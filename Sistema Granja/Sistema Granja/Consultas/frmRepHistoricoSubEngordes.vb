Public Class frmRepHistoricoSubEngordes
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim rptHistoricoSubEngordeTableAdapter As New dtsInformesGranjaTableAdapters.rptHistoricoSubEngordeTableAdapter
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            rptHistoricoSubEngordeTableAdapter.Fill(odtsInformesGranja.rptHistoricoSubEngorde, Me.LoteNoTextBoxX1.Text)
            Dim _rptHistoricoSubEngorde As New rptHistoricoSubEngorde
            _rptHistoricoSubEngorde.SetDataSource(odtsInformesGranja.Tables("rptHistoricoSubEngorde"))
            Me.CrystalReportViewer1.ReportSource = _rptHistoricoSubEngorde
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class