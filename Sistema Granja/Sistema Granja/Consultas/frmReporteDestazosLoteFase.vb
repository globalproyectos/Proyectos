Public Class frmReporteDestazosLoteFase
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim reporteSalidasTableAdapter As New dtsInformesGranjaTableAdapters.reporteSalidasTableAdapter
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
    Private Sub frmReporteDestazosLoteFase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.mostrartiposalidas()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            reporteSalidasTableAdapter.Fill(odtsInformesGranja.reporteSalidas, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, "DZ", "", "", 0, UsuarioActual)
            Me.PivotGridControl1.DataSource = odtsInformesGranja.reporteSalidas
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error mostrar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class