<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MainMenu))
        Me.btn_Close = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_TopBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.img_TopBar_Logo = New System.Windows.Forms.PictureBox()
        Me.ctx_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxItem_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_TopBar_Text = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_Auth = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_ToggleAuth = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_ToggleAuthText = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_ToggleAuth = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_TopBar.SuspendLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctx_Main.SuspendLayout()
        Me.pnl_ToggleAuth.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.CheckedState.Parent = Me.btn_Close
        Me.btn_Close.CustomImages.Parent = Me.btn_Close
        Me.btn_Close.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btn_Close.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.ForeColor = System.Drawing.Color.White
        Me.btn_Close.HoverState.Parent = Me.btn_Close
        Me.btn_Close.Location = New System.Drawing.Point(950, -4)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.ShadowDecoration.Parent = Me.btn_Close
        Me.btn_Close.Size = New System.Drawing.Size(50, 54)
        Me.btn_Close.TabIndex = 0
        Me.btn_Close.TabStop = False
        Me.btn_Close.Text = "×"
        '
        'pnl_TopBar
        '
        Me.pnl_TopBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_TopBar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pnl_TopBar.Controls.Add(Me.img_TopBar_Logo)
        Me.pnl_TopBar.Controls.Add(Me.lbl_TopBar_Text)
        Me.pnl_TopBar.Controls.Add(Me.btn_Close)
        Me.pnl_TopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnl_TopBar.Name = "pnl_TopBar"
        Me.pnl_TopBar.ShadowDecoration.Parent = Me.pnl_TopBar
        Me.pnl_TopBar.Size = New System.Drawing.Size(1000, 50)
        Me.pnl_TopBar.TabIndex = 1
        '
        'img_TopBar_Logo
        '
        Me.img_TopBar_Logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.img_TopBar_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.img_TopBar_Logo.ContextMenuStrip = Me.ctx_Main
        Me.img_TopBar_Logo.Image = CType(resources.GetObject("img_TopBar_Logo.Image"), System.Drawing.Image)
        Me.img_TopBar_Logo.Location = New System.Drawing.Point(6, 5)
        Me.img_TopBar_Logo.Name = "img_TopBar_Logo"
        Me.img_TopBar_Logo.Size = New System.Drawing.Size(45, 40)
        Me.img_TopBar_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_TopBar_Logo.TabIndex = 0
        Me.img_TopBar_Logo.TabStop = False
        '
        'ctx_Main
        '
        Me.ctx_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxItem_About, Me.ctxItem_Help, Me.ctxItem_Exit})
        Me.ctx_Main.Name = "ctx_Main"
        Me.ctx_Main.Size = New System.Drawing.Size(108, 70)
        '
        'ctxItem_About
        '
        Me.ctxItem_About.Name = "ctxItem_About"
        Me.ctxItem_About.Size = New System.Drawing.Size(107, 22)
        Me.ctxItem_About.Text = "About"
        '
        'ctxItem_Help
        '
        Me.ctxItem_Help.Name = "ctxItem_Help"
        Me.ctxItem_Help.Size = New System.Drawing.Size(107, 22)
        Me.ctxItem_Help.Text = "Help"
        '
        'ctxItem_Exit
        '
        Me.ctxItem_Exit.Name = "ctxItem_Exit"
        Me.ctxItem_Exit.Size = New System.Drawing.Size(107, 22)
        Me.ctxItem_Exit.Text = "Exit"
        '
        'lbl_TopBar_Text
        '
        Me.lbl_TopBar_Text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_TopBar_Text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TopBar_Text.Enabled = False
        Me.lbl_TopBar_Text.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TopBar_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_TopBar_Text.Location = New System.Drawing.Point(57, 12)
        Me.lbl_TopBar_Text.Name = "lbl_TopBar_Text"
        Me.lbl_TopBar_Text.Size = New System.Drawing.Size(88, 27)
        Me.lbl_TopBar_Text.TabIndex = 1
        Me.lbl_TopBar_Text.TabStop = False
        Me.lbl_TopBar_Text.Text = "<span style=""color: white"">MD</span> - <span style=""color: #ddd"">APP</span>"
        '
        'pnl_Auth
        '
        Me.pnl_Auth.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnl_Auth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_Auth.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.pnl_Auth.Location = New System.Drawing.Point(0, 49)
        Me.pnl_Auth.Name = "pnl_Auth"
        Me.pnl_Auth.ShadowDecoration.Parent = Me.pnl_Auth
        Me.pnl_Auth.Size = New System.Drawing.Size(670, 552)
        Me.pnl_Auth.TabIndex = 0
        '
        'pnl_ToggleAuth
        '
        Me.pnl_ToggleAuth.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pnl_ToggleAuth.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnl_ToggleAuth.Controls.Add(Me.PictureBox1)
        Me.pnl_ToggleAuth.Controls.Add(Me.lbl_ToggleAuthText)
        Me.pnl_ToggleAuth.Controls.Add(Me.btn_ToggleAuth)
        Me.pnl_ToggleAuth.Location = New System.Drawing.Point(668, 49)
        Me.pnl_ToggleAuth.Name = "pnl_ToggleAuth"
        Me.pnl_ToggleAuth.ShadowDecoration.Parent = Me.pnl_ToggleAuth
        Me.pnl_ToggleAuth.Size = New System.Drawing.Size(333, 552)
        Me.pnl_ToggleAuth.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(103, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_ToggleAuthText
        '
        Me.lbl_ToggleAuthText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ToggleAuthText.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToggleAuthText.Enabled = False
        Me.lbl_ToggleAuthText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToggleAuthText.Location = New System.Drawing.Point(18, 289)
        Me.lbl_ToggleAuthText.Name = "lbl_ToggleAuthText"
        Me.lbl_ToggleAuthText.Size = New System.Drawing.Size(288, 27)
        Me.lbl_ToggleAuthText.TabIndex = 1
        Me.lbl_ToggleAuthText.TabStop = False
        Me.lbl_ToggleAuthText.Text = "Already Registered? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Login instead"
        Me.lbl_ToggleAuthText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_ToggleAuth
        '
        Me.btn_ToggleAuth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ToggleAuth.BorderRadius = 20
        Me.btn_ToggleAuth.CheckedState.Parent = Me.btn_ToggleAuth
        Me.btn_ToggleAuth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ToggleAuth.CustomImages.Parent = Me.btn_ToggleAuth
        Me.btn_ToggleAuth.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ToggleAuth.ForeColor = System.Drawing.Color.White
        Me.btn_ToggleAuth.HoverState.Parent = Me.btn_ToggleAuth
        Me.btn_ToggleAuth.Location = New System.Drawing.Point(18, 337)
        Me.btn_ToggleAuth.Name = "btn_ToggleAuth"
        Me.btn_ToggleAuth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_ToggleAuth.ShadowDecoration.Parent = Me.btn_ToggleAuth
        Me.btn_ToggleAuth.Size = New System.Drawing.Size(302, 45)
        Me.btn_ToggleAuth.TabIndex = 0
        Me.btn_ToggleAuth.Text = "Login"
        '
        'frm_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnl_ToggleAuth)
        Me.Controls.Add(Me.pnl_Auth)
        Me.Controls.Add(Me.pnl_TopBar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_MainMenu"
        Me.ShowIcon = False
        Me.Text = "Form1"
        Me.pnl_TopBar.ResumeLayout(False)
        Me.pnl_TopBar.PerformLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctx_Main.ResumeLayout(False)
        Me.pnl_ToggleAuth.ResumeLayout(False)
        Me.pnl_ToggleAuth.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Close As Guna.UI2.WinForms.Guna2Button
  Friend WithEvents pnl_TopBar As Guna.UI2.WinForms.Guna2Panel
  Friend WithEvents pnl_Auth As Guna.UI2.WinForms.Guna2Panel
  Friend WithEvents pnl_ToggleAuth As Guna.UI2.WinForms.Guna2Panel
  Friend WithEvents lbl_ToggleAuthText As Guna.UI2.WinForms.Guna2HtmlLabel
  Friend WithEvents btn_ToggleAuth As Guna.UI2.WinForms.Guna2Button
  Friend WithEvents lbl_TopBar_Text As Guna.UI2.WinForms.Guna2HtmlLabel
  Friend WithEvents ctx_Main As ContextMenuStrip
  Friend WithEvents ctxItem_About As ToolStripMenuItem
  Friend WithEvents ctxItem_Help As ToolStripMenuItem
  Friend WithEvents ctxItem_Exit As ToolStripMenuItem
  Friend WithEvents img_TopBar_Logo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
