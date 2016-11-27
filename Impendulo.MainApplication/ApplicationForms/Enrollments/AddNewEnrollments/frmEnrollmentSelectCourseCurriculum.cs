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

namespace Impendulo.Enrollments.Deployment
{
    public partial class frmEnrollmentSelectCourseCurriculum : Form
    {

        public int StudentID { get; set; }
        public frmEnrollmentSelectCourseCurriculum(int _StudentID)
        {
            StudentID = _StudentID;
            InitializeComponent();
        }

        private void populateEnrollmentTypeRadioButtons()
        {

            using (var Dbconnection = new MCDEntities())
            {
                List<LookupSectionalEnrollmentType> lstSet = (from a in Dbconnection.LookupSectionalEnrollmentTypes
                                                              select a).ToList<LookupSectionalEnrollmentType>();
                buildRadioButtons(lstSet);
            };
        }
        private void buildRadioButtons(List<LookupSectionalEnrollmentType> ObjList)
        {
            Boolean IsFirst = true;
            foreach (LookupSectionalEnrollmentType set in ObjList)
            {
                RadioButton radButton = new RadioButton();
                radButton.Text = set.LookupSectionalEnrollmentTypeName;
                radButton.Tag = set.LookupSectionalEnrollmentTypeID;
                radButton.Click += RadButton_Click;
                if (IsFirst)
                {
                    IsFirst = false;
                    radButton.Checked = true;
                };
                flowLayoutPanelEnrollmentTypes.Controls.Add(radButton);
            }

        }

        private void RadButton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void populateApperienticeshipCurriculum()
        {

            using (var Dbconnection = new MCDEntities())
            {
                curriculumBindingSource.DataSource = (from a in Dbconnection.Curriculums
                                                      where a.DepartmentID == (int)EnumDepartments.Apprenticeship
                                                      select a).Except(from a in Dbconnection.Curriculums
                                                                       from b in a.Enrollments
                                                                       where a.DepartmentID == (int)EnumDepartments.Apprenticeship
                                                                       && b.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressStates.In_Progress
                                                                       && b.IndividualID == StudentID
                                                                       select a).ToList<Curriculum>();
                //curriculumBindingSource.DataSource = (from a in Dbconnection.Curriculums
                //                                      from b in a.Enrollments
                //                                      where a.DepartmentID == (int)EnumDepartments.Apprenticeship
                //                                      && b.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressState.InProgress
                //                                      && b.IndividualID == StudentID
                //                                      select a).ToList<Curriculum>();
            };
        }

        private void frmEnrollmentSelectCourseCurriculum_Load(object sender, EventArgs e)
        {
            this.populateEnrollmentTypeRadioButtons();
            this.populateApperienticeshipCurriculum();
        }

        private void dgvCurriculum_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //CurriculumSelectCol
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {

                    //row.Cells[CurriculumSelectCol.Index].Value = "Select";
                }
            }
        }

        private void dgvCurriculum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvCurriculum.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnAddSelection_Click(object sender, EventArgs e)
        {
            this.AddCurriculum();
        }


        private void AddCurriculum()
        {
            int LookupSectionalEnrollmentTypeID = 0;
            Curriculum CurriculumObj = ((Curriculum)curriculumBindingSource.Current);

            foreach (RadioButton rad in flowLayoutPanelEnrollmentTypes.Controls)
            {
                if (rad.Checked)
                {
                    LookupSectionalEnrollmentTypeID = (int)rad.Tag;
                }
            }
            using (var Dbconnection = new MCDEntities())
            {
               
                Enrollment enroll = new Enrollment
                {
                    LookupEnrollmentProgressStateID = (int)EnumEnrollmentProgressStates.In_Progress,
                    IndividualID = this.StudentID,
                    CurriculumID = CurriculumObj.CurriculumID,
                    DateIntitiated = DateTime.Now,
                    ApprienticeshipEnrollment = new ApprienticeshipEnrollment
                    {
                        LookupSectionalEnrollmentTypeID = LookupSectionalEnrollmentTypeID
                    }

                };

                Dbconnection.Enrollments.Add(enroll);
                Dbconnection.SaveChanges();


                List<CurriculumCourse> lstCurriculumCourse = (from a in Dbconnection.CurriculumCourses
                                                              where a.CurriculumID == CurriculumObj.CurriculumID
                                                              select a).ToList<CurriculumCourse>();

                foreach (CurriculumCourse CurrCourseObj in lstCurriculumCourse)
                {
                    CurriculumCourseEnrollment CurriculumCourseEnrollmentObj = new CurriculumCourseEnrollment
                    {
                        CurriculumCourseID = CurrCourseObj.CurriculumCourseID,
                        EnrollmentID = enroll.EnrollmentID
                    };
                    enroll.CurriculumCourseEnrollments.Add(CurriculumCourseEnrollmentObj);
                }
                Dbconnection.SaveChanges();
            };
            this.Close();
        }

    }
}
