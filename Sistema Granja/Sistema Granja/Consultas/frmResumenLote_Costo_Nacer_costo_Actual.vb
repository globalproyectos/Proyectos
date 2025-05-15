Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmResumenLote_Costo_Nacer_costo_Actual

    Private Sub frmResumenLote_Costo_Nacer_costo_Actual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsBDGRANJA.Resumen_Lote' Puede moverla o quitarla según sea necesario.
        Try
            Me.Resumen_LoteTableAdapter.Fill(Me.DtsBDGRANJA.Resumen_Lote)
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ExportarDatosExcel(Me.Resumen_LoteDataGridViewX, "RESUMEN LOTES", "FECHA: " & FechaSistema, "2", "G")
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class