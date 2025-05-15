Public Class frmPartosExcedidos
    Dim Alerta_Maximo7PartosTableAdapter As New DtsBDGRANJATableAdapters.Alerta_Maximo7PartosTableAdapter
    Private Sub frmPartosExcedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarnotificacion()
    End Sub
    Sub cargarnotificacion()
        Try
            Alerta_Maximo7PartosTableAdapter.Fill(odtsBDGRANJA.Alerta_Maximo7Partos)
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = odtsBDGRANJA.Alerta_Maximo7Partos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rptAlertas_MaximoPartos As New rptAlertasMaximoPartos
            rptAlertas_MaximoPartos.SetDataSource(odtsBDGRANJA.Tables("Alerta_Maximo7Partos"))

            Dim vistaprevia As New Visualizador
            With vistaprevia
                .WindowState = FormWindowState.Maximized
                .StartPosition = FormStartPosition.CenterScreen
                .CrReporteViewerç.ReportSource = rptAlertas_MaximoPartos
                .ShowDialog()
            End With
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class