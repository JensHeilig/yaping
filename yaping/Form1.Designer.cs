namespace yaping
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.tb_IPaddr = new System.Windows.Forms.TextBox();
      this.btn_Start = new System.Windows.Forms.Button();
      this.tb_Result = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tb_szPayload = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tb_Interval = new System.Windows.Forms.MaskedTextBox();
      this.cb_LogOn = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cb_TimestampOn = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 53);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "IP-address:";
      // 
      // tb_IPaddr
      // 
      this.tb_IPaddr.Location = new System.Drawing.Point(88, 50);
      this.tb_IPaddr.Name = "tb_IPaddr";
      this.tb_IPaddr.Size = new System.Drawing.Size(141, 20);
      this.tb_IPaddr.TabIndex = 1;
      this.tb_IPaddr.Text = "127.0.0.1";
      // 
      // btn_Start
      // 
      this.btn_Start.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btn_Start.Location = new System.Drawing.Point(418, 263);
      this.btn_Start.Name = "btn_Start";
      this.btn_Start.Size = new System.Drawing.Size(75, 23);
      this.btn_Start.TabIndex = 5;
      this.btn_Start.Text = "Start Ping";
      this.btn_Start.UseVisualStyleBackColor = true;
      this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
      // 
      // tb_Result
      // 
      this.tb_Result.BackColor = System.Drawing.SystemColors.Window;
      this.tb_Result.Location = new System.Drawing.Point(16, 140);
      this.tb_Result.Multiline = true;
      this.tb_Result.Name = "tb_Result";
      this.tb_Result.ReadOnly = true;
      this.tb_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tb_Result.Size = new System.Drawing.Size(396, 146);
      this.tb_Result.TabIndex = 5;
      this.tb_Result.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(168, 24);
      this.label2.TabIndex = 4;
      this.label2.Text = "Yet Another Ping";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 79);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Payload size:";
      // 
      // tb_szPayload
      // 
      this.tb_szPayload.Location = new System.Drawing.Point(88, 76);
      this.tb_szPayload.Name = "tb_szPayload";
      this.tb_szPayload.Size = new System.Drawing.Size(141, 20);
      this.tb_szPayload.TabIndex = 2;
      this.tb_szPayload.Text = "64";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 105);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Interval (ms):";
      // 
      // tb_Interval
      // 
      this.tb_Interval.HidePromptOnLeave = true;
      this.tb_Interval.Location = new System.Drawing.Point(88, 102);
      this.tb_Interval.Mask = "999990";
      this.tb_Interval.Name = "tb_Interval";
      this.tb_Interval.PromptChar = ' ';
      this.tb_Interval.RejectInputOnFirstFailure = true;
      this.tb_Interval.Size = new System.Drawing.Size(141, 20);
      this.tb_Interval.TabIndex = 3;
      this.tb_Interval.Text = "100";
      // 
      // cb_LogOn
      // 
      this.cb_LogOn.AutoSize = true;
      this.cb_LogOn.Location = new System.Drawing.Point(419, 140);
      this.cb_LogOn.Name = "cb_LogOn";
      this.cb_LogOn.Size = new System.Drawing.Size(75, 17);
      this.cb_LogOn.TabIndex = 4;
      this.cb_LogOn.Text = "Log to File";
      this.cb_LogOn.UseVisualStyleBackColor = true;
      this.cb_LogOn.CheckedChanged += new System.EventHandler(this.cb_LogOn_CheckedChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(247, 44);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(246, 78);
      this.label5.TabIndex = 6;
      this.label5.Text = resources.GetString("label5.Text");
      // 
      // cb_TimestampOn
      // 
      this.cb_TimestampOn.AutoSize = true;
      this.cb_TimestampOn.Location = new System.Drawing.Point(419, 163);
      this.cb_TimestampOn.Name = "cb_TimestampOn";
      this.cb_TimestampOn.Size = new System.Drawing.Size(77, 17);
      this.cb_TimestampOn.TabIndex = 4;
      this.cb_TimestampOn.Text = "Timestamp";
      this.cb_TimestampOn.UseVisualStyleBackColor = true;
      this.cb_TimestampOn.CheckedChanged += new System.EventHandler(this.cb_TimestampOn_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(505, 298);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.cb_TimestampOn);
      this.Controls.Add(this.cb_LogOn);
      this.Controls.Add(this.tb_Interval);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tb_Result);
      this.Controls.Add(this.btn_Start);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tb_szPayload);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tb_IPaddr);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Yet another Ping";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tb_IPaddr;
    private System.Windows.Forms.Button btn_Start;
    private System.Windows.Forms.TextBox tb_Result;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tb_szPayload;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.MaskedTextBox tb_Interval;
    private System.Windows.Forms.CheckBox cb_LogOn;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox cb_TimestampOn;
  }
}

