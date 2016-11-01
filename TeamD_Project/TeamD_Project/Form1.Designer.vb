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
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim IssueLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim Priority_lvlLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.IssueTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.IssueTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueTableDataSet = New TeamD_Project.IssueTableDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IssueTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IssueTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewIssueBtn = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.PhoneToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PhoneToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PhoneToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PhoneToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.IssueTableTableAdapter = New TeamD_Project.IssueTableDataSetTableAdapters.IssueTableTableAdapter()
        Me.TableAdapterManager = New TeamD_Project.IssueTableDataSetTableAdapters.TableAdapterManager()
        Me.Search = New System.Windows.Forms.Button()
        Me.WelcomeLbl = New System.Windows.Forms.Label()
        Me.PleaseFillLbl = New System.Windows.Forms.Label()
        Me.OrSearchLbl = New System.Windows.Forms.Label()
        Me.ContactInfoGroup = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.IssueInfoGroup = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Priority_lvlComboBox = New System.Windows.Forms.ComboBox()
        Me.IssueComboBox = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.CancelSearchBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeEstimateBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDirection = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        IssueLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        Priority_lvlLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.IssueTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IssueTableBindingNavigator.SuspendLayout()
        CType(Me.IssueTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueTableDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhoneToolStrip.SuspendLayout()
        Me.ContactInfoGroup.SuspendLayout()
        Me.IssueInfoGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(7, 35)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(7, 61)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(7, 87)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 7
        PhoneLabel.Text = "Phone:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(7, 113)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(76, 13)
        Email_AddressLabel.TabIndex = 9
        Email_AddressLabel.Text = "Email Address:"
        '
        'IssueLabel
        '
        IssueLabel.AutoSize = True
        IssueLabel.Location = New System.Drawing.Point(12, 35)
        IssueLabel.Name = "IssueLabel"
        IssueLabel.Size = New System.Drawing.Size(35, 13)
        IssueLabel.TabIndex = 11
        IssueLabel.Text = "Issue:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(12, 61)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(59, 13)
        CommentsLabel.TabIndex = 13
        CommentsLabel.Text = "Comments:"
        '
        'Priority_lvlLabel
        '
        Priority_lvlLabel.AutoSize = True
        Priority_lvlLabel.Location = New System.Drawing.Point(12, 87)
        Priority_lvlLabel.Name = "Priority_lvlLabel"
        Priority_lvlLabel.Size = New System.Drawing.Size(54, 13)
        Priority_lvlLabel.TabIndex = 15
        Priority_lvlLabel.Text = "Priority lvl:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 115)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 17
        DateLabel.Text = "Date:"
        '
        'IssueTableBindingNavigator
        '
        Me.IssueTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IssueTableBindingNavigator.BindingSource = Me.IssueTableBindingSource
        Me.IssueTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IssueTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IssueTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IssueTableBindingNavigatorSaveItem})
        Me.IssueTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IssueTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IssueTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IssueTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IssueTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IssueTableBindingNavigator.Name = "IssueTableBindingNavigator"
        Me.IssueTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IssueTableBindingNavigator.Size = New System.Drawing.Size(656, 25)
        Me.IssueTableBindingNavigator.TabIndex = 0
        Me.IssueTableBindingNavigator.Text = "BindingNavigator1"
        Me.IssueTableBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'IssueTableBindingSource
        '
        Me.IssueTableBindingSource.DataMember = "IssueTable"
        Me.IssueTableBindingSource.DataSource = Me.IssueTableDataSet
        '
        'IssueTableDataSet
        '
        Me.IssueTableDataSet.DataSetName = "IssueTableDataSet"
        Me.IssueTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IssueTableBindingNavigatorSaveItem
        '
        Me.IssueTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IssueTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("IssueTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IssueTableBindingNavigatorSaveItem.Name = "IssueTableBindingNavigatorSaveItem"
        Me.IssueTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.IssueTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueTableBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(89, 28)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox.TabIndex = 4
        Me.First_NameTextBox.Visible = False
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueTableBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(89, 58)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 6
        Me.Last_NameTextBox.Visible = False
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueTableBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(89, 84)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 8
        Me.PhoneTextBox.Visible = False
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueTableBindingSource, "Email_Address", True))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(89, 110)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Email_AddressTextBox.TabIndex = 10
        Me.Email_AddressTextBox.Visible = False
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueTableBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(94, 58)
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CommentsTextBox.TabIndex = 14
        Me.CommentsTextBox.Visible = False
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Checked = False
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssueTableBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(94, 110)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.ShowCheckBox = True
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 18
        Me.DateDateTimePicker.Visible = False
        '
        'IssueTableDataGridView
        '
        Me.IssueTableDataGridView.AutoGenerateColumns = False
        Me.IssueTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.IssueTableDataGridView.DataSource = Me.IssueTableBindingSource
        Me.IssueTableDataGridView.Location = New System.Drawing.Point(21, 362)
        Me.IssueTableDataGridView.Name = "IssueTableDataGridView"
        Me.IssueTableDataGridView.Size = New System.Drawing.Size(631, 152)
        Me.IssueTableDataGridView.TabIndex = 19
        Me.IssueTableDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Issue ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Issue ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email_Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email_Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Issue"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Issue"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Priority_lvl"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Priority_lvl"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'NewIssueBtn
        '
        Me.NewIssueBtn.Location = New System.Drawing.Point(379, 123)
        Me.NewIssueBtn.Name = "NewIssueBtn"
        Me.NewIssueBtn.Size = New System.Drawing.Size(75, 23)
        Me.NewIssueBtn.TabIndex = 20
        Me.NewIssueBtn.Text = "New Issue"
        Me.NewIssueBtn.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Location = New System.Drawing.Point(21, 331)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(125, 23)
        Me.Delete.TabIndex = 21
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Enabled = False
        Me.SubmitBtn.Location = New System.Drawing.Point(379, 159)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBtn.TabIndex = 22
        Me.SubmitBtn.Text = "Submit Issue"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'PhoneToolStrip
        '
        Me.PhoneToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.PhoneToolStrip.Enabled = False
        Me.PhoneToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhoneToolStripLabel, Me.PhoneToolStripTextBox, Me.PhoneToolStripButton})
        Me.PhoneToolStrip.Location = New System.Drawing.Point(281, 326)
        Me.PhoneToolStrip.Name = "PhoneToolStrip"
        Me.PhoneToolStrip.Size = New System.Drawing.Size(204, 25)
        Me.PhoneToolStrip.TabIndex = 23
        Me.PhoneToolStrip.Text = "PhoneToolStrip"
        Me.PhoneToolStrip.Visible = False
        '
        'PhoneToolStripLabel
        '
        Me.PhoneToolStripLabel.Name = "PhoneToolStripLabel"
        Me.PhoneToolStripLabel.Size = New System.Drawing.Size(44, 22)
        Me.PhoneToolStripLabel.Text = "Phone:"
        '
        'PhoneToolStripTextBox
        '
        Me.PhoneToolStripTextBox.Name = "PhoneToolStripTextBox"
        Me.PhoneToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'PhoneToolStripButton
        '
        Me.PhoneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PhoneToolStripButton.Name = "PhoneToolStripButton"
        Me.PhoneToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.PhoneToolStripButton.Text = "Search"
        '
        'IssueTableTableAdapter
        '
        Me.IssueTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IssueTableTableAdapter = Me.IssueTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = TeamD_Project.IssueTableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(344, 300)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(120, 23)
        Me.Search.TabIndex = 24
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'WelcomeLbl
        '
        Me.WelcomeLbl.AutoSize = True
        Me.WelcomeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLbl.Location = New System.Drawing.Point(166, 9)
        Me.WelcomeLbl.Name = "WelcomeLbl"
        Me.WelcomeLbl.Size = New System.Drawing.Size(510, 29)
        Me.WelcomeLbl.TabIndex = 26
        Me.WelcomeLbl.Text = "Welcome to the YesCo issue submission form!"
        '
        'PleaseFillLbl
        '
        Me.PleaseFillLbl.AutoSize = True
        Me.PleaseFillLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PleaseFillLbl.Location = New System.Drawing.Point(208, 50)
        Me.PleaseFillLbl.Name = "PleaseFillLbl"
        Me.PleaseFillLbl.Size = New System.Drawing.Size(432, 13)
        Me.PleaseFillLbl.TabIndex = 27
        Me.PleaseFillLbl.Text = "To submit an issue click ""New Issue"", fill in ALL fields, then click ""Submit"""
        '
        'OrSearchLbl
        '
        Me.OrSearchLbl.AutoSize = True
        Me.OrSearchLbl.Location = New System.Drawing.Point(281, 63)
        Me.OrSearchLbl.Name = "OrSearchLbl"
        Me.OrSearchLbl.Size = New System.Drawing.Size(278, 13)
        Me.OrSearchLbl.TabIndex = 28
        Me.OrSearchLbl.Text = "or you can search and delete previously submitted issues."
        '
        'ContactInfoGroup
        '
        Me.ContactInfoGroup.Controls.Add(Me.TextBox4)
        Me.ContactInfoGroup.Controls.Add(Email_AddressLabel)
        Me.ContactInfoGroup.Controls.Add(Me.First_NameTextBox)
        Me.ContactInfoGroup.Controls.Add(Me.Email_AddressTextBox)
        Me.ContactInfoGroup.Controls.Add(Me.TextBox1)
        Me.ContactInfoGroup.Controls.Add(PhoneLabel)
        Me.ContactInfoGroup.Controls.Add(Me.TextBox3)
        Me.ContactInfoGroup.Controls.Add(Last_NameLabel)
        Me.ContactInfoGroup.Controls.Add(Me.TextBox2)
        Me.ContactInfoGroup.Controls.Add(First_NameLabel)
        Me.ContactInfoGroup.Controls.Add(Me.PhoneTextBox)
        Me.ContactInfoGroup.Controls.Add(Me.Last_NameTextBox)
        Me.ContactInfoGroup.Location = New System.Drawing.Point(49, 98)
        Me.ContactInfoGroup.Name = "ContactInfoGroup"
        Me.ContactInfoGroup.Size = New System.Drawing.Size(309, 152)
        Me.ContactInfoGroup.TabIndex = 29
        Me.ContactInfoGroup.TabStop = False
        Me.ContactInfoGroup.Text = "Contact Info"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(89, 84)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 20)
        Me.TextBox4.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(89, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 35
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(89, 28)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(89, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 35
        '
        'IssueInfoGroup
        '
        Me.IssueInfoGroup.Controls.Add(Me.TextBox8)
        Me.IssueInfoGroup.Controls.Add(Me.Priority_lvlComboBox)
        Me.IssueInfoGroup.Controls.Add(Me.IssueComboBox)
        Me.IssueInfoGroup.Controls.Add(Me.TextBox7)
        Me.IssueInfoGroup.Controls.Add(Me.TextBox6)
        Me.IssueInfoGroup.Controls.Add(Me.DateDateTimePicker)
        Me.IssueInfoGroup.Controls.Add(DateLabel)
        Me.IssueInfoGroup.Controls.Add(Priority_lvlLabel)
        Me.IssueInfoGroup.Controls.Add(Me.CommentsTextBox)
        Me.IssueInfoGroup.Controls.Add(CommentsLabel)
        Me.IssueInfoGroup.Controls.Add(IssueLabel)
        Me.IssueInfoGroup.Controls.Add(Me.TextBox5)
        Me.IssueInfoGroup.Location = New System.Drawing.Point(471, 98)
        Me.IssueInfoGroup.Name = "IssueInfoGroup"
        Me.IssueInfoGroup.Size = New System.Drawing.Size(332, 152)
        Me.IssueInfoGroup.TabIndex = 30
        Me.IssueInfoGroup.TabStop = False
        Me.IssueInfoGroup.Text = "Issue Info"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(94, 58)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(200, 20)
        Me.TextBox8.TabIndex = 35
        '
        'Priority_lvlComboBox
        '
        Me.Priority_lvlComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueTableBindingSource, "Priority_lvl", True))
        Me.Priority_lvlComboBox.FormattingEnabled = True
        Me.Priority_lvlComboBox.Location = New System.Drawing.Point(94, 84)
        Me.Priority_lvlComboBox.Name = "Priority_lvlComboBox"
        Me.Priority_lvlComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Priority_lvlComboBox.TabIndex = 35
        Me.Priority_lvlComboBox.Visible = False
        '
        'IssueComboBox
        '
        Me.IssueComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueTableBindingSource, "Issue", True))
        Me.IssueComboBox.FormattingEnabled = True
        Me.IssueComboBox.Location = New System.Drawing.Point(94, 32)
        Me.IssueComboBox.Name = "IssueComboBox"
        Me.IssueComboBox.Size = New System.Drawing.Size(200, 21)
        Me.IssueComboBox.TabIndex = 19
        Me.IssueComboBox.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(94, 85)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(200, 20)
        Me.TextBox7.TabIndex = 35
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(94, 110)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(200, 20)
        Me.TextBox6.TabIndex = 35
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(94, 33)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 20)
        Me.TextBox5.TabIndex = 35
        '
        'CancelSearchBtn
        '
        Me.CancelSearchBtn.Enabled = False
        Me.CancelSearchBtn.Location = New System.Drawing.Point(667, 491)
        Me.CancelSearchBtn.Name = "CancelSearchBtn"
        Me.CancelSearchBtn.Size = New System.Drawing.Size(125, 23)
        Me.CancelSearchBtn.TabIndex = 31
        Me.CancelSearchBtn.Text = "Cancel Search"
        Me.CancelSearchBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(829, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'TimeEstimateBtn
        '
        Me.TimeEstimateBtn.Enabled = False
        Me.TimeEstimateBtn.Location = New System.Drawing.Point(152, 331)
        Me.TimeEstimateBtn.Name = "TimeEstimateBtn"
        Me.TimeEstimateBtn.Size = New System.Drawing.Size(128, 23)
        Me.TimeEstimateBtn.TabIndex = 33
        Me.TimeEstimateBtn.Text = "Time Estimate"
        Me.TimeEstimateBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Click 'Search' to display all your previously submitted issues!"
        '
        'lblDirection
        '
        Me.lblDirection.Location = New System.Drawing.Point(658, 362)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(134, 111)
        Me.lblDirection.TabIndex = 35
        Me.lblDirection.Text = "You now have the option of selecting and deleting the issue, or clicking ""Time Es" &
    "timate"" to see when the issue maintenance will start."
        Me.lblDirection.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 526)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TimeEstimateBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelSearchBtn)
        Me.Controls.Add(Me.IssueInfoGroup)
        Me.Controls.Add(Me.ContactInfoGroup)
        Me.Controls.Add(Me.OrSearchLbl)
        Me.Controls.Add(Me.PleaseFillLbl)
        Me.Controls.Add(Me.WelcomeLbl)
        Me.Controls.Add(Me.IssueTableDataGridView)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.PhoneToolStrip)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.NewIssueBtn)
        Me.Controls.Add(Me.IssueTableBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Issue Submission Form"
        CType(Me.IssueTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IssueTableBindingNavigator.ResumeLayout(False)
        Me.IssueTableBindingNavigator.PerformLayout()
        CType(Me.IssueTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueTableDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhoneToolStrip.ResumeLayout(False)
        Me.PhoneToolStrip.PerformLayout()
        Me.ContactInfoGroup.ResumeLayout(False)
        Me.ContactInfoGroup.PerformLayout()
        Me.IssueInfoGroup.ResumeLayout(False)
        Me.IssueInfoGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IssueTableDataSet As IssueTableDataSet
    Friend WithEvents IssueTableBindingSource As BindingSource
    Friend WithEvents IssueTableTableAdapter As IssueTableDataSetTableAdapters.IssueTableTableAdapter
    Friend WithEvents TableAdapterManager As IssueTableDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IssueTableBindingNavigator As BindingNavigator
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
    Friend WithEvents IssueTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Email_AddressTextBox As TextBox
    Friend WithEvents CommentsTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents IssueTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents NewIssueBtn As Button
    Friend WithEvents Delete As Button
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents PhoneToolStrip As ToolStrip
    Friend WithEvents PhoneToolStripLabel As ToolStripLabel
    Friend WithEvents PhoneToolStripTextBox As ToolStripTextBox
    Friend WithEvents PhoneToolStripButton As ToolStripButton
    Friend WithEvents Search As Button
    Friend WithEvents WelcomeLbl As Label
    Friend WithEvents PleaseFillLbl As Label
    Friend WithEvents OrSearchLbl As Label
    Friend WithEvents ContactInfoGroup As GroupBox
    Friend WithEvents IssueInfoGroup As GroupBox
    Friend WithEvents CancelSearchBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TimeEstimateBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Priority_lvlComboBox As ComboBox
    Friend WithEvents IssueComboBox As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents lblDirection As Label
End Class
