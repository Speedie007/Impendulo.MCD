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

namespace Impendulo.Employees.LinkAssociatedDepartments.Development
{
    public partial class frmEmployeeAssociatedDepartments : Form
    {
        public frmEmployeeAssociatedDepartments()
        {
            InitializeComponent();
        }
        public Employee CurrentEmployee { get; set; }

        private void frmEmployeeAssociatedDepartments_Load(object sender, EventArgs e)
        {
            this.refreshAvaiableDepartments();
            this.refreshLinkedDepartmemts();
        }
        private void refreshAvaiableDepartments()
        {
            this.populateAvaiableDepartments();
        }
        private void populateAvaiableDepartments()
        {
            using (var Dbconnection = new MCDEntities())
            {
                avaiableDepartmentBindingSource.DataSource = ((from a in Dbconnection.LookupDepartments
                                                               select a).Except(from a in Dbconnection.Employees
                                                                                from b in a.LookupDepartments
                                                                                where a.EmployeeID == this.CurrentEmployee.EmployeeID
                                                                                select b)).ToList<LookupDepartment>();
            };

        }
        private void refreshLinkedDepartmemts()
        {
            this.populateLinkedDepartments();
        }
        private void populateLinkedDepartments()
        {

            using (var Dbconnection = new MCDEntities())
            {
                this.LinkedDepartmentBindingSource.DataSource = (from a in Dbconnection.Employees
                                                                 from b in a.LookupDepartments
                                                                 where a.EmployeeID == this.CurrentEmployee.EmployeeID
                                                                 select b).ToList<LookupDepartment>();
            };

        }

        private void btnLinkDepartments_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                if (avaiableDepartmentBindingSource.Count > 0)
                {
                    var Employ = Dbconnection.Employees.FirstOrDefault(p => p.EmployeeID == CurrentEmployee.EmployeeID);
                    var Dep = Dbconnection.LookupDepartments.FirstOrDefault(s => s.DepartmentID == ((LookupDepartment)avaiableDepartmentBindingSource.Current).DepartmentID);

                   // Dbconnection.Employees.Attach(CurrentEmployee);
                    //Dbconnection.LookupDepartments.Attach((LookupDepartment)avaiableDepartmentBindingSource.Current);
                    Employ.LookupDepartments.Add(Dep);
                    Dbconnection.SaveChanges();
                }
            };
            refreshAvaiableDepartments();
            refreshLinkedDepartmemts();
        }

        private void btnRemoveDepartments_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                if (LinkedDepartmentBindingSource.Count > 0)
                {
                    // return one instance each entity by primary key

                    var Employ = Dbconnection.Employees.FirstOrDefault(p => p.EmployeeID == CurrentEmployee.EmployeeID);
                    var Dep = Dbconnection.LookupDepartments.FirstOrDefault(s => s.DepartmentID == ((LookupDepartment)LinkedDepartmentBindingSource.Current).DepartmentID);

                    // call Remove method from navigation property for any instance
                    // supplier.Product.Remove(product);
                    // also works
                    Employ.LookupDepartments.Remove(Dep);

                    



                    //Employee EmployeeToUpdate = (from a in Dbconnection.Employees
                    //                             where a.EmployeeID == CurrentEmployee.EmployeeID
                    //                             select a).FirstOrDefault<Employee>();


                    //Dbconnection.Employees.Attach(CurrentEmployee);
                    //CurrentEmployee.LookupDepartments.Remove((LookupDepartment)LinkedDepartmentBindingSource.Current);

                    ////Dbconnection.Entry(CurrentEmployee).Collection(a => a.LookupDepartments).Load();

                    ////LookupDepartment tr = (from a in CurrentEmployee.LookupDepartments
                    ////                       where a.DepartmentID == ((LookupDepartment)LinkedDepartmentBindingSource.Current).DepartmentID
                    ////                       select a).FirstOrDefault<LookupDepartment>();


                    ////EmployeeToUpdate.LookupDepartments.Remove(tr);
                    Dbconnection.SaveChanges();
                }
            };
            refreshAvaiableDepartments();
            refreshLinkedDepartmemts();
        }
    }
}
