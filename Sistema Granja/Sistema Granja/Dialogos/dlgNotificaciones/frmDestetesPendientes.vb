Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmDestetesPendientes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim destetesPendientesAdapter As New DtsBDGRANJATableAdapters.Alerta_PendientesDesteteTableAdapter
    Private Sub frmDestetesPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            destetesPendientesAdapter.Fill(odtsBDGRANJA.Alerta_PendientesDestete, FechaSistema)

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = odtsBDGRANJA.Alerta_PendientesDestete
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar inseminaciones pendientes de confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
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

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rptAlertas_Destetes As New rptAlertasDestetes
            rptAlertas_Destetes.SetDataSource(odtsBDGRANJA.Tables("Alerta_PendientesDestete"))

            Dim vistaprevia As New Visualizador
            With vistaprevia
                .WindowState = FormWindowState.Maximized
                .StartPosition = FormStartPosition.CenterScreen
                .CrReporteViewerç.ReportSource = rptAlertas_Destetes
                .ShowDialog()
            End With


            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class