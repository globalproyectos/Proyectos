Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmConsultaLotes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Verif As Boolean = False
    Private Sub frmConsultaLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.CargarLotes()
        Me.txtFechaDesde.Text = Format(FechaSistema, "dd/MM/yy")
        Me.txtFechaHasta.Text = Format(FechaSistema, "dd/MM/yy")
        For i As Integer = 0 To 100
            Me.ProgressBarX2.Value = 100
        Next
    End Sub
    Sub PropiedadDatagrid()
        EstiloDatagrid(Me.DataGridViewX1, 8, "Tahoma", FontStyle.Bold)
        Me.DataGridViewX1.Columns(0).Width = 50
        Me.DataGridViewX1.Columns(1).Width = 80
        Me.DataGridViewX1.Columns(2).Width = 70
        Me.DataGridViewX1.Columns(3).Width = 70
        Me.DataGridViewX1.Columns(4).Width = 80
        Me.DataGridViewX1.Columns(5).Width = 70
        Me.DataGridViewX1.Columns(6).Width = 70
    End Sub
    Sub CargarLotes()
        Me.cbxLoteDesde.Items.Clear()
        Me.cbxLoteHasta.Items.Clear()
        Try
            sql = New SqlCommand("SELECT Lote_No FROM LOTES WHERE Estado='A' OR Estado='F'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLoteDesde.Items.Add(leer(0))
                Me.cbxLoteHasta.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error cargando Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub cbxLoteHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLoteHasta.LostFocus
        If Me.txtFechaDesde.TextLength <> 0 And Me.txtFechaHasta.TextLength <> 0 And Me.cbxLoteDesde.Text <> "" And Me.cbxLoteHasta.Text <> "" Then
            Me.btnConsultar.Enabled = True
        Else
            Me.btnConsultar.Enabled = False
        End If
    End Sub
    Private Sub txtFechaDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaDesde.KeyPress
        If Me.txtFechaDesde.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaDesde.Text = Me.txtFechaDesde.Text & "/"
            Me.txtFechaDesde.SelectionStart = 4
        ElseIf Me.txtFechaDesde.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaDesde.Text = Me.txtFechaDesde.Text & "/"
            Me.txtFechaDesde.SelectionStart = 6
        End If
    End Sub
    Private Sub txtFechaHasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaHasta.KeyPress
        If Me.txtFechaHasta.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaHasta.Text = Me.txtFechaHasta.Text & "/"
            Me.txtFechaHasta.SelectionStart = 4
        ElseIf Me.txtFechaHasta.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaHasta.Text = Me.txtFechaHasta.Text & "/"
            Me.txtFechaHasta.SelectionStart = 6
        End If
    End Sub

    Private Sub cbxLoteDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLoteDesde.LostFocus
        If Me.txtFechaDesde.TextLength <> 0 And Me.txtFechaHasta.TextLength <> 0 And Me.cbxLoteDesde.Text <> "" And Me.cbxLoteHasta.Text <> "" Then
            Me.btnConsultar.Enabled = True
        Else
            Me.btnConsultar.Enabled = False
        End If
    End Sub

    Private Sub txtFechaDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaDesde.LostFocus
        If Me.txtFechaDesde.TextLength <> 0 And Me.txtFechaHasta.TextLength <> 0 And Me.cbxLoteDesde.Text <> "" And Me.cbxLoteHasta.Text <> "" Then
            Me.btnConsultar.Enabled = True
        Else
            Me.btnConsultar.Enabled = False
        End If
    End Sub

    Private Sub txtFechaHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaHasta.LostFocus
        If Me.txtFechaDesde.TextLength <> 0 And Me.txtFechaHasta.TextLength <> 0 And Me.cbxLoteDesde.Text <> "" And Me.cbxLoteHasta.Text <> "" Then
            Me.btnConsultar.Enabled = True
        Else
            Me.btnConsultar.Enabled = False
        End If
    End Sub

    Private Sub txtFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaDesde.TextChanged
        If Me.txtFechaDesde.TextLength < 8 Or Me.txtFechaHasta.TextLength < 8 Then
            Me.btnConsultar.Enabled = False
        Else
            Me.btnConsultar.Enabled = True
        End If
    End Sub

    Private Sub txtFechaHasta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaHasta.TextChanged
        If Me.txtFechaHasta.TextLength < 8 Or Me.txtFechaDesde.TextLength < 8 Then
            Me.btnConsultar.Enabled = False
        Else
            Me.btnConsultar.Enabled = True
        End If
    End Sub
    Sub Consultar()
        Try
            sql = New SqlCommand("SELECT l.Lote_No, l.Fecha_Creacion, l.Cerdos_Nacidos, t.Total_Cerdos, t.Fecha_Ultima_Modificación," _
                                 & " isnull((select round(sum(a.cantidad),2) from Lineas_de_Requisiciones a where a.Lote_No = l.Lote_No and a.Viva = 1 and a.Fecha_Liquidacion between '" & Me.txtFechaDesde.Text & "' and '" & Me.txtFechaHasta.Text & "'),0) Libras," _
                                 & " isnull((select round(sum(a.Importe),2) from Lineas_de_Requisiciones a where a.Lote_No = l.Lote_No and a.Viva = 1 and a.Fecha_Liquidacion between '" & Me.txtFechaDesde.Text & "' and '" & Me.txtFechaHasta.Text & "'),0) Total" _
                                 & " FROM LOTES as l" _
                                 & " LEFT JOIN Total_Cerdos_Lote AS t ON l.Lote_No=t.Lote_No" _
                                 & " LEFT JOIN LINEAS_DE_REQUISICIONES AS a ON l.Lote_No=a.Lote_No" _
                                 & " LEFT JOIN REQUISICIONES AS b ON a.Req_No=b.Req_NO" _
                                 & " WHERE l.Lote_No between '" & Me.cbxLoteDesde.Text & "' and '" & Me.cbxLoteHasta.Text & "' and l.IdEtapa_Cerdas='E'" _
                                 & " GROUP BY l.Lote_No, l.Fecha_Creacion, l.Cerdos_Nacidos, t.Total_Cerdos, t.Fecha_Ultima_Modificación", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Lote No."))
                .Add(New DataColumn("Fecha Creación"))
                .Add(New DataColumn("Cerdos Registrados"))
                .Add(New DataColumn("Total Actual"))
                .Add(New DataColumn("Ultima Modificación"))
                .Add(New DataColumn("Cantidad Consumo"))
                .Add(New DataColumn("Consumo Costos USS$"))
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
                dt.Rows.Add(dr)
            End While
            con.Close()
            dv = New DataView(dt)
            Me.DataGridViewX1.DataSource = dv
            Me.PropiedadDatagrid()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If ValidarFechas(Me.txtFechaDesde.Text) = False Then
            Me.txtFechaDesde.SelectAll()
            Me.txtFechaDesde.Focus()
        ElseIf ValidarFechas(Me.txtFechaHasta.Text) = False Then
            Me.txtFechaHasta.SelectAll()
            Me.txtFechaHasta.Focus()
        Else
            Me.Consultar()
        End If
    End Sub
    Sub CalcularTiempo()
        Try

            Dim Dias As Double
            Dim FechaDesde, FechaHasta As Date
            FechaDesde = Me.DataGridViewX1.CurrentRow.Cells("Fecha Creación").Value
            FechaHasta = FechaSistema
            Dias = (FechaHasta - FechaDesde).TotalDays
            Dim Meses As Double
            Meses = (Dias * 0.0328549112)
            Dim Años As Double
            Años = (Meses / 12)
            Dim Semanas As Integer = Dias * 0.142857143
            Me.txtAños.Text = Math.Round(Años, 1)
            Me.txtMeses.Text = Math.Round(Meses, 1)
            Me.txtSemanas.Text = Math.Round(Semanas, 1)
            Me.txtDias.Text = Math.Round(Dias, 1)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub RecuperarMovimientosLote()
        Try
            Dim Reemplazos, Defunciones, Destazo, Rastro, Entradas, Salidas As Integer
            sql = New SqlCommand("SELECT SUM(Reemplazos) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & Me.DataGridViewX1.CurrentRow.Cells("Lote No.").Value & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Reemplazos = 0
                Else
                    Reemplazos = leer(0)
                End If
            End While
            con.Close()
            sql = New SqlCommand("SELECT SUM(Defuncion) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & Me.DataGridViewX1.CurrentRow.Cells("Lote No.").Value & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Defunciones = 0
                Else
                    Defunciones = leer(0)
                End If
            End While
            con.Close()
            sql = New SqlCommand("SELECT SUM(Destazo) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & Me.DataGridViewX1.CurrentRow.Cells("Lote No.").Value & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Destazo = 0
                Else
                    Destazo = leer(0)
                End If
            End While
            con.Close()
            sql = New SqlCommand("SELECT SUM(Rastro) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & Me.DataGridViewX1.CurrentRow.Cells("Lote No.").Value & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Rastro = 0
                Else
                    Rastro = leer(0)
                End If
            End While
            con.Close()
            sql = New SqlCommand("SELECT SUM(Entrada) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & Me.DataGridViewX1.CurrentRow.Cells("Lote No.").Value & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Entradas = 0
                Else
                    Entradas = leer(0)
                End If
            End While
            con.Close()
            sql = New SqlCommand("SELECT SUM(Salida) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & Me.DataGridViewX1.CurrentRow.Cells("Lote No.").Value & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Salidas = 0
                Else
                    Salidas = leer(0)
                End If
            End While
            con.Close()
            Me.txtReemplazos.Text = Reemplazos
            Me.txtDefunciones.Text = Defunciones
            Me.txtDestazos.Text = Destazo
            Me.txtRastro.Text = Rastro
            Me.txtEntradas.Text = Entradas
            Me.txtSalidas.Text = Salidas
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error Recuperando Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

    End Sub
    Sub MostrarDetallesLote()
        Dim FechaCreacion, FechaModificacion As Date
        FechaCreacion = Me.DataGridViewX1.CurrentRow.Cells("Fecha Creación").Value
        Me.txtFechaCreacion.Text = Format(FechaCreacion, "dd/MM/yyyy")
        Me.txtCerdosRegistrados.Text = Me.DataGridViewX1.CurrentRow.Cells("Cerdos Registrados").Value
        Me.txtCerdosActuales.Text = Me.DataGridViewX1.CurrentRow.Cells("Total Actual").Value
        FechaModificacion = Me.DataGridViewX1.CurrentRow.Cells("Ultima Modificación").Value
        Me.txtUltiamModificacion.Text = Format(FechaModificacion, "dd/MM/yyyy")
        Me.txtConsumoCantidad.Text = Me.DataGridViewX1.CurrentRow.Cells("Cantidad Consumo").Value
        Me.txtConsumoCostos.Text = Me.DataGridViewX1.CurrentRow.Cells("Consumo Costos USS$").Value

        Me.ProgressBarX1.Maximum = Val(Me.DataGridViewX1.CurrentRow.Cells("Cerdos Registrados").Value)
        Me.ProgressBarX1.Minimum = 0
        Me.ProgressBarX1.Value = Val(Me.DataGridViewX1.CurrentRow.Cells("Total Actual").Value)
        Me.ProgressBarX1.Text = "Cerdos Actuales: " & Val(Me.DataGridViewX1.CurrentRow.Cells("Total Actual").Value)
        Me.lbRegistrados.Text = Val(Me.DataGridViewX1.CurrentRow.Cells("Cerdos Registrados").Value)
        Me.CalcularTiempo()
        Me.RecuperarMovimientosLote()
        Dim Media As Integer
        Media = Me.DataGridViewX1.CurrentRow.Cells("Cerdos Registrados").Value / 2
        If Me.txtCerdosActuales.Text = Me.txtCerdosRegistrados.Text Then
            Me.ProgressBarX2.ColorTable = eProgressBarItemColor.Normal
            Me.ProgressBarX1.ColorTable = eProgressBarItemColor.Normal
        ElseIf Me.txtCerdosActuales.Text <= Media Then
            Me.ProgressBarX2.ColorTable = eProgressBarItemColor.Paused
            Me.ProgressBarX1.ColorTable = eProgressBarItemColor.Paused
        ElseIf Me.txtCerdosActuales.Text >= 0 And Me.txtCerdosActuales.Text <= 5 Then
            Me.ProgressBarX2.ColorTable = eProgressBarItemColor.Error
            Me.ProgressBarX1.ColorTable = eProgressBarItemColor.Error
        Else
            Me.ProgressBarX1.ColorTable = eProgressBarItemColor.Normal
            Me.ProgressBarX2.ColorTable = eProgressBarItemColor.Normal
        End If
    End Sub
    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

    Private Sub DataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        Me.MostrarDetallesLote()
    End Sub
    Private Sub DataGridViewX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX1.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            Me.MostrarDetallesLote()
        End If
    End Sub
    
    Private Sub DataGridViewX1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.RowEnter
        'Me.MostrarDetallesLote()
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        ExportarDatosExcel(Me.DataGridViewX1, "..::Reporte General Lotes::..", "Desde LoteNo: " & Me.cbxLoteDesde.Text & " Hasta: " & Me.cbxLoteHasta.Text, "Fecha desde: " & Me.txtFechaDesde.Text & " Hasta: " & Me.txtFechaHasta.Text, "H")
    End Sub
End Class