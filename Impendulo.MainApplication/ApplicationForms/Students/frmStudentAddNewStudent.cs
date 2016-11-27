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
using System.Data.Entity;
using Impendulo.Common.Enum;
using Impendulo.Company.SearchForCompany.Deployment;
using Impendulo.Company.Deployment;

namespace Impendulo.StudentForms.Deployment
{
    public partial class frmAddUpdateStudent : Form
    {
        int iCurrentPosition = 0;
        public Student CurrentSelectedStudent { get; set; }
        //MCDEntities Dbconnection;
        //Student StudentObj;

        public frmAddUpdateStudent()
        {
            InitializeComponent();
            // DbConnection = new MCDEntities();
            //Dbconnection = new MCDEntities();
            /*
            Remove this Code for production or productin Testing.
            */

            /*--------------------------------------------------------*/

        }

        public int StudentID { get; set; }
        // public frmStudentCourseEnrollment EnrollmentForm { get; set; }

        private void frmAddUpdateStudent_Load(object sender, EventArgs e)
        {
            //StudentID = 0;
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }

        #region Refresh Controls

        #region Student Details refresh Methods
        private void refreshGender()
        {
            if (cboLookupGender.DataSource == null) { this.populateStudentGender(); }
        }
        private void refreshTitle()
        {
            if (cbolookupTitle.DataSource == null) { this.populateStudentTitle(); }
        }
        private void refreshEthnicity()
        {
            if (cboLookupEthnicity.DataSource == null) { this.populateStudentEthnicity(); }
        }
        private void refreshMartialStatus()
        {
            if (cboLookupMartialStatus.DataSource == null) { this.populateStudentMaritalStatus(); }
        }
        private void refreshHighestQualificationLevel()
        {
            if (cboLookupQualificationLevel.DataSource == null) { this.populateStudentHighestQualificationLevel(); }
        }
        #endregion

        #region Student Address Details Refresh Methods


        private void refreshStudentAddressTypes()
        {
            if (BindingSourceStudentAddressAddressType.Count == 0)
            {
                this.populateStudentAddressTypes();
            }
        }
        private void refreshStudentAddressProvices()
        {
            if (BindingSourceStudentAddressProvinces.Count == 0)
            {
                this.populateStudentAddressProvinces();
            }

        }
        private void refreshStudentAddressCountry()
        {
            if (BindingSourceStudentAddressCountry.Count == 0)
            {
                this.populateStudentAddressCountry();
            }
        }
        private void refreshStudentAddressGridview()
        {
            this.populateStudentAddresseDataGridViewControl();
        }
        private void refreshStudentAddressAddUpdateControls()
        {
            this.setStudentAddresssControls();
        }


        #endregion

        #region Student Contact Info Refresh Methods
        private void refreshStudentContactInfo()
        {
            populateStudentContactInfoContactDetails();
        }
        #endregion

        #region  Student Disabilities Refresh Methods

        private void RefreshStudentDisablityGridView()
        {
            this.populateStudentDisablityDataGrid();
        }
        private void RefreshStudentControls()
        {

        }
        #endregion

        #region  Student Company Refresh Methods
        private void refreshStudentCompany()
        {
            this.populateStudentCompany();
        }
        #endregion


        #endregion

        #region Populate Methods

        #region Student Details Populate Methods
        private void populateStudentGender()
        {
            using (var Dbconnection = new MCDEntities())
            {
                cboLookupGender.DataSource = (from a in Dbconnection.LookupGenders
                                              select a).ToList<LookupGender>();
            };
        }
        private void populateStudentTitle()
        {
            using (var Dbconnection = new MCDEntities())
            {
                cbolookupTitle.DataSource = (from a in Dbconnection.LookupTitles
                                             select a).ToList<LookupTitle>();
            };
        }
        private void populateStudentEthnicity()
        {
            using (var Dbconnection = new MCDEntities())
            {
                cboLookupEthnicity.DataSource = (from a in Dbconnection.LookupEthnicities
                                                 select a).ToList<LookupEthnicity>();
            };
        }
        private void populateStudentMaritalStatus()
        {
            using (var Dbconnection = new MCDEntities())
            {
                cboLookupMartialStatus.DataSource = (from a in Dbconnection.LookupMartialStatuses
                                                     select a).ToList<LookupMartialStatus>();
            };
        }
        private void populateStudentHighestQualificationLevel()
        {

            using (var Dbconnection = new MCDEntities())
            {
                cboLookupQualificationLevel.DataSource = (from a in Dbconnection.LookupQualificationLevels
                                                          select a).ToList<LookupQualificationLevel>();
            };
        }
        #endregion


        #region "Student Address Populate Methods"
        private void populateStudentAddressTypes()
        {

            using (var Dbconnection = new MCDEntities())
            {
                BindingSourceStudentAddressAddressType.DataSource = (from a in Dbconnection.LookupAddressTypes
                                                                     select a).ToList<LookupAddressType>();
            };

        }
        private void populateStudentAddresseDataGridViewControl()
        {

            using (var Dbconnection = new MCDEntities())
            {
                BindingSourceStudentAddresses.DataSource = (from a in Dbconnection.Individuals.Include("LookupProvince")
                                                            from b in a.Addresses
                                                            where a.IndividualID == this.StudentID
                                                            select b).ToList<Address>();
            };

        }
        private void populateStudentAddressProvinces()
        {

            using (var Dbconnection = new MCDEntities())
            {
                BindingSourceStudentAddressProvinces.DataSource = (from a in Dbconnection.LookupProvinces
                                                                   select a).ToList<LookupProvince>();
            };

        }
        private void populateStudentAddressCountry()
        {

            using (var Dbconnection = new MCDEntities())
            {
                BindingSourceStudentAddressCountry.DataSource = (from a in Dbconnection.LookupCountries
                                                                 select a).ToList<LookupCountry>();
            };

        }
        #endregion

