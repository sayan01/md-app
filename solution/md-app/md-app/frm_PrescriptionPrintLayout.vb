Public Class frm_PrescriptionPrintLayout
  Public bmp As Bitmap
  Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDocument.PrintPage
    'e.Graphics.DrawImage(bmp, 0, 0)
    Dim dm As New Bitmap(pnl_parent.Width, pnl_parent.Height)
    pnl_parent.DrawToBitmap(dm, New Rectangle(0, 0, pnl_parent.Width, pnl_parent.Height))
    e.Graphics.DrawImage(dm, 0, 0)

    Dim asp As New PageSetupDialog
    asp.Document = printDocument
  End Sub
End Class
