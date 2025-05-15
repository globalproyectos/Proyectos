Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmVaciasPendientes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim alertaVaciasAdapter As New DtsBDGRANJATableAdapters.Alerta_CerdasVaciasTableAdapter
    Private Sub frmVaciasPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alertaVaciasAdapter.Fill(odtsBDGRANJA.Alerta_CerdasVacias, FechaSistema)

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = odtsBDGRANJA.Alerta_CerdasVacias
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar cerdas vacías", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub DataGridViewX1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridViewX1.RowPrePaint
        If If(IsDBNull(Me.DataGridViewX1.Rows(e.RowIndex).Cells("Estado").Value), "", Me.DataGridViewX1.Rows(e.RowIndex).Cells("Estado").Value) = "Excedido" Then
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        ElseIf If(IsDBNull(Me.DataGridViewX1.Rows(e.RowIndex).Cells("Estado").Value), "", Me.DataGridViewX1.Rows(e.RowIndex).Cells("Estado").Value) = "Por vencer" Then
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
        Else
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Nothing

        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        'ExportarDatosExcel(Me.DataGridViewX1, "Alerta: Lista de cerdas corral vacias", "", "", "")
        ExportDataToExcel("C:\texto\file.xlsx", Me.DataGridViewX1)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rptalerta_vacias As New rptAlertaCerdasVaciasCorral
            rptalerta_vacias.SetDataSource(odtsBDGRANJA.Tables("Alerta_CerdasVacias"))
            Dim vistaprevia As New Visualizador
            With vistaprevia
                .WindowState = FormWindowState.Maximized
                .StartPosition = FormStartPosition.CenterScreen
                .CrReporteViewerç.ReportSource = rptalerta_vacias
                .ShowDialog()
            End With
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class