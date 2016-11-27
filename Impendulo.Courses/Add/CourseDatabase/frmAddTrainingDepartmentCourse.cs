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

namespace Impendulo.Courses.Add.CourseDatabase
{
    public partial class frmAddTrainingDepartmentCourse : Form
    {
        public frmAddTrainingDepartmentCourse()
        {
            InitializeComponent();
        }


        public int TrainingDepartmentID { get; set; }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTrainingDepartmentCourse_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                //TrainingDepartmentCourseMetaData TDCMD = new TrainingDepartmentCourseMetaData()
                //{
                //    TrainingDepartmentCourseMetaDataCourseName = this.txtAddTrainingDepartmentCourse.Text.ToString(),
                //    TrainingDepartmentCourseMetaDataCourseDescription = this.txtAddTrainingDepartmentCourseDescription.Text.ToString(),
                //    TrainingDepartmentID = this.TrainingDepartmentID

                //};

                //DbConnection.TrainingDepartmentCourseMetaDatas.Add(TDCMD);

                DbConnection.SaveChanges();
                this.Close();
            }
        }

        private void frmAddTrainingDepartmentCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
