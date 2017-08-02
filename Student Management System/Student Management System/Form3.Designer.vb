<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudDetails))
        Me.Student = New System.Windows.Forms.DataGridView()
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet = New Student_Management_System.Database2DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bldgrp = New System.Windows.Forms.ComboBox()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.dad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.paddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.regno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.course = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.naam = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dfat = New System.Windows.Forms.Label()
        Me.dph = New System.Windows.Forms.Label()
        Me.dbg = New System.Windows.Forms.Label()
        Me.ddob = New System.Windows.Forms.Label()
        Me.dperaddres = New System.Windows.Forms.Label()
        Me.daddress = New System.Windows.Forms.Label()
        Me.dregno = New System.Windows.Forms.Label()
        Me.ddept = New System.Windows.Forms.Label()
        Me.dcourse = New System.Windows.Forms.Label()
        Me.dname = New System.Windows.Forms.Label()
        Me.regg = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Student_DetailsTableAdapter = New Student_Management_System.Database2DataSetTableAdapters.Student_DetailsTableAdapter()
        CType(Me.Student, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Student
        '
        Me.Student.AutoGenerateColumns = False
        Me.Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Student.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.RegNoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PerAddressDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.BloodGroupDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.FatherNameDataGridViewTextBoxColumn})
        Me.Student.DataSource = Me.StudentDetailsBindingSource
        Me.Student.Location = New System.Drawing.Point(148, 198)
        Me.Student.Name = "Student"
        Me.Student.Size = New System.Drawing.Size(127, 150)
        Me.Student.TabIndex = 0
        Me.Student.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "Dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "Dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        '
        'RegNoDataGridViewTextBoxColumn
        '
        Me.RegNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.HeaderText = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.Name = "RegNoDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PerAddressDataGridViewTextBoxColumn
        '
        Me.PerAddressDataGridViewTextBoxColumn.DataPropertyName = "Per Address"
        Me.PerAddressDataGridViewTextBoxColumn.HeaderText = "Per Address"
        Me.PerAddressDataGridViewTextBoxColumn.Name = "PerAddressDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'BloodGroupDataGridViewTextBoxColumn
        '
        Me.BloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn.Name = "BloodGroupDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        '
        'StudentDetailsBindingSource
        '
        Me.StudentDetailsBindingSource.DataMember = "Student Details"
        Me.StudentDetailsBindingSource.DataSource = Me.BindingSource1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bldgrp)
        Me.GroupBox1.Controls.Add(Me.dob)
        Me.GroupBox1.Controls.Add(Me.dad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.pno)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.paddress)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.address)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.regno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Dept)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.course)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.naam)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 713)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Details"
        '
        'bldgrp
        '
        Me.bldgrp.FormattingEnabled = True
        Me.bldgrp.Items.AddRange(New Object() {"A+", "B+", "A-", "B-", "AB+", "AB-", "O+", "O-"})
        Me.bldgrp.Location = New System.Drawing.Point(72, 497)
        Me.bldgrp.Name = "bldgrp"
        Me.bldgrp.Size = New System.Drawing.Size(164, 21)
        Me.bldgrp.TabIndex = 23
        '
        'dob
        '
        Me.dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dob.Location = New System.Drawing.Point(55, 457)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(200, 20)
        Me.dob.TabIndex = 22
        Me.dob.Value = New Date(2015, 10, 2, 10, 50, 42, 0)
        '
        'dad
        '
        Me.dad.Location = New System.Drawing.Point(69, 579)
        Me.dad.Name = "dad"
        Me.dad.Size = New System.Drawing.Size(194, 20)
        Me.dad.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-3, 578)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "FathersName"
        '
        'pno
        '
        Me.pno.Location = New System.Drawing.Point(55, 538)
        Me.pno.Name = "pno"
        Me.pno.Size = New System.Drawing.Size(208, 20)
        Me.pno.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(-3, 542)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "PhoneNo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-3, 498)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "BloodGrp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 458)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "DOB"
        '
        'paddress
        '
        Me.paddress.Location = New System.Drawing.Point(56, 311)
        Me.paddress.Multiline = True
        Me.paddress.Name = "paddress"
        Me.paddress.Size = New System.Drawing.Size(207, 130)
        Me.paddress.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-3, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PermAddr"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(55, 188)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(208, 117)
        Me.address.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address"
        '
        'regno
        '
        Me.regno.Location = New System.Drawing.Point(55, 155)
        Me.regno.Name = "regno"
        Me.regno.Size = New System.Drawing.Size(208, 20)
        Me.regno.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "RegNo"
        '
        'Dept
        '
        Me.Dept.Location = New System.Drawing.Point(55, 120)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(208, 20)
        Me.Dept.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dept"
        '
        'course
        '
        Me.course.Location = New System.Drawing.Point(55, 87)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(208, 20)
        Me.course.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Course"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 628)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'naam
        '
        Me.naam.Location = New System.Drawing.Point(55, 53)
        Me.naam.Name = "naam"
        Me.naam.Size = New System.Drawing.Size(208, 20)
        Me.naam.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dfat)
        Me.GroupBox2.Controls.Add(Me.dph)
        Me.GroupBox2.Controls.Add(Me.Student)
        Me.GroupBox2.Controls.Add(Me.dbg)
        Me.GroupBox2.Controls.Add(Me.ddob)
        Me.GroupBox2.Controls.Add(Me.dperaddres)
        Me.GroupBox2.Controls.Add(Me.daddress)
        Me.GroupBox2.Controls.Add(Me.dregno)
        Me.GroupBox2.Controls.Add(Me.ddept)
        Me.GroupBox2.Controls.Add(Me.dcourse)
        Me.GroupBox2.Controls.Add(Me.dname)
        Me.GroupBox2.Controls.Add(Me.regg)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(396, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 723)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display Details"
        '
        'dfat
        '
        Me.dfat.AutoSize = True
        Me.dfat.Location = New System.Drawing.Point(21, 626)
        Me.dfat.Name = "dfat"
        Me.dfat.Size = New System.Drawing.Size(70, 13)
        Me.dfat.TabIndex = 28
        Me.dfat.Text = "FathersName"
        '
        'dph
        '
        Me.dph.AutoSize = True
        Me.dph.Location = New System.Drawing.Point(22, 592)
        Me.dph.Name = "dph"
        Me.dph.Size = New System.Drawing.Size(52, 13)
        Me.dph.TabIndex = 27
        Me.dph.Text = "PhoneNo"
        '
        'dbg
        '
        Me.dbg.AutoSize = True
        Me.dbg.Location = New System.Drawing.Point(23, 552)
        Me.dbg.Name = "dbg"
        Me.dbg.Size = New System.Drawing.Size(51, 13)
        Me.dbg.TabIndex = 26
        Me.dbg.Text = "BloodGrp"
        '
        'ddob
        '
        Me.ddob.AutoSize = True
        Me.ddob.Location = New System.Drawing.Point(27, 509)
        Me.ddob.Name = "ddob"
        Me.ddob.Size = New System.Drawing.Size(30, 13)
        Me.ddob.TabIndex = 25
        Me.ddob.Text = "DOB"
        '
        'dperaddres
        '
        Me.dperaddres.AutoSize = True
        Me.dperaddres.Location = New System.Drawing.Point(21, 401)
        Me.dperaddres.Name = "dperaddres"
        Me.dperaddres.Size = New System.Drawing.Size(53, 13)
        Me.dperaddres.TabIndex = 24
        Me.dperaddres.Text = "PermAddr"
        '
        'daddress
        '
        Me.daddress.AutoSize = True
        Me.daddress.Location = New System.Drawing.Point(21, 280)
        Me.daddress.Name = "daddress"
        Me.daddress.Size = New System.Drawing.Size(45, 13)
        Me.daddress.TabIndex = 23
        Me.daddress.Text = "Address"
        '
        'dregno
        '
        Me.dregno.AutoSize = True
        Me.dregno.Location = New System.Drawing.Point(19, 230)
        Me.dregno.Name = "dregno"
        Me.dregno.Size = New System.Drawing.Size(41, 13)
        Me.dregno.TabIndex = 22
        Me.dregno.Text = "RegNo"
        '
        'ddept
        '
        Me.ddept.AutoSize = True
        Me.ddept.Location = New System.Drawing.Point(21, 208)
        Me.ddept.Name = "ddept"
        Me.ddept.Size = New System.Drawing.Size(30, 13)
        Me.ddept.TabIndex = 21
        Me.ddept.Text = "Dept"
        '
        'dcourse
        '
        Me.dcourse.AutoSize = True
        Me.dcourse.Location = New System.Drawing.Point(21, 181)
        Me.dcourse.Name = "dcourse"
        Me.dcourse.Size = New System.Drawing.Size(40, 13)
        Me.dcourse.TabIndex = 4
        Me.dcourse.Text = "Course"
        '
        'dname
        '
        Me.dname.AutoSize = True
        Me.dname.Location = New System.Drawing.Point(19, 160)
        Me.dname.Name = "dname"
        Me.dname.Size = New System.Drawing.Size(38, 13)
        Me.dname.TabIndex = 3
        Me.dname.Text = "Name:"
        '
        'regg
        '
        Me.regg.Location = New System.Drawing.Point(16, 71)
        Me.regg.Name = "regg"
        Me.regg.Size = New System.Drawing.Size(299, 20)
        Me.regg.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Enter Registration No."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Display"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Student_DetailsTableAdapter
        '
        Me.Student_DetailsTableAdapter.ClearBeforeFill = True
        '
        'StudDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(817, 503)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Details"
        CType(Me.Student, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Database2DataSet As Database2DataSet
    Friend WithEvents Student As DataGridView
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
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents naam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents paddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents regno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Dept As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents course As TextBox
    Friend WithEvents bldgrp As ComboBox
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dfat As Label
    Friend WithEvents dph As Label
    Friend WithEvents dbg As Label
    Friend WithEvents ddob As Label
    Friend WithEvents dperaddres As Label
    Friend WithEvents daddress As Label
    Friend WithEvents dregno As Label
    Friend WithEvents ddept As Label
    Friend WithEvents dcourse As Label
    Friend WithEvents dname As Label
    Friend WithEvents regg As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
End Class
