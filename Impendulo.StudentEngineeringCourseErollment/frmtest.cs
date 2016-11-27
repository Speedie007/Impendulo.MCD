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

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment
{
    public partial class frmtest : Form
    {
        public frmtest()
        {
            InitializeComponent();
        }

        private void frmtest_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                enrollmentBindingSource.DataSource = (from a in Dbconnection.Enrollments
                                                     
                                                     
                                                          //from b in a.ApprienticeshipEnrollment.LookupSectionalEnrollmentType
                                                          //from b in a.Student.StudentAssociatedCompanies
                                                          //from c in b..CompanyName
                                                      orderby a.DateIntitiated descending
                                                      where a.EnrolmentParentID == 0
                                                      select a)
                                                      .Include("ApprienticeshipEnrollment")
                                                      .Include("ApprienticeshipEnrollment.LookupSectionalEnrollmentType")
                                                      .Include("CurriculumCourseEnrollments")
                                                      .Include("Student")
                                                      .Include("Student.Individual")
                                                      .Include("Student.StudentAssociatedCompanies")
                                                      .Include("Student.StudentAssociatedCompanies.Company")

                                    //.Include("Individuals.ContactDetails")
                                    //.Include("Individuals.LookupTitle")
                                    //.Include("Individuals.ContactDetails.LookupContactType")
                                    //.Include("Companies")
                                    //.Include("CurriculumEnquiries.Enrollments")
                                    .ToList<Enrollment>();
            };

        }

        private void enrollmentDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Enrollment EnrollmentObj = (Enrollment)(row.DataBoundItem);
                   // EnrollmentObj.CurriculumCourseEnrollments
                    //if (EnrollmentObj.ApprienticeshipEnrollment != null)
                    //{
                    //    row.Cells[colApprenticeshipSection.Index].Value = EnrollmentObj.ApprienticeshipEnrollment.LookupSectionalEnrollmentType.LookupSectionalEnrollmentTypeName.ToString();
                    //}
                    var CurriculumEnquiryObj = EnrollmentObj.CurriculumEnquiries.FirstOrDefault<CurriculumEnquiry>(); ;
                    //if (CurriculumEnquiryObj != null)
                    //{
                    //    row.Cells[colApprenticeshipEnqiry.Index].Value = CurriculumEnquiryObj.EnquiryID.ToString();
                    //}


                }
            }
        }
    }
}
