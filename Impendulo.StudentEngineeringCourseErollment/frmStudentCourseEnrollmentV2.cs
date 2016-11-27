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
using System.Data.Entity;

using Impendulo.Common.Enum;
using Impendulo.Common.ProjectionQueryConverter;
using System.Reflection;
using Impendulo.Scheduling.Development.Courses.Apprenticeship;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment
{
    public partial class frmStudentCourseEnrollmentV2 : Form
    {
        public frmStudentCourseEnrollmentV2()
        {
            InitializeComponent();
        }


        private void frmStudentCourseEnrollmentV2_Load(object sender, EventArgs e)
        {
            tabEnrollmentWorkbench.SelectedIndex = 1;
            refreshApprenticeship();
        }

        #region Common Functions

        private void populateApprenticeshipDocumnetTypes(EnumDepartments _EnrollmentType)
        {
            if (_EnrollmentType == EnumDepartments.Apprenticeship)
            {
                flowLayoutPanelApprenticeshipDocumentTypes.Controls.Clear();

            }
            using (var Dbconnection = new MCDEntities())
            {
                List<LookupEnrollentDocumentType> cnoType = (from a in Dbconnection.LookupEnrollentDocumentTypes
                                                             select a).ToList<LookupEnrollentDocumentType>();
                Boolean IsFirst = true;
                foreach (LookupEnrollentDocumentType Enrolltype in cnoType)
                {
                    RadioButton radObj = new RadioButton();
                    radObj.Appearance = Appearance.Button;
                    radObj.Text = Enrolltype.EnrollentDocumentType;
                    if (IsFirst)
                    {
                        populateApprenticeshipEnrollmentDocuments(Enrolltype.LookupEnrollentDocumentTypeID);
                        radObj.Checked = true;
                        IsFirst = false;

                    };
                    radObj.Tag = Enrolltype.LookupEnrollentDocumentTypeID;
                    radObj.CheckedChanged += RadObj_ApprenticeshipDocuments_CheckedChanged;
                    if (_EnrollmentType == EnumDepartments.Apprenticeship)
                    {
                        flowLayoutPanelApprenticeshipDocumentTypes.Controls.Add(radObj);
                    }
                }

            };


        }
        private void populateApprenticeshipEnrollmentDocuments(int _EnrollentDocumentTypeID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                Enrollment Enroll = ((Enrollment)(apprenticeshipEnrollmentBindingSource.Current));
                fileBindingSource.DataSource = (from a in Dbconnection.ApprenticeshipEnrollmentDocuments
                                                where a.EnrollmentID == Enroll.EnrollmentID
                                                    && a.LookupEnrollentDocumentTypeID == _EnrollentDocumentTypeID
                                                select new
                                                {
                                                    ImageID = a.File.ImageID,
                                                    FileName = a.File.FileName + "." + a.File.FileExtension,
                                                    DateCreated = a.File.DateCreated
                                                }).ToList();

            };
        }
        private void RadObj_ApprenticeshipDocuments_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radObj = (RadioButton)sender;
            populateApprenticeshipEnrollmentDocuments((int)radObj.Tag);
        }
        #endregion
        #region Apprenticeship

        #region Refresh Methods

        private void refreshApprenticeship()
        {
            populateApprienticeship();
        }
        private void refreshApprenticeshipCoursePreRequisites()
        {
            populateApprenticeshipCoursePreRequisites();
        }
        private void refreshApprenticeshipEnrollmentAvailbaleCourses()
        {
            int _EnrollmentID = 0;
            int _CurriculumID = 0;
            if (apprenticeshipEnrollmentBindingSource.List.Count > 0)
            {
                _EnrollmentID = ((Enrollment)(apprenticeshipEnrollmentBindingSource.Current)).EnrollmentID;
                _CurriculumID = ((Enrollment)(apprenticeshipEnrollmentBindingSource.Current)).CurriculumID;
            }
            populateAprientceshipAvailableCourses(_EnrollmentID, _CurriculumID);
        }

        private void refreshApprenticeshipEnrollmentLinkedCourses()
        {
            int _EnrollmentID = 0;
            if (apprenticeshipEnrollmentBindingSource.List.Count > 0)
            {
                _EnrollmentID = ((Enrollment)(apprenticeshipEnrollmentBindingSource.Current)).EnrollmentID;
            }
            populateApprienticeshipLinkedCourse(_EnrollmentID);
        }

        #endregion

        #region Populate methods
        private void clearDataBindingSources()
        {
            apprenticeshipEnrollmentBindingSource.Clear();
        }
        private void populateApprienticeship()
        {
            this.clearDataBindingSources();
            using (var Dbconnection = new MCDEntities())
            {
                apprenticeshipEnrollmentBindingSource.DataSource = (from a in Dbconnection.Enrollments
                                                      .Include("Student")
                                                      .Include("Student.Individual")
                                                      .Include("Student.Individual.LookupTitle")
                                                      .Include("CurriculumEnquiries")
                                                          // .Include("CurriculumEnquiries.Enquiry")
                                                          //.Include("CurriculumEnquiries.Enquiry.Companies")
                                                      orderby a.DateIntitiated descending
                                                      where a.EnrolmentParentID == 0
                                                      select a)


                                                      //.Include("CurriculumEnquiries")
                                                      //.Include("CurriculumEnquiries.Enquiry")
                                                      // .Include("CurriculumEnquiries.Enquiry.Companies")
                                                      //.Include("ApprienticeshipEnrollment")
                                                      //.Include("ApprienticeshipEnrollment.LookupSectionalEnrollmentType")

                                                      //.Include("Student.Individual.LookupTitle")
                                                      .Take<Enrollment>(30).ToList<Enrollment>();

            };
        }
        private void populateApprenticeshipCoursePreRequisites()
        {
            Enrollment EnrollObj = (Enrollment)apprenticeshipEnrollmentBindingSource.Current;
            if (EnrollObj != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    apprenticeshipCurriculumCourseBindingSource.DataSource = (from a in Dbconnection.Enrollments
                                                                from b in a.CurriculumCourseEnrollments
                                                                where a.EnrolmentParentID == EnrollObj.EnrollmentID
                                                                select b.CurriculumCourse
                                                                ).ToList<CurriculumCourse>();
                };
            }
            else
            {
                apprenticeshipCurriculumCourseBindingSource.Clear();
            }


        }

        private void populateAprientceshipAvailableCourses(int _EnrollmentID, int _CurriculumID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                apprenticeshipAvailableCurriculumCoursesBindingSource.DataSource =
                    (from a in Dbconnection.CurriculumCourses
                     .Include("Course")
                     where a.CurriculumID == _CurriculumID
                     select a).ToList<CurriculumCourse>().Except(
                                                                 (from a in Dbconnection.CurriculumCourses

                                                                  from b in a.CurriculumCourseEnrollments
                                                                  where b.EnrollmentID == _EnrollmentID
                                                                  select a).ToList<CurriculumCourse>()).ToList<CurriculumCourse>();

            };
        }
        private void populateApprienticeshipLinkedCourse(int _EnrollmentID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                apprenticeshipLinkedCurriculumCoursesBindingSource.DataSource = (from a in Dbconnection.CurriculumCourses
                                                                    .Include("Course")
                                                                   from b in a.CurriculumCourseEnrollments
                                                                   where b.EnrollmentID == _EnrollmentID
                                                                   select a).ToList<CurriculumCourse>();
            };
        }
        #endregion

        #region Control Event Methods
        private void tabEnrollmentWorkbench_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((tabEnrollmentWorkbench).SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    this.refreshApprenticeship();
                    if (apprenticeshipEnrollmentBindingSource.List.Count > 0)
                    {
                        populateApprenticeshipDocumnetTypes(EnumDepartments.Apprenticeship);
                        this.refreshApprenticeshipEnrollmentAvailbaleCourses();
                        this.refreshApprenticeshipEnrollmentLinkedCourses();
                    }
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

                    break;
            }
        }
        #endregion

        #region Logical Control

        #endregion
        #endregion

        private void dgvAprenticeshipTab_Enrollment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Enrollment EnrollmentObj = (Enrollment)(row.DataBoundItem);

                    row.Cells[colApprenticeshipCurriculum.Index].Value = EnrollmentObj.Curriculum.CurriculumName.ToString();
                    if (EnrollmentObj.ApprienticeshipEnrollment != null)
                    {
                        row.Cells[colApprenticeshipSection.Index].Value = EnrollmentObj.ApprienticeshipEnrollment.LookupSectionalEnrollmentType.LookupSectionalEnrollmentTypeName.ToString();

                    }
                    var CurriculumEnquiryObj = EnrollmentObj.CurriculumEnquiries.FirstOrDefault<CurriculumEnquiry>(); ;
                    if (CurriculumEnquiryObj != null)
                    {
                        row.Cells[colApprenticeshipEnqiry.Index].Value = CurriculumEnquiryObj.EnquiryID.ToString();
                    }


                }
            }
        }
        private void dgvAprenticeshipTab_Enrollment_DataError(object sender, DataGridViewDataErrorEventArgs e) { }
        private void dgvApprenticeshipTab_PrerequisiteCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    CurriculumCourse CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);

                    row.Cells[colApprenticeshipPreRequisiteCurriculum.Index].Value = CurriculumCourseObj.Curriculum.CurriculumName.ToString();
                    row.Cells[colApprenticeshipPreRequisiteCourse.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                }
            }
        }
        private void dgvApprenticeshipTab_PrerequisiteCourses_DataError(object sender, DataGridViewDataErrorEventArgs e) { }
        private void enrollmentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            refreshApprenticeshipCoursePreRequisites();
            if (apprenticeshipEnrollmentBindingSource.List.Count > 0)
            {
                populateApprenticeshipDocumnetTypes(EnumDepartments.Apprenticeship);
                this.refreshApprenticeshipEnrollmentAvailbaleCourses();
                this.refreshApprenticeshipEnrollmentLinkedCourses();
            }
        }
        private void dgvApprenticeshipTab_PrerequisiteCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:

                    break;
                case 1:
                    frmScheduleApprenticeship frm = new frmScheduleApprenticeship();
                    frm.ShowDialog();
                    break;
                case 4:

                    break;
            }
        }

        private void dgvApprenticeshipEnrollmentAvaiableCurriculumCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    CurriculumCourse CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);

                    row.Cells[colApprenticeshipEnrollmentAvailableCourse.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                }
            }
        }

        private void dgvApprenticeshipEnrollmentAvaiableCurriculumCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



        private void dgvApprenticeshipTab_PrerequisiteCourses_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {

                case 0:


                    var FileObj = fileBindingSource.Current;
                    File x = new File();
                    //loop through the properties of the object you want to covert:          
                    foreach (PropertyInfo pi in FileObj.GetType().GetProperties())
                    {
                        try
                        {
                            //get the value of property and try 
                            //to assign it to the property of T type object:
                            x.GetType().GetProperty(pi.Name).SetValue(x, pi.GetValue(FileObj, null), null);
                        }
                        catch { }
                    }
                    folderBrowserDialogForDownloading.ShowDialog();

                    if (folderBrowserDialogForDownloading.SelectedPath.Length > 0)
                    {
                        try
                        {
                            File CurrentFile = Common.FileHandeling.FileHandeling.GetFile(x.ImageID);
                            string path = folderBrowserDialogForDownloading.SelectedPath + "\\" + x.FileName;
                            System.IO.File.WriteAllBytes(path, CurrentFile.FileImage);
                            MessageBox.Show(x.FileName + ", Successfully Saved to: " + path, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    break;
            }
        }

        private void btnEditCourseSelection_Click(object sender, EventArgs e)
        {

        }
    }
}
