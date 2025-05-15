Public Class frmRepHistoricoCerdas
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim LotesTableAdapter As New dtsInformesGranjaTableAdapters.v_historico_cerdasTableAdapter
    Dim v_historico_cerdasTableAdapter As New dtsInformesGranjaTableAdapters.v_historico_cerdasTableAdapter
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim fecha_desde As Date, fecha_hasta As Date, idCerda As String

            If idCerdaTextBoxX1.Text = "" Then
                fecha_desde = Me.desdeDateTimeInput1.Text
                fecha_hasta = Me.hastaDateTimeInput2.Text
                idCerda = ""
            Else
                fecha_desde = "01/01/1901"
                fecha_hasta = "01/01/1901"
                idCerda = Me.idCerdaTextBoxX1.Text
            End If
            v_historico_cerdasTableAdapter.Fill(odtsInformesGranja.v_historico_cerdas, fecha_desde, fecha_hasta, idCerda)
            Dim rpthistoricoCerdas As New rptHistoricoCerdas

            rpthistoricoCerdas.SetDataSource(odtsInformesGranja.Tables("v_historico_cerdas"))

            Me.CrystalReportViewer1.ReportSource = rpthistoricoCerdas
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class