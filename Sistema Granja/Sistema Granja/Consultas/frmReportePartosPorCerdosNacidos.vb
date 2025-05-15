Public Class frmReportePartosPorCerdosNacidos
    Dim odtsInventario As New dtsInventario
    Dim vReportePartosHomogeneidadTableAdapter As New dtsInventarioTableAdapters.vReportePartosHomogeneidadTableAdapter
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

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            vReportePartosHomogeneidadTableAdapter.Fill(odtsInventario.vReportePartosHomogeneidad, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text)
            Me.PivotGridControl1.DataSource = odtsInventario.vReportePartosHomogeneidad
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class