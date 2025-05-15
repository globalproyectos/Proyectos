Imports System.Data.SqlClient
Imports System.Data
Public Class frmRptEdadVerracos
    Public esAlerta As Boolean = False
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        cargar()
    End Sub
    Sub cargar()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim odtsInformes As New dtsInformesGranja
            Dim rptEdadVerracosTableAdapter As New dtsInformesGranjaTableAdapters.rptEdadVerracosTableAdapter
            rptEdadVerracosTableAdapter.Fill(odtsInformes.rptEdadVerracos, Me.TextBoxX1.Text)

            Dim rpt As New rptEdadVerracos
            rpt.SetDataSource(odtsInformes.Tables("rptEdadVerracos"))

            CrystalReportViewer1.ReportSource = rpt


            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub frmRptEdadVerracos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If esAlerta Then
            cargar()
        End If
    End Sub
End Class