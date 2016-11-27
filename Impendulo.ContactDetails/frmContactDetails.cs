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
using Impendulo.Common.Enum;
using System.Data.Entity;

namespace Impendulo.ContactDetails.Development
{
    /// <summary>
    /// </summary>
    public partial class frmAddUpdateContactDetails : Form
    {
        public int ContactDetailID { get; set; }
        public ContactDetail CurrentDetail { get; set; }

        public frmAddUpdateContactDetails()
        {
            ContactDetailID = 0;
            InitializeComponent();
        }

        private void setAddUpdatePanel()
        {
            if (ContactDetailID == 0)
            {
                btnAddContactInfo.Visible = true;
                btnUpdateContactInfo.Visible = false;
                this.gbContactYpeSelection.Visible = true;
            }
            else
            {
                btnAddContactInfo.Visible = false;
                btnUpdateContactInfo.Visible = true;
                this.gbContactYpeSelection.Visible = false;
                if (CurrentDetail != null)
                {
                    resetUpdateStudentContactInfo();

                    if ((int)EnumContactTypes.Email_Address == CurrentDetail.ContactTypeID)
                    {
                        txtStudentContactTypeAddEmailAddress.Visible = true;
                        txtStudentContactTypeAddEmailAddress.Text = CurrentDetail.ContactDetailValue;
                        txtContactNumber.Visible = false;
                        lblAddControlType.Text = CurrentDetail.LookupContactType.ContactType;
                    }
                    else
                    {
                        txtStudentContactTypeAddEmailAddress.Visible = false;
                        txtContactNumber.Visible = true;
                        txtContactNumber.Text = CurrentDetail.ContactDetailValue;
                        lblAddControlType.Text = CurrentDetail.LookupContactType.ContactType;
                    }
                }
            }
        }

        private void resetUpdateStudentContactInfo()
        {
            txtStudentContactTypeAddEmailAddress.Clear();
            txtContactNumber.Clear();
        }
        private void setContactInfoAddControls()
        {
            if (flowLayoutPanelContactTypeOptions.Controls.Count == 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    List<LookupContactType> cnoType = (from a in Dbconnection.LookupContactTypes
                                                       select a).ToList<LookupContactType>();
                    Boolean IsFirst = true;
                    foreach (LookupContactType contype in cnoType)
                    {
                        RadioButton radObj = new RadioButton();
                        radObj.Text = contype.ContactType;
                        if (IsFirst)
                        {
                            radObj.Checked = true;
                            IsFirst = false;
                            lblAddControlType.Text = contype.ContactType;
                            this.switchStudentContactInfoAddControls(contype.ContactTypeID);
                        };
                        radObj.Tag = contype.ContactTypeID;
                        radObj.CheckedChanged += RadObj_CheckedChanged;
                        flowLayoutPanelContactTypeOptions.Controls.Add(radObj);
                    }

                };
            }
            else
            {
                switchStudentContactInfoAddControls((int)EnumContactTypes.Email_Address);
            }
            //flowLayoutPanelContactTypeOptions.Controls.Clear();
        }

        private void switchStudentContactInfoAddControls(int ContactTypeID)
        {
            if (ContactTypeID == (int)EnumContactTypes.Email_Address)
            {
                txtStudentContactTypeAddEmailAddress.Focus();
                txtStudentContactTypeAddEmailAddress.Visible = true;
                txtContactNumber.Visible = false;
                txtStudentContactTypeAddEmailAddress.Clear();
            }
            else
            {
                txtContactNumber.Focus();
                txtStudentContactTypeAddEmailAddress.Visible = false;
                txtContactNumber.Visible = true;
                txtContactNumber.Clear();
            }
        }
        private void RadObj_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radObj = (RadioButton)sender;
            this.lblAddControlType.Text = radObj.Text;
            if ((int)EnumContactTypes.Email_Address == (int)radObj.Tag)
            {
                txtStudentContactTypeAddEmailAddress.Clear();
            }
            else
            {
                txtContactNumber.Clear();
            }
            switchStudentContactInfoAddControls((int)radObj.Tag);
            //MessageBox.Show("sdsdsd");
            //throw new NotImplementedException();
        }

        #region Old Methods



        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ContactDetailID == 0)
            {
                setContactInfoAddControls();
            }

            setAddUpdatePanel();
        }

        private void btnUpdateContactInfo_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                if ((int)EnumContactTypes.Email_Address == CurrentDetail.ContactTypeID)
                {
                    CurrentDetail.ContactDetailValue = txtStudentContactTypeAddEmailAddress.Text;
                }
                else
                {
                    CurrentDetail.ContactDetailValue = txtContactNumber.Text;
                }
                DbConnection.ContactDetails.Attach(CurrentDetail);
                DbConnection.Entry(CurrentDetail).State = EntityState.Modified;
                DbConnection.SaveChanges();
            };
            this.Close();
        }
        private void btnCancelAddStudnetContactInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddContactInfo_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                string _ContactDetailValue = "";
                int _ContactTypeID = 0;
                foreach (RadioButton rad in flowLayoutPanelContactTypeOptions.Controls)
                {
                    if (rad.Checked && ((int)rad.Tag == (int)EnumContactTypes.Email_Address))
                    {
                        _ContactDetailValue = txtStudentContactTypeAddEmailAddress.Text;
                        _ContactTypeID = (int)rad.Tag;
                    }
                    else
                    {
                        if (rad.Checked)
                        {
                            _ContactDetailValue = txtContactNumber.Text;
                            _ContactTypeID = (int)rad.Tag;
                        }
                    }
                }
                CurrentDetail = new ContactDetail
                {
                    ContactTypeID = _ContactTypeID,
                    ContactDetailValue = _ContactDetailValue
                };
                Dbconnection.ContactDetails.Add(CurrentDetail);
                Dbconnection.SaveChanges();

            };
            this.Close();
        }
    }
}
