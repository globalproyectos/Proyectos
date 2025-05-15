Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmReg_Abuelas
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim CerdasActuales As Integer
    Dim claseHatoReprodAdapter As New DtsBDGRANJATableAdapters.ClasesHatosReprodTableAdapter
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Private Sub txtCodCerda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCerda.TextChanged
        If Me.txtCodCerda.TextLength <> 0 Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub
    Sub Limpiar()
        Me.txtCodCerda.Clear()
        Me.txtCosto.Clear()
        Me.cbxMadre_Madres.Text = ""
        Me.txtPadre.Clear()
        Me.cbxGenetica.Text = ""
        Me.NumPartos.Value = 0
        Me.txtFecha.Text = ""
        Me.depreciarCheckBoxX1.Checked = False
        Me.valorresidualDoubleInput1.Value = 0
        Me.clasificacionComboBoxEx1.Text = ""
        Me.documentoTextBoxX1.Clear()
        Me.origenTextBoxX1.Clear()
        Me.pesoDoubleInput1.Value = 0
        Me.notaTextBoxX2.Clear()
        txtNomb_o_Num.Clear()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If moverACbx.Text = "" Then
            MessageBoxEx.Show("Debe seleccionar a donde se moveran la(s) cerda(s) ingresada(s)", "Guardar Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            moverACbx.Focus()
        ElseIf txtFecha.Text = "" Then
            MessageBoxEx.Show("No ha ingresado la fecha de Nacimiento de la cerda", "Guardar Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtFecha.TextLength < 8 Then
            MessageBoxEx.Show("La fecha Ingresada esta incompleta", "Guardar Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Trim(documentoTextBoxX1.Text) = "" Then
            MessageBoxEx.Show("El campo documento no puede quedar vacío", "Guardar Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.documentoTextBoxX1.Focus()
        Else
            Try

                sql = New SqlCommand("Proc_InsertarAbuela", con)
                sql.CommandType = CommandType.StoredProcedure
                sql.Parameters.Add("@CodigoCerda", SqlDbType.Char, 8).Value = Me.txtCodCerda.Text
                sql.Parameters.Add("@NoCerda", SqlDbType.Char, 12).Value = Me.txtNomb_o_Num.Text
                sql.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = txtFecha.Text
                sql.Parameters.Add("@Padre", SqlDbType.Char, 12).Value = txtPadre.Text
                sql.Parameters.Add("@Madre", SqlDbType.Char, 12).Value = cbxMadre_Madres.Text
                sql.Parameters.Add("@Genetica", SqlDbType.Char, 12).Value = cbxGenetica.Text
                sql.Parameters.Add("@Costo", SqlDbType.Decimal, 10.2).Value = txtCosto.Text
                sql.Parameters.Add("@Depreciacion", SqlDbType.Int).Value = NumPartos.Value
                sql.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = FechaSistema
                sql.Parameters.Add("@SeDeprecia", SqlDbType.Bit).Value = Me.depreciarCheckBoxX1.Checked
                sql.Parameters.Add("@ValorResidual", SqlDbType.Decimal, 18.4).Value = Me.valorresidualDoubleInput1.Value
                sql.Parameters.Add("@IdClase", SqlDbType.Char, 2).Value = Me.clasificacionComboBoxEx1.SelectedValue
                sql.Parameters.Add("@Documento", SqlDbType.VarChar, 40).Value = documentoTextBoxX1.Text
                sql.Parameters.Add("@Origen", SqlDbType.Char, 100).Value = origenTextBoxX1.Text
                sql.Parameters.Add("@Nota", SqlDbType.VarChar, 250).Value = notaTextBoxX2.Text
                sql.Parameters.Add("@Peso", SqlDbType.Decimal, 12.2).Value = pesoDoubleInput1.Value
                sql.Parameters.Add("@MoverA", SqlDbType.NVarChar, 20).Value = moverACbx.Text

                Dim hay_error As Boolean, mensaje As String
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    hay_error = leer(0)
                    mensaje = leer(1)
                End While
                con.Close()
                If hay_error = True Then
                    MessageBox.Show(mensaje, "Error al grabar registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ActualizarLote()
                    Me.Limpiar()
                    cargarClasesHatoReprod()
                End If

                'sql = New SqlCommand("insert into REG_ABUELAS values('" & Me.txtCodCerda.Text & "','" & Me.txtNomb_o_Num.Text & "','" & txtFecha.Text & "','" & Val(Me.txtPadre.Text) & "','" & Val(Me.cbxMadre_Madres.Text) & "','" & Me.cbxGenetica.Text & "','" & Val(Me.txtCosto.Text) & "','" & Val(Me.NumPartos.Value) & "','" & FechaSistema & "','5','V', '" & Me.depreciarCheckBoxX1.Checked & "','" & Me.valorresidualDoubleInput1.Value & "','" & Me.clasificacionComboBoxEx1.SelectedValue & "','" & Me.documentoTextBoxX1.Text & "','" & Me.origenTextBoxX1.Text & "'," & Me.pesoDoubleInput1.Text & ",'" & Me.notaTextBoxX2.Text & "')", con)
                'con.Open()
                'sql.ExecuteNonQuery()
                'con.Close()
                'Dim ID_Depreciacion As Integer = 0
                'sql = New SqlCommand("select max(ID_Depreciacion) from  Depreciacion_x_Cerda", con)
                'con.Open()
                'leer = sql.ExecuteReader
                'While leer.Read
                '    If leer.IsDBNull(0) = True Then
                '        ID_Depreciacion = 1
                '    Else
                '        ID_Depreciacion = leer(0) + 1
                '    End If
                'End While
                'con.Close()
                'sql = New SqlCommand("insert into Depreciacion_x_Cerda values('" & ID_Depreciacion & "','" & Me.txtCodCerda.Text & "','" & Me.txtCosto.Text & "','" & Me.NumPartos.Text & "','" & txtFecha.Text & "')", con)
                'con.Open()
                'sql.ExecuteNonQuery()
                'con.Close()
                'RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Ra.")
                'ActualizarLote()
                'Me.Limpiar()
                'cargarClasesHatoReprod()
            Catch ex1 As System.Data.SqlClient.SqlException
                MessageBoxEx.Show(CadenaError & ex1.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub
    Sub cargarClasesHatoReprod()
        Try
            Me.clasificacionComboBoxEx1.DataSource = claseHatoReprodAdapter.GetData
            Me.clasificacionComboBoxEx1.DisplayMember = "Descripcion"
            Me.clasificacionComboBoxEx1.ValueMember = "IdClase"
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error en cargar Clases Hatos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
    
 

    Private Sub frmReg_Abuelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarClasesHatoReprod()
    End Sub
End Class