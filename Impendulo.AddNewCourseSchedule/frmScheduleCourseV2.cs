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
    public partial class frmScheduleCourseV2 : Form
    {
        public System.DateTime _UserSelectedDate = new DateTime(2016, 12, 7);
        public frmScheduleCourseV2()
        {
            InitializeComponent();
        }

        private void frmScheduleCourseV2_Load(object sender, EventArgs e)
        {
            this.populateTrainingDepartments();
            this.populateTrainingDepartmentCourses(Convert.ToInt32(this.cboTrainingDepartments.SelectedValue.ToString()));
            this.populateScheduledDepartmentCourses(Convert.ToInt32(this.cboTrainingDepartments.SelectedValue.ToString()));
        }

        #region "Populate Controls"
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

                //var test = from a in dbConnection.TrainingDepartmentCourses
                //           from b in a.ScheduledTrainingDepartmentCourses
                //           where a.TrainingDepartmentID == _TrainingDepartmentID && b.ScheduledTrainingDepartmentCourseStartDate == _UserSelectedDate
                //           select a.Course;

                // LINQ Query Syntax
                //var nestedQueryOfDepartmentCourses = from AllCourseRows in dbConnection.Courses
                //                                     from DepartmentCourses in AllCourseRows.TrainingDepartmentCourses
                //                                     where DepartmentCourses.TrainingDepartmentID == _TrainingDepartmentID
                //                                     select AllCourseRows;

                //var nestedQueryOfDepartmentCoursesAlreadyScheduled = from a in dbConnection.TrainingDepartmentCourses
                //                                                     from b in a.ScheduledTrainingDepartmentCourses
                //                                                     where a.TrainingDepartmentID == _TrainingDepartmentID &&
                //                                                            b.ScheduledTrainingDepartmentCourseStartDate == _UserSelectedDate
                //                                                     select a.Course;


                //var QueryOfDepartmentCourseNotYetScheduled = nestedQueryOfDepartmentCourses
                //                                                .Except(nestedQueryOfDepartmentCoursesAlreadyScheduled);

                //this.courseBindingSource.DataSource = QueryOfDepartmentCourseNotYetScheduled.ToList<Course>();



            }

        }
        private void populateScheduledDepartmentCourses(int _TrainingDepartmentID)
        {

            //var _TrainingDepartmentCourseID = 0;
            // var _CourseID = Convert.ToInt32(this.lstCoursePerDepartment.SelectedValue.ToString());
            using (var dbConnection = new MCDEntities())
            {
                //{

                //    var nestedQueryOfDepartmentCoursesAlreadyScheduled = from a in dbConnection.TrainingDepartmentCourses
                //                                                     from b in a.ScheduledTrainingDepartmentCourses
                //                                                     where a.TrainingDepartmentID == _TrainingDepartmentID &&
                //                                                            b.ScheduledTrainingDepartmentCourseStartDate == _UserSelectedDate
                //                                                     select a.Course;

                //_TrainingDepartmentCourseID = (from s in dbConnection.TrainingDepartmentCourses
                //       where s.CourseID == _CourseID && s.TrainingDepartmentID == _TrainingDepartmentID
                //                                 select s).FirstOrDefault<TrainingDepartmentCourse>().TrainingDepartmentCourseID;

                //var nestedQueryOfScheduledDepartmentCourses = from a in dbConnection.TrainingDepartmentCourses
                //                                              from b in a.ScheduledTrainingDepartmentCourses
                //                                              where a.TrainingDepartmentID == _TrainingDepartmentID &&
                //                                                     b.ScheduledTrainingDepartmentCourseStartDate == _UserSelectedDate
                //                                              select new
                //                                              {
                //                                                  a.Course,
                //                                                  b.ScheduledTrainingDepartmentCourseID,
                //                                                  b.ScheduledTrainingDepartmentCourseStartDate
                //                                              };

                //var nestedQueryOfScheduledDepartmentCourses = from a in dbConnection.Courses
                //                                              from b in a.TrainingDepartmentCourses
                //                                              from c in b.ScheduledTrainingDepartmentCourses
                //                                              where b.TrainingDepartmentID == _TrainingDepartmentID &&
                //                                                     c.ScheduledTrainingDepartmentCourseStartDate == _UserSelectedDate
                //                                              select new
                //                                              {
                //                                                  c.ScheduledTrainingDepartmentCourseID,
                //                                                  a.CourseName,
                //                                                  c.ScheduledTrainingDepartmentCourseStartDate
                //                                              };
                //dgvScheduledDepartmentCourses.DataSource = nestedQueryOfScheduledDepartmentCourses.ToList();
                //this.ScheduledDepartmentCourseBindingSource.DataSource = nestedQueryOfScheduledDepartmentCourses.ToList();
                //this.bindingNavigator1.BindingSource = ScheduledDepartmentCourseBindingSource;
                //dgvScheduledDepartmentCourses.DataSource = this.ScheduledDepartmentCourseBindingSource;



            }


            ////var nestedQueryOfDepartmentCourses = from AllCourseRows in dbConnection.Courses
            ////                                     from DepartmentCourses in AllCourseRows.TrainingDepartmentCourses
            ////                                     where DepartmentCourses.TrainingDepartmentID == _TrainingDepartmentID
            ////                                     select AllCourseRows;


            ////using (var dbConnection = new MCDEntities())
            ////{
            ////    //dbConnection.Entry( Department).Collection(s => s.DepartmentCourses).Load();

            ////    // LINQ Query Syntax

            ////    //var iTrainingDepartmentID = Convert.ToInt32(cboTrainingDepartments.SelectedValue.ToString());
            ////    var nestedQueryOfScheduledDepartmentCourses = from AllCourseRows in dbConnection.Courses
            ////                                                  from AllScheduledCourses in AllCourseRows.ScheduledCourses
            ////                                                  from AllTrainingDepartmentCourses in AllCourseRows.TrainingDepartmentCourses
            ////                                                  where AllTrainingDepartmentCourses.TrainingDepartmentID == _TrainingDepartmentID && AllScheduledCourses.ScheduledCourseStartDate == _UserSelectedDate
            ////                                                  select new
            ////                                                  {
            ////                                                      AllScheduledCourses.ScheduledCourseID,
            ////                                                      AllCourseRows.CourseName,
            ////                                                      AllScheduledCourses.ScheduledCourseStartDate
            ////                                                  };
            ////    dgvScheduledDepartmentCourses.DataSource = nestedQueryOfScheduledDepartmentCourses.ToList();
            ////}
        }
        #endregion

        #region "Index Changed Controls"
        private void cboTrainingDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cboObj = (ComboBox)sender;

            if (cboObj.SelectedValue != null)
            {
                populateTrainingDepartmentCourses(Convert.ToInt32(cboObj.SelectedValue.ToString()));
                populateScheduledDepartmentCourses(Convert.ToInt32(cboObj.SelectedValue.ToString()));
            }
        }
        #endregion

        private void btnScheduleDepartmentCourse_Click(object sender, EventArgs e)
        {

            if (this.lstCoursePerDepartment.SelectedValue != null)
            {
                //int _TrainingDepartmentCourseID = 0;
                //int _TrainingDepartmentID = Convert.ToInt32(this.cboTrainingDepartments.SelectedValue.ToString());
                //int _CourseID = Convert.ToInt32(this.lstCoursePerDepartment.SelectedValue.ToString());

                using (var DbConnection = new MCDEntities())
                {
                    //_TrainingDepartmentCourseID = (from s in DbConnection.TrainingDepartmentCourses
                    //                               where s.CourseID == _CourseID && s.TrainingDepartmentID == _TrainingDepartmentID
                    //                               select s).FirstOrDefault<TrainingDepartmentCourse>().TrainingDepartmentCourseID;

                    //var _ScheduledTrainingDepartmentCourse = new ScheduledTrainingDepartmentCourse()
                    //{
                    //    TrainingDepartmentCourseID = _TrainingDepartmentCourseID,
                    //    ScheduledTrainingDepartmentCourseStartDate = _UserSelectedDate
                    //};
                    ////Add ScheduledTrainingDepartmentCourse object into ScheduledTrainingDepartmentCourses DBset
                    //DbConnection.ScheduledTrainingDepartmentCourses.Add(_ScheduledTrainingDepartmentCourse);

                    //// call SaveChanges method to save ScheduledTrainingDepartmentCourse into database
                    //DbConnection.SaveChanges();

                }
                populateTrainingDepartmentCourses(Convert.ToInt32(cboTrainingDepartments.SelectedValue.ToString()));
                populateScheduledDepartmentCourses(Convert.ToInt32(cboTrainingDepartments.SelectedValue.ToString()));
            }
            
            
        }

      
        private void bindingNavigator1_Click(object sender, EventArgs e)
        {
            if (dgvScheduledDepartmentCourses.RowCount > 0)
            {
                var iID = Convert.ToInt32(dgvScheduledDepartmentCourses.SelectedCells[0].Value.ToString());

                using (var DbConnection = new MCDEntities())
                {

                    var asdfa = from a in DbConnection.LookupProvinces
                                select a;


                    //var objScheduledTrainingDepartmentCourse = (from a in DbConnection.ScheduledTrainingDepartmentCourses
                    //                                            where a.ScheduledTrainingDepartmentCourseID == iID
                    //                                            select a).FirstOrDefault<ScheduledTrainingDepartmentCourse>();

                    //DbConnection.ScheduledTrainingDepartmentCourses.Remove(objScheduledTrainingDepartmentCourse);

                    //Execute Inser, Update & Delete queries in the database
                    DbConnection.SaveChanges();
                }
                
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            populateTrainingDepartmentCourses(Convert.ToInt32(cboTrainingDepartments.SelectedValue.ToString()));
            populateScheduledDepartmentCourses(Convert.ToInt32(cboTrainingDepartments.SelectedValue.ToString()));
        }
    }
}
