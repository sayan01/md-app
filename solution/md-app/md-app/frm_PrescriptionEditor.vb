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
    Me.Close()
  End Sub

  Private Sub InvokeCtx(sender As Object, e As EventArgs) _
    Handles img_TopBar_Logo.Click
    ctx_Main.Show(MousePosition.X + 2, MousePosition.Y + 2)
  End Sub

#End Region


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
    dtb_med.Columns.Add("id", GetType(Integer))
    dtb_med.Columns.Add("name", GetType(String))
    dtb_med.Columns.Add("dosage", GetType(Integer))
    dtb_med.Columns.Add("unit", GetType(String))

    dtb_proc.Columns.Add("id", GetType(Integer))
    dtb_proc.Columns.Add("name", GetType(String))

    dtb_consol.Columns.Add("Medicines/Procedures", GetType(String))
    dtb_consol.Columns.Add("Additional Note", GetType(String))

    dtb_med.Rows.Add(1, "Paracetamol", 100, "gm")
    dtb_med.Rows.Add(2, "Norfloxacin", 100, "gm")

    dtb_proc.Rows.Add(1, "Functional Magnetic Resonance Imaging (FMRI)")

    For Each row As DataRow In dtb_med.Rows
      dtb_consol.Rows.Add(row(1).ToString & " (" & row(2).ToString & " " & row(3).ToString & ")")
    Next

    For Each row As DataRow In dtb_proc.Rows
      dtb_consol.Rows.Add(row(1))
    Next

    dgv_PresTable.DataSource = dtb_consol
  End Sub
End Class
