Public Class frmReporteLotes
    Inherits DevComponents.DotNetBar.OfficeForm
    Dim Proc_ReporteLotesAdapter As New DtsBDGRANJATableAdapters.Proc_ReporteLotesTableAdapter
    Dim oDtsBDGRANJA As New DtsBDGRANJA
    Private Sub frmReporteLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.desdeDateTimeInput1.Text = Today
        Me.hastaDateTimeInput1.Text = Today
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()

    End Sub

    Private Sub desdeDateTimeInput1_Click(sender As Object, e As EventArgs) Handles desdeDateTimeInput1.Click

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Cursor = Cursors.WaitCursor
        Proc_ReporteLotesAdapter.Fill(oDtsBDGRANJA.Proc_ReporteLotes, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput1.Text, Me.LoteNoTextBoxX1.Text)
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.DataSource = oDtsBDGRANJA.Proc_ReporteLotes
        Me.Cursor = Cursors.Arrow

    End Sub
End Class