using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Data.Models;
using Impendulo.Common;
using System.IO;
using Impendulo.Email.Select_Contacts.Development;
using Impendulo.Common.Enum;

namespace Impendulo.Email.Development
{
    public partial class frmSendEmail : Form
    {

        public List<string> AttachmentsUsingFilePaths { get; set; }
        public List<int> AttachmentsUsingDbImageFileID { get; set; }

        private List<CustomFileAttributtes> AllFileAttachments = new List<CustomFileAttributtes>();
        public frmSendEmail()
        {
            InitializeComponent();
            if (AttachmentsUsingFilePaths == null)
            {
                AttachmentsUsingFilePaths = new List<string>();
            }
            if (AttachmentsUsingDbImageFileID == null)
            {
                AttachmentsUsingDbImageFileID = new List<int>();
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (txtTestingToAddress.Text.Length > 0 && txtTestSubject.Text.Length > 0)
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

                    foreach (string path in AttachmentsUsingFilePaths)
                    {
                        NewMessage.AddAttachment(new EmailAttachmentMetaData(path));
                       // NewMessage.AddAttachment(new System.Net.Mail.Attachment(path));
                    }
                    NewMessage.sendMessage();
                };
            }
            else
            {
                MessageBox.Show("Ensure that To Address and Subject Is Completed!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmSendEmail_Load(object sender, EventArgs e)
        {

            this.refreshAttachemntListUsingDatabaseFileID();
            this.refreshTheAttachmentList();
        }

        public class CustomFileAttributtes
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public AttachmentType AttachmentType { get; set; }
            public EmailAttachmentMetaData CurrentAttachment { get; set; }
        }

        private void refreshTheAttachmentList()
        {
            this.refreshAttachemntListUsingFilePaths();
            this.FileAttachmentBindingSource.DataSource = AllFileAttachments.OrderBy(a => a.FileName).ToList<CustomFileAttributtes>();
        }
        private void refreshAttachemntListUsingDatabaseFileID()
        {
            using (var Dbconnection = new MCDEntities())
            {
                foreach (int _ImageFileID in AttachmentsUsingDbImageFileID)
                {
                    var CurrentImageFile = (from a in Dbconnection.Files
                                            where a.ImageID == _ImageFileID
                                            select new
                                            {
                                                ImageID = a.ImageID,
                                                FileExtension = a.FileExtension,
                                                FileName = a.FileName,
                                                DateCreated = a.DateCreated

                                            }).FirstOrDefault(); ;

                    AllFileAttachments.Add(new CustomFileAttributtes
                    {
                        FileName = CurrentImageFile.FileName + "." + CurrentImageFile.FileExtension,
                        FilePath = "Retrieved From The Database",
                        AttachmentType = AttachmentType.DatabaseImageAttachment,
                        CurrentAttachment = new EmailAttachmentMetaData(_ImageFileID)
                    });
                }
            };
        }
        private void refreshAttachemntListUsingFilePaths()
        {

            Char delimiter = '.';

            foreach (string FilePath in AttachmentsUsingFilePaths)
            {
                FileInfo fileInfo = new FileInfo(FilePath);

                AllFileAttachments.Add(new CustomFileAttributtes
                {
                    FileName = fileInfo.Name.Split(delimiter)[0] + fileInfo.Extension,
                    FilePath = FilePath,
                    AttachmentType = AttachmentType.PathBasedAttachment,
                    CurrentAttachment = new EmailAttachmentMetaData(FilePath)

                });
            }

        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            openFileDialogForAttachments.InitialDirectory = "";
            openFileDialogForAttachments.Reset();
            openFileDialogForAttachments.Title = "Select Email Attachments Using File Paths";
            openFileDialogForAttachments.ShowDialog();
            foreach (string file in openFileDialogForAttachments.FileNames)
            {
                AttachmentsUsingFilePaths.Add(file);
            }
            this.refreshTheAttachmentList();
        }

        private void dgvFileAttachments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CustomFileAttributte = (CustomFileAttributtes)(row.DataBoundItem);
                    row.Cells[FileName.Index].Value = CustomFileAttributte.FileName.ToString();
                    row.Cells[FilePath.Index].Value = CustomFileAttributte.FilePath.ToString();
                    if (CustomFileAttributte.AttachmentType == AttachmentType.PathBasedAttachment)
                    {
                        row.Cells[colRemoveAttachments.Index].Value = "Remove";
                    }
                    else
                    {
                        row.Cells[colRemoveAttachments.Index].Value = "";
                    }

                }
            }
        }

        private void dgvFileAttachments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                AttachmentsUsingFilePaths.RemoveAt(e.RowIndex);
                this.refreshAttachemntListUsingFilePaths();

            }

        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            frmSelectEmailContacts frm = new frmSelectEmailContacts();
            frm.ShowDialog();
            List<string> EmailAddresses = (from a in frm.SelectedContacts
                                           from b in a.ContactDetails
                                           where b.ContactTypeID == (int)Common.Enum.EnumContactTypes.Email_Address
                                           select b.ContactDetailValue).ToList<string>();
            string ContactEmailaddresses = "";
            foreach (string _EmailAddress in EmailAddresses)
            {
                if (ContactEmailaddresses.Length > 0)
                {
                    ContactEmailaddresses += "; ";
                }
                ContactEmailaddresses += _EmailAddress;
            }
            //if (ContactEmailaddresses.Length > 0)
            //{
            //    ContactEmailaddresses += ";";
            //}

            this.txtTestingToAddress.Text = ContactEmailaddresses;
        }
    }
}
