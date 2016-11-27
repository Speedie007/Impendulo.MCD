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
using Impendulo.Facilitators.Development;

namespace Impendulo.Facilitators.FacilitatorCourses.Development
{
    public partial class frmFacilitatorAssociatedCourses : Form
    {
        public Facilitator currentFacilitator { get; set; }
        public frmFacilitatorAssociatedCourses()
        {
            InitializeComponent();
        }

        private void refreshFacilitator()
        {

        }
        private void refreshDepartment()
        {
            if (currentFacilitator != null)
            {
                this.populateDepartments();
            }
            else
            {
                lookupDepartmentBindingSource.Clear();
            }
            this.setSelectionControls();
        }


        private void refreshAvailableCourses()
        {
            if (lookupDepartmentBindingSource.Count > 0)
            {
                int _DepartmentID = 0;
                if (lookupDepartmentBindingSource.Count > 0)
                {
                    _DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue);
                }
                populateAvailableCourses(_DepartmentID);
            }
            else
            {
                availableCoursesBindingSource.Clear();
            }
        }
        private void refreshLinkedCourses()
        {
            if (lookupDepartmentBindingSource.Count > 0)
            {
                populateLinkedCourses();
            }
            else
            {
                linkedCoursesBindingSource.Clear();
            }
        }

