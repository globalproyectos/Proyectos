Public Class frmRepConsumoSemEngorde
    Dim odtsInventario As New dtsInventario
    Dim RepConsumoSemEngordeAdaoter As New dtsInventarioTableAdapters.RepConsumoSemEngordeTableAdapter
    Dim RepKardexMaterialesResumidoAdapter As New dtsInventarioTableAdapters.RepKardexMaterialesResumidoTableAdapter

    Private Sub frmRepConsumoSemEngorde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub cargar()
        Try
            RepConsumoSemEngordeTableAdapter.Fill(odtsInventario.RepConsumoSemEngorde, desdeDateTimeInput1.Text, hastaDateTimeInput2.Text, "")
            Me.PivotGridControl1.DataSource = odtsInventario.RepConsumoSemEngorde
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error)
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