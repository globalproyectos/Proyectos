Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports System.Data.SqlClient
Imports System.Data
Public Class frmComparacionTotalesA_CalculadoyFisico
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
    Dim TotalCantidad_x_Dia, Inicio, Crecimiento, Desarrollo, Final, Gestacion, Lactancia, Reemplazos, Fase2, Fase3, Nupig1, Nupig2, Inited, Nusem, Reemplazoss, Defuncion, Destazo, Rastro, Entrada, Salida, CerdosReg, Total_Cerdos As Double
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
    Dim Total_DiarioF, Total_DiarioFU As Double
    Dim Total_AcuCal, Total_AcuCalU As Double
    Dim CostoNacerU, AlimControladaU, AlimentacionBTU, TrasladosU As Double

    Private Sub frmComparacionTotalesA_CalculadoyFisico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tabla()
        CargarLotes(Me.cbxLotes)
        Me.ProgressBarX1.Hide()
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub
    Private Sub txtDesde_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesde.GotFocus
        If Not Me.txtDesde.Text <> "dd/mm/aa" Then
            Me.txtDesde.Clear()
        End If
    End Sub
    Private Sub txtDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesde.KeyPress
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
    Sub Tabla()
        Dim dc0 As New DataColumn("Fecha")
        Dim dc1 As New DataColumn("Dias")
        Dim dc2 As New DataColumn("No. Cerdos", System.Type.GetType("System.Int32"))
        Dim dc3 As New DataColumn("C. Diario Fisico {Total/Unitario} Lbs.", System.Type.GetType("System.String"))
        Dim dc4 As New DataColumn("Peso Vivo Lbs.", System.Type.GetType("System.String"))
        Dim dc5 As New DataColumn("C. Lbs. Diario Calculado", System.Type.GetType("System.String"))
        Dim dc6 As New DataColumn("C. Lbs. Acum. Semanal", System.Type.GetType("System.String"))
        Dim dc7 As New DataColumn("Acumulado", System.Type.GetType("System.Decimal"))
       
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
        End With
        Me.DataGridViewX1.DataSource = carrito

        EstiloDatagrid(Me.DataGridViewX1, 7, "Tahoma", FontStyle.Bold)
        Me.DataGridViewX1.Columns(0).Width = 65
        Me.DataGridViewX1.Columns(1).Width = 45
        Me.DataGridViewX1.Columns(2).Width = 74
        Me.DataGridViewX1.Columns(3).Width = 90
        Me.DataGridViewX1.Columns(4).Width = 74
        Me.DataGridViewX1.Columns(5).Width = 74
        Me.DataGridViewX1.Columns(6).Width = 74
        Me.DataGridViewX1.Columns(7).Width = 74

    End Sub
    Private Sub txtHasta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHasta.GotFocus
        If Not Me.txtHasta.Text <> "dd/mm/aa" Then
            Me.txtHasta.Clear()
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
    Private Sub txtHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHasta.LostFocus
        If Me.txtHasta.Text = "" Then
            Me.txtHasta.Text = "dd/mm/aa"
        End If
    End Sub

    Private Sub txtDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesde.LostFocus
        If Me.txtDesde.Text = "" Then
            Me.txtDesde.Text = "dd/mm/aa"
        End If
    End Sub
    Private Sub cbxLotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotes.SelectedIndexChanged
        Try

            'Me.lbLoteNo.Text = Me.cbxLotes.Text
            sql = New SqlCommand("SELECT Fecha_Creacion, Cerdos_Nacidos, Codigo_Granja FROM LOTES WHERE Lote_No='" & Me.cbxLotes.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.txtDesde.Text = Format(leer(0), "dd/MM/yy")
                Me.txtDesde.Text = Format(leer(0), "dd/MM/yy")
                'Me.txtCantidadCerdos.Text = leer(1)
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

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Me.Total_DiarioF = 0
        Me.Total_DiarioFU = 0

        If ValidarFechas(Me.txtDesde.Text) = False Then
            Me.txtDesde.Select()
            Me.txtDesde.Focus()
        ElseIf ValidarFechas(Me.txtHasta.Text) = False Then
            Me.txtHasta.Select()
            Me.txtHasta.Focus()
        Else
            Try

         
                sql16 = New SqlCommand("Select Fecha_Creacion from LOTES WHERE Lote_No='" & Me.cbxLotes.Text & "'", con)
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

                cont_progres = 0
                cont_progres2 = 0
                Me.ProgressBarX1.Show()
                Me.ProgressBarX1.Value = 0
                For i As Integer = 0 To carrito.Rows.Count - 1
                    carrito.Rows.Clear()
                Next

                '********************************************************************************************************
                days_desde2 = 0
                mes_inicio2 = 0
                mes2 = 0

                days_desde2 = Me.txtDesde.Text.Substring(0, 2)
                mes_inicio2 = Me.txtDesde.Text.Substring(3, 2)
                Mes_Fin2 = 0
                Mes_Fin2 = Me.txtHasta.Text.Substring(3, 2)

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
                sql = New SqlCommand("select Cerdos_Nacidos from LOTES  WHERE Lote_No='" & Me.cbxLotes.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CerdosReg = leer(0)
                End While
                con.Close()

                'Try
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
                            Me.ProgressBarX1.Text = "Cargando..." & cont_progres2 & " días"
                            '***************************************CONSULTAS*****************************************
                            sql = New SqlCommand("SELECT r.Fecha, SUM(a.Libras) FROM LINEAS_DE_REQUISICIONES AS a JOIN REQUISICIONES AS r ON a.Req_No=r.Req_No WHERE a.Lote_No='" & Me.cbxLotes.Text & "' and r.Fecha = '" & d & "/" & m & "/" & y & "'  group by r.Fecha", con)
                            sql2 = New SqlCommand("declare @Dias int" _
                                                  & " set @Dias ='" & DiasCerdos + Me.DataGridViewX1.Rows.Count & "'" _
                                                  & " SELECT a.Peso_Vivo_Kg_Acumulado FROM tablaAlimenticiaLM80_HC40 AS a WHERE @Dias between a.Edad_Dias and a.Hasta_Dias ", con)
                            sql3 = New SqlCommand("declare @Dias1 int" _
                                                  & " set @Dias1 ='" & DiasCerdos + Me.DataGridViewX1.Rows.Count & "'" _
                                                  & " SELECT a.Consumo_Kg_Diario FROM tablaAlimenticiaLM80_HC40 AS a WHERE @Dias1 between a.Edad_Dias and a.Hasta_Dias ", con)
                            sql4 = New SqlCommand("declare @Dias int" _
                                                  & " set @Dias ='" & DiasCerdos + Me.DataGridViewX1.Rows.Count & "'" _
                                                  & " SELECT a.Consumo_Kg_Acumulado FROM tablaAlimenticiaLM80_HC40 AS a WHERE @Dias = a.Edad_Dias ", con)
                            sql5 = New SqlCommand("declare @Dias int" _
                                                 & " set @Dias ='" & DiasCerdos + Me.DataGridViewX1.Rows.Count & "'" _
                                                 & " SELECT a.CA_Acumulado_Kg FROM tablaAlimenticiaLM80_HC40 AS a WHERE @Dias = a.Edad_Dias ", con)
                            'sql = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='PI' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            'sql1 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='I' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            'sql2 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='C' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            'sql3 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='D' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            'sql4 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='F' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            'sql5 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='G' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            'sql6 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='L' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            'sql7 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='R' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            'sql8 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='UN' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                            '                     & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' and a.Lote_No='" & Me.cbxLotes.Text & "' GROUP BY b.Fecha", con)
                            sql9 = New SqlCommand("select SUM(Reemplazos) from MOVIMIENTO_LOTE where Lote_No='" & Me.cbxLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql10 = New SqlCommand("select SUM(Defuncion) from MOVIMIENTO_LOTE where Lote_No='" & Me.cbxLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql11 = New SqlCommand("select SUM(Destazo) from MOVIMIENTO_LOTE where Lote_No='" & Me.cbxLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql12 = New SqlCommand("select SUM(Rastro) from MOVIMIENTO_LOTE where Lote_No='" & Me.cbxLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql13 = New SqlCommand("select SUM(Entrada) from MOVIMIENTO_LOTE where Lote_No='" & Me.cbxLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)
                            sql14 = New SqlCommand("select SUM(Salida) from MOVIMIENTO_LOTE where Lote_No='" & Me.cbxLotes.Text & "' and Fecha_Movimiento='" & d & "/" & m & "/" & y & " '", con)

                            sql15 = New SqlCommand("Select Cerdos_Nacidos, Fecha_Creacion from LOTES where Lote_No='" & Me.cbxLotes.Text & "'", con)

                            '******************************************************************************************
                            Dim FechaRecorrida As Date = days_desde & "/" & m & "/" & y

                            con.Open()
                            leer = sql.ExecuteReader
                            dr = carrito.NewRow
                            dr(0) = Format(FechaRecorrida, "dd/MM/yyyy")
                            dr(1) = DiasCerdos + Me.DataGridViewX1.Rows.Count
                            dr(2) = 0
                            dr(3) = 0
                            dr(4) = 0
                            dr(5) = 0
                            dr(6) = 0
                            dr(7) = 0
                            '**********************BLOQUE COLUMNA PRE-INICIO******************************

                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    TotalCantidad_x_Dia = 0
                                Else
                                    Verif = True
                                    Me.fecha_Req = leer(0)
                                    TotalCantidad_x_Dia = leer(1)
                                    ''Total_DiarioF += TotalCantidad_x_Dia
                                    'Total_DiarioFU += TotalCantidad_x_Dia / CerdosReg
                                End If
                            End While
                            con.Close()
                            '************************* BLOQUE COLUMNA REEMPLAZOSS******************************
                            con.Open()
                            leer = sql9.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Reemplazoss = 0
                                Else
                                    Reemplazoss = leer(0)

                                End If
                            End While
                            con.Close()
                            '****************************************************************************
                            ''************************* BLOQUE COLUMNA DEFUNCION******************************
                            con.Open()
                            leer = sql10.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Defuncion = 0
                                Else
                                    Defuncion = leer(0)

                                End If
                            End While
                            con.Close()
                            ''****************************************************************************
                            ''************************* BLOQUE COLUMNA DESTAZO******************************
                            con.Open()
                            leer = sql11.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Destazo = 0
                                Else
                                    Destazo = leer(0)

                                End If
                            End While
                            con.Close()
                            ''****************************************************************************
                            ''************************* BLOQUE COLUMNA RASTRO******************************
                            con.Open()
                            leer = sql12.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Rastro = 0
                                Else
                                    Rastro = leer(0)

                                End If
                            End While
                            con.Close()
                            ''****************************************************************************
                            ''************************* BLOQUE COLUMNA ENTRADA******************************
                            con.Open()
                            leer = sql13.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Entrada = 0
                                Else
                                    Entrada = leer(0)

                                End If
                            End While
                            con.Close()
                            ''****************************************************************************
                            ''************************* BLOQUE COLUMNA SALIDA******************************
                            con.Open()
                            leer = sql14.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    Salida = 0
                                Else
                                    Salida = leer(0)

                                End If
                            End While
                            con.Close()
                            ''****************************************************************************

                            ''************************* BLOQUE COLUMNA TOTAL_CERDOS******************************
                            con.Open()
                            leer = sql15.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    dr(17) = CerdosReg
                                Else
                                    Total_Cerdos = ((CerdosReg + Entrada) - (Reemplazoss + Defuncion + Destazo + Rastro + Salida))
                                    CerdosReg = Total_Cerdos
                                    dr(2) = Math.Round(Total_Cerdos, 2)
                                End If
                            End While
                            con.Close()


                            If Verif = True Then
                                If Me.fecha_Req.Substring(0, 2) = d Then
                                    dr(3) = TotalCantidad_x_Dia
                                End If
                            End If
                            '***************************************************************************

                            con.Open()
                            leer = sql2.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    dr(4) = 0
                                Else

                                    dr(4) = leer(0) * CerdosReg & "/" & ((leer(0) * CerdosReg) / CerdosReg)
                                End If
                            End While
                            con.Close()
                            '***************************************************************************
                            '***************************************************************************
                            con.Open()
                            leer = sql3.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    dr(5) = 0
                                Else
                                    dr(5) = leer(0) * CerdosReg '& "/" & ((leer(0) * CerdosReg) / CerdosReg)
                                    Total_DiarioF += TotalCantidad_x_Dia
                                End If
                            End While
                            con.Close()
                            '***************************************************************************

                            '***************************************************************************
                            con.Open()
                            leer = sql4.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    dr(6) = 0
                                Else

                                    dr(6) = leer(0) * CerdosReg & "/" & ((leer(0) * CerdosReg) / CerdosReg)
                                End If
                            End While
                            con.Close()
                            '***************************************************************************

                            '***************************************************************************
                            con.Open()
                            leer = sql5.ExecuteReader
                            While leer.Read
                                If leer.IsDBNull(0) = True Then
                                    dr(7) = 0
                                Else
                                    dr(7) = leer(0) * CerdosReg '* CerdosReg & "/" & leer(0)
                                    'Total_AcuCal += leer(0) * CerdosReg
                                    'Total_AcuCalU += leer(0)
                                End If
                            End While
                            con.Close()


                            '****************************************************************************
                            carrito.Rows.Add(dr)
                            If cont = Date.DaysInMonth(year, mes) Then
                                days_desde = 1
                            End If
                        Next
                    Next

                Next
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            If Me.ProgressBarX1.Value = cont_progres Then
                Me.ProgressBarX1.Hide()
            End If
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)

            'End Try

        End If

        Me.Label2.Text = Sumar("C. Lbs. Diario Calculado", Me.DataGridViewX1)
        Me.Label1.Text = Sumar("C. Diario Fisico {Total/Unitario} Lbs.", Me.DataGridViewX1)
        'Me.Label2.Text = Total_DiarioF & "  " & Total_DiarioFU
    End Sub

   
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        ExportarDatosExcel(Me.DataGridViewX1, "Reporte X", "LOTE NO: " & Me.cbxLotes.Text, "REPORTE DEL: " & Me.txtDesde.Text & " AL " & Me.txtHasta.Text, "I")
    End Sub

    Private Sub txtDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesde.TextChanged

    End Sub
End Class