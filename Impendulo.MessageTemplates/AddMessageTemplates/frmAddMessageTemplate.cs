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

namespace Impendulo.MessageTemplates.Development.AddMessageTemplates
{
    public partial class frmAddMessageTemplate : Form
    {
        private MessageTemplate _CurrentMessageTemplate;

        public Boolean MessageCreated;

        public MessageTemplate CurrentMessageTemplate
        {
            get
            {
                if (_CurrentMessageTemplate == null)
                {
                    _CurrentMessageTemplate = new MessageTemplate();
                }
                return _CurrentMessageTemplate;
            }
            set { _CurrentMessageTemplate = value; }
        }



        private List<FileInfo> CurrentMessageAttachmentFileInfo = new List<FileInfo>();

        public frmAddMessageTemplate()
        {
            MessageCreated = false;
            InitializeComponent();
        }

        private void frmAddMessageTemplate_Load(object sender, EventArgs e)
        {
            //txtMessage.SaveFile(("C:\\Viso Key.docx");

        }

        private void refreshMessageAttachemnts()
        {
            if (CurrentMessageAttachmentFileInfo.Count > 0)
            {
                populateMessageAttachments();
            }
            else
            {
                filesBindingSource.Clear();
            }
        }

        private void populateMessageAttachments()
        {

            List<Data.Models.File> res = (from a in CurrentMessageAttachmentFileInfo
                                          select new Data.Models.File
                                          {
                                              ImageID = 0,
                                              FileImage = null,
                                              ContentType = "",
                                              DateCreated = DateTime.Now,
                                              FileName = a.Name.Substring(0, a.Name.LastIndexOf(".")),
                                              FileExtension = a.Extension.Replace(".", "")
                                          }
                       ).ToList<Data.Models.File>();
            filesBindingSource.DataSource = res;
        }


        private void btnSetItalic_Click(object sender, EventArgs e)
        {

        }

        private void btnSetBold_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAtachment_Click(object sender, EventArgs e)
        {
            this.openFileDialogForAttachments.ShowDialog();
            if (openFileDialogForAttachments.FileNames.Count() > 0)
            {
                foreach (string LocalFileName in openFileDialogForAttachments.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(LocalFileName);
                    CurrentMessageAttachmentFileInfo.Add(fileInfo);
                }

            }
            this.refreshMessageAttachemnts();
        }

        private void btnRemoveAttachemnt_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveMessageTmeplate_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length == 0)
            {
                MessageBox.Show("Please Complete the message text, before the message can be added!", "Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //add data to new Message Template.
                CurrentMessageTemplate.Message = this.txtMessage.Text.ToString();
                foreach (FileInfo x in CurrentMessageAttachmentFileInfo)
                {
                    FileInfo fileInfo = new FileInfo(x.FullName);
                    FileStream fs;
                    BinaryReader br;
                    Byte[] fileToUpload = new Byte[Convert.ToInt32(fileInfo.Length)];

                    try
                    {
                        fs = new FileStream(x.FullName, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        fileToUpload = br.ReadBytes(Convert.ToInt32(fileInfo.Length));
                        if (br != null)
                        {
                            br.Close();
                        }
                        if (fs != null)
                        {
                            fs.Close();
                        }
                        CurrentMessageTemplate.Files.Add(new Data.Models.File
                        {
                            FileImage = fileToUpload,
                            ContentType = "",
                            FileName = x.Name.Substring(0, x.Name.LastIndexOf(".")),
                            FileExtension = x.Extension.Replace(".", ""),
                            DateCreated = DateTime.Now
                        });
                    }
                    catch (Exception)
                    {
                        throw;
                    };
                    MessageCreated = true;
                }

                this.Close();
            }
        }
    }
}
