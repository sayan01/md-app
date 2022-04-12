Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography
Public Class frm_LoginAuth
  Dim DBPath As String
  ReadOnly TableName As String = "users"
  Public user_id, passwordhash, username, dept As String
  Public is_admin As Integer

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

    Private Sub frm_LoginAuth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function SHA512(ByVal input) As String
        Dim hash As Byte() = SHA512Managed.Create().ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim stringBuilder As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next
        Return stringBuilder.ToString
    End Function

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
    If tb_LoginAuth_Username.Text = Nothing _
        Or tb_LoginAuth_Username.Text = "" _
        Or tb_LoginAuth_Password.Text = Nothing _
        Or tb_LoginAuth_Password.Text = "" Then
      MsgBox("Invalid Username/Password")
      Exit Sub
    End If
    user_id = tb_LoginAuth_Username.Text.Trim()
        passwordhash = SHA512(tb_LoginAuth_Username.Text & tb_LoginAuth_Password.Text)
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
      LoadDB("select * from " & TableName & " where user_id='" & user_id & "'", TableDB, SQLiteCon)
      If TableDB.Rows.Count = 1 AndAlso TableDB.Rows(0)(1) = passwordhash Then
        Dim row As DataRow = TableDB.Rows(0)
        username = row(2)
        dept = row(3)
        is_admin = row(4)
        If is_admin = 0 Then
          frm_UserHome.Show()
          frm_MainMenu.Hide()
        Else
          frm_AdminHome.Show()
          frm_MainMenu.Hide()
        End If
      Else
        MsgBox("Username/Password invalid")
        MsgBox(passwordhash + " vs " + TableDB.Rows(0).Item(1))
        Exit Sub
      End If
    Catch ex As Exception
            MsgBox("Error loading database: " & ex.Message)
            Exit Sub
    Finally
      TableDB.Dispose()
      SQLiteCon.Dispose()
      tb_LoginAuth_Username.Text = Nothing
      tb_LoginAuth_Password.Text = Nothing
    End Try
  End Sub

End Class
