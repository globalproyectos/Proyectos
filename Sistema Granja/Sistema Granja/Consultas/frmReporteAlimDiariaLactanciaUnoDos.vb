Imports DevComponents.DotNetBar
Public Class frmReporteAlimDiariaLactanciaUnoDos
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim p_reporte_cerdas_lactancia_uno_y_dosTableAdapter As New dtsInformesGranjaTableAdapters.p_reporte_cerdas_lactancia_uno_y_dosTableAdapter
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            If Me.ComboBox1.Text = "" Then
                MessageBoxEx.Show("Debe elegir una opción y luego dar clic en generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.Cursor = Cursors.WaitCursor
                p_reporte_cerdas_lactancia_uno_y_dosTableAdapter.Fill(odtsInformesGranja.p_reporte_cerdas_lactancia_uno_y_dos, Me.ComboBox1.Text)

                Dim rptalimdiaria As New rptRegAlimDiariaCerdasLactUnoDos
                rptalimdiaria.SetDataSource(odtsInformesGranja.Tables("p_reporte_cerdas_lactancia_uno_y_dos"))

                Me.CrystalReportViewer1.ReportSource = rptalimdiaria
                Me.Cursor = Cursors.Arrow
            End If

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class