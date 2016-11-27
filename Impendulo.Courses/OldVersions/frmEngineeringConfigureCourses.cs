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
    public partial class frmEngineeringConfigureCourses : Form
    {
        //int _CourseID;
        public string _CourseType;
        public frmEngineeringConfigureCourses()
        {
            InitializeComponent();
        }

        private void frmEngineeringConfigureCourses_Load(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                //this._CourseID = (from a in DbConnection.Courses
                //                  where a.CourseName == _CourseType
                //                  select a).FirstOrDefault<Course>().CourseID;
            }
        }

        private void btnApprenticeshipAddNew_Click(object sender, EventArgs e)
        {
            var frm = new frmAddNewCourse();
            //frm._CourseID = _CourseID;
            //frm.ShowDialog();
            //populateCourseCategoriesLinkedtoTrainingDepartment(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
        }
    }
}
