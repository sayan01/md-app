<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RegisterAuth
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
        Me.tb_RegisterAuth_Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_RegisterAuth_Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_RegisterAuth_Password = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_RegisterAuth_Heading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_RegisterAuth_Username = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_RegisterAuth_Name = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tb_RegisterAuth_Name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_RegisterAuth_Dept = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tb_RegisterAuth_Dept = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_Register = New Guna.UI2.WinForms.Guna2Button()
        Me.chkbx_RegisterAuth_is_admin = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.lbl_RegisterAuth_is_admin = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'tb_RegisterAuth_Password
        '
        Me.tb_RegisterAuth_Password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_RegisterAuth_Password.AutoSize = True
        Me.tb_RegisterAuth_Password.BorderRadius = 10
        Me.tb_RegisterAuth_Password.BorderThickness = 3
        Me.tb_RegisterAuth_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_RegisterAuth_Password.DefaultText = ""
        Me.tb_RegisterAuth_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_RegisterAuth_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_RegisterAuth_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_RegisterAuth_Password.DisabledState.Parent = Me.tb_RegisterAuth_Password
        Me.tb_RegisterAuth_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_RegisterAuth_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_RegisterAuth_Password.FocusedState.Parent = Me.tb_RegisterAuth_Password
        Me.tb_RegisterAuth_Password.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_RegisterAuth_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_RegisterAuth_Password.HoverState.Parent = Me.tb_RegisterAuth_Password
        Me.tb_RegisterAuth_Password.Location = New System.Drawing.Point(189, 135)
        Me.tb_RegisterAuth_Password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_RegisterAuth_Password.Name = "tb_RegisterAuth_Password"
        Me.tb_RegisterAuth_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9899)
        Me.tb_RegisterAuth_Password.PlaceholderText = "password"
        Me.tb_RegisterAuth_Password.SelectedText = ""
        Me.tb_RegisterAuth_Password.ShadowDecoration.Parent = Me.tb_RegisterAuth_Password
        Me.tb_RegisterAuth_Password.Size = New System.Drawing.Size(298, 45)
        Me.tb_RegisterAuth_Password.TabIndex = 1
        '
        'tb_RegisterAuth_Username
        '
        Me.tb_RegisterAuth_Username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_RegisterAuth_Username.AutoSize = True
        Me.tb_RegisterAuth_Username.BorderRadius = 10
        Me.tb_RegisterAuth_Username.BorderThickness = 3
        Me.tb_RegisterAuth_Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_RegisterAuth_Username.DefaultText = ""
        Me.tb_RegisterAuth_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_RegisterAuth_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_RegisterAuth_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_RegisterAuth_Username.DisabledState.Parent = Me.tb_RegisterAuth_Username
        Me.tb_RegisterAuth_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_RegisterAuth_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_RegisterAuth_Username.FocusedState.Parent = Me.tb_RegisterAuth_Username
        Me.tb_RegisterAuth_Username.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_RegisterAuth_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_RegisterAuth_Username.HoverState.Parent = Me.tb_RegisterAuth_Username
        Me.tb_RegisterAuth_Username.Location = New System.Drawing.Point(189, 67)
        Me.tb_RegisterAuth_Username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_RegisterAuth_Username.Name = "tb_RegisterAuth_Username"
        Me.tb_RegisterAuth_Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_RegisterAuth_Username.PlaceholderText = "username"
        Me.tb_RegisterAuth_Username.SelectedText = ""
        Me.tb_RegisterAuth_Username.ShadowDecoration.Parent = Me.tb_RegisterAuth_Username
        Me.tb_RegisterAuth_Username.Size = New System.Drawing.Size(295, 45)
        Me.tb_RegisterAuth_Username.TabIndex = 0
        '
        'lbl_RegisterAuth_Password
        '
        Me.lbl_RegisterAuth_Password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_RegisterAuth_Password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RegisterAuth_Password.Enabled = False
        Me.lbl_RegisterAuth_Password.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegisterAuth_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_RegisterAuth_Password.Location = New System.Drawing.Point(65, 144)
        Me.lbl_RegisterAuth_Password.Name = "lbl_RegisterAuth_Password"
        Me.lbl_RegisterAuth_Password.Size = New System.Drawing.Size(95, 27)
        Me.lbl_RegisterAuth_Password.TabIndex = 5
        Me.lbl_RegisterAuth_Password.TabStop = False
        Me.lbl_RegisterAuth_Password.Text = "Password:<span style=""color:red"">*</span>"
        '
        'lbl_RegisterAuth_Heading
        '
        Me.lbl_RegisterAuth_Heading.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_RegisterAuth_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RegisterAuth_Heading.Enabled = False
        Me.lbl_RegisterAuth_Heading.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegisterAuth_Heading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_RegisterAuth_Heading.Location = New System.Drawing.Point(202, 12)
        Me.lbl_RegisterAuth_Heading.Name = "lbl_RegisterAuth_Heading"
        Me.lbl_RegisterAuth_Heading.Size = New System.Drawing.Size(119, 47)
        Me.lbl_RegisterAuth_Heading.TabIndex = 3
        Me.lbl_RegisterAuth_Heading.TabStop = False
        Me.lbl_RegisterAuth_Heading.Text = "Register"
        '
        'lbl_RegisterAuth_Username
        '
        Me.lbl_RegisterAuth_Username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_RegisterAuth_Username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RegisterAuth_Username.Enabled = False
        Me.lbl_RegisterAuth_Username.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegisterAuth_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_RegisterAuth_Username.Location = New System.Drawing.Point(60, 75)
        Me.lbl_RegisterAuth_Username.Name = "lbl_RegisterAuth_Username"
        Me.lbl_RegisterAuth_Username.Size = New System.Drawing.Size(100, 27)
        Me.lbl_RegisterAuth_Username.TabIndex = 4
        Me.lbl_RegisterAuth_Username.TabStop = False
        Me.lbl_RegisterAuth_Username.Text = "Username:<span style=""color:red"">*</span>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_RegisterAuth_Name
        '
        Me.lbl_RegisterAuth_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_RegisterAuth_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RegisterAuth_Name.Enabled = False
        Me.lbl_RegisterAuth_Name.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegisterAuth_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_RegisterAuth_Name.Location = New System.Drawing.Point(87, 210)
        Me.lbl_RegisterAuth_Name.Name = "lbl_RegisterAuth_Name"
        Me.lbl_RegisterAuth_Name.Size = New System.Drawing.Size(70, 27)
        Me.lbl_RegisterAuth_Name.TabIndex = 6
        Me.lbl_RegisterAuth_Name.TabStop = False
        Me.lbl_RegisterAuth_Name.Text = "Name: <span style=""color:red"">*</span>"
        '
        'tb_RegisterAuth_Name
        '
        Me.tb_RegisterAuth_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_RegisterAuth_Name.AutoSize = True
        Me.tb_RegisterAuth_Name.BorderRadius = 10
        Me.tb_RegisterAuth_Name.BorderThickness = 3
        Me.tb_RegisterAuth_Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_RegisterAuth_Name.DefaultText = ""
        Me.tb_RegisterAuth_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_RegisterAuth_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_RegisterAuth_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_RegisterAuth_Name.DisabledState.Parent = Me.tb_RegisterAuth_Name
        Me.tb_RegisterAuth_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_RegisterAuth_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_RegisterAuth_Name.FocusedState.Parent = Me.tb_RegisterAuth_Name
        Me.tb_RegisterAuth_Name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_RegisterAuth_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_RegisterAuth_Name.HoverState.Parent = Me.tb_RegisterAuth_Name
        Me.tb_RegisterAuth_Name.Location = New System.Drawing.Point(189, 202)
        Me.tb_RegisterAuth_Name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_RegisterAuth_Name.Name = "tb_RegisterAuth_Name"
        Me.tb_RegisterAuth_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_RegisterAuth_Name.PlaceholderText = "name"
        Me.tb_RegisterAuth_Name.SelectedText = ""
        Me.tb_RegisterAuth_Name.ShadowDecoration.Parent = Me.tb_RegisterAuth_Name
        Me.tb_RegisterAuth_Name.Size = New System.Drawing.Size(295, 45)
        Me.tb_RegisterAuth_Name.TabIndex = 2
        '
        'lbl_RegisterAuth_Dept
        '
        Me.lbl_RegisterAuth_Dept.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_RegisterAuth_Dept.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RegisterAuth_Dept.Enabled = False
        Me.lbl_RegisterAuth_Dept.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegisterAuth_Dept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_RegisterAuth_Dept.Location = New System.Drawing.Point(50, 280)
        Me.lbl_RegisterAuth_Dept.Name = "lbl_RegisterAuth_Dept"
        Me.lbl_RegisterAuth_Dept.Size = New System.Drawing.Size(107, 27)
        Me.lbl_RegisterAuth_Dept.TabIndex = 7
        Me.lbl_RegisterAuth_Dept.TabStop = False
        Me.lbl_RegisterAuth_Dept.Text = "Department:"
        '
        'tb_RegisterAuth_Dept
        '
        Me.tb_RegisterAuth_Dept.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_RegisterAuth_Dept.AutoSize = True
        Me.tb_RegisterAuth_Dept.BorderRadius = 10
        Me.tb_RegisterAuth_Dept.BorderThickness = 3
        Me.tb_RegisterAuth_Dept.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_RegisterAuth_Dept.DefaultText = ""
        Me.tb_RegisterAuth_Dept.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_RegisterAuth_Dept.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_RegisterAuth_Dept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_RegisterAuth_Dept.DisabledState.Parent = Me.tb_RegisterAuth_Dept
        Me.tb_RegisterAuth_Dept.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_RegisterAuth_Dept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_RegisterAuth_Dept.FocusedState.Parent = Me.tb_RegisterAuth_Dept
        Me.tb_RegisterAuth_Dept.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_RegisterAuth_Dept.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_RegisterAuth_Dept.HoverState.Parent = Me.tb_RegisterAuth_Dept
        Me.tb_RegisterAuth_Dept.Location = New System.Drawing.Point(189, 271)
        Me.tb_RegisterAuth_Dept.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_RegisterAuth_Dept.Name = "tb_RegisterAuth_Dept"
        Me.tb_RegisterAuth_Dept.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_RegisterAuth_Dept.PlaceholderText = "department"
        Me.tb_RegisterAuth_Dept.SelectedText = ""
        Me.tb_RegisterAuth_Dept.ShadowDecoration.Parent = Me.tb_RegisterAuth_Dept
        Me.tb_RegisterAuth_Dept.Size = New System.Drawing.Size(295, 45)
        Me.tb_RegisterAuth_Dept.TabIndex = 3
        '
        'btn_Register
        '
        Me.btn_Register.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Register.BorderRadius = 20
        Me.btn_Register.CheckedState.Parent = Me.btn_Register
        Me.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Register.CustomImages.Parent = Me.btn_Register
        Me.btn_Register.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Register.ForeColor = System.Drawing.Color.White
        Me.btn_Register.HoverState.Parent = Me.btn_Register
        Me.btn_Register.Location = New System.Drawing.Point(170, 398)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.ShadowDecoration.Parent = Me.btn_Register
        Me.btn_Register.Size = New System.Drawing.Size(180, 45)
        Me.btn_Register.TabIndex = 8
        Me.btn_Register.Text = "Register"
        '
        'chkbx_RegisterAuth_is_admin
        '
        Me.chkbx_RegisterAuth_is_admin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkbx_RegisterAuth_is_admin.AutoSize = True
        Me.chkbx_RegisterAuth_is_admin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkbx_RegisterAuth_is_admin.CheckedState.BorderRadius = 2
        Me.chkbx_RegisterAuth_is_admin.CheckedState.BorderThickness = 0
        Me.chkbx_RegisterAuth_is_admin.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkbx_RegisterAuth_is_admin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbx_RegisterAuth_is_admin.Location = New System.Drawing.Point(189, 337)
        Me.chkbx_RegisterAuth_is_admin.Name = "chkbx_RegisterAuth_is_admin"
        Me.chkbx_RegisterAuth_is_admin.Size = New System.Drawing.Size(91, 29)
        Me.chkbx_RegisterAuth_is_admin.TabIndex = 4
        Me.chkbx_RegisterAuth_is_admin.Text = " Admin"
        Me.chkbx_RegisterAuth_is_admin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkbx_RegisterAuth_is_admin.UncheckedState.BorderRadius = 2
        Me.chkbx_RegisterAuth_is_admin.UncheckedState.BorderThickness = 0
        Me.chkbx_RegisterAuth_is_admin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkbx_RegisterAuth_is_admin.UseVisualStyleBackColor = True
        '
        'lbl_RegisterAuth_is_admin
        '
        Me.lbl_RegisterAuth_is_admin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_RegisterAuth_is_admin.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RegisterAuth_is_admin.Enabled = False
        Me.lbl_RegisterAuth_is_admin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegisterAuth_is_admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_RegisterAuth_is_admin.Location = New System.Drawing.Point(42, 339)
        Me.lbl_RegisterAuth_is_admin.Name = "lbl_RegisterAuth_is_admin"
        Me.lbl_RegisterAuth_is_admin.Size = New System.Drawing.Size(118, 27)
        Me.lbl_RegisterAuth_is_admin.TabIndex = 7
        Me.lbl_RegisterAuth_is_admin.TabStop = False
        Me.lbl_RegisterAuth_is_admin.Text = "Admin User?<span style=""color:red"">*</span>"
        '
        'frm_RegisterAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(536, 472)
        Me.Controls.Add(Me.chkbx_RegisterAuth_is_admin)
        Me.Controls.Add(Me.btn_Register)
        Me.Controls.Add(Me.tb_RegisterAuth_Dept)
        Me.Controls.Add(Me.tb_RegisterAuth_Name)
        Me.Controls.Add(Me.lbl_RegisterAuth_is_admin)
        Me.Controls.Add(Me.lbl_RegisterAuth_Dept)
        Me.Controls.Add(Me.tb_RegisterAuth_Password)
        Me.Controls.Add(Me.lbl_RegisterAuth_Name)
        Me.Controls.Add(Me.tb_RegisterAuth_Username)
        Me.Controls.Add(Me.lbl_RegisterAuth_Password)
        Me.Controls.Add(Me.lbl_RegisterAuth_Heading)
        Me.Controls.Add(Me.lbl_RegisterAuth_Username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_RegisterAuth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_RegisterAuth_Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_RegisterAuth_Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_RegisterAuth_Password As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_RegisterAuth_Heading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_RegisterAuth_Username As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_RegisterAuth_Name As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tb_RegisterAuth_Name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_RegisterAuth_Dept As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tb_RegisterAuth_Dept As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_Register As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents chkbx_RegisterAuth_is_admin As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lbl_RegisterAuth_is_admin As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
