using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentCourseSelection
{
    public partial class frmEnrollmentCourseSelection : Form
    {
        public frmEnrollmentCourseSelection()
        {
            InitializeComponent();

            using (var Dbconnection = new MCDEntities())
            {
                CurrentEnrollemnt = (from a in Dbconnection.Enrollments
                                     orderby a.DateIntitiated descending
                                     select a).FirstOrDefault<Enrollment>();
            };
        }

        public Enrollment CurrentEnrollemnt { get; set; }

        private void frmEnrollmentCourseSelection_Load(object sender, EventArgs e)
        {

            
        }

        private void populateLinkedEnrollment()
        {
            using (var Dbconnection = new MCDEntities())
            {
                Dbconnection.Enrollments.Attach(CurrentEnrollemnt);
                CurrentEnrollemnt.CurriculumCourseEnrollments = null;

                Dbconnection.Entry(CurrentEnrollemnt).Collection<CurriculumCourseEnrollment>("CurriculumCourseEnrollments").Load();

            };
        }
    }
}
