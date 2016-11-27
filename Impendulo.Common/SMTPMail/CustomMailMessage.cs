using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using System.IO;


/*
  Links for help...
  https://msdn.microsoft.com/en-us/library/system.net.mail.smtpclient(v=vs.110).aspx
  https://msdn.microsoft.com/en-us/library/swas0fwc(v=vs.110).aspx

 */
namespace Impendulo.Common
{

    public class CustomMailMessage
    {


        public Boolean MailSent
        {
            get { return _mailSent; }
        }
        public string CancelMessage
        {
            get { return _CanceledMmessage; }
        }
        public string ErrorMessage
        {
            get { return ErrorMessage; }
        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                _CanceledMmessage = "[" + token + "] Send canceled.";
            }
            if (e.Error != null)
            {
                _ErrorMessage = token.ToString() + " - " + e.Error.ToString();
                System.Windows.Forms.MessageBox.Show(_ErrorMessage);
            }
            else
            {
                _mailSent = true;
                //prefrom action here
                System.Windows.Forms.MessageBox.Show("Email Sent...!!");
            }

        }
        public void CancelMessageSend()
        {
            if (_mailSent == false && client != null)
            {
                client.SendAsyncCancel();
            }
        }


        #region Internal Vairables
        private static Boolean _mailSent = false;
        private static string _CanceledMmessage = "";
        private static string _ErrorMessage = "";
        private SmtpClient client = null;

        private int _Port = 25;
        private string _Host = "";
        private Boolean _RequireAuthentication = false;
        private Boolean _RequiresSSL = false;
        private string _FromAddress = "";
        private string _UserName = "";
        private string _Password = "";
        private string _MessageBody = "";
        private string _Subject = "";
        private string _DisplayName = "";
        private List<System.Net.Mail.Attachment> _Attachments = null;
        private List<EmailAttachmentMetaData> EmailAttachments { get; set; }
        #endregion


        #region Eamil Message Properties
        public string FromAddress
        {
            get { return _FromAddress; }
            set { _FromAddress = value; }
        }
        public string ToAddress { get; set; }
        public string Subject
        {
            set { _Subject = value; }
            get { return _Subject; }
        }
        public string Body
        {
            get { return _MessageBody; }
            set { _MessageBody = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public Boolean RequireAuthentication
        {
            get { return _RequireAuthentication; }
            set { _RequireAuthentication = value; }
        }
        public int PortNumber
        {
            get { return _Port; }
            set { _Port = value; }
        }
        public string Host
        {
            get { return _Host; }
            set { _Host = value; }
        }
        public Boolean RequireSSL
        {
            get { return _RequiresSSL; }
            set { _RequiresSSL = value; }
        }
        public string DisplayName
        {
            get { return _DisplayName; }
            set { _DisplayName = value; }
        }
        #endregion


        public void AddAttachment(EmailAttachmentMetaData MessageAttachment)
        {
            if (EmailAttachments == null)
            {
                EmailAttachments = new List<EmailAttachmentMetaData>();
            }
            EmailAttachments.Add(MessageAttachment);
        }
        #region Constructors
        public CustomMailMessage(string FromAddress, string ToAddress)
        {
            this.FromAddress = FromAddress;
            this.ToAddress = ToAddress;
        }
        public CustomMailMessage(string FromAddress, string ToAddress, String Subject)
        {
            this.FromAddress = FromAddress;
            this.ToAddress = ToAddress;
            this.Subject = Subject;
        }
        public CustomMailMessage(string FromAddress, string ToAddress, String Subject, string Body)
        {
            this.FromAddress = FromAddress;
            this.ToAddress = ToAddress;
            this.Subject = Subject;
            this.Body = Body;
        }
        #endregion



        /// <summary>
        /// Send Email Message, Providing the SMTP Host Address and the Required Port Number Default is: 25.
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="Port"></param>
        public void sendMessage(string Host, int Port)
        {
            this.PortNumber = Port;
            this.Host = Host;
            sendMessage();
        }
        public void sendMessage(string Host, int Port, string toAddress)
        {
            this.PortNumber = Port;
            this.Host = Host;
            this.ToAddress = ToAddress;
            sendMessage();
        }
        public void sendMessage()
        {
            MailMessage mail = new MailMessage();
            client = new SmtpClient(this.Host, this.PortNumber);
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            if (this.DisplayName.Length > 0)
            {
                mail.From = new MailAddress(this.FromAddress, this.DisplayName);
            }
            else
            {
                mail.From = new MailAddress(this.FromAddress);
            }


            string[] items = this.ToAddress.Split(';');
            if (items.Length > 0)
            {
                foreach (string EAddress in items)
                {
                    if (EAddress.Length > 0)
                    {
                        mail.To.Add(EAddress.Trim());
                    }
                }
            }
            else
            {
                mail.To.Add(this.ToAddress.Trim());
            }



            mail.Subject = this.Subject;
            mail.Body = this.Body;

            ////Depreciated will be remove soon - 10 April 2017
            //if (_Attachments != null)
            //{
            //    foreach (Attachment myAttachment in _Attachments)
            //    { mail.Attachments.Add(myAttachment); }
            //}

            if (EmailAttachments != null)
            {
                List<int> AddFileID = new List<int>();
                foreach (EmailAttachmentMetaData myAttachment in EmailAttachments)
                {
                    if (myAttachment.CurrentAttachmentType == AttachmentType.PathBasedAttachment)
                    {
                        mail.Attachments.Add(new Attachment(myAttachment.AttachmentPath));
                    }
                    if (myAttachment.CurrentAttachmentType == AttachmentType.DatabaseImageAttachment)
                    {
                        try
                        {
                            using (var Dbconnection = new MCDEntities())
                            {
                                Data.Models.File FileImage = (from a in Dbconnection.Files
                                                              where a.ImageID == myAttachment.DatabaseFileID
                                                              select a).FirstOrDefault();

                                MemoryStream ms = new MemoryStream(FileImage.FileImage);
                                string sFileName = FileImage.FileName + "." + FileImage.FileExtension;
                                mail.Attachments.Add(new Attachment(ms, sFileName));
                            };
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show("Error getting attachment from database : " + ex.Message);
                        }
                    }
                }
            }


            if (RequireAuthentication)
            { client.Credentials = new System.Net.NetworkCredential(UserName, Password); }
            if (this.RequireSSL)
            { client.EnableSsl = true; }

            int retryCount = 0; ;
            try
            {
                // string userState = "test message1";

                client.SendAsync(mail, "Start");
            }
            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i < ex.InnerExceptions.Length; i++)
                {
                    SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                    if (status == SmtpStatusCode.MailboxBusy || status == SmtpStatusCode.MailboxUnavailable)
                    {
                        System.Windows.Forms.MessageBox.Show("Delivery failed - retrying in 5 seconds. Retry Attempt " + retryCount + 1 + "of 3.", "Connection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1);
                        //System.Threading.Thread.Sleep(1);
                        if (retryCount < 2)
                        {
                            string userState = "test message1";
                            client.SendAsync(mail, userState);
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Failed to deliver message to {0}",
                            ex.InnerExceptions[i].FailedRecipient, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Exception caught in RetryIfBusy(): {0}",
                        ex.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

    }
}
