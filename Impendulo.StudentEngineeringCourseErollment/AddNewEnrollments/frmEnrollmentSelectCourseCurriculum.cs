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
using Impendulo.Common.Enum;

namespace Impendulo.Enrollments.Development
{
    public partial class frmEnrollmentSelectCourseCurriculum : Form
    {
        public frmEnrollmentSelectCourseCurriculum()
        {
            InitializeComponent();
        }

        private void populateEnrollmentTypeRadioButtons()
        {

            using (var Dbconnection = new MCDEntities())
            {
                List<LookupSectionalEnrollmentType> lstSet = (from a in Dbconnection.LookupSectionalEnrollmentTypes
                                                              select a).ToList<LookupSectionalEnrollmentType>();
                buildRadioButtons(lstSet);
            };
        }
        private void buildRadioButtons(List<LookupSectionalEnrollmentType> ObjList)
        {
            Boolean IsFirst = true;
            foreach (LookupSectionalEnrollmentType set in ObjList)
            {
                RadioButton radButton = new RadioButton();
                radButton.Text = set.LookupSectionalEnrollmentTypeName;
                radButton.Tag = set.LookupSectionalEnrollmentTypeID;
                radButton.Click += RadButton_Click;
                if (IsFirst)
                {
                    IsFirst = false;
                    radButton.Checked = true;
                };
                flowLayoutPanelEnrollmentTypes.Controls.Add(radButton);
            }

        }

        private void RadButton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void populateApperienticeshipCurriculum()
        {

            using (var Dbconnection = new MCDEntities())
            {
                curriculumBindingSource.DataSource = (from a in Dbconnection.Curriculums
                                                      where a.DepartmentID == (int)EnumDepartments.Apprenticeship
                                                      select a).ToList<Curriculum>();
            };
        }

        private void frmEnrollmentSelectCourseCurriculum_Load(object sender, EventArgs e)
        {
            this.populateEnrollmentTypeRadioButtons();
            this.populateApperienticeshipCurriculum();
        }

        private void dgvCurriculum_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //CurriculumSelectCol
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                   
                    row.Cells[CurriculumSelectCol.Index].Value = "Select";
                }
            }
        }

        private void dgvCurriculum_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvCurriculum.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
        }
    }
}
