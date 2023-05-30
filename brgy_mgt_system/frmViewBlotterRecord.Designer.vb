<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewBlotterRecord
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
        Me.frm = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblReportingPerson = New System.Windows.Forms.Label()
        Me.lblDTIncident = New System.Windows.Forms.Label()
        Me.lblDTReported = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIncidentType = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.txtIncidentDetails = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm
        '
        Me.frm.TargetControl = Me
        '
        'lblReportingPerson
        '
        Me.lblReportingPerson.AutoSize = True
        Me.lblReportingPerson.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblReportingPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblReportingPerson.Location = New System.Drawing.Point(319, 215)
        Me.lblReportingPerson.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReportingPerson.Name = "lblReportingPerson"
        Me.lblReportingPerson.Size = New System.Drawing.Size(67, 22)
        Me.lblReportingPerson.TabIndex = 103
        Me.lblReportingPerson.Text = "Dummy"
        '
        'lblDTIncident
        '
        Me.lblDTIncident.AutoSize = True
        Me.lblDTIncident.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDTIncident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblDTIncident.Location = New System.Drawing.Point(31, 315)
        Me.lblDTIncident.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDTIncident.Name = "lblDTIncident"
        Me.lblDTIncident.Size = New System.Drawing.Size(67, 22)
        Me.lblDTIncident.TabIndex = 102
        Me.lblDTIncident.Text = "Dummy"
        '
        'lblDTReported
        '
        Me.lblDTReported.AutoSize = True
        Me.lblDTReported.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDTReported.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblDTReported.Location = New System.Drawing.Point(31, 215)
        Me.lblDTReported.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDTReported.Name = "lblDTReported"
        Me.lblDTReported.Size = New System.Drawing.Size(67, 22)
        Me.lblDTReported.TabIndex = 98
        Me.lblDTReported.Text = "Dummy"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(31, 196)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 19)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Date && Time Reported"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(319, 196)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 19)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Reporting Person"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(31, 296)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 19)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Date && Time Incident"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblLocation.Location = New System.Drawing.Point(319, 127)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(67, 22)
        Me.lblLocation.TabIndex = 85
        Me.lblLocation.Text = "Dummy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(319, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Location"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(448, 7)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.MidnightBlue
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(49, 38)
        Me.Guna2ControlBox1.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(31, 45)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Details"
        '
        'lblIncidentType
        '
        Me.lblIncidentType.AutoSize = True
        Me.lblIncidentType.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblIncidentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblIncidentType.Location = New System.Drawing.Point(31, 127)
        Me.lblIncidentType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIncidentType.Name = "lblIncidentType"
        Me.lblIncidentType.Size = New System.Drawing.Size(67, 22)
        Me.lblIncidentType.TabIndex = 82
        Me.lblIncidentType.Text = "Dummy"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.lblHeader)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(507, 79)
        Me.Guna2Panel1.TabIndex = 83
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Nunito", 19.22!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(30, 17)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(149, 28)
        Me.lblHeader.TabIndex = 53
        Me.lblHeader.Text = "Blotter Record"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Incident Type"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(319, 296)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 19)
        Me.label1.TabIndex = 91
        Me.label1.Text = "Contact No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nunito", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(31, 387)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 19)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Incident Details"
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblContactNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.lblContactNo.Location = New System.Drawing.Point(319, 315)
        Me.lblContactNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(67, 22)
        Me.lblContactNo.TabIndex = 105
        Me.lblContactNo.Text = "Dummy"
        '
        'txtIncidentDetails
        '
        Me.txtIncidentDetails.BorderColor = System.Drawing.Color.Red
        Me.txtIncidentDetails.BorderRadius = 5
        Me.txtIncidentDetails.BorderThickness = 0
        Me.txtIncidentDetails.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIncidentDetails.DefaultText = "sdfssfs"
        Me.txtIncidentDetails.DisabledState.BorderColor = System.Drawing.Color.Red
        Me.txtIncidentDetails.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtIncidentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtIncidentDetails.DisabledState.Parent = Me.txtIncidentDetails
        Me.txtIncidentDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtIncidentDetails.Enabled = False
        Me.txtIncidentDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIncidentDetails.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtIncidentDetails.FocusedState.Parent = Me.txtIncidentDetails
        Me.txtIncidentDetails.Font = New System.Drawing.Font("Nunito SemiBold", 15.19!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtIncidentDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtIncidentDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIncidentDetails.HoverState.Parent = Me.txtIncidentDetails
        Me.txtIncidentDetails.Location = New System.Drawing.Point(21, 409)
        Me.txtIncidentDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIncidentDetails.Multiline = True
        Me.txtIncidentDetails.Name = "txtIncidentDetails"
        Me.txtIncidentDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIncidentDetails.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtIncidentDetails.PlaceholderText = ""
        Me.txtIncidentDetails.SelectedText = ""
        Me.txtIncidentDetails.SelectionStart = 7
        Me.txtIncidentDetails.ShadowDecoration.Parent = Me.txtIncidentDetails
        Me.txtIncidentDetails.Size = New System.Drawing.Size(423, 177)
        Me.txtIncidentDetails.TabIndex = 156
        '
        'frmViewBlotterRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 621)
        Me.Controls.Add(Me.txtIncidentDetails)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblReportingPerson)
        Me.Controls.Add(Me.lblDTIncident)
        Me.Controls.Add(Me.lblDTReported)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblIncidentType)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmViewBlotterRecord"
        Me.Text = "Dummy"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents frm As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblReportingPerson As Label
    Friend WithEvents lblDTIncident As Label
    Friend WithEvents lblDTReported As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblIncidentType As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblContactNo As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents txtIncidentDetails As Guna.UI2.WinForms.Guna2TextBox
End Class
