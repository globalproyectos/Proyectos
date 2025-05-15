Public Class frmReporteHembrasEsperandoDestete
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim v_hembrasEsperandoDesteteTableAdapter As New dtsInformesGranjaTableAdapters.v_hembrasEsperandoDesteteTableAdapter
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Cursor = Cursors.WaitCursor
        v_hembrasEsperandoDesteteTableAdapter.Fill(odtsInformesGranja.v_hembrasEsperandoDestete, Me.codigoCerdaTextBoxX1.Text)

        Dim rpt As New rptHembrasEsperandoDestete
        rpt.SetDataSource(odtsInformesGranja.Tables("v_hembrasEsperandoDestete"))

        CrystalReportViewer1.ReportSource = rpt

        Me.Cursor = Cursors.Arrow
    End Sub
End Class