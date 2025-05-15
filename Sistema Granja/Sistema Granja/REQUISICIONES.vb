Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents
Imports System.Data.SqlClient
Imports System.Data
Imports System.StackOverflowException

Public Class REQUISICIONES
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Descripcion As String
    Dim total As Single
    Dim carrito As New DataTable("Detalle")
    Dim dr As DataRow
    Dim leer As SqlDataReader
    Dim No_req As Integer
    Dim dt As DataTable
    Dim sql, sql2 As SqlCommand
    Dim existencias As Boolean = False
    Dim prod_exist As Boolean = False
    Dim fila As Byte
    Public tipo_req As Integer
    Dim placa As Char
    Dim centro_costo As Integer
    Dim rm_list As String
    Dim Entradas, Salidas, Existencia_Actual As Double
    Dim Verif As Boolean = False
    Dim Codigo As Double
    Dim Exist As Double
    Dim verfi2 As Boolean = False
    Dim Peso As Integer = 0
    Dim Costo_T_QQ, Costo_T_QQ_ex, Existencia_T_QQ, Existencia_T_QQ_ex As Double
    Dim b As DevComponents.DotNetBar.Balloon
    Friend WithEvents balloonTipFocus As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents balloonTipHover As DevComponents.DotNetBar.BalloonTip

    Dim LotesGestacion As Integer = 0
    Dim LotesMontas As Integer = 0
    Dim CerdasGestacion As Integer = 0
    Dim CerdasMontas As Integer = 0
    Dim TotalCerdas_G_y_M As Integer = 0
    Dim CodigoGranja As String
    Dim Corr_Gen As Integer = 0
    Public Completo_Operacion As Boolean = False


    Dim oDtsRequisiciones As New dtsRequisiciones
    Dim Lineas_de_Requisiciones_CerdasTableAdapter As New dtsRequisicionesTableAdapters.Lineas_de_Requisiciones_CerdasTableAdapter
    Dim p_lista_lotes_gestacionTableAdapter As New dtsRequisicionesTableAdapters.p_lista_lotes_gestacionTableAdapter
    Dim lotesAdapter As New dtsRequisicionesTableAdapters.LotesTableAdapter
    Sub No_req_automatico()
        Try
            sql = New SqlCommand("select MAX(Req_No) from REQUISICIONES", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Me.txtReqNo.Text = "1"
                Else
                    Me.txtReqNo.Text = leer(0) + 1
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error No. Req Automatico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub lotes()
        Try
            Me.txtLoteNO.Items.Clear()
            sql = New SqlCommand("select * from LOTES l where L.Estado <>'T' AND L.IdEtapa_Cerdas <>'G' AND L.IdEtapa_Cerdas <>'M'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.txtLoteNO.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Recuperando Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub mostrar_motivos()
        Try
            sql = New SqlCommand("select distinct Motivo from REQUISICIONES", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Me.CbxMotivo.Items.Add("Otros")
                Else
                    Me.CbxMotivo.Items.Add(leer(0))
                End If
            End While
            con.Close()
            For i As Integer = 0 To Me.CbxMotivo.Items.Count - 2
                For j As Integer = Me.CbxMotivo.Items.Count - 1 To i + 1 Step -1
                    If Me.CbxMotivo.Items(j).ToString = Me.CbxMotivo.Items(i).ToString Then
                        Me.CbxMotivo.Items.RemoveAt(j)
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Recuperando Motivos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub
    Private Sub REQUISICIONES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For I As Integer = 0 To Me.cbxTipo.Items.Count - 1
            Me.cbxTipo.SelectedIndex = I
        Next
        Me.txtBodega.Items.Clear()
        Me.tabla()
        Me.txtFecha.Text = Format(FechaSistema, "dd/MM/yy")
        Me.No_req_automatico()
        Me.cbxTipo.Text = "ENTRADA"
        Try
            sql = New SqlCommand("select Bodega FROM BODEGAS", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    MessageBoxEx.Show("No ha ninguna bodega asignada, porfavor verifique Bodegas", "Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.txtBodega.Items.Add(leer(0))
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Recuperando Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
        '*************************ESTILO DE LA TABLA**************************************
        Me.DgvLineasReq.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
        Me.DgvLineasReq.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark
        Me.DgvLineasReq.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.DgvLineasReq.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DgvLineasReq.DefaultCellStyle.Font = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)
        Me.DgvLineasReq.DefaultCellStyle.BackColor = Color.Empty
        Me.DgvLineasReq.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
        Me.DgvLineasReq.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Me.DgvLineasReq.GridColor = SystemColors.ControlDarkDark
        '*********************************************************************************

        Me.txtFechaNatural.Text = Format(Today, "dd/MM/yy")
        Me.mostrar_motivos()

    End Sub
    Private Sub tabla()
        Try
            Dim dc0 As New DataColumn("No.", System.Type.GetType("System.Int32"))
            Dim dc1 As New DataColumn("Codigo", System.Type.GetType("System.String"))
            Dim dc2 As New DataColumn("Lote No", System.Type.GetType("System.String"))
            Dim dc3 As New DataColumn("Descripcion", System.Type.GetType("System.String"))
            Dim dc4 As New DataColumn("Unitario", System.Type.GetType("System.Decimal"))
            Dim dc5 As New DataColumn("Cantidad", System.Type.GetType("System.Decimal"))
            Dim dc6 As New DataColumn("Importe", System.Type.GetType("System.Decimal"))
            Dim dc7 As New DataColumn("Codigo_Cerdo", System.Type.GetType("System.String"))
            Dim dc8 As New DataColumn("Corr_Gen", System.Type.GetType("System.String"))
            Dim dc9 As New DataColumn("Gen_Descripcion", System.Type.GetType("System.String"))
            dc6.Expression = "Unitario*Cantidad"
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
            End With
            Me.DgvLineasReq.DataSource = carrito
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message)
        End Try
        Me.DgvLineasReq.Columns(0).Width = 45
        Me.DgvLineasReq.Columns(1).Width = 82
        Me.DgvLineasReq.Columns(2).Width = 77
        Me.DgvLineasReq.Columns(3).Width = 325
        Me.DgvLineasReq.Columns(4).Width = 80
        Me.DgvLineasReq.Columns(5).Width = 80
        Me.DgvLineasReq.Columns(6).Width = 80
        Me.DgvLineasReq.Columns(7).Width = 1
        Me.DgvLineasReq.Columns(8).Width = 1
        Me.DgvLineasReq.Columns(9).Width = 1
        Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub totales()
        Try
            Dim i As Integer
            Dim total, totalp As Single
            Dim ValorLetras As String
            For i = 0 To carrito.Rows.Count - 1
                total += carrito.Rows(i)(6)
            Next

            'iva = total * 13 / 100
            'Me.txtIVA.Text = iva.ToString("n1")
            totalp = total '+ iva
            Me.txtTotalReq.Text = Math.Round(totalp, 2)
            ValorLetras = Convertir_a_Letras(Me.txtTotalReq.Text)
            Me.txtValorenLetras.Text = UCase(ValorLetras)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub limpiar_cajas()
        Me.txtCodigo.Clear()
        Me.txtLoteNO.Text = ""
        Me.txtDescripcion.Clear()
        Me.txtExistencia.Text = "0"
        Me.txtPrecio.Clear()
        Me.txtCantidad.Clear()

    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Me.chbxEngorde.CheckState = CheckState.Checked Then
            validarexistencias()
            If Me.cbxTipo.Text = "SALIDA" Then
                If Me.txtLoteNO.Text = "" Then
                    MessageBoxEx.Show("No ha seleccionado el lote", "Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtLoteNO.Focus()
                ElseIf Me.txtCantidad.Text = "" Then
                    MessageBoxEx.Show("No ha ingresado la cantidad del producto", "Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtCantidad.Focus()
                Else
                    If Me.txtBodega.Text = "" Then
                        MessageBoxEx.Show("No ha selecciondo la bodega", "Requisicion Salida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.txtBodega.Focus()
                    ElseIf (Val(Me.txtCantidad.Text) > Val(Me.txtExistencia.Text)) Then
                        MessageBoxEx.Show("La cantidad ingresada excede la existencia: " & Me.txtExistencia.Text, "Sin Existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.txtCantidad.Text = ""
                        Me.txtCantidad.Focus()
                    Else
                        If Me.DgvLineasReq.Rows.Count = 30 Then
                            MessageBoxEx.Show("No de items permitido completo para proseguir porfavor grabe la requisicion y continue con una nueva", "Maximo Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            ButtonX2_Click(sender, e)
                        Else
                            Try
                                Dim x1, x2, x3, x4, x5 As String
                                x1 = Me.txtCodigo.Text
                                x2 = Me.txtLoteNO.Text
                                x3 = Me.txtDescripcion.Text
                                x4 = Me.txtPrecio.Text
                                x5 = Me.txtCantidad.Text
                                dr = carrito.NewRow()
                                dr(0) = carrito.Rows.Count + 1
                                dr(1) = x1
                                dr(2) = x2
                                dr(3) = x3
                                dr(4) = x4
                                dr(5) = x5
                                dr(7) = ""
                                dr(8) = ""
                                dr(9) = ""
                                carrito.Rows.Add(dr)
                                Me.totales()
                                Me.limpiar_cajas()
                                Me.txtCodigo.Focus()
                                Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
                                For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
                                    Me.DgvLineasReq.CurrentCell = Me.DgvLineasReq.Rows(i).Cells("Codigo")
                                Next
                                Me.txtLoteNO.DropDownStyle = ComboBoxStyle.DropDownList
                            Catch ex1 As System.Data.ConstraintException
                                MessageBoxEx.Show("El material ya ha sido agregado", "Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Catch ex As Exception
                                MessageBoxEx.Show("Se ha producido el siguiente Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                End If
            End If
        ElseIf Me.chbxHatoReprod.CheckState = CheckState.Checked Then
            If Me.txtCantidad.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la cantidad del producto", "Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCantidad.Focus()
            Else
                If Me.txtBodega.Text = "" Then
                    MessageBoxEx.Show("No ha selecciondo la bodega", "Requisicion Salida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtBodega.Focus()
                ElseIf (Val(Me.txtCantidad.Text) > Val(Me.txtExistencia.Text)) Then
                    MessageBoxEx.Show("La cantidad ingresada excede la existencia: " & Me.txtExistencia.Text, "Sin Existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtCantidad.Text = ""
                    Me.txtCantidad.Focus()
                Else
                    Dim Items_a_Agregar As Integer = 0
                    Items_a_Agregar = Me.cbxLotes2.Items.Count
                    Dim Items_Agregados As Integer = 0
                    Items_Agregados = Me.DgvLineasReq.Rows.Count
                    Dim NuevosItems As Integer = (Items_Agregados + Items_a_Agregar)
                    If NuevosItems > 30 Then
                        MessageBoxEx.Show("Los items que se pretende agregar supera el máx. permitido que es 30, para proseguir porfavor grabe la requisicion y continue con una nueva", "Maximo Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ButtonX2_Click(sender, e)
                    Else
                        If RTrim(Me.cbxEtapa.SelectedItem.ToString) = "Monta y Gestación" Then
                            For I As Integer = 0 To Me.cbxLotes2.Items.Count - 1
                                Dim CerdasM As Integer = 0
                                Dim CerdasA As Integer = 0
                                Dim TotalCerdasMA As Integer = 0
                                Dim CantidadDistribuir As Double = 0
                                Dim cmdM As String = "select COUNT (rm.Código_Cerda)" _
                                                  & " from REG_MADRES rm" _
                                                  & " where (rm.Estado_Actual ='G' OR RM.Estado_Actual ='P'OR RM.Estado_Actual ='V') AND Lote_No ='" & Me.cbxLotes2.Items(I).ToString & "'"
                                sql = New SqlCommand(cmdM, con)
                                con.Open()
                                leer = sql.ExecuteReader
                                While leer.Read
                                    CerdasM = leer(0)
                                End While
                                con.Close()
                                Dim cmdA As String = "select COUNT (rm.Código_Abuela)" _
                                                   & " from REG_ABUELAS rm" _
                                                   & " where (rm.Estado_Actual ='G' OR RM.Estado_Actual ='P'OR RM.Estado_Actual ='V') AND Lote_No ='" & Me.cbxLotes2.Items(I).ToString & "'"
                                sql = New SqlCommand(cmdA, con)
                                con.Open()
                                leer = sql.ExecuteReader
                                While leer.Read
                                    CerdasA = leer(0)
                                End While
                                con.Close()
                                TotalCerdasMA = (CerdasM + CerdasA)
                                CantidadDistribuir = (Val(Me.txtCantidad.Text) / TotalCerdas_G_y_M) * TotalCerdasMA
                                Dim x1, x2, x3, x4, x5 As String
                                x1 = Me.txtCodigo.Text
                                x2 = Me.cbxLotes2.Items(I).ToString
                                x3 = Me.txtDescripcion.Text
                                x4 = Me.txtPrecio.Text
                                x5 = CantidadDistribuir
                                dr = carrito.NewRow()
                                dr(0) = carrito.Rows.Count + 1
                                dr(1) = x1
                                dr(2) = x2
                                dr(3) = x3
                                dr(4) = x4
                                dr(5) = x5
                                dr(7) = ""
                                dr(8) = ""
                                dr(9) = ""
                                carrito.Rows.Add(dr)
                                Me.totales()
                            Next
                            Me.limpiar_cajas()
                            Me.txtCodigo.Focus()
                            Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
                            For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
                                Me.DgvLineasReq.CurrentCell = Me.DgvLineasReq.Rows(i).Cells("Codigo")
                            Next
                            Try
                                b.Close()
                            Catch ex As Exception

                            End Try
                        ElseIf RTrim(Me.cbxEtapa.SelectedItem.ToString) = "Lactancia" Then
                            For I As Integer = 0 To Me.cbxLotes2.Items.Count - 1
                                Dim CerdasM As Integer = 0
                                Dim CerdasA As Integer = 0
                                Dim TotalCerdasMA As Integer = 0
                                Dim CantidadDistribuir As Double = 0
                                Dim cmdM As String = "select COUNT (rm.Código_Cerda)" _
                                                  & " from REG_MADRES rm" _
                                                  & " where (rm.Estado_Actual ='L') AND Lote_No ='" & Me.cbxLotes2.Items(I).ToString & "'"
                                sql = New SqlCommand(cmdM, con)
                                con.Open()
                                leer = sql.ExecuteReader
                                While leer.Read
                                    CerdasM = leer(0)
                                End While
                                con.Close()
                                Dim cmdA As String = "select COUNT (rm.Código_Abuela)" _
                                                   & " from REG_ABUELAS rm" _
                                                   & " where (rm.Estado_Actual ='L') AND Lote_No ='" & Me.cbxLotes2.Items(I).ToString & "'"
                                sql = New SqlCommand(cmdA, con)
                                con.Open()
                                leer = sql.ExecuteReader
                                While leer.Read
                                    CerdasA = leer(0)
                                End While
                                con.Close()
                                TotalCerdasMA = (CerdasM + CerdasA)
                                CantidadDistribuir = (Val(Me.txtCantidad.Text) / TotalCerdas_G_y_M) * TotalCerdasMA
                                Dim x1, x2, x3, x4, x5 As String
                                x1 = Me.txtCodigo.Text
                                x2 = Me.cbxLotes2.Items(I).ToString
                                x3 = Me.txtDescripcion.Text
                                x4 = Me.txtPrecio.Text
                                x5 = CantidadDistribuir
                                dr = carrito.NewRow()
                                dr(0) = carrito.Rows.Count + 1
                                dr(1) = x1
                                dr(2) = x2
                                dr(3) = x3
                                dr(4) = x4
                                dr(5) = x5
                                dr(7) = ""
                                dr(8) = ""
                                dr(9) = ""
                                carrito.Rows.Add(dr)
                                Me.totales()
                            Next
                            Me.limpiar_cajas()
                            Me.txtCodigo.Focus()
                            Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
                            For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
                                Me.DgvLineasReq.CurrentCell = Me.DgvLineasReq.Rows(i).Cells("Codigo")
                            Next
                            Try
                                b.Close()
                            Catch ex As Exception

                            End Try
                        ElseIf RTrim(Me.cbxEtapa.SelectedItem.ToString) = "Cerditos Lactancia" Then
                            Try
                                Dim x1, x2, x3, x4, x5 As String
                                x1 = Me.txtCodigo.Text
                                x2 = Me.txtLoteNO.Text
                                x3 = Me.txtDescripcion.Text
                                x4 = Me.txtPrecio.Text
                                x5 = Me.txtCantidad.Text
                                dr = carrito.NewRow()
                                dr(0) = carrito.Rows.Count + 1
                                dr(1) = x1
                                dr(2) = x2
                                dr(3) = x3
                                dr(4) = x4
                                dr(5) = x5
                                dr(7) = ""
                                dr(8) = ""
                                dr(9) = ""
                                carrito.Rows.Add(dr)
                                Me.totales()
                                Me.limpiar_cajas()
                                Me.txtCodigo.Focus()
                                Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
                                For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
                                    Me.DgvLineasReq.CurrentCell = Me.DgvLineasReq.Rows(i).Cells("Codigo")
                                Next
                            Catch ex1 As System.Data.ConstraintException
                                MessageBoxEx.Show("El material ya ha sido agregado", "Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Catch ex As Exception
                                MessageBoxEx.Show("Se ha producido el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If

                    End If
                End If
            End If
        ElseIf Me.otroCheckBoxX1.CheckState = CheckState.Checked Then
            If Me.txtBodega.Text = "" Then
                MessageBoxEx.Show("No ha selecciondo la bodega", "Requisicion Salida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtBodega.Focus()
            ElseIf (Val(Me.txtCantidad.Text) > Val(Me.txtExistencia.Text)) Then
                MessageBoxEx.Show("La cantidad ingresada excede la existencia: " & Me.txtExistencia.Text, "Sin Existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCantidad.Text = ""
                Me.txtCantidad.Focus()
            ElseIf Me.txtLoteNO.Text = "" And Me.otroComboBox1.Text = "Lotes Gestacion Individual" Then
                MessageBoxEx.Show("Debe ingresar el No. de Lote.", "Dato necesario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtLoteNO.Text = ""
                Me.txtLoteNO.Focus()
            ElseIf Val(Me.txtCantidad.Text) <= 0 Then
                MessageBoxEx.Show("Debe ingresar una cantidad mayor a 0", "Sin Existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCantidad.Text = ""
                Me.txtCantidad.Focus()

            Else
                If Me.otroComboBox1.Text = "Lotes Gestacion Individual" Then
                    If lotesAdapter.GetExiste(Me.txtLoteNO.Text) = 0 And Me.txtLoteNO.Text <> "" Then
                        MessageBoxEx.Show("El Lote que ha ingresado no existe, favor validar", "Sin Existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else

                        Dim x1, x2, x3, x4, x5 As String
                        x1 = Me.txtCodigo.Text
                        x2 = Me.txtLoteNO.Text
                        x3 = Me.txtDescripcion.Text
                        x4 = Me.txtPrecio.Text
                        x5 = Me.txtCantidad.Text
                        dr = carrito.NewRow()
                        dr(0) = carrito.Rows.Count + 1
                        dr(1) = x1
                        dr(2) = x2
                        dr(3) = x3
                        dr(4) = x4
                        dr(5) = x5
                        dr(7) = ""
                        dr(8) = ""
                        dr(9) = ""
                        carrito.Rows.Add(dr)

                        Me.totales()
                        Me.limpiar_cajas()
                        Me.txtCodigo.Focus()
                        Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
                        For y As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
                            Me.DgvLineasReq.CurrentCell = Me.DgvLineasReq.Rows(y).Cells("Codigo")
                        Next
                        Me.CbxMotivo.Text = UCase(Me.otroComboBox1.Text)
                        Me.txtCodigo.Enabled = True
                    End If
                Else
                        Lineas_de_Requisiciones_CerdasTableAdapter.Fill(oDtsRequisiciones.Lineas_de_Requisiciones_Cerdas, Me.txtReqNo.Text, Corr_Gen)

                    For i As Integer = 0 To oDtsRequisiciones.Lineas_de_Requisiciones_Cerdas.Rows.Count - 1

                        With oDtsRequisiciones.Lineas_de_Requisiciones_Cerdas.Rows(i)
                            If .Item("Cantidad") > 0 Then
                                Dim x1, x2, x3, x4, x5 As String
                                x1 = Me.txtCodigo.Text
                                x2 = .Item("Lote_No")
                                x3 = Me.txtDescripcion.Text
                                x4 = Me.txtPrecio.Text
                                x5 = .Item("Cantidad")
                                dr = carrito.NewRow()
                                dr(0) = carrito.Rows.Count + 1
                                dr(1) = x1
                                dr(2) = x2
                                dr(3) = x3
                                dr(4) = x4
                                dr(5) = x5
                                dr(7) = .Item("Codigo_Cerdo")
                                dr(8) = .Item("Corr_Gen")
                                dr(9) = .Item("Gen_Descripcion")
                                carrito.Rows.Add(dr)
                            End If
                        End With
                    Next
                    Me.totales()
                    Me.limpiar_cajas()
                    Me.txtJustificacion.Focus()
                    Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
                    For y As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
                        Me.DgvLineasReq.CurrentCell = Me.DgvLineasReq.Rows(y).Cells("Codigo")
                    Next
                    Me.CbxMotivo.Text = UCase(Me.otroComboBox1.Text)
                    Me.txtCodigo.Enabled = False
                End If

            End If
        End If
    End Sub
    Private Sub TxtSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSerie.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtSerie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerie.TextChanged
        Me.TxtSerie.Text = UCase(Me.TxtSerie.Text)
        Me.TxtSerie.SelectionStart = 50

    End Sub


    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalReq.KeyPress
        e.Handled = True
    End Sub

    Private Sub CbxMotivo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxMotivo.LostFocus

    End Sub


    '************BLOQUEAR LETRAS*****************

    'If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
    'e.Handled = False
    'Else
    'e.Handled = True
    'End If

    '*********************************************

    '********************BLOQUEAR NUMEROS*********

    'If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Then
    'e.Handled = False
    'Me.DetectorError.Clear()
    'Else
    'Me.DetectorError.SetError(Me.TxtSerie, "No se puede ingresar numeros en un campo serie")
    'e.Handled = True
    'End If

    '*********************************************

    Private Sub CbxMotivo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxMotivo.TextChanged
        Me.CbxMotivo.Text = UCase(Me.CbxMotivo.Text)
        Me.CbxMotivo.SelectionStart = 200
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ListaProductos.StartPosition = FormStartPosition.CenterParent
            My.Forms.ListaProductos.txtDescripcion.Clear()
            My.Forms.ListaProductos.ventanallama = "requisicion"
            My.Forms.ListaProductos.ShowDialog()
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub

    Private Sub txtLoteNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Me.DetectorError.Clear()
        Else
            Me.DetectorError.SetError(Me.txtLoteNO, "No se puede ingresar letras en un campo No. Lote")
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Me.txtDescripcion.Text = UCase(Me.txtDescripcion.Text)
        Me.txtDescripcion.SelectionStart = 60
    End Sub

    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX1_Click(sender, e)
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
            Me.DetectorError.Clear()
        Else
            Me.DetectorError.SetError(Me.txtCantidad, "No se puede ingresar letras en un campo Cantidad")
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus



        prod_exist = False
        If RTrim(CUnitario) = "Promedio" Then
            sql2 = New SqlCommand("select Costo_Unitario from Inventario_Materiales where Codigo='" & Me.txtCodigo.Text & "'", con)
            con.Close()
            con.Open()
            leer = sql2.ExecuteReader
            While leer.Read
                Me.Costo_T_QQ = leer(0)
            End While
            con.Close()
        ElseIf RTrim(CUnitario) = "Mensual" Then
            sql = New SqlCommand("declare @FechaDigitacion datetime set @FechaDigitacion = '" & FechaSistema & "' select c.Costo_Unitario, c.Mes_a_Trabajar from Costos_Concentrados_x_Mes c where @FechaDigitacion between c.Fecha_Inicio_Trabajar and c.Fecha_Fin_Trabajar  and c.Codigo = '" & Me.txtCodigo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.Costo_T_QQ = leer(0)
            End While
            con.Close()

        End If
        sql = New SqlCommand("select Descripcion from inventario_materiales where Codigo='" & Me.txtCodigo.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            If leer.IsDBNull(0) = True Then
                Me.txtDescripcion.Text = "EL CÓDIGO INGRESADO NO EXISTE, FAVOR VALIDAR"
                'MessageBoxEx.Show("No existe ningun producto con el código: " & Me.txtCodigo.Text, "Código Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCodigo.Focus()

            Else
                Me.txtDescripcion.Text = leer(0)
                Me.txtPrecio.Text = Costo_T_QQ

                prod_exist = True
            End If
        End While
        con.Close()
        If prod_exist = False And Me.txtCodigo.Text <> "" Then
            Me.txtDescripcion.Text = "EL CÓDIGO INGRESADO NO EXISTE, FAVOR VALIDAR"
            'MessageBoxEx.Show("No hay ningún producto con ese código porfavor verfique el código", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.txtCodigo.Clear()
            Me.txtCodigo.Focus()
            'Me.txtDescripcion.Clear()
            Me.txtPrecio.Clear()
            Me.txtExistencia.Text = ""
        ElseIf EstadoInventario(Me.txtCodigo.Text) = False Then
            Me.txtDescripcion.Text = "CÓDIGO INGRESADO INACTIVO"
            'MessageBoxEx.Show("No hay ningún producto con ese código porfavor verfique el código", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.txtCodigo.Clear()
            Me.txtCodigo.Focus()
            'Me.txtDescripcion.Clear()
            Me.txtPrecio.Clear()
            Me.txtExistencia.Text = ""

        Else
            validarexistencias()
            If Me.otroComboBox1.Text = "Lactancia 1(de 1 a 2 partos)" Or Me.otroComboBox1.Text = "Lactancia 2(de 3 partos en adelante)" Then
                Me.txtCantidad.Enabled = False

                Try
                    Corr_Gen += 1
                    Dim cmd As New SqlCommand("p_generar_lista_cerdas_alimentar", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@Req_No", SqlDbType.Int).Value = CInt(Val(txtReqNo.Text))
                    cmd.Parameters.Add("@Corr_Gen", SqlDbType.Int).Value = Corr_Gen
                    cmd.Parameters.Add("@Gen_Descripcion", SqlDbType.NVarChar, 50).Value = Me.otroComboBox1.Text
                    cmd.Parameters.Add("@Fecha_Digitacion", SqlDbType.DateTime).Value = FechaSistema
                    cmd.Parameters.Add("@Accion", SqlDbType.NVarChar, 1).Value = "G"
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    frmListaCerdasLactancia.opcion = Me.otroComboBox1.Text
                    frmListaCerdasLactancia.existencia = Me.txtExistencia.Text
                    frmListaCerdasLactancia.req_no = CInt(Val(txtReqNo.Text))
                    frmListaCerdasLactancia.corr_gen = Corr_Gen
                    frmListaCerdasLactancia.ShowDialog()
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try
            ElseIf Me.otroComboBox1.Text = "Lotes Gestacion Individual" Then
                Me.txtLoteNO.DataSource = Nothing
                Me.txtLoteNO.Enabled = True
                Me.txtLoteNO.DropDownStyle = ComboBoxStyle.DropDown
                Me.txtLoteNO.DataSource = p_lista_lotes_gestacionTableAdapter.GetData(FechaSistema)
                Me.txtLoteNO.DisplayMember = "Lote_No"
                Me.txtLoteNO.ValueMember = "Lote_No"
                Me.txtLoteNO.Text = ""
                Me.txtDescripcionLote.Text = "GESTACION"
            Else
                Me.txtCantidad.Enabled = True
            End If
        End If
        Me.txtLoteNO.Focus()
    End Sub
    Sub validarexistencias()
        Dim existenciaActual As Double = 0
        sql = New SqlCommand("select Existencia_Actual from Existencias where Bodega='" & Me.txtBodega.Text & "' and Codigo='" & Me.txtCodigo.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            existenciaActual = leer(0)
            'Me.txtExistencia.Text = leer(0)
        End While
        con.Close()
        For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
            If Me.DgvLineasReq.Rows(i).Cells("Codigo").Value = Me.txtCodigo.Text Then
                existenciaActual -= Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value
            End If
        Next
        Me.txtExistencia.Text = Math.Round(existenciaActual, 2)
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.txtCodigo.Clear()
        Me.txtDescripcion.Clear()
        Me.txtPrecio.Clear()
        Me.txtCantidad.Clear()
        Me.txtLoteNO.Text = ""
        Me.txtExistencia.Text = ""
        Me.txtCodigo.Focus()
    End Sub
    Private Sub txtBodega_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBodega.LostFocus

    End Sub

    Private Sub txtBodega_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBodega.SelectedIndexChanged
        Try
            Dim cmd As String = "select Descripcion,Codigo_Granja from BODEGAS where Bodega='" & Me.txtBodega.Text & "'"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.txtBodegaDescripcion.Text = leer(0).ToString
                Me.lbRequisiciones.Text = Me.txtBodega.Text
                CodigoGranja = RTrim(leer(1))
            End While
            con.Close()
            'If RTrim(Me.txtBodega.SelectedItem.ToString) <> "014" Then
            '    Me.chbxHatoReprod.Enabled = False

            'Else
            '    Me.chbxHatoReprod.Enabled = True
            'End If
            lotes()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarLinea.Click
        Try
            fila = Me.DgvLineasReq.CurrentCell.RowIndex
            If fila > -1 And carrito.Rows.Count > 0 Then
                total -= Single.Parse(Me.DgvLineasReq.Item(4, fila).Value)
                carrito.Rows.RemoveAt(fila)
                Dim i As Integer
                For i = 0 To carrito.Rows.Count - 1
                    carrito.Rows(i).BeginEdit()
                    carrito.Rows(i)(0) = i + 1
                    carrito.Rows(i).EndEdit()
                Next
                totales()
            End If
        Catch ex As Exception
            MessageBoxEx.Show("Todos los productos han sido borrados de la Lista", "Información...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
    End Sub
    Private Sub txtUserCreador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserCreador.KeyPress
        e.Handled = True
    End Sub
    Sub Guardar_Requisicion()
        Try
            Dim empleado As Char
            Dim para_bodega As Char
            Dim status As Char
            Dim No_Envio As Char
            Dim des_recibida As Boolean = True
            Dim desp_rec_por As Char = "SISTEMA"

            If Me.cbxTipo.Text = "ENTRADA" Then
                Me.tipo_req = 51
            ElseIf Me.cbxTipo.Text = "SALIDA" Then
                Me.tipo_req = 50
            End If

            sql = New SqlCommand("insert into REQUISICIONES values('" & Me.txtReqNo.Text & "','" & Me.txtFecha.Text & "','" & Me.txtBodega.Text & "','" & empleado & "','" & para_bodega & "','" & 0 & "','" & 0 & "','" & Me.txtTotalReq.Text & "','" & Me.DgvLineasReq.Rows.Count & "','" & Me.txtJustificacion.Text & "','" & status & "','" & No_Envio & "','" & tipo_req & "','" & Me.CbxMotivo.Text & "','" & des_recibida & "','" & desp_rec_por & "','" & FechaSistema & "','" & TimeOfDay & "','" & placa & "','" & Me.txtUserCreador.Text & "','" & Me.txtUserModificador.Text & "','" & Me.txtFechaNatural.Text & "','" & Me.TxtSerie.Text & "','" & True & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex1 As System.Data.SqlClient.SqlException
            MessageBoxEx.Show("Se ha producido el siguiente error: " & ex1.Message, "Error al Guardar Req.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub Guardar_Lineas_Requisicion()
        Try
            Dim validada As Boolean = False

            If Me.cbxTipo.Text = "ENTRADA" Then
                Me.tipo_req = 51
            ElseIf Me.cbxTipo.Text = "SALIDA" Then
                Me.tipo_req = 50
            End If
            If Me.txtCentroCosto.Text = "" Then
                centro_costo = 0
            Else
                centro_costo = Me.txtCentroCosto.Text
            End If
            For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1


                sql = New SqlCommand("insert into LINEAS_DE_REQUISICIONES values('" & Me.txtReqNo.Text & "','" & Me.DgvLineasReq.Rows(i).Cells("No.").Value & "','" & Me.txtBodega.Text & "','" & Me.DgvLineasReq.Rows(i).Cells("Codigo").Value & "','" & Me.txtCuentaContable.Text & "','" & Me.txtFecha.Text & "'," & Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value & ",'" & Me.DgvLineasReq.Rows(i).Cells("Unitario").Value & "','" & Math.Round(Me.DgvLineasReq.Rows(i).Cells("Importe").Value, 4) & "','" & Me.tipo_req & "','" & Me.CbxMotivo.Text & "','" & validada & "','" & placa & "','" & Me.TxtSerie.Text & "','" & centro_costo & "','" & 0 & "','" & Me.DgvLineasReq.Rows(i).Cells("Lote No").Value & "','" & (Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value * 100) & "','" & True & "','" & Me.DgvLineasReq.Rows(i).Cells("Descripcion").Value & "','0','0','" & Me.DgvLineasReq.Rows(i).Cells("Codigo_Cerdo").Value & "','" & Me.DgvLineasReq.Rows(i).Cells("Corr_Gen").Value & "','" & Me.DgvLineasReq.Rows(i).Cells("Gen_Descripcion").Value & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                sql = New SqlCommand("insert into Kardex(Bodega,Codigo,Fecha,Documento,Ingreso_Egreso,Unidades,Costo_Unitario,Justificacion,ID,Granja,Lote_No) values('" & Me.txtBodega.Text & "','" & Me.DgvLineasReq.Rows(i).Cells("Codigo").Value & "','" & Me.txtFecha.Text & "','" & "Req." & Me.txtReqNo.Text & "','E','" & Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value & "','" & Me.DgvLineasReq.Rows(i).Cells("Unitario").Value & "','" & Me.txtJustificacion.Text & "','R','','" & Me.DgvLineasReq.Rows(i).Cells("Lote No").Value & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            Next

            Try

                Dim cmd As New SqlCommand("p_generar_lista_cerdas_alimentar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Req_No", SqlDbType.Int).Value = CInt(Val(Me.txtReqNo.Text))
                cmd.Parameters.Add("@Corr_Gen", SqlDbType.Int).Value = Corr_Gen
                cmd.Parameters.Add("@Gen_Descripcion", SqlDbType.NVarChar, 50).Value = otroComboBox1.Text
                cmd.Parameters.Add("@Fecha_Digitacion", SqlDbType.DateTime).Value = FechaSistema
                cmd.Parameters.Add("@Accion", SqlDbType.NVarChar, 1).Value = "A"
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al Grabar Lineas de Requisicion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Sub Cargar_Existencias_Entrada()
        For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
            Verif = False
            Try

                sql = New SqlCommand("Select Existencia_Actual from Existencia where Codigo= '" & Me.DgvLineasReq.Rows(i).Cells("Codigo").Value & "' AND Bodega='" & Me.txtBodega.Text & "'", con)
                Codigo = Me.DgvLineasReq.Rows(i).Cells("Codigo").Value
                Exist = Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        MessageBoxEx.Show("No hay existencias")
                    Else
                        Me.Existencia_Actual = leer(0)
                        Verif = True
                    End If

                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            '**************************************
            'If Verif = False Then
            '    Try
            '        sql = New SqlCommand("Insert into EXISTENCIAS Values('" & Codigo & "','" & Me.txtBodega.Text & "','" & Exist & "')", con)
            '        con.Open()
            '        sql.ExecuteNonQuery()
            '        con.Close()
            '    Catch ex As Exception
            '        MessageBoxEx.Show("Se ha producido el Siguiente error: " & ex.Message, "Error Agregando Existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        con.Close()
            '    End Try
            'Else
            '    Try
            '        sql = New SqlCommand("Update EXISTENCIAS Set Existencia_Actual_QQ='" & (Me.Existencia_Actual + Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value) & "', Bodega='" & Me.txtBodega.Text & "' WHERE Codigo_Producto='" & Me.DgvLineasReq.Rows(i).Cells("Codigo").Value & "'", con)
            '        con.Open()
            '        sql.ExecuteNonQuery()
            '        con.Close()
            '    Catch ex As Exception
            '        MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        con.Close()
            '    End Try
            'End If
        Next
    End Sub
    Sub cargar_Existencias_Salida()
        For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
            Verif = False
            Try
                sql = New SqlCommand("Select Existencia_Actual from EXISTENCIAS where Codigo= '" & Me.DgvLineasReq.Rows(i).Cells("Codigo").Value & "' AND Bodega='" & Me.txtBodega.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        MessageBoxEx.Show("No hay existencias")
                    Else
                        Me.Existencia_Actual = leer(0)

                        Verif = True
                    End If
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            '*********************************
            If Verif = False Then
                MessageBoxEx.Show("No hay ningun producto registrado en exitencias", "Existencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Else
                '    Try
                '        sql = New SqlCommand("Update EXISTENCIAS Set Existencia_Actual_QQ ='" & (Me.Existencia_Actual - Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value) & "', Existencia_Actual_Lbs='" & (Me.Existencia_Actual - Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value) * 100 & "',Costo_Total_QQ ='" & (Me.Costo_T_QQ_ex - Me.DgvLineasReq.Rows(i).Cells("Importe").Value) & "' WHERE Codigo_Producto='" & Me.DgvLineasReq.Rows(i).Cells("Codigo").Value & "' and Bodega='" & Me.txtBodega.Text & "'", con)
                '        con.Open()
                '        sql.ExecuteNonQuery()
                '        con.Close()
                '    Catch ex As Exception
                '        MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                '        con.Close()
                '    End Try
            End If
            '********************************
        Next
    End Sub
    Sub limpiar_cajas_al_guardar()
        Me.txtLoteNO.Text = ""
        Me.txtBodega.Text = ""
        If Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.CbxMotivo.Text = "ALIMENTACION L. ENGORDE"
        ElseIf Me.chbxHatoReprod.CheckState = CheckState.Checked Then
            Me.CbxMotivo.Text = "ALIMENTACION HATO R."
        End If

        Me.lbLineas.Text = ""
        Me.txtExistencia.Text = "0"
        Me.txtValorenLetras.Text = ""
        Me.txt1.Clear()
        Me.txt2.Clear()
        Me.txtCuentaContable.Clear()
        Me.txtCentroCosto.Clear()
        Me.txtJustificacion.Clear()
        Me.txtTotalReq.Clear()
        For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
            carrito.Rows.Clear()
        Next
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.cbxTipo.Text = "ENTRADA" Then
            If Me.DgvLineasReq.Rows.Count = 0 Then
                MessageBoxEx.Show("No hay ninguna linea en la requisición, no puede continuar el guardado", "Sin Lineas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Me.txtBodega.Text = "" Then
                MessageBoxEx.Show("No ha seleccionado la bodega", "Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtBodega.Focus()
            ElseIf Me.CbxMotivo.Text = "" Then
                MessageBoxEx.Show("No ha ingresado motivo en el campo motivo", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CbxMotivo.Focus()
            ElseIf Me.txtJustificacion.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la Justificación es campo requerido", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtJustificacion.Focus()
            ElseIf Me.txtFecha.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la fecha es campo requerido", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFecha.Focus()
            ElseIf Me.txtFechaNatural.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la fecha Natural es campo requerido", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFechaNatural.Focus()
            ElseIf ValidarFechas(Me.txtFecha.Text) = False Then
                Me.txtFecha.SelectAll()
                Me.txtFecha.Focus()
            ElseIf ValidarFechas(Me.txtFechaNatural.Text) = False Then
                Me.txtFechaNatural.SelectAll()
                Me.txtFechaNatural.Focus()
            Else
               

                Me.Guardar_Requisicion()
                Me.Guardar_Lineas_Requisicion()
                Me.Cargar_Existencias_Entrada()
                ActualizarExistencias()
                Me.limpiar_cajas_al_guardar()
                Me.No_req_automatico()
                Me.mostrar_motivos()
                Me.TxtSerie.Focus()
                Corr_Gen = 0
            End If

        ElseIf Me.cbxTipo.Text = "SALIDA" Then
            If Me.DgvLineasReq.Rows.Count = 0 Then
                MessageBoxEx.Show("No hay ninguna linea en la requisición, no puede continuar el guardado", "Sin Lineas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Me.CbxMotivo.Text = "" Then
                MessageBoxEx.Show("No ha ingresado motivo en el campo motivo", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CbxMotivo.Focus()
            ElseIf Me.txtBodega.Text = "" Then
                MessageBoxEx.Show("No ha seleccionado la bodega", "Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtBodega.Focus()
            ElseIf Me.txtJustificacion.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la Justificación es campo requerido", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtJustificacion.Focus()
            ElseIf Me.txtFecha.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la fecha es campo requerido", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFecha.Focus()
            ElseIf Me.txtFechaNatural.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la fecha Natural es campo requerido", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFechaNatural.Focus()
            ElseIf ValidarFechas(Me.txtFecha.Text) = False Then
                Me.txtFecha.SelectAll()
                Me.txtFecha.Focus()
            ElseIf ValidarFechas(Me.txtFechaNatural.Text) = False Then
                Me.txtFechaNatural.SelectAll()
                Me.txtFechaNatural.Focus()
            ElseIf ValidarFechas(Me.txtFecha.Text) = True And ValidarFechas(Me.txtFechaNatural.Text) = True Then
                '*************************************SE DESHABILITA LA IMPRESION DE REQ.***************************
                'MessageBoxEx.Show("Se va a imprimir la requisición no: " & Me.txtReqNo.Text & " prepare la impresora luego presiones Ok", "Imprimir Requisición", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'oAdapter = New SqlDataAdapter("SELECT * FROM LINEAS_DE_REQUISICIONES", con)
                'Dts = New DataSet
                'con.Open()
                'oAdapter.Fill(Dts, "LineasReq")
                'con.Close()
                'Dts.Tables("LineasReq").Clear()
                'For i As Integer = 0 To Me.DgvLineasReq.Rows.Count - 1
                '    dr = Dts.Tables("LineasReq").NewRow
                '    dr(0) = Me.txtReqNo.Text
                '    dr(1) = Me.DgvLineasReq.Rows(i).Cells("No.").Value
                '    dr(2) = Me.txtBodega.Text
                '    dr(3) = Me.DgvLineasReq.Rows(i).Cells("Codigo").Value
                '    dr(4) = ""
                '    dr(5) = Me.txtFecha.Text
                '    dr(6) = Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value
                '    dr(7) = Me.DgvLineasReq.Rows(i).Cells("Unitario").Value
                '    dr(8) = Me.DgvLineasReq.Rows(i).Cells("Importe").Value
                '    dr(9) = 50
                '    dr(10) = Me.CbxMotivo.Text
                '    dr(11) = True
                '    dr(12) = ""
                '    dr(13) = Me.TxtSerie.Text
                '    dr(14) = 0
                '    dr(15) = 0
                '    dr(16) = Me.DgvLineasReq.Rows(i).Cells("Lote No").Value
                '    dr(17) = 0
                '    dr(18) = True
                '    dr(19) = Me.DgvLineasReq.Rows(i).Cells("Descripcion").Value
                '    Dts.Tables("LineasReq").Rows.Add(dr)
                'Next
                'Dim rptReq As New rptRequisicion()
                'Dim vs As New Visualizador()
                'With rptReq

                '    .SetDataSource(Dts.Tables("LineasReq"))
                '    .SetParameterValue("NoDoc", Me.txtReqNo.Text)
                '    .SetParameterValue("TipoVenta", Me.cbxTipo.Text)
                '    .SetParameterValue("Fecha", Me.txtFecha.Text)
                '    .SetParameterValue("Serie", Me.TxtSerie.Text)
                '    .SetParameterValue("Bodega", Me.txtBodega.Text)
                '    .SetParameterValue("DescripcionBodega", Me.txtBodegaDescripcion.Text)
                '    .SetParameterValue("Total", Me.txtTotalReq.Text)
                '    .SetParameterValue("TotalLetras", Me.txtValorenLetras.Text)

                '    vs.CrReporteViewerç.ReportSource = rptReq
                '    .PrintToPrinter(2, False, 1, 1)
                '    'vs.CrReporteViewerç.PrintReport()
                'End With
                Me.Guardar_Requisicion()
                Me.Guardar_Lineas_Requisicion()
                Me.cargar_Existencias_Salida()
                ActualizarExistencias()
                Me.limpiar_cajas_al_guardar()
                Me.txtExistencia.Text = ""
                Me.No_req_automatico()
                Me.mostrar_motivos()
                Me.TxtSerie.Focus()
                If Me.otroComboBox1.Text = "Lotes Gestacion Individual" Then
                    Me.txtLoteNO.DropDownStyle = ComboBoxStyle.DropDownList
                End If
            End If

            End If
    End Sub
    Private Sub txtJustificacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJustificacion.TextChanged
        Me.txtJustificacion.Text = UCase(Me.txtJustificacion.Text)
        Me.txtJustificacion.SelectionStart = 60
    End Sub
    Private Sub txtBodega2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBodegaDescripcion.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtLoteNO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoteNO.LostFocus

    End Sub

    Private Sub txt2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt2.LostFocus
        Me.txtJustificacion.Focus()
    End Sub
    Private Sub txtFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecha.KeyPress
        If Me.txtFecha.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFecha.Text = Me.txtFecha.Text & "/"
            Me.txtFecha.SelectionStart = 4
        ElseIf Me.txtFecha.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFecha.Text = Me.txtFecha.Text & "/"
            Me.txtFecha.SelectionStart = 6
        End If
    End Sub
    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio.TextChanged

    End Sub
    Private Sub txtLoteNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoteNO.SelectedIndexChanged
        Dim cmd As String = "SELECT e.Descripcion FROM Lotes l JOIN Etapas_Cerdas_Lote e on l.IdEtapa_Cerdas=e.IdEtapa_Cerdas where l.Lote_No='" & Me.txtLoteNO.Text & "'"
        sql = New SqlCommand(cmd, con)
        Dim ExisteLote As Boolean = False

        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            ExisteLote = True
            Descripcion = leer(0).ToString
        End While
        con.Close()
        If ExisteLote = True Then
            Me.txtDescripcionLote.Text = Descripcion
            Me.CbxMotivo.Text = "ALIMENTACION L. " & Me.txtDescripcionLote.Text
        Else
            Me.txtDescripcionLote.Text = ""
        End If
    End Sub

    
    
    Private Sub lbRequisiciones_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbRequisiciones.TextChanged
        If Me.lbRequisiciones.Text = "" Then
            Me.grDatosMaterial.Enabled = False
        Else
            Me.lbRequisiciones.Enabled = True
        End If
    End Sub
    Private Sub chbxEngorde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxEngorde.CheckedChanged
        If Me.chbxHatoReprod.Enabled = False Then
            Me.chbxEngorde.CheckState = CheckState.Checked
        End If
        If Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.chbxHatoReprod.CheckState = CheckState.Unchecked

            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Me.cbxEtapa.Enabled = False
            Me.txtLoteNO.Enabled = True
            lotes()
        ElseIf Me.chbxHatoReprod.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub chbxHatoReprod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxHatoReprod.CheckedChanged
        If Me.chbxHatoReprod.CheckState = CheckState.Checked Then
            Me.CbxMotivo.Text = "ALIMENTACION HATO R."
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.cbxEtapa.Enabled = True
            Me.txtLoteNO.Enabled = False

        ElseIf Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.chbxHatoReprod.CheckState = CheckState.Unchecked
        End If
    End Sub


    Private Sub lbLineas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbLineas.TextChanged
        If Val(Me.lbLineas.Text) > 0 Then
            Me.GroupPanel2.Enabled = False

            Me.gpTipoAlimentacion.Enabled = False


        Else
            Me.GroupPanel2.Enabled = True

            Me.gpTipoAlimentacion.Enabled = True

        End If
        If Me.lbLineas.Text = "0" Then
            Me.btnGuardar.Enabled = False
            Me.btnBorrarLinea.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
            Me.btnBorrarLinea.Enabled = True
        End If
    End Sub
    Private Sub gpTipoAlimentacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gpTipoAlimentacion.LostFocus
        Me.txtCodigo.Focus()
    End Sub
    Private Sub lbLineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbLineas.Click

    End Sub

    Private Sub CheckBoxX1_CheckedChanged(sender As Object, e As EventArgs) Handles otroCheckBoxX1.CheckedChanged
        If Me.otroCheckBoxX1.Checked = True Then
            Me.otroComboBox1.Enabled = True
            Me.txtLoteNO.Enabled = False
            Me.txtCodigo.Enabled = False

        End If
    End Sub

    Private Sub cbxEtapa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEtapa.SelectedIndexChanged
        If Me.cbxEtapa.SelectedItem.ToString = "Monta y Gestación" Then
            Me.txtLoteNO.Enabled = False
            Me.cbxLotes2.Items.Clear()
            LotesGestacion = 0
            LotesMontas = 0
            CerdasGestacion = 0
            CerdasMontas = 0
            TotalCerdas_G_y_M = 0
            Try
                b.Close()
            Catch ex As Exception

            End Try
            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                              & " FROM LOTES l" _
                              & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                              & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                              & " where L.Estado <>'T' and l.Lote_No<>'5' and ((rm.Estado_Actual ='G' OR RA.Estado_Actual ='G') OR (RM.Estado_Actual ='P' OR RA.Estado_Actual ='P')OR (RM.Estado_Actual ='V' OR RA.Estado_Actual ='V'))" _
                              & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
                              & " ORDER BY L.IdEtapa_Cerdas"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                Me.cbxLotes2.Items.Add(leer(0))
                If RTrim(leer(1)).ToString = "G" Then
                    LotesGestacion += 1
                ElseIf RTrim(leer(1)).ToString = "M" Then
                    LotesMontas += 1
                End If
            End While
            con.Close()

            Dim cmd3 As String = "SELECT l.Lote_No,rm.Código_Cerda" _
                               & " FROM LOTES l" _
                               & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                               & " where l.IdEtapa_Cerdas = 'G' AND ((RM.Estado_Actual ='G')) AND L.Estado <> 'T' and l.Lote_No<>'5'" _
                               & " group by rm.Código_Cerda, l.Lote_No"
            sql = New SqlCommand(cmd3, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CerdasGestacion += 1
            End While
            con.Close()
            Dim cmd4 As String = "SELECT l.Lote_No,rm.Código_Abuela" _
                               & " FROM LOTES l" _
                               & " LEFT JOIN REG_ABUELAS RM ON L.Lote_No = RM.Lote_No" _
                               & " where l.IdEtapa_Cerdas = 'G' AND ((RM.Estado_Actual ='G')) AND L.Estado <> 'T' and l.Lote_No<>'5'" _
                               & " group by rm.Código_Abuela, l.Lote_No"
            sql = New SqlCommand(cmd4, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CerdasGestacion += 1
            End While
            con.Close()

            Dim cmd5 As String = "SELECT l.Lote_No,rm.Código_Cerda" _
                               & " FROM LOTES l" _
                               & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                               & " where l.IdEtapa_Cerdas = 'M' AND ((RM.Estado_Actual ='P' or RM.Estado_Actual ='V')) AND L.Estado <> 'T' and l.Lote_No<>'5'" _
                               & " group by rm.Código_Cerda, l.Lote_No"
            sql = New SqlCommand(cmd5, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CerdasMontas += 1
            End While
            con.Close()
            Dim cmd6 As String = "SELECT l.Lote_No,rm.Código_Abuela" _
                               & " FROM LOTES l" _
                               & " LEFT JOIN REG_ABUELAS RM ON L.Lote_No = RM.Lote_No" _
                               & " where l.IdEtapa_Cerdas = 'M' AND ((RM.Estado_Actual ='P' OR RM.Estado_Actual ='V')) AND L.Estado <> 'T' and l.Lote_No<>'5'" _
                               & " group by rm.Código_Abuela, l.Lote_No"
            sql = New SqlCommand(cmd6, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CerdasMontas += 1
            End While
            con.Close()
            TotalCerdas_G_y_M = (CerdasGestacion + CerdasMontas)
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "INFORMACIÓN DE LOTES"
            b.Text = "Lotes{Lotes G: " & LotesGestacion & " | " & "Lotes M: " & LotesMontas & "}, No Cerdas{Cerdas G: " & CerdasGestacion & " | Cerdas M: " & CerdasMontas & "}"
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.Width = 380
            b.Height = 50
            b.Opacity = 40
            'b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.txtLoteNO, False)
        ElseIf Me.cbxEtapa.SelectedItem.ToString = "Lactancia" Then
            Me.txtLoteNO.Enabled = False
            Me.cbxLotes2.Items.Clear()
            Me.cbxLotes2.Items.Clear()
            Dim LotesLactancia As Integer = 0
            Dim Cerdas_Lactancia As Integer = 0
            TotalCerdas_G_y_M = 0
            Try
                b.Close()
            Catch ex As Exception

            End Try

            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                             & " FROM LOTES l" _
                             & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                             & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                             & " where L.Estado <>'T' AND ((rm.Estado_Actual ='L' OR RA.Estado_Actual ='L') and l.Lote_No<>'5')" _
                             & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
                             & " ORDER BY L.IdEtapa_Cerdas"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                Me.cbxLotes2.Items.Add(leer(0))
                LotesLactancia += 1
            End While
            con.Close()

            Dim cmd3 As String = "SELECT l.Lote_No,rm.Código_Cerda" _
                               & " FROM LOTES l" _
                               & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                               & " where l.IdEtapa_Cerdas = 'G' AND ((RM.Estado_Actual ='L')) AND L.Estado <> 'T' and l.Lote_No<>'5'" _
                               & " group by rm.Código_Cerda, l.Lote_No"
            sql = New SqlCommand(cmd3, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Cerdas_Lactancia += 1
            End While
            con.Close()

            Dim cmd4 As String = "SELECT l.Lote_No,rm.Código_Abuela" _
                               & " FROM LOTES l" _
                               & " LEFT JOIN REG_ABUELAS RM ON L.Lote_No = RM.Lote_No" _
                               & " where l.IdEtapa_Cerdas = 'G' AND ((RM.Estado_Actual ='L')) AND L.Estado <> 'T' and l.Lote_No<>'5'" _
                               & " group by rm.Código_Abuela, l.Lote_No"
            sql = New SqlCommand(cmd4, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Cerdas_Lactancia += 1
            End While
            con.Close()
            TotalCerdas_G_y_M = (Cerdas_Lactancia)
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "INFORMACIÓN DE LOTES"
            b.Text = "Lotes{Lotes G: " & LotesLactancia & ", No Cerdas{Cerdas Lactancia: " & TotalCerdas_G_y_M & "}"
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.Opacity = 40
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.txtLoteNO, False)
        ElseIf Me.cbxEtapa.SelectedItem.ToString = "Cerditos Lactancia" Then
            Me.txtLoteNO.Enabled = True
            Me.txtLoteNO.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                            & " FROM LOTES l" _
                            & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                            & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                            & " where L.Estado <>'T' AND ((rm.Estado_Actual ='L' OR RA.Estado_Actual ='L') and l.Lote_No<>'5')" _
                            & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
                            & " ORDER BY L.IdEtapa_Cerdas"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                Me.txtLoteNO.Items.Add(leer(0))
            End While
            con.Close()
        ElseIf Me.cbxEtapa.SelectedItem.ToString = "Cerdas Lactando" Then
            Me.txtLoteNO.Enabled = True
            Me.txtLoteNO.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                           & " FROM LOTES l" _
                           & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                           & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                           & " where L.Estado <>'T' AND ((rm.Estado_Actual ='L' OR RA.Estado_Actual ='L') and l.Lote_No<>'5')" _
                           & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
                           & " ORDER BY L.IdEtapa_Cerdas"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                Me.txtLoteNO.Items.Add(leer(0))
            End While
            con.Close()

        End If
    End Sub

    Private Sub otroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles otroComboBox1.SelectedIndexChanged
        If Me.otroComboBox1.Text <> "" Then
            Me.txtCodigo.Enabled = True
        End If
    End Sub

    Private Sub txtFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFecha.LostFocus
        If Me.txtFecha.Text <> "" Then
            If Not IsDate(Me.txtFecha.Text) Then
                MessageBoxEx.Show("La Fecha que ha ingresado es incorrecta, porfavor verifique que los dias correspondan al mes y año", "Error Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtFecha.Text = ""
                Me.txtFecha.Focus()
            End If

            If Me.txtBodegaDescripcion.Text <> "" Then
                Me.grDatosMaterial.Enabled = True
            Else
                Me.grDatosMaterial.Enabled = True
            End If
        End If

    End Sub

    Private Sub txtFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFecha.TextChanged

    End Sub

    Private Sub txtBodegaDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBodegaDescripcion.TextChanged
        If Me.txtFecha.Text <> "" And Me.txtBodegaDescripcion.Text <> "" Then
            Me.grDatosMaterial.Enabled = True
        Else
            Me.grDatosMaterial.Enabled = True
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_GotFocus(sender As Object, e As EventArgs) Handles txtCodigo.GotFocus

    End Sub
End Class