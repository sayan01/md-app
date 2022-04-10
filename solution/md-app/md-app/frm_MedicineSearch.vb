Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Public Class frm_MedicineSearch
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
        Me.Close()
    End Sub

    Private Sub InvokeCtx(sender As Object, e As EventArgs) _
    Handles img_TopBar_Logo.Click
        ctx_Main.Show(MousePosition.X + 2, MousePosition.Y + 2)
    End Sub

#End Region

    Dim DBPath As String
  ReadOnly TableName As String = "medicines"

  Private Sub LoadDB(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
        Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
        SQLiteDA.Fill(tbl)
        SQLiteDA.Dispose()
    End Sub
    Private Sub frm_MedicineSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBPath = "Data Source=" & Application.StartupPath & "\data.db;"
        Dim SQLiteCon As New SQLiteConnection(DBPath)
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            MsgBox("Error Opening Database: " & ex.Message)
            Exit Sub
        End Try
        Dim TableDB As New DataTable
        Try
      LoadDB("select * from " & TableName, TableDB, SQLiteCon)
      dgv_Medicines.DataSource = TableDB
        Catch ex As Exception
            MsgBox("Error loading database: " & ex.Message)
            Exit Sub
        Finally
            TableDB.Dispose()
            SQLiteCon.Dispose()
        End Try
    End Sub

  Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
    If dgv_Medicines.SelectedRows.Count <> 1 Then
      MsgBox("Select a Medicine first!")
      Exit Sub
    End If
    Dim row As DataRow = dgv_Medicines.SelectedRows(0).DataBoundItem.Row
    frm_PrescriptionEditor.dtb_med.Rows.Add(row(0).ToString, row(1).ToString, row(2).ToString, row(3).ToString)
    frm_PrescriptionEditor.dtb_consol.Rows.Add(
      row(1).ToString & " (" &
      row(2).ToString & " " &
      row(3).ToString & ")")
    Me.Hide()
  End Sub
End Class
