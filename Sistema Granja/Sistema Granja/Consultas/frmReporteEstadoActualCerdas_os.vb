Public Class frmReporteEstadoActualCerdas_os
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim Etapas_CerdasTableAdapter As New dtsInformesGranjaTableAdapters.Etapas_CerdasTableAdapter
    Dim rptEstadoActualCerdas_osTableAdapter As New dtsInformesGranjaTableAdapters.rptEstadoActualCerdas_osTableAdapter

    Private Sub frmReporteEstadoActualCerdas_os_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarestados()
    End Sub
    Sub cargarestados()
        Try
            Me.EstadosComboBoxEx1.DataSource = Etapas_CerdasTableAdapter.GetData()
            Me.EstadosComboBoxEx1.DisplayMember = "descripcion"
            Me.EstadosComboBoxEx1.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar estados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarreporte()
        Try
            Me.Cursor = Cursors.WaitCursor
            rptEstadoActualCerdas_osTableAdapter.Fill(odtsInformesGranja.rptEstadoActualCerdas_os, Me.EstadosComboBoxEx1.SelectedValue, Me.desdeIntegerInput1.Value, Me.hastaIntegerInput2.Value)
            Dim rptEstadoActual As New rptEstadoActualCerdas_os
            rptEstadoActual.SetDataSource(odtsInformesGranja.Tables("rptEstadoActualCerdas_os"))

            Me.CrystalReportViewer1.ReportSource = rptEstadoActual
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar estados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        cargarreporte()
    End Sub
End Class