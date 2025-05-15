Public Class frmReporteCorteDiario
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim reporteSalidasTableAdapter As New dtsInformesGranjaTableAdapters.reporteSalidasTableAdapter
    Dim vReporteCorteDiarioDefuncionesLactanciaTableAdapter As New dtsInformesGranjaTableAdapters.vReporteCorteDiarioDefuncionesLactanciaTableAdapter
    Dim vReporteCorteDiarioDefuncionesEngordeTableAdapter As New dtsInformesGranjaTableAdapters.vReporteCorteDiarioDefuncionesEngordeTableAdapter
    Dim ConteoImpresionCorteDiarioTableAdapter As New dtsInformesGranjaTableAdapters.ConteoImpresionCorteDiarioTableAdapter
    Private Sub frmReporteCorteDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.fechaDateTimeInput1.Text = FechaSistema
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        'Try
        Me.Cursor = Cursors.WaitCursor
        Dim ultimoconteo As Integer
        If ConteoImpresionCorteDiarioTableAdapter.GetContarNoRegistrosSegunFecha(FechaSistema) > 0 Then
            ultimoconteo = ConteoImpresionCorteDiarioTableAdapter.GetUltimoSegunFecha(FechaSistema)
        Else
            ultimoconteo = 0
        End If

        Dim actualconteo As Integer = ultimoconteo + 1
        ConteoImpresionCorteDiarioTableAdapter.InsertarNuevoConteo(FechaSistema, actualconteo, UsuarioActual)

        reporteSalidasTableAdapter.Fill(odtsInformesGranja.reporteSalidas, Me.fechaDateTimeInput1.Text, Me.fechaDateTimeInput1.Text, UsuarioActual, actualconteo, "", "", "")
        vReporteCorteDiarioDefuncionesLactanciaTableAdapter.Fill(odtsInformesGranja.vReporteCorteDiarioDefuncionesLactancia, Me.fechaDateTimeInput1.Text, Me.fechaDateTimeInput1.Text)
            vReporteCorteDiarioDefuncionesEngordeTableAdapter.Fill(odtsInformesGranja.vReporteCorteDiarioDefuncionesEngorde, Me.fechaDateTimeInput1.Text, Me.fechaDateTimeInput1.Text)

            Dim rptCorteDiario As New rptCorteDiario
            rptCorteDiario.SetDataSource(odtsInformesGranja.Tables("reporteSalidas"))
            rptCorteDiario.Subreports("rptDefuncionesLactancia").SetDataSource(odtsInformesGranja.Tables("vReporteCorteDiarioDefuncionesLactancia"))
            rptCorteDiario.Subreports("rptDefuncionesEngorde").SetDataSource(odtsInformesGranja.Tables("vReporteCorteDiarioDefuncionesEngorde"))


            Me.CrystalReportViewer1.ReportSource = rptCorteDiario
            Me.Cursor = Cursors.Arrow
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class