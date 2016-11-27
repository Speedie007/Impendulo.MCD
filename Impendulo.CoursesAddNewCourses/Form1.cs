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

namespace Impendulo.CoursesAddNewCourses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.populateTrainingDepartments();
            this.populateTrainingDepartmentSections(Convert.ToInt32(cboTrainingDepartment.SelectedValue));
        }

        private void populateTrainingDepartments()
        {
            using (var DbConnection = new MCDEntities())
            {
                //trainingDepartmentBindingSource.DataSource = DbConnection.TrainingDepartments.ToList<TrainingDepartment>();
            }
        }
        private void populateTrainingDepartmentSections(int _TrainingDepartmentID)
        {
            using (var DbConnection = new MCDEntities())
            {
                //trainingDepartmentSectionBindingSource.DataSource =
                //                        (from a in DbConnection.TrainingDepartmentSections
                //                         where a.TrainingDepartmentID == _TrainingDepartmentID
                //                         select a).ToList<TrainingDepartmentSection>();
            }
        }

        private void trainingDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cboObj = (ComboBox)sender;

            if (cboObj.SelectedValue != null)
            {
                this.populateTrainingDepartmentSections(Convert.ToInt32(cboObj.SelectedValue.ToString()));
            }


        }
    }
}
