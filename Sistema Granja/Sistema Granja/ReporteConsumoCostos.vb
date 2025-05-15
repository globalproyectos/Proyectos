Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Public Class ReporteConsumoCostos
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
    Dim dts3, dts4 As DataSet
    Dim meses2 As Integer = 1
    Dim cont_progres As Integer = 0
    Dim cont_progres2 As Integer = 0
    Dim Mes_Fin, Mes_Fin2 As Integer
    Private Sub ReporteConsumoCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.DgvCantidadCostos.DataSource = carrito

        EstiloDatagrid(Me.DgvCantidadCostos, 8, "Tahoma", FontStyle.Bold)

        Me.DgvCantidadCostos.Columns(0).Width = 77
        Me.DgvCantidadCostos.Columns(1).Width = 70
        Me.DgvCantidadCostos.Columns(2).Width = 95
        Me.DgvCantidadCostos.Columns(3).Width = 95
        Me.DgvCantidadCostos.Columns(4).Width = 95
        Me.DgvCantidadCostos.Columns(5).Width = 95
        Me.DgvCantidadCostos.Columns(6).Width = 95
        Me.DgvCantidadCostos.Columns(7).Width = 95
        Me.DgvCantidadCostos.Columns(8).Width = 95
        Me.DgvCantidadCostos.Columns(9).Width = 95
        Me.DgvCantidadCostos.Columns(10).Width = 95
        Me.DgvCantidadCostos.Columns(11).Width = 95

        Me.DgvCantidadCostos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DgvCantidadCostos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.DgvCantidadCostos.Columns(0).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(1).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(2).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(3).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(4).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(5).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(6).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(7).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(8).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(9).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(10).DefaultCellStyle.Format = "###,###,##0.00"
        Me.DgvCantidadCostos.Columns(11).DefaultCellStyle.Format = "###,###,##0.00"
        'Me.DgvCantidadCostos.Columns(12).DefaultCellStyle.Format = "###,###,##0.00"
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
            Me.btnExportar.Enabled = False
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
                            sql = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='PI' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql1 = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='I' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql2 = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='C' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql3 = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='D' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql4 = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='F' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql5 = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='G' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql6 = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='L' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql7 = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='R' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)
                            sql8 = New SqlCommand("select b.Fecha, SUM(a.Importe) AS INICIO FROM LINEAS_DE_REQUISICIONES a, REQUISICIONES b, PRODUCTOS c WHERE c.IdEtapa='UN' and a.Req_No=b.Req_No and a.Codigo_Producto= c.Codigo_Producto " _
                                                 & "and fecha='" & d & "/" & m & "/" & y & "' and a.Tipo_Documento='" & 51 & "' GROUP BY b.Fecha", con)


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
            dr = carrito.NewRow
            dr(1) = "TOTALES"
            dr(2) = Sumar("Pre_Inicio", Me.DgvCantidadCostos)
            dr(3) = Sumar("Inicio", Me.DgvCantidadCostos)
            dr(4) = Sumar("Crecimiento", Me.DgvCantidadCostos)
            dr(5) = Sumar("Desarrollo", Me.DgvCantidadCostos)
            dr(6) = Sumar("Final", Me.DgvCantidadCostos)
            dr(7) = Sumar("Gestación", Me.DgvCantidadCostos)
            dr(8) = Sumar("Lactancia", Me.DgvCantidadCostos)
            dr(9) = Sumar("Reemplazo", Me.DgvCantidadCostos)
            dr(10) = Sumar("Nusem", Me.DgvCantidadCostos)
            dr(11) = Sumar("Total", Me.DgvCantidadCostos)
            carrito.Rows.Add(dr)
            '****************************SUMA DE COLUMNAS******************************
            'Me.txtTotalDias.Text = Me.DgvCantidadCostos.Rows.Count
            'Me.txtPreinicio.Text = Sumar("Pre_Inicio", Me.DgvCantidadCostos)
            'Me.txtInicio.Text = Sumar("Inicio", Me.DgvCantidadCostos)
            'Me.txtCrecimiento.Text = Sumar("Crecimiento", Me.DgvCantidadCostos)
            'Me.txtDesarrollo.Text = Sumar("Desarrollo", Me.DgvCantidadCostos)
            'Me.txtFinal.Text = Sumar("Final", Me.DgvCantidadCostos)
            'Me.txtGestacion.Text = Sumar("Gestación", Me.DgvCantidadCostos)
            'Me.txtLactancia.Text = Sumar("Lactancia", Me.DgvCantidadCostos)
            'Me.txtReemplazo.Text = Sumar("Reemplazo", Me.DgvCantidadCostos)
            'Me.txtNusem.Text = Sumar("Nusem", Me.DgvCantidadCostos)
            'Me.txtTotal.Text = Sumar("Total", Me.DgvCantidadCostos)
            '**************************************************************************
            Me.lbSemanas.Text = Math.Round(Me.DgvCantidadCostos.Rows.Count / 7, 0)
            Me.lbMeses.Text = Math.Round(Me.DgvCantidadCostos.Rows.Count * 0.0328549112, 1)
            Me.lbHoras.Text = Math.Round(Me.DgvCantidadCostos.Rows.Count * 24, 0)
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
    Sub mandarDatos2()
        MandarReportACrystal(Me.DgvCantidadCostos, "Select * from TempoConsumos", "ResumenReporteCC")
    End Sub


    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Me.Close()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            ExportarDatosExcel(Me.DgvCantidadCostos, "REPORTE CONSUMO COSTOS GENERAL", "RESUMEN", "DESDE: " & Me.CajaFecha1.txtFecha.Text & " HASTA: " & Me.CajaFecha2.txtFecha.Text, "M")
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Me.mandarDatos2()
        Try
            Dim MostrarVisualizador = New Visualizador()
            Dim x As New Visualizador
            Dim rpt2 As New ReporteCCostos()
            rpt2.SetDataSource(Dts.Tables("ResumenReporteCC"))
            'rpt2.SetParameterValue("TPreinicio", Me.txtPreinicio.Text)
            'rpt2.SetParameterValue("TInicio", Me.txtInicio.Text)
            'rpt2.SetParameterValue("TCrecimiento", Me.txtCrecimiento.Text)
            'rpt2.SetParameterValue("TDesarrollo", Me.txtDesarrollo.Text)
            'rpt2.SetParameterValue("TFinal", Me.txtFinal.Text)
            'rpt2.SetParameterValue("TGestacion", Me.txtGestacion.Text)
            'rpt2.SetParameterValue("TLactancia", Me.txtLactancia.Text)
            'rpt2.SetParameterValue("TReemplazo", Me.txtReemplazo.Text)
            'rpt2.SetParameterValue("TNusem", Me.txtNusem.Text)
            'rpt2.SetParameterValue("TTotal", Me.txtTotal.Text)
            rpt2.SetParameterValue("Desde", Me.lbDesde.Text)
            rpt2.SetParameterValue("Hasta", Me.lbHasta.Text)
            rpt2.SetParameterValue("Meses", Me.lbMeses.Text)
            rpt2.SetParameterValue("Semanas", Me.lbSemanas.Text)
            rpt2.SetParameterValue("Dias", Me.DgvCantidadCostos.Rows.Count)
            x.Text = "Reporte de Consumo Costos " & FechaSistema
            x.CrReporteViewerç.ReportSource = rpt2
            x.MdiParent = Me.MdiParent
            x.Show()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class