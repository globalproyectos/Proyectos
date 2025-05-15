Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmCompartivo_Hato
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub frmCompartivo_Hato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub

    Private Sub MostrarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Comparativo_HatoTableAdapter.Mostrar(Me.DtsBDGRANJA.Comparativo_Hato, Me.cbxEstados.SelectedItem.ToString)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Comparativo_HatoDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Comparativo_HatoDataGridViewX.CellContentClick

    End Sub
    Private Sub cbxEstados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEstados.SelectedIndexChanged
        MostrarToolStripButton_Click(sender, e)
    End Sub

    Private Sub Comparativo_HatoDataGridViewX_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles Comparativo_HatoDataGridViewX.RowPrePaint
        If Me.Comparativo_HatoDataGridViewX.Rows(e.RowIndex).Cells("Diff").Value < 0 Then
            Me.Comparativo_HatoDataGridViewX.Rows(e.RowIndex).Cells("Diff").Style.ForeColor = Color.Red
        ElseIf Me.Comparativo_HatoDataGridViewX.Rows(e.RowIndex).Cells("Diff").Value > 0 Then
            Me.Comparativo_HatoDataGridViewX.Rows(e.RowIndex).Cells("Diff").Style.ForeColor = Color.Orange
        ElseIf Me.Comparativo_HatoDataGridViewX.Rows(e.RowIndex).Cells("Diff").Value = 0 Then
            Me.Comparativo_HatoDataGridViewX.Rows(e.RowIndex).Cells("Diff").Style.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        ExportarDatosExcel(Me.Comparativo_HatoDataGridViewX, "AGROINDUSTRIA GUMARSAL", "Comparativo Hato", "", "H")
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        MostrarToolStripButton_Click(sender, e)
    End Sub
End Class