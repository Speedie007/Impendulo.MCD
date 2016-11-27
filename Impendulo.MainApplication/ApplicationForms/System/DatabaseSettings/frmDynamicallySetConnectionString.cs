using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Common.SqlHelper;
using Impendulo.Common.EntityFrameWorkHelper;
using Impendulo.Common.AppSettings;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using Impendulo.Data.Models;

namespace Impendulo.DatabaseSettings.Deployment
{
    public partial class frmDynamicallySetConnectionString : Form
    {
        public frmDynamicallySetConnectionString()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add(".");
            cboServer.Items.Add("(Local)");
            cboServer.Items.Add("LocalHost");
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 2;
            chkUseIntergaratedSecurity.Checked = true;
            if (chkUseIntergaratedSecurity.Checked)
            {
                txtPassword.Enabled = false;
                txtUsername.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
                txtUsername.Enabled = true;
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            // Set the properties for the data source.

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = cboServer.Text;
            sqlBuilder.InitialCatalog = txtDatabase.Text;
            if (chkUseIntergaratedSecurity.Checked)
            {
                sqlBuilder.IntegratedSecurity = true;
            }
            else
            {
                sqlBuilder.UserID = txtUsername.Text;
                sqlBuilder.Password = txtPassword.Text;
            }

            try
            {
                SQLHelper helper = new SQLHelper(sqlBuilder.ToString());
                if (helper.hasSQLConnectionPassed)
                    MessageBox.Show("Connection Successfull!", "ConnectionState Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuildSQLConnectionString()
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = cboServer.Text;
            sqlBuilder.InitialCatalog = txtDatabase.Text;
            sqlBuilder.MultipleActiveResultSets = true;

            if (chkUseIntergaratedSecurity.Checked)
            {
                sqlBuilder.IntegratedSecurity = true;
            }
            else
            {
                sqlBuilder.UserID = txtUsername.Text;
                sqlBuilder.Password = txtPassword.Text;
            }
            return sqlBuilder.ToString();
        }
        private string BuildEntityFrameWorkConnectionString()
        {
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = "System.Data.SqlClient";

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = this.BuildSQLConnectionString() + ";App=EntityFramework";

            // Set the Metadata location.
            entityBuilder.Metadata = string.Format("res://*/Models.MCDEntities.csdl|res://*/Models.MCDEntities.ssdl|res://*/Models.MCDEntities.msl", typeof(MCDEntities).Assembly.FullName);

            return entityBuilder.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                SQLHelper SqlHelper = new SQLHelper(BuildSQLConnectionString());
                EntityFrameworkHelper EntityFrameWorkHelper = new EntityFrameworkHelper(BuildEntityFrameWorkConnectionString());
                if (SqlHelper.hasSQLConnectionPassed && EntityFrameWorkHelper.hasSQLConnectionPassed)
                {
                    AppSettings setting = new AppSettings();
                    setting.SaveConnectionString("MCDEntities", BuildEntityFrameWorkConnectionString());
                    setting.SaveConnectionString("SQLCon", BuildSQLConnectionString());
                    MessageBox.Show("Connection Successfully Updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }else
                {
                    MessageBox.Show("Connection Not Successfully Updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseIntergaratedSecurity.Checked)
            {
                txtPassword.Enabled = false;
                txtUsername.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
                txtUsername.Enabled = true;
            }
        }

        private void btnTestEntityConnection_Click(object sender, EventArgs e)
        {
            // using (EntityConnection conn = new EntityConnection("metadata=res://*/Models.MCDModel.csdl|res://*/Models.MCDModel.ssdl|res://*/Models.MCDModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source=Localhost;initial catalog=MCD;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\""))
            using (EntityConnection conn = new EntityConnection(this.BuildEntityFrameWorkConnectionString()))
            {
                conn.Open();
                MessageBox.Show("Entity Framework Connection Created and Successfully Connected.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }
    }
}
