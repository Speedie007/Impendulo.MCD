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
using System.Globalization;

namespace Impendulo.Courses.InputForms.Development
{
    public partial class frmUpdateCurriculumCourse : Form
    {
        public int CurriculumCourseID { get; set; }
        public frmUpdateCurriculumCourse()
        {
            InitializeComponent();
        }

        private void frmUpdateCurriculumCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateCurriculumCourse_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                CurriculumCourse courseObj = (from a in Dbconnection.CurriculumCourses
                                              where a.CurriculumCourseID == this.CurriculumCourseID
                                              select a).FirstOrDefault<CurriculumCourse>();

                courseObj.Cost = Convert.ToDecimal(txtCourseCost.Text);
                courseObj.Duration = Convert.ToInt32(nudCourseDuration.Value);
                courseObj.CurriculumCourseMinimumMaximum.CurriculumCourseMaximum = Convert.ToInt32(nudCourseMaximumAllowed.Value);
                courseObj.CurriculumCourseMinimumMaximum.CurriculumCourseMinimum= Convert.ToInt32(nudCourseMinimumAllowed.Value);
                courseObj.CurricullumCourseCode.CurricullumCourseCodeValue = txtCourseCourseCode.Text;


                //Dbconnection.CurriculumCourses.Add()
                Dbconnection.SaveChanges();
                this.Close();
            };
        }
    }
}
