using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//using Impendulo.Data.Models;



namespace Impendulo.Common
{
    public partial class CommonFormProperties : Form

    {


        //public MCDEntities DbConnection
        //{
        //    get { return new MCDEntities(); }
        //}


        public CommonFormProperties()
        {
            //DbConnection = new MCDEntities();
            InitializeComponent();

        }
        private void setProperties()
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CommonFormProperties
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CommonFormProperties";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CommonFormProperties_Load);
            this.ResumeLayout(false);

        }

        private void CommonFormProperties_Load(object sender, EventArgs e)
        {
            
        }
    }
}
