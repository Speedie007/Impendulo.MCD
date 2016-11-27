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

namespace Impendulo.Courses.InputForms.Deployment
{
    public partial class frmAddModuleActivities : Form
    {
        public frmAddModuleActivities()
        {
            InitializeComponent();
        }
        public int CurriculumCourseID { get; set; }
        public int ModuleID { get; set; }

        #region "Populate Module Activities"
        private void populateModules()
        {
            using (var DbConnection = new MCDEntities())
            {
                bindingSourceModules.DataSource = (from a in DbConnection.Modules
                                                   orderby a.ModuleName
                                                   select a).ToList<Module>();
                cboModules.SelectedValue = this.ModuleID;
            }
        }
        private void populateAvailableModuleActivities()
        {
            using (var DbConnection = new MCDEntities())
            {
                int ModID = Convert.ToInt32(cboModules.SelectedValue);
                List<Activity> AvailableModuleActivities = (from a in DbConnection.Activities
                                                            where a.ModuleID == ModID
                                                            select a).Except(from a in DbConnection.Activities
                                                                             from b in a.CurriculumCourseModules
                                                                             where b.ModuleID == this.ModuleID &&
                                                                                        b.CurriculumCourseID == this.CurriculumCourseID
                                                                             select a).ToList<Activity>();
                bindingSourceAvailableModuleActivities.DataSource = (from a in AvailableModuleActivities
                                                                     orderby a.ActivityCode
                                                                     select a).ToList<Activity>();
            }

        }

        private void populateLinkedModuleActivities()
        {
            using (var DbConnection = new MCDEntities())
            {
                int ModID = Convert.ToInt32(cboModules.SelectedValue);
                List<Activity> LinkedModuleActivities = (from a in DbConnection.Activities
                                                         from b in a.CurriculumCourseModules
                                                         where b.ModuleID == this.ModuleID &&
                                                                    b.CurriculumCourseID == this.CurriculumCourseID
                                                         select a).ToList<Activity>();
                bindingSourceLinkedModuleActivities.DataSource = (from a in LinkedModuleActivities
                                                                  orderby a.ActivityCode
                                                                  select a).ToList<Activity>();
            }
        }
        #endregion

        private void btnLinkActivities_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {


                /*
                * this steps follow to both entities
                * 
                * 1 - create instance of entity with relative primary key
                * 
                * 2 - add instance to context
                * 
                * 3 - attach instance to context
                */
                int ModID = Convert.ToInt32(cboModules.SelectedValue);
                CurriculumCourseModule ab = (from a in DbConnection.CurriculumCourseModules
                                                                   where a.ModuleID == this.ModuleID &&
                                                                              a.CurriculumCourseID == this.CurriculumCourseID
                                                                   select a).FirstOrDefault<CurriculumCourseModule>();

                Activity ActivityObj = (Activity)this.bindingSourceAvailableModuleActivities.Current;
                ////// 1
                Activity ac = new Activity {
                    ActivityID = ActivityObj.ActivityID,
                      
                };
                ////// 2
                DbConnection.Activities.Add(ac);
                ////// 3
                DbConnection.Activities.Attach(ac);

                // like previous method add instance to navigation property
                ab.Activities.Add(ac);

                // call SaveChanges
                DbConnection.SaveChanges();
            };
            this.populateAvailableModuleActivities();
            this.populateLinkedModuleActivities();
            this.setAddRemoveControls();
        }

        private void btnRemoveActivities_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                //int ModID = Convert.ToInt32(cboModules.SelectedValue);
                Activity obj = (Activity)(bindingSourceLinkedModuleActivities.Current);

                //// return one instance each entity by primary key
                var curriculumCourseModule = DbConnection.CurriculumCourseModules.FirstOrDefault(a => a.ModuleID == this.ModuleID && a.CurriculumCourseID == this.CurriculumCourseID);
                var ActivityObj = DbConnection.Activities.FirstOrDefault(a => a.ActivityID == obj.ActivityID);

                //// call Remove method from navigation property for any instance
                //// supplier.Product.Remove(product);
                //// also works
                curriculumCourseModule.Activities.Remove(ActivityObj);

                //// call SaveChanges from context
                DbConnection.SaveChanges();
            };
            this.populateAvailableModuleActivities();
            this.populateLinkedModuleActivities();
            this.setAddRemoveControls();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            splitContainerAvailableActivities.Panel2Collapsed = false;
        }

        private void frmAddTrainingDepartmentCourseEnrollmentTypeModuleActivities_Load(object sender, EventArgs e)
        {
            this.populateModules();
            this.populateAvailableModuleActivities();
            this.populateLinkedModuleActivities();
            this.setAddRemoveControls();
            splitContainerAvailableActivities.Panel2Collapsed = true;
        }
        private void setAddRemoveControls()
        {
            if (bindingSourceAvailableModuleActivities.Count > 0) { btnLinkActivities.Enabled = true; } else { btnLinkActivities.Enabled = false; }
            if (bindingSourceLinkedModuleActivities.Count > 0) { btnRemoveActivities.Enabled = true; } else { btnRemoveActivities.Enabled = false; }
        }

        private void btnCloseAddActivity_Click(object sender, EventArgs e)
        {
            splitContainerAvailableActivities.Panel2Collapsed = true;
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {

            using (var DbConnection = new MCDEntities())
            {
                int ModID = Convert.ToInt32(cboModules.SelectedValue);
                Activity act = new Activity()
                {
                    ActivityCode = txtActivityCode.Text,
                    ActivitiyDescription = txtActivityDescription.Text,
                    ModuleID = ModID
                };
                DbConnection.Activities.Add(act);
                DbConnection.SaveChanges();
            }
            this.populateAvailableModuleActivities();
            this.setAddRemoveControls();
        }

        private void dgvAvailableActivities_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var act = (Activity)(row.DataBoundItem);
                    //var M = TDCETM.Module;
                    //int hours = 0;
                    //int min = 0;
                    //hours = Convert.ToInt32(Math.Floor(Convert.ToDecimal(act.ActivityDuration) / 60));
                    //min = act.ActivityDuration - (hours * 60);

                    //row.Cells[TotalDuration.Index].Value = hours + " H " + min + " min";// act.ModuleName.ToString();
                    //row.Cells[tripEndColumn.Index].Value = trip.En dDate.ToShortDateString();
                    //row.Cells[destinationColumn.Index].Value = trip.Destination.Name;
                }
            }
        }

        private void dgvLinkedActivities_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var act = (Activity)(row.DataBoundItem);
                    //var M = TDCETM.Module;
                    int hours = 0;
                    int min = 0;
                    //hours = Convert.ToInt32(Math.Floor(Convert.ToDecimal(act.ActivityDuration) / 60));
                    //min = act.ActivityDuration - (hours * 60);

                    row.Cells[LinkedActivityTotalDuration.Index].Value = hours + " H " + min + " min";// act.ModuleName.ToString();
                    //row.Cells[tripEndColumn.Index].Value = trip.En dDate.ToShortDateString();
                    //row.Cells[destinationColumn.Index].Value = trip.Destination.Name;
                }
            }
        }

        private void cboModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.populateAvailableModuleActivities();
            this.setAddRemoveControls();
        }

        private void bindingSourceAvailableModuleActivities_PositionChanged(object sender, EventArgs e)
        {
            populateLinkedModuleActivities();
        }
    }
}
