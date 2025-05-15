Public Class frmReporteInventarioDiario
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim RepInventarioDiarioEngorgeAdapter As New DtsBDGRANJATableAdapters.RepInventarioDiarioEngorgeTableAdapter
    Private Sub frmReporteInventarioDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Cursor = Cursors.WaitCursor
        RepInventarioDiarioEngorgeAdapter.CommandTimeout = 5000
        RepInventarioDiarioEngorgeAdapter.Fill(odtsBDGRANJA.RepInventarioDiarioEngorge, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text)

        Dim rptDiario As New rptInventarioDiario
        rptDiario.SetDataSource(odtsBDGRANJA.Tables("RepInventarioDiarioEngorge"))
        Me.CrystalReportViewer1.ReportSource = rptDiario
        Me.Cursor = Cursors.Arrow
    End Sub
End Class