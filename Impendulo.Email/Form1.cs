using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Net;
using System.Configuration;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;
using Outlook = Microsoft.Office.Interop.Outlook;
//using Office = Microsoft.Office.Core;

namespace Impendulo.Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Outlook.MailItem mail = null;
            //Outlook.Recipients mailRecipients = null;
            //Outlook.Recipient mailRecipient = null;
            //try
            //{
            //    mail = Application.CreateItem(Outlook.OlItemType.olMailItem)
            //        as Outlook.MailItem;
            //    mail.Subject = "A programatically generated e-mail";
            //    mailRecipients = mail.Recipients;
            //    mailRecipient = mailRecipients.Add("Eugene Astafiev");
            //    mailRecipient.Resolve();
            //    if (mailRecipient.Resolved)
            //    {
            //        mail.Send();
            //    }
            //    else
            //    {
            //        System.Windows.Forms.MessageBox.Show(
            //            "There is no such record in your address book.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message,
            //         "An exception is occured in the code of add-in.");
            //}
            //finally
            //{
            //    if (mailRecipient != null) Marshal.ReleaseComObject(mailRecipient);
            //    if (mailRecipients != null) Marshal.ReleaseComObject(mailRecipients);
            //    if (mail != null) Marshal.ReleaseComObject(mail);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            //mail.Attachments.Add(new Attachment())

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the Outlook application by using inline initialization.
                Outlook.Application oApp = new Outlook.Application();

                //Create the new message by using the simplest approach.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

                //Add a recipient.
                // TODO: Change the following recipient where appropriate.
                Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add("Brendanw@mweb.co.za");
                oRecip.Resolve();

                //Set the basic properties.
                oMsg.Subject = "This is the subject of the test message With modal Dialog";
                oMsg.Body = "TThis Is When outLook is Closed Testin if it Sends!!!!!!!!!\nversion 34235245";

                //Add an attachment.
                // TODO: change file path where appropriate
                String sSource = "C:\\Recovery.txt";
                String sDisplayName = "MyFirstAttachment";
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                Outlook.Attachment oAttach = oMsg.Attachments.Add(sSource, iAttachType, iPosition, sDisplayName);

                // If you want to, display the message.
                 //oMsg.Display(true);  //modal

                //Send the message.
                oMsg.Save();
                oMsg.Send();

                //Explicitly release objects.
                oRecip = null;
                oAttach = null;
                oMsg = null;
                oApp = null;
            }

            // Simple error handler.
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex, "");
                //Console.WriteLine("{0} Exception caught: ", ex);
            }

            //Default return value.
            //return 0;

        }

    }
}
