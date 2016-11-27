namespace Impendulo.StudentEngineeringCourseErollment.Devlopment
{
    partial class frmtest
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
            System.Windows.Forms.Label individualFirstNameLabel;
            System.Windows.Forms.Label individualLastnameLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label companyNameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtest));
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.enrollmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.enrollmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.individualLastnameTextBox = new System.Windows.Forms.TextBox();
            this.studentAssociatedCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameListBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.curriculumCourseEnrollmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curriculumCourseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumCourseParentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curricullumCourseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            individualFirstNameLabel = new System.Windows.Forms.Label();
            individualLastnameLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            companyNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingNavigator)).BeginInit();
            this.enrollmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAssociatedCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumCourseEnrollmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // individualFirstNameLabel
            // 
            individualFirstNameLabel.AutoSize = true;
            individualFirstNameLabel.Location = new System.Drawing.Point(68, 297);
            individualFirstNameLabel.Name = "individualFirstNameLabel";
            individualFirstNameLabel.Size = new System.Drawing.Size(108, 13);
            individualFirstNameLabel.TabIndex = 2;
            individualFirstNameLabel.Text = "Individual First Name:";
            // 
            // individualLastnameLabel
            // 
            individualLastnameLabel.AutoSize = true;
            individualLastnameLabel.Location = new System.Drawing.Point(72, 323);
            individualLastnameLabel.Name = "individualLastnameLabel";
            individualLastnameLabel.Size = new System.Drawing.Size(104, 13);
            individualLastnameLabel.TabIndex = 4;
            individualLastnameLabel.Text = "Individual Lastname:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(303, 297);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 6;
            companyNameLabel.Text = "Company Name:";
            // 
            // companyNameLabel1
            // 
            companyNameLabel1.AutoSize = true;
            companyNameLabel1.Location = new System.Drawing.Point(391, 362);
            companyNameLabel1.Name = "companyNameLabel1";
            companyNameLabel1.Size = new System.Drawing.Size(85, 13);
            companyNameLabel1.TabIndex = 8;
            companyNameLabel1.Text = "Company Name:";
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataSource = typeof(Impendulo.Data.Models.Enrollment);
            // 
            // enrollmentBindingNavigator
            // 
            this.enrollmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.enrollmentBindingNavigator.BindingSource = this.enrollmentBindingSource;
            this.enrollmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.enrollmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.enrollmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.enrollmentBindingNavigatorSaveItem});
            this.enrollmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.enrollmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.enrollmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.enrollmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.enrollmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.enrollmentBindingNavigator.Name = "enrollmentBindingNavigator";
            this.enrollmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.enrollmentBindingNavigator.Size = new System.Drawing.Size(955, 25);
            this.enrollmentBindingNavigator.TabIndex = 0;
            this.enrollmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // enrollmentBindingNavigatorSaveItem
            // 
            this.enrollmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enrollmentBindingNavigatorSaveItem.Enabled = false;
            this.enrollmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("enrollmentBindingNavigatorSaveItem.Image")));
            this.enrollmentBindingNavigatorSaveItem.Name = "enrollmentBindingNavigatorSaveItem";
            this.enrollmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.enrollmentBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // enrollmentDataGridView
            // 
            this.enrollmentDataGridView.AutoGenerateColumns = false;
            this.enrollmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrollmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.colSectional});
            this.enrollmentDataGridView.DataSource = this.enrollmentBindingSource;
            this.enrollmentDataGridView.Location = new System.Drawing.Point(34, 51);
            this.enrollmentDataGridView.Name = "enrollmentDataGridView";
            this.enrollmentDataGridView.Size = new System.Drawing.Size(536, 220);
            this.enrollmentDataGridView.TabIndex = 1;
            this.enrollmentDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.enrollmentDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EnrollmentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EnrollmentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateIntitiated";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateIntitiated";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colSectional
            // 
            this.colSectional.HeaderText = "sec";
            this.colSectional.Name = "colSectional";
            // 
            // individualFirstNameTextBox
            // 
            this.individualFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource, "Student.Individual.IndividualFirstName", true));
            this.individualFirstNameTextBox.Location = new System.Drawing.Point(182, 294);
            this.individualFirstNameTextBox.Name = "individualFirstNameTextBox";
            this.individualFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.individualFirstNameTextBox.TabIndex = 3;
            // 
            // individualLastnameTextBox
            // 
            this.individualLastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource, "Student.Individual.IndividualLastname", true));
            this.individualLastnameTextBox.Location = new System.Drawing.Point(182, 320);
            this.individualLastnameTextBox.Name = "individualLastnameTextBox";
            this.individualLastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.individualLastnameTextBox.TabIndex = 5;
            // 
            // studentAssociatedCompaniesBindingSource
            // 
            this.studentAssociatedCompaniesBindingSource.DataSource = typeof(Impendulo.Data.ObservableListSource<Impendulo.Data.Models.StudentAssociatedCompany>);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentAssociatedCompaniesBindingSource, "Company.CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(394, 294);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.companyNameTextBox.TabIndex = 7;
            // 
            // companyNameListBox
            // 
            this.companyNameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentAssociatedCompaniesBindingSource, "Company.CompanyName", true));
            this.companyNameListBox.FormattingEnabled = true;
            this.companyNameListBox.Location = new System.Drawing.Point(482, 362);
            this.companyNameListBox.Name = "companyNameListBox";
            this.companyNameListBox.Size = new System.Drawing.Size(120, 95);
            this.companyNameListBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.curriculumCourseIDDataGridViewTextBoxColumn,
            this.curriculumCourseParentIDDataGridViewTextBoxColumn,
            this.curriculumIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.enrollmentTypeIDDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.curricullumCourseCodeDataGridViewTextBoxColumn,
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn,
            this.curriculumDataGridViewTextBoxColumn,
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "CurriculumCourse";
            this.dataGridView1.DataSource = this.curriculumCourseEnrollmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(598, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 229);
            this.dataGridView1.TabIndex = 10;
            // 
            // curriculumCourseEnrollmentsBindingSource
            // 
            this.curriculumCourseEnrollmentsBindingSource.DataMember = "CurriculumCourseEnrollments";
            this.curriculumCourseEnrollmentsBindingSource.DataSource = this.enrollmentBindingSource;
            // 
            // curriculumCourseIDDataGridViewTextBoxColumn
            // 
            this.curriculumCourseIDDataGridViewTextBoxColumn.DataPropertyName = "CurriculumCourseID";
            this.curriculumCourseIDDataGridViewTextBoxColumn.HeaderText = "CurriculumCourseID";
            this.curriculumCourseIDDataGridViewTextBoxColumn.Name = "curriculumCourseIDDataGridViewTextBoxColumn";
            // 
            // curriculumCourseParentIDDataGridViewTextBoxColumn
            // 
            this.curriculumCourseParentIDDataGridViewTextBoxColumn.DataPropertyName = "CurriculumCourseParentID";
            this.curriculumCourseParentIDDataGridViewTextBoxColumn.HeaderText = "CurriculumCourseParentID";
            this.curriculumCourseParentIDDataGridViewTextBoxColumn.Name = "curriculumCourseParentIDDataGridViewTextBoxColumn";
            // 
            // curriculumIDDataGridViewTextBoxColumn
            // 
            this.curriculumIDDataGridViewTextBoxColumn.DataPropertyName = "CurriculumID";
            this.curriculumIDDataGridViewTextBoxColumn.HeaderText = "CurriculumID";
            this.curriculumIDDataGridViewTextBoxColumn.Name = "curriculumIDDataGridViewTextBoxColumn";
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // enrollmentTypeIDDataGridViewTextBoxColumn
            // 
            this.enrollmentTypeIDDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentTypeID";
            this.enrollmentTypeIDDataGridViewTextBoxColumn.HeaderText = "EnrollmentTypeID";
            this.enrollmentTypeIDDataGridViewTextBoxColumn.Name = "enrollmentTypeIDDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // curricullumCourseCodeDataGridViewTextBoxColumn
            // 
            this.curricullumCourseCodeDataGridViewTextBoxColumn.DataPropertyName = "CurricullumCourseCode";
            this.curricullumCourseCodeDataGridViewTextBoxColumn.HeaderText = "CurricullumCourseCode";
            this.curricullumCourseCodeDataGridViewTextBoxColumn.Name = "curricullumCourseCodeDataGridViewTextBoxColumn";
            // 
            // curriculumCourseMinimumMaximumDataGridViewTextBoxColumn
            // 
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn.DataPropertyName = "CurriculumCourseMinimumMaximum";
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn.HeaderText = "CurriculumCourseMinimumMaximum";
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn.Name = "curriculumCourseMinimumMaximumDataGridViewTextBoxColumn";
            // 
            // curriculumDataGridViewTextBoxColumn
            // 
            this.curriculumDataGridViewTextBoxColumn.DataPropertyName = "Curriculum";
            this.curriculumDataGridViewTextBoxColumn.HeaderText = "Curriculum";
            this.curriculumDataGridViewTextBoxColumn.Name = "curriculumDataGridViewTextBoxColumn";
            // 
            // lookupEnrollmentTypeDataGridViewTextBoxColumn
            // 
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn.DataPropertyName = "LookupEnrollmentType";
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn.HeaderText = "LookupEnrollmentType";
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn.Name = "lookupEnrollmentTypeDataGridViewTextBoxColumn";
            // 
            // frmtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 705);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(companyNameLabel1);
            this.Controls.Add(this.companyNameListBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(individualLastnameLabel);
            this.Controls.Add(this.individualLastnameTextBox);
            this.Controls.Add(individualFirstNameLabel);
            this.Controls.Add(this.individualFirstNameTextBox);
            this.Controls.Add(this.enrollmentDataGridView);
            this.Controls.Add(this.enrollmentBindingNavigator);
            this.Name = "frmtest";
            this.Text = "frmtest";
            this.Load += new System.EventHandler(this.frmtest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingNavigator)).EndInit();
            this.enrollmentBindingNavigator.ResumeLayout(false);
            this.enrollmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAssociatedCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumCourseEnrollmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private System.Windows.Forms.BindingNavigator enrollmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton enrollmentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView enrollmentDataGridView;
        private System.Windows.Forms.TextBox individualFirstNameTextBox;
        private System.Windows.Forms.TextBox individualLastnameTextBox;
        private System.Windows.Forms.BindingSource studentAssociatedCompaniesBindingSource;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectional;
        private System.Windows.Forms.ListBox companyNameListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumCourseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumCourseParentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curricullumCourseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumCourseMinimumMaximumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lookupEnrollmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource curriculumCourseEnrollmentsBindingSource;
    }
}