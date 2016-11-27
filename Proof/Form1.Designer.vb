<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CourseCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseCategoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CourseCategoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CourseCategoryComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.CourseCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseCategoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CourseCategoryBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CourseCategoryBindingSource
        '
        Me.CourseCategoryBindingSource.DataSource = GetType(Impendulo.Data.Models.CourseCategory)
        '
        'CourseCategoryBindingNavigator
        '
        Me.CourseCategoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CourseCategoryBindingNavigator.BindingSource = Me.CourseCategoryBindingSource
        Me.CourseCategoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CourseCategoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CourseCategoryBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CourseCategoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CourseCategoryBindingNavigatorSaveItem})
        Me.CourseCategoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CourseCategoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CourseCategoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CourseCategoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CourseCategoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CourseCategoryBindingNavigator.Name = "CourseCategoryBindingNavigator"
        Me.CourseCategoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CourseCategoryBindingNavigator.Size = New System.Drawing.Size(385, 29)
        Me.CourseCategoryBindingNavigator.TabIndex = 0
        Me.CourseCategoryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CourseCategoryBindingNavigatorSaveItem
        '
        Me.CourseCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CourseCategoryBindingNavigatorSaveItem.Enabled = False
        Me.CourseCategoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("CourseCategoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CourseCategoryBindingNavigatorSaveItem.Name = "CourseCategoryBindingNavigatorSaveItem"
        Me.CourseCategoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 26)
        Me.CourseCategoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CourseCategoryComboBox
        '
        Me.CourseCategoryComboBox.DataSource = Me.CourseCategoryBindingSource
        Me.CourseCategoryComboBox.DisplayMember = "CourseCategoryName"
        Me.CourseCategoryComboBox.FormattingEnabled = True
        Me.CourseCategoryComboBox.Location = New System.Drawing.Point(65, 96)
        Me.CourseCategoryComboBox.Name = "CourseCategoryComboBox"
        Me.CourseCategoryComboBox.Size = New System.Drawing.Size(300, 24)
        Me.CourseCategoryComboBox.TabIndex = 1
        Me.CourseCategoryComboBox.ValueMember = "CourseCategoryID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 253)
        Me.Controls.Add(Me.CourseCategoryComboBox)
        Me.Controls.Add(Me.CourseCategoryBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CourseCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseCategoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CourseCategoryBindingNavigator.ResumeLayout(False)
        Me.CourseCategoryBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CourseCategoryBindingSource As BindingSource
    Friend WithEvents CourseCategoryBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CourseCategoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CourseCategoryComboBox As ComboBox
End Class
