Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmReporteInventarioDiarioReprod
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim repInvDiarioHatoReprodAdapter As New DtsBDGRANJATableAdapters.RepInventarioDiarioReprodTableAdapter
    Dim repInvDiarioHatoReprodResumAdapter As New DtsBDGRANJATableAdapters.RepInventarioDiarioReprod_resumTableAdapter
    Private Sub frmReporteInventarioDiarioReprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            repInvDiarioHatoReprodAdapter.Fill(odtsBDGRANJA.RepInventarioDiarioReprod, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text)
            repInvDiarioHatoReprodResumAdapter.Fill(odtsBDGRANJA.RepInventarioDiarioReprod_resum, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text)
            Dim rptInvReprod As New rptInventarioDiarioReprod
            rptInvReprod.SetDataSource(odtsBDGRANJA.Tables("RepInventarioDiarioReprod"))
            rptInvReprod.Subreports("rpt_resum_hato_reprod").SetDataSource(odtsBDGRANJA.Tables("RepInventarioDiarioReprod_resum"))

            Me.CrystalReportViewer1.ReportSource = rptInvReprod
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class