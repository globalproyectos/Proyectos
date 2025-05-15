Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmReportePesosProcesos

    Inherits DevComponents.DotNetBar.Office2007Form
    Dim oDtsPesos As New dtsPesosCerdosProcesos
    Dim reportePesosAdapter As New dtsPesosCerdosProcesosTableAdapters.rptPesosTableAdapter
    Private Sub frmReportePesosProcesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim rptPesos As New rptPesosProcesos
            reportePesosAdapter.Fill(oDtsPesos.rptPesos, Me.desdeDateTimeInput1.Text, hastaDateTimeInput2.Text)
            rptPesos.SetDataSource(oDtsPesos.Tables("rptPesos"))
            Me.CrystalReportViewer1.ReportSource = rptPesos
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class