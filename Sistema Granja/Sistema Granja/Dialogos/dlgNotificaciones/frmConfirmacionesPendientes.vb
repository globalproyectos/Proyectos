Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmConfirmacionesPendientes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim alertaConfirmacionesAdapter As New DtsBDGRANJATableAdapters.Alerta_PendientesConfirmarTableAdapter
    Private Sub frmConfirmacionesPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alertaConfirmacionesAdapter.Fill(odtsBDGRANJA.Alerta_PendientesConfirmar, FechaSistema)
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = odtsBDGRANJA.Alerta_PendientesConfirmar
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar inseminaciones pendientes de confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

   

    Private Sub DataGridViewX1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridViewX1.RowPrePaint
        If Me.DataGridViewX1.Rows(e.RowIndex).Cells("Estado").Value = "Excedido" Then
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        ElseIf Me.DataGridViewX1.Rows(e.RowIndex).Cells("Estado").Value = "Por vencer" Then
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
        Else
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Nothing

        End If
    End Sub
End Class