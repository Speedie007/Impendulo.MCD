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

namespace Impendulo.Courses.InputForms.Development
{
    public partial class frmAddCurriculum : Form
    {
        public frmAddCurriculum()
        {
            InitializeComponent();
        }

        public int DepartmentID { get; set; }
        public Boolean IsSquenced { get; set; }
        public string CurriculumName { get; set; }
        public int CostingModelID { get; set; }
        public Boolean IsUpdating { get; set; }
        public int CurriculumID { get; set; }

        private void frmAddTrainingDepartment_Load(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                costingModelBindingSource.DataSource = Dbconnection.CostingModels.ToList<CostingModel>();
            };

            if (IsUpdating)
            {
                cboCostingModel.SelectedValue = this.CostingModelID;
                txtAddCurriculum.Text = this.CurriculumName;
                chkIsSequencedCourse.Checked = this.IsSquenced;
                this.btnAddTrainingDepartment.Text = "Update";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTrainingDepartment_Click(object sender, EventArgs e)
        {
            if (btnAddTrainingDepartment.Text.ToLower().Equals("update"))
            {
                using (var DbConnection = new MCDEntities())
                {
                    Curriculum UpdateCurriculumObj = (from a in DbConnection.Curriculums
                                                      where a.CurriculumID == this.CurriculumID
                                                      select a).FirstOrDefault<Curriculum>();

                    UpdateCurriculumObj.DepartmentID = this.DepartmentID;
                    UpdateCurriculumObj.CostingModelID = Convert.ToInt32(this.cboCostingModel.SelectedValue);
                    UpdateCurriculumObj.CurriculumName = txtAddCurriculum.Text;
                    UpdateCurriculumObj.CurriculumIsSequenced = chkIsSequencedCourse.Checked;
                    DbConnection.Entry(UpdateCurriculumObj).State = System.Data.Entity.EntityState.Modified;
                    DbConnection.SaveChanges();
                    this.Close();

                };
            }
            else
            {
                using (var DbConnection = new MCDEntities())
                {
                    Curriculum newCurriculum = new Curriculum()
                    {
                        DepartmentID = this.DepartmentID,
                        CostingModelID = Convert.ToInt32(this.cboCostingModel.SelectedValue),
                        CurriculumName = txtAddCurriculum.Text,
                        CurriculumIsSequenced = chkIsSequencedCourse.Checked
                    };
                    DbConnection.Curriculums.Add(newCurriculum);

                    DbConnection.SaveChanges();
                    this.Close();


                };
            }
        }
    }
}
