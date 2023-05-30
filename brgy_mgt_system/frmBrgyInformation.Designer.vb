<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrgyInformation
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlSettings = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnChangeLogo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmailAdd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProvince = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBarangay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlCard = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator5 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEmailAdd = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBarangay = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.picDisplayedLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnlSettings.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.picDisplayedLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.White
        Me.pnlSettings.BorderRadius = 5
        Me.pnlSettings.Controls.Add(Me.Label2)
        Me.pnlSettings.Controls.Add(Me.picLogo)
        Me.pnlSettings.Controls.Add(Me.btnChangeLogo)
        Me.pnlSettings.Controls.Add(Me.btnSave)
        Me.pnlSettings.Controls.Add(Me.txtEmailAdd)
        Me.pnlSettings.Controls.Add(Me.Label14)
        Me.pnlSettings.Controls.Add(Me.txtPhoneNo)
        Me.pnlSettings.Controls.Add(Me.Label13)
        Me.pnlSettings.Controls.Add(Me.txtProvince)
        Me.pnlSettings.Controls.Add(Me.Label12)
        Me.pnlSettings.Controls.Add(Me.txtCity)
        Me.pnlSettings.Controls.Add(Me.Label11)
        Me.pnlSettings.Controls.Add(Me.txtBarangay)
        Me.pnlSettings.Controls.Add(Me.Label16)
        Me.pnlSettings.Controls.Add(Me.btnEdit)
        Me.pnlSettings.Controls.Add(Me.Guna2Panel2)
        Me.pnlSettings.Controls.Add(Me.btnCancel)
        Me.pnlSettings.Location = New System.Drawing.Point(362, 14)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.ShadowDecoration.Parent = Me.pnlSettings
        Me.pnlSettings.Size = New System.Drawing.Size(656, 562)
        Me.pnlSettings.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 404)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Logo"
        '
        'picLogo
        '
        Me.picLogo.Image = Global.brgy_mgt_system.My.Resources.Resources.logo_removebg_preview
        Me.picLogo.Location = New System.Drawing.Point(27, 430)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.ShadowDecoration.Parent = Me.picLogo
        Me.picLogo.Size = New System.Drawing.Size(71, 63)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'btnChangeLogo
        '
        Me.btnChangeLogo.BorderColor = System.Drawing.Color.LightGray
        Me.btnChangeLogo.BorderRadius = 5
        Me.btnChangeLogo.BorderThickness = 1
        Me.btnChangeLogo.CheckedState.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnChangeLogo.CheckedState.Parent = Me.btnChangeLogo
        Me.btnChangeLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeLogo.CustomImages.Parent = Me.btnChangeLogo
        Me.btnChangeLogo.Enabled = False
        Me.btnChangeLogo.FillColor = System.Drawing.Color.Transparent
        Me.btnChangeLogo.Font = New System.Drawing.Font("Nunito", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnChangeLogo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnChangeLogo.HoverState.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnChangeLogo.HoverState.Parent = Me.btnChangeLogo
        Me.btnChangeLogo.Location = New System.Drawing.Point(162, 445)
        Me.btnChangeLogo.Name = "btnChangeLogo"
        Me.btnChangeLogo.ShadowDecoration.Parent = Me.btnChangeLogo
        Me.btnChangeLogo.Size = New System.Drawing.Size(81, 33)
        Me.btnChangeLogo.TabIndex = 0
        Me.btnChangeLogo.Text = "Change"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 5
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Nunito", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(401, 509)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(83, 36)
        Me.btnSave.TabIndex = 79
        Me.btnSave.Text = "Save"
        Me.btnSave.Visible = False
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.BorderRadius = 5
        Me.txtEmailAdd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailAdd.DefaultText = ""
        Me.txtEmailAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtEmailAdd.DisabledState.Parent = Me.txtEmailAdd
        Me.txtEmailAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAdd.Enabled = False
        Me.txtEmailAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAdd.FocusedState.Parent = Me.txtEmailAdd
        Me.txtEmailAdd.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEmailAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAdd.HoverState.Parent = Me.txtEmailAdd
        Me.txtEmailAdd.Location = New System.Drawing.Point(162, 338)
        Me.txtEmailAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailAdd.PlaceholderText = ""
        Me.txtEmailAdd.SelectedText = ""
        Me.txtEmailAdd.ShadowDecoration.Parent = Me.txtEmailAdd
        Me.txtEmailAdd.Size = New System.Drawing.Size(429, 36)
        Me.txtEmailAdd.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(32, 346)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 20)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Email address"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.BorderRadius = 5
        Me.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNo.DefaultText = ""
        Me.txtPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtPhoneNo.DisabledState.Parent = Me.txtPhoneNo
        Me.txtPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNo.Enabled = False
        Me.txtPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNo.FocusedState.Parent = Me.txtPhoneNo
        Me.txtPhoneNo.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNo.HoverState.Parent = Me.txtPhoneNo
        Me.txtPhoneNo.Location = New System.Drawing.Point(162, 277)
        Me.txtPhoneNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNo.PlaceholderText = ""
        Me.txtPhoneNo.SelectedText = ""
        Me.txtPhoneNo.ShadowDecoration.Parent = Me.txtPhoneNo
        Me.txtPhoneNo.Size = New System.Drawing.Size(429, 36)
        Me.txtPhoneNo.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(32, 285)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Phone no."
        '
        'txtProvince
        '
        Me.txtProvince.BorderRadius = 5
        Me.txtProvince.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProvince.DefaultText = ""
        Me.txtProvince.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProvince.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProvince.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtProvince.DisabledState.Parent = Me.txtProvince
        Me.txtProvince.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProvince.Enabled = False
        Me.txtProvince.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProvince.FocusedState.Parent = Me.txtProvince
        Me.txtProvince.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtProvince.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProvince.HoverState.Parent = Me.txtProvince
        Me.txtProvince.Location = New System.Drawing.Point(162, 216)
        Me.txtProvince.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProvince.PlaceholderText = ""
        Me.txtProvince.SelectedText = ""
        Me.txtProvince.ShadowDecoration.Parent = Me.txtProvince
        Me.txtProvince.Size = New System.Drawing.Size(429, 36)
        Me.txtProvince.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(32, 224)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 20)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Province"
        '
        'txtCity
        '
        Me.txtCity.BorderRadius = 5
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.DefaultText = ""
        Me.txtCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtCity.DisabledState.Parent = Me.txtCity
        Me.txtCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCity.Enabled = False
        Me.txtCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCity.FocusedState.Parent = Me.txtCity
        Me.txtCity.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCity.HoverState.Parent = Me.txtCity
        Me.txtCity.Location = New System.Drawing.Point(162, 155)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCity.PlaceholderText = ""
        Me.txtCity.SelectedText = ""
        Me.txtCity.ShadowDecoration.Parent = Me.txtCity
        Me.txtCity.Size = New System.Drawing.Size(429, 36)
        Me.txtCity.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(32, 163)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 20)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "City"
        '
        'txtBarangay
        '
        Me.txtBarangay.BorderRadius = 5
        Me.txtBarangay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBarangay.DefaultText = ""
        Me.txtBarangay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBarangay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBarangay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtBarangay.DisabledState.Parent = Me.txtBarangay
        Me.txtBarangay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBarangay.Enabled = False
        Me.txtBarangay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBarangay.FocusedState.Parent = Me.txtBarangay
        Me.txtBarangay.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBarangay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBarangay.HoverState.Parent = Me.txtBarangay
        Me.txtBarangay.Location = New System.Drawing.Point(162, 94)
        Me.txtBarangay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBarangay.PlaceholderText = ""
        Me.txtBarangay.SelectedText = ""
        Me.txtBarangay.ShadowDecoration.Parent = Me.txtBarangay
        Me.txtBarangay.Size = New System.Drawing.Size(429, 36)
        Me.txtBarangay.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(32, 102)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 20)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Barangay"
        '
        'btnEdit
        '
        Me.btnEdit.BorderRadius = 5
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Nunito", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(510, 509)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(83, 36)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(656, 53)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Nunito", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(36, 10)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(106, 33)
        Me.Guna2Button2.TabIndex = 3
        Me.Guna2Button2.Text = "Settings"
        Me.Guna2Button2.UseTransparentBackground = True
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Nunito", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(510, 509)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(83, 36)
        Me.btnCancel.TabIndex = 81
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Visible = False
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.BorderRadius = 5
        Me.pnlCard.Controls.Add(Me.Guna2Separator6)
        Me.pnlCard.Controls.Add(Me.Guna2Separator5)
        Me.pnlCard.Controls.Add(Me.Guna2Separator4)
        Me.pnlCard.Controls.Add(Me.Guna2Separator3)
        Me.pnlCard.Controls.Add(Me.lblPhoneNo)
        Me.pnlCard.Controls.Add(Me.Label10)
        Me.pnlCard.Controls.Add(Me.lblEmailAdd)
        Me.pnlCard.Controls.Add(Me.Label8)
        Me.pnlCard.Controls.Add(Me.lblCity)
        Me.pnlCard.Controls.Add(Me.Label6)
        Me.pnlCard.Controls.Add(Me.lblProvince)
        Me.pnlCard.Controls.Add(Me.Label4)
        Me.pnlCard.Controls.Add(Me.lblBarangay)
        Me.pnlCard.Controls.Add(Me.Label3)
        Me.pnlCard.Controls.Add(Me.Guna2Panel1)
        Me.pnlCard.CustomBorderColor = System.Drawing.Color.Navy
        Me.pnlCard.CustomBorderThickness = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.pnlCard.Location = New System.Drawing.Point(12, 14)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.ShadowDecoration.Parent = Me.pnlCard
        Me.pnlCard.Size = New System.Drawing.Size(329, 618)
        Me.pnlCard.TabIndex = 3
        '
        'Guna2Separator6
        '
        Me.Guna2Separator6.Location = New System.Drawing.Point(18, 522)
        Me.Guna2Separator6.Name = "Guna2Separator6"
        Me.Guna2Separator6.Size = New System.Drawing.Size(293, 10)
        Me.Guna2Separator6.TabIndex = 67
        '
        'Guna2Separator5
        '
        Me.Guna2Separator5.Location = New System.Drawing.Point(18, 447)
        Me.Guna2Separator5.Name = "Guna2Separator5"
        Me.Guna2Separator5.Size = New System.Drawing.Size(293, 10)
        Me.Guna2Separator5.TabIndex = 66
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.Location = New System.Drawing.Point(18, 369)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(293, 10)
        Me.Guna2Separator4.TabIndex = 65
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.Location = New System.Drawing.Point(16, 300)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(293, 10)
        Me.Guna2Separator3.TabIndex = 2
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPhoneNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblPhoneNo.Location = New System.Drawing.Point(17, 490)
        Me.lblPhoneNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(90, 22)
        Me.lblPhoneNo.TabIndex = 64
        Me.lblPhoneNo.Text = "09999999"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(17, 469)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 19)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Phone no."
        '
        'lblEmailAdd
        '
        Me.lblEmailAdd.AutoSize = True
        Me.lblEmailAdd.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblEmailAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblEmailAdd.Location = New System.Drawing.Point(17, 564)
        Me.lblEmailAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailAdd.Name = "lblEmailAdd"
        Me.lblEmailAdd.Size = New System.Drawing.Size(39, 22)
        Me.lblEmailAdd.TabIndex = 62
        Me.lblEmailAdd.Text = "test"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(17, 543)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Email"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblCity.Location = New System.Drawing.Point(17, 336)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(39, 22)
        Me.lblCity.TabIndex = 60
        Me.lblCity.Text = "test"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 315)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 19)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "City"
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblProvince.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblProvince.Location = New System.Drawing.Point(17, 412)
        Me.lblProvince.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(39, 22)
        Me.lblProvince.TabIndex = 58
        Me.lblProvince.Text = "test"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 391)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Province"
        '
        'lblBarangay
        '
        Me.lblBarangay.AutoSize = True
        Me.lblBarangay.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBarangay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblBarangay.Location = New System.Drawing.Point(17, 265)
        Me.lblBarangay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBarangay.Name = "lblBarangay"
        Me.lblBarangay.Size = New System.Drawing.Size(39, 22)
        Me.lblBarangay.TabIndex = 56
        Me.lblBarangay.Text = "test"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 244)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Barangay"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.picDisplayedLogo)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(329, 224)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(18, 296)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(293, 10)
        Me.Guna2Separator2.TabIndex = 1
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(16, 216)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(293, 10)
        Me.Guna2Separator1.TabIndex = 0
        '
        'picDisplayedLogo
        '
        Me.picDisplayedLogo.Image = Global.brgy_mgt_system.My.Resources.Resources.logo_removebg_preview
        Me.picDisplayedLogo.Location = New System.Drawing.Point(65, 24)
        Me.picDisplayedLogo.Name = "picDisplayedLogo"
        Me.picDisplayedLogo.ShadowDecoration.Parent = Me.picDisplayedLogo
        Me.picDisplayedLogo.Size = New System.Drawing.Size(199, 176)
        Me.picDisplayedLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDisplayedLogo.TabIndex = 0
        Me.picDisplayedLogo.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me.pnlCard
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.pnlSettings
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmBrgyInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 646)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.pnlSettings)
        Me.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBrgyInformation"
        Me.Text = "frmAbout"
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.picDisplayedLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlSettings As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents picDisplayedLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblEmailAdd As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProvince As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBarangay As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator5 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnChangeLogo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmailAdd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPhoneNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtProvince As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBarangay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents picLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class
