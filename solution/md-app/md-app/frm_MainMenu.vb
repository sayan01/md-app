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
    Application.Exit()
  End Sub

  Private Sub InvokeCtx(sender As Object, e As EventArgs) _
    Handles img_TopBar_Logo.Click
    ctx_Main.Show(MousePosition.X + 2, MousePosition.Y + 2)
  End Sub

#End Region

#Region "Embed Auth Forms"

  Dim AuthForm As Form
  Dim AuthState As Integer = 0

  Private Sub AuthPageLoad(sender As Object, e As EventArgs) _
    Handles Me.Load
    With frm_LoginAuth
      .TopLevel = False
      pnl_Auth.Controls.Add(frm_LoginAuth)
      .Dock = DockStyle.Fill
      .BringToFront()
      .Show()
      AuthForm = frm_LoginAuth
    End With
    lbl_ToggleAuthText.Text = "New User? Register instead"
    btn_ToggleAuth.Text = "Register"
    AuthState = 0
  End Sub

  Private Sub ToggleAuth(sender As Object, e As EventArgs) _
    Handles btn_ToggleAuth.Click
    If AuthState = 0 Then
      AuthState = 1
      AuthForm.Close()
      With frm_RegisterAuth
        .TopLevel = False
        pnl_Auth.Controls.Clear()
        pnl_Auth.Controls.Add(frm_RegisterAuth)
        .Dock = DockStyle.Fill
        .BringToFront()
        .Show()
        AuthForm = frm_RegisterAuth
      End With

      lbl_ToggleAuthText.Text = "Already Registered? Login Instead"
      btn_ToggleAuth.Text = "Login"
    Else
      AuthState = 0
      AuthForm.Close()
      With frm_LoginAuth
        .TopLevel = False
        pnl_Auth.Controls.Clear()
        pnl_Auth.Controls.Add(frm_LoginAuth)
        .Dock = DockStyle.Fill
        .BringToFront()
        .Show()
        AuthForm = frm_LoginAuth
      End With

      lbl_ToggleAuthText.Text = "New User? Register instead"
      btn_ToggleAuth.Text = "Register"
    End If
  End Sub


#End Region
End Class
