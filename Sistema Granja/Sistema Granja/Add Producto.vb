Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports DevComponents
Imports System.IO

Public Class Add_Producto
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim prodEn As String = ", el error se produjo el el BLOQUE AP-"
    Dim Etapa As String
    Dim ms As New MemoryStream
    Dim Imagen() As Byte
    Dim ValCbxEtapas As Boolean
    Dim ValCbxUnidades As Boolean
    Dim Tema As String
    Dim ProdExistencias As Boolean
    Sub lista_productos()
        Try
            'BLOQUE AP-1
            sql = New SqlCommand("Select codigo,descripcion,Unidad,peso,Costo_Unitario,etapa,Unidad_x_Presentacion from inventario_materiales", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Código"))
                .Add(New DataColumn("Descripción"))
                .Add(New DataColumn("Unidad Medida"))
                .Add(New DataColumn("Peso"))
                .Add(New DataColumn("Costo $"))
                .Add(New DataColumn("Etapa"))
                .Add(New DataColumn("UxP"))
            End With

            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    MessageBoxEx.Show("La lista de productos esta vacia", "Lista de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer(1)
                    dr(2) = leer(2)
                    dr(3) = leer(3)
                    dr(4) = leer(4)
                    dr(5) = leer(5)
                    dr(6) = leer(6)
                    dt.Rows.Add(dr)
                End If
            End While
            dv = New DataView(dt)
            Me.dgvListaProductos.DataSource = dv
            con.Close()
            Me.lbNoProd.Text = Me.dgvListaProductos.Rows.Count - 1
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 1, "Error al recuperar lista productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub RecuperarEtapas()
        Try
            'BLOQUE AP-2
            Me.cbxEtapas.Items.Clear()
            sql = New SqlCommand("Select Etapa from Etapas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxEtapas.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show("Se ha producido el siguiente error: " & ex.Message & prodEn & 2, "Error recuperando etapas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub GuardarProducto()
        'BLOQUE AP-3
       
        Try
            'BLOQUE AP-3-1
            sql = New SqlCommand("Select IdEtapa from Etapas where Etapa='" & Me.cbxEtapas.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Etapa = leer(0)
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & "3 - 1", "Error cargar etapa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Try
            Me.ProdExistencias = False
            'BLOQUE(AP - 3 - 2)
            'sql = New SqlCommand("Insert into PRODUCTOS values(@Codigo,@Descripcion,@UnidadMedida,@Peso,@Costo,@Etapa,@UxP,@FechaCreacion,@UsuarioCreador,@Image)", con)
            'With sql
            '    .Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Char, 8)).Value = Me.txtCodigo.Text
            '    .Parameters.Add(New SqlParameter("Descripcion", SqlDbType.Char, 50)).Value = Me.txtDescripcion.Text
            '    .Parameters.Add(New SqlParameter("@UnidadMedida", SqlDbType.Char, 10)).Value = Me.cbxUnidades.Text
            '    .Parameters.Add(New SqlParameter("@Peso", SqlDbType.Float)).Value = Me.txtPeso.Text
            '    .Parameters.Add(New SqlParameter("@Costo", SqlDbType.Float)).Value = Me.txtCosto.Text
            '    .Parameters.Add(New SqlParameter("@Etapa", SqlDbType.Char, 25)).Value = Etapa
            '    .Parameters.Add(New SqlParameter("@UxP", SqlDbType.Float)).Value = Me.txtUnidadxPresentacion.Text
            '    .Parameters.Add(New SqlParameter("@FechaCreacion", SqlDbType.DateTime)).Value = FechaSistema
            '    .Parameters.Add(New SqlParameter("@UsuarioCreador", SqlDbType.Char, 20)).Value = UsuarioActual
            '    .Parameters.Add(New SqlParameter("@Image", SqlDbType.Image)).Value = Imagen
            'End With
            'con.Open()
            'sql.ExecuteNonQuery()
            'con.Close()
            sql = New SqlCommand("insert into Inventario_Materiales values('" & Me.txtCodigo.Text & "','" & Me.txtDescripcion.Text & "','','" & Me.cbxUnidades.Text & "','CONCENTRADOS','','','','','','" & FechaSistema & "','" & FechaSistema & "','" & True & "','" & True & "','" & Me.cbxEtapas.Text & "','" & Me.txtPeso.Text & "','" & Me.txtUnidadxPresentacion.Text & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            sql = New SqlCommand("select * from Existencias where Codigo_Producto='" & Me.txtCodigo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.ProdExistencias = True
            End While
            con.Close()
            If Me.ProdExistencias = False Then
                sql = New SqlCommand("insert into Existencias values('" & Me.txtCodigo.Text & "',)")
            End If
            Me.limpiar_cajas()
            Me.btnGuardar.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.deshabilitar_cajas()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & "3-2", "Error al intentar guardar producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
       End Sub
    Private Sub Add_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' BLOQUE AP-4
            Me.lista_productos()
            Me.RecuperarEtapas()
            Me.dgvListaProductos.Columns(0).Width = 50
            Me.dgvListaProductos.Columns(1).Width = 250
            Me.dgvListaProductos.Columns(2).Width = 67
            Me.dgvListaProductos.Columns(3).Width = 67
            Me.dgvListaProductos.Columns(4).Width = 67
            Me.dgvListaProductos.Columns(5).Width = 67
            Me.dgvListaProductos.Columns(6).Width = 67
            '*************************ESTILO DE LA TABLA**************************************
            Me.dgvListaProductos.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 7, FontStyle.Bold, GraphicsUnit.Point)
            Me.dgvListaProductos.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark
            Me.dgvListaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            Me.dgvListaProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgvListaProductos.DefaultCellStyle.Font = New Font("Tahoma", 6.5, FontStyle.Regular, GraphicsUnit.Point)
            Me.dgvListaProductos.DefaultCellStyle.BackColor = Color.Empty
            Me.dgvListaProductos.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
            Me.dgvListaProductos.CellBorderStyle = DataGridViewCellBorderStyle.Single
            Me.dgvListaProductos.GridColor = SystemColors.ControlDarkDark
            '*********************************************************************************
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 4, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Public Sub limpiar_cajas()
        Me.txtCodigo.Clear()
        Me.txtDescripcion.Clear()
        Me.cbxEtapas.Text = ""
        Me.cbxUnidades.Text = ""
        Me.txtUnidadxPresentacion.Clear()
    End Sub
    Public Sub habilitar_cajas()
        Me.txtDescripcion.Enabled = True
        Me.txtCodigo.Enabled = True
        Me.cbxEtapas.Enabled = True
        Me.txtPeso.Enabled = True
        Me.cbxUnidades.Enabled = True
        Me.txtUnidadxPresentacion.Enabled = True
    End Sub
    Public Sub deshabilitar_cajas()
        Me.txtDescripcion.Enabled = False
        Me.txtCodigo.Enabled = False
        Me.txtPeso.Enabled = False
        Me.cbxUnidades.Enabled = False
        Me.cbxEtapas.Enabled = False
        Me.txtUnidadxPresentacion.Enabled = False
    End Sub
    'Public Sub Cod_Product_Automatico()
    '    Try
    '        'BLOQUE AP-5
    '        sql = New SqlCommand("select MAX(Codigo_Producto) from PRODUCTOS", con)
    '        con.Open()
    '        leer = sql.ExecuteReader
    '        While leer.Read
    '            If leer.IsDBNull(0) = True Then
    '                Me.txtCodigo.Text = "1010101"
    '            Else
    '                Me.txtCodigo.Text = leer(0) + 1
    '            End If
    '        End While
    '        con.Close()
    '    Catch ex As Exception
    '        MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 5, "Error generar Cód. Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        con.Close()
    '    End Try
    'End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.lista_productos()
    End Sub
    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.limpiar_cajas()
        Me.habilitar_cajas()
        'Me.Cod_Product_Automatico()
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.txtCodigo.Focus()
    End Sub
  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            'BLOQUE AP-6
            If Me.txtDescripcion.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la descripción del producto", "Guardar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
          
            ElseIf Me.txtPeso.Text = "" Then
                MessageBoxEx.Show("No ha ingresado el peso del producto", "Guardar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPeso.Focus()
            ElseIf Me.ValCbxEtapas = False Then
                MessageBoxEx.Show("No ha seleccionado la etapa", "Etapas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbxEtapas.Focus()
            ElseIf Me.ValCbxUnidades = False Then
                MessageBoxEx.Show("No ha seleccionado las unidades", "Etapas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbxUnidades.Focus()
            Else
                Me.GuardarProducto()
                Me.lista_productos()
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 6, "Error al intentar guardar producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 209 Or Asc(e.KeyChar) = 241 Then
            e.Handled = False
            Me.DetectorError.Clear()
        Else
            Me.DetectorError.SetError(Me.txtDescripcion, "No se puede ingresar caracteres especiales en un campo Descripción")
            e.Handled = True
        End If
    End Sub
    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Me.txtDescripcion.Text = UCase(Me.txtDescripcion.Text)
        Me.txtDescripcion.SelectionStart = 60
    End Sub
    Private Sub txtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cbxBodega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub
   Private Sub cbxUnidades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxUnidades.SelectedIndexChanged
        Me.ValCbxUnidades = True
    End Sub
    Private Sub cbxEtapas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEtapas.SelectedIndexChanged
        Me.ValCbxEtapas = True
    End Sub
End Class