        private void populateFacilitators()
        {

        }
        private void populateDepartments()
        {
            using (var Dbconnection = new MCDEntities())
            {
                lookupDepartmentBindingSource.DataSource = (from a in Dbconnection.LookupDepartments
                                                            .Include("Curriculums")
                                                            select a).ToList<LookupDepartment>();
            };
        }
        private void populateCurriculums()
        {
            LookupDepartment currentDepartment = (LookupDepartment)lookupDepartmentBindingSource.Current;
            curriculumBindingSource.DataSource = (from a in currentDepartment.Curriculums
                                                  select a).ToList<Curriculum>();
        }
        private void populateAvailableCourses(int _DepartmentID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                List<Course> AllDepartmentCourses = (from a in Dbconnection.Courses
                                                        .Include("FacilitatorAssociatedCourses")
                                                     where a.DepartmentID == _DepartmentID &&
                                                                                a.CourseName.ToLower().Contains(AvaiableCoursesFilter)
                                                     select a).ToList<Course>();

                availableCoursesBindingSource.DataSource = (from a in AllDepartmentCourses
                                                            select a).Except(from a in AllDepartmentCourses
                                                                             from b in a.FacilitatorAssociatedCourses
                                                                             where b.IndividualID == this.currentFacilitator.FacilitatorID
                                                                             select a).ToList<Course>();
            };

        }

        private void populateLinkedCourses()
        {

            using (var Dbconnection = new MCDEntities())
            {
                linkedCoursesBindingSource.DataSource = (from a in Dbconnection.Courses
                                                         .Include("FacilitatorAssociatedCourses")
                                                         from b in a.FacilitatorAssociatedCourses
                                                         where
                                                                b.IndividualID == this.currentFacilitator.FacilitatorID
                                                                && a.CourseName.ToLower().Contains(LinkedCoursesFilter)
                                                         select a).ToList<Course>();
                foreach (Course CourseObj in linkedCoursesBindingSource.List)
                {
                    Dbconnection.Entry(CourseObj).Collection(a => a.FacilitatorAssociatedCourses).Load();
                }
            };
        }


        private void frmFacilitatorAssociatedCourses_Load(object sender, EventArgs e)
        {
            if(currentFacilitator != null)
            {
                setAvaiableCouresFilterValues();
                setLinkedCouresFilterValues();
                setSelectionControls();

                setFacilitatorDetails();
                refreshDepartment();
                refreshAvailableCourses();
                refreshLinkedCourses();
            }
            else
            {
                setAvaiableCouresFilterValues();
                setLinkedCouresFilterValues();
                setSelectionControls();
            }
           
        }

        private void setSelectionControls()
        {
            if (currentFacilitator != null)
            {
                splitContainer1.Panel2.Enabled = true;
            }
            else
            {
                splitContainer1.Panel2.Enabled = false;
            }
        }
        private void btnSelectFacilitator_Click(object sender, EventArgs e)
        {
            frmStudentSearchForFacilitator frm = new frmStudentSearchForFacilitator();
            frm.ShowDialog();
            currentFacilitator = frm.CurrentFacilitator;
            if (currentFacilitator != null)
            {
                setFacilitatorDetails();
                refreshDepartment();
                refreshAvailableCourses();
                refreshLinkedCourses();

            }

        }
        private void setFacilitatorDetails()
        {
            this.txtFacilitator.Text = currentFacilitator.Individual.IndividualFirstName + " " + currentFacilitator.Individual.IndividualSecondName + " " + currentFacilitator.Individual.IndividualLastname;
        }

        private void cboDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshAvailableCourses();
            this.refreshLinkedCourses();
        }

        private void btnLinkCourse_Click(object sender, EventArgs e)
        {
            dgvAvailableCourses.EndEdit();
            using (var Dbconnection = new MCDEntities())
            {
                List<FacilitatorAssociatedCourse> CoursesToBeLinked = new List<FacilitatorAssociatedCourse>();

                foreach (DataGridViewRow currentRow in dgvAvailableCourses.Rows)
                {
                    DataGridViewCheckBoxCell chk = currentRow.Cells[SelectCourses.Index] as DataGridViewCheckBoxCell;

                    if (chk.Value != null)
                    {
                        FacilitatorAssociatedCourse linkCourseToFacilitator = new FacilitatorAssociatedCourse
                        {
                            CourseID = ((Course)currentRow.DataBoundItem).CourseID,
                            IndividualID = currentFacilitator.FacilitatorID
                        };
                        CoursesToBeLinked.Add(linkCourseToFacilitator);
                    }
                }
                Dbconnection.FacilitatorAssociatedCourses.AddRange(CoursesToBeLinked);
                Dbconnection.SaveChanges();
            }
            this.refreshAvailableCourses();
            this.refreshLinkedCourses();

        }


        private void tbnRemoveCourse_Click(object sender, EventArgs e)
        {
            dgvLinkedCourses.EndEdit();
            using (var Dbconnection = new MCDEntities())
            {
                List<FacilitatorAssociatedCourse> CoursesToBeRemoved = new List<FacilitatorAssociatedCourse>();

                foreach (DataGridViewRow currentRow in dgvLinkedCourses.Rows)
                {
                    DataGridViewCheckBoxCell chk = currentRow.Cells[chkItemToReomve.Index] as DataGridViewCheckBoxCell;

                    if (chk.Value != null)
                    {
                        Course CurrentCourse = (Course)currentRow.DataBoundItem;

                        FacilitatorAssociatedCourse LinkedFacilitatorCourse = (from a in CurrentCourse.FacilitatorAssociatedCourses
                                                                               where
                                                                               a.CourseID == CurrentCourse.CourseID &&
                                                                               a.IndividualID == currentFacilitator.FacilitatorID
                                                                               select a).FirstOrDefault<FacilitatorAssociatedCourse>();

                        Dbconnection.FacilitatorAssociatedCourses.Attach(LinkedFacilitatorCourse);
                        CoursesToBeRemoved.Add(LinkedFacilitatorCourse);
                    }
                }

                Dbconnection.FacilitatorAssociatedCourses.RemoveRange(CoursesToBeRemoved);
                Dbconnection.SaveChanges();
            }
            refreshAvailableCourses();
            refreshLinkedCourses();
        }

        private void dgvAvailableCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvLinkedCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private string AvaiableCoursesFilter { get; set; }
        private string LinkedCoursesFilter { get; set; }
        private void setAvaiableCouresFilterValues()
        {
            AvaiableCoursesFilter = txtAvailableCourseFilterCriteria.Text.ToLower().ToString();
        }
        private void setLinkedCouresFilterValues()
        {
            LinkedCoursesFilter = txtLinkedCoursesFilterCriteria.Text.ToLower().ToString();
        }
        private void btnFilterAvailableCourses_Click(object sender, EventArgs e)
        {
            setAvaiableCouresFilterValues();
            refreshAvailableCourses();
        }
        private void btnFilterAvailablCourses_Click(object sender, EventArgs e)
        {
            setAvaiableCouresFilterValues();
            refreshLinkedCourses();
        }

        private void btnFilterLinkedCourses_Click(object sender, EventArgs e)
        {
            setLinkedCouresFilterValues();
            refreshLinkedCourses();
        }

        private void tsbtnRefreshAvailableCourseSearch_Click(object sender, EventArgs e)
        {
            this.txtAvailableCourseFilterCriteria.Clear();
            setAvaiableCouresFilterValues();
            refreshAvailableCourses();
        }

        private void btnSelectAllAvailableCourses_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow currentRow in dgvAvailableCourses.Rows)
            {
                DataGridViewCheckBoxCell chk = currentRow.Cells[SelectCourses.Index] as DataGridViewCheckBoxCell;

                chk.Value = true;
               
            }
        }

        private void btnSelectAllLinkedCourses_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow currentRow in dgvLinkedCourses.Rows)
            {
                DataGridViewCheckBoxCell chk = currentRow.Cells[chkItemToReomve.Index] as DataGridViewCheckBoxCell;

                chk.Value = true;

            }
        }

        private void btnSelectNoneAvailableCourses_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow currentRow in dgvAvailableCourses.Rows)
            {
                DataGridViewCheckBoxCell chk = currentRow.Cells[SelectCourses.Index] as DataGridViewCheckBoxCell;

                chk.Value = false;

            }
        }

        private void btnSelectNoneLinkedCourses_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow currentRow in dgvLinkedCourses.Rows)
            {
                DataGridViewCheckBoxCell chk = currentRow.Cells[chkItemToReomve.Index] as DataGridViewCheckBoxCell;

                chk.Value = false;

            }
        }

        private void tsbtnRefreshLinkedCourseSearch_Click(object sender, EventArgs e)
        {
            txtLinkedCoursesFilterCriteria.Clear();
            setLinkedCouresFilterValues();
            refreshLinkedCourses();
        }
    }
}