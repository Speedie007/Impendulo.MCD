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

namespace Impendulo.Courses
{
    public partial class CourseAdministrationV5 : Form
    {
        MCDEntities DbConnection;
        Boolean _IsLoading = false;
        public CourseAdministrationV5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbConnection = new MCDEntities();

            _IsLoading = true;

            populateTrainingDepartments();
            populateTrainingDepartmentCourses(Convert.ToInt32(lstTrainingDepartments.SelectedValue));
            populateCourses(Convert.ToInt32(lstTrainingDepartmentCoures.SelectedValue));

            int _CourseID = Convert.ToInt32(dgvCoures.SelectedRows[0].Cells[0].Value);
            populateCourseEnrollmentTypes(_CourseID);
            populateSetaCourseAccreditations(_CourseID);
        }

        #region "Populate Methods"
        private void populateTrainingDepartments()
        {
            this.trainingDepartmentBindingSource.DataSource = DbConnection.TrainingDepartments.ToList<TrainingDepartment>();
        }
        private void populateTrainingDepartmentCourses(int _TrainingDepartmentID)
        {
            //this.trainingDepartmentCourseBindingSource.DataSource = (from a in DbConnection.TrainingDepartments
            //                                                         from b in a.TrainingDepartmentCourses
            //                                                         where b.TrainingDepartmentID == _TrainingDepartmentID
            //                                                         select b).ToList<TrainingDepartmentCourse>();

        }
        private void populateCourses(int _TrainingDepartmentCourseID)
        {
            //this.courseBindingSource.DataSource = (from a in DbConnection.Courses
            //                                       where a.TrainingDepartmentCourseID == _TrainingDepartmentCourseID
            //                                       select a).ToList<Course>();
        }
        private void populateCourseEnrollmentTypes(int _CourseID)
        {
            //this.courseEnrollmentTypeBindingSource.DataSource = (from a in DbConnection.CourseEnrollmentTypes
            //                                                     where a.CourseID == _CourseID
            //                                                     select a).ToList<CourseEnrollmentType>();
        }

        private void populateSetaCourseAccreditations(int _CourseID)
        {
            //this.setaBindingSource.DataSource = (from a in DbConnection.Setas.Include("Courses")
            //                                     where a.Courses.Any(c => c.CourseID == _CourseID)
            //                                     select a
            //                                    ).ToList<Seta>();

            //DbConnection.Setas.Include("Courses").FirstOrDefault();
            ////          var tripWithActivities = DbConnection.Setas
            ////.Include("Course").FirstOrDefault();


            //var query = from article in DbConnection..Articles
            //            where article.Categories.Any(c => c.Category_ID == cat_id)
            //            select article;
        }


        #endregion


        private void dgvCoures_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Selected)
                    {
                        _IsLoading = false;
                       // var a = row.Cells[courseIDDataGridViewTextBoxColumn.Name].Value;
                    }
                    //var reservation = (TrainingDepartmentCourse)(row.DataBoundItem);
                    //TrainingDepartmentCourse trip = 
                    //    (TrainingDepartmentCourse)(
                    //                    from a in reservation.TrainingDepartmentCourses
                    //                    select a);

                    //row.Cells[ tr.Index].Value = trip.ToShortDateString();
                    //row.Cells[tripEndColumn.Index].Value = trip.EndDate.ToShortDateString();
                    //row.Cells[destinationColumn.Index].Value = trip.Destination.Name;
                }
            }

        }

        private void lstTrainingDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //populateTrainingDepartmentCourses(Convert.ToInt32(lstTrainingDepartments.SelectedValue));
            _IsLoading = true;
            //resetTrainingDepartmentCategoryAndCouresAndCourseModules();
            var TrainingDepartmentID = 0;
            var TrainingDepartmentCourseID = 0;
            var CourseID = 0;

            //Must Build the Course Categories
            if (this.lstTrainingDepartments.SelectedValue != null) { TrainingDepartmentID = Convert.ToInt32(this.lstTrainingDepartments.SelectedValue.ToString()); }
            //populate Course Categories Linked to Training Department
            this.populateTrainingDepartmentCourses(TrainingDepartmentID);

            if (this.lstTrainingDepartmentCoures.SelectedValue != null) { TrainingDepartmentCourseID = Convert.ToInt32(lstTrainingDepartmentCoures.SelectedValue.ToString()); }
            //Populate Courses Linked To the Training Department Catergory
            this.populateCourses(TrainingDepartmentCourseID);

            if (this.dgvCoures.Rows.Count > 0) {
                if(dgvCoures.SelectedRows[0].Cells[0].Value != null)
                {
                    CourseID = Convert.ToInt32(dgvCoures.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            //populates the Course Modules Linked to Course
            this.populateSetaCourseAccreditations(CourseID);
            this.populateCourseEnrollmentTypes(CourseID);
        }

        private void dgvCoures_SelectionChanged(object sender, EventArgs e)
        {
            if (!_IsLoading)
            {
                int _CourseID = 0;
                if (dgvCoures.SelectedRows.Count > 0) { _CourseID = Convert.ToInt32(dgvCoures.SelectedRows[0].Cells[0].Value); }
                populateCourseEnrollmentTypes(_CourseID);
                populateSetaCourseAccreditations(_CourseID);
            }
        }

        private void lstTrainingDepartmentCoures_SelectedIndexChanged(object sender, EventArgs e)
        {
            //resetTrainingDepartmentCategoryAndCouresAndCourseModules();
            // var TrainingDepartmentID = 0;
            var TrainingDepartmentCourseID = 0;
            var CourseID = 0;
            _IsLoading = true;
            ////Must Build the Course Categories
            //if (this.lstTrainingDepartments.SelectedValue != null) { TrainingDepartmentID = Convert.ToInt32(this.lstTrainingDepartments.SelectedValue.ToString()); }
            ////populate Course Categories Linked to Training Department
            //this.populateTrainingDepartmentCourses(TrainingDepartmentID);

            if (this.lstTrainingDepartmentCoures.SelectedValue != null) { TrainingDepartmentCourseID = Convert.ToInt32(lstTrainingDepartmentCoures.SelectedValue.ToString()); }
            //Populate Courses Linked To the Training Department Catergory
            this.populateCourses(TrainingDepartmentCourseID);

            if (this.dgvCoures.Rows.Count > 0) {
                if (dgvCoures.SelectedRows[0].Cells[0].Value != null)
                {
                    CourseID = Convert.ToInt32(dgvCoures.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            //populates the Course Modules Linked to Course
            this.populateSetaCourseAccreditations(CourseID);
            this.populateCourseEnrollmentTypes(CourseID);
        }

        private void dgvCourseEnrolmentProperties_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    //var CET = (CourseEnrollmentType)(row.DataBoundItem);
                    //var C = CET.Course;
                    //var LET = CET.LookupEnrollmentType;

                    //row.Cells[UnboundCourseName.Index].Value = C.CourseName.ToString();
                    //row.Cells[EnrollmentType.Index].Value = LET.EnrollmentType.ToString();
                }
            }
        }

        
    }
}
