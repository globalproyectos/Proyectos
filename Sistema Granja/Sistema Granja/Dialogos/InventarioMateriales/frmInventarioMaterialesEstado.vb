Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Public Class frmInventarioMaterialesEstado
    Dim odtsInventario As New dtsInventario
    Dim inventarioAdapter As New dtsInventarioTableAdapters.Inventario_Materiales_EstadosTableAdapter
    Dim bsInventario As New BindingSource
    Private Sub frmInventarioMaterialesEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Sub cargar()
        Try
            inventarioAdapter.Fill(odtsInventario.Inventario_Materiales_Estados, Trim(Me.descripcionTextBoxX2.Text), Trim(Me.codigoTextBoxX1.Text))
            bsInventario.DataSource = odtsInventario.Inventario_Materiales_Estados

            inventarioDataGridViewX1.AutoGenerateColumns = False
            inventarioDataGridViewX1.DataSource = bsInventario
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Try
            bsInventario.EndEdit()
            inventarioAdapter.Update(odtsInventario.Inventario_Materiales_Estados)
            MessageBoxEx.Show("Cambios aplicados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub codigoTextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles codigoTextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargar()
        End If
    End Sub

    Private Sub descripcionTextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles descripcionTextBoxX2.TextChanged

    End Sub

    Private Sub descripcionTextBoxX2_KeyDown(sender As Object, e As KeyEventArgs) Handles descripcionTextBoxX2.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargar()

        End If
    End Sub
End Class