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
    public partial class CourseViewLinkedCoursesAndModules : Form
    {
        //MCDEntities _context;
        public CourseViewLinkedCoursesAndModules()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Loads up the Departments from database and load the datasource to populate the combobox
            using (var dbConnection = new MCDEntities())
            {
                departmentBindingSource.DataSource = dbConnection.TrainingDepartments.ToList<TrainingDepartment>();
            }
            //populates the Listbox with the Courses linked to the department ListBox
            populateCourses(Convert.ToInt32(cboDepartments.SelectedValue));
            //populates the list box with the modules that are linked to the Course
            populateModules(Convert.ToInt32(lstCourses.SelectedValue));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox s = (ComboBox)sender;
            var a = s.SelectedValue;

            populateCourses(Convert.ToInt32(s.SelectedValue));
            populateModules(Convert.ToInt32(lstCourses.SelectedValue));
        }

        private void populateCourses(int _DepartmentID)
        {

            //using (var dbConnection = new MCDEntities())
            //{
            //    coursBindingSource.DataSource = dbConnection.Courses.SqlQuery("SELECT Courses.CourseID, Courses.Course FROM  Courses INNER JOIN DepartmentCourses ON Courses.CourseID = DepartmentCourses.CourseID WHERE(DepartmentCourses.DepartmentID = " + _DepartmentID + ")").ToList<Cours>();

            //}
            using (var dbConnection = new MCDEntities())
            {
                //dbConnection.Entry( Department).Collection(s => s.DepartmentCourses).Load();

                // LINQ Query Syntax
                ////var nestedQuesryOfCourses = from AllCourseRows in dbConnection.Courses
                ////                            from DepartmentCourses in AllCourseRows.TrainingDepartmentCourses
                ////                            where DepartmentCourses.TrainingDepartmentID == _DepartmentID
                ////                            select new
                ////                            {
                ////                                AllCourseRows.CourseID,
                ////                                AllCourseRows.CourseName,
                ////                                AllCourseRows.CourseDescription
                ////                            };
                //var Course = nestedQuesryOfCourses.FirstOrDefault();
                //txtCourseDescriptionUPDATE.Text = nestedQuesryOfCourses.ToList()[0].CourseDescription ;
                ////this.coursBindingSource.DataSource = nestedQuesryOfCourses.ToList();
            }
            populateCourseDetailsForEditing();
        }
        private void populateCourseDetailsForEditing()
        {
            if (Convert.ToUInt32(lstCourses.Items.Count) != 0)
            {
                //Querying with LINQ to Entities 
                using (var dbConnection = new MCDEntities())
                {
                    //int _CourseID = Convert.ToInt32(lstCourses.SelectedValue);
                    //var L2EQuery = dbConnection.Courses.Where(c => c.CourseID == _CourseID);
                    //var Course = L2EQuery.FirstOrDefault<Cours>();
                    //if (Course != null)
                    //{
                    //    this.txtCourseDescriptionUPDATE.Text = Course.CourseDescription.ToString();
                    //}
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox s = (ListBox)sender;
            populateModules(Convert.ToInt32(s.SelectedValue));
            populateCourseDetailsForEditing();
        }

        private void populateModules(int _CourseID)
        {
            //using (var dbConnection = new MCDEntities())
            //{
            //    var nestedQuesryOfModules = from m in dbConnection.Modules
            //                                from cm in m.CourseModules
            //                                where cm.CourseID == _CourseID
            //                                select new
            //                                {
            //                                    m.ModuleID,
            //                                    m.ModuleName
            //                                };
            //    this.moduleBindingSource.DataSource = nestedQuesryOfModules.ToList();
            //    populateModulesDetailsForEditing();

            //}
        }

        private void populateModulesDetailsForEditing()
        {
            if (Convert.ToUInt32(lstModules.Items.Count) != 0)
            {
                //Querying with LINQ to Entities 
                using (var dbConnection = new MCDEntities())
                {
                    int _ModuleID = Convert.ToInt32(lstModules.SelectedValue);
                    int _CourseID = Convert.ToInt32(lstCourses.SelectedValue);
                    //var L2EQuery = dbConnection.CourseModules.Where(c => c.CourseID == _CourseID && c.ModuleID == _ModuleID);
                    //var CourseModule = L2EQuery.FirstOrDefault<CourseModule>();
                    //if (CourseModule != null)
                    //{
                        //this.txtCourseModuleDefaultDurationUPDATE.Text = CourseModule.CourseModuleDefaultDuration.ToString();
                        //this.txtCourseModuleDefaultPriceUPDATE.Text = CourseModule.CourseModuleDefaultPrice.ToString();
                    //}
                }
            }
        }


        #region "Update Statements"


        #endregion

        private void lstModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateModulesDetailsForEditing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new LinkCourseToDepartment();
            frm._GlobalDepartmentID = Convert.ToInt32(cboDepartments.SelectedValue);
            frm.Height = 300;
            frm.ShowDialog();
            this.populateCourses(Convert.ToInt32(this.cboDepartments.SelectedValue.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
             var frm = new LinkModuleToCourse();
            frm._GlobalCourseID = Convert.ToInt32(lstCourses.SelectedValue);
            frm.Height = 300;
            frm.ShowDialog();
            this.populateModules(Convert.ToInt32(this.lstCourses.SelectedValue.ToString()));
        }

        private void btnUpdateCourseModule_Click(object sender, EventArgs e)
        {
            //CourseModule UpdateCourseModule;

            //using (var dbConnection = new MCDEntities())
            //{
            //    var UpdateCourseID = Convert.ToInt32(lstCourses.SelectedValue.ToString());
            //    var UpdateModuleID = Convert.ToInt32(lstModules.SelectedValue.ToString());

            //    UpdateCourseModule = dbConnection.CourseModules.Where(s => s.CourseID == UpdateCourseID && s.ModuleID == UpdateModuleID).FirstOrDefault<CourseModule>();
            //}

            //if (UpdateCourseModule != null)
            //{
            //    UpdateCourseModule.CourseModuleDefaultPrice= Convert.ToDecimal(this.txtCourseModuleDefaultPriceUPDATE.Text.ToString());
            //    UpdateCourseModule.CourseModuleDefaultDuration = Convert.ToInt32(this.txtCourseModuleDefaultDurationUPDATE.Text.ToString());
            //}

            ////save modified entity using new Context
            //using (var dbConnection = new MCDEntities())
            //{
            //    //3. Mark entity as modified
            //    dbConnection.Entry(UpdateCourseModule).State = System.Data.Entity.EntityState.Modified;

            //    //4. call SaveChanges
            //    dbConnection.SaveChanges();
            //}


            //populateModulesDetailsForEditing();
        }
    }

}