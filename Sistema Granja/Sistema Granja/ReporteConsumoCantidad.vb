Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Public Class ReporteConsumoCantidad
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim sql, sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11, sql12 As SqlCommand
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
    Dim Pre_Inicio, Inicio, Crecimiento, Desarrollo, Final, Gestacion, Lactancia, Reemplazos, Fase2, Fase3, Nupig1, Nupig2, Inited, Nusem, Total As Double
    Dim Verif As Boolean = False
    Dim l As Integer
    Dim carrito As New DataTable("Detalles")
    Dim adapter As SqlDataAdapter
    Dim dts3 As DataSet
    Dim cont_progres As Integer = 0
    Dim cont_progres2 As Integer = 0
    Dim meses2 As Integer = 1
    Dim Mes_Fin, Mes_Fin2 As Integer
    Private Sub ReporteConsumoCantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ProgressBarX1.Hide()
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
        Dim dc11 As New DataColumn("Total")
        dc11.Expression = "Pre_Inicio+Inicio+Crecimiento+Desarrollo+Final+Gestación+Lactancia+Reemplazo+Nusem"
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
         End With
        Me.DataGridView1.DataSource = carrito
        EstiloDatagrid(Me.DataGridView1, 8, "Tahoma", FontStyle.Bold)
        Me.DataGridView1.Columns(0).Width = 77
        Me.DataGridView1.Columns(1).Width = 90
        Me.DataGridView1.Columns(2).Width = 95
        Me.DataGridView1.Columns(3).Width = 95
        Me.DataGridView1.Columns(4).Width = 95
        Me.DataGridView1.Columns(5).Width = 95
        Me.DataGridView1.Columns(6).Width = 95
        Me.DataGridView1.Columns(7).Width = 95
        Me.DataGridView1.Columns(8).Width = 95
        Me.DataGridView1.Columns(9).Width = 95
        Me.DataGridView1.Columns(10).Width = 95
        Me.DataGridView1.Columns(11).Width = 95

        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.DataGridView1.Columns(0).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(1).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(2).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(5).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(6).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(7).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(8).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(9).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(10).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DataGridView1.Columns(11).DefaultCellStyle.Format = "###,###,##0.00"
        'Me.DataGridView1.Columns(12).DefaultCellStyle.Format = "###,###,##0.00"
       
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
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click

        If ValidarFechas(Me.CajaFecha1.txtFecha.Text) = False Then
            Me.CajaFecha1.txtFecha.Select()
            Me.CajaFecha1.txtFecha.Focus()
        ElseIf ValidarFechas(Me.CajaFecha2.txtFecha.Text) = False Then
            Me.CajaFecha2.txtFecha.Select()
            Me.CajaFecha2.txtFecha.Focus()
        Else
            Me.Cursor = Cursors.WaitCursor
            Me.panelEspere.Visible = True
            Me.btnMostrar.Enabled = False
            Me.btnExportar.Enabled = True
            Me.btnImprimir.Enabled = False


            Me.lbDesde.Text = Format(Me.CajaFecha1.txtFecha.Text, "Long Date")
            Me.lbHasta.Text = Format(Me.CajaFecha2.txtFecha.Text, "Long Date")
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
            days_desde2 = Me.CajaFecha1.txtFecha.Text.Substring(0, 2)
            mes_inicio2 = Me.CajaFecha1.txtFecha.Text.Substring(3, 2)
            Mes_Fin2 = 0
            Mes_Fin2 = Me.CajaFecha2.txtFecha.Text.Substring(3, 2)
            Try


                For y2 As Integer = Me.CajaFecha1.txtFecha.Text.Substring(6, 2) To Me.CajaFecha2.txtFecha.Text.Substring(6, 2)
                    year2 = y2
                    If mes2 = 12 Then
                        mes_inicio2 = 1
                        meses2 += 1
                    End If
                    If year2 <> Me.CajaFecha2.txtFecha.Text.Substring(6, 2) Then
                        Mes_Fin2 = 12
                    Else
                        Mes_Fin2 = Me.CajaFecha2.txtFecha.Text.Substring(3, 2)
                    End If
                    For m2 = mes_inicio2 To Mes_Fin2
                        mes2 = m2
                        If mes2 = Me.CajaFecha2.txtFecha.Text.Substring(3, 2) And year2 = Me.CajaFecha2.txtFecha.Text.Substring(6, 2) Then
                            days_hasta2 = Me.CajaFecha2.txtFecha.Text.Substring(0, 2)
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

            '***************************************************************************************************
            Try
                Verif = False
                days_desde = 0
                mes_inicio = 0
                mes = 0
                days_desde = Me.CajaFecha1.txtFecha.Text.Substring(0, 2)
                mes_inicio = Me.CajaFecha1.txtFecha.Text.Substring(3, 2)
                Mes_Fin = 0
                Mes_Fin = Me.CajaFecha2.txtFecha.Text.Substring(3, 2)
                For y As Integer = Me.CajaFecha1.txtFecha.Text.Substring(6, 2) To Me.CajaFecha2.txtFecha.Text.Substring(6, 2)
                    year = y
                    If mes = 12 Then
                        mes_inicio = 1
                        meses += 1
                    End If
                    If year <> Me.CajaFecha2.txtFecha.Text.Substring(6, 2) Then
                        Mes_Fin = 12
                    Else
                        Mes_Fin = Me.CajaFecha2.txtFecha.Text.Substring(3, 2)
                    End If
                    For m = mes_inicio To Mes_Fin
                        mes = m
                        If mes = Me.CajaFecha2.txtFecha.Text.Substring(3, 2) And year = Me.CajaFecha2.txtFecha.Text.Substring(6, 2) Then
                            days_hasta = Me.CajaFecha2.txtFecha.Text.Substring(0, 2)
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
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql1 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='I' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql2 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='C' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql3 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='D' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql4 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='F' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql5 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='G' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql6 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='L' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql7 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='R' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql8 = New SqlCommand("select b.Fecha, SUM(a.Libras) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='UN' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "'GROUP BY b.Fecha", con)
                            '******************************************************************************************
                            con.Open()
                            leer = sql.ExecuteReader
                            dr = carrito.NewRow
                            dr(0) = days_desde & "/" & m & "/" & y
                            dr(1) = carrito.Rows.Count + 1
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
                            carrito.Rows.Add(dr)
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
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try

            ''****************************SUMA DE COLUMNAS******************************
            dr = carrito.NewRow
            dr(1) = "TOTALES"
            dr(2) = Sumar("Pre_Inicio", Me.DataGridView1)
            dr(3) = Sumar("Inicio", Me.DataGridView1)
            dr(4) = Sumar("Crecimiento", Me.DataGridView1)
            dr(5) = Sumar("Desarrollo", Me.DataGridView1)
            dr(6) = Sumar("Final", Me.DataGridView1)
            dr(7) = Sumar("Gestación", Me.DataGridView1)
            dr(8) = Sumar("Lactancia", Me.DataGridView1)
            dr(9) = Sumar("Reemplazo", Me.DataGridView1)
            dr(10) = Sumar("Nusem", Me.DataGridView1)
            dr(11) = Sumar("Total", Me.DataGridView1)
            carrito.Rows.Add(dr)
            ''**************************************************************************


            'Me.txtPreinicio.Text = Sumar("Pre_Inicio", Me.DataGridView1)
            'Me.txtTotalDias.Text = Me.DataGridView1.Rows.Count                       '*
            'Me.txtInicio.Text = Sumar("Inicio", Me.DataGridView1)                    '*
            'Me.txtCrecimiento.Text = Sumar("Crecimiento", Me.DataGridView1)          '*
            'Me.txtDesarrollo.Text = Sumar("Desarrollo", Me.DataGridView1)            '*
            'Me.txtFinal.Text = Sumar("Final", Me.DataGridView1)                      '*
            'Me.txtGestacion.Text = Sumar("Gestación", Me.DataGridView1)              '*
            'Me.txtLactancia.Text = Sumar("Lactancia", Me.DataGridView1)              '*
            'Me.txtReemplazo.Text = Sumar("Reemplazo", Me.DataGridView1)              '*
            'Me.txtNusem.Text = Sumar("Nusem", Me.DataGridView1)                      '*
            'Me.txtTotal.Text = Sumar("Total", Me.DataGridView1)                      '*

            Me.lbSemanas.Text = Math.Round(Me.DataGridView1.Rows.Count / 7, 0)
            Me.lbMeses.Text = Math.Round(Me.DataGridView1.Rows.Count * 0.0328549112, 1)
            Me.lbAños.Text = Math.Round(Val(Me.lbMeses.Text) / 12, 1)
            Me.lbHoras.Text = Math.Round(Me.DataGridView1.Rows.Count * 24, 0)
        End If
        Me.panelEspere.Visible = False
        Me.Cursor = Cursors.Arrow
        With My.Forms.dlgEspera
            .Close()
        End With

        Me.btnMostrar.Enabled = True
        Me.btnImprimir.Enabled = True
        Me.btnExportar.Enabled = True

    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Me.Close()
    End Sub
    Sub mandarDatos()
        MandarReportACrystal(Me.DataGridView1, "Select * from TempoConsumos", "ResumenReporte")
        'adapter = New SqlDataAdapter("select * from TempoConsumos", con)
        'dts3 = New DataSet
        'con.Open()
        'adapter.Fill(dts3, "ResumenReporte")
        'con.Close()
        'dts3.Tables("ResumenReporte").Rows.Clear()
        'Dim dr2 As DataRow
        'For i As Integer = 0 To Me.DataGridView1.RowCount - 1
        '    dr2 = dts3.Tables("ResumenReporte").NewRow

        '    dr2(0) = Me.DataGridView1.Rows(i).Cells("Fecha").Value
        '    dr2(1) = Me.DataGridView1.Rows(i).Cells("Dias").Value
        '    dr2(2) = Me.DataGridView1.Rows(i).Cells("Pre_Inicio").Value
        '    dr2(3) = Me.DataGridView1.Rows(i).Cells("Inicio").Value
        '    dr2(4) = Me.DataGridView1.Rows(i).Cells("Crecimiento").Value
        '    dr2(5) = Me.DataGridView1.Rows(i).Cells("Desarrollo").Value
        '    dr2(6) = Me.DataGridView1.Rows(i).Cells("Final").Value
        '    dr2(7) = Me.DataGridView1.Rows(i).Cells("Gestación").Value
        '    dr2(8) = Me.DataGridView1.Rows(i).Cells("Lactancia").Value
        '    dr2(9) = Me.DataGridView1.Rows(i).Cells("Reemplazo").Value
        '    dr2(10) = Me.DataGridView1.Rows(i).Cells("Nusem").Value
        '    dr2(11) = Me.DataGridView1.Rows(i).Cells("Total").Value
        '    dts3.Tables("ResumenReporte").Rows.Add(dr2)
        'Next
    End Sub
    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Me.Close()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            ExportarDatosExcel(Me.DataGridView1, "REPORTE CONSUMO CANTIDAD GENERAL", "RESUMEN", "DESDE: " & Me.CajaFecha1.txtFecha.Text & " HASTA: " & Me.CajaFecha2.txtFecha.Text, "M")
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.DataGridView1.Rows.Count = 0 Then
            MessageBoxEx.Show("No puede visualizar el reporte en vista de impresión debido a que no hay datos", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.mandarDatos()
            Try
                'Dim MostrarVisualizador = New Visualizador()
                'Dim x As New Visualizador
                'Dim rpt As New ReporteCCantidad()
                'rpt.SetDataSource(Dts.Tables("ResumenReporte"))
                'rpt.SetParameterValue("TPreinicio", Me.txtPreinicio.Text)
                'rpt.SetParameterValue("TInicio", Me.txtInicio.Text)
                'rpt.SetParameterValue("TCrecimiento", Me.txtCrecimiento.Text)
                'rpt.SetParameterValue("TDesarrollo", Me.txtDesarrollo.Text)
                'rpt.SetParameterValue("TFinal", Me.txtFinal.Text)
                'rpt.SetParameterValue("TGestacion", Me.txtGestacion.Text)
                'rpt.SetParameterValue("TLactancia", Me.txtLactancia.Text)
                'rpt.SetParameterValue("TReemplazo", Me.txtReemplazo.Text)

                'rpt.SetParameterValue("TNusem", Me.txtNusem.Text)
                'rpt.SetParameterValue("TTotal", Me.txtTotal.Text)
                'rpt.SetParameterValue("TPreinicioQ", Me.txtPreinicio.Text / 100)
                'rpt.SetParameterValue("TInicioQ", Me.txtInicio.Text / 100)
                'rpt.SetParameterValue("TCrecimientoQ", Me.txtCrecimiento.Text / 100)
                'rpt.SetParameterValue("TDesarrolloQ", Me.txtDesarrollo.Text / 100)
                'rpt.SetParameterValue("TFinalQ", Me.txtFinal.Text / 100)
                'rpt.SetParameterValue("TGestacionQ", Me.txtGestacion.Text / 100)
                'rpt.SetParameterValue("TLactanciaQ", Me.txtLactancia.Text / 100)
                'rpt.SetParameterValue("TReemplazoQ", Me.txtReemplazo.Text / 100)
                'rpt.SetParameterValue("TNusemQ", Me.txtNusem.Text / 100)
                'rpt.SetParameterValue("TTotalQ", Me.txtTotal.Text / 100)

                'rpt.SetParameterValue("Desde", Me.lbDesde.Text)
                'rpt.SetParameterValue("Hasta", Me.lbHasta.Text)
                'rpt.SetParameterValue("Meses", Me.lbMeses.Text)
                'rpt.SetParameterValue("Semanas", Me.lbSemanas.Text)
                'rpt.SetParameterValue("Dias", Me.DataGridView1.Rows.Count)
                'x.Text = "Reporte de Consumo Cantidad " & FechaSistema
                'x.CrReporteViewerç.ReportSource = rpt
                'x.MdiParent = Me.MdiParent
                'x.Show()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
    End Sub
End Class