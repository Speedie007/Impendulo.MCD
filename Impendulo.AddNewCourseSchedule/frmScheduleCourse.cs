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

namespace Impendulo.AddNewCourseSchedule
{
    public partial class frmScheduleCourse : Form
    {

        public System.DateTime _UserSelectedDate = new DateTime(2016,12,6);
        public frmScheduleCourse()
        {
            InitializeComponent();
        }

        private void frmScheduleCourse_Load(object sender, EventArgs e)
        {
            this.populateTrainingDepartments();
            this.populateTrainingDepartmentCourses(Convert.ToInt32(this.cboTrainingDepartments.SelectedValue.ToString()));
            this.populateScheduledDepartmentCourses(Convert.ToInt32(this.cboTrainingDepartments.SelectedValue.ToString()));
        }

        private void populateTrainingDepartments()
        {
            using (var DbConnection = new MCDEntities())
            {
                //var _TrainingDepartments = from dep in DbConnection.TrainingDepartments
                //                           select dep;

                //trainingDepartmentBindingSource.DataSource = _TrainingDepartments.ToList<TrainingDepartment>();

            }
        }
        private void populateTrainingDepartmentCourses(int _TrainingDepartmentID)
        {

            using (var dbConnection = new MCDEntities())
            {
                //dbConnection.Entry( Department).Collection(s => s.DepartmentCourses).Load();

                // LINQ Query Syntax
                ////////var nestedQueryOfDepartmentCourses = from AllCourseRows in dbConnection.Courses
                ////////                                    from DepartmentCourses in AllCourseRows.TrainingDepartmentCourses
                ////////                                    where DepartmentCourses.TrainingDepartmentID == _TrainingDepartmentID
                ////////                                    select AllCourseRows;

                ////////var nestedQueryOfDepartmentCoursesAlreadyScheduled = from AllCourses in dbConnection.Courses
                ////////                                                     //from CourseAlreadyScheduled in AllCourses.ScheduledCourses
                ////////                                                     //where CourseAlreadyScheduled.ScheduledCourseStartDate == _UserSelectedDate
                ////////                                                     select AllCourses;

                ////////var QueryOfDepartmentCourseNotYetScheduled = nestedQueryOfDepartmentCourses.Except(nestedQueryOfDepartmentCoursesAlreadyScheduled);

                ////////if (QueryOfDepartmentCourseNotYetScheduled != null)
                ////////{
                ////////    this.courseBindingSource.DataSource = QueryOfDepartmentCourseNotYetScheduled.ToList<Course>();

                ////////}

            }

        }
        private void populateScheduledDepartmentCourses(int _TrainingDepartmentID)
        {
            //using (var dbConnection = new MCDEntities())
            //{
            //    //dbConnection.Entry( Department).Collection(s => s.DepartmentCourses).Load();

            //    // LINQ Query Syntax

            //    //var iTrainingDepartmentID = Convert.ToInt32(cboTrainingDepartments.SelectedValue.ToString());
            //    var nestedQueryOfScheduledDepartmentCourses = from AllCourseRows in dbConnection.Courses
            //                                                  from AllScheduledCourses in AllCourseRows.ScheduledCourses
            //                                                  from AllTrainingDepartmentCourses in AllCourseRows.TrainingDepartmentCourses
            //                                                  where AllTrainingDepartmentCourses.TrainingDepartmentID == _TrainingDepartmentID && AllScheduledCourses.ScheduledCourseStartDate == _UserSelectedDate
            //                                                  select new
            //                                                  {
            //                                                      AllScheduledCourses.ScheduledCourseID,
            //                                                      AllCourseRows.CourseName,
            //                                                      AllScheduledCourses.ScheduledCourseStartDate
            //                                                  };
            //    dgvScheduledDepartmentCourses.DataSource = nestedQueryOfScheduledDepartmentCourses.ToList();
            //}
        }

        private void cboTrainingDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cboObj = (ComboBox)sender;

            if (cboObj.SelectedValue != null)
            {
                populateTrainingDepartmentCourses(Convert.ToInt32(cboObj.SelectedValue.ToString()));
                populateScheduledDepartmentCourses(Convert.ToInt32(cboObj.SelectedValue.ToString()));
            }
            
        }

        private void btnScheduleDepartmentCourse_Click(object sender, EventArgs e)
        {

           
                
        }
    }
}
