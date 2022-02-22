<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProcedureSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ProcedureSearch))
        Me.dgv_Procedures = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tb_SearchInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_Search = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_OK = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_Mid = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_Bottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctxItem_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctx_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.img_TopBar_Logo = New System.Windows.Forms.PictureBox()
        Me.lbl_TopBar_Text = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_Close = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_TopBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_Top = New Guna.UI2.WinForms.Guna2Panel()
        Me.col_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Procedures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Mid.SuspendLayout()
        Me.pnl_Bottom.SuspendLayout()
        Me.ctx_Main.SuspendLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_TopBar.SuspendLayout()
        Me.pnl_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Procedures
        '
        Me.dgv_Procedures.AllowUserToAddRows = False
        Me.dgv_Procedures.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv_Procedures.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Procedures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Procedures.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Procedures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Procedures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Procedures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Procedures.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Procedures.ColumnHeadersHeight = 21
        Me.dgv_Procedures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_name})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Procedures.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Procedures.EnableHeadersVisualStyles = False
        Me.dgv_Procedures.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Procedures.Location = New System.Drawing.Point(27, 19)
        Me.dgv_Procedures.Margin = New System.Windows.Forms.Padding(15)
        Me.dgv_Procedures.Name = "dgv_Procedures"
        Me.dgv_Procedures.ReadOnly = True
        Me.dgv_Procedures.RowHeadersVisible = False
        Me.dgv_Procedures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Procedures.Size = New System.Drawing.Size(963, 372)
        Me.dgv_Procedures.TabIndex = 0
        Me.dgv_Procedures.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_Procedures.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Procedures.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_Procedures.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_Procedures.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_Procedures.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_Procedures.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Procedures.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Procedures.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Procedures.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Procedures.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_Procedures.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_Procedures.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_Procedures.ThemeStyle.HeaderStyle.Height = 21
        Me.dgv_Procedures.ThemeStyle.ReadOnly = True
        Me.dgv_Procedures.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Procedures.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Procedures.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_Procedures.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_Procedures.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_Procedures.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Procedures.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tb_SearchInput
        '
        Me.tb_SearchInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_SearchInput.DefaultText = ""
        Me.tb_SearchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_SearchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_SearchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_SearchInput.DisabledState.Parent = Me.tb_SearchInput
        Me.tb_SearchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_SearchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_SearchInput.FocusedState.Parent = Me.tb_SearchInput
        Me.tb_SearchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_SearchInput.HoverState.Parent = Me.tb_SearchInput
        Me.tb_SearchInput.Location = New System.Drawing.Point(123, 23)
        Me.tb_SearchInput.Name = "tb_SearchInput"
        Me.tb_SearchInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_SearchInput.PlaceholderText = ""
        Me.tb_SearchInput.SelectedText = ""
        Me.tb_SearchInput.ShadowDecoration.Parent = Me.tb_SearchInput
        Me.tb_SearchInput.Size = New System.Drawing.Size(795, 36)
        Me.tb_SearchInput.TabIndex = 1
        '
        'lbl_Search
        '
        Me.lbl_Search.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Search.Location = New System.Drawing.Point(27, 31)
        Me.lbl_Search.Name = "lbl_Search"
        Me.lbl_Search.Size = New System.Drawing.Size(58, 22)
        Me.lbl_Search.TabIndex = 0
        Me.lbl_Search.Text = "Search:"
        '
        'btn_OK
        '
        Me.btn_OK.BorderRadius = 20
        Me.btn_OK.CheckedState.Parent = Me.btn_OK
        Me.btn_OK.CustomImages.Parent = Me.btn_OK
        Me.btn_OK.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OK.ForeColor = System.Drawing.Color.White
        Me.btn_OK.HoverState.Parent = Me.btn_OK
        Me.btn_OK.Location = New System.Drawing.Point(901, 21)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.ShadowDecoration.Parent = Me.btn_OK
        Me.btn_OK.Size = New System.Drawing.Size(101, 45)
        Me.btn_OK.TabIndex = 0
        Me.btn_OK.Text = "OK"
        '
        'pnl_Mid
        '
        Me.pnl_Mid.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnl_Mid.Controls.Add(Me.dgv_Procedures)
        Me.pnl_Mid.Location = New System.Drawing.Point(0, 133)
        Me.pnl_Mid.Name = "pnl_Mid"
        Me.pnl_Mid.ShadowDecoration.Parent = Me.pnl_Mid
        Me.pnl_Mid.Size = New System.Drawing.Size(1014, 410)
        Me.pnl_Mid.TabIndex = 6
        '
        'pnl_Bottom
        '
        Me.pnl_Bottom.Controls.Add(Me.btn_OK)
        Me.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Bottom.Location = New System.Drawing.Point(0, 544)
        Me.pnl_Bottom.Name = "pnl_Bottom"
        Me.pnl_Bottom.ShadowDecoration.Parent = Me.pnl_Bottom
        Me.pnl_Bottom.Size = New System.Drawing.Size(1014, 78)
        Me.pnl_Bottom.TabIndex = 7
        '
        'ctxItem_Exit
        '
        Me.ctxItem_Exit.Name = "ctxItem_Exit"
        Me.ctxItem_Exit.Size = New System.Drawing.Size(107, 22)
        Me.ctxItem_Exit.Text = "Exit"
        '
        'ctxItem_Help
        '
        Me.ctxItem_Help.Name = "ctxItem_Help"
        Me.ctxItem_Help.Size = New System.Drawing.Size(107, 22)
        Me.ctxItem_Help.Text = "Help"
        '
        'ctxItem_About
        '
        Me.ctxItem_About.Name = "ctxItem_About"
        Me.ctxItem_About.Size = New System.Drawing.Size(107, 22)
        Me.ctxItem_About.Text = "About"
        '
        'ctx_Main
        '
        Me.ctx_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxItem_About, Me.ctxItem_Help, Me.ctxItem_Exit})
        Me.ctx_Main.Name = "ctx_Main"
        Me.ctx_Main.Size = New System.Drawing.Size(108, 70)
        '
        'img_TopBar_Logo
        '
        Me.img_TopBar_Logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.img_TopBar_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.img_TopBar_Logo.Image = CType(resources.GetObject("img_TopBar_Logo.Image"), System.Drawing.Image)
        Me.img_TopBar_Logo.Location = New System.Drawing.Point(6, 5)
        Me.img_TopBar_Logo.Name = "img_TopBar_Logo"
        Me.img_TopBar_Logo.Size = New System.Drawing.Size(45, 36)
        Me.img_TopBar_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_TopBar_Logo.TabIndex = 0
        Me.img_TopBar_Logo.TabStop = False
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
        Me.lbl_TopBar_Text.Size = New System.Drawing.Size(255, 27)
        Me.lbl_TopBar_Text.TabIndex = 1
        Me.lbl_TopBar_Text.TabStop = False
        Me.lbl_TopBar_Text.Text = "<span style=""color: white"">MD</span> - <span style=""color: #ddd"">APP</span> -  Pr" &
    "ocedure Search"
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
        Me.btn_Close.Location = New System.Drawing.Point(964, -4)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.ShadowDecoration.Parent = Me.btn_Close
        Me.btn_Close.Size = New System.Drawing.Size(50, 50)
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
        Me.pnl_TopBar.Size = New System.Drawing.Size(1014, 46)
        Me.pnl_TopBar.TabIndex = 5
        '
        'pnl_Top
        '
        Me.pnl_Top.Controls.Add(Me.tb_SearchInput)
        Me.pnl_Top.Controls.Add(Me.lbl_Search)
        Me.pnl_Top.Location = New System.Drawing.Point(0, 45)
        Me.pnl_Top.Name = "pnl_Top"
        Me.pnl_Top.ShadowDecoration.Parent = Me.pnl_Top
        Me.pnl_Top.Size = New System.Drawing.Size(1017, 89)
        Me.pnl_Top.TabIndex = 8
        '
        'col_name
        '
        Me.col_name.HeaderText = "Name"
        Me.col_name.Name = "col_name"
        Me.col_name.ReadOnly = True
        '
        'frm_ProcedureSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 622)
        Me.Controls.Add(Me.pnl_Mid)
        Me.Controls.Add(Me.pnl_Bottom)
        Me.Controls.Add(Me.pnl_TopBar)
        Me.Controls.Add(Me.pnl_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ProcedureSearch"
        Me.Text = "frm_ProcedureSearch"
        CType(Me.dgv_Procedures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Mid.ResumeLayout(False)
        Me.pnl_Bottom.ResumeLayout(False)
        Me.ctx_Main.ResumeLayout(False)
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_TopBar.ResumeLayout(False)
        Me.pnl_TopBar.PerformLayout()
        Me.pnl_Top.ResumeLayout(False)
        Me.pnl_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_Procedures As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tb_SearchInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_Search As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_OK As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl_Mid As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_Bottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctxItem_Exit As ToolStripMenuItem
    Friend WithEvents ctxItem_Help As ToolStripMenuItem
    Friend WithEvents ctxItem_About As ToolStripMenuItem
    Friend WithEvents ctx_Main As ContextMenuStrip
    Friend WithEvents img_TopBar_Logo As PictureBox
    Friend WithEvents lbl_TopBar_Text As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_Close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl_TopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_Top As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents col_name As DataGridViewTextBoxColumn
End Class
