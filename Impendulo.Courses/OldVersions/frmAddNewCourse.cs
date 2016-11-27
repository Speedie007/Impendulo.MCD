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
    public partial class frmAddNewCourse : Form
    {
        public int _CourseID = 0;
        public frmAddNewCourse()
        {
            InitializeComponent();
        }

        private void frmAddNewCourseCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourseCategory_Click(object sender, EventArgs e)
        {
            //var CourseObj = new ApprenticeshipCourse()
            //{
            //     ApprenticeshipCourseName  = txtCourse.Text.ToString(),
            //     CourseID = _CourseID
            //};
            //using (var DbConnection = new MCDEntities())
            //{

            //    DbConnection.ApprenticeshipCourses.Add(CourseObj);
            //    DbConnection.SaveChanges();
            //    this.Close();

            //}

        }
    }
}
