Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Public Class Reporte_x_Lotes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim carrito As New DataTable("Detalles")
    Dim sql, sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11, sql12, sql13, sql14, sql15, sql16 As SqlCommand
    Dim leer As SqlDataReader
    Dim dr As DataRow
    Dim dt As DataTable
    Dim dv As DataView
    Dim meses As Integer = 1
    Dim fecha_crea, fecha_crea2 As Date
    Dim fecha_fin As Date
    Dim d, d2, m, m2, y, y2 As Integer
    Dim cont, cont2 As Integer
    Dim days_desde, days_desde2 As Integer
    Dim year_desde, year_hasta As Integer
    Dim days_hasta, days_hasta2 As Integer
    Dim year, year2 As Integer
    Dim mes, mes2 As Integer
    Dim mes_inicio, mes_inicio2 As Integer
    Dim fecha_Req As String
    Dim Pre_Inicio, Inicio, Crecimiento, Desarrollo, Final, Gestacion, Lactancia, Reemplazos, Fase2, Fase3, Nupig1, Nupig2, Inited, Nusem, Reemplazoss, Defuncion, Destazo, Rastro, Entrada, Salida, CerdosReg, Total_Cerdos As Double
    Dim Verif As Boolean = False
    Dim l As Integer
    Dim adapter As SqlDataAdapter
    Dim dts3 As DataSet
    Dim cont_progres As Integer = 0
    Dim cont_progres2 As Integer = 0
    Dim meses2 As Integer = 1
    Dim Movimientos As Integer
    Dim Mes_Fin, Mes_Fin2 As Integer
    Dim DiasCerdos As Double
    Dim Cod_Granja As String
    Dim NombreGranja As String
    Dim ExsitenTraslados As Boolean = False
    Dim CostoNacerU, AlimControladaU, AlimentacionBTU, TrasladosU As Double
    Private Sub Reporte_x_Lotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mostrar_Lote_No()
        Me.ProgressBarX1.Hide()
        Me.txtHasta.Text = Format(FechaSistema, "dd/MM/yy")
        Dim dc0 As New DataColumn("Fecha")
        Dim dc1 As New DataColumn("Dias")
        Dim dc2 As New DataColumn("Pre_Inicio", System.Type.GetType("System.Decimal"))
        Dim dc3 As New DataColumn("Inicio", System.Type.GetType("System.Decimal"))
        Dim dc4 As New DataColumn("Crecimiento", System.Type.GetType("System.Decimal"))
        Dim dc5 As New DataColumn("Desarrollo", System.Type.GetType("System.Decimal"))
        Dim dc6 As New DataColumn("Final", System.Type.GetType("System.Decimal"))
        Dim dc7 As New DataColumn("Gestación", System.Type.GetType("System.Decimal"))
        Dim dc8 As New DataColumn("Lactancia", System.Type.GetType("System.Decimal"))
        Dim dc9 As New DataColumn("Reemplazo", System.Type.GetType("System.Decimal"))
        Dim dc10 As New DataColumn("Nusem", System.Type.GetType("System.Decimal"))
        Dim dc11 As New DataColumn("Reemplazos", System.Type.GetType("System.Int32"))
        Dim dc12 As New DataColumn("Defuncion", System.Type.GetType("System.Int32"))
        Dim dc13 As New DataColumn("Destazo", System.Type.GetType("System.Int32"))
        Dim dc14 As New DataColumn("Rastro", System.Type.GetType("System.Int32"))
        Dim dc15 As New DataColumn("Entrada", System.Type.GetType("System.Int32"))
        Dim dc16 As New DataColumn("Salida", System.Type.GetType("System.Int32"))
        Dim dc17 As New DataColumn("Total_Cerdos", System.Type.GetType("System.Int32"))
        'dc16.Expression = "Reemplazos+Defuncion+Destazo+Rastro"
        With carrito.Columns
            .Add(dc0)
            .Add(dc1)
            .Add(dc2)
            .Add(dc3)
            .Add(dc4)
            .Add(dc5)
            .Add(dc6)
            .Add(dc7)
            .Add(dc8)
            .Add(dc9)
            .Add(dc10)
            .Add(dc11)
            .Add(dc12)
            .Add(dc13)
            .Add(dc14)
            .Add(dc15)
            .Add(dc16)
            .Add(dc17)
        End With
        Me.DgvDetallesCyC.DataSource = carrito

        EstiloDatagrid(Me.DgvDetallesCyC, 7, "Tahoma", FontStyle.Bold)
        Me.DgvDetallesCyC.Columns(0).Width = 65
        Me.DgvDetallesCyC.Columns(1).Width = 70
        Me.DgvDetallesCyC.Columns(2).Width = 74
        Me.DgvDetallesCyC.Columns(3).Width = 74
        Me.DgvDetallesCyC.Columns(4).Width = 74
        Me.DgvDetallesCyC.Columns(5).Width = 74
        Me.DgvDetallesCyC.Columns(6).Width = 74
        Me.DgvDetallesCyC.Columns(7).Width = 74
        Me.DgvDetallesCyC.Columns(8).Width = 74
        Me.DgvDetallesCyC.Columns(9).Width = 74
        Me.DgvDetallesCyC.Columns(10).Width = 74
        Me.DgvDetallesCyC.Columns(11).Width = 74
        Me.DgvDetallesCyC.Columns(12).Width = 74
        Me.DgvDetallesCyC.Columns(13).Width = 74
        Me.DgvDetallesCyC.Columns(14).Width = 74
        Me.DgvDetallesCyC.Columns(15).Width = 74
        Me.DgvDetallesCyC.Columns(16).Width = 74
        Me.DgvDetallesCyC.Columns(17).Width = 76

    End Sub
    Sub Mostrar_Lote_No()
        Try
            Me.CbxListaLotes.Items.Clear()
            sql = New SqlCommand("Select Lote_No from LOTES WHERE Estado='A' OR Estado='F'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.CbxListaLotes.Items.Add(leer(0))

            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error Recuperando No Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub CbxListaLotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxListaLotes.SelectedIndexChanged
        Try

            Me.lbLoteNo.Text = Me.CbxListaLotes.Text
            sql = New SqlCommand("SELECT Fecha_Creacion, Cerdos_Nacidos, Codigo_Granja FROM LOTES WHERE Lote_No='" & Me.CbxListaLotes.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.txtDesde.Text = Format(leer(0), "dd/MM/yy")
                Me.txtFechaCreacion.Text = Format(leer(0), "dd/MM/yy")
                Me.txtCantidadCerdos.Text = leer(1)
                Cod_Granja = leer(2)
            End While
            con.Close()
            sql = New SqlCommand("Select Nombre FROM Granjas WHERE Codigo_Granja='" & Cod_Granja & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.NombreGranja = Trim(UCase(leer(0)))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error Recuperar Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Function Sumar(ByVal nombre_Columna As String, ByVal Dgv As DataGridView) As Double
        Dim total As Double = 0
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total
    End Function
    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        Me.Cursor = Cursors.WaitCursor

        Me.panelEspere.Visible = True
        Me.btnMostrar.Enabled = False
        Me.ButtonX1.Enabled = False
        Me.ButtonX2.Enabled = False
        Me.ExsitenTraslados = False
        If ValidarFechas(Me.txtDesde.Text) = False Then
            Me.txtDesde.Select()
            Me.txtDesde.Focus()
        ElseIf ValidarFechas(Me.txtHasta.Text) = False Then
            Me.txtHasta.Select()
            Me.txtHasta.Focus()
        Else
            Try
                sql16 = New SqlCommand("Select Fecha_Creacion from LOTES WHERE Lote_No='" & Me.CbxListaLotes.Text & "'", con)
                con.Open()
                leer = sql16.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        DiasCerdos = 0
                    Else
                        Dim FechaCreacion As Date = leer(0)
                        Dim FechaDesdeInicio As Date = Me.txtDesde.Text
                        DiasCerdos = (FechaDesdeInicio - FechaCreacion).TotalDays
                    End If
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            Me.lbDesde.Text = Format(Me.txtDesde.Text, "Long Date")
            Me.lbHasta.Text = Format(Me.txtHasta.Text, "Long Date")
            cont_progres = 0
            cont_progres2 = 0
            Me.ProgressBarX1.Show()
            Me.ProgressBarX1.Value = 0
            For i As Integer = 0 To carrito.Rows.Count - 1
                carrito.Rows.Clear()
            Next
            '*************************************************************************
            'Verif = False
            days_desde2 = 0
            mes_inicio2 = 0
            mes2 = 0

            days_desde2 = Me.txtDesde.Text.Substring(0, 2)
            mes_inicio2 = Me.txtDesde.Text.Substring(3, 2)
            Mes_Fin2 = 0
            Mes_Fin2 = Me.txtHasta.Text.Substring(3, 2)
            Try
                For y2 As Integer = Me.txtDesde.Text.Substring(6, 2) To Me.txtHasta.Text.Substring(6, 2)
                    year2 = y2
                    If mes2 = 12 Then
                        mes_inicio2 = 1
                        meses2 += 1
                    End If
                    If year2 <> Me.txtHasta.Text.Substring(6, 2) Then
                        Mes_Fin2 = 12
                    Else
                        Mes_Fin2 = Me.txtHasta.Text.Substring(3, 2)
                    End If
                    For m2 = mes_inicio2 To Mes_Fin2
                        mes2 = m2
                        If mes2 = Me.txtHasta.Text.Substring(3, 2) And year2 = Me.txtHasta.Text.Substring(6, 2) Then
                            days_hasta2 = Me.txtHasta.Text.Substring(0, 2)
                        Else
                            days_hasta2 = Date.DaysInMonth(year2, mes2)
                        End If
                        For d2 = days_desde2 To days_hasta2
                            cont_progres += 1
                            cont2 = d2
                            days_desde2 = d2
                            Me.ProgressBarX1.Maximum = cont_progres

                            If cont2 = Date.DaysInMonth(year2, mes2) Then
                                days_desde2 = 1
                            End If
                        Next
                    Next
                Next
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            With My.Forms.dlgEspera
                .Show()
                .Progreso.Maximum = cont_progres
                .Progreso.Value = cont_progres2
                .Show()
            End With

            Try
                sql = New SqlCommand("select Cerdos_Nacidos from LOTES  WHERE Lote_No='" & Me.CbxListaLotes.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CerdosReg = leer(0)
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            '***************************************************************************************************
            Try
                Verif = False
                days_desde = 0
                mes_inicio = 0
                mes = 0
                days_desde = Me.txtDesde.Text.Substring(0, 2)
                mes_inicio = Me.txtDesde.Text.Substring(3, 2)
                Mes_Fin = 0
                Mes_Fin = Me.txtHasta.Text.Substring(3, 2)
                For y As Integer = Me.txtDesde.Text.Substring(6, 2) To Me.txtHasta.Text.Substring(6, 2)
                    year = y
                    If mes = 12 Then
                        mes_inicio = 1
                        meses += 1
                    End If
                    If year <> Me.txtHasta.Text.Substring(6, 2) Then
                        Mes_Fin = 12
                    Else
                        Mes_Fin = Me.txtHasta.Text.Substring(3, 2)
                    End If
                    For m = mes_inicio To Mes_Fin
                        mes = m
                        If mes = Me.txtHasta.Text.Substring(3, 2) And year = Me.txtHasta.Text.Substring(6, 2) Then
                            days_hasta = Me.txtHasta.Text.Substring(0, 2)
                        Else
                            days_hasta = Date.DaysInMonth(year, mes)
                        End If
                        For d = days_desde To days_hasta
                            cont = d
                            days_desde = d
                            cont_progres2 += 1
                            Me.ProgressBarX1.Value = cont_progres2
                            Me.ProgressBarX1.Text = "Diás Generados..." & cont_progres2 & " de " & cont_progres
                            '***************************************CONSULTAS*****************************************
                            sql = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='PI' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql1 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='I' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql2 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='C' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql3 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='D' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql4 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='F' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql5 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='G' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql6 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='L' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql7 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='R' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql8 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='UN' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.CbxListaLotes.Text & "' GROUP BY b.Fecha", con)
                            sql9 = New SqlCommand("select SUM(Reemplazos) from MOVIMIENTO_LOTE where Lote_No='" & Me.CbxListaLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql10 = New SqlCommand("select SUM(Defuncion) from MOVIMIENTO_LOTE where Lote_No='" & Me.CbxListaLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql11 = New SqlCommand("select SUM(Destazo) from MOVIMIENTO_LOTE where Lote_No='" & Me.CbxListaLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql12 = New SqlCommand("select SUM(Rastro) from MOVIMIENTO_LOTE where Lote_No='" & Me.CbxListaLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql13 = New SqlCommand("select SUM(Entrada) from MOVIMIENTO_LOTE where Lote_No='" & Me.CbxListaLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql14 = New SqlCommand("select SUM(Salida) from MOVIMIENTO_LOTE where Lote_No='" & Me.CbxListaLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)

                            sql15 = New SqlCommand("Select Cerdos_Nacidos, Fecha_Creacion from LOTES where Lote_No='" & Me.CbxListaLotes.Text & "'", con)

                            '******************************************************************************************
                            Dim FechaCorrelativa As Date = days_desde & "/" & m & "/" & y
                            con.Open()
                            leer = sql.ExecuteReader
                            dr = carrito.NewRow
                            dr(0) = FechaCorrelativa
                            dr(1) = DiasCerdos + Me.DgvDetallesCyC.Rows.Count
                            dr(2) = 0
                            dr(3) = 0
                            dr(4) = 0
                            dr(5) = 0
                            dr(6) = 0
                            dr(7) = 0
                            dr(8) = 0
                            dr(9) = 0
                            dr(10) = 0
                            dr(11) = 0
                            dr(12) = 0
                            dr(13) = 0
                            dr(14) = 0
                            dr(15) = 0
                            dr(16) = 0
                            dr(17) = CerdosReg
                            '**********************BLOQUE COLUMNA PRE-INICIO******************************
                            While leer.Read
                                Verif = True
                                Me.fecha_Req = leer(0)
                                Pre_Inicio = leer(1)
                            End While
                            con.Close()
                            If Verif = True Then
                                If Me.fecha_Req.Substring(0, 2) = d Then

                                    dr(2) = Pre_Inicio
                                End If
                            End If
                            '***************************************************************************
                            '************************* BLOQUE COLUMNA INICIO************************
                            con.Open()
                            leer = sql1.ExecuteReader
                            While leer.Read
                                Inicio = leer(1)
                                dr(3) = Math.Round(Inicio, 2)
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA CRECIMIENTO************************
                            con.Open()
                            leer = sql2.ExecuteReader
                            While leer.Read
                                Crecimiento = leer(1)
                                dr(4) = Math.Round(Crecimiento, 2)
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA DESARROLLO************************
                            con.Open()
                            leer = sql3.ExecuteReader
                            While leer.Read
                                Desarrollo = leer(1)
                                dr(5) = Math.Round(Desarrollo, 2)
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA FINAL******************************
                            con.Open()
                            leer = sql4.ExecuteReader
                            While leer.Read
                                Final = leer(1)
                                dr(6) = Math.Round(Final, 2)
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA GESTACION******************************
                            con.Open()
                            leer = sql5.ExecuteReader
                            While leer.Read
                                Gestacion = leer(1)
                                dr(7) = Math.Round(Gestacion, 2)
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA LACTANCIA******************************
                            con.Open()
                            leer = sql6.ExecuteReader
                            While leer.Read
                                Lactancia = leer(1)
                                dr(8) = Math.Round(Lactancia, 2)
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA REEMPLAZO******************************
                            con.Open()
                            leer = sql7.ExecuteReader
                            While leer.Read
                                Reemplazos = leer(1)
                                dr(9) = Math.Round(Reemplazos, 2)
                            End While
                            con.Close()
                            '****************************************************************************

                            '************************* BLOQUE COLUMNA NUSEM******************************
                            con.Open()
                            leer = sql8.ExecuteReader
                            While leer.Read
                                Nusem = leer(1)
                                dr(10) = Math.Round(Nusem, 2)
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA REEMPLAZOSS******************************
                            con.Open()
                            leer = sql9.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Reemplazoss = 0
                                Else
                                    Reemplazoss = leer(0)
                                    dr(11) = Math.Round(Reemplazoss, 2)
                                End If
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA DEFUNCION******************************
                            con.Open()
                            leer = sql10.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Defuncion = 0
                                Else
                                    Defuncion = leer(0)
                                    dr(12) = Math.Round(Defuncion, 2)
                                End If
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA DESTAZO******************************
                            con.Open()
                            leer = sql11.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Destazo = 0
                                Else
                                    Destazo = leer(0)
                                    dr(13) = Math.Round(Destazo, 2)
                                End If
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA RASTRO******************************
                            con.Open()
                            leer = sql12.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Rastro = 0
                                Else
                                    Rastro = leer(0)
                                    dr(14) = Math.Round(Rastro, 2)
                                End If
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA ENTRADA******************************
                            con.Open()
                            leer = sql13.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Entrada = 0
                                Else
                                    Entrada = leer(0)
                                    dr(15) = Math.Round(Entrada, 2)
                                End If
                            End While
                            con.Close()
                            '****************************************************************************
                            '************************* BLOQUE COLUMNA SALIDA******************************
                            con.Open()
                            leer = sql14.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Salida = 0
                                Else
                                    Salida = leer(0)
                                    dr(16) = Math.Round(Salida, 2)
                                End If
                            End While
                            con.Close()
                            '****************************************************************************
                            carrito.Rows.Add(dr)
                            '************************* BLOQUE COLUMNA TOTAL_CERDOS******************************
                            con.Open()
                            leer = sql15.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    dr(17) = CerdosReg
                                Else
                                    Total_Cerdos = ((CerdosReg + Entrada) - (Reemplazoss + Defuncion + Destazo + Rastro + Salida))
                                    CerdosReg = Total_Cerdos
                                    dr(17) = Math.Round(Total_Cerdos, 2)
                                End If
                            End While
                            con.Close()
                            '****************************************************************************
                            If cont = Date.DaysInMonth(year, mes) Then
                                days_desde = 1
                            End If
                        Next
                    Next
                Next
                If Me.ProgressBarX1.Value = cont_progres Then
                    Me.ProgressBarX1.Hide()
                End If
            Catch ex As Exception
                MessageBox.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()

            End Try
            dr = carrito.NewRow
            dr(1) = "TOTALES"
            dr(2) = Sumar("Pre_Inicio", Me.DgvDetallesCyC)
            dr(3) = Sumar("Inicio", Me.DgvDetallesCyC)
            dr(4) = Sumar("Crecimiento", Me.DgvDetallesCyC)
            dr(5) = Sumar("Desarrollo", Me.DgvDetallesCyC)
            dr(6) = Sumar("Final", Me.DgvDetallesCyC)
            dr(7) = Sumar("Gestación", Me.DgvDetallesCyC)
            dr(8) = Sumar("Lactancia", Me.DgvDetallesCyC)
            dr(9) = Sumar("Reemplazo", Me.DgvDetallesCyC)
            dr(10) = Sumar("Nusem", Me.DgvDetallesCyC)
            dr(11) = Sumar("Reemplazos", Me.DgvDetallesCyC)
            dr(12) = Sumar("Defuncion", Me.DgvDetallesCyC)
            dr(13) = Sumar("Destazo", Me.DgvDetallesCyC)
            dr(14) = Sumar("Rastro", Me.DgvDetallesCyC)
            dr(15) = Sumar("Entrada", Me.DgvDetallesCyC)
            dr(16) = Sumar("Salida", Me.DgvDetallesCyC)
            dr(17) = CerdosReg
            carrito.Rows.Add(dr)

            ' ''****************************SUMA DE COLUMNAS******************************
            'Me.txtPreinicio.Text = Sumar("Pre_Inicio", Me.DgvDetallesCyC)
            'Me.txtInicio.Text = Sumar("Inicio", Me.DgvDetallesCyC)                    '*
            'Me.txtCrecimiento.Text = Sumar("Crecimiento", Me.DgvDetallesCyC)          '*
            'Me.txtDesarrollo.Text = Sumar("Desarrollo", Me.DgvDetallesCyC)            '*
            'Me.txtFinal.Text = Sumar("Final", Me.DgvDetallesCyC)                      '*
            'Me.txtGestacion.Text = Sumar("Gestación", Me.DgvDetallesCyC)              '*
            'Me.txtLactancia.Text = Sumar("Lactancia", Me.DgvDetallesCyC)              '*
            'Me.txtReemplazo.Text = Sumar("Reemplazo", Me.DgvDetallesCyC)              '*
            'Me.txtNusem.Text = Sumar("Nusem", Me.DgvDetallesCyC)
            'Me.txtReemplazos.Text = Sumar("Reemplazos", Me.DgvDetallesCyC)            '*
            'Me.txtDefuncion.Text = Sumar("Defuncion", Me.DgvDetallesCyC)
            'Me.txtDestazo.Text = Sumar("Destazo", Me.DgvDetallesCyC)
            'Me.txtRastro.Text = Sumar("Rastro", Me.DgvDetallesCyC)
            'Me.txtEntrada.Text = Sumar("Entrada", Me.DgvDetallesCyC)
            'Me.txtSalida.Text = Sumar("Salida", Me.DgvDetallesCyC)
            'Me.txtTotalCerdos1.Text = CerdosReg        '*
            ' ''**************************************************************************
            Me.lbSemanas.Text = Math.Round(Me.DgvDetallesCyC.Rows.Count / 7, 0)
            Me.lbMeses.Text = Math.Round(Me.DgvDetallesCyC.Rows.Count * 0.0328549112, 1)
            Me.lbHoras.Text = Math.Round(Me.DgvDetallesCyC.Rows.Count * 24, 0)

        End If
        Try

            sql = New SqlCommand("Select SUM(Costo) FROM TrasladosEntreLotes WHERE De_Lote='" & Me.CbxListaLotes.Text & "' and Fecha_Traslado<='" & Me.txtHasta.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Me.txtCostoTraslado.Text = 0
                Else
                    Me.txtCostoTraslado.Text = Math.Round(leer(0) * CerdosReg, 2)
                    Me.ExsitenTraslados = True
                    Me.TrasladosU = leer(0)
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Try


            If Me.ExsitenTraslados = False Then
                sql = New SqlCommand("select SUM(Costo_al_Nacer) FROM Costos_al_Nacer_x_Lotes WHERE Lote_No='" & Me.CbxListaLotes.Text & "' and Fecha_Registro<='" & Me.txtHasta.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        Me.txtCostoAlNacer.Text = 0
                    Else
                        Me.txtCostoAlNacer.Text = Math.Round(leer(0) * CerdosReg, 2)
                        Me.CostoNacerU = leer(0)
                    End If
                End While
                con.Close()
            Else
                Me.txtCostoAlNacer.Text = 0
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Try

            sql = New SqlCommand("Select SUM(Costo_Alimento) FROM Alimentacion_No_Controlada WHERE Lote_No='" & Me.CbxListaLotes.Text & "' and Fecha_Alimentacion<='" & Me.txtHasta.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Me.txtAlimentacionBT.Text = 0
                Else
                    Me.txtAlimentacionBT.Text = Math.Round(leer(0) * CerdosReg, 2)
                    Me.AlimentacionBTU = leer(0)
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Try
            sql = New SqlCommand("SELECT SUM(Importe) FROM LINEAS_DE_REQUISICIONES as l JOIN REQUISICIONES AS r ON l.Req_No=r.Req_No WHERE r.Fecha<='" & Me.txtHasta.Text & "' AND l.Lote_No='" & Me.CbxListaLotes.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Me.txtAlimentacionControlada.Text = 0
                Else
                    Me.txtAlimentacionControlada.Text = Math.Round(leer(0), 2)
                    Me.AlimControladaU = leer(0) / CerdosReg
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Me.txtTotalUnitario.Text = Math.Round((Me.CostoNacerU + Me.AlimControladaU + Me.AlimentacionBTU + Me.TrasladosU), 2)
        Me.txtTotalGeneral.Text = Format((Val(Me.txtCostoAlNacer.Text) + Val(Me.txtCostoTraslado.Text) + Val(Me.txtAlimentacionBT.Text) + Val(Me.txtAlimentacionControlada.Text)), "C")
        Me.panelEspere.Visible = False
        Me.Cursor = Cursors.Arrow
        With My.Forms.dlgEspera
            .Close()
        End With

        Me.btnMostrar.Enabled = True
        Me.ButtonX1.Enabled = True
        Me.ButtonX2.Enabled = True
    End Sub
    Sub mandarDatos()
        MandarReportACrystal(Me.DgvDetallesCyC, "Select * from Tempo_x_Lote", "ResumenReporte")
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Me.DgvDetallesCyC.Rows.Count = 0 Then
            MessageBoxEx.Show("No puede visualizar el reporte en vista de impresión debido a que no hay datos", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Me.mandarDatos()
            Try

                Dim DesdeHasta As String = "REPORTE DESDE: " & Me.txtDesde.Text & " AL: " & Me.txtHasta.Text
                Dim MostrarVisualizador = New Visualizador()
                Dim x As New Visualizador
                Dim rpt As New ReportexLote()
                rpt.SetDataSource(Dts.Tables("ResumenReporte"))
                rpt.SetParameterValue("LoteNo", "LOTE NO: " & Me.CbxListaLotes.Text)
                rpt.SetParameterValue("ReporteDesdeHasta", DesdeHasta)
                rpt.SetParameterValue("Granja", Me.NombreGranja)
                rpt.SetParameterValue("T_Cerdos", Val(CerdosReg))
                rpt.SetParameterValue("CostoalNacer", Me.CostoNacerU)
                rpt.SetParameterValue("CostoTraslado", Me.TrasladosU)
                rpt.SetParameterValue("AlimentacionBT", Me.AlimentacionBTU)
                rpt.SetParameterValue("AlimentacionCtrda", Me.AlimControladaU)
                rpt.SetParameterValue("TotalUnitario", (Me.CostoNacerU + Me.TrasladosU + Me.AlimentacionBTU + Me.AlimControladaU))
                rpt.SetParameterValue("CostoAlNacerT", Me.CostoNacerU * CerdosReg)
                rpt.SetParameterValue("CostoTrasladoT", Me.TrasladosU * CerdosReg)
                rpt.SetParameterValue("AlimentacionBTT", Me.AlimentacionBTU * CerdosReg)
                rpt.SetParameterValue("AlimentacionCtrdaT", Me.AlimControladaU * CerdosReg)
                rpt.SetParameterValue("TotalT", (Me.CostoNacerU * CerdosReg) + (Me.TrasladosU * CerdosReg) + (Me.AlimentacionBTU * CerdosReg) + (Me.AlimControladaU * CerdosReg))
                x.Text = "Reporte x Lote " & FechaSistema
                x.CrReporteViewerç.ReportSource = rpt
                x.MdiParent = Me.MdiParent
                x.Show()

            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        ExportarDatosExcel(Me.DgvDetallesCyC, "Reporte de Cantidad Consumo", "LOTE NO: " & Me.CbxListaLotes.Text, "REPORTE DEL: " & Me.txtDesde.Text & " AL " & Me.txtHasta.Text, "S")
    End Sub
    Private Sub TextBoxX7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesde.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.txtDesde.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtDesde.Text = Me.txtDesde.Text & "/"
            Me.txtDesde.SelectionStart = 4
        ElseIf Me.txtDesde.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtDesde.Text = Me.txtDesde.Text & "/"
            Me.txtDesde.SelectionStart = 6
        End If
    End Sub
    Private Sub txtHasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHasta.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.txtHasta.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtHasta.Text = Me.txtHasta.Text & "/"
            Me.txtHasta.SelectionStart = 4
        ElseIf Me.txtHasta.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtHasta.Text = Me.txtHasta.Text & "/"
            Me.txtHasta.SelectionStart = 6
        End If
    End Sub
    Private Sub txtCantidadCerdos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadCerdos.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

   
    Private Sub CbxListaLotes_TabStopChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxListaLotes.TabStopChanged
        CbxListaLotes_SelectedIndexChanged(sender, e)
    End Sub
End Class