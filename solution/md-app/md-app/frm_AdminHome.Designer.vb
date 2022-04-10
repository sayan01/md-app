<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminHome))
        Me.pnl_Body = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_Bottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_EditMed = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_EditProc = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_PatHist = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_Heading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_Close = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_TopBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.img_TopBar_Logo = New System.Windows.Forms.PictureBox()
        Me.ctx_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxItem_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_TopBar_Text = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_Body.SuspendLayout()
        Me.pnl_Bottom.SuspendLayout()
        Me.pnl_TopBar.SuspendLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctx_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_Body
        '
        Me.pnl_Body.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_Body.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnl_Body.Controls.Add(Me.pnl_Bottom)
        Me.pnl_Body.Controls.Add(Me.lbl_Heading)
        Me.pnl_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Body.Location = New System.Drawing.Point(0, 50)
        Me.pnl_Body.Name = "pnl_Body"
        Me.pnl_Body.ShadowDecoration.Parent = Me.pnl_Body
        Me.pnl_Body.Size = New System.Drawing.Size(762, 319)
        Me.pnl_Body.TabIndex = 3
        '
        'pnl_Bottom
        '
        Me.pnl_Bottom.Controls.Add(Me.btn_EditMed)
        Me.pnl_Bottom.Controls.Add(Me.btn_EditProc)
        Me.pnl_Bottom.Controls.Add(Me.btn_PatHist)
        Me.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Bottom.Location = New System.Drawing.Point(0, 198)
        Me.pnl_Bottom.Name = "pnl_Bottom"
        Me.pnl_Bottom.ShadowDecoration.Parent = Me.pnl_Bottom
        Me.pnl_Bottom.Size = New System.Drawing.Size(762, 121)
        Me.pnl_Bottom.TabIndex = 2
        '
        'btn_EditMed
        '
        Me.btn_EditMed.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_EditMed.BorderRadius = 25
        Me.btn_EditMed.CheckedState.Parent = Me.btn_EditMed
        Me.btn_EditMed.CustomImages.Parent = Me.btn_EditMed
        Me.btn_EditMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EditMed.ForeColor = System.Drawing.Color.White
        Me.btn_EditMed.HoverState.Parent = Me.btn_EditMed
        Me.btn_EditMed.Location = New System.Drawing.Point(284, 16)
        Me.btn_EditMed.Name = "btn_EditMed"
        Me.btn_EditMed.ShadowDecoration.Parent = Me.btn_EditMed
        Me.btn_EditMed.Size = New System.Drawing.Size(183, 78)
        Me.btn_EditMed.TabIndex = 1
        Me.btn_EditMed.Text = "Edit Medicines"
        '
        'btn_EditProc
        '
        Me.btn_EditProc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_EditProc.BorderRadius = 25
        Me.btn_EditProc.CheckedState.Parent = Me.btn_EditProc
        Me.btn_EditProc.CustomImages.Parent = Me.btn_EditProc
        Me.btn_EditProc.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EditProc.ForeColor = System.Drawing.Color.White
        Me.btn_EditProc.HoverState.Parent = Me.btn_EditProc
        Me.btn_EditProc.Location = New System.Drawing.Point(526, 16)
        Me.btn_EditProc.Name = "btn_EditProc"
        Me.btn_EditProc.ShadowDecoration.Parent = Me.btn_EditProc
        Me.btn_EditProc.Size = New System.Drawing.Size(183, 78)
        Me.btn_EditProc.TabIndex = 1
        Me.btn_EditProc.Text = "Edit Procedures"
        '
        'btn_PatHist
        '
        Me.btn_PatHist.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_PatHist.BorderRadius = 25
        Me.btn_PatHist.CheckedState.Parent = Me.btn_PatHist
        Me.btn_PatHist.CustomImages.Parent = Me.btn_PatHist
        Me.btn_PatHist.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PatHist.ForeColor = System.Drawing.Color.White
        Me.btn_PatHist.HoverState.Parent = Me.btn_PatHist
        Me.btn_PatHist.Location = New System.Drawing.Point(43, 16)
        Me.btn_PatHist.Name = "btn_PatHist"
        Me.btn_PatHist.ShadowDecoration.Parent = Me.btn_PatHist
        Me.btn_PatHist.Size = New System.Drawing.Size(183, 78)
        Me.btn_PatHist.TabIndex = 1
        Me.btn_PatHist.Text = "Patient History"
        '
        'lbl_Heading
        '
        Me.lbl_Heading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Enabled = False
        Me.lbl_Heading.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_Heading.Location = New System.Drawing.Point(269, 45)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(231, 122)
        Me.lbl_Heading.TabIndex = 0
        Me.lbl_Heading.Text = "<h1>Admin Panel</h1>"
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
        Me.btn_Close.Location = New System.Drawing.Point(712, -4)
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
        Me.pnl_TopBar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pnl_TopBar.Controls.Add(Me.img_TopBar_Logo)
        Me.pnl_TopBar.Controls.Add(Me.lbl_TopBar_Text)
        Me.pnl_TopBar.Controls.Add(Me.btn_Close)
        Me.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_TopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnl_TopBar.Name = "pnl_TopBar"
        Me.pnl_TopBar.ShadowDecoration.Parent = Me.pnl_TopBar
        Me.pnl_TopBar.Size = New System.Drawing.Size(762, 50)
        Me.pnl_TopBar.TabIndex = 4
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
        'frm_AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 369)
        Me.Controls.Add(Me.pnl_Body)
        Me.Controls.Add(Me.pnl_TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_AdminHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_AdminHome"
        Me.pnl_Body.ResumeLayout(False)
        Me.pnl_Body.PerformLayout()
        Me.pnl_Bottom.ResumeLayout(False)
        Me.pnl_TopBar.ResumeLayout(False)
        Me.pnl_TopBar.PerformLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctx_Main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_Body As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_Close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl_TopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents img_TopBar_Logo As PictureBox
    Friend WithEvents ctx_Main As ContextMenuStrip
    Friend WithEvents ctxItem_About As ToolStripMenuItem
    Friend WithEvents ctxItem_Help As ToolStripMenuItem
    Friend WithEvents ctxItem_Exit As ToolStripMenuItem
    Friend WithEvents lbl_TopBar_Text As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_EditProc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_EditMed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_PatHist As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_Heading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_Bottom As Guna.UI2.WinForms.Guna2Panel
End Class