        #region Student Contact Info Populate Methods
        private void populateStudentContactInfoContactDetails()
        {
            using (var DbConnection = new MCDEntities())
            {
                BindingSourceStudentContactDetails.DataSource = (from a in DbConnection.ContactDetails
                                                                 from b in a.Individuals
                                                                 where b.IndividualID == this.StudentID
                                                                 select a).ToList<ContactDetail>();
            }
        }
        #endregion

        #region Student Disablities Populate Methods

        private void populateStudentDisablityDataGrid()
        {

            using (var Dbconnection = new MCDEntities())
            {
                BindingSourceStudentDisablity.DataSource = (from a in Dbconnection.StudentDisabilities
                                                            where a.Student.StudentID == this.StudentID
                                                            select a).ToList<StudentDisability>();
            };
        }

        #endregion

        #region Company Populate Methods
        private void populateStudentCompany()
        {

            using (var Dbconnection = new MCDEntities())
            {
                this.companyBindingSource.DataSource = (from a in Dbconnection.Students
                                                        from b in a.StudentAssociatedCompanies
                                                        where a.StudentID == this.StudentID && b.IsCurrentCompany == true
                                                        select b.Company).ToList<Data.Models.Company>();
            };
        }
        #endregion
        #endregion

        #region Student Details methods

        private void setStudentDetails()
        {
            using (var Dbconnection = new MCDEntities())
            {
                Student StudentObj = (from a in Dbconnection.Students //.Include("Individual")
                                      where a.StudentID == StudentID
                                      select a).FirstOrDefault<Student>();

                //Set the drop down items with the values from the database.
                cboLookupGender.SelectedValue = StudentObj.GenderID;
                cbolookupTitle.SelectedValue = StudentObj.Individual.TitleID;
                cboLookupEthnicity.SelectedValue = StudentObj.EthnicityID;
                cboLookupMartialStatus.SelectedValue = StudentObj.MartialStatusID;
                cboLookupQualificationLevel.SelectedValue = StudentObj.QualificationLevelID;

                //Set the text field items wtih the values form the databse.a
                txtStudentID.Text = StudentObj.StudentID.ToString();
                txtStudentFirstName.Text = StudentObj.Individual.IndividualFirstName;
                txtStudentSecondName.Text = StudentObj.Individual.IndividualSecondName;
                txtStudentLastName.Text = StudentObj.Individual.IndividualLastname;
                txtStudentIDNumber.Text = StudentObj.StudentIDNumber;
            };
        }
        private void setStudentAddUpdateButtonToUpdate()
        {
            btnAddUpdateStudent.Text = "Update Student";
        }
        private void setStudentAddUpdateButtonToAdd()
        {
            btnAddUpdateStudent.Text = "Add Student";
        }
        private void loadStudentDetailsDropdownControls()
        {
            //refresh methods populates the drop downs if the they are not already populated.
            this.refreshGender();
            this.refreshEthnicity();
            this.refreshHighestQualificationLevel();
            this.refreshMartialStatus();
            this.refreshTitle();
        }
        private void addStudent()
        {
            Student StudentObj = new Student()
            {
                EthnicityID = Convert.ToInt32(this.cboLookupEthnicity.SelectedValue),
                GenderID = Convert.ToInt32(this.cboLookupGender.SelectedValue),
                MartialStatusID = Convert.ToInt32(this.cboLookupMartialStatus.SelectedValue),
                QualificationLevelID = Convert.ToInt32(this.cboLookupQualificationLevel.SelectedValue),
                StudentlInitialDate = DateTime.Today,
                StudentIDNumber = txtStudentIDNumber.Text,
                StudentCurrentPosition = "",
                Individual = new Individual()
                {
                    // IndividualID = 0,
                    TitleID = Convert.ToInt32(cbolookupTitle.SelectedValue),
                    IndividualFirstName = txtStudentFirstName.Text.ToString(),
                    IndividualSecondName = txtStudentSecondName.Text.ToString(),
                    IndividualLastname = txtStudentLastName.Text.ToString()

                }
            };

            using (MCDEntities DbConnection = new MCDEntities())
            {
                //We are saving a new student into the Student Collection
                DbConnection.Students.Add(StudentObj);
                DbConnection.SaveChanges();

                txtStudentID.Text = StudentObj.StudentID.ToString();
                this.StudentID = StudentObj.StudentID;
                this.CurrentSelectedStudent = StudentObj;
            }
        }
        private void updateStudent()
        {
            using (MCDEntities DbConnection = new MCDEntities())
            {
                var updateStudent = (from s in DbConnection.Students
                                     where s.StudentID == this.StudentID
                                     select s).FirstOrDefault<Student>();


                //2. update student in disconnected mode
                updateStudent.EthnicityID = Convert.ToInt32(this.cboLookupEthnicity.SelectedValue);
                updateStudent.GenderID = Convert.ToInt32(this.cboLookupGender.SelectedValue);
                updateStudent.MartialStatusID = Convert.ToInt32(this.cboLookupMartialStatus.SelectedValue);
                updateStudent.QualificationLevelID = Convert.ToInt32(this.cboLookupQualificationLevel.SelectedValue);
                updateStudent.StudentIDNumber = txtStudentIDNumber.Text.ToString();
                updateStudent.Individual.TitleID = Convert.ToInt32(cbolookupTitle.SelectedValue.ToString());
                //                    updateStudent.Individual.IndividualIDNumber = individualIDNumberTextBox.Text;
                updateStudent.Individual.IndividualFirstName = txtStudentFirstName.Text;
                updateStudent.Individual.IndividualSecondName = txtStudentSecondName.Text;
                updateStudent.Individual.IndividualLastname = txtStudentLastName.Text;

                //We are saving a new student into the Student Collection
                //3. Mark entity as modified
                // DbConnection.Entry(updateStudent).State = System.Data.Entity.EntityState.Modified;

                //4. call SaveChanges
                DbConnection.SaveChanges();
                CurrentSelectedStudent = updateStudent;
            };

        }
        private void btnStudentAddStudent_Click(object sender, EventArgs e)
        {
            if (this.btnAddUpdateStudent.Text.ToLower().Equals("add student"))
            {
                this.addStudent();
                this.setStudentAddUpdateButtonToUpdate();

            }
            else
            {
                this.updateStudent();
            }
        }

