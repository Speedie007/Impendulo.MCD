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
using Impendulo.Data.Models;


namespace Impendulo.Courses
{
    public partial class LinkCourseToDepartment : Form
    {
        public int _GlobalDepartmentID = 0;
        public LinkCourseToDepartment()
        {
            InitializeComponent();
        }

        private void LinkCourseToDepartment_Load(object sender, EventArgs e)
        {
            this.populateAvailableCourses();
        }

        private void populateAvailableCourses()
        {

            using (var dbConnection = new MCDEntities())
            {
                ////Gets a LIST of all Courses linked to theselected Department
                //////var CoursesLinkedToDepartmentEntities =
                //////    from AllCourses in dbConnection.Courses
                //////    from DepartmentCourses in AllCourses.TrainingDepartmentCourses
                //////    where DepartmentCourses.TrainingDepartmentID == _GlobalDepartmentID
                //////    select AllCourses;

                //////////Gets a LIST of all Courses
                //////var AllCoursesEntities =
                //////    from allCourses in dbConnection.Courses
                //////    select allCourses;

                //////////Returns a list of courses that are not linked to the selected Department.
                //////var CoursesNotLinkedToDepartment = AllCoursesEntities.Except(CoursesLinkedToDepartmentEntities);

                //////if (CoursesNotLinkedToDepartment != null)
                //////{
                //////    //Updates the data source of the databinding Control.
                //////    this.coursBindingSource.DataSource = CoursesNotLinkedToDepartment.ToList<Course>();
                //////}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var dbConnection = new MCDEntities())
            {
                //var _DepartmentCourse = new TrainingDepartmentCourse()
                //{

                //    //CourseID = Convert.ToInt32(lstCoursesINSERT.SelectedValue.ToString()),
                //    //TrainingDepartmentID = _GlobalDepartmentID
                //};

                //dbConnection.TrainingDepartmentCourses.Add(_DepartmentCourse);
                //dbConnection.SaveChanges();
            }
            populateAvailableCourses();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnShowInsertCourseSection_Click(object sender, EventArgs e)
        {
            this.Height = 490;
            var btn = (Button)sender;
            btn.Enabled = false;
        }

        private void btnInsertCourse_Click_1(object sender, EventArgs e)
        {
            using (var dbConnection = new MCDEntities())
            {
                //var _Course = new Course()
                //{

                //    CourseName = txtCourseNameINSERTIntoCourses.Text.ToString(),
                //    //CourseDescription = txtCourseDescriptionINSERTIntoCourses.ToString()

                //};

                //dbConnection.Courses.Add(_Course);
                dbConnection.SaveChanges();

                this.populateAvailableCourses();

                btnShowInsertCourseSection.Enabled = true;
                this.Height = 300;

            }
        }
    }
}
