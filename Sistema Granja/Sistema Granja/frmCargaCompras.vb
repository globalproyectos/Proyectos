Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmCargaCompras
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim prod_exist As Boolean
    Dim Carrito As New DataTable("Detalles")
    Dim fila As Byte
    Dim total As Single
    Dim Verif As Boolean
    Dim Codigo As Double
    Dim Exist_Actual, Exist_Lbs As Double
    Dim Peso As Double
    Dim Existencia_Actual As Double
    Dim Selecciono_Bodega As Boolean
    Dim Existencias_QQ, Existencias_Lbs As Double
    Dim Exist_Prod_en_existencias As Boolean
    Dim Exist_Total_Monto As Double

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ListaProd2.StartPosition = FormStartPosition.CenterParent
            My.Forms.ListaProd2.txtDescripcion.Clear()
            My.Forms.ListaProd2.ShowDialog()
        End If
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
  
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        prod_exist = False
        Dim Descripcion As String = ""
        sql = New SqlCommand("select * from INVENTARIO_MATERIALES where Codigo='" & Me.txtCodigo.Text & "'", con)
        con.Close()
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            Descripcion = leer(1)

            prod_exist = True

        End While
        con.Close()
        If prod_exist = False And Me.txtCodigo.Text <> "" Then
            Me.txtDescripcion.Text = "EL CÓDIGO INGRESADO NO EXISTE, FAVOR VALIDAR"
            'MessageBoxEx.Show("No hay ningún producto con ese código porfavor verfique el código", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.txtCodigo.Clear()
            'Me.txtCodigo.Focus()
            'Me.txtDescripcion.Clear()
            Me.txtPrecio.TextBoxX1.Clear()
            Descripcion = ""
        ElseIf EstadoInventario(Me.txtCodigo.Text) = False Then
            Me.txtDescripcion.Text = "CÓDIGO INGRESADO INACTIVO"
            'MessageBoxEx.Show("No hay ningún producto con ese código porfavor verfique el código", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.txtCodigo.Clear()
            'Me.txtCodigo.Focus()
            'Me.txtDescripcion.Clear()
            Me.txtPrecio.TextBoxX1.Clear()
            Descripcion = ""

        ElseIf prod_exist = True And Me.txtCodigo.Text <> "" Then
            Me.txtDescripcion.Text = Descripcion
            Try
                Dim MesActual As Integer = FechaSistema.Month
                Dim oMes As String = ""
                If MesActual = 1 Then
                    oMes = "ENE" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 2 Then
                    oMes = "FEB" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 3 Then
                    oMes = "MAR" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 4 Then
                    oMes = "ABR" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 5 Then
                    oMes = "MAY" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 6 Then
                    oMes = "JUN" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 7 Then
                    oMes = "JUL" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 8 Then
                    oMes = "AGO" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 9 Then
                    oMes = "SEP" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 10 Then
                    oMes = "OCT" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 11 Then
                    oMes = "NOV" & FechaSistema.Year.ToString.Substring(2, 2)
                ElseIf MesActual = 12 Then
                    oMes = "DIC" & FechaSistema.Year.ToString.Substring(2, 2)
                End If
                Dim SeEncontro As Boolean = False
                Dim CostoUnitario As Double = 0
                sql = New SqlCommand("select Costo_Unitario from Costos_Concentrados_x_Mes where Codigo='" & RTrim(Me.txtCodigo.Text) & "' and Mes_a_Trabajar='" & oMes & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    SeEncontro = True
                    CostoUnitario = leer(0)
                End While
                con.Close()

                If SeEncontro = False Then
                    MessageBoxEx.Show("No se encontró el costo unitario del material con codigo: " & RTrim(Me.txtCodigo.Text) & " puede ingresar el costo manual ó asegurarse de haber subido el archivo correspondiente al mes: " & RTrim(oMes), "No se encontro el material", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtPrecio.Enabled = True
                    Me.txtPrecio.Focus()

                Else
                    Me.txtPrecio.Enabled = False
                    Me.txtPrecio.TextBoxX1.Text = CostoUnitario
                    Me.txtCantidad.Focus()
                End If
                Me.txtPrecio.Enabled = True
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub tabla()
        Try
            Dim dc0 As New DataColumn("No.", System.Type.GetType("System.Int32"))
            Dim dc1 As New DataColumn("Codigo", System.Type.GetType("System.String"))
            Dim dc2 As New DataColumn("Descripcion", System.Type.GetType("System.String"))
            Dim dc3 As New DataColumn("Unitario", System.Type.GetType("System.Decimal"))
            Dim dc4 As New DataColumn("Cantidad", System.Type.GetType("System.Decimal"))
            Dim dc5 As New DataColumn("Importe", System.Type.GetType("System.Decimal"))
            dc1.Unique = True
            dc5.Expression = "Unitario*Cantidad"
            With carrito.Columns
                .Add(dc0)
                .Add(dc1)
                .Add(dc2)
                .Add(dc3)
                .Add(dc4)
                .Add(dc5)

            End With
            Me.DgDetalles.DataSource = Carrito
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message)
        End Try
        Me.DgDetalles.Columns(0).Width = 35
        Me.DgDetalles.Columns(1).Width = 70
        Me.DgDetalles.Columns(2).Width = 200
        Me.DgDetalles.Columns(3).Width = 73
        Me.DgDetalles.Columns(4).Width = 73
        Me.DgDetalles.Columns(5).Width = 75

        'Me.lbLineas.Text = Me.DgDetalles.Rows.Count

    End Sub

    Private Sub frmCargaCompras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.DgDetalles.Rows.Count > 0 Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Hay registros que no ha guardado, si sale de esta opción se perderán los registros" & vbCrLf & vbCrLf & "¿Desea continuar de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resp = MsgBoxResult.No Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        End If
    End Sub
   Private Sub frmCargaCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tabla()
        Me.MostrarBodegas()
        Me.IdCompra_Automatico()
        Me.txtNoDocumento.MaxLength = 10
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            Try
                If Not IsNumeric(Me.txtPrecio.TextBoxX1.Text) Then
                    MessageBoxEx.Show("El precio que ha ingresado es erroneo", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtPrecio.Focus()
                ElseIf Not IsNumeric(Me.txtCantidad.Text) Then
                    MessageBoxEx.Show("La cantidad que ha ingresado no es válida", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtCantidad.Focus()
                Else
                    Dim x1, x2, x3, x4 As String
                    x1 = Me.txtCodigo.Text
                    x2 = Me.txtDescripcion.Text
                    x3 = Me.txtPrecio.TextBoxX1.Text
                    x4 = Me.txtCantidad.Text
                    dr = Carrito.NewRow()
                    dr(0) = Carrito.Rows.Count + 1
                    dr(1) = x1
                    dr(2) = x2
                    dr(3) = x3
                    dr(4) = x4
                    Carrito.Rows.Add(dr)
                    Me.totales()
                    Me.txtCodigo.Clear()
                    Me.txtDescripcion.Clear()
                    Me.txtPrecio.TextBoxX1.Clear()
                    Me.txtCantidad.Clear()
                    Me.txtCodigo.Focus()
                End If
                
            Catch ex1 As System.Data.ConstraintException
                MessageBoxEx.Show("El producto ya ha sido agregado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBoxEx.Show("Se ha producido el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Sub BorrarLinea()
        Try
            fila = Me.DgDetalles.CurrentCell.RowIndex
            If fila > -1 And Carrito.Rows.Count > 0 Then
                total -= Single.Parse(Me.DgDetalles.Item(4, fila).Value)
                Carrito.Rows.RemoveAt(fila)
                Dim i As Integer
                For i = 0 To Carrito.Rows.Count - 1
                    Carrito.Rows(i).BeginEdit()
                    Carrito.Rows(i)(0) = i + 1
                    Carrito.Rows(i).EndEdit()
                Next
                totales()
            End If
        Catch ex As Exception
            MessageBoxEx.Show("Todos los productos han sido borrados de la Lista", "Informacion...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Me.lbLineas.Text = Me.DgvLineasReq.Rows.Count
    End Sub
    Private Sub totales()
        Try
            Dim i As Integer
            Dim total, totalp As Single
            Dim ValorLetras As String
            For i = 0 To carrito.Rows.Count - 1
                total += Carrito.Rows(i)(5)
            Next
            'iva = total * 13 / 100
            'Me.txtIVA.Text = iva.ToString("n1")
            totalp = total '+ iva
            Me.txtTotal.TextBoxX1.Text = Math.Round(totalp, 2)
            ValorLetras = Convertir_a_Letras(Me.txtTotal.TextBoxX1.Text)
            Me.txtTLetras.Text = UCase(ValorLetras)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DgDetalles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgDetalles.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.BorrarLinea()
        End If
    End Sub
    Sub Cargar_Existencias_Entrada()
        For i As Integer = 0 To Me.DgDetalles.Rows.Count - 1
            Verif = False
            Try
                sql = New SqlCommand("Select Existencia_Actual from EXISTENCIAS where Codigo= '" & Me.DgDetalles.Rows(i).Cells("Codigo").Value & "' AND Bodega='" & Me.cbxBodegas.Text & "'", con)
                Codigo = Me.DgDetalles.Rows(i).Cells("Codigo").Value
                Exist_Actual = Me.DgDetalles.Rows(i).Cells("Cantidad").Value

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
            If Verif = False Then
                Try
                    sql = New SqlCommand("Insert into EXISTENCIAS Values('" & Codigo & "','" & Me.cbxBodegas.Text & "','" & 0 & "','" & 0 & "','" & 0 & "','" & 0 & "','')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MessageBoxEx.Show("Se ha producido el Siguiente error: " & ex.Message, "Error Agregando Existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                End Try
           
            End If
        Next
    End Sub
    Sub MostrarBodegas()
        Try
            sql = New SqlCommand("select Bodega from BODEGAS", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxBodegas.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub
    Sub Guardar_Encabezado_Compras()
        Try
            sql = New SqlCommand("insert into Compras values('" & Me.txtID.TextBoxX1.Text & "','" & Me.txtNoDocumento.Text & "','" & Me.CajaFecha1.txtFecha.Text & "','" & Me.txtTotal.TextBoxX1.Text & "','" & Me.txtTLetras.Text & "','" & Me.DgDetalles.Rows.Count & "','" & Me.txtUserCreador.Text & "','" & Me.txtUserModify.Text & "','" & Me.txtJustificacion.Text & "')", con)
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
    Sub Guardar_Lineas_Compras()
        Try
            For i As Integer = 0 To Me.DgDetalles.Rows.Count - 1
                Dim existeProd_En_existencias_x_bodega As Boolean = False
                sql = New SqlCommand("select Codigo from Existencias where Bodega='" & Me.cbxBodegas.Text & "' and Codigo='" & Me.DgDetalles.Rows(i).Cells("Codigo").Value & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    existeProd_En_existencias_x_bodega = True
                End While
                con.Close()
                If existeProd_En_existencias_x_bodega = False Then
                    sql = New SqlCommand("insert into Existencias values('" & Me.DgDetalles.Rows(i).Cells("Codigo").Value & "','" & Me.cbxBodegas.Text & "','" & 0 & "','" & 0 & "','" & 0 & "','" & 0 & "','" & Me.DgDetalles.Rows(i).Cells("Descripcion").Value & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                End If
                sql2 = New SqlCommand("Select Peso from Inventario_Materiales where Codigo='" & Me.DgDetalles.Rows(i).Cells("Codigo").Value & "'", con)
                con.Open()
                leer = sql2.ExecuteReader
                While leer.Read
                    Peso = leer(0)
                End While


                '****************************BLOQUE TEMPORAL***********************
                Dim Lbs As Double
                Lbs = ((Me.DgDetalles.Rows(i).Cells("Cantidad").Value * 0.453592) / Peso)

                '(Peso * Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value) * 2.20462262
                'Me.DgvLineasReq.Rows(i).Cells("Cantidad").Value
                '******************************************************************
                con.Close()
                sql = New SqlCommand("insert into Lineas_de_Compras values('" & Me.txtID.TextBoxX1.Text & "','" & Me.txtNoDocumento.Text & "','" & Me.DgDetalles.Rows(i).Cells("No.").Value & "','" & Me.cbxBodegas.Text & "','" & Me.DgDetalles.Rows(i).Cells("Codigo").Value & "','" & Me.DgDetalles.Rows(i).Cells("Unitario").Value & "','" & Me.DgDetalles.Rows(i).Cells("Cantidad").Value & "','" & Math.Round(Me.DgDetalles.Rows(i).Cells("Importe").Value, 4) & "','" & Me.CajaFecha1.txtFecha.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                sql = New SqlCommand("insert into Kardex(Bodega,Codigo,Fecha,Documento,Ingreso_Egreso,Unidades,Costo_Unitario,Justificacion,ID,Granja,Lote_No) values('" & Me.cbxBodegas.Text & "','" & Me.DgDetalles.Rows(i).Cells("Codigo").Value & "','" & Me.CajaFecha1.txtFecha.Text & "','" & "Cp." & Me.txtNoDocumento.Text & "','I','" & Me.DgDetalles.Rows(i).Cells("Cantidad").Value & "','" & Me.DgDetalles.Rows(i).Cells("Unitario").Value & "','" & Me.txtJustificacion.Text & "','C','','" & 0 & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub
    
 Private Sub cbxBodegas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxBodegas.SelectedIndexChanged
        Me.Selecciono_Bodega = True
        Me.lbBodega.Text = Me.cbxBodegas.Text
        Try
            sql = New SqlCommand("select * from BODEGAS where Bodega='" & Me.cbxBodegas.SelectedItem.ToString & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.txtDescripcionBodega.Text = leer(1).ToString
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub
    Sub Limpiar_Cajas()
        Me.txtNoDocumento.Text = ""
        Me.txtJustificacion.Clear()
        Me.txtTLetras.Clear()
        Me.txtIVA.TextBoxX1.Text = "0.00"
        Me.txtTotal.TextBoxX1.Text = "0.00"
        For i As Integer = 0 To Me.DgDetalles.Rows.Count
            Me.Carrito.Rows.Clear()
        Next
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.Carrito.Rows.Count = 0 Then
            MessageBoxEx.Show("No hay ninguna linea en detalles de compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Me.txtNoDocumento.Text = "" Or Me.txtNoDocumento.Text = "0" Then
                MessageBox.Show("No ha ingresado el número del documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNoDocumento.Focus()
            ElseIf ValidarFechas(Me.CajaFecha1.txtFecha.Text) = False Then
                MessageBoxEx.Show("La fecha que ha ingresado es erronea", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CajaFecha1.txtFecha.Focus()
            ElseIf Me.Selecciono_Bodega = False Then
                MessageBoxEx.Show("No ha seleccionado la bodega que se va a cargar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbxBodegas.Focus()
            ElseIf Me.txtJustificacion.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la Justificación, porfavor ingrese una breve Información", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtJustificacion.Focus()
            Else
                Me.Guardar_Encabezado_Compras()
                Me.Guardar_Lineas_Compras()
                Me.Cargar_Existencias_Entrada()
                ActualizarExistencias()
                Me.Limpiar_Cajas()
                Me.IdCompra_Automatico()
                Me.txtNoDocumento.Focus()
            End If
        End If
        
    End Sub
    Sub IdCompra_Automatico()
        Try
            sql = New SqlCommand("select MAX(IdCompra) from Compras", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Me.txtID.TextBoxX1.Text = 0
                Else
                    Me.txtID.TextBoxX1.Text = (leer(0) + 1)
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub txtJustificacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJustificacion.TextChanged
        Me.txtJustificacion.Text = UCase(Me.txtJustificacion.Text)
        Me.txtJustificacion.SelectionStart = 150
    End Sub
    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = False
    End Sub
    Private Sub txtIVA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVA.KeyPress
        e.Handled = False
    End Sub
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        e.Handled = False
    End Sub

   
    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub
    Private Sub txtNoDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoDocumento.LostFocus
        Dim existeNoDoc As Boolean = False
        If Me.txtNoDocumento.Text <> "" Then
            Try
                sql = New SqlCommand("select No_Documento from Compras where No_Documento='" & RTrim(Me.txtNoDocumento.Text) & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    existeNoDoc = True
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error al verificar No Documento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            If existeNoDoc = True Then
                MessageBoxEx.Show("El número de documento que ha ingresado ya existe, favor verifiquelo y vuelva a intentarlo", "Doc. Verificación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtNoDocumento.Text = ""
                Me.txtNoDocumento.Focus()
            End If
        End If
    End Sub

   
    Private Sub DgDetalles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgDetalles.CellContentClick

    End Sub
End Class