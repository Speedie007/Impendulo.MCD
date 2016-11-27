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
using Impendulo.MessageTemplates.Deployment.AddMessageTemplates;
using System.Collections;
using Impendulo.Common.FileHandeling;

namespace Impendulo.MessageTemplates.Deployment
{
    public partial class frmMessageTemplates : Form
    {
        public frmMessageTemplates()
        {
            InitializeComponent();
        }
        MessageTemplate _CurrentMessageTemplate;
        MessageTemplate CurrentMessageTemplate
        {
            get
            {
                if (_CurrentMessageTemplate == null)
                {
                    return new MessageTemplate();
                };
                return _CurrentMessageTemplate;
            }
            set
            {
                _CurrentMessageTemplate = value;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.refreshProcesses();

        }

        #region All Sections

        #region Summary Sections

        #region Refresh Methods
        private void refreshProcesses()
        {
            this.populateProcesses();
        }

        #endregion

        #region Populate Methods
        private void populateProcesses()
        {

            using (var Dbconnection = new MCDEntities())
            {
                lookupProcessBindingSource.DataSource = (from a in Dbconnection.LookupProcesses
                                                         .Include("LookupProcessSteps")
                                                             //.Include("LookupProcessSteps.MessageTemplates")
                                                         select a).ToList<LookupProcess>();
            };
        }


        #endregion

        #region Logical Control Methods

        #endregion

        #region Controls Event Methods

        #endregion

        #region seting of Toolbar Controls



        #endregion


        #endregion

        #region Message Sections
        #region Refresh Methods
        private void refreshMessage()
        {
            if (lookupProcessStepsBindingSource.Count > 0)
            {
                this.populateMessage();

            }
            else
            {
                messageTemplateBindingSource.Clear();
            }
        }

        #endregion

        #region Populate Methods
        private void populateMessage()
        {

            filesBindingSource.Clear();
            messageTemplateBindingSource.Clear();
            CurrentMessageTemplate = null;

            using (var Dbconnection = new MCDEntities())
            {
                var _ProcessStepMessage = (from a in Dbconnection.MessageTemplates
                                           where a.ProcessStepID == ((LookupProcessStep)lookupProcessStepsBindingSource.Current).ProcessStepID
                                           select new
                                           {
                                               MessageTemplateID = a.MessageTemplateID,
                                               DateLastUpdated = a.DateLastUpdated,
                                               ProcessStepID = a.ProcessStepID,
                                               Message = a.Message
                                           }).FirstOrDefault();



                if (_ProcessStepMessage != null)
                {

                    MessageTemplate NewMessageTemplate = CurrentMessageTemplate;

                    NewMessageTemplate.Message = _ProcessStepMessage.Message;
                    NewMessageTemplate.MessageTemplateID = _ProcessStepMessage.MessageTemplateID;
                    NewMessageTemplate.ProcessStepID = _ProcessStepMessage.ProcessStepID;
                    NewMessageTemplate.DateLastUpdated = _ProcessStepMessage.DateLastUpdated;

                    var x = (from a in Dbconnection.MessageTemplates
                             from b in a.Files
                             where a.ProcessStepID == ((LookupProcessStep)lookupProcessStepsBindingSource.Current).ProcessStepID
                             select new
                             {
                                 b.ImageID,
                                 b.FileName,
                                 b.FileExtension,
                                 b.DateCreated
                             }).ToList();

                    NewMessageTemplate.Files.Clear();

                    foreach (var gg in x)
                    {
                        NewMessageTemplate.Files.Add(new Data.Models.File
                        {
                            ImageID = gg.ImageID,
                            ContentType = "",
                            DateCreated = gg.DateCreated,
                            FileImage = null,
                            FileName = gg.FileName,
                            FileExtension = gg.FileExtension
                        });
                    }
                    CurrentMessageTemplate = NewMessageTemplate;
                    messageTemplateBindingSource.DataSource = NewMessageTemplate;
                    this.gbMessageEditor.Enabled = true;
                    this.AddMessageTemplate.Enabled = false;
                }
                else
                {
                    filesBindingSource.Clear();
                    messageTemplateBindingSource.Clear();
                    this.gbMessageEditor.Enabled = false;
                    this.AddMessageTemplate.Enabled = true;
                }



            };



        }
        #endregion

        #region Logical Control Methods

        #endregion

        #region Controls Event Methods

        #endregion

        #endregion

        #region Attachment Sections
        #region Refresh Methods

        #endregion

        #region Populate Methods

        #endregion

        #region Logical Control Methods

        #endregion

        #region Controls Event Methods

        #endregion

        #endregion

        #endregion

        private void cboProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboProcessSteps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMessageTemplate_Click(object sender, EventArgs e)
        {
            frmAddMessageTemplate frm = new frmAddMessageTemplate();
            frm.ShowDialog();
            if (frm.MessageCreated)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    frm.CurrentMessageTemplate.ProcessStepID = ((LookupProcessStep)lookupProcessStepsBindingSource.Current).ProcessStepID;
                    frm.CurrentMessageTemplate.DateLastUpdated = DateTime.Now;
                    Dbconnection.MessageTemplates.Add(frm.CurrentMessageTemplate);
                    Dbconnection.SaveChanges();
                };
            }
            this.refreshMessage();
        }

        private void lookupProcessStepsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            refreshMessage();
        }

        private void btnUploadMessageTamplateAttachments_Click(object sender, EventArgs e)
        {
            List<File> UploadedFiles = FileHandeling.UploadFile();

            using (var Dbconnection = new MCDEntities())
            {
                MessageTemplate hh = CurrentMessageTemplate;
                Dbconnection.MessageTemplates.Attach(CurrentMessageTemplate);
                foreach (Data.Models.File x in UploadedFiles)
                {
                    Dbconnection.Files.Attach(x);
                    CurrentMessageTemplate.Files.Add(x);
                }

                Dbconnection.SaveChanges();

                this.refreshMessage();


            };
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            btnUpdateMessage.Enabled = true;
        }

        private void btnRemoveAttachment_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "Attchment Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                Data.Models.File FileToRemove = (Data.Models.File)filesBindingSource.Current;

                using (var Dbconnection = new MCDEntities())
                {

                    Dbconnection.MessageTemplates.Attach(CurrentMessageTemplate);
                    Dbconnection.Files.Attach(FileToRemove);
                    CurrentMessageTemplate.Files.Remove(FileToRemove);
                    Dbconnection.Files.Remove(FileToRemove);
                };
                this.refreshMessage();
            }
        }

        private void btnUpdateMessage_Click(object sender, EventArgs e)
        {



            using (var Dbconnection = new MCDEntities())
            {
                Dbconnection.MessageTemplates.Attach(CurrentMessageTemplate);
                CurrentMessageTemplate.Message = txtMessage.Text.ToString();
                Dbconnection.Entry(CurrentMessageTemplate).State = System.Data.Entity.EntityState.Modified;

                Dbconnection.SaveChanges();

                MessageBox.Show("Template Updated!", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            };
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            if (txtMessage.SelectionFont.Bold)
            {
                txtMessage.SelectionFont = new Font(txtMessage.Font, FontStyle.Regular);
            }
            else
            {
                txtMessage.SelectionFont = new Font(txtMessage.Font, FontStyle.Bold);
            }

        }

        private void lookupProcessBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshMessage();

        }
        private void btnDeleteMessageTemplate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "Template Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.MessageTemplates.Attach(CurrentMessageTemplate);
                    Dbconnection.MessageTemplates.Remove(CurrentMessageTemplate);
                    Dbconnection.SaveChanges();
                    refreshMessage();
                };
            }
        }
    }
}
