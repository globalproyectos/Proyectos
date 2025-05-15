Public Class frmReportePesosPartos
    Dim odtsInventario As New dtsInventario
    Dim repPesosEngordesAdapter As New dtsInventarioTableAdapters.ReportePesosEngordesTableAdapter
    Private Sub frmReportePesosPartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub cargar()
        Try
            Me.Cursor = Cursors.WaitCursor
            repPesosEngordesAdapter.Fill(odtsInventario.ReportePesosEngordes, desdeDateTimeInput1.Text, hastaDateTimeInput2.Text, "Parto")
            Me.PivotGridControl1.DataSource = odtsInventario.ReportePesosEngordes
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        cargar()
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
End Class