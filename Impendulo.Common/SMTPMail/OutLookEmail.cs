using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Impendulo.Common.SMTPMail
{
    class OutLookEmail
    {
        private void sendMessage()
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
        }
    }
}
