Public Class frmReporteCelosCerdas
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If IsDate(Me.desdeDateTimeInput1.Text) And IsDate(Me.hastaDateTimeInput2.Text) Then
            Me.Cursor = Cursors.WaitCursor
            Dim rpt As New rptCelosCerdasAgrupado
            Dim odts As New dtsInformesGranja
            Dim repCelosAdapter As New dtsInformesGranjaTableAdapters.Proc_ReporteCelosAgrupadoTableAdapter
            repCelosAdapter.Fill(odts.Proc_ReporteCelosAgrupado, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text)
            rpt.SetDataSource(odts.Tables("Proc_ReporteCelosAgrupado"))
            Me.CrystalReportViewer1.ReportSource = rpt

            Me.Cursor = Cursors.Arrow
        End If
    End Sub
End Class