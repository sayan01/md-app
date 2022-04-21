Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Public Class frm_PatHist

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
    If frm_LoginAuth.is_admin = 0 Then
      frm_UserHome.Show()
    Else
      frm_AdminHome.Show()
    End If
    Me.Close()
  End Sub

  Private Sub InvokeCtx(sender As Object, e As EventArgs) _
    Handles img_TopBar_Logo.Click
    ctx_Main.Show(MousePosition.X + 2, MousePosition.Y + 2)
  End Sub

#End Region


  Dim DBPath As String
  ReadOnly TableName As String = "visits"
  Dim TableDB As New DataTable
  Dim visit_id As Integer = -1


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

  Private Sub LoadTable(sender As Object, e As EventArgs) _
    Handles tb_SearchInput.TextChanged, MyBase.Load
    DBPath = "Data Source=" & Application.StartupPath & "\data.db;"
    Dim SQLiteCon As New SQLiteConnection(DBPath)
    Try
      SQLiteCon.Open()
    Catch ex As Exception
      SQLiteCon.Dispose()
      MsgBox("Error Opening Database: " & ex.Message)
      Exit Sub
    End Try
    Try
      TableDB.Clear()
      LoadDB("select * from " & TableName & " where ( patient_name like '%" &
               tb_SearchInput.Text.Trim().ToLower() &
               "%' or  patient_age like '%" &
               tb_SearchInput.Text.Trim().ToLower() &
               "%' or  patient_gender like '%" &
               tb_SearchInput.Text.Trim().ToLower() &
               "%' or date like '%" &
               tb_SearchInput.Text.Trim().ToLower() &
               If(frm_LoginAuth.is_admin = 0, "%' ) and user_id = '" & frm_LoginAuth.user_id & "'", "%' )") _
               & "order by date desc" _
             , TableDB, SQLiteCon)
      dgv_Visits.DataSource = TableDB
      If dgv_Visits.Columns.Count <> 0 Then
        dgv_Visits.Columns(0).Visible = False
      End If
      dgv_Visits.ClearSelection()
    Catch ex As Exception
      MsgBox("Error loading database: " & ex.Message)
      Exit Sub
    Finally
      TableDB.Dispose()
      SQLiteCon.Dispose()
    End Try
  End Sub



End Class
