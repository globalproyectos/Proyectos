Public Class frmHistorico_Resumen_Cerdas

    Private Sub LocalizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Historico_Resumen_cerdasTableAdapter.Localizar(Me.DtsBDGRANJA.Historico_Resumen_cerdas, Me.txtCodigo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmHistorico_Resumen_Cerdas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizarToolStripButton_Click(sender, e)
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        LocalizarToolStripButton_Click(sender, e)
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        LocalizarToolStripButton_Click(sender, e)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        ExportarDatosExcel(Me.Historico_Resumen_cerdasDataGridViewX, "AGROINDUSTRIAS GUMARSAL S.A. DE C.V.", "HISTORICO RESUMEN CERDAS", "FECHA: " & FechaSistema, "H")
    End Sub
End Class