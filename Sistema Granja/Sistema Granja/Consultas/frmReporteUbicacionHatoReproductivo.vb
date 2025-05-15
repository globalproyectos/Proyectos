Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmReporteUbicacionHatoReproductivo
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim orptInventarioGranja As New dtsInformesGranja
    Dim oProc_ReporteUbicacionHatoReproductivo As New dtsInformesGranjaTableAdapters.Proc_ReporteUbicacionHatoReproductivoTableAdapter
    Private Sub frmReporteUbicacionHatoReproductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            oProc_ReporteUbicacionHatoReproductivo.Fill(orptInventarioGranja.Proc_ReporteUbicacionHatoReproductivo, RTrim(Me.LoteNoTextBoxX1.Text), RTrim(Me.CodigoTextBoxX2.Text))
            Dim rptUbicacionesHato As New rptUbicacionHatoReproductivo
            rptUbicacionesHato.SetDataSource(orptInventarioGranja.Tables("Proc_ReporteUbicacionHatoReproductivo"))
            Me.CrystalReportViewer1.ReportSource = rptUbicacionesHato
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class