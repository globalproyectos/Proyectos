Public Class frmReportePesosDestetesIndividuales
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim odtsInformesGranja As New dtsInformesGranja
            Dim v_pesosDestetesTableAdapter As New dtsInformesGranjaTableAdapters.v_pesosDestetesTableAdapter
            v_pesosDestetesTableAdapter.Fill(odtsInformesGranja.v_pesosDestetes, Me.desdeDoubleInput1.Value, Me.hastaDoubleInput2.Value, Me.desdeFechaDateTimeInput1.Text, Me.loteGestacionTextBoxX1.Text)

            Dim _rptPesosDestetes As New rptPesosDestetesIndiv
            _rptPesosDestetes.SetDataSource(odtsInformesGranja.Tables("v_pesosDestetes"))


            Me.CrystalReportViewer1.ReportSource = _rptPesosDestetes

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub frmReportePesosDestetesIndividuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.desdeFechaDateTimeInput1.Text = DateAdd(DateInterval.Day, -30, Today)
        Me.desdeDoubleInput1.Value = 0.00
        Me.hastaDoubleInput2.Value = 20
    End Sub
End Class