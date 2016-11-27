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
    public partial class frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData : Form
    {
        public frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData()
        {
            InitializeComponent();
        }

        public int TrainingDepartmentCourseMetaDataID { get; set; }

        private void frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData_Load(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                lookupEnrollmentTypeBindingSource.DataSource = (from a in DbConnection.LookupEnrollmentTypes
                                                                select a).ToList<LookupEnrollmentType>();

            }
        }

        private void btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData_Click(object sender, EventArgs e)
        {
            //TrainingDepartmentCourseEnrollmentTypeMetaData TDCETMD = new TrainingDepartmentCourseEnrollmentTypeMetaData()
            //{
            //    TrainingDepartmentCourseMetaDataID = this.TrainingDepartmentCourseMetaDataID,
            //    EnrollmentTypeID = Convert.ToInt32(cboEnrollmentTypes.SelectedValue),
            //    TrainingDepartmentCourseMetaDataDescription = txtDesciption.Text.ToString(),
            //    TrainingDepartmentCourseMetaDataCourseCost = Convert.ToDecimal(txtCost.Text),
            //    TrainingDepartmentCourseMetaDataMaximunAllowed = Convert.ToInt32(txtMaximum.Text),
            //    TrainingDepartmentCourseMetaDataMinimunAllowed = Convert.ToInt32(txtMinimum.Text)
            //};

            //using (var DbConnection = new MCDEntities())
            //{
            //    DbConnection.TrainingDepartmentCourseEnrollmentTypeMetaDatas.Add(TDCETMD);
            //    DbConnection.SaveChanges();
            //}
            //this.Close();
        }
    }
}
