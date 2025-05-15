Public Class frmReporteSalidasPorFecha
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim reporteSalidasTableAdapter As New dtsInformesGranjaTableAdapters.reporteSalidasTableAdapter
    Dim Tipos_SalidasTableAdapter As New dtsInformesGranjaTableAdapters.Tipos_SalidasTableAdapter
    Dim DestinosTableAdapter As New dtsInformesGranjaTableAdapters.DestinosTableAdapter
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        With SFD
            .Filter = "Archivo de Excel|*.xlsx| Archivo en PDF|*.pdf"
            If .ShowDialog = DialogResult.OK Then

                If .FileName.Contains(".xlsx") Then
                    Me.GridControl1.ExportToXlsx(.FileName)

                ElseIf .FileName.Contains(".pdf") Then
                    Me.GridControl1.ExportToPdf(.FileName)
                End If
                MessageBox.Show("Reporte exportado correctamente", "Exportar a archivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            reporteSalidasTableAdapter.Fill(odtsInformesGranja.reporteSalidas, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, UsuarioActual, 0, Trim(Me.tiposalidasComboBox1.SelectedValue), Trim(Me.destinoComboBox1.SelectedValue), "")

            Me.GridControl1.DataSource = odtsInformesGranja.reporteSalidas
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmReporteSalidasPorFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostratiposalidas()
        mostrardestinos()
    End Sub
    Sub mostratiposalidas()
        Try
            Me.tiposalidasComboBox1.DataSource = Tipos_SalidasTableAdapter.GetData()
            Me.tiposalidasComboBox1.DisplayMember = "TipoSalidas"
            Me.tiposalidasComboBox1.ValueMember = "Codigo_Salida"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub mostrardestinos()
        Try
            Me.destinoComboBox1.DataSource = DestinosTableAdapter.GetData()
            Me.destinoComboBox1.DisplayMember = "Destino"
            Me.destinoComboBox1.ValueMember = "Tipo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rpt As New rptReporteSalidasPorFecha
            reporteSalidasTableAdapter.Fill(odtsInformesGranja.reporteSalidas, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, Trim(Me.tiposalidasComboBox1.SelectedValue), Trim(Me.destinoComboBox1.SelectedValue), "", 0, UsuarioActual)
            rpt.SetDataSource(odtsInformesGranja.Tables("reporteSalidas"))
            Dim frmVistaPrevia As New frmVIstaPreviaImpresiones
            frmVistaPrevia.MdiParent = Me.MdiParent
            frmVistaPrevia.CrystalReportViewer1.ReportSource = rpt
            frmVistaPrevia.Show()
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class