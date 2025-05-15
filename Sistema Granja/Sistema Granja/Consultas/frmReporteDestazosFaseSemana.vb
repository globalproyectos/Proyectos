Public Class frmReporteDestazosFaseSemana
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim reporteSalidasTableAdapter As New dtsInformesGranjaTableAdapters.reporteSalidasTableAdapter
    Dim LotesFiltroDinamicoSalidasTableAdapter As New dtsInformesGranjaTableAdapters.LotesFiltroDinamicoSalidasTableAdapter
    Dim Tipos_SalidasTableAdapter As New dtsInformesGranjaTableAdapters.Tipos_SalidasTableAdapter
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        With SFD
            .Filter = "Archivo de Excel|*.xlsx| Archivo en PDF|*.pdf"
            If .ShowDialog = DialogResult.OK Then

                If .FileName.Contains(".xlsx") Then
                    Me.PivotGridControl1.ExportToXlsx(.FileName)

                ElseIf .FileName.Contains(".pdf") Then
                    Me.PivotGridControl1.ExportToPdf(.FileName)
                End If
                MessageBox.Show("Reporte exportado correctamente", "Exportar a archivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End With
    End Sub
    Sub cargarlotesfiltro()
        Try
            If IsDate(Me.desdeDateTimeInput1.Text) And IsDate(Me.hastaDateTimeInput2.Text) Then
                Me.lotesComboBox1.DataSource = LotesFiltroDinamicoSalidasTableAdapter.GetData(Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text)
                Me.lotesComboBox1.DisplayMember = "Descripcion"
                Me.lotesComboBox1.ValueMember = "Lote_No"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error filtro lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub desdeDateTimeInput1_TextChanged(sender As Object, e As EventArgs) Handles desdeDateTimeInput1.TextChanged
        cargarlotesfiltro()
    End Sub
    Private Sub hastaDateTimeInput2_TextChanged(sender As Object, e As EventArgs) Handles hastaDateTimeInput2.TextChanged
        cargarlotesfiltro()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            reporteSalidasTableAdapter.Fill(odtsInformesGranja.reporteSalidas, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, "DZ", "", Me.lotesComboBox1.SelectedValue, 0, UsuarioActual)
            Me.PivotGridControl1.DataSource = odtsInformesGranja.reporteSalidas
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmReporteDestazosFaseSemana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargartiposalidas()
    End Sub
End Class