Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmRegistrar_Verraco
    Dim claseHatoReprodAdapter As New DtsBDGRANJATableAdapters.ClasesHatosReprodTableAdapter
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If Me.btnCerrar.Text = "&Cerrar" Then
            Me.Close()
        ElseIf Me.btnCerrar.Text = "&Cancelar" Then
            Me.btnCerrar.Text = "&Cerrar"
            Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
            Me.Limpiar()
            Me.Deshabilitar()
            Me.btnGuardar.Enabled = False
            Me.btnNuevo.Enabled = True
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.btnCerrar.Text = "&Cancelar"
        Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.button_cancel)
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Habilitar()
        Me.Limpiar()
        Me.TabControl1.TabIndex = 0
        Me.txtDocumentoNo.Focus()
    End Sub
    Sub Limpiar()
        Me.txtCodigo.Text = ""
        Me.txtDocumentoNo.Text = ""
        Me.txtCosto.Text = ""
        Me.txtDepreciacion.Value = 5
        Me.txtFecha.Text = ""
        Me.txtGenetica.Text = ""
        Me.txtMadre.Text = ""
        Me.txtPadre.Text = ""
        Me.txtValorResidual.Text = ""
        Me.origenTextBoxX2.Text = ""
        Me.pesoDoubleInput1.Value = 0
        Me.notaTextBoxX1.Text = ""

    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtDocumentoNo.Text = "" Then
            MessageBoxEx.Show("No ingresado el no de documento con el que realizó la compra del verraco", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txtDocumentoNo.Focus()
        ElseIf Me.txtCodigo.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el codigo del verraco", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txtCodigo.Focus()
        ElseIf Me.txtDepreciacion.Text = "" Then
            MessageBoxEx.Show("No la depreciacion del verraco", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txtDepreciacion.Focus()
        ElseIf Me.txtCosto.Text = "" Then
            MessageBoxEx.Show("No la depreciacion del verraco", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txtCosto.Focus()
        ElseIf Me.txtPadre.Text = "" Then
            MessageBoxEx.Show("No ingresado el padre", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txtPadre.Focus()
        ElseIf Me.txtMadre.Text = "" Then
            MessageBoxEx.Show("No ingresado la madre", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txtMadre.Focus()
        ElseIf Me.txtValorResidual.Text = "" Then
            MessageBoxEx.Show("No ingresado el valor residual", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txtValorResidual.Focus()
        Else
            Try


                Dim cnx As New SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
                Dim cmd As New SqlCommand("Proc_InsertarVerraco", cnx)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CodigoVerraco", SqlDbType.Char, 8).Value = Me.txtCodigo.Text
                cmd.Parameters.Add("@FechaCompra", SqlDbType.DateTime).Value = Me.txtFecha.Text
                cmd.Parameters.Add("@Padre", SqlDbType.Char, 12).Value = Me.txtPadre.Text
                cmd.Parameters.Add("@Madre", SqlDbType.Char, 12).Value = Me.txtMadre.Text
                cmd.Parameters.Add("@Genetica", SqlDbType.Char, 12).Value = Me.txtGenetica.Text
                cmd.Parameters.Add("@Costo", SqlDbType.Float).Value = Me.txtCosto.Text
                cmd.Parameters.Add("@Depreciacion", SqlDbType.Int).Value = txtDepreciacion.Value
                cmd.Parameters.Add("@ValorResidual", SqlDbType.Decimal, 12.2).Value = Me.txtValorResidual.Text
                cmd.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = FechaSistema
                cmd.Parameters.Add("@Documento", SqlDbType.Char, 12).Value = txtDocumentoNo.Text
                cmd.Parameters.Add("@IdClase", SqlDbType.Char, 2).Value = Me.clasificacionComboBoxEx1.SelectedValue
                cmd.Parameters.Add("@Origen", SqlDbType.Char, 100).Value = Me.origenTextBoxX2.Text
                cmd.Parameters.Add("@Nota", SqlDbType.Char, 250).Value = Me.notaTextBoxX1.Text
                cmd.Parameters.Add("@Peso", SqlDbType.Decimal, 12.2).Value = Me.pesoDoubleInput1.Value
                cnx.Open()
                leer = cmd.ExecuteReader

                Dim hay_error As Boolean, mensaje As String
                While leer.Read
                    hay_error = leer(0)
                    mensaje = leer(1)
                End While
                cnx.Close()
                If hay_error = True Then
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ActualizarDpcs()
                    Me.Limpiar()

                    Me.btnCerrar.Text = "&Cerrar"
                    Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
                    Me.btnNuevo.Enabled = True
                    Me.btnGuardar.Enabled = False
                    Deshabilitar()
                    cargarClaseHatoReprdo()
                    MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Using oCon As New SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
            '    oCon.Open()

            '    Dim command As SqlCommand = oCon.CreateCommand()
            '    Dim transaction As SqlTransaction
            '    transaction = oCon.BeginTransaction("SampleTransaction")
            '    command.Transaction = transaction
            '    command.Connection = oCon
            '    Try


            '        command.CommandText = "INSERT INTO REG_VERRACOS VALUES('" & Me.txtCodigo.Text & "','" & Me.txtFecha.Text & "','" & Me.txtPadre.Text & "','" & Me.txtMadre.Text & "','" & Me.txtGenetica.Text & "','" & Me.txtCosto.Text & "','" & Me.txtDepreciacion.Value & "','" & FechaSistema & "','" & 3 & "','A','" & Me.txtDocumentoNo.Text & "','" & Me.clasificacionComboBoxEx1.SelectedValue & "', '" & Me.origenTextBoxX2.Text & "', " & Me.pesoDoubleInput1.Value & ",'" & Me.notaTextBoxX1.Text & "')"
            '        command.ExecuteNonQuery()

            '        command.CommandText = "insert into Depreciaciones_Verracos values('" & Me.txtCodigo.Text & "','" & Me.txtCosto.Text & "','" & Me.txtDepreciacion.Value & "','" & Me.txtValorResidual.Text & "','" & 0 & "','" & 365 & "','" & 1152 & "','" & 3 & "','" & True & "','" & True & "')"
            '        command.ExecuteNonQuery()

            '        command.CommandText = "insert into Movimiento_Lote (Lote_No, Reemplazos, Defuncion, Destazo, Rastro, Entrada, Salida, Fecha_Movimiento, Documento_NO) values('3',0,0,0,0,1,0,'" & FechaSistema & "','" & Me.txtDocumentoNo.Text & "')"
            '        command.ExecuteNonQuery()

            '        transaction.Commit()


            '        ActualizarDpcs()
            '        Me.Limpiar()

            '        Me.btnCerrar.Text = "&Cerrar"
            '        Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
            '        Me.btnNuevo.Enabled = True
            '        Me.btnGuardar.Enabled = False
            '        Deshabilitar()
            '        cargarClaseHatoReprdo()
            '    Catch ex As Exception
            '        transaction.Rollback()
            '        MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar registro verraco", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Finally
            '        If oCon.State = ConnectionState.Open Then
            '            oCon.Close()
            '        End If
            '    End Try
            'End Using

        End If
    End Sub
    Sub ActualizarDpcs()
        Try
            sql = New SqlCommand("ActualizarDepreciaciones_Verracos", con)
            sql.CommandType = CommandType.StoredProcedure
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al actualizar Dpcs", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub Habilitar()
        Me.txtCodigo.Enabled = True
        Me.txtCosto.Enabled = True
        Me.txtDepreciacion.Enabled = True
        Me.txtFecha.Enabled = True
        Me.txtGenetica.Enabled = True
        Me.txtMadre.Enabled = True
        Me.txtPadre.Enabled = True
        Me.txtDocumentoNo.Enabled = True
        Me.txtValorResidual.Enabled = True
        Me.notaTextBoxX1.Enabled = True
        Me.origenTextBoxX2.Enabled = True


    End Sub
    Sub Deshabilitar()
        Me.txtDocumentoNo.Enabled = False
        Me.txtCodigo.Enabled = False
        Me.txtCosto.Enabled = False
        Me.txtDepreciacion.Enabled = False
        Me.txtFecha.Enabled = False
        Me.txtGenetica.Enabled = False
        Me.txtMadre.Enabled = False
        Me.txtPadre.Enabled = False
        Me.txtValorResidual.Enabled = False
        Me.notaTextBoxX1.Enabled = False
        Me.origenTextBoxX2.Enabled = False
    End Sub
   

    Private Sub txtFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 47 And Not Asc(e.KeyChar) = 46 And Not Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If txtFecha.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            txtFecha.Text = txtFecha.Text & "/"
            txtFecha.SelectionStart = 4
        ElseIf txtFecha.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            txtFecha.Text = txtFecha.Text & "/"
            txtFecha.SelectionStart = 6
        End If
    End Sub
    Sub cargarClaseHatoReprdo()
        Try
            clasificacionComboBoxEx1.DataSource = claseHatoReprodAdapter.GetData
            clasificacionComboBoxEx1.DisplayMember = "Descripcion"
            clasificacionComboBoxEx1.ValueMember = "IdClase"

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar Clases H. Reprod.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   
    Private Sub TabControlPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlPanel1.Click

    End Sub

    Private Sub frmRegistrar_Verraco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarClaseHatoReprdo()
    End Sub
End Class