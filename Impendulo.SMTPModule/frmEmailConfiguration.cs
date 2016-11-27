using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impendulo.Common;
using System.Windows.Forms;
using Impendulo.Data.Models;
using Impendulo.Common.SMTPMail;
using Impendulo.Common.Enum;

namespace Impendulo.SMTPModule.Development
{
    public partial class frmEmailConfiguration : Form
    {
        public string toAddressForTesting { get; set; }
        public frmEmailConfiguration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SMTPSetting CurrentSettings = null;
            using (var Dbconnection = new MCDEntities())
            {
                CurrentSettings = (from a in Dbconnection.SMTPSettings
                                   select a).FirstOrDefault<SMTPSetting>();
            };
            if (CurrentSettings != null)
            {
                txtDisdplayName.Text = CurrentSettings.DisplayName;
                txtFromAddress.Text = CurrentSettings.FromAddress;
                txtPortNumber.Text = CurrentSettings.PortNumber.ToString();
                txtSMTPHostAddress.Text = CurrentSettings.SMTPHost;
                chkUseSSLConnection.Checked = CurrentSettings.RequiresSSL;
                chkAuthenticationRequired.Checked = CurrentSettings.RequireAuthentication;
                setAuthenticationControls();
                txtUserName.Text = CurrentSettings.UserName;
                txtPassword.Text = CurrentSettings.Password;
            }

        }


        private void btnTestMailSettings_Click(object sender, EventArgs e)
        {
            this.saveEmailSettings();

            SMTPSetting EmailSettings;
            using (var Dbconnection = new MCDEntities())
            {
                EmailSettings = (from a in Dbconnection.SMTPSettings
                                 select a).FirstOrDefault<SMTPSetting>();

            };
            lblCheckingConnection.Visible = true;
            picConnectionPassed.Visible = false;

            if (SmtpHelper.TestConnection(EmailSettings.SMTPHost, EmailSettings.PortNumber))
            {
                lblCheckingConnection.Visible = false;
                picConnectionPassed.Visible = true;
            }
            else
            {
                lblCheckingConnection.Visible = false;
                picConnectionPassed.Visible = false;
            }
        }

        private void btnSaveMailSettings_Click(object sender, EventArgs e)
        {
            saveEmailSettings();
        }

        private void saveEmailSettings()
        {

            using (var Dbconnection = new MCDEntities())
            {
                SMTPSetting EmailSettings;
                EmailSettings = (from a in Dbconnection.SMTPSettings
                                 select a).FirstOrDefault<SMTPSetting>();
                if (EmailSettings == null)
                {
                    SMTPSetting NewSettings = new SMTPSetting
                    {
                        FromAddress = txtFromAddress.Text,
                        PortNumber = Convert.ToInt32(txtPortNumber.Text),
                        RequiresSSL = chkUseSSLConnection.Checked,
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                        RequireAuthentication = chkAuthenticationRequired.Checked,
                        SMTPHost = txtSMTPHostAddress.Text
                    };
                    Dbconnection.SMTPSettings.Add(NewSettings);
                    Dbconnection.SaveChanges();
                }
                else
                {
                    EmailSettings.FromAddress = txtFromAddress.Text;
                    EmailSettings.PortNumber = Convert.ToInt32(txtPortNumber.Text);
                    EmailSettings.RequiresSSL = chkUseSSLConnection.Checked;
                    EmailSettings.UserName = txtUserName.Text;
                    EmailSettings.Password = txtPassword.Text;
                    EmailSettings.RequireAuthentication = chkAuthenticationRequired.Checked;
                    EmailSettings.SMTPHost = txtSMTPHostAddress.Text;

                    Dbconnection.SaveChanges();
                }

            };
        }

        private void chkUseSSLConnection_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseSSLConnection.Checked)
            {
                txtPortNumber.Text = "465";
            }
            else
            {
                txtPortNumber.Text = "25";
            }
        }

        private void setAuthenticationControls()
        {
            if (chkAuthenticationRequired.Checked)
            {
                //txtUserName.Clear();
                //txtPassword.Clear();
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                //txtUserName.Clear();
                //txtPassword.Clear();
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
        }
        private void chkAuthenticationRequired_CheckedChanged(object sender, EventArgs e)
        {
            setAuthenticationControls();
        }

        private void tabEmailSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmailSettings.TabIndex == 1)
            {
                SMTPSetting Emailsettings;
                using (var Dbconnection = new MCDEntities())
                {
                    Emailsettings = (from a in Dbconnection.SMTPSettings
                                     select a).FirstOrDefault<SMTPSetting>();
                };
                if (Emailsettings != null)
                {

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please Set The Settings First!");
                }
            }
        }

        private void btnSendTestMessage_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {

                SMTPSetting EmailSettings = (from a in Dbconnection.SMTPSettings
                                             select a).FirstOrDefault<SMTPSetting>();
                CustomMailMessage NewMessage = new CustomMailMessage(
                    EmailSettings.FromAddress,
                    this.txtTestingToAddress.Text,
                    this.txtTestSubject.Text,
                    this.txtTestMessage.Text);

                NewMessage.DisplayName = EmailSettings.DisplayName;
                NewMessage.PortNumber = EmailSettings.PortNumber;
                NewMessage.Host = EmailSettings.SMTPHost;
                NewMessage.UserName = EmailSettings.UserName;
                NewMessage.Password = EmailSettings.Password;
                NewMessage.RequireAuthentication = EmailSettings.RequireAuthentication;
                NewMessage.RequireSSL = EmailSettings.RequiresSSL;
                foreach (string path in lstAttachments.Items)
                {
                    NewMessage.AddAttachment(new EmailAttachmentMetaData(path));
                }
                NewMessage.sendMessage();
            };

        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogForAttachments.ShowDialog();
            foreach (string file in openFileDialogForAttachments.FileNames)
            {
                lstAttachments.Items.Add(file);
            }
        }
    }
}
