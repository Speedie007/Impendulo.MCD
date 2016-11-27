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

namespace Impendulo.Courses.AddRemoveCurriculumCoursePreRequisteCourses.Deployment
{
    public partial class frmAddPreRequisteCourses : Form
    {
        List<CurriculumPrequisiteCourse> CurrentPreRequisisteCourses { get; set; }

        public int SelectedCurriculumID { get; set; }
        public frmAddPreRequisteCourses()
        {
            InitializeComponent();
        }

        private void frmAddPreRequisteCourses_Load(object sender, EventArgs e)
        {
            refreshCurriculumPreRequisisteCourses();
            refreshDepartments();
        }
        private void refreshDepartments()
        {
            populateDepartments();
        }

        private void refreshCurriculumPreRequisisteCourses()
        {
            populateCurriculumPreRequisisteCourses();
        }
        private void populateCurriculumPreRequisisteCourses()
        {

            using (var Dbconnection = new MCDEntities())
            {
                CurrentPreRequisisteCourses = (from a in Dbconnection.CurriculumPrequisiteCourses
                                               .Include("CurriculumCourse")
                                               .Include("CurriculumCourse.Curriculum")
                                               .Include("CurriculumCourse.Course")
                                               .Include("Curriculum")
                                               where a.CurriculumID == this.SelectedCurriculumID
                                               select a).ToList<CurriculumPrequisiteCourse>();
            };
            curriculumPrequisiteCourseBindingSource.DataSource = CurrentPreRequisisteCourses;
        }
        private void refreshCourses()
        {
            populateCourses();
        }

        private void populateCourses()
        {

            List<CurriculumCourse> ds = new List<CurriculumCourse>();

            if (curriculumsBindingSource.Current != null)
            {
                //Gets Current Courses Link as PreREquisite Courses
                List<CurriculumCourse> LinkedPreRequisiteCourses = new List<CurriculumCourse>();
                foreach (CurriculumPrequisiteCourse CPRC in CurrentPreRequisisteCourses)
                {
                    LinkedPreRequisiteCourses.Add(CPRC.CurriculumCourse);
                }

                List<CurriculumCourse> AvailableCourses = new List<CurriculumCourse>();
                //Filters out the PreREquisite Courses from the current List Of Courses
                AvailableCourses = (from a in ((Data.Models.Curriculum)(curriculumsBindingSource.Current)).CurriculumCourses
                                    select a).ToList<CurriculumCourse>();

                foreach (CurriculumCourse AvaC in AvailableCourses)
                {
                    Boolean IsLinked = false;
                    foreach (CurriculumCourse LinkC in LinkedPreRequisiteCourses)
                    {
                        if (AvaC.CurriculumCourseID == LinkC.CurriculumCourseID) { IsLinked = true; }
                    }
                    if (!IsLinked)
                    {
                        ds.Add(AvaC);
                    }

                }
            }

            curriculumCoursesBindingSource.DataSource = ds;
        }
        private void populateDepartments()
        {
            using (var Dbconnection = new MCDEntities())
            {
                departmentBindingSource.DataSource = (from a in Dbconnection.LookupDepartments
                                                      .Include("Curriculums")
                                                      .Include("Courses")
                                                      .Include("Curriculums.CurriculumCourses")
                                                      orderby a.DepartmentName
                                                      select a).ToList<LookupDepartment>();
            };
        }


        private void curriculumBindingSource_PositionChanged(object sender, EventArgs e)
        {
            refreshCourses();
        }

        private void dgvAvailableCourse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);
                    row.Cells[colAvailablePreRequisiteCourseName.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                }
            }
        }

        private void dgvLinkedCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumCourseObj = (CurriculumPrequisiteCourse)(row.DataBoundItem);
                    //CurriculumCourse.Curriculum
                    row.Cells[colLinkedPreRequisiteCourseName.Index].Value = CurriculumCourseObj.CurriculumCourse.Course.CourseName.ToString();
                    row.Cells[colCurriculumPreRequisiteCurriculum.Index].Value = CurriculumCourseObj.CurriculumCourse.Curriculum.CurriculumName.ToString();
                }
            }
        }

        private void dgvAvailableCourse_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvLinkedCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



        private void btnLinkCourse_Click(object sender, EventArgs e)
        {
            List<CurriculumPrequisiteCourse> SelctedCourses = new List<CurriculumPrequisiteCourse>();

            var gridView = (DataGridView)dgvAvailableCourse;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[colAvailableCourseSelection.Index].Value != null)
                    {
                        if ((Boolean)row.Cells[colAvailableCourseSelection.Index].Value == true)
                        {
                            SelctedCourses.Add(new CurriculumPrequisiteCourse
                            {
                                CurriculumCourseID = ((CurriculumCourse)(row.DataBoundItem)).CurriculumCourseID,
                                CurriculumID = SelectedCurriculumID
                            });
                        }
                    }
                }
            }
            if (SelctedCourses.Count > 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.CurriculumPrequisiteCourses.AddRange(SelctedCourses);
                    Dbconnection.SaveChanges();
                };
                this.refreshCurriculumPreRequisisteCourses();
                this.refreshCourses();
            }

        }

        private void btnUnLinkCourse_Click(object sender, EventArgs e)
        {
            List<CurriculumPrequisiteCourse> SelctedCourses = new List<CurriculumPrequisiteCourse>();

            var gridView = (DataGridView)dgvLinkedCourses;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[colLinkedCourseSelection.Index].Value != null)
                    {
                        if ((Boolean)row.Cells[colLinkedCourseSelection.Index].Value == true)
                        {
                            SelctedCourses.Add(new CurriculumPrequisiteCourse
                            {
                                CurriculumPrequisiteCourseID = ((CurriculumPrequisiteCourse)(row.DataBoundItem)).CurriculumPrequisiteCourseID,
                                CurriculumCourseID = ((CurriculumPrequisiteCourse)(row.DataBoundItem)).CurriculumCourseID,
                                CurriculumID = SelectedCurriculumID
                            });
                        }
                    }
                }
            }
            if (SelctedCourses.Count > 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    foreach (CurriculumPrequisiteCourse x in SelctedCourses)
                    {
                        Dbconnection.CurriculumPrequisiteCourses.Attach(x);
                    }
                    Dbconnection.CurriculumPrequisiteCourses.RemoveRange(SelctedCourses);
                    Dbconnection.SaveChanges();
                };
                this.refreshCurriculumPreRequisisteCourses();
                this.refreshCourses();
            }
        }

        private void dgvAvailableCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAvailableCourse.EndEdit();
            if (e.ColumnIndex == 0)
            {
                if (dgvAvailableCourse.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dgvAvailableCourse.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    if ((bool)dgvAvailableCourse.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == true)
                    {
                        dgvAvailableCourse.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    }
                    else
                    {
                        dgvAvailableCourse.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    }
                }
            }
        }

        private void dgvLinkedCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLinkedCourses.EndEdit();
            if (e.ColumnIndex == 0)
            {
                if (dgvLinkedCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dgvLinkedCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    if ((bool)dgvLinkedCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == true)
                    {
                        dgvLinkedCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    }
                    else
                    {
                        dgvLinkedCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    }
                }
            }
        }
    }
}
