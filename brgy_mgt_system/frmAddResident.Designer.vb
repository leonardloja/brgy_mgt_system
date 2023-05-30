<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddResident
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddResident))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtMiddleName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmailAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPlaceOfBirth = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCitizenship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContactNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtOccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStreet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtHouseNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmbCivilStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbPurok = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtBirthDate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.picResident = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.EPFirstName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPMiddleName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPLastName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPEmailAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPPlaceOfBirth = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPCitizenship = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPContactNo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPOccupation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPHouseNo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPStreet = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPPurok = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EPImage = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.picResident, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPMiddleName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPEmailAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPPlaceOfBirth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPCitizenship, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPContactNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPOccupation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPHouseNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPStreet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPPurok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderRadius = 5
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.Parent = Me.txtFirstName
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.FocusedState.Parent = Me.txtFirstName
        Me.txtFirstName.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.HoverState.Parent = Me.txtFirstName
        Me.txtFirstName.Location = New System.Drawing.Point(49, 187)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.ShadowDecoration.Parent = Me.txtFirstName
        Me.txtFirstName.Size = New System.Drawing.Size(175, 36)
        Me.txtFirstName.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(263, 531)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 19)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Street"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(49, 529)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 19)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "House No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(477, 528)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 19)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Purok"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(456, 439)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 19)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Profession/Occupation"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(506, 344)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 19)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Citizenship"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(49, 439)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 19)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Civil status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(200, 344)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 19)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Place of birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(234, 439)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 19)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Contact No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(369, 251)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Email address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(265, 251)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 19)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(49, 251)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Birth date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(49, 344)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(265, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Middle name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(482, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Last name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(49, 166)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 19)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "First name"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Nunito", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(483, 11)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(36, 34, 36, 34)
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(76, 38)
        Me.btnCancel.TabIndex = 48
        Me.btnCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito", 24.33!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 34)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Add Resident"
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbGender.FocusedState.Parent = Me.cmbGender
        Me.cmbGender.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.HoverState.Parent = Me.cmbGender
        Me.cmbGender.ItemHeight = 30
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.ItemsAppearance.Parent = Me.cmbGender
        Me.cmbGender.Location = New System.Drawing.Point(49, 365)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.ShadowDecoration.Parent = Me.cmbGender
        Me.cmbGender.Size = New System.Drawing.Size(99, 36)
        Me.cmbGender.StartIndex = 0
        Me.cmbGender.TabIndex = 6
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BorderRadius = 5
        Me.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddleName.DefaultText = ""
        Me.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.DisabledState.Parent = Me.txtMiddleName
        Me.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.FocusedState.Parent = Me.txtMiddleName
        Me.txtMiddleName.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.HoverState.Parent = Me.txtMiddleName
        Me.txtMiddleName.Location = New System.Drawing.Point(265, 187)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddleName.PlaceholderText = ""
        Me.txtMiddleName.SelectedText = ""
        Me.txtMiddleName.ShadowDecoration.Parent = Me.txtMiddleName
        Me.txtMiddleName.Size = New System.Drawing.Size(175, 36)
        Me.txtMiddleName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.BorderRadius = 5
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.Parent = Me.txtLastName
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.FocusedState.Parent = Me.txtLastName
        Me.txtLastName.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.HoverState.Parent = Me.txtLastName
        Me.txtLastName.Location = New System.Drawing.Point(481, 187)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.ShadowDecoration.Parent = Me.txtLastName
        Me.txtLastName.Size = New System.Drawing.Size(175, 36)
        Me.txtLastName.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.BorderRadius = 5
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.DefaultText = ""
        Me.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.DisabledState.Parent = Me.txtAge
        Me.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.Enabled = False
        Me.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.FocusedState.Parent = Me.txtAge
        Me.txtAge.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.HoverState.Parent = Me.txtAge
        Me.txtAge.Location = New System.Drawing.Point(265, 274)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.PlaceholderText = ""
        Me.txtAge.SelectedText = ""
        Me.txtAge.ShadowDecoration.Parent = Me.txtAge
        Me.txtAge.Size = New System.Drawing.Size(54, 36)
        Me.txtAge.TabIndex = 4
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BorderRadius = 5
        Me.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailAddress.DefaultText = ""
        Me.txtEmailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAddress.DisabledState.Parent = Me.txtEmailAddress
        Me.txtEmailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAddress.FocusedState.Parent = Me.txtEmailAddress
        Me.txtEmailAddress.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEmailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAddress.HoverState.Parent = Me.txtEmailAddress
        Me.txtEmailAddress.Location = New System.Drawing.Point(369, 274)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailAddress.PlaceholderText = ""
        Me.txtEmailAddress.SelectedText = ""
        Me.txtEmailAddress.ShadowDecoration.Parent = Me.txtEmailAddress
        Me.txtEmailAddress.Size = New System.Drawing.Size(287, 36)
        Me.txtEmailAddress.TabIndex = 5
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.BorderRadius = 5
        Me.txtPlaceOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlaceOfBirth.DefaultText = ""
        Me.txtPlaceOfBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPlaceOfBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPlaceOfBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPlaceOfBirth.DisabledState.Parent = Me.txtPlaceOfBirth
        Me.txtPlaceOfBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPlaceOfBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlaceOfBirth.FocusedState.Parent = Me.txtPlaceOfBirth
        Me.txtPlaceOfBirth.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPlaceOfBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlaceOfBirth.HoverState.Parent = Me.txtPlaceOfBirth
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(200, 365)
        Me.txtPlaceOfBirth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPlaceOfBirth.PlaceholderText = ""
        Me.txtPlaceOfBirth.SelectedText = ""
        Me.txtPlaceOfBirth.ShadowDecoration.Parent = Me.txtPlaceOfBirth
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(254, 36)
        Me.txtPlaceOfBirth.TabIndex = 7
        '
        'txtCitizenship
        '
        Me.txtCitizenship.BorderRadius = 5
        Me.txtCitizenship.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCitizenship.DefaultText = ""
        Me.txtCitizenship.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCitizenship.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCitizenship.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCitizenship.DisabledState.Parent = Me.txtCitizenship
        Me.txtCitizenship.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCitizenship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.FocusedState.Parent = Me.txtCitizenship
        Me.txtCitizenship.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCitizenship.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.HoverState.Parent = Me.txtCitizenship
        Me.txtCitizenship.Location = New System.Drawing.Point(506, 365)
        Me.txtCitizenship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCitizenship.PlaceholderText = ""
        Me.txtCitizenship.SelectedText = ""
        Me.txtCitizenship.ShadowDecoration.Parent = Me.txtCitizenship
        Me.txtCitizenship.Size = New System.Drawing.Size(150, 36)
        Me.txtCitizenship.TabIndex = 8
        '
        'txtContactNo
        '
        Me.txtContactNo.BorderRadius = 5
        Me.txtContactNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNo.DefaultText = ""
        Me.txtContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContactNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNo.DisabledState.Parent = Me.txtContactNo
        Me.txtContactNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNo.FocusedState.Parent = Me.txtContactNo
        Me.txtContactNo.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNo.HoverState.Parent = Me.txtContactNo
        Me.txtContactNo.Location = New System.Drawing.Point(234, 460)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNo.PlaceholderText = ""
        Me.txtContactNo.SelectedText = ""
        Me.txtContactNo.ShadowDecoration.Parent = Me.txtContactNo
        Me.txtContactNo.Size = New System.Drawing.Size(179, 36)
        Me.txtContactNo.TabIndex = 10
        '
        'txtOccupation
        '
        Me.txtOccupation.BorderRadius = 5
        Me.txtOccupation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOccupation.DefaultText = ""
        Me.txtOccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOccupation.DisabledState.Parent = Me.txtOccupation
        Me.txtOccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOccupation.FocusedState.Parent = Me.txtOccupation
        Me.txtOccupation.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtOccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOccupation.HoverState.Parent = Me.txtOccupation
        Me.txtOccupation.Location = New System.Drawing.Point(456, 460)
        Me.txtOccupation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOccupation.PlaceholderText = ""
        Me.txtOccupation.SelectedText = ""
        Me.txtOccupation.ShadowDecoration.Parent = Me.txtOccupation
        Me.txtOccupation.Size = New System.Drawing.Size(200, 36)
        Me.txtOccupation.TabIndex = 11
        '
        'txtStreet
        '
        Me.txtStreet.BorderRadius = 5
        Me.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStreet.DefaultText = ""
        Me.txtStreet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStreet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStreet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreet.DisabledState.Parent = Me.txtStreet
        Me.txtStreet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreet.FocusedState.Parent = Me.txtStreet
        Me.txtStreet.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtStreet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreet.HoverState.Parent = Me.txtStreet
        Me.txtStreet.Location = New System.Drawing.Point(263, 552)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreet.PlaceholderText = ""
        Me.txtStreet.SelectedText = ""
        Me.txtStreet.ShadowDecoration.Parent = Me.txtStreet
        Me.txtStreet.Size = New System.Drawing.Size(175, 36)
        Me.txtStreet.TabIndex = 13
        '
        'txtHouseNo
        '
        Me.txtHouseNo.BorderRadius = 5
        Me.txtHouseNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHouseNo.DefaultText = ""
        Me.txtHouseNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHouseNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHouseNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHouseNo.DisabledState.Parent = Me.txtHouseNo
        Me.txtHouseNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHouseNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHouseNo.FocusedState.Parent = Me.txtHouseNo
        Me.txtHouseNo.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtHouseNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHouseNo.HoverState.Parent = Me.txtHouseNo
        Me.txtHouseNo.Location = New System.Drawing.Point(49, 552)
        Me.txtHouseNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHouseNo.PlaceholderText = ""
        Me.txtHouseNo.SelectedText = ""
        Me.txtHouseNo.ShadowDecoration.Parent = Me.txtHouseNo
        Me.txtHouseNo.Size = New System.Drawing.Size(175, 36)
        Me.txtHouseNo.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmbCivilStatus
        '
        Me.cmbCivilStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbCivilStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCivilStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCivilStatus.FocusedState.Parent = Me.cmbCivilStatus
        Me.cmbCivilStatus.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbCivilStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCivilStatus.FormattingEnabled = True
        Me.cmbCivilStatus.HoverState.Parent = Me.cmbCivilStatus
        Me.cmbCivilStatus.ItemHeight = 30
        Me.cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed"})
        Me.cmbCivilStatus.ItemsAppearance.Parent = Me.cmbCivilStatus
        Me.cmbCivilStatus.Location = New System.Drawing.Point(49, 460)
        Me.cmbCivilStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCivilStatus.Name = "cmbCivilStatus"
        Me.cmbCivilStatus.ShadowDecoration.Parent = Me.cmbCivilStatus
        Me.cmbCivilStatus.Size = New System.Drawing.Size(142, 36)
        Me.cmbCivilStatus.StartIndex = 0
        Me.cmbCivilStatus.TabIndex = 9
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
        Me.btnSave.Location = New System.Drawing.Point(580, 11)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(36, 34, 36, 34)
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(76, 38)
        Me.btnSave.TabIndex = 84
        Me.btnSave.Text = "Save"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.LightSteelBlue
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(712, 81)
        Me.Guna2Panel1.TabIndex = 85
        '
        'cmbPurok
        '
        Me.cmbPurok.BackColor = System.Drawing.Color.Transparent
        Me.cmbPurok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPurok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPurok.FocusedColor = System.Drawing.Color.Empty
        Me.cmbPurok.FocusedState.Parent = Me.cmbPurok
        Me.cmbPurok.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbPurok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPurok.FormattingEnabled = True
        Me.cmbPurok.HoverState.Parent = Me.cmbPurok
        Me.cmbPurok.ItemHeight = 30
        Me.cmbPurok.ItemsAppearance.Parent = Me.cmbPurok
        Me.cmbPurok.Location = New System.Drawing.Point(477, 552)
        Me.cmbPurok.Name = "cmbPurok"
        Me.cmbPurok.ShadowDecoration.Parent = Me.cmbPurok
        Me.cmbPurok.Size = New System.Drawing.Size(179, 36)
        Me.cmbPurok.TabIndex = 14
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.btnCancel)
        Me.Guna2Panel2.Controls.Add(Me.btnSave)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 619)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(712, 60)
        Me.Guna2Panel2.TabIndex = 86
        '
        'dtBirthDate
        '
        Me.dtBirthDate.BackColor = System.Drawing.Color.Transparent
        Me.dtBirthDate.BorderRadius = 1
        Me.dtBirthDate.Color = System.Drawing.Color.Silver
        Me.dtBirthDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dtBirthDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dtBirthDate.DisabledColor = System.Drawing.Color.Gray
        Me.dtBirthDate.DisplayWeekNumbers = False
        Me.dtBirthDate.DPHeight = 0
        Me.dtBirthDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtBirthDate.FillDatePicker = False
        Me.dtBirthDate.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtBirthDate.ForeColor = System.Drawing.Color.Black
        Me.dtBirthDate.Icon = CType(resources.GetObject("dtBirthDate.Icon"), System.Drawing.Image)
        Me.dtBirthDate.IconColor = System.Drawing.Color.Gray
        Me.dtBirthDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dtBirthDate.LeftTextMargin = 5
        Me.dtBirthDate.Location = New System.Drawing.Point(49, 274)
        Me.dtBirthDate.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dtBirthDate.Name = "dtBirthDate"
        Me.dtBirthDate.Size = New System.Drawing.Size(175, 32)
        Me.dtBirthDate.TabIndex = 3
        Me.dtBirthDate.Value = New Date(2022, 9, 24, 20, 7, 0, 0)
        '
        'picResident
        '
        Me.picResident.AutoRoundedCorners = True
        Me.picResident.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picResident.BorderRadius = 53
        Me.picResident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picResident.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picResident.Image = Global.brgy_mgt_system.My.Resources.Resources.add_image_100_dark
        Me.picResident.InitialImage = Global.brgy_mgt_system.My.Resources.Resources.add_image_100_dark
        Me.picResident.Location = New System.Drawing.Point(283, 23)
        Me.picResident.Margin = New System.Windows.Forms.Padding(2)
        Me.picResident.Name = "picResident"
        Me.picResident.ShadowDecoration.Parent = Me.picResident
        Me.picResident.Size = New System.Drawing.Size(147, 109)
        Me.picResident.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picResident.TabIndex = 1
        Me.picResident.TabStop = False
        '
        'EPFirstName
        '
        Me.EPFirstName.ContainerControl = Me
        '
        'EPMiddleName
        '
        Me.EPMiddleName.ContainerControl = Me
        '
        'EPLastName
        '
        Me.EPLastName.ContainerControl = Me
        '
        'EPEmailAddress
        '
        Me.EPEmailAddress.ContainerControl = Me
        '
        'EPPlaceOfBirth
        '
        Me.EPPlaceOfBirth.ContainerControl = Me
        '
        'EPCitizenship
        '
        Me.EPCitizenship.ContainerControl = Me
        '
        'EPContactNo
        '
        Me.EPContactNo.ContainerControl = Me
        '
        'EPOccupation
        '
        Me.EPOccupation.ContainerControl = Me
        '
        'EPHouseNo
        '
        Me.EPHouseNo.ContainerControl = Me
        '
        'EPStreet
        '
        Me.EPStreet.ContainerControl = Me
        '
        'EPPurok
        '
        Me.EPPurok.ContainerControl = Me
        '
        'EPImage
        '
        Me.EPImage.ContainerControl = Me
        '
        'frmAddResident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 679)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.cmbPurok)
        Me.Controls.Add(Me.dtBirthDate)
        Me.Controls.Add(Me.cmbCivilStatus)
        Me.Controls.Add(Me.txtHouseNo)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.txtCitizenship)
        Me.Controls.Add(Me.txtPlaceOfBirth)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.picResident)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddResident"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddResident"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.picResident, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPMiddleName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPEmailAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPPlaceOfBirth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPCitizenship, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPContactNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPOccupation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPHouseNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPStreet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPPurok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents picResident As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtHouseNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStreet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtOccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContactNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCitizenship As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPlaceOfBirth As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmailAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMiddleName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmbCivilStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtBirthDate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbPurok As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents EPFirstName As ErrorProvider
    Friend WithEvents EPMiddleName As ErrorProvider
    Friend WithEvents EPLastName As ErrorProvider
    Friend WithEvents EPEmailAddress As ErrorProvider
    Friend WithEvents EPPlaceOfBirth As ErrorProvider
    Friend WithEvents EPCitizenship As ErrorProvider
    Friend WithEvents EPContactNo As ErrorProvider
    Friend WithEvents EPOccupation As ErrorProvider
    Friend WithEvents EPHouseNo As ErrorProvider
    Friend WithEvents EPStreet As ErrorProvider
    Friend WithEvents EPPurok As ErrorProvider
    Friend WithEvents EPImage As ErrorProvider
End Class
