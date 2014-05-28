using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;

namespace yaping
{
  public partial class Form1 : Form
  {
    private AbortableBackgroundWorker bw;
    private TextWriter tw;
    private bool b_writeToFile = false;
    private bool b_timestamp = false;

    public Form1()
    {
      InitializeComponent();
    }

    private void btn_Start_Click(object sender, EventArgs e)
    {
      btn_Start.Text = "Stop Ping";
      btn_Start.Click -= btn_Start_Click;
      btn_Start.Click += btn_Stop_Click;
      tb_Result.Clear();

      bw = new AbortableBackgroundWorker();

      // this allows our worker to report progress during work
      bw.WorkerReportsProgress = true;

      // what to do in the background thread
      bw.DoWork += new DoWorkEventHandler(
      delegate(object o, DoWorkEventArgs args)
      {
        BackgroundWorker b = o as BackgroundWorker;

        // run ping() in an endless loop
        while (true)
        {
          b.ReportProgress(10, ping());
          Thread.Sleep(Convert.ToInt32(tb_Interval.Text));
        }

      });

      // what to do when progress changed (update the progress bar for example)
      bw.ProgressChanged += new ProgressChangedEventHandler(
      delegate(object o, ProgressChangedEventArgs args)
      {
        tb_Result.AppendText(string.Format("{0}", args.UserState));// = string.Format("{0}% Completed", args.ProgressPercentage);
        if (b_writeToFile)
          tw.Write(string.Format("{0}", args.UserState));
      });

      bw.RunWorkerAsync();
    }

    private void btn_Stop_Click(object sender, EventArgs e)
    {
      btn_Start.Text = "Start Ping";
      btn_Start.Click -= btn_Stop_Click;
      btn_Start.Click += btn_Start_Click;

      bw.Abort();
      bw.Dispose();

    }

    static bool ByteArrayCompare(byte[] a1, byte[] a2)
    {
      if (a1.Length != a2.Length)
        return false;

      for (int i = 0; i < a1.Length; i++)
        if (a1[i] != a2[i])
          return false;

      return true;
    }

    private string ping()
    {
      Ping pingSender = new Ping();
      PingOptions options = new PingOptions();

      string str_result;

      // Use the default Ttl value which is 128,
      // but change the fragmentation behavior.
      options.DontFragment = true;

      // Create a buffer of 32 bytes of data to be transmitted.
      byte[] buffer = Encoding.ASCII.GetBytes(RandomString(Convert.ToInt32(tb_szPayload.Text), false));
      int timeout = 120;
      PingReply reply = pingSender.Send(tb_IPaddr.Text, timeout, buffer, options);
      if (reply.Status == IPStatus.Success)
      {
        str_result = "";
        if (b_timestamp)
          str_result += String.Format("{0}: ", DateTime.Now.ToString("HH:mm:ss"));
        str_result += String.Format("{0}: ", reply.Address.ToString());
        str_result += String.Format("RoundTrip time: {0}, ", reply.RoundtripTime);
        //        tb_Result.AppendText(String.Format("Time to live: {0}, ", reply.Options.Ttl));
        //        tb_Result.AppendText(String.Format("Don't fragment: {0}\r\n", reply.Options.DontFragment));
        str_result += String.Format("Buffer size: {0}, ", reply.Buffer.Length);
        if (ByteArrayCompare(reply.Buffer, buffer))
        {
          str_result += "Payload OK!\r\n";
        }
        else
        {
          str_result += "Payload NOT OK!\r\n";
        }
      }
      else
      {
        str_result = "Ping failed\r\n";
      }
      return str_result;
    }

    public string RandomString(int size, bool lowerCase)
    {
      StringBuilder builder = new StringBuilder();
      Random random = new Random();
      char ch;
      for (int i = 0; i < size; i++)
      {
        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
        builder.Append(ch);
      }
      if (lowerCase)
        return builder.ToString().ToLower();
      return builder.ToString();
    }

    private void cb_LogOn_CheckedChanged(object sender, EventArgs e)
    {
      if (cb_LogOn.Checked)
      {
        tw = new StreamWriter(@"c:\temp\yapinglog.txt", true);
        b_writeToFile = true;
      }
      else
      {
        if (tw != null)
        {
          tw.Close();
          b_writeToFile = false;
        }

      }
    }

    private void cb_TimestampOn_CheckedChanged(object sender, EventArgs e)
    {
      if (cb_TimestampOn.Checked)
        b_timestamp = true;
      else
        b_timestamp = false;
    }
  }



  public class AbortableBackgroundWorker : BackgroundWorker
  {

    private Thread workerThread;

    protected override void OnDoWork(DoWorkEventArgs e)
    {
      workerThread = Thread.CurrentThread;
      try
      {
        base.OnDoWork(e);
      }
      catch (ThreadAbortException)
      {
        e.Cancel = true; //We must set Cancel property to true!
        Thread.ResetAbort(); //Prevents ThreadAbortException propagation
      }
    }


    public void Abort()
    {
      if (workerThread != null)
      {
        workerThread.Abort();
        workerThread = null;
      }
    }
  }
}
