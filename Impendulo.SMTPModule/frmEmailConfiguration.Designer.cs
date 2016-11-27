namespace Impendulo.SMTPModule.Development
{
    partial class frmEmailConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmailConfiguration));
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picConnectionPassed = new System.Windows.Forms.PictureBox();
            this.lblCheckingConnection = new System.Windows.Forms.Label();
            this.txtFromAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnSaveMailSettings = new System.Windows.Forms.Button();
            this.chkUseSSLConnection = new System.Windows.Forms.CheckBox();
            this.btnTestMailSettings = new System.Windows.Forms.Button();
            this.txtDisdplayName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkAuthenticationRequired = new System.Windows.Forms.CheckBox();
            this.txtSMTPHostAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabEmailSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTestingToAddress = new System.Windows.Forms.TextBox();
            this.btnSendTestMessage = new System.Windows.Forms.Button();
            this.txtTestMessage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTestSubject = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialogForAttachments = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogForAttachments = new System.Windows.Forms.OpenFileDialog();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionPassed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabEmailSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Location = new System.Drawing.Point(95, 162);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(42, 20);
            this.txtPortNumber.TabIndex = 0;
            this.txtPortNumber.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Default 25)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.txtFromAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnSaveMailSettings);
            this.groupBox1.Controls.Add(this.chkUseSSLConnection);
            this.groupBox1.Controls.Add(this.btnTestMailSettings);
            this.groupBox1.Controls.Add(this.txtDisdplayName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSMTPHostAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPortNumber);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMTP Settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.picConnectionPassed);
            this.flowLayoutPanel1.Controls.Add(this.lblCheckingConnection);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(125, 322);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(36, 25);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // picConnectionPassed
            // 
            this.picConnectionPassed.Image = ((System.Drawing.Image)(resources.GetObject("picConnectionPassed.Image")));
            this.picConnectionPassed.Location = new System.Drawing.Point(3, 3);
            this.picConnectionPassed.Name = "picConnectionPassed";
            this.picConnectionPassed.Size = new System.Drawing.Size(30, 23);
            this.picConnectionPassed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConnectionPassed.TabIndex = 16;
            this.picConnectionPassed.TabStop = false;
            this.picConnectionPassed.Visible = false;
            // 
            // lblCheckingConnection
            // 
            this.lblCheckingConnection.AutoSize = true;
            this.lblCheckingConnection.Location = new System.Drawing.Point(3, 29);
            this.lblCheckingConnection.Name = "lblCheckingConnection";
            this.lblCheckingConnection.Size = new System.Drawing.Size(29, 91);
            this.lblCheckingConnection.TabIndex = 17;
            this.lblCheckingConnection.Text = "Checking Please Wait!!";
            // 
            // txtFromAddress
            // 
            this.txtFromAddress.Location = new System.Drawing.Point(92, 50);
            this.txtFromAddress.Name = "txtFromAddress";
            this.txtFromAddress.Size = new System.Drawing.Size(324, 20);
            this.txtFromAddress.TabIndex = 15;
            this.txtFromAddress.Text = "info@mcdtraining.co.za";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "From Address:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Location = new System.Drawing.Point(15, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 77);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Required Port number Summary";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(3, 16);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(404, 58);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "IMAP uses port 143 , but SSL/TLS encrypted IMAP uses port 993 . POP uses port 110" +
    " , but SSL/TLS encrypted POP uses port 995 . SMTP uses port 25 , but SSL/TLS enc" +
    "rypted SMTP uses port 465 .";
            // 
            // btnSaveMailSettings
            // 
            this.btnSaveMailSettings.Location = new System.Drawing.Point(299, 324);
            this.btnSaveMailSettings.Name = "btnSaveMailSettings";
            this.btnSaveMailSettings.Size = new System.Drawing.Size(126, 23);
            this.btnSaveMailSettings.TabIndex = 10;
            this.btnSaveMailSettings.Text = "Save Mail Settings";
            this.btnSaveMailSettings.UseVisualStyleBackColor = true;
            this.btnSaveMailSettings.Click += new System.EventHandler(this.btnSaveMailSettings_Click);
            // 
            // chkUseSSLConnection
            // 
            this.chkUseSSLConnection.AutoSize = true;
            this.chkUseSSLConnection.Location = new System.Drawing.Point(211, 164);
            this.chkUseSSLConnection.Name = "chkUseSSLConnection";
            this.chkUseSSLConnection.Size = new System.Drawing.Size(125, 17);
            this.chkUseSSLConnection.TabIndex = 9;
            this.chkUseSSLConnection.Text = "Use SSL Connection";
            this.chkUseSSLConnection.UseVisualStyleBackColor = true;
            this.chkUseSSLConnection.CheckedChanged += new System.EventHandler(this.chkUseSSLConnection_CheckedChanged);
            // 
            // btnTestMailSettings
            // 
            this.btnTestMailSettings.Location = new System.Drawing.Point(167, 324);
            this.btnTestMailSettings.Name = "btnTestMailSettings";
            this.btnTestMailSettings.Size = new System.Drawing.Size(126, 23);
            this.btnTestMailSettings.TabIndex = 8;
            this.btnTestMailSettings.Text = "Test Mail Settings";
            this.btnTestMailSettings.UseVisualStyleBackColor = true;
            this.btnTestMailSettings.Click += new System.EventHandler(this.btnTestMailSettings_Click);
            // 
            // txtDisdplayName
            // 
            this.txtDisdplayName.Location = new System.Drawing.Point(92, 24);
            this.txtDisdplayName.Name = "txtDisdplayName";
            this.txtDisdplayName.Size = new System.Drawing.Size(192, 20);
            this.txtDisdplayName.TabIndex = 7;
            this.txtDisdplayName.Text = "MCD Notifications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Display Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.chkAuthenticationRequired);
            this.groupBox2.Location = new System.Drawing.Point(18, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 104);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(68, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(331, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(68, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(331, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // chkAuthenticationRequired
            // 
            this.chkAuthenticationRequired.AutoSize = true;
            this.chkAuthenticationRequired.Checked = true;
            this.chkAuthenticationRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuthenticationRequired.Location = new System.Drawing.Point(6, 19);
            this.chkAuthenticationRequired.Name = "chkAuthenticationRequired";
            this.chkAuthenticationRequired.Size = new System.Drawing.Size(69, 17);
            this.chkAuthenticationRequired.TabIndex = 0;
            this.chkAuthenticationRequired.Text = "Required";
            this.chkAuthenticationRequired.UseVisualStyleBackColor = true;
            this.chkAuthenticationRequired.CheckedChanged += new System.EventHandler(this.chkAuthenticationRequired_CheckedChanged);
            // 
            // txtSMTPHostAddress
            // 
            this.txtSMTPHostAddress.Location = new System.Drawing.Point(95, 188);
            this.txtSMTPHostAddress.Name = "txtSMTPHostAddress";
            this.txtSMTPHostAddress.Size = new System.Drawing.Size(321, 20);
            this.txtSMTPHostAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SMTP Server:";
            // 
            // tabEmailSettings
            // 
            this.tabEmailSettings.Controls.Add(this.tabPage1);
            this.tabEmailSettings.Controls.Add(this.tabPage2);
            this.tabEmailSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmailSettings.Location = new System.Drawing.Point(0, 0);
            this.tabEmailSettings.Name = "tabEmailSettings";
            this.tabEmailSettings.SelectedIndex = 0;
            this.tabEmailSettings.Size = new System.Drawing.Size(454, 394);
            this.tabEmailSettings.TabIndex = 4;
            this.tabEmailSettings.SelectedIndexChanged += new System.EventHandler(this.tabEmailSettings_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test Message";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txtTestSubject);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtTestMessage);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnSendTestMessage);
            this.groupBox4.Controls.Add(this.txtTestingToAddress);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 362);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send Test Message";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Send To Address:";
            // 
            // txtTestingToAddress
            // 
            this.txtTestingToAddress.Location = new System.Drawing.Point(105, 19);
            this.txtTestingToAddress.Name = "txtTestingToAddress";
            this.txtTestingToAddress.Size = new System.Drawing.Size(329, 20);
            this.txtTestingToAddress.TabIndex = 1;
            // 
            // btnSendTestMessage
            // 
            this.btnSendTestMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnSendTestMessage.Image")));
            this.btnSendTestMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendTestMessage.Location = new System.Drawing.Point(269, 187);
            this.btnSendTestMessage.Name = "btnSendTestMessage";
            this.btnSendTestMessage.Size = new System.Drawing.Size(165, 47);
            this.btnSendTestMessage.TabIndex = 2;
            this.btnSendTestMessage.Text = "Send Mail";
            this.btnSendTestMessage.UseVisualStyleBackColor = true;
            this.btnSendTestMessage.Click += new System.EventHandler(this.btnSendTestMessage_Click);
            // 
            // txtTestMessage
            // 
            this.txtTestMessage.Location = new System.Drawing.Point(105, 71);
            this.txtTestMessage.Multiline = true;
            this.txtTestMessage.Name = "txtTestMessage";
            this.txtTestMessage.Size = new System.Drawing.Size(329, 110);
            this.txtTestMessage.TabIndex = 4;
            this.txtTestMessage.Text = "Standar Test Message";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Test Message:";
            // 
            // txtTestSubject
            // 
            this.txtTestSubject.Location = new System.Drawing.Point(105, 45);
            this.txtTestSubject.Name = "txtTestSubject";
            this.txtTestSubject.Size = new System.Drawing.Size(329, 20);
            this.txtTestSubject.TabIndex = 6;
            this.txtTestSubject.Text = "MCD Test Message";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Subject:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstAttachments);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 119);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "List Of Attachments";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(105, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Attachments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogForAttachments
            // 
            this.openFileDialogForAttachments.FileName = "openFileDialog1";
            this.openFileDialogForAttachments.Multiselect = true;
            // 
            // lstAttachments
            // 
            this.lstAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.Location = new System.Drawing.Point(3, 16);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(428, 100);
            this.lstAttachments.TabIndex = 0;
            // 
            // frmEmailConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 394);
            this.Controls.Add(this.tabEmailSettings);
            this.Name = "frmEmailConfiguration";
            this.Text = "Email Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionPassed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabEmailSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSMTPHostAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chkAuthenticationRequired;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnSaveMailSettings;
        private System.Windows.Forms.CheckBox chkUseSSLConnection;
        private System.Windows.Forms.Button btnTestMailSettings;
        private System.Windows.Forms.TextBox txtDisdplayName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFromAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picConnectionPassed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCheckingConnection;
        private System.Windows.Forms.TabControl tabEmailSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTestingToAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSendTestMessage;
        private System.Windows.Forms.TextBox txtTestSubject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTestMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.SaveFileDialog saveFileDialogForAttachments;
        private System.Windows.Forms.OpenFileDialog openFileDialogForAttachments;
        private System.Windows.Forms.ListBox lstAttachments;
    }
}

