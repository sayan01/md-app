<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MedicineSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MedicineSearch))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_TopBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.img_TopBar_Logo = New System.Windows.Forms.PictureBox()
        Me.lbl_TopBar_Text = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_Close = New Guna.UI2.WinForms.Guna2Button()
        Me.ctx_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxItem_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_Top = New Guna.UI2.WinForms.Guna2Panel()
        Me.tb_SearchInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_Search = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_Mid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgv_Medicines = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnl_Bottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_OK = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_TopBar.SuspendLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctx_Main.SuspendLayout()
        Me.pnl_Top.SuspendLayout()
        Me.pnl_Mid.SuspendLayout()
        CType(Me.dgv_Medicines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Bottom.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnl_TopBar.TabIndex = 3
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
        Me.lbl_TopBar_Text.Size = New System.Drawing.Size(247, 27)
        Me.lbl_TopBar_Text.TabIndex = 1
        Me.lbl_TopBar_Text.TabStop = False
        Me.lbl_TopBar_Text.Text = "<span style=""color: white"">MD</span> - <span style=""color: #ddd"">APP</span> -  Me" &
    "dicine Search"
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
        'pnl_Top
        '
        Me.pnl_Top.Controls.Add(Me.tb_SearchInput)
        Me.pnl_Top.Controls.Add(Me.lbl_Search)
        Me.pnl_Top.Location = New System.Drawing.Point(0, 47)
        Me.pnl_Top.Name = "pnl_Top"
        Me.pnl_Top.ShadowDecoration.Parent = Me.pnl_Top
        Me.pnl_Top.Size = New System.Drawing.Size(1014, 82)
        Me.pnl_Top.TabIndex = 4
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
        'pnl_Mid
        '
        Me.pnl_Mid.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnl_Mid.Controls.Add(Me.dgv_Medicines)
        Me.pnl_Mid.Location = New System.Drawing.Point(0, 128)
        Me.pnl_Mid.Name = "pnl_Mid"
        Me.pnl_Mid.ShadowDecoration.Parent = Me.pnl_Mid
        Me.pnl_Mid.Size = New System.Drawing.Size(1014, 410)
        Me.pnl_Mid.TabIndex = 4
        '
        'dgv_Medicines
        '
        Me.dgv_Medicines.AllowUserToAddRows = False
        Me.dgv_Medicines.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgv_Medicines.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Medicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Medicines.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Medicines.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Medicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Medicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Medicines.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Medicines.ColumnHeadersHeight = 21
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Medicines.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Medicines.EnableHeadersVisualStyles = False
        Me.dgv_Medicines.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Medicines.Location = New System.Drawing.Point(27, 19)
        Me.dgv_Medicines.Margin = New System.Windows.Forms.Padding(15)
        Me.dgv_Medicines.Name = "dgv_Medicines"
        Me.dgv_Medicines.ReadOnly = True
        Me.dgv_Medicines.RowHeadersVisible = False
        Me.dgv_Medicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Medicines.Size = New System.Drawing.Size(963, 372)
        Me.dgv_Medicines.TabIndex = 0
        Me.dgv_Medicines.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_Medicines.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Medicines.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_Medicines.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_Medicines.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_Medicines.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_Medicines.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Medicines.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Medicines.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Medicines.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Medicines.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_Medicines.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_Medicines.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_Medicines.ThemeStyle.HeaderStyle.Height = 21
        Me.dgv_Medicines.ThemeStyle.ReadOnly = True
        Me.dgv_Medicines.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Medicines.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Medicines.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_Medicines.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_Medicines.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_Medicines.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Medicines.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnl_Bottom
        '
        Me.pnl_Bottom.Controls.Add(Me.btn_OK)
        Me.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Bottom.Location = New System.Drawing.Point(0, 537)
        Me.pnl_Bottom.Name = "pnl_Bottom"
        Me.pnl_Bottom.ShadowDecoration.Parent = Me.pnl_Bottom
        Me.pnl_Bottom.Size = New System.Drawing.Size(1014, 78)
        Me.pnl_Bottom.TabIndex = 4
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
        'frm_MedicineSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 615)
        Me.Controls.Add(Me.pnl_Mid)
        Me.Controls.Add(Me.pnl_Bottom)
        Me.Controls.Add(Me.pnl_Top)
        Me.Controls.Add(Me.pnl_TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_MedicineSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_MedicineSearch"
        Me.pnl_TopBar.ResumeLayout(False)
        Me.pnl_TopBar.PerformLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctx_Main.ResumeLayout(False)
        Me.pnl_Top.ResumeLayout(False)
        Me.pnl_Top.PerformLayout()
        Me.pnl_Mid.ResumeLayout(False)
        CType(Me.dgv_Medicines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Bottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_TopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents img_TopBar_Logo As PictureBox
    Friend WithEvents lbl_TopBar_Text As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_Close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ctx_Main As ContextMenuStrip
    Friend WithEvents ctxItem_About As ToolStripMenuItem
    Friend WithEvents ctxItem_Help As ToolStripMenuItem
    Friend WithEvents ctxItem_Exit As ToolStripMenuItem
    Friend WithEvents pnl_Top As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tb_SearchInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_Search As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_Mid As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgv_Medicines As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnl_Bottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_OK As Guna.UI2.WinForms.Guna2Button
End Class
