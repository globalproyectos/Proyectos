Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportePartos
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub frmReportePartos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If Me.DataGridViewX1.RowCount = 0 Then
            MessageBoxEx.Show("No hay ningun registro, no puede exportar listas vacias", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ExportarDatosExcel(Me.DataGridViewX1, "..::Reporte de Partos::..", "Fecha desde: " & Me.CajaFecha1.txtFecha.Text & " Hasta: " & Me.CajaFecha2.txtFecha.Text, "", "S")
        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If ValidarFechas(Me.CajaFecha1.txtFecha.Text) = False Then
            MessageBoxEx.Show("La fecha que ha ingresado es incorrecta porfavor verifiquela y vuelva a interntarlo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CajaFecha1.txtFecha.Focus()
        ElseIf ValidarFechas(Me.CajaFecha2.txtFecha.Text) = False Then
            MessageBoxEx.Show("La fecha que ha ingresado es incorrecta porfavor verifiquela y vuelva a interntarlo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CajaFecha2.txtFecha.Focus()
        Else
            Try
                sql = New SqlCommand("SELECT * FROM REG_PARTOS_X_CERDA WHERE Fecha_Real BETWEEN '" & Me.CajaFecha1.txtFecha.Text & "' AND '" & Me.CajaFecha2.txtFecha.Text & "'", con)
                dt = New DataTable
                With dt.Columns
                    .Add(New DataColumn("Código Cerda"))
                    .Add(New DataColumn("Parto No"))
                    .Add(New DataColumn("Fecha Monta"))
                    .Add(New DataColumn("Verraco"))
                    .Add(New DataColumn("Fecha Estimada DP"))
                    .Add(New DataColumn("Fecha Monta R1"))
                    .Add(New DataColumn("Verraco 1"))
                    .Add(New DataColumn("Fecha Real"))
                    .Add(New DataColumn("No. Vivos"))
                    .Add(New DataColumn("Momias"))
                    .Add(New DataColumn("Muertos"))
                    .Add(New DataColumn("P. Camada"))
                    .Add(New DataColumn("P. Prom."))
                    .Add(New DataColumn("Fecha Destete"))
                    .Add(New DataColumn("No. Destad"))
                    .Add(New DataColumn("P. Camada 1"))
                    .Add(New DataColumn("P. Prom. 1"))
                    .Add(New DataColumn("Estado"))
                End With
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer(1)
                    dr(2) = leer(2)
                    dr(3) = leer(3)
                    dr(4) = leer(4)
                    dr(5) = leer(5)
                    dr(6) = leer(6)
                    dr(7) = leer(7)
                    dr(8) = leer(8)
                    dr(9) = leer(9)
                    dr(10) = leer(10)
                    dr(11) = leer(11)
                    dr(12) = leer(12)
                    dr(13) = leer(13)
                    dr(14) = leer(14)
                    dr(15) = leer(15)
                    dr(16) = leer(16)
                    dr(17) = leer(17)
                    dt.Rows.Add(dr)
                End While
                dv = New DataView(dt)
                Me.DataGridViewX1.DataSource = dv
                con.Close()
                EstiloDatagrid(Me.DataGridViewX1, 9, "Arial", FontStyle.Regular)
                Me.DataGridViewX1.Columns(0).Width = 70
                Me.DataGridViewX1.Columns(1).Width = 60
                Me.DataGridViewX1.Columns(2).Width = 70
                Me.DataGridViewX1.Columns(3).Width = 65
                Me.DataGridViewX1.Columns(4).Width = 70
                Me.DataGridViewX1.Columns(5).Width = 70
                Me.DataGridViewX1.Columns(6).Width = 65
                Me.DataGridViewX1.Columns(7).Width = 70
                Me.DataGridViewX1.Columns(8).Width = 65
                Me.DataGridViewX1.Columns(9).Width = 65
                Me.DataGridViewX1.Columns(10).Width = 60
                Me.DataGridViewX1.Columns(11).Width = 70
                Me.DataGridViewX1.Columns(12).Width = 70
                Me.DataGridViewX1.Columns(13).Width = 70
                Me.DataGridViewX1.Columns(14).Width = 70
                Me.DataGridViewX1.Columns(15).Width = 70
                Me.DataGridViewX1.Columns(16).Width = 70
                Me.DataGridViewX1.Columns(17).Width = 60
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
    End Sub
End Class