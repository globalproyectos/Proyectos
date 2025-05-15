Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class frmRegistrarMedicamentos
    Dim ms1 As New MemoryStream
    Dim Img1() As Byte
    Dim ms2 As New MemoryStream
    Dim Img2() As Byte
    Dim SeleccionoTipo As Boolean = False
   
    'Private Sub LocalizarMedToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.Sl_MedicamentosTableAdapter.LocalizarMed(Me.DtsBDGRANJA.Sl_Medicamentos, Me.txtDescripcion.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If Me.btnCerrar.Text = "&Cerrar" Then
            Me.Close()
        ElseIf Me.btnCerrar.Text = "&Cancelar" Then
            Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
            Me.btnGuardar.Enabled = False
            Me.Limpiar()
            Deshabilitar()
            Me.btnNuevo.Enabled = True
            Me.btnCerrar.Text = "&Cerrar"
        End If
    End Sub
    Sub GuardarMaterial()
        Try
            Try
                Me.imgMedicamento.Image.Save(ms1, Me.imgMedicamento.Image.RawFormat)
                Me.Img1 = ms1.GetBuffer
            Catch ex As Exception
                Me.ImagenVacia.Image.Save(ms1, Me.ImagenVacia.Image.RawFormat)
                Me.Img1 = ms1.GetBuffer
            End Try
            sql = New SqlCommand("INSERT INTO Inventario_Materiales([Codigo], [Descripcion], [Marca], [Unidad], [Tipo], [Costo_Unitario], [Existencia], [Costo_Total], [Ingresos], [Egresos], [Fecha_Entrada], [Fecha_Vencimiento], [Maneja_Existencias], [Disponible], [Etapa], [Peso], [Unidad_x_Presentacion], [Activo], [Orden_Alimentacion]) VALUES('" & Me.txtCodigo.Text & "','" & Me.txtDescripcionMaterail.Text & "','" & Me.txtMarca.Text & "','" & Me.cbxUnidadMedida.Text & "','" & Me.cbxTipo.Text & "','" & 0 & "','" & 0 & "','" & 0 & "','" & 0 & "','" & 0 & "','" & Me.txtFechaCreacion.Text & "','" & Me.txtFechaVencimiento.Text & "','" & True & "','" & True & "','" & Me.txtIdEtapa.Text & "','" & Me.txtPeso.Text & "','" & Me.txtUnidad_x_Presentacion.Text & "', '" & True & "', " & Me.ordenalimentacionIntegerInput1.Value & ")", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()

            Dim cmd As String = "insert into Costos_Concentrados_x_Mes (Codigo , Descripcion , Costo_Unitario , Mes_Segun_Datalisys ,Mes_a_Trabajar , Fecha_Inicio_Trabajar ,Fecha_Fin_Trabajar )" _
                              & " select TOP 1 '" & RTrim(Me.txtCodigo.Text) & "','" & RTrim(Me.txtDescripcionMaterail.Text) & "'," & CDbl(Me.costoTextBox1.Text) & ",c.Mes_Segun_Datalisys , c.Mes_a_Trabajar , c.Fecha_Inicio_Trabajar ,c.Fecha_Fin_Trabajar" _
                              & " from Costos_Concentrados_x_Mes c" _
                              & " where '" & FechaSistema & "' between c.Fecha_Inicio_Trabajar and c.Fecha_Fin_Trabajar"

            sql = New SqlCommand(cmd, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            'sql = New SqlCommand("INSERT INTO PRODUCTOS VALUES(@Codigo,@Descripcion,@Unidad,@Peso,@Costo,@IdEtapa,@UXP,@FechaCreacion,@UsuarioCreador,@Image)", con)
            'With sql.Parameters
            '    .Add(New SqlParameter("@Codigo", SqlDbType.Char, 12)).Value = Me.txtCodigo.Text
            '    .Add(New SqlParameter("@Descripcion", SqlDbType.Char, 50)).Value = Me.txtDescripcionMaterail.Text
            '    .Add(New SqlParameter("@Unidad", SqlDbType.Char, 10)).Value = Me.cbxUnidadMedida.Text
            '    .Add(New SqlParameter("@Peso", SqlDbType.Float)).Value = Me.txtPeso.Text
            '    .Add(New SqlParameter("@Costo", SqlDbType.Float)).Value = 0
            '    .Add(New SqlParameter("@IdEtapa", SqlDbType.Char, 3)).Value = Me.txtIdEtapa.Text
            '    .Add(New SqlParameter("@UXP", SqlDbType.Float)).Value = Me.txtUnidad_x_Presentacion.Text
            '    .Add(New SqlParameter("@FechaCreacion", SqlDbType.Date)).Value = Me.txtFechaCreacion.Text
            '    .Add(New SqlParameter("@UsuarioCreador", SqlDbType.Char, 30)).Value = UsuarioActual
            '    .Add(New SqlParameter("@Image", SqlDbType.Image)).Value = Img1

            'End With
            'con.Open()
            'sql.ExecuteNonQuery()
            'con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar material", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.txtCodigo.Text = "" Then
                MessageBoxEx.Show("No ha ingresado el Codigo", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtCodigo.Focus()
            ElseIf Me.txtDescripcionMaterail.Text = "" Then
                MessageBoxEx.Show("No ha ingresado La Descripcion", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtDescripcionMaterail.Focus()
                'ElseIf SeleccionoTipo = False Then
                '    MessageBoxEx.Show("No ha seleccionado el tipo", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '    Me.TipoTextBoxX.Focus()
            ElseIf txtIdEtapa.Text = "" Then
                MessageBoxEx.Show("No ha especificado la etapa", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtIdEtapa.Focus()
            ElseIf txtPeso.Text = "" Then
                MessageBoxEx.Show("No ha ingresado el peso", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtPeso.Focus()
            ElseIf CDbl(Me.costoTextBox1.Text) = 0 Then
                MessageBoxEx.Show("No ha ingresado el costo con el que iniciará el código", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.costoTextBox1.Focus()
                Me.costoTextBox1.SelectAll()
            Else
                Try
                    Me.GuardarMaterial()
                    Try
                        For i As Integer = 0 To Me.bodegasCheckedListBox1.Items.Count - 1
                            If bodegasCheckedListBox1.GetItemCheckState(i) = CheckState.Checked Then
                                Dim existe As Boolean = False
                                sql = New SqlCommand("select codigo from existencias where codigo= '" & RTrim(Me.txtCodigo.Text) & "' and bodega='" & RTrim(Me.bodegasCheckedListBox1.Items(i).ToString) & "'", con)
                                con.Open()
                                leer = sql.ExecuteReader
                                While leer.Read
                                    existe = True
                                End While
                                con.Close()
                                If existe <> True Then
                                    sql = New SqlCommand("insert into existencias values('" & Me.txtCodigo.Text & "','" & Me.bodegasCheckedListBox1.Items(i).ToString & "','0','0','0','0','" & Me.txtDescripcionMaterail.Text & "')", con)
                                    con.Open()
                                    sql.ExecuteNonQuery()
                                    con.Close()
                                End If

                            End If

                        Next
                    Catch ex As Exception

                        MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If

                    End Try

                    MessageBoxEx.Show("Registro guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Deshabilitar()
                    Me.imgMedicamento.Image = New System.Drawing.Bitmap(My.Resources.SinImagen)
                    Me.btnCerrar.Text = "&Cerrar"
                    Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
                    Me.btnGuardar.Enabled = False
                    Me.btnNuevo.Enabled = True

                Catch ex As Exception
                    MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            Me.imgMedicamento.Image.Save(ms1, Me.imgMedicamento.Image.RawFormat)
            Me.Img1 = ms1.GetBuffer
        Catch ex As Exception
            Me.ImagenVacia.Image.Save(ms1, Me.ImagenVacia.Image.RawFormat)
            Me.Img1 = ms1.GetBuffer
        End Try
    End Sub
    Sub Limpiar()
        Me.txtCodigo.Text = ""
        Me.txtDescripcionMaterail.Text = ""
        Me.costoTextBox1.Text = "0.00"
        Me.txtMarca.Text = ""
        Me.cbxTipo.Text = ""
        For I As Integer = 0 To Me.cbxUnidadMedida.Items.Count - 1
            If Me.cbxUnidadMedida.Items(I).ToString = "" Then
                Me.cbxUnidadMedida.SelectedIndex = I
            End If
        Next
        Me.txtIdEtapa.Text = ""
        Me.txtPeso.Text = ""
        Me.txtUnidad_x_Presentacion.Text = ""
        Me.txtDescripcionTipo.Text = ""
        Me.txtDescripcionEtapa.Text = ""
        Me.ordenalimentacionIntegerInput1.Value = 0

    End Sub
    Sub Habilitar()
        Me.txtCodigo.Enabled = True
        Me.txtDescripcionMaterail.Enabled = True
        Me.txtMarca.Enabled = True
        Me.txtFechaVencimiento.Enabled = True
        Me.txtIdEtapa.Enabled = True
        Me.txtPeso.Enabled = True
        Me.txtUnidad_x_Presentacion.Enabled = True
        Me.cbxTipo.Enabled = True
        Me.cbxUnidadMedida.Enabled = True
        Me.ButtonX1.Enabled = True
        Me.costoTextBox1.Enabled = True
        Me.ordenalimentacionIntegerInput1.Enabled = True

    End Sub
    Sub Deshabilitar()
        Me.txtCodigo.Enabled = False
        Me.costoTextBox1.Enabled = False
        Me.txtDescripcionMaterail.Enabled = False
        Me.txtMarca.Enabled = False
        Me.txtFechaVencimiento.Enabled = False
        Me.txtIdEtapa.Enabled = False
        Me.txtPeso.Enabled = False
        Me.txtUnidad_x_Presentacion.Enabled = False
        Me.cbxTipo.Enabled = False
        Me.cbxUnidadMedida.Enabled = False
        Me.ButtonX1.Enabled = False
        Me.ordenalimentacionIntegerInput1.Enabled = False
    End Sub
    Sub MostrarTipos()
        Try
            Me.cbxTipo.Items.Clear()
            sql = New SqlCommand("SELECT Codigo FROM Tipos_Productos", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxTipo.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar Tipos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.Limpiar()
        Me.Habilitar()
        Me.MostrarTipos()
        Me.txtCodigo.Focus()
        Me.imgMedicamento.Image = New System.Drawing.Bitmap(My.Resources.SinImagen)
        Me.btnCerrar.Text = "&Cancelar"
        Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.button_cancel)
        Me.btnGuardar.Enabled = True
        Me.btnNuevo.Enabled = False
        'Me.TipoTextBoxX.Text = "M"
        Me.Costo_UnitarioTextBoxX.Text = "0.00"
        Me.txtUsuarioCreador.Text = UsuarioActual
        Me.txtUnidad_x_Presentacion.Text = "1"
        Me.txtMarca.Text = ""
        'Me.TipoTextBoxX.Text = Me.TipoTextBoxX.Text
        Me.txtFechaCreacion.Text = FechaSistema
        Me.txtFechaVencimiento.Text = "01/01/1901"
        Try
            Me.bodegasCheckedListBox1.Items.Clear()

            sql = New SqlCommand("select bodega from bodegas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.bodegasCheckedListBox1.Items.Add(RTrim(leer(0)))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        

    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        With OpenFileDialog1
            .Filter = "JPG|*.jpg|GIF|*.gif|PNG|*.png"
            .FileName = ""
            If (.ShowDialog(Me)) = Windows.Forms.DialogResult.OK Then
                Me.imgMedicamento.ImageLocation = .FileName.ToString
            End If
        End With
    End Sub

    Private Sub TipoTextBoxX_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipo.SelectedIndexChanged

        If Me.cbxTipo.Text <> "" Then
            Dim existeTipo As Boolean = False
            Dim DescriTipo As String = ""
            sql = New SqlCommand("select Descripcion from Tipos_Productos where Codigo='" & Me.cbxTipo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                existeTipo = True
                DescriTipo = leer(0).ToString
            End While
            con.Close()
            If existeTipo = False Then
                MessageBoxEx.Show("No existe ningun tipo de producto con ese codigo", "Tipo no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.cbxTipo.Text = ""
                Me.txtDescripcionTipo.Text = ""
            Else
                Me.txtDescripcionTipo.Text = DescriTipo
            End If
        End If
    End Sub
    Private Sub IdEtapaTextBoxX_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdEtapa.KeyDown
        If e.KeyCode = Keys.F5 Then
            With My.Forms.dlgEtapas_Alimentos_Medicamentos
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub IdEtapaTextBoxX_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdEtapa.LostFocus
        If Me.txtIdEtapa.Text <> "" Then
            Dim ExisteEtapas As Boolean = False
            Dim DescrEtapa As String = ""
            sql = New SqlCommand("SELECT Etapa FROM Etapas WHERE IdEtapa='" & Me.txtIdEtapa.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ExisteEtapas = True
                DescrEtapa = leer(0)
            End While
            con.Close()
            If ExisteEtapas = False Then
                MessageBoxEx.Show("No hay ninguna etapa con el ID: " & Me.txtIdEtapa.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtIdEtapa.Text = ""
                Me.txtDescripcionEtapa.Text = ""
            Else
                Me.txtDescripcionEtapa.Text = DescrEtapa
            End If
        End If
    End Sub
    Private Sub txtFechaVencimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaVencimiento.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 47 And Not Asc(e.KeyChar) = 46 And Not Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If txtFechaVencimiento.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            txtFechaVencimiento.Text = txtFechaVencimiento.Text & "/"
            txtFechaVencimiento.SelectionStart = 4
        ElseIf txtFechaVencimiento.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            txtFechaVencimiento.Text = txtFechaVencimiento.Text & "/"
            txtFechaVencimiento.SelectionStart = 6
        End If
    End Sub
    Private Sub txtDescripcionMaterail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionMaterail.TextChanged
        Me.txtDescripcionMaterail.Text = UCase(Me.txtDescripcionMaterail.Text)
        Me.txtDescripcionMaterail.SelectionStart = 51

    End Sub

    Private Sub txtMarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarca.TextChanged
        Me.txtMarca.Text = UCase(Me.txtMarca.Text)
        Me.txtMarca.SelectionStart = 51
    End Sub

    Private Sub txtIdEtapa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdEtapa.TextChanged
        Me.txtIdEtapa.Text = UCase(Me.txtIdEtapa.Text)
        Me.txtIdEtapa.SelectionStart = 4
    End Sub

    Private Sub cbxUnidadMedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxUnidadMedida.SelectedIndexChanged
        Me.cbxUnidadMedida.Text = UCase(Me.cbxUnidadMedida.Text)
        Me.cbxUnidadMedida.SelectionStart = 60
    End Sub
    Private Sub cbxTipo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipo.TextChanged
        TipoTextBoxX_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus

        Try
            Dim existe As Boolean = False
            sql = New SqlCommand("select codigo from inventario_materiales where codigo='" & RTrim(Me.txtCodigo.Text) & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                existe = True
            End While
            con.Close()
            If existe = True Then
                MessageBoxEx.Show("El código que ha digitado ya existe en el inventario", "Código ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCodigo.Focus()
                Me.txtCodigo.SelectAll()
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Sub

   

    
   
   
    
End Class