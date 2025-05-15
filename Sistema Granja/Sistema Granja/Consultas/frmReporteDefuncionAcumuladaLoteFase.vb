Public Class frmReporteDefuncionAcumuladaLoteFase
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim LotesFiltroRepDefFasesTableAdapter As New dtsInformesGranjaTableAdapters.LotesFiltroRepDefFasesTableAdapter
    Dim ReporteDefuncionesFasesTableAdapter As New dtsInformesGranjaTableAdapters.ReporteDefuncionesFasesTableAdapter

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
    Sub mostrarlotesfiltros()
        Try
            If IsDate(Me.desdeDateTimeInput1.Text) And IsDate(Me.hastaDateTimeInput2.Text) Then
                Me.lotesComboBox1.DataSource = LotesFiltroRepDefFasesTableAdapter.GetData(Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text)
                Me.lotesComboBox1.DisplayMember = "descripcion"
                Me.lotesComboBox1.ValueMember = "lote_no"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub desdeDateTimeInput1_TextChanged(sender As Object, e As EventArgs) Handles desdeDateTimeInput1.TextChanged
        mostrarlotesfiltros()
    End Sub

    Private Sub hastaDateTimeInput2_TextChanged(sender As Object, e As EventArgs) Handles hastaDateTimeInput2.TextChanged
        mostrarlotesfiltros()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            ReporteDefuncionesFasesTableAdapter.Fill(odtsInformesGranja.ReporteDefuncionesFases, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, Trim(Me.lotesComboBox1.SelectedValue))
            Me.PivotGridControl1.DataSource = odtsInformesGranja.ReporteDefuncionesFases
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class