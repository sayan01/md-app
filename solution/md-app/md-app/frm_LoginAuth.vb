Public Class frm_LoginAuth
  Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
    Dim frm_Prescription As New frm_PrescriptionEditor
    frm_Prescription.Show()
  End Sub
End Class
