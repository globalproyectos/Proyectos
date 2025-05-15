Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmReporteKardex
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim bodegaAdapter As New DtsBDGRANJATableAdapters.BODEGASTableAdapter
    Dim rptKardexAdapter As New DtsBDGRANJATableAdapters.RepKardexExcelTableAdapter
    Dim inventarioAdapter As New DtsBDGRANJATableAdapters.Inventario_MaterialesTableAdapter
    Dim SalidaFarmacosAdapter As New dtsAlimentacionBaseTablaTableAdapters.SalidaFarmacosTableAdapter

    Private Sub frmReporteKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.desdeDateTimeInput1.Text = FechaSistema
        Me.hastaDateTimeInput2.Text = FechaSistema
        cargarbodegas()
    End Sub
    Sub cargarbodegas()
        Try
            Me.bodegaComboBoxEx1.DataSource = bodegaAdapter.GetData

            Me.bodegaComboBoxEx1.DisplayMember = "Descripcion"
            Me.bodegaComboBoxEx1.ValueMember = "Bodega"

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If recalcularCheckBoxX1.CheckState = CheckState.Checked Then
            Dim _con As New SqlClient.SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
            Try
                Dim cmd As New SqlClient.SqlCommand("Proc_RecalculoSaldoMensualMateriales", _con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Mes", SqlDbType.Char, 3).Value = SalidaFarmacosAdapter.GetMesNombre(hastaDateTimeInput2.Text)
                cmd.Parameters.Add("@Año", SqlDbType.Char, 2).Value = SalidaFarmacosAdapter.GetMesNombre(hastaDateTimeInput2.Text)
                _con.Open()
                cmd.ExecuteNonQuery()
                _con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error al recalcular costo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If _con.State = ConnectionState.Open Then
                    _con.Close()
                End If
            End Try

        End If
        Me.Cursor = Cursors.WaitCursor
        Dim _rptKardex As New rptKardex

        rptKardexAdapter.Fill(odtsBDGRANJA.RepKardexExcel, Me.desdeDateTimeInput1.Text, Me.hastaDateTimeInput2.Text, If(Me.codigoTextBoxX1.Text <> "", Me.codigoTextBoxX1.Text, ""), Me.bodegaComboBoxEx1.SelectedValue)
        _rptKardex.SetDataSource(odtsBDGRANJA.Tables("RepKardexExcel"))
        CrystalReportViewer1.ReportSource = _rptKardex
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub codigoTextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles codigoTextBoxX1.KeyDown
        If e.KeyCode = Keys.F5 Then
            With ListaProductos
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterScreen
                .ventanallama = "reportekardex"
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub codigoTextBoxX1_LostFocus(sender As Object, e As EventArgs) Handles codigoTextBoxX1.LostFocus
        If Me.codigoTextBoxX1.Text <> "" Then
            Me.descripcionTextBox1.Text = inventarioAdapter.GetDescripcion(Me.codigoTextBoxX1.Text)
        Else
            Me.descripcionTextBox1.Text = ""
        End If
    End Sub
    Private Sub codigoTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles codigoTextBoxX1.TextChanged
    End Sub
End Class

