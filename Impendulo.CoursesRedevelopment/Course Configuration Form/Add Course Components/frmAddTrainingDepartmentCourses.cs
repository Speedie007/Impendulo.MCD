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
using System.Data.Entity.Validation;

namespace Impendulo.Courses.InputForms.Development
{
    public partial class frmAddTrainingDeparmentCourses : Form
    {
        public int TrainingDepartmentID { get; set; }
        public frmAddTrainingDeparmentCourses()
        {
            InitializeComponent();
        }

        private void frmAddCourses_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            try
            {
                using (var DbConnection = new MCDEntities())
                {
                    //TrainingDepartmentCourse newCourse = new TrainingDepartmentCourse()
                    //{
                    //     TrainingDepartmentCourseName = this.txtCourse.Text.ToString(),
                    //    TrainingDepartmentID = this.TrainingDepartmentID
                    //};

                    //DbConnection.TrainingDepartmentCourses.Add(newCourse);
                    //DbConnection.SaveChanges();
                    this.Close();
                }

            }
            catch (DbEntityValidationException ex)
            {
                var error = ex.EntityValidationErrors.First().ValidationErrors.First();
                MessageBox.Show(ex.Message);
            }
            catch(System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                
                //var error = ex.EntityValidationErrors.First().ValidationErrors.First();
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
