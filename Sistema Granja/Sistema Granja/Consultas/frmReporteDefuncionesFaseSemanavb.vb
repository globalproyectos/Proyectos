Public Class frmReporteDefuncionesFaseSemanavb

    Dim odtsInformesGranja As New dtsInformesGranja
    Dim ReporteDefuncionesFasesAdapter As New dtsInformesGranjaTableAdapters.ReporteDefuncionesFasesTableAdapter
    Dim LotesFiltroRepDefFasesAdapter As New dtsInformesGranjaTableAdapters.LotesFiltroRepDefFasesTableAdapter


    Private Sub desdeDateTimeInput1_TextChanged(sender As Object, e As EventArgs) Handles desdeDateTimeInput1.TextChanged
        mostrarlotesfiltro()
    End Sub
    Sub mostrarlotesfiltro()
        Try
            If IsDate(Me.desdeDateTimeInput1.Text) And IsDate(Me.hastaDateTimeInput2.Text) Then
                lotesComboBox1.DataSource = LotesFiltroRepDefFasesAdapter.GetData(Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text)
                lotesComboBox1.ValueMember = "lote_no"
                lotesComboBox1.DisplayMember = "descripcion"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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

    Private Sub frmReporteDefuncionesFaseSemanavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarlotesfiltro()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            ReporteDefuncionesFasesAdapter.Fill(odtsInformesGranja.ReporteDefuncionesFases, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, Me.lotesComboBox1.SelectedValue)
            Me.PivotGridControl1.DataSource = odtsInformesGranja.ReporteDefuncionesFases
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub hastaDateTimeInput2_TextChanged(sender As Object, e As EventArgs) Handles hastaDateTimeInput2.TextChanged
        mostrarlotesfiltro()
    End Sub
End Class