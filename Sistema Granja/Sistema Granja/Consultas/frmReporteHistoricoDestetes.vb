Public Class frmReporteHistoricoDestetes
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim rptHistoricoDesteteTableAdapter As New dtsInformesGranjaTableAdapters.rptHistoricoDesteteTableAdapter
    Private Sub frmReporteHistoricoDestetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            rptHistoricoDesteteTableAdapter.Fill(odtsInformesGranja.rptHistoricoDestete, Me.LoteNoTextBoxX1.Text)
            Dim rptHistoricoDestete As New rptHistoricoDestete
            rptHistoricoDestete.SetDataSource(odtsInformesGranja.Tables("rptHistoricoDestete"))
            Me.CrystalReportViewer1.ReportSource = rptHistoricoDestete
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class