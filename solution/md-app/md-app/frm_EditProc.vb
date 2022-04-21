Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Public Class frm_EditProc
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
    frm_AdminHome.Show()
    Me.Close()
  End Sub

  Private Sub InvokeCtx(sender As Object, e As EventArgs) _
    Handles img_TopBar_Logo.Click
      ctx_Main.Show(MousePosition.X + 2, MousePosition.Y + 2)
    End Sub

#End Region

  Dim DBPath As String
  ReadOnly TableName As String = "procedures"
  Dim TableDB As New DataTable
  Dim proc_id As Integer = -1


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
        LoadDB("select * from " & TableName & " where name like '%" &
               tb_SearchInput.Text.Trim().ToLower() &
               "%'", TableDB, SQLiteCon)
      dgv_Procedures.DataSource = TableDB
      If dgv_Procedures.Columns.Count <> 0 Then
        dgv_Procedures.Columns(0).Visible = False
      End If
      dgv_Procedures.ClearSelection()
    Catch ex As Exception
      MsgBox("Error loading database: " & ex.Message)
      Exit Sub
    Finally
      TableDB.Dispose()
      SQLiteCon.Dispose()
    End Try
  End Sub

  Private Sub SelectProc(sender As Object, e As EventArgs) _
    Handles dgv_Procedures.CellClick
    If dgv_Procedures.SelectedRows.Count <> 1 Then
      MsgBox("Select a Procedure first!")
      Exit Sub
    End If
    Dim row As DataRow = dgv_Procedures.SelectedRows(0).DataBoundItem.Row
    Try
      proc_id = row("procedure_id")
      tb_procname.Text = row("name")
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub UpdateProc(sender As Object, e As EventArgs) Handles btn_update.Click
    If proc_id = -1 Then
      MsgBox("Select a row to update first")
      Exit Sub
    End If
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
      ExecuteNonQuery("update " & TableName &
                      " set name = '" & tb_procname.Text.Trim() & "'" &
                      " where procedure_id = '" & proc_id & "'",
                      SQLiteCon)
      LoadTable(sender, e)
    Catch ex As Exception
      MsgBox("Error updating database: " & ex.Message)
      Exit Sub
    Finally
      TableDB.Dispose()
      SQLiteCon.Dispose()
      tb_procname.Text = ""
      tb_SearchInput.Text = ""
      proc_id = -1
      dgv_Procedures.ClearSelection()
    End Try
  End Sub

  Private Sub InsertProc(sender As Object, e As EventArgs) Handles btn_new.Click
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
      ExecuteNonQuery("insert into " & TableName & "(name) values('" &
                      tb_procname.Text.Trim() &
                      "')", SQLiteCon)
      LoadTable(sender, e)
    Catch ex As Exception
      MsgBox("Error inserting database: " & ex.Message)
      Exit Sub
    Finally
      TableDB.Dispose()
      SQLiteCon.Dispose()
      tb_procname.Text = ""
      tb_SearchInput.Text = ""
      proc_id = -1
      dgv_Procedures.ClearSelection()
    End Try
  End Sub

  Private Sub DeleteProc(sender As Object, e As EventArgs) Handles btn_delete.Click
    If proc_id = -1 Then
      MsgBox("Select a row to delete first")
      Exit Sub
    End If
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
      ExecuteNonQuery("delete from " & TableName & " where procedure_id='" & proc_id & "'", SQLiteCon)
      LoadTable(sender, e)
    Catch ex As Exception
      MsgBox("Error deleting database: " & ex.Message)
      Exit Sub
    Finally
      TableDB.Dispose()
      SQLiteCon.Dispose()
      tb_procname.Text = ""
      tb_SearchInput.Text = ""
      proc_id = -1
      dgv_Procedures.ClearSelection()
    End Try
  End Sub

End Class
