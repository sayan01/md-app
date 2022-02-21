<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PrescriptionEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PrescriptionEditor))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_TopBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.img_TopBar_Logo = New System.Windows.Forms.PictureBox()
        Me.ctx_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxItem_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxItem_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_TopBar_Text = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_Close = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_Date = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_Name = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_Age = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_Gender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tb_Date = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Age = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Gender = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnl_Header = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_Footer = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Print = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_Left = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_Prescription_Header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_Right = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_Advice_Header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgv_PresTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.col_med = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_AddMed = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_AddProc = New Guna.UI2.WinForms.Guna2Button()
        Me.rtb_Advice = New System.Windows.Forms.RichTextBox()
        Me.btn_ClearAdvice = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_TopBar.SuspendLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctx_Main.SuspendLayout()
        Me.pnl_Header.SuspendLayout()
        Me.pnl_Footer.SuspendLayout()
        Me.pnl_Left.SuspendLayout()
        Me.pnl_Right.SuspendLayout()
        CType(Me.dgv_PresTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnl_TopBar.Size = New System.Drawing.Size(1064, 50)
        Me.pnl_TopBar.TabIndex = 2
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
        Me.lbl_TopBar_Text.Size = New System.Drawing.Size(264, 27)
        Me.lbl_TopBar_Text.TabIndex = 1
        Me.lbl_TopBar_Text.TabStop = False
        Me.lbl_TopBar_Text.Text = "<span style=""color: white"">MD</span> - <span style=""color: #ddd"">APP</span> -  Pr" &
    "escription Editor"
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
        Me.btn_Close.Location = New System.Drawing.Point(1014, -4)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.ShadowDecoration.Parent = Me.btn_Close
        Me.btn_Close.Size = New System.Drawing.Size(50, 54)
        Me.btn_Close.TabIndex = 0
        Me.btn_Close.Text = "×"
        '
        'lbl_Date
        '
        Me.lbl_Date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Date.Enabled = False
        Me.lbl_Date.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.Location = New System.Drawing.Point(32, 28)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(38, 23)
        Me.lbl_Date.TabIndex = 3
        Me.lbl_Date.TabStop = False
        Me.lbl_Date.Text = "Date:"
        '
        'lbl_Name
        '
        Me.lbl_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name.Enabled = False
        Me.lbl_Name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(283, 28)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(48, 23)
        Me.lbl_Name.TabIndex = 3
        Me.lbl_Name.TabStop = False
        Me.lbl_Name.Text = "Name:"
        '
        'lbl_Age
        '
        Me.lbl_Age.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Age.Enabled = False
        Me.lbl_Age.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.Location = New System.Drawing.Point(544, 28)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(33, 23)
        Me.lbl_Age.TabIndex = 3
        Me.lbl_Age.TabStop = False
        Me.lbl_Age.Text = "Age:"
        '
        'lbl_Gender
        '
        Me.lbl_Gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Gender.Enabled = False
        Me.lbl_Gender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.Location = New System.Drawing.Point(779, 28)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(57, 23)
        Me.lbl_Gender.TabIndex = 3
        Me.lbl_Gender.TabStop = False
        Me.lbl_Gender.Text = "Gender:"
        '
        'tb_Date
        '
        Me.tb_Date.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Date.DefaultText = ""
        Me.tb_Date.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Date.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Date.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Date.DisabledState.Parent = Me.tb_Date
        Me.tb_Date.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Date.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Date.FocusedState.Parent = Me.tb_Date
        Me.tb_Date.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Date.HoverState.Parent = Me.tb_Date
        Me.tb_Date.Location = New System.Drawing.Point(76, 28)
        Me.tb_Date.Name = "tb_Date"
        Me.tb_Date.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Date.PlaceholderText = "date"
        Me.tb_Date.SelectedText = ""
        Me.tb_Date.ShadowDecoration.Parent = Me.tb_Date
        Me.tb_Date.Size = New System.Drawing.Size(178, 23)
        Me.tb_Date.TabIndex = 0
        '
        'tb_Name
        '
        Me.tb_Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Name.DefaultText = ""
        Me.tb_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Name.DisabledState.Parent = Me.tb_Name
        Me.tb_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Name.FocusedState.Parent = Me.tb_Name
        Me.tb_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Name.HoverState.Parent = Me.tb_Name
        Me.tb_Name.Location = New System.Drawing.Point(337, 29)
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Name.PlaceholderText = "name"
        Me.tb_Name.SelectedText = ""
        Me.tb_Name.ShadowDecoration.Parent = Me.tb_Name
        Me.tb_Name.Size = New System.Drawing.Size(178, 22)
        Me.tb_Name.TabIndex = 1
        '
        'tb_Age
        '
        Me.tb_Age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Age.DefaultText = ""
        Me.tb_Age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Age.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Age.DisabledState.Parent = Me.tb_Age
        Me.tb_Age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Age.FocusedState.Parent = Me.tb_Age
        Me.tb_Age.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Age.HoverState.Parent = Me.tb_Age
        Me.tb_Age.Location = New System.Drawing.Point(583, 29)
        Me.tb_Age.Name = "tb_Age"
        Me.tb_Age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Age.PlaceholderText = "age"
        Me.tb_Age.SelectedText = ""
        Me.tb_Age.ShadowDecoration.Parent = Me.tb_Age
        Me.tb_Age.Size = New System.Drawing.Size(178, 22)
        Me.tb_Age.TabIndex = 2
        '
        'tb_Gender
        '
        Me.tb_Gender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Gender.DefaultText = ""
        Me.tb_Gender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Gender.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Gender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Gender.DisabledState.Parent = Me.tb_Gender
        Me.tb_Gender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Gender.FocusedState.Parent = Me.tb_Gender
        Me.tb_Gender.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Gender.HoverState.Parent = Me.tb_Gender
        Me.tb_Gender.Location = New System.Drawing.Point(842, 29)
        Me.tb_Gender.Name = "tb_Gender"
        Me.tb_Gender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Gender.PlaceholderText = "gender"
        Me.tb_Gender.SelectedText = ""
        Me.tb_Gender.ShadowDecoration.Parent = Me.tb_Gender
        Me.tb_Gender.Size = New System.Drawing.Size(178, 22)
        Me.tb_Gender.TabIndex = 3
        '
        'pnl_Header
        '
        Me.pnl_Header.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_Header.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Header.Controls.Add(Me.lbl_Date)
        Me.pnl_Header.Controls.Add(Me.lbl_Name)
        Me.pnl_Header.Controls.Add(Me.tb_Gender)
        Me.pnl_Header.Controls.Add(Me.lbl_Age)
        Me.pnl_Header.Controls.Add(Me.tb_Age)
        Me.pnl_Header.Controls.Add(Me.lbl_Gender)
        Me.pnl_Header.Controls.Add(Me.tb_Name)
        Me.pnl_Header.Controls.Add(Me.tb_Date)
        Me.pnl_Header.Location = New System.Drawing.Point(0, 51)
        Me.pnl_Header.Name = "pnl_Header"
        Me.pnl_Header.ShadowDecoration.Parent = Me.pnl_Header
        Me.pnl_Header.Size = New System.Drawing.Size(1064, 79)
        Me.pnl_Header.TabIndex = 5
        '
        'pnl_Footer
        '
        Me.pnl_Footer.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnl_Footer.Controls.Add(Me.btn_Print)
        Me.pnl_Footer.Controls.Add(Me.btn_Save)
        Me.pnl_Footer.Location = New System.Drawing.Point(0, 535)
        Me.pnl_Footer.Name = "pnl_Footer"
        Me.pnl_Footer.ShadowDecoration.Parent = Me.pnl_Footer
        Me.pnl_Footer.Size = New System.Drawing.Size(1064, 72)
        Me.pnl_Footer.TabIndex = 6
        '
        'btn_Save
        '
        Me.btn_Save.BorderRadius = 20
        Me.btn_Save.CheckedState.Parent = Me.btn_Save
        Me.btn_Save.CustomImages.Parent = Me.btn_Save
        Me.btn_Save.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.HoverState.Parent = Me.btn_Save
        Me.btn_Save.Location = New System.Drawing.Point(804, 10)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.ShadowDecoration.Parent = Me.btn_Save
        Me.btn_Save.Size = New System.Drawing.Size(137, 45)
        Me.btn_Save.TabIndex = 9
        Me.btn_Save.Text = "Save & Exit"
        '
        'btn_Print
        '
        Me.btn_Print.BorderRadius = 20
        Me.btn_Print.CheckedState.Parent = Me.btn_Print
        Me.btn_Print.CustomImages.Parent = Me.btn_Print
        Me.btn_Print.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.ForeColor = System.Drawing.Color.White
        Me.btn_Print.HoverState.Parent = Me.btn_Print
        Me.btn_Print.Location = New System.Drawing.Point(947, 10)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.ShadowDecoration.Parent = Me.btn_Print
        Me.btn_Print.Size = New System.Drawing.Size(104, 45)
        Me.btn_Print.TabIndex = 10
        Me.btn_Print.Text = "Print"
        '
        'pnl_Left
        '
        Me.pnl_Left.Controls.Add(Me.dgv_PresTable)
        Me.pnl_Left.Controls.Add(Me.btn_AddProc)
        Me.pnl_Left.Controls.Add(Me.btn_AddMed)
        Me.pnl_Left.Controls.Add(Me.lbl_Prescription_Header)
        Me.pnl_Left.Location = New System.Drawing.Point(0, 129)
        Me.pnl_Left.Name = "pnl_Left"
        Me.pnl_Left.ShadowDecoration.Parent = Me.pnl_Left
        Me.pnl_Left.Size = New System.Drawing.Size(668, 407)
        Me.pnl_Left.TabIndex = 7
        '
        'lbl_Prescription_Header
        '
        Me.lbl_Prescription_Header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Prescription_Header.Enabled = False
        Me.lbl_Prescription_Header.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prescription_Header.Location = New System.Drawing.Point(32, 20)
        Me.lbl_Prescription_Header.Name = "lbl_Prescription_Header"
        Me.lbl_Prescription_Header.Size = New System.Drawing.Size(86, 23)
        Me.lbl_Prescription_Header.TabIndex = 3
        Me.lbl_Prescription_Header.TabStop = False
        Me.lbl_Prescription_Header.Text = "Prescription"
        '
        'pnl_Right
        '
        Me.pnl_Right.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnl_Right.Controls.Add(Me.rtb_Advice)
        Me.pnl_Right.Controls.Add(Me.btn_ClearAdvice)
        Me.pnl_Right.Controls.Add(Me.lbl_Advice_Header)
        Me.pnl_Right.Location = New System.Drawing.Point(666, 129)
        Me.pnl_Right.Name = "pnl_Right"
        Me.pnl_Right.ShadowDecoration.Parent = Me.pnl_Right
        Me.pnl_Right.Size = New System.Drawing.Size(398, 407)
        Me.pnl_Right.TabIndex = 8
        '
        'lbl_Advice_Header
        '
        Me.lbl_Advice_Header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Advice_Header.Enabled = False
        Me.lbl_Advice_Header.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Advice_Header.Location = New System.Drawing.Point(29, 20)
        Me.lbl_Advice_Header.Name = "lbl_Advice_Header"
        Me.lbl_Advice_Header.Size = New System.Drawing.Size(111, 23)
        Me.lbl_Advice_Header.TabIndex = 3
        Me.lbl_Advice_Header.TabStop = False
        Me.lbl_Advice_Header.Text = "Doctor's Advice"
        '
        'dgv_PresTable
        '
        Me.dgv_PresTable.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgv_PresTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_PresTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_PresTable.BackgroundColor = System.Drawing.Color.White
        Me.dgv_PresTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_PresTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_PresTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_PresTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_PresTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PresTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_med, Me.col_note})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_PresTable.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_PresTable.EnableHeadersVisualStyles = False
        Me.dgv_PresTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_PresTable.Location = New System.Drawing.Point(57, 62)
        Me.dgv_PresTable.Name = "dgv_PresTable"
        Me.dgv_PresTable.ReadOnly = True
        Me.dgv_PresTable.RowHeadersVisible = False
        Me.dgv_PresTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_PresTable.Size = New System.Drawing.Size(520, 250)
        Me.dgv_PresTable.TabIndex = 4
        Me.dgv_PresTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_PresTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_PresTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_PresTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_PresTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_PresTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_PresTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_PresTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_PresTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_PresTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_PresTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_PresTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_PresTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PresTable.ThemeStyle.HeaderStyle.Height = 21
        Me.dgv_PresTable.ThemeStyle.ReadOnly = True
        Me.dgv_PresTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_PresTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_PresTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_PresTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_PresTable.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_PresTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_PresTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'col_med
        '
        Me.col_med.HeaderText = "Medicines/Procedures"
        Me.col_med.Name = "col_med"
        Me.col_med.ReadOnly = True
        '
        'col_note
        '
        Me.col_note.HeaderText = "Additional Note"
        Me.col_note.Name = "col_note"
        Me.col_note.ReadOnly = True
        '
        'btn_AddMed
        '
        Me.btn_AddMed.BorderRadius = 20
        Me.btn_AddMed.CheckedState.Parent = Me.btn_AddMed
        Me.btn_AddMed.CustomImages.Parent = Me.btn_AddMed
        Me.btn_AddMed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddMed.ForeColor = System.Drawing.Color.White
        Me.btn_AddMed.HoverState.Parent = Me.btn_AddMed
        Me.btn_AddMed.Location = New System.Drawing.Point(130, 339)
        Me.btn_AddMed.Name = "btn_AddMed"
        Me.btn_AddMed.ShadowDecoration.Parent = Me.btn_AddMed
        Me.btn_AddMed.Size = New System.Drawing.Size(137, 45)
        Me.btn_AddMed.TabIndex = 6
        Me.btn_AddMed.Text = "Add Medicine"
        '
        'btn_AddProc
        '
        Me.btn_AddProc.BorderRadius = 20
        Me.btn_AddProc.CheckedState.Parent = Me.btn_AddProc
        Me.btn_AddProc.CustomImages.Parent = Me.btn_AddProc
        Me.btn_AddProc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddProc.ForeColor = System.Drawing.Color.White
        Me.btn_AddProc.HoverState.Parent = Me.btn_AddProc
        Me.btn_AddProc.Location = New System.Drawing.Point(367, 339)
        Me.btn_AddProc.Name = "btn_AddProc"
        Me.btn_AddProc.ShadowDecoration.Parent = Me.btn_AddProc
        Me.btn_AddProc.Size = New System.Drawing.Size(137, 45)
        Me.btn_AddProc.TabIndex = 7
        Me.btn_AddProc.Text = "Add Procedure"
        '
        'rtb_Advice
        '
        Me.rtb_Advice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_Advice.Location = New System.Drawing.Point(29, 62)
        Me.rtb_Advice.Name = "rtb_Advice"
        Me.rtb_Advice.Size = New System.Drawing.Size(325, 250)
        Me.rtb_Advice.TabIndex = 5
        Me.rtb_Advice.Text = ""
        '
        'btn_ClearAdvice
        '
        Me.btn_ClearAdvice.BorderRadius = 20
        Me.btn_ClearAdvice.CheckedState.Parent = Me.btn_ClearAdvice
        Me.btn_ClearAdvice.CustomImages.Parent = Me.btn_ClearAdvice
        Me.btn_ClearAdvice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClearAdvice.ForeColor = System.Drawing.Color.White
        Me.btn_ClearAdvice.HoverState.Parent = Me.btn_ClearAdvice
        Me.btn_ClearAdvice.Location = New System.Drawing.Point(138, 339)
        Me.btn_ClearAdvice.Name = "btn_ClearAdvice"
        Me.btn_ClearAdvice.ShadowDecoration.Parent = Me.btn_ClearAdvice
        Me.btn_ClearAdvice.Size = New System.Drawing.Size(137, 45)
        Me.btn_ClearAdvice.TabIndex = 8
        Me.btn_ClearAdvice.Text = "Clear"
        '
        'frm_PrescriptionEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 606)
        Me.Controls.Add(Me.pnl_Right)
        Me.Controls.Add(Me.pnl_Left)
        Me.Controls.Add(Me.pnl_Footer)
        Me.Controls.Add(Me.pnl_Header)
        Me.Controls.Add(Me.pnl_TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_PrescriptionEditor"
        Me.Text = "frm_PrescriptionEditor"
        Me.pnl_TopBar.ResumeLayout(False)
        Me.pnl_TopBar.PerformLayout()
        CType(Me.img_TopBar_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctx_Main.ResumeLayout(False)
        Me.pnl_Header.ResumeLayout(False)
        Me.pnl_Header.PerformLayout()
        Me.pnl_Footer.ResumeLayout(False)
        Me.pnl_Left.ResumeLayout(False)
        Me.pnl_Left.PerformLayout()
        Me.pnl_Right.ResumeLayout(False)
        Me.pnl_Right.PerformLayout()
        CType(Me.dgv_PresTable, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_Date As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_Name As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_Age As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_Gender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tb_Date As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_Name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_Age As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_Gender As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnl_Header As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_Footer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl_Left As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_Prescription_Header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgv_PresTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents col_med As DataGridViewTextBoxColumn
    Friend WithEvents col_note As DataGridViewTextBoxColumn
    Friend WithEvents btn_AddProc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_AddMed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl_Right As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_Advice_Header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents rtb_Advice As RichTextBox
    Friend WithEvents btn_ClearAdvice As Guna.UI2.WinForms.Guna2Button
End Class
