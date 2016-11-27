namespace Impendulo.Courses
{
    partial class CourseViewLinkedCoursesAndModules
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
            this.cboDepartments = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.coursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseDescriptionUPDATE = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourseModuleDefaultPriceUPDATE = new System.Windows.Forms.TextBox();
            this.txtCourseModuleDefaultDurationUPDATE = new System.Windows.Forms.TextBox();
            this.lstModules = new System.Windows.Forms.ListBox();
            this.btnUpdateCourseModule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDepartments
            // 
            this.cboDepartments.DataSource = this.departmentBindingSource;
            this.cboDepartments.DisplayMember = "Department";
            this.cboDepartments.FormattingEnabled = true;
            this.cboDepartments.Location = new System.Drawing.Point(119, 25);
            this.cboDepartments.Name = "cboDepartments";
            this.cboDepartments.Size = new System.Drawing.Size(470, 24);
            this.cboDepartments.TabIndex = 0;
            this.cboDepartments.ValueMember = "TrainingDepartmentID";
            this.cboDepartments.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Impendulo.Data.Models.TrainingDepartment);
            // 
            // lstCourses
            // 
            this.lstCourses.DataSource = this.coursBindingSource;
            this.lstCourses.DisplayMember = "CourseName";
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 16;
            this.lstCourses.Location = new System.Drawing.Point(6, 21);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(285, 244);
            this.lstCourses.TabIndex = 1;
            this.lstCourses.ValueMember = "CourseID";
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // coursBindingSource
            // 
            //.coursBindingSource.DataSource = typeof(Impendulo.Data.Models.Course);
            // 
            // moduleBindingSource
            // 
            ////this.moduleBindingSource.DataSource = typeof(Impendulo.Data.Models.Module);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Departments";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboDepartments);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(5, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(784, 65);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Departments";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.lstCourses);
            this.groupBox4.Location = new System.Drawing.Point(12, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(768, 285);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Courses";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCourseDescriptionUPDATE);
            this.groupBox1.Location = new System.Drawing.Point(313, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 244);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Course Properties";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Link Course To Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course Description";
            // 
            // txtCourseDescriptionUPDATE
            // 
            this.txtCourseDescriptionUPDATE.Location = new System.Drawing.Point(140, 30);
            this.txtCourseDescriptionUPDATE.Multiline = true;
            this.txtCourseDescriptionUPDATE.Name = "txtCourseDescriptionUPDATE";
            this.txtCourseDescriptionUPDATE.Size = new System.Drawing.Size(274, 137);
            this.txtCourseDescriptionUPDATE.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.lstModules);
            this.groupBox2.Location = new System.Drawing.Point(12, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 285);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnUpdateCourseModule);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtCourseModuleDefaultPriceUPDATE);
            this.groupBox5.Controls.Add(this.txtCourseModuleDefaultDurationUPDATE);
            this.groupBox5.Location = new System.Drawing.Point(396, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 244);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Module Properties";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Link Module To Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Default Module Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Default Module Price";
            // 
            // txtCourseModuleDefaultPriceUPDATE
            // 
            this.txtCourseModuleDefaultPriceUPDATE.Location = new System.Drawing.Point(175, 27);
            this.txtCourseModuleDefaultPriceUPDATE.Name = "txtCourseModuleDefaultPriceUPDATE";
            this.txtCourseModuleDefaultPriceUPDATE.Size = new System.Drawing.Size(156, 22);
            this.txtCourseModuleDefaultPriceUPDATE.TabIndex = 13;
            // 
            // txtCourseModuleDefaultDurationUPDATE
            // 
            this.txtCourseModuleDefaultDurationUPDATE.Location = new System.Drawing.Point(173, 58);
            this.txtCourseModuleDefaultDurationUPDATE.Name = "txtCourseModuleDefaultDurationUPDATE";
            this.txtCourseModuleDefaultDurationUPDATE.Size = new System.Drawing.Size(106, 22);
            this.txtCourseModuleDefaultDurationUPDATE.TabIndex = 12;
            // 
            // lstModules
            // 
            this.lstModules.DataSource = this.moduleBindingSource;
            this.lstModules.DisplayMember = "ModuleName";
            this.lstModules.FormattingEnabled = true;
            this.lstModules.ItemHeight = 16;
            this.lstModules.Location = new System.Drawing.Point(6, 21);
            this.lstModules.Name = "lstModules";
            this.lstModules.Size = new System.Drawing.Size(384, 244);
            this.lstModules.TabIndex = 12;
            this.lstModules.ValueMember = "ModuleID";
            this.lstModules.SelectedIndexChanged += new System.EventHandler(this.lstModules_SelectedIndexChanged);
            // 
            // btnUpdateCourseModule
            // 
            this.btnUpdateCourseModule.Location = new System.Drawing.Point(137, 99);
            this.btnUpdateCourseModule.Name = "btnUpdateCourseModule";
            this.btnUpdateCourseModule.Size = new System.Drawing.Size(194, 36);
            this.btnUpdateCourseModule.TabIndex = 20;
            this.btnUpdateCourseModule.Text = "Link Module To Course";
            this.btnUpdateCourseModule.UseVisualStyleBackColor = true;
            this.btnUpdateCourseModule.Click += new System.EventHandler(this.btnUpdateCourseModule_Click);
            // 
            // CourseViewLinkedCoursesAndModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "CourseViewLinkedCoursesAndModules";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Text = "33";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDepartments;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.BindingSource coursBindingSource;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseDescriptionUPDATE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCourseModuleDefaultPriceUPDATE;
        private System.Windows.Forms.TextBox txtCourseModuleDefaultDurationUPDATE;
        private System.Windows.Forms.ListBox lstModules;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdateCourseModule;
    }
}

