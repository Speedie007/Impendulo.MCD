namespace Impendulo.Courses.SummaryForms.Development
{
    partial class frmCurriculumCourseSummary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourseTotalDuration = new System.Windows.Forms.TextBox();
            this.txtCourseTotalCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurriculum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmountOdCourses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalAmountOdCourses);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCourseTotalDuration);
            this.groupBox1.Controls.Add(this.txtCourseTotalCost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCurriculum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "(In Days)";
            // 
            // txtCourseTotalDuration
            // 
            this.txtCourseTotalDuration.Location = new System.Drawing.Point(149, 81);
            this.txtCourseTotalDuration.Name = "txtCourseTotalDuration";
            this.txtCourseTotalDuration.ReadOnly = true;
            this.txtCourseTotalDuration.Size = new System.Drawing.Size(78, 20);
            this.txtCourseTotalDuration.TabIndex = 11;
            // 
            // txtCourseTotalCost
            // 
            this.txtCourseTotalCost.Location = new System.Drawing.Point(149, 55);
            this.txtCourseTotalCost.Name = "txtCourseTotalCost";
            this.txtCourseTotalCost.ReadOnly = true;
            this.txtCourseTotalCost.Size = new System.Drawing.Size(131, 20);
            this.txtCourseTotalCost.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Cost";
            // 
            // txtCurriculum
            // 
            this.txtCurriculum.Location = new System.Drawing.Point(149, 29);
            this.txtCurriculum.Name = "txtCurriculum";
            this.txtCurriculum.ReadOnly = true;
            this.txtCurriculum.Size = new System.Drawing.Size(295, 20);
            this.txtCurriculum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Curriculum";
            // 
            // txtTotalAmountOdCourses
            // 
            this.txtTotalAmountOdCourses.Location = new System.Drawing.Point(149, 107);
            this.txtTotalAmountOdCourses.Name = "txtTotalAmountOdCourses";
            this.txtTotalAmountOdCourses.ReadOnly = true;
            this.txtTotalAmountOdCourses.Size = new System.Drawing.Size(78, 20);
            this.txtTotalAmountOdCourses.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Amount Of Course(s)";
            // 
            // frmCurriculumCourseSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 160);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCurriculumCourseSummary";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curriculum Course Summary";
            this.Load += new System.EventHandler(this.frmCurriculumCourseSummary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCourseTotalDuration;
        private System.Windows.Forms.TextBox txtCourseTotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurriculum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAmountOdCourses;
        private System.Windows.Forms.Label label2;
    }
}