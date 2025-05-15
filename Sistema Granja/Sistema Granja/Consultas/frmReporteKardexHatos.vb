Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmReporteKardexHatos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim bodegaAdapter As New DtsBDGRANJATableAdapters.BODEGASTableAdapter
    Dim rptKardexAdapter As New DtsBDGRANJATableAdapters.RepKardexHatosTableAdapter
    Dim inventarioAdapter As New DtsBDGRANJATableAdapters.Inventario_MaterialesTableAdapter
    Private Sub frmReporteKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.desdeDateTimeInput1.Text = FechaSistema
        Me.hastaDateTimeInput2.Text = FechaSistema
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim _rptKardex As New rptKardexHatos

        rptKardexAdapter.Fill(odtsBDGRANJA.RepKardexHatos, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, If(Me.loteTextBoxX1.Text <> "", Me.loteTextBoxX1.Text, ""))
        _rptKardex.SetDataSource(odtsBDGRANJA.Tables("RepKardexHatos"))
        CrystalReportViewer1.ReportSource = _rptKardex
        Me.Cursor = Cursors.Arrow

    End Sub
    'Private Sub codigoTextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles loteTextBoxX1.KeyDown, loteTextBoxX1.KeyDown
    '    If e.KeyCode = Keys.F5 Then
    '        With ListaProductos
    '            .WindowState = FormWindowState.Normal
    '            .StartPosition = FormStartPosition.CenterScreen
    '            .ventanallama = "reportekardex"
    '            .ShowDialog()
    '        End With
    '    End If
    'End Sub
    Private Sub codigoTextBoxX1_LostFocus(sender As Object, e As EventArgs) Handles loteTextBoxX1.LostFocus, loteTextBoxX1.LostFocus
        If Me.loteTextBoxX1.Text <> "" Then
            Me.descripcionTextBox1.Text = rptKardexAdapter.GetDescripcionEtapaLote(Me.loteTextBoxX1.Text)
        Else
            Me.descripcionTextBox1.Text = ""
        End If
    End Sub
    Private Sub codigoTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles loteTextBoxX1.TextChanged, loteTextBoxX1.TextChanged

    End Sub
End Class