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
    public partial class LinkModuleToCourseV2 : Form
    {
        public CourseViewLinkedCoursesAndModulesV3 _parentForm = null;
        public int _GlobalCourseID = 0;
        public int _GlobalTrainingDepartmentID = 0;
        public LinkModuleToCourseV2()
        {
            InitializeComponent();
        }

        private void LinkModuleToCourseV2_Load(object sender, EventArgs e)
        {
            populateAvailableModules();
        }

        private void btnShowInsertModuleSection_Click(object sender, EventArgs e)
        {
            gbAvailableModules.Hide();
        }

        private void populateAvailableModules()
        {

            using (var dbConnection = new MCDEntities())
            {
                //////Gets a LIST of all Courses linked to theselected Department
                //var ModulesLinkedToCourse =
                //    from a in dbConnection.Modules
                //    from b in a.CourseModules
                //    where b.CourseID == _GlobalCourseID
                //    select a;

                //////Gets a LIST of all Courses
                //var AllModules =
                //    from allModules in dbConnection.Modules
                //    orderby allModules.ModuleName
                //    select allModules;

                //////Returns a list of courses that are not linked to the selected Department.
                //var ModulesNotLinkedToCourse = (from s in AllModules orderby s.ModuleName select s).Except(ModulesLinkedToCourse);

                //if (ModulesNotLinkedToCourse != null)
                //{
                //    //Updates the data source of the databinding Control.
                //    this.moduleBindingSource.DataSource = ModulesNotLinkedToCourse.ToList<Module>();
                //}
            }
        }

        private void btnCancelAddingModule_Click(object sender, EventArgs e)
        {
            gbAvailableModules.Show();
        }

        private void btnLinkCourseModule_Click(object sender, EventArgs e)
        {
            using (var dbConnection = new MCDEntities())
            {
                //var _CourseModule = new CourseModule()
                //{
                //    ModuleID = Convert.ToInt32(lstModuleINSERT.SelectedValue.ToString()),
                //    CourseID = _GlobalCourseID,
                //    CourseModuleUnitCost = Convert.ToDecimal(this.txtModuleCost.Text),
                //    CourseModuleDuration = Convert.ToInt32(this.txtModuleDuration.Text)
                //};

                //dbConnection.CourseModules.Add(_CourseModule);
                //dbConnection.SaveChanges();
            }
            this.txtModuleCost.Text = "0";
            this.txtModuleDuration.Text = "0";
            populateAvailableModules();
        }

        //private int GetTrainingDepartmentCourseID()
        //{
        //    using (var dbConnection = new MCDEntities())
        //    {
        //        //return (from s in dbConnection.TrainingDepartmentCourses
        //        //        where s.CourseID == _GlobalCourseID && s.TrainingDepartmentID == _GlobalTrainingDepartmentID
        //        //        select s).FirstOrDefault<TrainingDepartmentCourse>().TrainingDepartmentCourseID;
        //    }
        //}

        private void btnInsertModule_Click(object sender, EventArgs e)
        {
            //using (var dbConnection = new MCDEntities())
            //{
            //    var _Module = new Module()
            //    {
            //        ModuleName = txtModuleNameINSERTIntoModules.Text.ToString(),
            //        //ModuleDescription = txtModuleDescription.Text.ToString()
            //    };

            //    dbConnection.Modules.Add(_Module);
            //    dbConnection.SaveChanges();

            //    this.populateAvailableModules();

            //    this.gbAvailableModules.Show();
            //}
            //txtModuleNameINSERTIntoModules.Text = "";
            //txtModuleDescription.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

