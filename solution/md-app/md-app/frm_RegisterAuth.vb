Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography
Public Class frm_RegisterAuth
  Dim DBPath As String
  ReadOnly TableName As String = "users"
  Dim user_id, passwordhash, username, dept As String
  Dim is_admin As Integer

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

  Private Function SHA512(ByVal input) As String
    Dim hash As Byte() = SHA512Managed.Create().ComputeHash(Encoding.UTF8.GetBytes(input))
    Dim stringBuilder As New StringBuilder()
    For i As Integer = 0 To hash.Length - 1
      stringBuilder.Append(hash(i).ToString("X2"))
    Next
    Return stringBuilder.ToString
  End Function

  Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
    If tb_RegisterAuth_Username.Text = Nothing _
        Or tb_RegisterAuth_Username.Text = "" _
        Or tb_RegisterAuth_Password.Text = Nothing _
        Or tb_RegisterAuth_Password.Text = "" _
        Or tb_RegisterAuth_Name.Text = Nothing _
        Or tb_RegisterAuth_Name.Text = "" Then
      MsgBox("Fill all the required fields")
      Exit Sub
    End If
    user_id = tb_RegisterAuth_Username.Text.Trim()
    passwordhash = SHA512(tb_RegisterAuth_Username.Text & tb_RegisterAuth_Password.Text)
    username = tb_RegisterAuth_Name.Text
    dept = tb_RegisterAuth_Dept.Text
    is_admin = If(chkbx_RegisterAuth_is_admin.Checked, 1, 0)

    If user_id.Length > 16 Then
      MsgBox("Username can be 16 characters at max")
      Exit Sub
    End If

    If username.Length > 50 Then
      MsgBox("Name can be 50 characters at max")
      Exit Sub
    End If

    If dept.Length > 15 Then
      MsgBox("Department can be 15 characters at max")
      Exit Sub
    End If

    DBPath = "Data Source=" & Application.StartupPath & "\data.db;"
    Dim SQLiteCon As New SQLiteConnection(DBPath)
    Try
      SQLiteCon.Open()
    Catch ex As Exception
      SQLiteCon.Dispose()
      MsgBox("Error connecting to database:" & ex.Message)
      Exit Sub
    End Try
    Try
      ExecuteNonQuery("insert into users values('" &
                      user_id &
                      "','" & passwordhash &
                      "','" & username &
                      "','" & dept &
                      "','" & is_admin &
                      "');", SQLiteCon)
      MsgBox(If(is_admin = 1, "Admin", "User") & " Registered Successfully")
    Catch ex As Exception
      If ex.Message.Contains("UNIQUE") Then
        MsgBox("Username is already registered")
      Else
        MsgBox("Error Registering User: " & ex.Message)
      End If
      Exit Sub
    Finally
      tb_RegisterAuth_Dept.Text = Nothing
      tb_RegisterAuth_Name.Text = Nothing
      tb_RegisterAuth_Password.Text = Nothing
      tb_RegisterAuth_Username.Text = Nothing
      SQLiteCon.Dispose()
    End Try
  End Sub

  Private Sub tb_RegisterAuth_KeyDown(sender As Object, e As KeyEventArgs) _
   Handles tb_RegisterAuth_Dept.KeyDown, tb_RegisterAuth_Name.KeyDown, tb_RegisterAuth_Password.KeyDown,
   tb_RegisterAuth_Username.KeyDown
    If e.KeyCode = Keys.Enter Then
      btn_Register_Click(sender, e)
    End If
  End Sub

End Class
