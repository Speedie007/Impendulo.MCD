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
using Impendulo.StudentForms.Development;
using Impendulo.Common.FileHandeling;

namespace Impendulo.WizardForm.ClientEnquiry.Development
{
    public partial class frmApprenticeshipEnrollmentFormV2 : Form
    {



        int iCurrentPosition = 0;
        //MCDEntities Dbconnection;
        //Student StudentObj;
        public Enrollment CurrentEnrollments { get; set; }
        public Student CurrentSelectedStudent { get; set; }
        public CurriculumEnquiry CurrentCurriculumEnquiry { get; set; }
        private IList<File> CurrentEnrollmentFormDocument { get; set; }
        private IList<File> CurrentIDDocument { get; set; }

        private Boolean MustSaveItems = false;

        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }

        public frmApprenticeshipEnrollmentFormV2()
        {
            InitializeComponent();
            CurrentEnrollmentFormDocument = new List<File>();
            CurrentIDDocument = new List<File>();
        }

        private void frmAddUpdateStudent_Load(object sender, EventArgs e)
        {


            if (CurrentEmployeeLoggedIn == null)
            {
                /*
             * Thismust be Commmented out or removed in the production version this is just for Develpoement Testing.
             */
                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                               where a.EmployeeID == 11075
                                               select a).FirstOrDefault<Employee>();
                };

