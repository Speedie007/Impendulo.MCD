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

namespace Impendulo.Courses.Add.MCDCourses
{
    public partial class frmAddTrainingDepartmentCourses : Form
    {
        public frmAddTrainingDepartmentCourses()
        {
            InitializeComponent();
        }
        public int TrainingDepartmentID { get; set; }
        private void btnAddTrainingDepartmentCourse_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                //var NewObj = new TrainingDepartmentCourse()
                //{
                //    TrainingDepartmentID = this.TrainingDepartmentID,
                //    TrainingDepartmentCourseName = this.txtAddTrainingDepartmentCourse.Text.ToString()
                //};
                //DbConnection.TrainingDepartmentCourses.Add(NewObj);
                DbConnection.SaveChanges();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddTrainingDepartmentCourses_Load(object sender, EventArgs e)
        {

        }
    }
}