        #endregion

        #region Student Address Methods

        private void loadStudentAddressDropDownControls()
        {
            this.refreshStudentAddressTypes();
            this.refreshStudentAddressCountry();
            this.refreshStudentAddressProvices();

        }
        private void loadStudentAddressDataGridControl()
        {
            this.populateStudentAddresseDataGridViewControl();

        }
        private void addStudentAddressDetails()
        {
            this.dgvStudentAddresses.EndEdit();
            using (var Dbconnection = new MCDEntities())
            {
                Individual studentObj = (from a in Dbconnection.Individuals
                                         where a.IndividualID == this.StudentID
                                         select a).FirstOrDefault<Individual>();

                Address AddressObj = new Address
                {
                    AddressTypeID = Convert.ToInt32(cboStudentAddressAddressType.SelectedValue),
                    AddressLineOne = txtStudentAddressLineOne.Text,
                    AddressLineTwo = txtStudentAddressLineTwo.Text,
                    AddressTown = txtStudentAddressTown.Text,
                    AddressSuburb = txtStudentAddressSuburb.Text,
                    AddressAreaCode = txtStudentAddressAreaCode.Text,
                    ProvinceID = Convert.ToInt32(cboStudentAddressProvince.SelectedValue),
                    CountryID = Convert.ToInt32(cboStudentAddressCountry.SelectedValue),
                    AddressModifiedDate = DateTime.Now,
                    AddressIsDefault = this.chkStudnetAddressIsDefault.Checked
                };

                studentObj.Addresses.Add(AddressObj);
                Dbconnection.SaveChanges();
            };

        }
        private void updateStudentAddressDetails()
        {
            this.dgvStudentAddresses.EndEdit();
            int _AddressID = ((Address)BindingSourceStudentAddresses.Current).AddressID;
            using (var Dbconnection = new MCDEntities())
            {
                Address ad = (from a in Dbconnection.Addresses
                              where a.AddressID == _AddressID
                              select a).FirstOrDefault<Address>();


                ad.AddressTypeID = Convert.ToInt32(cboStudentAddressAddressType.SelectedValue);
                ad.ProvinceID = Convert.ToInt32(cboStudentAddressProvince.SelectedValue);
                ad.CountryID = Convert.ToInt32(cboStudentAddressCountry.SelectedValue);
                ad.AddressAreaCode = txtStudentAddressAreaCode.Text;
                ad.AddressLineOne = txtStudentAddressLineOne.Text;
                ad.AddressLineTwo = txtStudentAddressLineTwo.Text;
                ad.AddressSuburb = txtStudentAddressSuburb.Text;
                ad.AddressTown = txtStudentAddressTown.Text;
                ad.AddressModifiedDate = DateTime.Now;
                ad.AddressIsDefault = this.chkStudnetAddressIsDefault.Checked;

                //Dbconnection.Addresses.Attach(ad);
                //Dbconnection.Entry(ad).State = EntityState.Modified;
                Dbconnection.SaveChanges();
                
            };
        }
        private void removeStudentAddressDetails()
        {
            using (var DbConnection = new MCDEntities())
            {
                int _addressID = ((Address)BindingSourceStudentAddresses.Current).AddressID;
                Address AddressObj = (from a in DbConnection.Addresses
                                      where a.AddressID == _addressID
                                      select a).FirstOrDefault<Address>();

                Individual studentObj = (from a in DbConnection.Individuals
                                         where a.IndividualID == this.StudentID
                                         select a).FirstOrDefault<Individual>();

                studentObj.Addresses.Remove(AddressObj);


                DbConnection.SaveChanges();
            }


        }
        private void setStudentAddresssControls()
        {

            if (BindingSourceStudentAddresses.Count > 0)
            {
                int _AddressID = ((Address)BindingSourceStudentAddresses.Current).AddressID;
                using (var Dbconnection = new MCDEntities())
                {
                    Address ad = (from a in Dbconnection.Addresses
                                  where a.AddressID == _AddressID
                                  select a).FirstOrDefault<Address>();
                    if (ad != null)
                    {
                        cboStudentAddressAddressType.SelectedValue = ad.AddressTypeID;
                        cboStudentAddressProvince.SelectedValue = ad.LookupProvince.ProvinceID;
                        cboStudentAddressCountry.SelectedValue = ad.LookupCountry.CountryID;
                        txtStudentAddressAreaCode.Text = ad.AddressAreaCode;
                        txtStudentAddressLineOne.Text = ad.AddressLineOne;
                        txtStudentAddressLineTwo.Text = ad.AddressLineTwo;
                        txtStudentAddressSuburb.Text = ad.AddressSuburb;
                        txtStudentAddressTown.Text = ad.AddressTown;
                        chkStudnetAddressIsDefault.Checked = ad.AddressIsDefault;
                    }
                };

            }
            else
            {
                this.clearStudentAddresssControls();
            }




        }
        private void clearStudentAddresssControls()
        {
            cboStudentAddressAddressType.SelectedValue = 1;
            cboStudentAddressProvince.SelectedValue = 1;
            cboStudentAddressCountry.SelectedValue = 1;
            txtStudentAddressAreaCode.Text = "";
            txtStudentAddressLineOne.Text = "";
            txtStudentAddressLineTwo.Text = "";
            txtStudentAddressSuburb.Text = "";
            txtStudentAddressTown.Text = "";
            chkStudnetAddressIsDefault.Checked = false;

        }
        private void setStudentAddressAddUpdateButtonToAddState()
        {
            this.btnStudentAddressAddUpdate.Text = "Add";
            this.btnStudentAddressCancelAddUpdate.Visible = true;
            this.enableStudentAddressAddEditGroupBox();
        }
        private void setStudentAddressAddUpdateButtonToUpdateState()
        {
            this.btnStudentAddressAddUpdate.Text = "Update";
            this.btnStudentAddressCancelAddUpdate.Visible = false;
            //this.disableStudentAddressAddEditGroupBox();
        }
        private void enableStudentAddressAddEditGroupBox()
        {
            this.gbSutdentAddressAddEdit.Enabled = true;
        }
        private void disableStudentAddressAddEditGroupBox()
        {
            this.gbSutdentAddressAddEdit.Enabled = false;
        }
        #region Student Address Controls Methods
        private void btnRemoveStudentAddress_Click(object sender, EventArgs e)
        {
            this.removeStudentAddressDetails();
            this.refreshStudentAddressGridview();

            if (BindingSourceStudentAddresses.Count > 0)
            {
                this.BindingSourceStudentAddresses.Position = 0;
                this.setStudentAddresssControls();
                this.setStudentAddressAddUpdateButtonToUpdateState();
            }
            else
            {
                clearStudentAddresssControls();
                this.setStudentAddressAddUpdateButtonToAddState();
                this.disableStudentAddressAddEditGroupBox();
            }

        }
        private void btnAddStudnetAddress_Click(object sender, EventArgs e)
        {
            this.clearStudentAddresssControls();
            this.setStudentAddressAddUpdateButtonToAddState();
        }
        private void dgvStudentAddresses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var TDCETMD = (Address)(row.DataBoundItem);
                    var _Provinces = TDCETMD.LookupProvince;