                /***************************************************************************************/
                // MessageBox.Show("It is Required that you be logged in to use the feature.\n Login and try again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();

            }



            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }

        #region Forms Sections

        #region Page 1  - Student Selection

        #region Controls Events
        private void picSearchStudents_Click(object sender, EventArgs e)
        {
            frmStudentSearchForStudent frm = new frmStudentSearchForStudent();
            frm.ShowDialog();
            if (frm.CurrentSelectedStudent != null)
            {
                txtStudentFullName.Text = frm.CurrentSelectedStudent.Individual.IndividualFirstName + " " + frm.CurrentSelectedStudent.Individual.IndividualLastname;
                txtStudentIdNumber.Text = frm.CurrentSelectedStudent.StudentIDNumber;
                txtStudentNember.Text = frm.CurrentSelectedStudent.StudentID.ToString();
                CurrentSelectedStudent = frm.CurrentSelectedStudent;
                //Summary Fields
                txtSummaryFullName.Text = txtStudentFullName.Text;
                txtSummaryIDNumber.Text = txtStudentIdNumber.Text;
                txtSummaryStudentNumber.Text = txtStudentNember.Text;
                picbtnEditCurrentStudent.Visible = true;

            }
            else
            {
                picbtnEditCurrentStudent.Visible = false;
                txtStudentFullName.Clear();
                txtStudentIdNumber.Clear();
                txtStudentNember.Clear();
                //Summary Fields
                txtSummaryFullName.Clear();
                txtSummaryIDNumber.Clear();
                txtSummaryStudentNumber.Clear();
                CurrentSelectedStudent = null;
            }
        }
        private void picbtnEditCurrentStudent_Click(object sender, EventArgs e)
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent();
            frm.StudentID = this.CurrentSelectedStudent.StudentID;
            frm.CurrentSelectedStudent = CurrentSelectedStudent;
            frm.ShowDialog();

            txtStudentFullName.Text = frm.CurrentSelectedStudent.Individual.IndividualFirstName + " " + frm.CurrentSelectedStudent.Individual.IndividualLastname;
            txtStudentIdNumber.Text = frm.CurrentSelectedStudent.StudentIDNumber;
            txtStudentNember.Text = frm.CurrentSelectedStudent.StudentID.ToString();
            //Summary Detrials
            txtSummaryFullName.Text = txtStudentFullName.Text;
            txtSummaryIDNumber.Text = txtStudentIdNumber.Text;
            txtSummaryStudentNumber.Text = txtStudentNember.Text;
            CurrentSelectedStudent = frm.CurrentSelectedStudent;

        }

        #endregion

        #region Logical Control Metods


        #endregion



        #endregion

        #region Page 2 

        #region Refresh Methods



        #endregion

        #region Populate Methods

        #endregion

        #region Control Events
        private void lnk_UploadEnrollmentForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            removeAllEnrollmentForms();
            CurrentEnrollmentFormDocument = FileHandeling.UploadFile();
            if (CurrentEnrollmentFormDocument.Count > 0)
            {

                lblEnrollmentFormStatus.Text = "Completed Uploaded";
                lblEnrollmentFormStatus.BackColor = Color.Green;
                chkEnrollmentFormNotAvailable.Checked = false;


            }
            else
            {
                lblEnrollmentFormStatus.Text = "Not Uploaded";
                lblEnrollmentFormStatus.BackColor = Color.Red;
            }
            populateFileSummaryList();
        }
        private void populateFileSummaryList()
        {
            txtSummaryEnrollmentFormAttachments.Clear();
            txtSummaryIDDocumentAttachemnts.Clear();
            foreach (File f in CurrentEnrollmentFormDocument)
            {
                txtSummaryEnrollmentFormAttachments.Text += f.FileName + "." + f.FileExtension + "\n";
            }

            foreach (File f in CurrentIDDocument)
            {
                txtSummaryIDDocumentAttachemnts.Text += f.FileName + "." + f.FileExtension + "\n";
            }
        }
        private void removeAllEnrollmentForms()
        {
            if (CurrentEnrollmentFormDocument.Count > 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    foreach (File f in CurrentEnrollmentFormDocument)
                    {
                        Dbconnection.Files.Attach(f);
                    }

                    Dbconnection.Files.RemoveRange(CurrentEnrollmentFormDocument);
                    Dbconnection.SaveChanges();
                    CurrentEnrollmentFormDocument.Clear();
                    lblEnrollmentFormStatus.Text = "Not Uploaded";
                    lblEnrollmentFormStatus.BackColor = Color.Red;
                };
            }
            populateFileSummaryList();
        }

        private void lnkUploadIDDocument_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            removeAllIDDocuments();

            CurrentIDDocument = FileHandeling.UploadFile();
            if (CurrentIDDocument.Count > 0)
            {

                lblIDDocumentStatus.Text = "Completed Uploaded";
                lblIDDocumentStatus.BackColor = Color.Green;
                chkIDDocumentNotAvailable.Checked = false;

            }
            else
            {
                lblIDDocumentStatus.Text = "Not Uploaded";
                lblIDDocumentStatus.BackColor = Color.Red;
            }
            populateFileSummaryList();
        }
        private void removeAllIDDocuments()
        {
            if (CurrentIDDocument.Count > 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    foreach (File f in CurrentIDDocument)
                    {
                        Dbconnection.Files.Attach(f);
                    }

                    Dbconnection.Files.RemoveRange(CurrentIDDocument);
                    Dbconnection.SaveChanges();
                    CurrentIDDocument.Clear();
                    lblIDDocumentStatus.Text = "Not Uploaded";
                    lblIDDocumentStatus.BackColor = Color.Red;
                };
            }
            populateFileSummaryList();
        }

        private void chkEnrollmentFormNotAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnrollmentFormNotAvailable.Checked)
            {
                removeAllEnrollmentForms();
            }
        }

        private void chkIDDocumentNotAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIDDocumentNotAvailable.Checked)
            {
                removeAllIDDocuments();
            }
        }
        #endregion

        #region Logic Control Methods



        #endregion
        #endregion

        #region Page 3 

        #region Refresh Methods

        #endregion

        #region Populate Methods

        #endregion

        #region Control Events


        #endregion

        #region logical Control Methods

        #endregion

        #endregion

        #region Page 4 - Summary Confirmation

        #region Control Methods



        #endregion

        #endregion


        #endregion

        #region Wizard Comopnents
        #region "Navigation Controls"
        private void navigateForward()
        {
            if (ValidateStep())
            {
                if (iCurrentPosition + 1 < MainflowLayoutPanel.Controls.Count)
                {
                    //if step validation is passed the next window is display by incrementing the IcurrentPosition Counter.
                    iCurrentPosition++;
                }
                else
                {
                    //on last step which will close if the finish b=button is selected.
                    DialogResult res = MessageBox.Show("Are Details Correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult.Yes == res)
                    {
                        MustSaveItems = true;
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
                if (iCurrentPosition == MainflowLayoutPanel.Controls.Count - 1)
                {
                    btnNextSection.Text = "Save Enquiry";
                    btnNextSection.ImageIndex = 2;
                }
                else
                {
                    btnNextSection.Text = "Next";
                    btnNextSection.ImageIndex = 0;
                }
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
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                    else
                    {
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
                    this.loadupEnquiryContactSelectionType();
                    break;
                case 1:
                    this.loadupEnquiryContactSelection();
                    break;
                case 2:
                    this.loadupEnquiryCurriculumSelection();
                    break;
                case 3:
                    this.loadupEnquiryConfirmation();
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
                    break;
                case 1:
                    break;
                case 2:
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
        private void loadupEnquiryContactSelectionType()
        {


        }
        private void loadupEnquiryContactSelection()
        {





        }
        private void loadupEnquiryCurriculumSelection()
        {



        }


        private void loadupEnquiryConfirmation()
        {

        }







        #endregion

        #endregion

        #endregion

        private void frmApprenticeshipEnrollmentFormV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MustSaveItems)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    /*Step 1 Begin - Saves Main Enrollment*/
                    CurrentEnrollments = new Enrollment();
                    Dbconnection.CurriculumEnquiries.Attach(CurrentCurriculumEnquiry);

                    EnumSectionalEnrollmentTypes EnrollmenTypeSelection;
                    if (radSection13.Checked)
                    {
                        EnrollmenTypeSelection = EnumSectionalEnrollmentTypes.Section_13;
                    }
                    else
                    {
                        EnrollmenTypeSelection = EnumSectionalEnrollmentTypes.Section_28;
                    }

                    CurrentEnrollments.EnrolmentParentID = 0;
                    CurrentEnrollments.LookupEnrollmentProgressStateID = (int)EnumEnrollmentProgressStates.In_Progress;
                    CurrentEnrollments.CurriculumID = CurrentCurriculumEnquiry.CurriculumID;
                    CurrentEnrollments.IndividualID = CurrentSelectedStudent.StudentID;
                    CurrentEnrollments.DateIntitiated = DateTime.Now;
                    CurrentEnrollments.ApprienticeshipEnrollment = new ApprienticeshipEnrollment()
                    {
                        LookupSectionalEnrollmentTypeID = (int)EnrollmenTypeSelection
                    };

                    CurrentCurriculumEnquiry.Enrollments.Add(CurrentEnrollments);
                  
                    Dbconnection.SaveChanges();
                    /*End Step 1 */

                    /*Step 2 Get PreRequiestes Courses and and load them with the main enrollment*/

                    List<CurriculumPrequisiteCourse> CPC = (from a in Dbconnection.CurriculumPrequisiteCourses
                                                            where a.CurriculumID == CurrentCurriculumEnquiry.CurriculumID
                                                            select a)
                                                            .Include("CurriculumCourse")
                                                            .ToList<CurriculumPrequisiteCourse>();

                    foreach (CurriculumPrequisiteCourse CurrentCPC in CPC)
                    {
                        Enrollment PreRequisisteCourseEnrollment = new Enrollment
                        {
                            EnrolmentParentID = CurrentEnrollments.EnrollmentID,
                            LookupEnrollmentProgressStateID = (int)EnumEnrollmentProgressStates.In_Progress,
                            CurriculumID = CurrentCPC.CurriculumCourse.CurriculumID,
                            IndividualID = CurrentSelectedStudent.StudentID,
                            DateIntitiated = DateTime.Now
                        };
                        Dbconnection.Enrollments.Add(PreRequisisteCourseEnrollment);
                        Dbconnection.SaveChanges();

                        CurriculumCourseEnrollment CCE = new CurriculumCourseEnrollment
                        {
                             EnrollmentID = PreRequisisteCourseEnrollment.EnrollmentID,
                              CurriculumCourseID = CurrentCPC.CurriculumCourse.CurriculumCourseID
                        };
                        Dbconnection.CurriculumCourseEnrollments.Add(CCE);
                        Dbconnection.SaveChanges();
                    }

                    /* End Step 2*/

                    foreach (File f in CurrentEnrollmentFormDocument)
                    {
                        CurrentEnrollments.ApprienticeshipEnrollment.ApprenticeshipEnrollmentDocuments.Add(new ApprenticeshipEnrollmentDocument()
                        {
                            ImageID = f.ImageID,
                            EnrollmentID = CurrentEnrollments.EnrollmentID,
                             LookupEnrollentDocumentTypeID = (int)EnumEnrollentDocumentTypes.Enrollment_Documents
                        });
                    }
                    foreach (File f in CurrentIDDocument)
                    {
                        CurrentEnrollments.ApprienticeshipEnrollment.ApprenticeshipEnrollmentDocuments.Add(new ApprenticeshipEnrollmentDocument()
                        {
                            ImageID = f.ImageID,
                            EnrollmentID = CurrentEnrollments.EnrollmentID,
                            LookupEnrollentDocumentTypeID = (int)EnumEnrollentDocumentTypes.ID_Documents
                        });
                    }

                    Dbconnection.SaveChanges();
                };
            }
        }
    }
}
