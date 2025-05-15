Public Class frmReporteGraficoComparativoAlimentacion
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim LotesTableAdapter As New dtsInformesGranjaTableAdapters.LotesTableAdapter
    Dim rptGraficoComparativoAlimentacionTableAdapter As New dtsInformesGranjaTableAdapters.rptGraficoComparativoAlimentacionTableAdapter
    Private Sub frmReporteGraficoComparativoAlimentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlotes()
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

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            rptGraficoComparativoAlimentacionTableAdapter.Fill(odtsInformesGranja.rptGraficoComparativoAlimentacion, Me.LotesComboBoxEx1.Text)
            Dim rptGrafico As New rptGraficoComparativoAlimentacion
            rptGrafico.SetDataSource(odtsInformesGranja.Tables("rptGraficoComparativoAlimentacion"))
            Me.CrystalReportViewer1.ReportSource = rptGrafico

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow

        End Try
    End Sub
End Class