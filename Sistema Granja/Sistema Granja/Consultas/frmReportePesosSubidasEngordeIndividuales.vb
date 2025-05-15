Public Class frmReportePesosSubidasEngordeIndividuales
    Private Sub frmReportePesosSubidasEngordeIndividuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.desdeFechaDateTimeInput1.Text = DateAdd(DateInterval.Day, -30, Today)
        Me.desdeDoubleInput1.Value = 0.00
        Me.hastaDoubleInput2.Value = 100
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim odtsInformesGranja As New dtsInformesGranja
            Dim v_pesosSubidasTableAdapter As New dtsInformesGranjaTableAdapters.v_pesosSubidasEngordeTableAdapter
            v_pesosSubidasTableAdapter.Fill(odtsInformesGranja.v_pesosSubidasEngorde, Me.desdeDoubleInput1.Value, Me.hastaDoubleInput2.Value, Me.desdeFechaDateTimeInput1.Text, Me.loteGestacionTextBoxX1.Text)

            Dim _rptPesosSubidas As New rptPesosSubidaEngordeIndiv
            _rptPesosSubidas.SetDataSource(odtsInformesGranja.Tables("v_pesosSubidasEngorde"))


            Me.CrystalReportViewer1.ReportSource = _rptPesosSubidas

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Arrow
        End Try

    End Sub
End Class