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
    public partial class frmAddTrainingDepartment : Form
    {
        public frmAddTrainingDepartment()
        {
            InitializeComponent();
        }

        public int DepartmentID { get; set; }
        public Impendulo.Courses.CourseAdministrationV6cs myParentForm { get; set; }
        private void frmAddTrainingDepartment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTrainingDepartment_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                //TrainingDepartment newTrainDep = new TrainingDepartment()
                //{
                //    DepartmentID = this.DepartmentID,
                //    TrainingDepartmentName = this.txtAddDepartment.Text.ToString()
                //};
                //DbConnection.TrainingDepartments.Add(newTrainDep);

                DbConnection.SaveChanges();
                this.Close();


            }
        }
    }
}
