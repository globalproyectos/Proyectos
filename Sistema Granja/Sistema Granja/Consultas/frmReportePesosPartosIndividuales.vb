Public Class frmReportePesosPartosIndividuales
    Private Sub frmReportePesosPartosIndividuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.desdeFechaDateTimeInput1.Text = DateAdd(DateInterval.Day, -30, Today)
        Me.desdeDoubleInput1.Value = 0.00
        Me.hastaDoubleInput2.Value = 2

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim odtsInformesGranja As New dtsInformesGranja
            Dim v_pesosPartosTableAdapter As New dtsInformesGranjaTableAdapters.v_pesosPartosTableAdapter
            v_pesosPartosTableAdapter.Fill(odtsInformesGranja.v_pesosPartos, Me.desdeDoubleInput1.Value, Me.hastaDoubleInput2.Value, Me.desdeFechaDateTimeInput1.Text, Me.loteGestacionTextBoxX1.Text)

            Dim _rptPesosLechones As New rptPesosLechones
            _rptPesosLechones.SetDataSource(odtsInformesGranja.Tables("v_pesosPartos"))


            Me.CrystalReportViewer1.ReportSource = _rptPesosLechones

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Arrow
        End Try

    End Sub
End Class