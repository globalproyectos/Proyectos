Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmNotificaciones
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub frmNotificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridViewX1.DataSource = odtsBDGRANJA.ResumenAlertas
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick
        If Me.DataGridViewX1.CurrentCell.ColumnIndex = 2 Then
            If Me.DataGridViewX1.CurrentRow.Cells(0).Value = "Inseminaciones" Then
                With frmConfirmacionesPendientes
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf Me.DataGridViewX1.CurrentRow.Cells(0).Value = "Partos" Then
                With frmPartosPendientes
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf Me.DataGridViewX1.CurrentRow.Cells(0).Value = "Destetes" Then
                With frmDestetesPendientes
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf Me.DataGridViewX1.CurrentRow.Cells(0).Value = "Cerdas vacías" Then
                With frmVaciasPendientes
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf Me.DataGridViewX1.CurrentRow.Cells(0).Value = "Límite de partos" Then
                With frmPartosExcedidos
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf Me.DataGridViewX1.CurrentRow.Cells(0).Value = "Límite de edad verracos" Then
                With frmRptEdadVerracos
                    .WindowState = FormWindowState.Normal
                    .esAlerta = True
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            End If

        End If
    End Sub
End Class