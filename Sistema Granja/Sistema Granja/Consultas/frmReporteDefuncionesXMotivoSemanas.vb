Imports DevComponents.DotNetBar
Public Class frmReporteDefuncionesXMotivoSemanas
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim odtsInformesGranja As New dtsInformesGranja
            Dim procReporteAdapter As New dtsInformesGranjaTableAdapters.Proc_ReporteDefuncionesXMotivoSemanasTableAdapter
            Dim rpt As New rptDefuncionesXMotivoSemana
            procReporteAdapter.Fill(odtsInformesGranja.Proc_ReporteDefuncionesXMotivoSemanas, fechaDesdeDateTimeInput1.Text, fechaHastaDateTimeInput1.Text, loteNoTextBoxX1.Text)
            rpt.SetDataSource(odtsInformesGranja.Tables("Proc_ReporteDefuncionesXMotivoSemanas"))
            Me.CrystalReportViewer1.ReportSource = rpt
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBoxEx.Show(ex.Message, "Error al generar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub
End Class