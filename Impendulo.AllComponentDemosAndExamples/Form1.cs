using Impendulo.Common;
using Impendulo.Common.Enum;
using Impendulo.Common.FileHandeling;
using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.AllComponentDemosAndExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFiles();
        }

        private void loadFiles()
        {

            using (var Dbconnection = new MCDEntities())
            {
                var x = (from a in Dbconnection.Files
                         select new
                         {
                             ContentType = a.ContentType,
                             DateCreated = a.DateCreated,
                             FileExtension = a.FileExtension,
                             FileName = a.FileName,
                             ImageID = a.ImageID
                         }).ToList();
                List<Data.Models.File> ListOfAttachments = new List<Data.Models.File>();
                foreach (var a in x)
                {
                    ListOfAttachments.Add(new Data.Models.File
                    {
                        ImageID = a.ImageID,
                        ContentType = "",
                        DateCreated = a.DateCreated,
                        FileExtension = a.FileExtension,
                        FileName = a.FileName
                    });
                }

                fileBindingSource.DataSource = ListOfAttachments;

            };
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            List<File> UploadedFiles = FileHandeling.UploadFile();
            foreach (File CurrentFile in UploadedFiles)
            {
                /*
                 * Must Add Logic here to Link the inserted file to which ever entity that it maybe associated with.
                 * ****************************************************************************************************/
            }
            loadFiles();
        }

        private void btnEmailFile_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {

                //////// SMTPSetting EmailSettings = (from a in Dbconnection.SMTPSettings
                ////////                              select a).FirstOrDefault<SMTPSetting>();
                //////// CustomMailMessage NewMessage = new CustomMailMessage(
                ////////    "Brendanw@mweb.co.za",
                ////////     "Brendanw@mweb.co.za",
                ////////     "Attachment Form Database",
                ////////     "This Is A Test Message With Attachment Form Database");

                //////// NewMessage.DisplayName = EmailSettings.DisplayName;
                //////// NewMessage.PortNumber = EmailSettings.PortNumber;
                //////// NewMessage.Host = EmailSettings.SMTPHost;
                //////// NewMessage.UserName = EmailSettings.UserName;
                //////// NewMessage.Password = EmailSettings.Password;
                //////// NewMessage.RequireAuthentication = EmailSettings.RequireAuthentication;
                //////// NewMessage.RequireSSL = EmailSettings.RequiresSSL;

                ////////// NewMessage.AddAttachment(new EmailAttachmentMetaData(1032));

                //////// NewMessage.sendMessage();

                SMTPSetting EmailSettings = (from a in Dbconnection.SMTPSettings
                                             select a).FirstOrDefault<SMTPSetting>();
                CustomMailMessage NewMessage = new CustomMailMessage(
                    EmailSettings.FromAddress,
                    "Brendanw@mweb.co.za",
                    "Test Message",
                    "Content");

                NewMessage.DisplayName = EmailSettings.DisplayName;
                NewMessage.PortNumber = EmailSettings.PortNumber;
                NewMessage.Host = EmailSettings.SMTPHost;
                NewMessage.UserName = EmailSettings.UserName;
                NewMessage.Password = EmailSettings.Password;
                NewMessage.RequireAuthentication = EmailSettings.RequireAuthentication;
                NewMessage.RequireSSL = EmailSettings.RequiresSSL;

                //add an attachment that is linked to the data base
                NewMessage.AddAttachment(new EmailAttachmentMetaData(((Data.Models.File)fileBindingSource.Current).ImageID));
               

                NewMessage.sendMessage();
            };
        }
    }
}
