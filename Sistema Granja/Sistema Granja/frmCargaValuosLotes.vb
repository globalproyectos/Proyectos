Imports System.Data
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar


Public Class frmCargaValuosLotes
    Inherits DevComponents.DotNetBar.Office2007Form
    Public LoteDesde, LoteHasta As String
    Public FechaHasta As Date
    Public Granja As String
    Dim NoLotes As Integer
    Dim LoteNo() As Double
   
    Private Sub frmCargaValuosLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Me.MostrarConsulta()
    End Sub
    Sub Estilo_y_Tamaño_Datagridview()
        EstiloDatagrid(Me.DataGridViewX1, 8, "Tahoma", FontStyle.Bold)

        Me.DataGridViewX1.Columns(0).Width = 50
        Me.DataGridViewX1.Columns(1).Width = 70
        Me.DataGridViewX1.Columns(2).Width = 75
        Me.DataGridViewX1.Columns(3).Width = 85
        Me.DataGridViewX1.Columns(4).Width = 85
        Me.DataGridViewX1.Columns(5).Width = 85
        Me.DataGridViewX1.Columns(6).Width = 85
        Me.DataGridViewX1.Columns(7).Width = 85
        Me.DataGridViewX1.Columns(8).Width = 85
        Me.DataGridViewX1.Columns(9).Width = 85
        Me.DataGridViewX1.Columns(10).Width = 85
        Me.DataGridViewX1.Columns(11).Width = 85


        Me.DataGridViewX1.Columns(3).DefaultCellStyle.Format = "###,###,###,##0.00"
        Me.DataGridViewX1.Columns(4).DefaultCellStyle.Format = "###,###,###,##0.00"
        Me.DataGridViewX1.Columns(5).DefaultCellStyle.Format = "###,###,###,##0.00"
        Me.DataGridViewX1.Columns(6).DefaultCellStyle.Format = "###,###,###,##0.00"
        Me.DataGridViewX1.Columns(7).DefaultCellStyle.Format = "###,###,###,##0.00"
        Me.DataGridViewX1.Columns(8).DefaultCellStyle.Format = "###,###,###,##0.00"
        Me.DataGridViewX1.Columns(9).DefaultCellStyle.Format = "###,###,###,##0.00"
        Me.DataGridViewX1.Columns(10).DefaultCellStyle.Format = "###,###,###,##0.00"
        Me.DataGridViewX1.Columns(11).DefaultCellStyle.Format = "###,###,###,##0.00"

        Me.DataGridViewX1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


    End Sub
    Public Sub MostrarConsulta()

        Dim cont As Integer = 0
        Dim TamañoM As Integer = 0
        dt = New DataTable
        Dim dc0 As New DataColumn("Lote No.", System.Type.GetType("System.Int32"))
        Dim dc1 As New DataColumn("Fecha Creación", System.Type.GetType("System.String"))
        Dim dc2 As New DataColumn("Existencia Final", System.Type.GetType("System.Decimal"))
        Dim dc3 As New DataColumn("Costo Traslado US$", System.Type.GetType("System.Decimal"))
        Dim dc4 As New DataColumn("Costo al Nacer US$", System.Type.GetType("System.Decimal"))
        Dim dc5 As New DataColumn("Alimentación B.T. US$", System.Type.GetType("System.Decimal"))
        Dim dc6 As New DataColumn("Alimentación Controlada US$", System.Type.GetType("System.Decimal"))
        Dim dc7 As New DataColumn("Total Unitario US$", System.Type.GetType("System.Decimal"))
        Dim dc8 As New DataColumn("Total Costo al Nacer US$", System.Type.GetType("System.Decimal"))
        Dim dc9 As New DataColumn("Total Alimentación B.T. US$", System.Type.GetType("System.Decimal"))
        Dim dc10 As New DataColumn("Total Alimentación Controlada US$", System.Type.GetType("System.Double"))
        Dim dc11 As New DataColumn("Total General US$", System.Type.GetType("System.Decimal"))
        dc10.Expression = "[Existencia Final]*[Alimentación Controlada US$]"
        dc7.Expression = "[Costo Traslado US$]+[Costo al Nacer US$]+[Alimentación B.T. US$]+[Alimentación Controlada US$]"
        dc8.Expression = "([Costo Traslado US$]+ [Costo al Nacer US$]*[Existencia Final])"
        dc9.Expression = "[Existencia Final]*[Alimentación B.T. US$]"
        dc10.Expression = "[Existencia Final]*[Alimentación Controlada US$]"
        dc11.Expression = "[Total Costo al Nacer US$]+[Total Alimentación B.T. US$]+[Total Alimentación Controlada US$]"
        With dt.Columns
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
        Try
            sql = New SqlCommand("select Lote_No from LOTES WHERE Lote_No BETWEEN '" & LoteDesde & "' AND '" & LoteHasta & "' AND Codigo_Granja='" & Granja & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                TamañoM += 1
            End While
            con.Close()
            ReDim LoteNo(TamañoM - 1)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                LoteNo(cont) = leer(0)
                cont += 1
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Try

            For i As Integer = 0 To cont - 1
                dr = dt.NewRow
                dr(0) = 0
                dr(0) = LoteNo(i)
                dr(2) = 0
                dr(3) = 0
                dr(4) = 0
                dr(5) = 0
                dr(6) = 0
                'dr(8) = 0
                'dr(9) = 0
                sql = New SqlCommand("Select Fecha_Creacion FROM LOTES where Lote_No='" & LoteNo(i) & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    dr(1) = Format(leer(0), "dd/MM/yyyy")
                End While
                con.Close()

                sql = New SqlCommand("SELECT SUM(Reemplazos), SUM(Defuncion),SUM(Destazo),SUM(Rastro),SUM(Entrada), SUM(Salida) FROM MOVIMIENTO_LOTE where Lote_No='" & LoteNo(i) & "' AND Fecha_Movimiento<='" & FechaHasta & "'", con)
                Dim Reem, Defun, Dest, Rast, Ent, Sal As Integer
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        Reem = 0
                        Defun = 0
                        Dest = 0
                        Rast = 0
                        Ent = 0
                        Sal = 0
                    Else
                        Reem = leer(0)
                        Defun = leer(1)
                        Dest = leer(2)
                        Rast = leer(3)
                        Ent = leer(4)
                        Sal = leer(5)
                    End If
                End While
                con.Close()
                Dim CerdosRegistrados As Integer
                Dim CerdosActuales As Integer
                sql = New SqlCommand("Select Cerdos_Nacidos From LOTES WHERE Lote_No='" & LoteNo(i) & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        CerdosRegistrados = 0
                    Else
                        CerdosRegistrados = leer(0)
                    End If
                End While
                con.Close()
                dr(2) = (CerdosRegistrados - (Reem + Defun + Dest + Rast + Sal - Ent))
                CerdosActuales = (CerdosRegistrados - (Reem + Defun + Dest + Rast + Sal - Ent))
                sql = New SqlCommand("Select SUM(Costo) FROM TrasladosEntreLotes WHERE De_Lote='" & LoteNo(i) & "' and Fecha_Traslado<='" & FechaHasta & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        dr(3) = 0
                    Else
                        dr(3) = leer(0)
                    End If
                End While
                con.Close()
                sql = New SqlCommand("select SUM(Costo_al_Nacer) FROM Costos_al_Nacer_x_Lotes WHERE Lote_No='" & LoteNo(i) & "' and Fecha_Registro<='" & FechaHasta & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        dr(4) = 0
                    Else
                        dr(4) = leer(0)
                    End If
                End While
                con.Close()
                sql = New SqlCommand("Select SUM(Costo_Alimento) FROM Alimentacion_No_Controlada WHERE Lote_No='" & LoteNo(i) & "' and Fecha_Alimentacion<='" & FechaHasta & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        dr(5) = 0
                    Else
                        dr(5) = leer(0)
                    End If
                End While
                con.Close()

                sql = New SqlCommand("SELECT SUM(Importe) FROM LINEAS_DE_REQUISICIONES as l JOIN REQUISICIONES AS r ON l.Req_No=r.Req_No WHERE r.Fecha<='" & FechaHasta & "' AND l.Lote_No='" & LoteNo(i) & "' and Viva='" & True & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        dr(6) = 0
                    Else
                        dr(6) = Math.Round((leer(0) / CerdosActuales), 4)
                    End If
                End While
                con.Close()

                '**********AL FINAL*******************
                dt.Rows.Add(dr)
                '****************************************
            Next

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        dv = New DataView(dt)
        Me.DataGridViewX1.DataSource = dv
        Me.txtTotalExistenciaF.Text = Sumar("Existencia Final", Me.DataGridViewX1)
        Me.txtCostoTraslado.Text = Format(Sumar("Costo Traslado US$", Me.DataGridViewX1), "c")
        Me.txtCostoalNacer.Text = Format(Sumar("Costo al Nacer US$", Me.DataGridViewX1), "c")
        Me.txtAlimentacionBT.Text = Format(Sumar("Alimentación B.T. US$", Me.DataGridViewX1), "c")
        Me.txtAlimentacionControlada.Text = Format(Sumar("Alimentación Controlada US$", Me.DataGridViewX1), "c")
        Me.txtTotalUnitario.Text = Format(Sumar("Total Unitario US$", Me.DataGridViewX1), "c")
        Me.txtTotalalNacer.Text = Format(Sumar("Total Costo al Nacer US$", Me.DataGridViewX1), "c")
        Me.txtTotalAlimBT.Text = Format(Sumar("Total Alimentación B.T. US$", Me.DataGridViewX1), "c")
        Me.txtTotalAlimControlada.Text = Format(Sumar("Total Alimentación Controlada US$", Me.DataGridViewX1), "c")
        Me.txtTotalGeneral.Text = Format(Sumar("Total General US$", Me.DataGridViewX1), "c")
        Me.Estilo_y_Tamaño_Datagridview()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        ExportarDatosExcel(Me.DataGridViewX1, "RESUMEN DE EXISTENCIAS DE LOTES DE CERDOS ", "                              " & Me.lbGranja.Text, Me.lbValuados.Text, "M")
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class