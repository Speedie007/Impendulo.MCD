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

namespace Impendulo.Courses.SummaryForms.Deployment
{
    public partial class frmCurriculumCourseSummary : Form
    {
        public int CurriculumID { get; set; }
        public string CurriculumName { get; set; }
        public frmCurriculumCourseSummary()
        {
            InitializeComponent();
        }

        private void frmCurriculumCourseSummary_Load(object sender, EventArgs e)
        {
            List<CurriculumCourse> AllCurriculumCourses;

            using (var Dbconnection = new MCDEntities())
            {
                AllCurriculumCourses = (from a in Dbconnection.CurriculumCourses
                                        where a.CurriculumID == this.CurriculumID
                                        select a).ToList<CurriculumCourse>();
            };

            if (AllCurriculumCourses.Count > 0)
            {
                txtCurriculum.Text = this.CurriculumName;
                txtCourseTotalCost.Text = (AllCurriculumCourses.Sum(a => a.Cost)).ToString("C", CultureInfo.CurrentCulture);
                txtCourseTotalDuration.Text = (Convert.ToInt32(AllCurriculumCourses.Sum(a => a.Duration))).ToString();
                txtTotalAmountOdCourses.Text = (Convert.ToInt32(AllCurriculumCourses.Count)).ToString();
            }
        }
    }
}
