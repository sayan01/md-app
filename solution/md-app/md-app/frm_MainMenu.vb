Public Class frm_MainMenu

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

#Region "Embed Auth Forms"

  Dim AuthForm As Form
  Dim AuthState As Integer = 0 ' 0 means login, 1 means registration

  Private Sub SetAuthForm(frm As Form, lblText As String, btnText As String)
    With frm
      .TopLevel = False
      pnl_Auth.Controls.Clear()
      pnl_Auth.Controls.Add(frm)
      .Dock = DockStyle.Fill
      .BringToFront()
      .Show()
      AuthForm = frm
    End With
    lbl_ToggleAuthText.Text = lblText
    btn_ToggleAuth.Text = btnText
  End Sub

  Private Sub AuthPageLoad(sender As Object, e As EventArgs) _
    Handles Me.Load
    SetAuthForm(frm_LoginAuth, "New User? Register instead", "Register")
    AuthState = 0
  End Sub

  Private Sub ToggleAuth(sender As Object, e As EventArgs) _
    Handles btn_ToggleAuth.Click
    If AuthForm IsNot Nothing Then
      AuthForm.Close()
    End If
    If AuthState = 0 Then
      SetAuthForm(frm_RegisterAuth, "Already Registered? Login Instead", "Login")
    Else
      SetAuthForm(frm_LoginAuth, "New User? Register instead", "Register")
    End If
    AuthState = AuthState Xor 1
  End Sub
#End Region
End Class
