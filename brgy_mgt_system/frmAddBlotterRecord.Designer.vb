<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddBlotterRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.frm = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIncidentType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtContactNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtIncident = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLocation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtReportingPerson = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIncidentDetails = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtReported = New System.Windows.Forms.DateTimePicker()
        Me.EPIncidentType = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPLocation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPReportingPerson = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPContactNo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPIncidentDetails = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        CType(Me.EPIncidentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPReportingPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPContactNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPIncidentDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(63, 347)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 19)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Incident Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(63, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Date && Time Reported"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(63, 88)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 19)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Incident Type"
        '
        'frm
        '
        Me.frm.BorderRadius = 10
        Me.frm.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito", 21.62!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 31)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Blotter Record Entry"
        '
        'txtIncidentType
        '
        Me.txtIncidentType.BorderRadius = 5
        Me.txtIncidentType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIncidentType.DefaultText = ""
        Me.txtIncidentType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtIncidentType.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtIncidentType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtIncidentType.DisabledState.Parent = Me.txtIncidentType
        Me.txtIncidentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIncidentType.FocusedState.Parent = Me.txtIncidentType
        Me.txtIncidentType.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtIncidentType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIncidentType.HoverState.Parent = Me.txtIncidentType
        Me.txtIncidentType.Location = New System.Drawing.Point(63, 111)
        Me.txtIncidentType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIncidentType.Name = "txtIncidentType"
        Me.txtIncidentType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIncidentType.PlaceholderText = ""
        Me.txtIncidentType.SelectedText = ""
        Me.txtIncidentType.ShadowDecoration.Parent = Me.txtIncidentType
        Me.txtIncidentType.Size = New System.Drawing.Size(215, 38)
        Me.txtIncidentType.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(619, 68)
        Me.Guna2Panel1.TabIndex = 133
        '
        'btnCancel
        '
        Me.btnCancel.BorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Nunito", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(478, 13)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(32, 36, 32, 36)
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(77, 40)
        Me.btnCancel.TabIndex = 48
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 5
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Nunito", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(375, 13)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(32, 36, 32, 36)
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(77, 40)
        Me.btnSave.TabIndex = 84
        Me.btnSave.Text = "Save"
        '
        'txtContactNo
        '
        Me.txtContactNo.BorderRadius = 5
        Me.txtContactNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNo.DefaultText = ""
        Me.txtContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtContactNo.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtContactNo.DisabledState.Parent = Me.txtContactNo
        Me.txtContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNo.FocusedState.Parent = Me.txtContactNo
        Me.txtContactNo.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNo.HoverState.Parent = Me.txtContactNo
        Me.txtContactNo.Location = New System.Drawing.Point(340, 286)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNo.PlaceholderText = ""
        Me.txtContactNo.SelectedText = ""
        Me.txtContactNo.ShadowDecoration.Parent = Me.txtContactNo
        Me.txtContactNo.Size = New System.Drawing.Size(215, 38)
        Me.txtContactNo.TabIndex = 5
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.btnCancel)
        Me.Guna2Panel2.Controls.Add(Me.btnSave)
        Me.Guna2Panel2.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 536)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(619, 64)
        Me.Guna2Panel2.TabIndex = 134
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 5
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Nunito", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Location = New System.Drawing.Point(375, 13)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Padding = New System.Windows.Forms.Padding(32, 36, 32, 36)
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(77, 40)
        Me.btnUpdate.TabIndex = 85
        Me.btnUpdate.Text = "Update"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Location = New System.Drawing.Point(1526, 513)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Guna2Panel3.TabIndex = 142
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel4.BorderRadius = 6
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.dtIncident)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.Location = New System.Drawing.Point(8, 7)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(194, 24)
        Me.Guna2Panel4.TabIndex = 143
        Me.Guna2Panel4.UseTransparentBackground = True
        '
        'dtIncident
        '
        Me.dtIncident.CalendarFont = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtIncident.CustomFormat = "MMM dd yyyy  hh:mm tt"
        Me.dtIncident.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtIncident.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtIncident.Location = New System.Drawing.Point(-1, -2)
        Me.dtIncident.Name = "dtIncident"
        Me.dtIncident.ShowUpDown = True
        Me.dtIncident.Size = New System.Drawing.Size(198, 28)
        Me.dtIncident.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(340, 264)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Contact No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(340, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 19)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Date && Time Incident"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(340, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.BorderRadius = 5
        Me.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocation.DefaultText = ""
        Me.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtLocation.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtLocation.DisabledState.Parent = Me.txtLocation
        Me.txtLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLocation.FocusedState.Parent = Me.txtLocation
        Me.txtLocation.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLocation.HoverState.Parent = Me.txtLocation
        Me.txtLocation.Location = New System.Drawing.Point(340, 111)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocation.PlaceholderText = ""
        Me.txtLocation.SelectedText = ""
        Me.txtLocation.ShadowDecoration.Parent = Me.txtLocation
        Me.txtLocation.Size = New System.Drawing.Size(215, 38)
        Me.txtLocation.TabIndex = 1
        '
        'txtReportingPerson
        '
        Me.txtReportingPerson.BorderRadius = 5
        Me.txtReportingPerson.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReportingPerson.DefaultText = ""
        Me.txtReportingPerson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtReportingPerson.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtReportingPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtReportingPerson.DisabledState.Parent = Me.txtReportingPerson
        Me.txtReportingPerson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReportingPerson.FocusedState.Parent = Me.txtReportingPerson
        Me.txtReportingPerson.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtReportingPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReportingPerson.HoverState.Parent = Me.txtReportingPerson
        Me.txtReportingPerson.Location = New System.Drawing.Point(63, 286)
        Me.txtReportingPerson.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReportingPerson.Name = "txtReportingPerson"
        Me.txtReportingPerson.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReportingPerson.PlaceholderText = ""
        Me.txtReportingPerson.SelectedText = ""
        Me.txtReportingPerson.ShadowDecoration.Parent = Me.txtReportingPerson
        Me.txtReportingPerson.Size = New System.Drawing.Size(215, 38)
        Me.txtReportingPerson.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(63, 264)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 19)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "Reporting Person"
        '
        'txtIncidentDetails
        '
        Me.txtIncidentDetails.BorderRadius = 5
        Me.txtIncidentDetails.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIncidentDetails.DefaultText = ""
        Me.txtIncidentDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtIncidentDetails.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtIncidentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtIncidentDetails.DisabledState.Parent = Me.txtIncidentDetails
        Me.txtIncidentDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIncidentDetails.FocusedState.Parent = Me.txtIncidentDetails
        Me.txtIncidentDetails.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtIncidentDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIncidentDetails.HoverState.Parent = Me.txtIncidentDetails
        Me.txtIncidentDetails.Location = New System.Drawing.Point(63, 370)
        Me.txtIncidentDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIncidentDetails.Multiline = True
        Me.txtIncidentDetails.Name = "txtIncidentDetails"
        Me.txtIncidentDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIncidentDetails.PlaceholderText = ""
        Me.txtIncidentDetails.SelectedText = ""
        Me.txtIncidentDetails.ShadowDecoration.Parent = Me.txtIncidentDetails
        Me.txtIncidentDetails.Size = New System.Drawing.Size(492, 143)
        Me.txtIncidentDetails.TabIndex = 6
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Panel5.BorderRadius = 6
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel5.Location = New System.Drawing.Point(340, 200)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(215, 38)
        Me.Guna2Panel5.TabIndex = 158
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Panel7.BorderRadius = 6
        Me.Guna2Panel7.BorderThickness = 1
        Me.Guna2Panel7.Controls.Add(Me.Guna2Panel8)
        Me.Guna2Panel7.Location = New System.Drawing.Point(63, 200)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(215, 38)
        Me.Guna2Panel7.TabIndex = 159
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel8.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel8.BorderRadius = 6
        Me.Guna2Panel8.BorderThickness = 1
        Me.Guna2Panel8.Controls.Add(Me.dtReported)
        Me.Guna2Panel8.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel8.Location = New System.Drawing.Point(8, 7)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.ShadowDecoration.Parent = Me.Guna2Panel8
        Me.Guna2Panel8.Size = New System.Drawing.Size(194, 24)
        Me.Guna2Panel8.TabIndex = 143
        Me.Guna2Panel8.UseTransparentBackground = True
        '
        'dtReported
        '
        Me.dtReported.CalendarFont = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtReported.CustomFormat = "MMM dd yyyy  hh:mm tt"
        Me.dtReported.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtReported.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReported.Location = New System.Drawing.Point(-1, -2)
        Me.dtReported.Name = "dtReported"
        Me.dtReported.ShowUpDown = True
        Me.dtReported.Size = New System.Drawing.Size(198, 28)
        Me.dtReported.TabIndex = 2
        '
        'EPIncidentType
        '
        Me.EPIncidentType.ContainerControl = Me
        '
        'EPLocation
        '
        Me.EPLocation.ContainerControl = Me
        '
        'EPReportingPerson
        '
        Me.EPReportingPerson.ContainerControl = Me
        '
        'EPContactNo
        '
        Me.EPContactNo.ContainerControl = Me
        '
        'EPIncidentDetails
        '
        Me.EPIncidentDetails.ContainerControl = Me
        '
        'frmAddBlotterRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 600)
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.txtIncidentDetails)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtReportingPerson)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtIncidentType)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddBlotterRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddBlotterRecord"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel8.ResumeLayout(False)
        CType(Me.EPIncidentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPReportingPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPContactNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPIncidentDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIncidentType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContactNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents frm As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLocation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtReportingPerson As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtIncidentDetails As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtIncident As DateTimePicker
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dtReported As DateTimePicker
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EPIncidentType As ErrorProvider
    Friend WithEvents EPLocation As ErrorProvider
    Friend WithEvents EPReportingPerson As ErrorProvider
    Friend WithEvents EPContactNo As ErrorProvider
    Friend WithEvents EPIncidentDetails As ErrorProvider
End Class
