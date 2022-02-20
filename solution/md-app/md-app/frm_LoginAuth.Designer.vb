<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LoginAuth
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
        Me.lbl_LoginAuth_Username = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_LoginAuth_Password = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tb_LoginAuth_Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_LoginAuth_Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_LoginAuth_Heading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_Login = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lbl_LoginAuth_Username
        '
        Me.lbl_LoginAuth_Username.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_LoginAuth_Username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LoginAuth_Username.Enabled = False
        Me.lbl_LoginAuth_Username.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LoginAuth_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_LoginAuth_Username.Location = New System.Drawing.Point(112, 115)
        Me.lbl_LoginAuth_Username.Name = "lbl_LoginAuth_Username"
        Me.lbl_LoginAuth_Username.Size = New System.Drawing.Size(92, 27)
        Me.lbl_LoginAuth_Username.TabIndex = 0
        Me.lbl_LoginAuth_Username.Text = "Username:"
        '
        'lbl_LoginAuth_Password
        '
        Me.lbl_LoginAuth_Password.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_LoginAuth_Password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LoginAuth_Password.Enabled = False
        Me.lbl_LoginAuth_Password.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LoginAuth_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_LoginAuth_Password.Location = New System.Drawing.Point(112, 220)
        Me.lbl_LoginAuth_Password.Name = "lbl_LoginAuth_Password"
        Me.lbl_LoginAuth_Password.Size = New System.Drawing.Size(87, 27)
        Me.lbl_LoginAuth_Password.TabIndex = 0
        Me.lbl_LoginAuth_Password.Text = "Password:"
        '
        'tb_LoginAuth_Username
        '
        Me.tb_LoginAuth_Username.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_LoginAuth_Username.AutoSize = True
        Me.tb_LoginAuth_Username.BorderRadius = 10
        Me.tb_LoginAuth_Username.BorderThickness = 3
        Me.tb_LoginAuth_Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_LoginAuth_Username.DefaultText = ""
        Me.tb_LoginAuth_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_LoginAuth_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_LoginAuth_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_LoginAuth_Username.DisabledState.Parent = Me.tb_LoginAuth_Username
        Me.tb_LoginAuth_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_LoginAuth_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_LoginAuth_Username.FocusedState.Parent = Me.tb_LoginAuth_Username
        Me.tb_LoginAuth_Username.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_LoginAuth_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_LoginAuth_Username.HoverState.Parent = Me.tb_LoginAuth_Username
        Me.tb_LoginAuth_Username.Location = New System.Drawing.Point(112, 145)
        Me.tb_LoginAuth_Username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_LoginAuth_Username.Name = "tb_LoginAuth_Username"
        Me.tb_LoginAuth_Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_LoginAuth_Username.PlaceholderText = "username"
        Me.tb_LoginAuth_Username.SelectedText = ""
        Me.tb_LoginAuth_Username.ShadowDecoration.Parent = Me.tb_LoginAuth_Username
        Me.tb_LoginAuth_Username.Size = New System.Drawing.Size(295, 38)
        Me.tb_LoginAuth_Username.TabIndex = 1
        '
        'tb_LoginAuth_Password
        '
        Me.tb_LoginAuth_Password.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_LoginAuth_Password.AutoSize = True
        Me.tb_LoginAuth_Password.BorderRadius = 10
        Me.tb_LoginAuth_Password.BorderThickness = 3
        Me.tb_LoginAuth_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_LoginAuth_Password.DefaultText = ""
        Me.tb_LoginAuth_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_LoginAuth_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_LoginAuth_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_LoginAuth_Password.DisabledState.Parent = Me.tb_LoginAuth_Password
        Me.tb_LoginAuth_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_LoginAuth_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_LoginAuth_Password.FocusedState.Parent = Me.tb_LoginAuth_Password
        Me.tb_LoginAuth_Password.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_LoginAuth_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_LoginAuth_Password.HoverState.Parent = Me.tb_LoginAuth_Password
        Me.tb_LoginAuth_Password.Location = New System.Drawing.Point(112, 250)
        Me.tb_LoginAuth_Password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_LoginAuth_Password.Name = "tb_LoginAuth_Password"
        Me.tb_LoginAuth_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9899)
        Me.tb_LoginAuth_Password.PlaceholderText = "password"
        Me.tb_LoginAuth_Password.SelectedText = ""
        Me.tb_LoginAuth_Password.ShadowDecoration.Parent = Me.tb_LoginAuth_Password
        Me.tb_LoginAuth_Password.Size = New System.Drawing.Size(295, 38)
        Me.tb_LoginAuth_Password.TabIndex = 1
        '
        'lbl_LoginAuth_Heading
        '
        Me.lbl_LoginAuth_Heading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_LoginAuth_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LoginAuth_Heading.Enabled = False
        Me.lbl_LoginAuth_Heading.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LoginAuth_Heading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_LoginAuth_Heading.Location = New System.Drawing.Point(219, 25)
        Me.lbl_LoginAuth_Heading.Name = "lbl_LoginAuth_Heading"
        Me.lbl_LoginAuth_Heading.Size = New System.Drawing.Size(82, 47)
        Me.lbl_LoginAuth_Heading.TabIndex = 0
        Me.lbl_LoginAuth_Heading.Text = "Login"
        '
        'btn_Login
        '
        Me.btn_Login.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Login.BorderRadius = 20
        Me.btn_Login.CheckedState.Parent = Me.btn_Login
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Login.CustomImages.Parent = Me.btn_Login
        Me.btn_Login.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.ForeColor = System.Drawing.Color.White
        Me.btn_Login.HoverState.Parent = Me.btn_Login
        Me.btn_Login.Location = New System.Drawing.Point(155, 347)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.ShadowDecoration.Parent = Me.btn_Login
        Me.btn_Login.Size = New System.Drawing.Size(180, 45)
        Me.btn_Login.TabIndex = 9
        Me.btn_Login.Text = "Login"
        '
        'frm_LoginAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(536, 445)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.tb_LoginAuth_Password)
        Me.Controls.Add(Me.tb_LoginAuth_Username)
        Me.Controls.Add(Me.lbl_LoginAuth_Password)
        Me.Controls.Add(Me.lbl_LoginAuth_Heading)
        Me.Controls.Add(Me.lbl_LoginAuth_Username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_LoginAuth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_LoginAuth_Username As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_LoginAuth_Password As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tb_LoginAuth_Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_LoginAuth_Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_LoginAuth_Heading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_Login As Guna.UI2.WinForms.Guna2Button
End Class
