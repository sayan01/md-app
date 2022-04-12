Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Public Class frm_PrescriptionEditor

#Region " Top Panel "
#Region " Move Form "

  Public MoveForm As Boolean
  Public MoveForm_MousePosition As Point

  Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_TopBar.MouseDown
    If e.Button = MouseButtons.Left Then
      MoveForm = True
      MoveForm_MousePosition = e.Location
    End If

  End Sub

  Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_TopBar.MouseMove

    If MoveForm Then
      Me.Location += (e.Location - MoveForm_MousePosition)
    End If

  End Sub

  Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_TopBar.MouseUp
    If e.Button = MouseButtons.Left Then
      MoveForm = False
    End If

  End Sub
#End Region

  Private Sub CloseApp(sender As Object, e As EventArgs) _
    Handles btn_Close.Click, ctxItem_Exit.Click, img_TopBar_Logo.DoubleClick
    frm_UserHome.Show()
    Me.Close()
  End Sub

  Private Sub InvokeCtx(sender As Object, e As EventArgs) _
    Handles img_TopBar_Logo.Click
    ctx_Main.Show(MousePosition.X + 2, MousePosition.Y + 2)
  End Sub

#End Region

  Dim DBPath As String
  ReadOnly TableName As String = "visits"

  Private Sub LoadDB(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
    Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
    SQLiteDA.Fill(tbl)
    SQLiteDA.Dispose()
  End Sub

  Private Sub ExecuteNonQuery(ByVal query As String, ByVal cn As SQLiteConnection)
    Dim SQLiteCM As New SQLiteCommand(query, cn)
    SQLiteCM.ExecuteNonQuery()
    SQLiteCM.Dispose()
  End Sub

  Public dtb_med As New DataTable
  Public dtb_proc As New DataTable
  Public dtb_consol As New DataTable

  Private Sub ClearAdvice(sender As Object, e As EventArgs) Handles btn_ClearAdvice.Click
    rtb_Advice.Clear()
  End Sub

  Private Sub AddMedicine(sender As Object, e As EventArgs) Handles btn_AddMed.Click
    frm_MedicineSearch.Show()
  End Sub

  Private Sub btn_AddProc_Click(sender As Object, e As EventArgs) Handles btn_AddProc.Click
    frm_ProcedureSearch.Show()
  End Sub

  Private Sub frm_PrescriptionEditor_Load(sender As Object, e As EventArgs) Handles Me.Load

    ' Input boxes

    dtp_date.Value = DateTime.Now


    ' Data Tables

    dtb_med = New DataTable()
    dtb_proc = New DataTable()
    dtb_consol = New DataTable()

    dtb_med.Columns.Clear()
    dtb_med.Columns.Add("id", GetType(Integer))
    dtb_med.Columns.Add("name", GetType(String))
    dtb_med.Columns.Add("dosage", GetType(Integer))
    dtb_med.Columns.Add("unit", GetType(String))

    dtb_proc.Columns.Clear()
    dtb_proc.Columns.Add("id", GetType(Integer))
    dtb_proc.Columns.Add("name", GetType(String))

    dtb_consol.Columns.Clear()
    dtb_consol.Columns.Add("Medicines/Procedures", GetType(String))
    dtb_consol.Columns.Add("Additional Note", GetType(String))

    dgv_PresTable.DataSource = dtb_consol
    dgv_PresTable.Columns("Medicines/Procedures").ReadOnly = True
  End Sub

  Private Sub Next_Enabled_Check(sender As Object, e As EventArgs) _
    Handles tb_Name.TextChanged, dtp_date.ValueChanged, num_age.ValueChanged, cb_gender.SelectedIndexChanged
    If dtp_date.Value = Nothing Or
       tb_Name.Text = Nothing Or tb_Name.Text = "" Or
       num_age.Value = Nothing Or
       cb_gender.SelectedIndex = -1 Then
      btn_Save.Enabled = False
      btn_Print.Enabled = False
    Else
      btn_Save.Enabled = True
      btn_Print.Enabled = True
    End If
  End Sub
End Class
