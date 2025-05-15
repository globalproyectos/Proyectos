Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Controls

Public Class dlgTipos_de_Venta
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub dlgTipos_de_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillToolStripButton_Click(sender, e)
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Consulta_Tipos_VentasTableAdapter.Fill(Me.DtsBDGRANJA.Consulta_Tipos_Ventas, Me.txtDescripcion.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        FillToolStripButton_Click(sender, e)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim HayDatos As Boolean = False

        For i As Integer = 0 To Me.Consulta_Tipos_VentasDataGridViewX.RowCount - 1
            HayDatos = True
        Next
        If HayDatos = True Then
            'With My.Forms.frmRegSalidas
            '    .Text = Me.Consulta_Tipos_VentasDataGridViewX.CurrentRow.Cells("Codigo").Value
            '    Me.Close()
            'End With
            Dim txt As TextBoxX
            Dim txtdescripcion As TextBoxX
            txt = frmRegSalidas.Controls.Find("txtTipoVenta", True).FirstOrDefault()
            txtdescripcion = frmRegSalidas.Controls.Find("txtDescripcionTipoVenta", True).FirstOrDefault()

            txt.Text = Me.Consulta_Tipos_VentasDataGridViewX.CurrentRow.Cells("Codigo").Value
            txtdescripcion.Text = Me.Consulta_Tipos_VentasDataGridViewX.CurrentRow.Cells("Descripcion").Value

            Me.Close()

        Else
            MessageBoxEx.Show("No ha ningun registro seleccionado", "No hay datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub



    Private Sub Consulta_Tipos_VentasDataGridViewX_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Consulta_Tipos_VentasDataGridViewX.CellContentDoubleClick
        btnGuardar_Click(sender, e)
    End Sub
End Class