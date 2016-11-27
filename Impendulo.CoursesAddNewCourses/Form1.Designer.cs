namespace Impendulo.CoursesAddNewCourses
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trainingDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDepartmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trainingDepartmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cboTrainingDepartment = new System.Windows.Forms.ComboBox();
            this.trainingDepartmentCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDepartmentSectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTrainingDepartmentSection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTrainingDepartmentSections = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingNavigator)).BeginInit();
            this.trainingDepartmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentSectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trainingDepartmentBindingSource
            // 
            //this.trainingDepartmentBindingSource.DataSource = typeof(Impendulo.Data.Models.TrainingDepartment);
            // 
            // trainingDepartmentBindingNavigator
            // 
            this.trainingDepartmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.trainingDepartmentBindingNavigator.BindingSource = this.trainingDepartmentBindingSource;
            this.trainingDepartmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.trainingDepartmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.trainingDepartmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trainingDepartmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.trainingDepartmentBindingNavigatorSaveItem});
            this.trainingDepartmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trainingDepartmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.trainingDepartmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.trainingDepartmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.trainingDepartmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.trainingDepartmentBindingNavigator.Name = "trainingDepartmentBindingNavigator";
            this.trainingDepartmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.trainingDepartmentBindingNavigator.Size = new System.Drawing.Size(1132, 27);
            this.trainingDepartmentBindingNavigator.TabIndex = 0;
            this.trainingDepartmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // trainingDepartmentBindingNavigatorSaveItem
            // 
            this.trainingDepartmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trainingDepartmentBindingNavigatorSaveItem.Enabled = false;
            this.trainingDepartmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("trainingDepartmentBindingNavigatorSaveItem.Image")));
            this.trainingDepartmentBindingNavigatorSaveItem.Name = "trainingDepartmentBindingNavigatorSaveItem";
            this.trainingDepartmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.trainingDepartmentBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cboTrainingDepartment
            // 
            this.cboTrainingDepartment.DataSource = this.trainingDepartmentBindingSource;
            this.cboTrainingDepartment.DisplayMember = "Department";
            this.cboTrainingDepartment.FormattingEnabled = true;
            this.cboTrainingDepartment.Location = new System.Drawing.Point(156, 45);
            this.cboTrainingDepartment.Name = "cboTrainingDepartment";
            this.cboTrainingDepartment.Size = new System.Drawing.Size(300, 24);
            this.cboTrainingDepartment.TabIndex = 1;
            this.cboTrainingDepartment.ValueMember = "TrainingDepartmentID";
            this.cboTrainingDepartment.SelectedIndexChanged += new System.EventHandler(this.trainingDepartmentComboBox_SelectedIndexChanged);
            // 
            // trainingDepartmentCourseBindingSource
            // 
            //this.trainingDepartmentCourseBindingSource.DataSource = typeof(Impendulo.Data.Models.TrainingDepartmentCourse);
            // 
            // trainingDepartmentSectionBindingSource
            // 
            //this.trainingDepartmentSectionBindingSource.DataSource = typeof(Impendulo.Data.Models.TrainingDepartmentSection);
            // 
            // cboTrainingDepartmentSection
            // 
            this.cboTrainingDepartmentSection.DataSource = this.trainingDepartmentSectionBindingSource;
            this.cboTrainingDepartmentSection.DisplayMember = "TrainingDepartmentSectionName";
            this.cboTrainingDepartmentSection.FormattingEnabled = true;
            this.cboTrainingDepartmentSection.Location = new System.Drawing.Point(156, 75);
            this.cboTrainingDepartmentSection.Name = "cboTrainingDepartmentSection";
            this.cboTrainingDepartmentSection.Size = new System.Drawing.Size(442, 24);
            this.cboTrainingDepartmentSection.TabIndex = 2;
            this.cboTrainingDepartmentSection.ValueMember = "TrainingDepartmentSectionID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Training Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department Section";
            // 
            // lstTrainingDepartmentSections
            // 
            this.lstTrainingDepartmentSections.DataSource = this.courseBindingSource;
            this.lstTrainingDepartmentSections.DisplayMember = "CourseName";
            this.lstTrainingDepartmentSections.FormattingEnabled = true;
            this.lstTrainingDepartmentSections.ItemHeight = 16;
            this.lstTrainingDepartmentSections.Location = new System.Drawing.Point(156, 113);
            this.lstTrainingDepartmentSections.Name = "lstTrainingDepartmentSections";
            this.lstTrainingDepartmentSections.Size = new System.Drawing.Size(442, 484);
            this.lstTrainingDepartmentSections.TabIndex = 6;
            this.lstTrainingDepartmentSections.ValueMember = "CourseID";
            // 
            // courseBindingSource
            // 
            //this.courseBindingSource.DataSource = typeof(Impendulo.Data.Models.Course);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 627);
            this.Controls.Add(this.lstTrainingDepartmentSections);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTrainingDepartmentSection);
            this.Controls.Add(this.cboTrainingDepartment);
            this.Controls.Add(this.trainingDepartmentBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingNavigator)).EndInit();
            this.trainingDepartmentBindingNavigator.ResumeLayout(false);
            this.trainingDepartmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentSectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource trainingDepartmentBindingSource;
        private System.Windows.Forms.BindingNavigator trainingDepartmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton trainingDepartmentBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cboTrainingDepartment;
        private System.Windows.Forms.BindingSource trainingDepartmentCourseBindingSource;
        private System.Windows.Forms.BindingSource trainingDepartmentSectionBindingSource;
        private System.Windows.Forms.ComboBox cboTrainingDepartmentSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTrainingDepartmentSections;
        private System.Windows.Forms.BindingSource courseBindingSource;
    }
}