                    row.Cells[Province.Index].Value = _Provinces.Province.ToString();
                    row.Cells[AddressType.Index].Value = TDCETMD.LookupAddressType.AddressType.ToString();
                    row.Cells[Country.Index].Value = TDCETMD.LookupCountry.CountryName.ToString();

                }
            }
        }
        private void btnStudentAddressAddUpdate_Click(object sender, EventArgs e)
        {
            if (btnStudentAddressAddUpdate.Text.ToLower().Equals("update"))
            {
                this.updateStudentAddressDetails();
                this.loadStudentAddressDataGridControl();
                this.setStudentAddresssControls();

            }
            else
            {//Adds New Address
                this.addStudentAddressDetails();
                this.loadStudentAddressDataGridControl();
                this.setStudentAddresssControls();
                this.setStudentAddressAddUpdateButtonToUpdateState();
            }
        }
        private void btnStudentAddressCancelAddUpdate_Click(object sender, EventArgs e)
        {
            if (BindingSourceStudentAddresses.Count > 0)
            {
                this.clearStudentAddresssControls();
                setStudentAddresssControls();
                this.enableStudentAddressAddEditGroupBox();
                btnStudentAddressCancelAddUpdate.Visible = false;
            }
            else
            {
                this.disableStudentAddressAddEditGroupBox();
            }
        }
        private void BindingSourceStudentAddresses_PositionChanged(object sender, EventArgs e)
        {
            this.setStudentAddresssControls();
        }
        #endregion
        #endregion


        #region Student Contact Info

        #region Student Contact Info Methods
        private void resetUpdateStudentContactInfo()
        {
            txtStudentContactTypeUpdateEmailAddress.Clear();
            txtStudentContactTypeUpdateNumberField.Clear();
        }
        private void setUpdateStudentContactInfo()
        {
            resetUpdateStudentContactInfo();
            //if ()
            //{

            //}
            ContactDetail ContactDetailObj = ((ContactDetail)BindingSourceStudentContactDetails.Current);
            if (ContactDetailObj != null)
            {
                if ((int)EnumContactTypes.Email_Address == ContactDetailObj.ContactTypeID)
                {
                    txtStudentContactTypeUpdateEmailAddress.Visible = true;
                    txtStudentContactTypeUpdateEmailAddress.Text = ContactDetailObj.ContactDetailValue;
                    txtStudentContactTypeUpdateNumberField.Visible = false;

                }
                else
                {
                    txtStudentContactTypeUpdateEmailAddress.Visible = false;
                    txtStudentContactTypeUpdateNumberField.Visible = true;
                    txtStudentContactTypeUpdateNumberField.Text = ContactDetailObj.ContactDetailValue;
                }
            }

        }

        private void showUpdateStudentContctInfo()
        {
            this.gbUpdateStudentContactInfo.Visible = true;

        }
        private void hideUpdateStudentContctInfo()
        {
            this.gbUpdateStudentContactInfo.Visible = false;
        }

        private void showAddStudentContctInfo()
        {
            this.gbAddStudentContactInfo.Visible = true;
        }
        private void hideAddStudentContctInfo()
        {
            this.gbAddStudentContactInfo.Visible = false;
        }

        private void switchStudentContactInfoAddControls(int ContactTypeID)
        {
            if (ContactTypeID == (int)EnumContactTypes.Email_Address)
            {
                txtStudentContactTypeAddEmailAddress.Visible = true;
                txtStudentContactTypeAddContactNumber.Visible = false;
                txtStudentContactTypeAddEmailAddress.Clear();
            }
            else
            {
                txtStudentContactTypeAddEmailAddress.Visible = false;
                txtStudentContactTypeAddContactNumber.Visible = true;
                txtStudentContactTypeAddContactNumber.Clear();
            }
        }
        private void setStudentContactInfoAddControls()
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
        enum StudentContactMethod
        {
            SwitchToAdd, SwitchToUpdate
        }

        private void switchBetweenAddNandUpdatePanelStudentContactInfo(StudentContactMethod SwitchType)
        {
            if (SwitchType == StudentContactMethod.SwitchToUpdate)
            {
                this.showUpdateStudentContctInfo();
                this.hideAddStudentContctInfo();
            }
            else
            {
                this.showAddStudentContctInfo();
                this.setStudentContactInfoAddControls();
                this.hideUpdateStudentContctInfo();
            }
        }

        private void addStudentContactInfo()
        {
            using (var DbConnection = new MCDEntities())
            {
                Individual IndividualObj = (from a in DbConnection.Individuals
                                            where a.IndividualID == this.StudentID
                                            select a).FirstOrDefault<Individual>();

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
                            _ContactDetailValue = txtStudentContactTypeAddContactNumber.Text;
                            _ContactTypeID = (int)rad.Tag;
                        }
                    }
                }

                ContactDetail Con = new ContactDetail
                {
                    ContactTypeID = _ContactTypeID,
                    ContactDetailValue = _ContactDetailValue

                };

                IndividualObj.ContactDetails.Add(Con);

                DbConnection.SaveChanges();

                this.populateStudentContactInfoContactDetails();

                // this.setStudentContactDetailsControls();
            }
        }
        private void updateStudentContactInfo()
        {
            int iCurrentIndex = BindingSourceStudentContactDetails.Position;

            using (var DbConnection = new MCDEntities())
            {

                ContactDetail _StudentContactDetailObj = ((ContactDetail)BindingSourceStudentContactDetails.Current);
                string _ContactDetailValue = "";
                if ((int)EnumContactTypes.Email_Address == _StudentContactDetailObj.ContactTypeID)
                {
                    _ContactDetailValue = txtStudentContactTypeUpdateEmailAddress.Text;
                }
                else
                {
                    _ContactDetailValue = txtStudentContactTypeUpdateNumberField.Text;
                }
                ContactDetail ConD = new ContactDetail
                {
                    ContactDetailID = _StudentContactDetailObj.ContactDetailID,
                    ContactDetailValue = _ContactDetailValue,
                    ContactTypeID = _StudentContactDetailObj.ContactTypeID
                };
                DbConnection.Entry(ConD).State = EntityState.Modified;
                DbConnection.SaveChanges();
            };
            this.refreshStudentContactInfo();
            this.BindingSourceStudentContactDetails.Position = iCurrentIndex;
        }
        private void removeStudentContactInfo()
        {

        }
        #endregion
        #region Studnet Contact Info Events
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
                txtStudentContactTypeAddContactNumber.Clear();
            }
            switchStudentContactInfoAddControls((int)radObj.Tag);
            //MessageBox.Show("sdsdsd");
            //throw new NotImplementedException();
        }

        #endregion

        #region Studnet Contact Details Controls Methods
        private void btnAddStudentContactInfo_Click(object sender, EventArgs e)
        {
            this.switchBetweenAddNandUpdatePanelStudentContactInfo(StudentContactMethod.SwitchToAdd);
            this.switchStudentContactInfoAddControls((int)EnumContactTypes.Email_Address);
            ((RadioButton)this.flowLayoutPanelContactTypeOptions.Controls[0]).Checked = true;
        }
        private void btnRemoveStudentClientInfo_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                var StudentObj = (from a in DbConnection.Individuals
                                  from b in a.ContactDetails
                                  where a.IndividualID == this.StudentID
                                  select a).FirstOrDefault<Individual>();
                var Cond = (from a in DbConnection.ContactDetails
                            where a.ContactDetailID == ((ContactDetail)BindingSourceStudentContactDetails.Current).ContactDetailID
                            select a).FirstOrDefault<ContactDetail>();
                StudentObj.ContactDetails.Remove(Cond);
                DbConnection.SaveChanges();
            };
            this.refreshStudentContactInfo();
            if (BindingSourceStudentContactDetails.Count > 0)
            {
                BindingSourceStudentContactDetails.Position = 0;
            }
        }
        private void btnCancelAddStudnetContactInfo_Click(object sender, EventArgs e)
        {
            this.switchBetweenAddNandUpdatePanelStudentContactInfo(StudentContactMethod.SwitchToUpdate);
        }
        private void btnAddStudnetContactInfo_Click(object sender, EventArgs e)
        {
            this.addStudentContactInfo();
            this.refreshStudentContactInfo();
            this.switchBetweenAddNandUpdatePanelStudentContactInfo(StudentContactMethod.SwitchToUpdate);
        }
        private void btnStudentContactInfoAddUpdateContactDetail_Click(object sender, EventArgs e)
        {
            this.updateStudentContactInfo();
        }
        private void BindingSourceStudentContactDetails_PositionChanged(object sender, EventArgs e)
        {
            this.setUpdateStudentContactInfo();
        }
        private void dgvStudentContactInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var ContactDet = (ContactDetail)(row.DataBoundItem);
                    row.Cells[ContactType.Index].Value = ContactDet.LookupContactType.ContactType.ToString();
                }
            }
        }
        #endregion

        #endregion

        #region Student Contact Info Populate Methods

        private void populateStudentContactInfoContactTypes()
        {
            using (var DbConnection = new MCDEntities())
            {
                BindingSourceStudentContactInfoContactType.DataSource = (from a in DbConnection.LookupContactTypes
                                                                         select a).ToList<LookupContactType>();
            }

        }


        #endregion

        #region Student Disabilities


        #region Student Disablities Methods
        private void setAddStudentDisablityButton()
        {
            this.btnAddUpdateStudentDisablity.Text = "&Add Details";
            this.btnCancelAddingStudentDisablity.Visible = true;
        }
        private void setUpdateStudentDisablityButton()
        {
            this.btnAddUpdateStudentDisablity.Text = "&Update Details";
            this.btnCancelAddingStudentDisablity.Visible = false;
        }
        private void addStudentDisablity()
        {
            int _DisabilityID = getDisablityID();
            using (var Dbconnection = new MCDEntities())
            {
                StudentDisability newStudentDisability = new StudentDisability
                {
                    StudentID = this.StudentID,
                    DisabilityID = _DisabilityID,
                    StudentDisabilityNotes = this.txtStudentDisablityNotes.Text.ToString()
                };

                Dbconnection.StudentDisabilities.Add(newStudentDisability);
                Dbconnection.SaveChanges();
            };
        }
        private int getDisablityID()
        {
            int _DisabilityID = 0;
            foreach (RadioButton rad in flowLayoutPanelDisablitiyCategory.Controls)
            {
                if (rad.Checked)
                {
                    _DisabilityID = (int)rad.Tag;
                }
            }
            return _DisabilityID;

        }
        private void updateStudentDisablitiy()
        {

            int _StudentDisabilityID = ((StudentDisability)BindingSourceStudentDisablity.Current).StudentDisabilityID;
            using (var Dbconnection = new MCDEntities())
            {
                StudentDisability studDistObj = (from a in Dbconnection.StudentDisabilities
                                                 where a.StudentDisabilityID == _StudentDisabilityID
                                                 select a).FirstOrDefault<StudentDisability>();

                studDistObj.StudentDisabilityNotes = txtStudentDisablityNotes.Text.ToString();

                Dbconnection.SaveChanges();

            };

        }
        private void removeStudentDisablity()
        {

            int _DisabilityID = ((StudentDisability)BindingSourceStudentDisablity.Current).StudentDisabilityID;
            using (var Dbconnection = new MCDEntities())
            {
                StudentDisability StudDisablityObj = (from a in Dbconnection.StudentDisabilities
                                                      where a.DisabilityID == _DisabilityID
                                                      select a).FirstOrDefault<StudentDisability>();

                //StudentDisability StudDisablityObj = new StudentDisability
                //{
                //    StudentDisabilityID = ((StudentDisability)BindingSourceStudentDisablity.Current).StudentDisabilityID
                //};
                Dbconnection.StudentDisabilities.Attach(StudDisablityObj);
                Dbconnection.StudentDisabilities.Remove(StudDisablityObj);
                Dbconnection.SaveChanges();

            };
        }
        private void setStudentDisalitiyControls()
        {
            StudentDisability studDisablObj = ((StudentDisability)BindingSourceStudentDisablity.Current);
            this.txtStudentDisablityNotes.Text = studDisablObj.StudentDisabilityNotes;
            foreach (RadioButton rad in this.flowLayoutPanelDisablitiyCategory.Controls)
            {
                if (studDisablObj.StudentDisabilityID == (int)rad.Tag)
                {
                    rad.Checked = true;
                }
            }
        }
        private void buildDisablityOptions()
        {
            if (flowLayoutPanelDisablitiyCategory.Controls.Count == 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Boolean IsFirst = true;
                    foreach (LookupDisability disObj in Dbconnection.LookupDisabilities.ToList<LookupDisability>())
                    {
                        RadioButton radObj = new RadioButton();
                        radObj.Text = disObj.Disability;
                        radObj.Width = 195;
                        if (IsFirst)
                        {
                            radObj.Checked = true;
                            IsFirst = false;
                        };
                        radObj.Tag = disObj.DisabilityID;
                        radObj.CheckedChanged += RadDisObj_CheckedChanged;
                        flowLayoutPanelDisablitiyCategory.Controls.Add(radObj);
                    }
                };
            }
        }
        private void clearStudentDisablityControls()
        {
            this.txtStudentDisablityNotes.Clear();
            ((RadioButton)(this.flowLayoutPanelDisablitiyCategory.Controls[0])).Checked = true;
        }
        private void hideDisablityOptions()
        {
            this.gbDisablitiyOptions.Visible = false;
        }
        private void showDisablityOptions()
        {
            this.gbDisablitiyOptions.Visible = true;
        }
        #endregion
        #region Student Disablities Events
        private void RadDisObj_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region Student Disablities Controls Events
        private void btnAddStudentDisablity_Click(object sender, EventArgs e)
        {
            this.setAddStudentDisablityButton();
            this.showDisablityOptions();
            this.clearStudentDisablityControls();
        }
        private void btnCancelAddingStudentDisablity_Click(object sender, EventArgs e)
        {
            this.hideDisablityOptions();
            this.setStudentDisalitiyControls();
            this.setUpdateStudentDisablityButton();
        }

        private void btnAddUpdateStudentDisablity_Click(object sender, EventArgs e)
        {
            if (btnAddUpdateStudentDisablity.Text.ToLower().Equals("&update details"))
            {
                this.updateStudentDisablitiy();
                this.RefreshStudentDisablityGridView();
                this.setUpdateStudentDisablityButton();
                this.hideDisablityOptions();
            }
            else
            {
                this.addStudentDisablity();
                this.hideDisablityOptions();
                this.RefreshStudentDisablityGridView();
                this.setUpdateStudentDisablityButton();
            }
        }
        private void BindingSourceStudentDisablity_PositionChanged(object sender, EventArgs e)
        {
            setStudentDisalitiyControls();
        }
        private void dgvStudentDisablity_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var StudentDisablitiesList = (StudentDisability)(row.DataBoundItem);
                    var _LookupDisablity = StudentDisablitiesList.LookupDisability;

                    row.Cells[AssignnedDisablity.Index].Value = _LookupDisablity.Disability.ToString();


                }
            }
        }
        private void btnRemoveStudentDisablity_Click(object sender, EventArgs e)
        {
            this.removeStudentDisablity();
            this.RefreshStudentDisablityGridView();
            if (BindingSourceStudentDisablity.Count > 0)
            {
                this.setStudentDisalitiyControls();
            }
            else
            {
                this.showDisablityOptions();

            }

        }
        #endregion


        #endregion

        #region Student Company Methods


        #endregion


        #region Wizard Comopnents
        #region "Navigation Controls"
        private void navigateForward()
        {
            if (ValidateStep())
            {
                if (iCurrentPosition + 1 < 6)
                {
                    //if step validation is passed the next window is display by incrementing the IcurrentPosition Counter.
                    iCurrentPosition++;
                }
                else
                {
                    //on last step which will close if the finish b=button is selected.
                    DialogResult res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult.Yes == res)
                    {
                        //if (EnrollmentForm != null)
                        //{
                        //    EnrollmentForm.StudentID = this.StudentID;
                        //    EnrollmentForm.txtStudentFullName.Text = this.txtStudentFirstName.Text + " " + txtStudentSecondName.Text + " " + txtStudentLastName.Text;
                        //    EnrollmentForm.txtStudentIdNumber.Text = this.txtStudentIDNumber.Text;
                        //    EnrollmentForm.txtStudentNumber.Text = this.StudentID.ToString();
                        //}
                        this.Close();
                    }
                }
                this.setCenterDisplayPanels();
                this.setNavigationControls();
                this.loadupStep();
            }
        }
        private void navigateBackwards()
        {
            if (iCurrentPosition - 1 >= 0)
            {
                iCurrentPosition--;
            }
            else
            {

                //iCurrentPosition = 5;
            }
            //Hide All Panels inside the MainFlowPanel
            //MainflowLayoutPanel
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }


        private void setNavigationControls()
        {
            if (iCurrentPosition == 0)
            {
                btnPreviousSection.Visible = false;
                btnNextSection.Text = "Next";
            }
            else
            {
                if (iCurrentPosition == 5)
                {
                    btnNextSection.Text = "Finished";
                }
                else { btnNextSection.Text = "Next"; }
                btnPreviousSection.Visible = true;
            }
            foreach (var Control in panel5.Controls)
            {
                if (Control is Label)
                {
                    //NavigationPanel
                    var lblObj = (Label)Control;
                    if (Convert.ToInt32(lblObj.Tag.ToString()) == iCurrentPosition)
                    {
                        //lblObj.Left = lblObj.Left + 5;
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                    else
                    {
                        //lblObj.Left = lblObj.Left - 5;
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Regular);
                    }
                }
            }

        }
        private void setCenterDisplayPanels()
        {
            foreach (var gbControl in MainflowLayoutPanel.Controls)
            {
                if (gbControl is GroupBox)
                {
                    var gbObj = (GroupBox)gbControl;
                    gbObj.Hide();
                }
            }
            foreach (var Control in MainflowLayoutPanel.Controls)
            {
                if (Control is GroupBox)
                {
                    var gbObj = (GroupBox)Control;
                    if (Convert.ToInt32(gbObj.Tag.ToString()) == iCurrentPosition)
                    {
                        gbObj.Show();
                        gbObj.Width = MainflowLayoutPanel.Width;
                        gbObj.Height = MainflowLayoutPanel.Height;
                    }
                    else
                    {
                        gbObj.Hide();
                        gbObj.Width = 0;
                        gbObj.Height = 0;

                    }
                }
            }
        }
        #endregion

        #region Wizard Methods
        private void loadupStep()
        {
            switch (iCurrentPosition)
            {
                case 0:
                    this.loadupStudent();
                    break;
                case 1:
                    this.loadupStudentAddresses();
                    break;
                case 2:
                    this.loadupStudentContactInfo();
                    break;
                case 3:
                    this.loadupStudentDisablities();
                    break;

                case 4:
                    this.loadupStudentCompany();
                    break;

                case 5:

                    break;
                default:

                    break;
            }

        }
        private void btnPreviousSection_Click(object sender, EventArgs e)
        {
            navigateBackwards();

        }

        private void btnNextSection_Click(object sender, EventArgs e)
        {
            navigateForward();
        }
        private Boolean ValidateStep()
        {

            Boolean bRtn = true;
            switch (iCurrentPosition)
            {
                case 0:
                    if (StudentID == 0)
                    {
                        MessageBox.Show("Please Save the Student Details Before Procceding!");
                        bRtn = false;
                    }
                    break;
                case 1:
                    //enter logic here
                    break;
                case 2:
                    //enter logic here

                    break;
                case 3:

                    break;

                case 4:

                    break;
                case 5:

                    break;

                default:
                    bRtn = false;
                    break;
            }

            return bRtn;
        }

        #region "Each Wizard Page Loadup"
        private void loadupStudent()
        {
            //Step 1 Load Drop down Controls
            this.loadStudentDetailsDropdownControls();

            //Step 2 if updating the student details load student details
            if (StudentID > 0)
            {
                //Load Student
                this.setStudentDetails();
                this.setStudentAddUpdateButtonToUpdate();
            }
            else
            {
                this.setStudentAddUpdateButtonToAdd();
            }

        }
        private void loadupStudentAddresses()
        {
            //load page controls
            this.loadStudentAddressDropDownControls();
            this.loadStudentAddressDataGridControl();
            this.setStudentAddresssControls();
            if (BindingSourceStudentAddresses.Count > 0)
            {
                this.enableStudentAddressAddEditGroupBox();
            }
            else
            {
                this.disableStudentAddressAddEditGroupBox();
            }




        }
        private void loadupStudentContactInfo()
        {

            this.refreshStudentContactInfo();

            if (this.BindingSourceStudentContactDetails.Count > 0)
            {
                this.switchBetweenAddNandUpdatePanelStudentContactInfo(StudentContactMethod.SwitchToUpdate);
                this.setUpdateStudentContactInfo();
            }
            else
            {
                this.switchBetweenAddNandUpdatePanelStudentContactInfo(StudentContactMethod.SwitchToAdd);
            }

        }


        private void loadupStudentDisablities()
        {


            this.RefreshStudentDisablityGridView();
            this.buildDisablityOptions();
            if (BindingSourceStudentDisablity.Count > 0)
            {
                //hide the disablity options
                this.hideDisablityOptions();
                //set the notes section with any notes that are linked to the disablity
                this.setStudentDisalitiyControls();

                // set the buttons to update
                this.setUpdateStudentDisablityButton();
            }
            else
            {
                //show the disablity options
                this.showDisablityOptions();
                //set the notes section with any notes that are linked to the disablity

                // set the buttons to add
                this.setAddStudentDisablityButton();
            }

        }
        private void loadupStudentCompany()
        {
            this.refreshStudentCompany();
        }
        private void loadupStudentNextOfKin()
        {

        }

        #endregion

        #endregion

        #endregion

        private void frmAddUpdateStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if adding or updating apprenticeship enrollments
            //if (EnrollmentForm != null)
            //{
            //    if (this.StudentID != 0)
            //    {
            //        EnrollmentForm.StudentID = this.StudentID;
            //        EnrollmentForm.txtStudentFullName.Text = this.txtStudentFirstName.Text + " " + txtStudentSecondName.Text + " " + txtStudentLastName.Text;
            //        EnrollmentForm.txtStudentIdNumber.Text = this.txtStudentIDNumber.Text;
            //        EnrollmentForm.txtStudentNumber.Text = this.StudentID.ToString();
            //    }
            //}
        }

        private void btnSearchForCompany_Click(object sender, EventArgs e)
        {
            frmCompanySearch frm = new frmCompanySearch();
            frm.ShowDialog();

            if (frm.CurrentCompany != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Student CurrentStudent = (from a in Dbconnection.Students
                                              where a.StudentID == this.StudentID
                                              select a).FirstOrDefault<Student>();
                    Boolean PreviouslyAssociatedWithCompany = false;
                    if (CurrentStudent.StudentAssociatedCompanies.Count > 0)
                    {
                        foreach (StudentAssociatedCompany CompanyStatusToUpdate in CurrentStudent.StudentAssociatedCompanies)
                        {
                            CompanyStatusToUpdate.IsCurrentCompany = false;
                            if (CompanyStatusToUpdate.StudentID == this.StudentID && CompanyStatusToUpdate.CompanyID == frm.CurrentCompany.CompanyID)
                            {
                                PreviouslyAssociatedWithCompany = true;
                                CompanyStatusToUpdate.IsCurrentCompany = true;
                            }
                        }
                    }

                    if (PreviouslyAssociatedWithCompany)
                    {
                        Dbconnection.SaveChanges();
                    }
                    else
                    {
                        CurrentStudent.StudentAssociatedCompanies.Add(new StudentAssociatedCompany
                        {
                            CompanyID = frm.CurrentCompany.CompanyID,
                            StudentID = CurrentStudent.StudentID,
                            IsCurrentCompany = true

                        });
                        Dbconnection.SaveChanges();
                    }
                    this.refreshStudentCompany();
                };
            }
        }

        private void btnReviewCompanyDetails_Click(object sender, EventArgs e)
        {
            frmCompany frm = new frmCompany();
            frm.txtCompaniesFilterCriteria.Text = ((Data.Models.Company)companyBindingSource.Current).CompanyName.ToString();
            frm.ShowDialog();
            this.refreshStudentCompany();
        }
    }
}
