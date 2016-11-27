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
using System.Data.Entity;
using Impendulo.Common.Enum;

namespace Impendulo.Wizard.Development
{
    public partial class frmWizardTemplate : Form
    {
       

       
        int iCurrentPosition = 0;
        //MCDEntities Dbconnection;
        //Student StudentObj;

        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }
      
        public frmWizardTemplate()
        {
            InitializeComponent();
            
        }

        private void frmAddUpdateStudent_Load(object sender, EventArgs e)
        {
            if (CurrentEmployeeLoggedIn == null)
            {
                /*
             * Thismust be Commmented out or removed in the production version this is just for Develpoement Testing.
             */
                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                               where a.EmployeeID == 11075
                                               select a).FirstOrDefault<Employee>();
                };
                /***************************************************************************************/
                // MessageBox.Show("It is Required that you be logged in to use the feature.\n Login and try again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();
            }
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }

        #region Forms Sections

        #region Page 1 

        #region Controls Events
       

        #endregion

        #region Logical Control Metods
       

        #endregion



        #endregion

        #region Page 2 

        #region Refresh Methods

      

        #endregion

        #region Populate Methods
       
        #endregion

        #region Control Events
              
        #endregion

        #region Logic Control Methods

      

        #endregion
        #endregion

        #region Page 3 

        #region Refresh Methods
       
        #endregion

        #region Populate Methods
       
        #endregion

        #region Control Events
       

        #endregion

        #region logical Control Methods

        #endregion

        #endregion

        #region Page 4 - Summary Confirmation

        #region Control Methods

       

        #endregion

        #endregion


        #endregion

        #region Wizard Comopnents
        #region "Navigation Controls"
        private void navigateForward()
        {
            if (ValidateStep())
            {
                if (iCurrentPosition + 1 < MainflowLayoutPanel.Controls.Count)
                {
                    //if step validation is passed the next window is display by incrementing the IcurrentPosition Counter.
                    iCurrentPosition++;
                }
                else
                {
                    //on last step which will close if the finish b=button is selected.
                    DialogResult res = MessageBox.Show("Are Details Correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult.Yes == res)
                    {
                        this.Close();
                    }
                }
                this.setCenterDisplayPanels();
                this.setNavigationControls();
                this.loadupStep();
            }
        }
        private void navigateBackwards()
        {
            if (iCurrentPosition - 1 >= 0)
            {
                iCurrentPosition--;
            }
            else
            {

                //iCurrentPosition = 5;
            }
            //Hide All Panels inside the MainFlowPanel
            //MainflowLayoutPanel
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }


        private void setNavigationControls()
        {
            if (iCurrentPosition == 0)
            {
                btnPreviousSection.Visible = false;
                btnNextSection.Text = "Next";
            }
            else
            {
                if (iCurrentPosition == MainflowLayoutPanel.Controls.Count - 1)
                {
                    btnNextSection.Text = "Save Enquiry";
                    btnNextSection.ImageIndex = 2;
                }
                else
                {
                    btnNextSection.Text = "Next";
                    btnNextSection.ImageIndex = 0;
                }
                btnPreviousSection.Visible = true;
            }
            foreach (var Control in panel5.Controls)
            {
                if (Control is Label)
                {
                    //NavigationPanel
                    var lblObj = (Label)Control;
                    if (Convert.ToInt32(lblObj.Tag.ToString()) == iCurrentPosition)
                    {
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                    else
                    {
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Regular);
                    }
                }
            }

        }
        private void setCenterDisplayPanels()
        {
            foreach (var gbControl in MainflowLayoutPanel.Controls)
            {
                if (gbControl is GroupBox)
                {
                    var gbObj = (GroupBox)gbControl;
                    gbObj.Hide();
                }
            }
            foreach (var Control in MainflowLayoutPanel.Controls)
            {
                if (Control is GroupBox)
                {
                    var gbObj = (GroupBox)Control;
                    if (Convert.ToInt32(gbObj.Tag.ToString()) == iCurrentPosition)
                    {
                        gbObj.Show();
                        gbObj.Width = MainflowLayoutPanel.Width;
                        gbObj.Height = MainflowLayoutPanel.Height;
                    }
                    else
                    {
                        gbObj.Hide();
                        gbObj.Width = 0;
                        gbObj.Height = 0;

                    }
                }
            }
        }
        #endregion

        #region Wizard Methods
        private void loadupStep()
        {
            switch (iCurrentPosition)
            {
                case 0:
                    this.loadupEnquiryContactSelectionType();
                    break;
                case 1:
                    this.loadupEnquiryContactSelection();
                    break;
                case 2:
                    this.loadupEnquiryCurriculumSelection();
                    break;
                case 3:
                    this.loadupEnquiryConfirmation();
                    break;
                default:

                    break;
            }

        }
        private void btnPreviousSection_Click(object sender, EventArgs e)
        {
            navigateBackwards();
        }

        private void btnNextSection_Click(object sender, EventArgs e)
        {
            navigateForward();
        }
        private Boolean ValidateStep()
        {

            Boolean bRtn = true;
            switch (iCurrentPosition)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;

                case 4:
                    break;
                case 5:
                    break;
                default:
                    bRtn = false;
                    break;
            }

            return bRtn;
        }

        #region "Each Wizard Page Loadup"
        private void loadupEnquiryContactSelectionType()
        {


        }
        private void loadupEnquiryContactSelection()
        {





        }
        private void loadupEnquiryCurriculumSelection()
        {



        }


        private void loadupEnquiryConfirmation()
        {

        }

        #endregion

        #endregion

        #endregion

       

       
    }
}
