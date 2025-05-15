Public Class frmReporteGraficoComparativoAlimentacionPorFecha
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim LotesTableAdapter As New dtsInformesGranjaTableAdapters.LotesTableAdapter
    Dim Proc_ReporteComparativoAlimentacionGrafico_PorFechaTableAdapter As New dtsInformesGranjaTableAdapters.Proc_ReporteComparativoAlimentacionGrafico_PorFechaTableAdapter
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Proc_ReporteComparativoAlimentacionGrafico_PorFechaTableAdapter.Fill(odtsInformesGranja.Proc_ReporteComparativoAlimentacionGrafico_PorFecha, Me.LotesComboBoxEx1.Text, Me.fechadesdeDateTimeInput1.Text, fechahastaDateTimeInput1.Text)
            Dim rptGraficoPorFecha As New rptGraficoComparativoAlimentacionPorFecha
            rptGraficoPorFecha.SetDataSource(odtsInformesGranja.Tables("Proc_ReporteComparativoAlimentacionGrafico_PorFecha"))

            Me.CrystalReportViewer1.ReportSource = rptGraficoPorFecha
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarlotes()
        Try
            Me.LotesComboBoxEx1.DataSource = LotesTableAdapter.GetData()
            Me.LotesComboBoxEx1.DisplayMember = "Lote_No"
            Me.LotesComboBoxEx1.ValueMember = "Lote_No"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmReporteGraficoComparativoAlimentacionPorFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlotes()
    End Sub
End Class