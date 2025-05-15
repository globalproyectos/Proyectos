Public Class frmRepConsolidadoExistencias
    Dim odtsInventario As New dtsInventario
    Dim bodegasAdapter As New dtsInventarioTableAdapters.BodegasTableAdapter
    Dim RepKardexMaterialesResumidoAdapter As New dtsInventarioTableAdapters.RepKardexMaterialesResumidoTableAdapter
    Dim inventarioAdapter As New dtsInventarioTableAdapters.Inventario_Materiales_EstadosTableAdapter
    Private Sub frmRepConsolidadoExistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarbodegas()
    End Sub
    Sub cargarbodegas()
        Try
            bodegasComboBoxEx1.DataSource = bodegasAdapter.GetData()
            bodegasComboBoxEx1.ValueMember = "Bodega"
            bodegasComboBoxEx1.DisplayMember = "Descripcion"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargar()
        Try
            'RepKardexMaterialesResumidoAdapter.Fill(odtsInventario.RepKardexMaterialesResumido, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, Me.codigoTextBoxX1.Text, Me.bodegasComboBoxEx1.Text)
            Me.PivotGridControl1.DataSource = RepKardexMaterialesResumidoAdapter.GetData(Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, If(Me.codigoTextBoxX1.Text <> "", Me.codigoTextBoxX1.Text, ""), Trim(Me.bodegasComboBoxEx1.SelectedValue))

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        cargar()
    End Sub

    Private Sub codigoTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles codigoTextBoxX1.TextChanged

    End Sub

    Private Sub codigoTextBoxX1_LostFocus(sender As Object, e As EventArgs) Handles codigoTextBoxX1.LostFocus
        If Me.codigoTextBoxX1.TextLength > 0 Then
            Me.descripionTextBoxX2.Text = inventarioAdapter.GetDescripcion(Me.codigoTextBoxX1.Text)
        End If
    End Sub

    Private Sub codigoTextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles codigoTextBoxX1.KeyDown
        If e.KeyCode = Keys.F5 Then
            With ListaProductos
                .StartPosition = FormStartPosition.CenterScreen
                .WindowState = FormWindowState.Normal
                .ventanallama = "repconsolidadoexistencias"
                .ShowDialog()
            End With
        End If
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