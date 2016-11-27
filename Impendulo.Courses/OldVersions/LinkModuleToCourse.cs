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
using Impendulo.Data.Models;

namespace Impendulo.Courses
{
    public partial class LinkModuleToCourse : Form
    {
        public int _GlobalCourseID;
        public LinkModuleToCourse()
        {
            InitializeComponent();
        }

        private void LinkModuleToCourse_Load(object sender, EventArgs e)
        {
            populateAvailableModules();
        }


        private void populateAvailableModules()
        {

            using (var dbConnection = new MCDEntities())
            {
                //////Gets a LIST of all Courses linked to theselected Department
                //var ModulesLinkedToCourseEntities =
                //    from AllModules in dbConnection.Modules
                //    //from CourseModules in AllModules.CourseModules
                //    //where CourseModules.CourseID == _GlobalCourseID
                //    select AllModules;

                //////Gets a LIST of all Courses
                //var AllModuleEntities =
                //    from allModules in dbConnection.Modules
                //    select allModules;

                //////Returns a list of courses that are not linked to the selected Department.
                //var ModulesNotLinkedToCourse = AllModuleEntities.Except(ModulesLinkedToCourseEntities);

                //if (ModulesNotLinkedToCourse != null)
                //{
                //    //Updates the data source of the databinding Control.
                //    this.moduleBindingSource.DataSource = ModulesNotLinkedToCourse.ToList<Module>();
                //}
            }
        }

        private void btnInsertModule_Click(object sender, EventArgs e)
        {
            using (var dbConnection = new MCDEntities())
            {
                //var _Module = new Module()
                {
                     //ModuleName = txtModuleNameINSERTIntoModules.Text.ToString(),
                   // CourseDescription = txtModuleDescriptionINSERTIntoCourses.ToString()
                };

                //dbConnection.Modules.Add(_Module);
                //dbConnection.SaveChanges();

                this.populateAvailableModules();

                btnShowInsertModuleSection.Enabled = true;
                this.Height = 300;

            }
        }

        private void btnShowInsertModuleSection_Click(object sender, EventArgs e)
        {
            this.Height = 490;
            var btn = (Button)sender;
            btn.Enabled = false;
        }

        private void btnLinkCourseModule_Click(object sender, EventArgs e)
        {
            //using (var dbConnection = new MCDEntities())
            //{
            //    var _CourseModule = new CourseModule()
            //    {

            //        CourseID = _GlobalCourseID,
            //         ModuleID  = Convert.ToInt32(lstModuleINSERT.SelectedValue.ToString())
            //    };

            //    dbConnection.CourseModules.Add(_CourseModule);
            //    dbConnection.SaveChanges();
            //}
            populateAvailableModules();
        }
    }
}
