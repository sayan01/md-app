<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_PrescriptionPrintLayout
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PrescriptionPrintLayout))
        Me.lbl_Heading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_PatientName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_PatientAge = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_PatientGender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_Doctor = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_Date = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.rtb_DoctorAdvice = New System.Windows.Forms.RichTextBox()
        Me.dgv_Prescriptions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tb_Name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Age = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Gender = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Doctor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Date = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pb_RX = New System.Windows.Forms.PictureBox()
        Me.lbl_Prescriptions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.printPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.printDocument = New System.Drawing.Printing.PrintDocument()
        Me.pb_Logo = New System.Windows.Forms.PictureBox()
        Me.pnl_parent = New System.Windows.Forms.Panel()
        CType(Me.dgv_Prescriptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_RX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_parent.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lbl_Heading.Location = New System.Drawing.Point(251, -12)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(132, 89)
        Me.lbl_Heading.TabIndex = 0
        Me.lbl_Heading.Text = "<h1>MD-APP</h1>"
        '
        'lbl_PatientName
        '
        Me.lbl_PatientName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PatientName.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lbl_PatientName.Location = New System.Drawing.Point(15, 88)
        Me.lbl_PatientName.Name = "lbl_PatientName"
        Me.lbl_PatientName.Size = New System.Drawing.Size(40, 18)
        Me.lbl_PatientName.TabIndex = 0
        Me.lbl_PatientName.Text = "Name"
        '
        'lbl_PatientAge
        '
        Me.lbl_PatientAge.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PatientAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PatientAge.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lbl_PatientAge.Location = New System.Drawing.Point(337, 88)
        Me.lbl_PatientAge.Name = "lbl_PatientAge"
        Me.lbl_PatientAge.Size = New System.Drawing.Size(28, 18)
        Me.lbl_PatientAge.TabIndex = 0
        Me.lbl_PatientAge.Text = "Age"
        '
        'lbl_PatientGender
        '
        Me.lbl_PatientGender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PatientGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PatientGender.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lbl_PatientGender.Location = New System.Drawing.Point(455, 88)
        Me.lbl_PatientGender.Name = "lbl_PatientGender"
        Me.lbl_PatientGender.Size = New System.Drawing.Size(48, 18)
        Me.lbl_PatientGender.TabIndex = 0
        Me.lbl_PatientGender.Text = "Gender"
        '
        'lbl_Doctor
        '
        Me.lbl_Doctor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Doctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Doctor.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lbl_Doctor.Location = New System.Drawing.Point(15, 131)
        Me.lbl_Doctor.Name = "lbl_Doctor"
        Me.lbl_Doctor.Size = New System.Drawing.Size(43, 18)
        Me.lbl_Doctor.TabIndex = 0
        Me.lbl_Doctor.Text = "Doctor"
        '
        'lbl_Date
        '
        Me.lbl_Date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lbl_Date.Location = New System.Drawing.Point(436, 131)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(32, 18)
        Me.lbl_Date.TabIndex = 0
        Me.lbl_Date.Text = "Date"
        '
        'rtb_DoctorAdvice
        '
        Me.rtb_DoctorAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtb_DoctorAdvice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_DoctorAdvice.Location = New System.Drawing.Point(18, 762)
        Me.rtb_DoctorAdvice.Name = "rtb_DoctorAdvice"
        Me.rtb_DoctorAdvice.Size = New System.Drawing.Size(593, 121)
        Me.rtb_DoctorAdvice.TabIndex = 0
        Me.rtb_DoctorAdvice.Text = ""
        '
        'dgv_Prescriptions
        '
        Me.dgv_Prescriptions.AllowUserToAddRows = False
        Me.dgv_Prescriptions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv_Prescriptions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Prescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Prescriptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Prescriptions.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Prescriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Prescriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Prescriptions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Prescriptions.ColumnHeadersHeight = 15
        Me.dgv_Prescriptions.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Prescriptions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Prescriptions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_Prescriptions.EnableHeadersVisualStyles = False
        Me.dgv_Prescriptions.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Prescriptions.Location = New System.Drawing.Point(18, 197)
        Me.dgv_Prescriptions.Name = "dgv_Prescriptions"
        Me.dgv_Prescriptions.ReadOnly = True
        Me.dgv_Prescriptions.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Prescriptions.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Prescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Prescriptions.Size = New System.Drawing.Size(593, 535)
        Me.dgv_Prescriptions.TabIndex = 0
        Me.dgv_Prescriptions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_Prescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Prescriptions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_Prescriptions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_Prescriptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_Prescriptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_Prescriptions.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Prescriptions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Prescriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Prescriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Prescriptions.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Prescriptions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_Prescriptions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_Prescriptions.ThemeStyle.HeaderStyle.Height = 15
        Me.dgv_Prescriptions.ThemeStyle.ReadOnly = True
        Me.dgv_Prescriptions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Prescriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Prescriptions.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Prescriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_Prescriptions.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_Prescriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Prescriptions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.tb_Name.ForeColor = System.Drawing.Color.Black
        Me.tb_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Name.HoverState.Parent = Me.tb_Name
        Me.tb_Name.Location = New System.Drawing.Point(76, 83)
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Name.PlaceholderText = ""
        Me.tb_Name.SelectedText = ""
        Me.tb_Name.ShadowDecoration.Parent = Me.tb_Name
        Me.tb_Name.Size = New System.Drawing.Size(249, 27)
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
        Me.tb_Age.ForeColor = System.Drawing.Color.Black
        Me.tb_Age.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Age.HoverState.Parent = Me.tb_Age
        Me.tb_Age.Location = New System.Drawing.Point(374, 83)
        Me.tb_Age.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.tb_Age.Name = "tb_Age"
        Me.tb_Age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Age.PlaceholderText = ""
        Me.tb_Age.SelectedText = ""
        Me.tb_Age.ShadowDecoration.Parent = Me.tb_Age
        Me.tb_Age.Size = New System.Drawing.Size(72, 27)
        Me.tb_Age.TabIndex = 1
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
        Me.tb_Gender.ForeColor = System.Drawing.Color.Black
        Me.tb_Gender.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Gender.HoverState.Parent = Me.tb_Gender
        Me.tb_Gender.Location = New System.Drawing.Point(512, 83)
        Me.tb_Gender.Margin = New System.Windows.Forms.Padding(13, 16, 13, 16)
        Me.tb_Gender.Name = "tb_Gender"
        Me.tb_Gender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Gender.PlaceholderText = ""
        Me.tb_Gender.SelectedText = ""
        Me.tb_Gender.ShadowDecoration.Parent = Me.tb_Gender
        Me.tb_Gender.Size = New System.Drawing.Size(99, 27)
        Me.tb_Gender.TabIndex = 1
        '
        'tb_Doctor
        '
        Me.tb_Doctor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Doctor.DefaultText = ""
        Me.tb_Doctor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Doctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Doctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Doctor.DisabledState.Parent = Me.tb_Doctor
        Me.tb_Doctor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Doctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Doctor.FocusedState.Parent = Me.tb_Doctor
        Me.tb_Doctor.ForeColor = System.Drawing.Color.Black
        Me.tb_Doctor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Doctor.HoverState.Parent = Me.tb_Doctor
        Me.tb_Doctor.Location = New System.Drawing.Point(76, 127)
        Me.tb_Doctor.Margin = New System.Windows.Forms.Padding(28, 37, 28, 37)
        Me.tb_Doctor.Name = "tb_Doctor"
        Me.tb_Doctor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Doctor.PlaceholderText = ""
        Me.tb_Doctor.SelectedText = ""
        Me.tb_Doctor.ShadowDecoration.Parent = Me.tb_Doctor
        Me.tb_Doctor.Size = New System.Drawing.Size(249, 29)
        Me.tb_Doctor.TabIndex = 1
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
        Me.tb_Date.ForeColor = System.Drawing.Color.Black
        Me.tb_Date.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Date.HoverState.Parent = Me.tb_Date
        Me.tb_Date.Location = New System.Drawing.Point(480, 127)
        Me.tb_Date.Margin = New System.Windows.Forms.Padding(61, 85, 61, 85)
        Me.tb_Date.Name = "tb_Date"
        Me.tb_Date.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Date.PlaceholderText = ""
        Me.tb_Date.SelectedText = ""
        Me.tb_Date.ShadowDecoration.Parent = Me.tb_Date
        Me.tb_Date.Size = New System.Drawing.Size(131, 29)
        Me.tb_Date.TabIndex = 1
        '
        'pb_RX
        '
        Me.pb_RX.Image = Global.md_app.My.Resources.Resources.rx
        Me.pb_RX.Location = New System.Drawing.Point(15, 14)
        Me.pb_RX.Name = "pb_RX"
        Me.pb_RX.Size = New System.Drawing.Size(55, 55)
        Me.pb_RX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_RX.TabIndex = 2
        Me.pb_RX.TabStop = False
        '
        'lbl_Prescriptions
        '
        Me.lbl_Prescriptions.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Prescriptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prescriptions.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lbl_Prescriptions.Location = New System.Drawing.Point(18, 173)
        Me.lbl_Prescriptions.Name = "lbl_Prescriptions"
        Me.lbl_Prescriptions.Size = New System.Drawing.Size(74, 18)
        Me.lbl_Prescriptions.TabIndex = 0
        Me.lbl_Prescriptions.Text = "Prescription"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(18, 738)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(98, 18)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Doctor's Advice"
        '
        'printPreviewDialog
        '
        Me.printPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialog.Document = Me.printDocument
        Me.printPreviewDialog.Enabled = True
        Me.printPreviewDialog.Icon = CType(resources.GetObject("printPreviewDialog.Icon"), System.Drawing.Icon)
        Me.printPreviewDialog.Name = "printPreviewDialog"
        Me.printPreviewDialog.Visible = False
        '
        'printDocument
        '
        '
        'pb_Logo
        '
        Me.pb_Logo.Image = CType(resources.GetObject("pb_Logo.Image"), System.Drawing.Image)
        Me.pb_Logo.Location = New System.Drawing.Point(566, 16)
        Me.pb_Logo.Name = "pb_Logo"
        Me.pb_Logo.Size = New System.Drawing.Size(55, 55)
        Me.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Logo.TabIndex = 3
        Me.pb_Logo.TabStop = False
        '
        'pnl_parent
        '
        Me.pnl_parent.AutoSize = True
        Me.pnl_parent.Controls.Add(Me.pb_RX)
        Me.pnl_parent.Controls.Add(Me.pb_Logo)
        Me.pnl_parent.Controls.Add(Me.lbl_Heading)
        Me.pnl_parent.Controls.Add(Me.rtb_DoctorAdvice)
        Me.pnl_parent.Controls.Add(Me.lbl_PatientGender)
        Me.pnl_parent.Controls.Add(Me.dgv_Prescriptions)
        Me.pnl_parent.Controls.Add(Me.lbl_PatientAge)
        Me.pnl_parent.Controls.Add(Me.tb_Date)
        Me.pnl_parent.Controls.Add(Me.lbl_PatientName)
        Me.pnl_parent.Controls.Add(Me.tb_Gender)
        Me.pnl_parent.Controls.Add(Me.tb_Name)
        Me.pnl_parent.Controls.Add(Me.tb_Doctor)
        Me.pnl_parent.Controls.Add(Me.tb_Age)
        Me.pnl_parent.Controls.Add(Me.lbl_Date)
        Me.pnl_parent.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnl_parent.Controls.Add(Me.lbl_Doctor)
        Me.pnl_parent.Controls.Add(Me.lbl_Prescriptions)
        Me.pnl_parent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_parent.Location = New System.Drawing.Point(0, 0)
        Me.pnl_parent.Name = "pnl_parent"
        Me.pnl_parent.Size = New System.Drawing.Size(630, 891)
        Me.pnl_parent.TabIndex = 4
        '
        'frm_PrescriptionPrintLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(630, 891)
        Me.Controls.Add(Me.pnl_parent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_PrescriptionPrintLayout"
        Me.Text = "frm_PrescriptionPrintLayout"
        CType(Me.dgv_Prescriptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_RX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_parent.ResumeLayout(False)
        Me.pnl_parent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Heading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_PatientName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_PatientAge As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_PatientGender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_Doctor As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_Date As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tb_Gender As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_Age As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_Name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgv_Prescriptions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents rtb_DoctorAdvice As RichTextBox
    Friend WithEvents tb_Date As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_Doctor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pb_RX As PictureBox
    Friend WithEvents lbl_Prescriptions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents printPreviewDialog As PrintPreviewDialog
    Friend WithEvents printDocument As Printing.PrintDocument
    Friend WithEvents pb_Logo As PictureBox
    Friend WithEvents pnl_parent As Panel
End Class
