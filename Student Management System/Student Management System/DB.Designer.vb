<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DB))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet = New Student_Management_System.Database2DataSet()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MrksDataSet = New Student_Management_System.mrksDataSet()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceDataSet = New Student_Management_System.attendanceDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_DetailsTableAdapter = New Student_Management_System.Database2DataSetTableAdapters.Student_DetailsTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SDet = New System.Windows.Forms.TabPage()
        Me.SAtt = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.RegNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemistryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MathsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BiologyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocialScienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeographyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComputerScienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Smarks = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.RegNoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MathsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemistryDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BiologyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocialStudiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeographyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComputerScienceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarksTableAdapter = New Student_Management_System.mrksDataSetTableAdapters.MarksTableAdapter()
        Me.AttendanceTableAdapter = New Student_Management_System.attendanceDataSetTableAdapters.attendanceTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MrksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SDet.SuspendLayout()
        Me.SAtt.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Smarks.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.Database2DataSet
        Me.BindingSource1.Position = 0
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource2
        '
        Me.BindingSource2.DataSource = Me.MrksDataSet
        Me.BindingSource2.Position = 0
        '
        'MrksDataSet
        '
        Me.MrksDataSet.DataSetName = "mrksDataSet"
        Me.MrksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource3
        '
        Me.BindingSource3.DataSource = Me.AttendanceDataSet
        Me.BindingSource3.Position = 0
        '
        'AttendanceDataSet
        '
        Me.AttendanceDataSet.DataSetName = "attendanceDataSet"
        Me.AttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.RegNoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PerAddressDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.BloodGroupDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.FatherNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentDetailsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(711, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "Dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "Dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        Me.DeptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegNoDataGridViewTextBoxColumn
        '
        Me.RegNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.HeaderText = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.Name = "RegNoDataGridViewTextBoxColumn"
        Me.RegNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PerAddressDataGridViewTextBoxColumn
        '
        Me.PerAddressDataGridViewTextBoxColumn.DataPropertyName = "Per Address"
        Me.PerAddressDataGridViewTextBoxColumn.HeaderText = "Per Address"
        Me.PerAddressDataGridViewTextBoxColumn.Name = "PerAddressDataGridViewTextBoxColumn"
        Me.PerAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BloodGroupDataGridViewTextBoxColumn
        '
        Me.BloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn.Name = "BloodGroupDataGridViewTextBoxColumn"
        Me.BloodGroupDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        Me.FatherNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentDetailsBindingSource
        '
        Me.StudentDetailsBindingSource.DataMember = "Student Details"
        Me.StudentDetailsBindingSource.DataSource = Me.BindingSource1
        '
        'Student_DetailsTableAdapter
        '
        Me.Student_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SDet)
        Me.TabControl1.Controls.Add(Me.SAtt)
        Me.TabControl1.Controls.Add(Me.Smarks)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(725, 273)
        Me.TabControl1.TabIndex = 1
        '
        'SDet
        '
        Me.SDet.AutoScroll = True
        Me.SDet.Controls.Add(Me.DataGridView1)
        Me.SDet.Location = New System.Drawing.Point(4, 22)
        Me.SDet.Name = "SDet"
        Me.SDet.Padding = New System.Windows.Forms.Padding(3)
        Me.SDet.Size = New System.Drawing.Size(717, 247)
        Me.SDet.TabIndex = 0
        Me.SDet.Text = "Student Details"
        Me.SDet.UseVisualStyleBackColor = True
        '
        'SAtt
        '
        Me.SAtt.Controls.Add(Me.DataGridView2)
        Me.SAtt.Location = New System.Drawing.Point(4, 22)
        Me.SAtt.Name = "SAtt"
        Me.SAtt.Padding = New System.Windows.Forms.Padding(3)
        Me.SAtt.Size = New System.Drawing.Size(717, 247)
        Me.SAtt.TabIndex = 1
        Me.SAtt.Text = "Student Attendance"
        Me.SAtt.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegNoDataGridViewTextBoxColumn1, Me.PhysicsDataGridViewTextBoxColumn, Me.ChemistryDataGridViewTextBoxColumn, Me.MathsDataGridViewTextBoxColumn, Me.BiologyDataGridViewTextBoxColumn, Me.SocialScienceDataGridViewTextBoxColumn, Me.GeographyDataGridViewTextBoxColumn, Me.ComputerScienceDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.AttendanceBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(711, 241)
        Me.DataGridView2.TabIndex = 0
        '
        'RegNoDataGridViewTextBoxColumn1
        '
        Me.RegNoDataGridViewTextBoxColumn1.DataPropertyName = "Reg_No"
        Me.RegNoDataGridViewTextBoxColumn1.HeaderText = "Reg_No"
        Me.RegNoDataGridViewTextBoxColumn1.Name = "RegNoDataGridViewTextBoxColumn1"
        Me.RegNoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PhysicsDataGridViewTextBoxColumn
        '
        Me.PhysicsDataGridViewTextBoxColumn.DataPropertyName = "Physics"
        Me.PhysicsDataGridViewTextBoxColumn.HeaderText = "Physics"
        Me.PhysicsDataGridViewTextBoxColumn.Name = "PhysicsDataGridViewTextBoxColumn"
        Me.PhysicsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChemistryDataGridViewTextBoxColumn
        '
        Me.ChemistryDataGridViewTextBoxColumn.DataPropertyName = "Chemistry"
        Me.ChemistryDataGridViewTextBoxColumn.HeaderText = "Chemistry"
        Me.ChemistryDataGridViewTextBoxColumn.Name = "ChemistryDataGridViewTextBoxColumn"
        Me.ChemistryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MathsDataGridViewTextBoxColumn
        '
        Me.MathsDataGridViewTextBoxColumn.DataPropertyName = "Maths"
        Me.MathsDataGridViewTextBoxColumn.HeaderText = "Maths"
        Me.MathsDataGridViewTextBoxColumn.Name = "MathsDataGridViewTextBoxColumn"
        Me.MathsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BiologyDataGridViewTextBoxColumn
        '
        Me.BiologyDataGridViewTextBoxColumn.DataPropertyName = "Biology"
        Me.BiologyDataGridViewTextBoxColumn.HeaderText = "Biology"
        Me.BiologyDataGridViewTextBoxColumn.Name = "BiologyDataGridViewTextBoxColumn"
        Me.BiologyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SocialScienceDataGridViewTextBoxColumn
        '
        Me.SocialScienceDataGridViewTextBoxColumn.DataPropertyName = "Social_Science"
        Me.SocialScienceDataGridViewTextBoxColumn.HeaderText = "Social_Science"
        Me.SocialScienceDataGridViewTextBoxColumn.Name = "SocialScienceDataGridViewTextBoxColumn"
        Me.SocialScienceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeographyDataGridViewTextBoxColumn
        '
        Me.GeographyDataGridViewTextBoxColumn.DataPropertyName = "Geography"
        Me.GeographyDataGridViewTextBoxColumn.HeaderText = "Geography"
        Me.GeographyDataGridViewTextBoxColumn.Name = "GeographyDataGridViewTextBoxColumn"
        Me.GeographyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComputerScienceDataGridViewTextBoxColumn
        '
        Me.ComputerScienceDataGridViewTextBoxColumn.DataPropertyName = "Computer_Science"
        Me.ComputerScienceDataGridViewTextBoxColumn.HeaderText = "Computer_Science"
        Me.ComputerScienceDataGridViewTextBoxColumn.Name = "ComputerScienceDataGridViewTextBoxColumn"
        Me.ComputerScienceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttendanceBindingSource
        '
        Me.AttendanceBindingSource.DataMember = "attendance"
        Me.AttendanceBindingSource.DataSource = Me.BindingSource3
        '
        'Smarks
        '
        Me.Smarks.Controls.Add(Me.DataGridView3)
        Me.Smarks.Location = New System.Drawing.Point(4, 22)
        Me.Smarks.Name = "Smarks"
        Me.Smarks.Padding = New System.Windows.Forms.Padding(3)
        Me.Smarks.Size = New System.Drawing.Size(717, 247)
        Me.Smarks.TabIndex = 2
        Me.Smarks.Text = "Student Academics"
        Me.Smarks.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegNoDataGridViewTextBoxColumn2, Me.MathsDataGridViewTextBoxColumn1, Me.PhysicsDataGridViewTextBoxColumn1, Me.ChemistryDataGridViewTextBoxColumn1, Me.BiologyDataGridViewTextBoxColumn1, Me.SocialStudiesDataGridViewTextBoxColumn, Me.GeographyDataGridViewTextBoxColumn1, Me.ComputerScienceDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.MarksBindingSource
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(711, 241)
        Me.DataGridView3.TabIndex = 0
        '
        'RegNoDataGridViewTextBoxColumn2
        '
        Me.RegNoDataGridViewTextBoxColumn2.DataPropertyName = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn2.HeaderText = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn2.Name = "RegNoDataGridViewTextBoxColumn2"
        Me.RegNoDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'MathsDataGridViewTextBoxColumn1
        '
        Me.MathsDataGridViewTextBoxColumn1.DataPropertyName = "Maths"
        Me.MathsDataGridViewTextBoxColumn1.HeaderText = "Maths"
        Me.MathsDataGridViewTextBoxColumn1.Name = "MathsDataGridViewTextBoxColumn1"
        Me.MathsDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PhysicsDataGridViewTextBoxColumn1
        '
        Me.PhysicsDataGridViewTextBoxColumn1.DataPropertyName = "Physics"
        Me.PhysicsDataGridViewTextBoxColumn1.HeaderText = "Physics"
        Me.PhysicsDataGridViewTextBoxColumn1.Name = "PhysicsDataGridViewTextBoxColumn1"
        Me.PhysicsDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ChemistryDataGridViewTextBoxColumn1
        '
        Me.ChemistryDataGridViewTextBoxColumn1.DataPropertyName = "Chemistry"
        Me.ChemistryDataGridViewTextBoxColumn1.HeaderText = "Chemistry"
        Me.ChemistryDataGridViewTextBoxColumn1.Name = "ChemistryDataGridViewTextBoxColumn1"
        Me.ChemistryDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BiologyDataGridViewTextBoxColumn1
        '
        Me.BiologyDataGridViewTextBoxColumn1.DataPropertyName = "Biology"
        Me.BiologyDataGridViewTextBoxColumn1.HeaderText = "Biology"
        Me.BiologyDataGridViewTextBoxColumn1.Name = "BiologyDataGridViewTextBoxColumn1"
        Me.BiologyDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SocialStudiesDataGridViewTextBoxColumn
        '
        Me.SocialStudiesDataGridViewTextBoxColumn.DataPropertyName = "Social Studies"
        Me.SocialStudiesDataGridViewTextBoxColumn.HeaderText = "Social Studies"
        Me.SocialStudiesDataGridViewTextBoxColumn.Name = "SocialStudiesDataGridViewTextBoxColumn"
        Me.SocialStudiesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeographyDataGridViewTextBoxColumn1
        '
        Me.GeographyDataGridViewTextBoxColumn1.DataPropertyName = "Geography"
        Me.GeographyDataGridViewTextBoxColumn1.HeaderText = "Geography"
        Me.GeographyDataGridViewTextBoxColumn1.Name = "GeographyDataGridViewTextBoxColumn1"
        Me.GeographyDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ComputerScienceDataGridViewTextBoxColumn1
        '
        Me.ComputerScienceDataGridViewTextBoxColumn1.DataPropertyName = "Computer Science"
        Me.ComputerScienceDataGridViewTextBoxColumn1.HeaderText = "Computer Science"
        Me.ComputerScienceDataGridViewTextBoxColumn1.Name = "ComputerScienceDataGridViewTextBoxColumn1"
        Me.ComputerScienceDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MarksBindingSource
        '
        Me.MarksBindingSource.DataMember = "Marks"
        Me.MarksBindingSource.DataSource = Me.BindingSource2
        '
        'MarksTableAdapter
        '
        Me.MarksTableAdapter.ClearBeforeFill = True
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'DB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(725, 273)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MrksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.SDet.ResumeLayout(False)
        Me.SAtt.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Smarks.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Database2DataSet As Database2DataSet
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents MrksDataSet As mrksDataSet
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents AttendanceDataSet As attendanceDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentDetailsBindingSource As BindingSource
    Friend WithEvents Student_DetailsTableAdapter As Database2DataSetTableAdapters.Student_DetailsTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodGroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FatherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SDet As TabPage
    Friend WithEvents SAtt As TabPage
    Friend WithEvents Smarks As TabPage
    Friend WithEvents MarksBindingSource As BindingSource
    Friend WithEvents MarksTableAdapter As mrksDataSetTableAdapters.MarksTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceBindingSource As BindingSource
    Friend WithEvents AttendanceTableAdapter As attendanceDataSetTableAdapters.attendanceTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RegNoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MathsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PhysicsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ChemistryDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BiologyDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SocialStudiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeographyDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ComputerScienceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents RegNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PhysicsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChemistryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MathsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BiologyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SocialScienceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeographyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComputerScienceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
