namespace Impendulo.Courses.InputForms.Deployment
{
    partial class frmAddCurriculum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCurriculum));
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddTrainingDepartment = new System.Windows.Forms.Button();
            this.costingModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsSequencedCourse = new System.Windows.Forms.CheckBox();
            this.cboCostingModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddCurriculum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.costingModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(190, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddTrainingDepartment
            // 
            this.btnAddTrainingDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTrainingDepartment.Image")));
            this.btnAddTrainingDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTrainingDepartment.Location = new System.Drawing.Point(271, 126);
            this.btnAddTrainingDepartment.Name = "btnAddTrainingDepartment";
            this.btnAddTrainingDepartment.Size = new System.Drawing.Size(99, 30);
            this.btnAddTrainingDepartment.TabIndex = 6;
            this.btnAddTrainingDepartment.Text = "Add";
            this.btnAddTrainingDepartment.UseVisualStyleBackColor = true;
            this.btnAddTrainingDepartment.Click += new System.EventHandler(this.btnAddTrainingDepartment_Click);
            // 
            // costingModelBindingSource
            // 
            this.costingModelBindingSource.DataSource = typeof(Impendulo.Data.Models.CostingModel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsSequencedCourse);
            this.groupBox1.Controls.Add(this.cboCostingModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddCurriculum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 108);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkIsSequencedCourse
            // 
            this.chkIsSequencedCourse.AutoSize = true;
            this.chkIsSequencedCourse.Location = new System.Drawing.Point(126, 77);
            this.chkIsSequencedCourse.Name = "chkIsSequencedCourse";
            this.chkIsSequencedCourse.Size = new System.Drawing.Size(144, 17);
            this.chkIsSequencedCourse.TabIndex = 17;
            this.chkIsSequencedCourse.Text = "Has Sequenced Courses";
            this.chkIsSequencedCourse.UseVisualStyleBackColor = true;
            // 
            // cboCostingModel
            // 
            this.cboCostingModel.DataSource = this.costingModelBindingSource;
            this.cboCostingModel.DisplayMember = "CostingModelName";
            this.cboCostingModel.FormattingEnabled = true;
            this.cboCostingModel.Location = new System.Drawing.Point(126, 50);
            this.cboCostingModel.Name = "cboCostingModel";
            this.cboCostingModel.Size = new System.Drawing.Size(224, 21);
            this.cboCostingModel.TabIndex = 16;
            this.cboCostingModel.ValueMember = "CostingModelID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Costing Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Department Curriculum";
            // 
            // txtAddCurriculum
            // 
            this.txtAddCurriculum.Location = new System.Drawing.Point(126, 24);
            this.txtAddCurriculum.Name = "txtAddCurriculum";
            this.txtAddCurriculum.Size = new System.Drawing.Size(224, 20);
            this.txtAddCurriculum.TabIndex = 13;
            // 
            // frmAddCurriculum
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(378, 165);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddTrainingDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCurriculum";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Curriculum";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddTrainingDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costingModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddTrainingDepartment;
        private System.Windows.Forms.BindingSource costingModelBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIsSequencedCourse;
        private System.Windows.Forms.ComboBox cboCostingModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddCurriculum;
    }
}