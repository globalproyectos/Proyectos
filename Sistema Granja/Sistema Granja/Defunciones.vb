Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Public Class Defunciones
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim odtsGranja As New DtsBDGRANJA
    Dim porc As Integer
    Dim cerdos_registrad, total_cerd, cerdos_defusos As Integer
    Dim verif As Boolean = False
    Dim prodEn As String = ", el error se produjo el el BLOQUE D-"
    Dim SeleccionoLote As Boolean = False
    Dim MotivosDefuncionTableAdapter As New DtsBDGRANJATableAdapters.MotivosDefuncionTableAdapter
    Sub Lotes()
        'BLOQUE D-1
        Try
            Me.txtLote.Items.Clear()
            sql = New SqlCommand("select Lote_No, Fecha_Creacion FROM LOTES where Estado='A' OR Estado='F'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.txtLote.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & ", el error se produjo en el BLOQUE D-1", "Error Recuperando Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub cargarmotivosdefuncion()
        Try
            motivosdefuncionComboBoxEx1.DataSource = MotivosDefuncionTableAdapter.GetData()
            motivosdefuncionComboBoxEx1.DisplayMember = "Descripcion"
            motivosdefuncionComboBoxEx1.ValueMember = "Teclear"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Defunciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NoDefuncionAuto()
        cargarmotivosdefuncion()
        Me.MostrarLotesSegunTipo()
        Me.txtFechaDefuncion.Text = FechaSistema
    End Sub
    Sub MostrarLotesSegunTipo()
        Try
            Me.txtLote.Items.Clear()
            If Me.chbxEngorde.CheckState = CheckState.Checked Then
                Me.txtNoDefunciones.Enabled = True
                Me.txtLote.Items.Clear()
                sql = New SqlCommand("select Lote_No, Fecha_Creacion FROM LOTES where IdEtapa_Cerdas='E' AND Estado<>'T'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.txtLote.Items.Add(leer(0))
                End While
                con.Close()
                Me.btnGuardar.Text = "Guardar Defuncion Engordes"
                Me.btnGuardar.Image = New System.Drawing.Bitmap(My.Resources.filesave)
            ElseIf Me.chbxAbuelas.CheckState = CheckState.Checked Or Me.chbxMadres.CheckState = CheckState.Checked Then
                sql = New SqlCommand("select Lote_No, Fecha_Creacion FROM LOTES where IdEtapa_Cerdas<>'E' and IdEtapa_Cerdas<>'R' AND IdEtapa_Cerdas<>'VR'  AND Estado<>'T'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.txtLote.Items.Add(leer(0))
                End While
                con.Close()
                Me.txtNoDefunciones.Enabled = False
                Me.btnGuardar.Text = "Seleccionar Cerdo/as"
                Me.btnGuardar.Image = New System.Drawing.Bitmap(My.Resources.agt_forward)
            ElseIf Me.chbxReemplazos.CheckState = CheckState.Checked Then
                sql = New SqlCommand("select Lote_No, Fecha_Creacion FROM LOTES where IdEtapa_Cerdas='R' AND Estado<>'T'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.txtLote.Items.Add(leer(0))
                End While
                con.Close()
                Me.txtNoDefunciones.Enabled = False
                Me.btnGuardar.Text = "Seleccionar Cerdo/as"
                Me.btnGuardar.Image = New System.Drawing.Bitmap(My.Resources.agt_forward)
            ElseIf Me.chbxVerracos.CheckState = CheckState.Checked Then
                sql = New SqlCommand("select Lote_No, Fecha_Creacion FROM LOTES where IdEtapa_Cerdas='VR' AND Estado<>'T'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.txtLote.Items.Add(leer(0))
                End While
                con.Close()
                Me.txtNoDefunciones.Enabled = False
                Me.btnGuardar.Text = "Seleccionar Cerdo/as"
                Me.btnGuardar.Image = New System.Drawing.Bitmap(My.Resources.agt_forward)
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error Mostrar Lotes x tipo defuncion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub cerdos_registrados()
        'BLOQUE D-2
        Try
            sql = New SqlCommand("select Cerdos_Nacidos from LOTES where Lote_No= '" & Me.txtLote.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cerdos_registrad = leer(0)
                Me.lbCerdosRegistrados.Text = Me.cerdos_registrad
                Me.lbTotalRegistrados.Text = Me.lbCerdosRegistrados.Text
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 2, "Error cargar cerdos registrados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub total_cerdos_menos_defusos()
        Try
            'BLOQUE D-3
            Dim CerdosActuales As Integer
            sql = New SqlCommand("select SUM(No_Defunciones) FROM DEFUNCIONES where Lote_No='" & Me.txtLote.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Me.cerdos_defusos = 0
                Else
                    Me.cerdos_defusos = leer(0)
                    Me.lbDefundidos.Text = Me.cerdos_defusos
                End If
            End While
            con.Close()
            sql = New SqlCommand("select Total_Cerdos FROM Total_Cerdos_Lote WHERE Lote_No='" & Me.txtLote.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.lbTotal.Text = leer(0)
                CerdosActuales = leer(0)
            End While
            con.Close()
            Me.ProgressBarX1.Maximum = Me.cerdos_registrad
            Me.ProgressBarX1.Minimum = 0
            Me.ProgressBarX1.Value = CerdosActuales
            Me.ProgressBarX1.Text = "Cerdos Actuales: " & CerdosActuales
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 3, "Error cargar Total Cerdos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub txtLote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub txtCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Sub NoDefuncionAuto()
        Try
            Correlativo_Auto("select max(DefuncionNo) from DEFUNCIONES", Me.txtDefuncionNo)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando No Defuncion Auto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub guardar_Defuncion()
        Try
            'BLOQUE D-4
            'Dim CerdosActuales As Integer
            'Dim IdDefuncion As Integer
            RegistrarMovimientoLote(Me.txtLote.Text, 0, Me.txtNoDefunciones.Text, 0, 0, 0, 0, FechaSistema, "Df." & Me.txtDefuncionNo.Text)

            'sql = New SqlCommand("select MAX(IdDefuncion) FROM DEFUNCIONES", con)
            'con.Open()
            'leer = sql.ExecuteReader
            'While leer.Read
            '    If leer.IsDBNull(0) = True Then
            '        IdDefuncion = 1
            '    Else
            '        IdDefuncion = leer(0) + 1
            '    End If
            'End While
            'con.Close()
            sql = New SqlCommand("insert into DEFUNCIONES([Lote_No], [No_Defunciones], [Motivo], [Fecha_Defuncion], [DefuncionNo], [Codigo_Cerdo], [Motivo2],[Peso]) values('" & Me.txtLote.Text & "','" & Me.txtNoDefunciones.Text & "','" & If(Me.motivosdefuncionComboBoxEx1.SelectedValue.ToString = "True", "(" & Trim(Me.motivosdefuncionComboBoxEx1.Text) & ")" & Me.txtMotivo.Text, Me.txtMotivo.Text) & "','" & Me.txtFechaDefuncion.Text & "','" & Me.txtDefuncionNo.Text & "','N/A', '" & If(Me.motivosdefuncionComboBoxEx1.SelectedValue.ToString = "True", "(" & Trim(Me.motivosdefuncionComboBoxEx1.Text) & ")" & Me.txtMotivo.Text, Me.txtMotivo.Text) & "', " & Me.pesoDoubleInput1.Value & ")", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            'sql = New SqlCommand("Select Total_Cerdos from Total_Cerdos_Lote WHERE Lote_No='" & Me.txtLote.Text & "'", con)
            'con.Open()
            'leer = sql.ExecuteReader
            'While leer.Read
            '    CerdosActuales = leer(0)
            'End While
            'con.Close()
            'sql = New SqlCommand("Update Total_Cerdos_Lote SET Total_Cerdos='" & CerdosActuales - Val(Me.txtNoDefunciones.Text) & "', Fecha_Ultima_Modificación='" & FechaSistema & "' WHERE Lote_No='" & Me.txtLote.Text & "'", con)
            'con.Open()
            'sql.ExecuteNonQuery()
            'con.Close()
            ActualizarLote()
            Me.txtFechaCreacion.Text = ""
            Me.txtNoDefunciones.Clear()
            Me.txtLote.Text = ""
            Me.txtMotivo.Text = ""
            Me.pesoDoubleInput1.Value = 0
        Catch ex1 As System.Data.SqlClient.SqlException
            MessageBoxEx.Show(ex1.Message & prodEn & 4, "Error al intentar guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 4, "Error al guardar defuncion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub txtGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        NoDefuncionAuto()
        If Me.chbxEngorde.CheckState = CheckState.Checked Then
            Try
                'BLOQUE D-5
                If Me.txtFechaDefuncion.Text = "" Then
                    MessageBoxEx.Show("No ha ingresado la fecha de defuncion, debe ingresar la fecha", "Guardar Defuncion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtFechaDefuncion.Focus()
                ElseIf Me.txtMotivo.Text = "" Then
                    MessageBoxEx.Show("No ha ingresado el motivo de la defuncion, debe ingresarlo", "Guardar Defuncion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtMotivo.Focus()
                ElseIf ValidarFechas(Me.txtFechaDefuncion.Text) = False Then
                    Me.txtFechaDefuncion.Select()
                    Me.txtFechaDefuncion.Focus()
                ElseIf Me.txtNoDefunciones.Text = "0" Or Me.txtNoDefunciones.Text = "" Then
                    MessageBoxEx.Show("No ha ingresado el numero de cerdos", "Guardar Defuncion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtNoDefunciones.Focus()
                ElseIf Me.SeleccionoLote = False Then
                    MessageBoxEx.Show("No ha seleccionado el lote", "Guardar Defuncion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtLote.Focus()
                Else
                    Me.guardar_Defuncion()
                    ActualizarLote()
                    SeleccionoLote = False
                    Me.lbCerdosRegistrados.Text = 0
                    Me.lbDefundidos.Text = 0
                    Me.lbTotal.Text = 0
                    NoDefuncionAuto()
                    Me.lbTotalRegistrados.Text = "?"
                    Me.ProgressBarX1.Value = 0
                End If
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 5, "Error al intentar guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf Me.chbxAbuelas.CheckState = CheckState.Checked Then
            If Me.SeleccionoLote = False Then
                MessageBoxEx.Show("Para continuar con la defuncion es necesario que seleccione el lote", "Lote No", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtLote.Focus()
            Else
                With My.Forms.dlgDefunciones_Madres_Abuelas
                    .LoteNo = Me.txtLote.Text
                    .DefuncioNo = Me.txtDefuncionNo.Text
                    .FechaDf = Me.txtFechaDefuncion.Text
                    .Abuela_o_Madre = "Abuelas"
                    .ShowDialog()
                End With
            End If
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            If Me.SeleccionoLote = False Then
                MessageBoxEx.Show("Para continuar con la defuncion es necesario que seleccione el lote", "Lote No", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtLote.Focus()
            Else
                With My.Forms.dlgDefunciones_Madres_Abuelas
                    .LoteNo = Me.txtLote.Text
                    .DefuncioNo = Me.txtDefuncionNo.Text
                    .FechaDf = Me.txtFechaDefuncion.Text

                    .Abuela_o_Madre = "Madres"
                    .ShowDialog()
                End With
            End If
        ElseIf Me.chbxVerracos.CheckState = CheckState.Checked Then
            If Me.SeleccionoLote = False Then
                MessageBoxEx.Show("Para continuar con la defuncion es necesario que seleccione el lote", "Lote No", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtLote.Focus()
            Else
                With My.Forms.dlgRegistro_defuncion_verracos
                    .LoteNo = Me.txtLote.Text
                    .DefuncioNo = Me.txtDefuncionNo.Text
                    .FechaDf = Me.txtFechaDefuncion.Text
                    .ShowDialog()
                End With
            End If
        ElseIf Me.chbxReemplazos.CheckState = CheckState.Checked Then
            If Me.SeleccionoLote = False Then
                MessageBoxEx.Show("Para continuar con la defuncion es necesario que seleccione el lote", "Lote No", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txtLote.Focus()
            Else
                With My.Forms.dlgRegistroDefunciones_Reemplazos
                    .LoteNo = Me.txtLote.Text
                    .DefuncioNo = Me.txtDefuncionNo.Text
                    .FechaDf = Me.txtFechaDefuncion.Text
                    .ShowDialog()
                End With
            End If
        End If
        
    End Sub
    Private Sub txtNoDefunciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoDefunciones.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNoDefunciones_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoDefunciones.TextChanged
        If Me.chbxEngorde.CheckState = CheckState.Checked Then
            If Me.txtNoDefunciones.Text <> "" Then
                Me.btnGuardar.Enabled = True
            Else
                Me.btnGuardar.Enabled = False
            End If
        Else
            Me.btnGuardar.Enabled = True
        End If


    End Sub

    Private Sub txtLote_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLote.SelectedIndexChanged
        SeleccionoLote = True 'BLOQUE D-6
        Me.lbCerdosRegistrados.Text = "0"
        Me.lbDefundidos.Text = "0"
        Me.lbTotal.Text = "0"
        Me.lbTotalRegistrados.Text = "0"

        Me.cerdos_registrados()
        Me.total_cerdos_menos_defusos()
        Try
            sql = New SqlCommand("select Fecha_Creacion FROM LOTES WHERE Lote_No='" & Me.txtLote.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.txtFechaCreacion.Text = leer(0)
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & prodEn & 6, "Error recuperando fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub

    Private Sub chbxEngorde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxEngorde.CheckedChanged
        If Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
            Me.MostrarLotesSegunTipo()
            Me.motivosdefuncionComboBoxEx1.Enabled = True
        ElseIf Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxReemplazos.CheckState = CheckState.Checked Then
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxVerracos.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxCerditosgestacion.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub chbxAbuelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxAbuelas.CheckedChanged
        If Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
            Me.MostrarLotesSegunTipo()
            Me.motivosdefuncionComboBoxEx1.Enabled = False
        ElseIf Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxReemplazos.CheckState = CheckState.Checked Then
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxVerracos.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
        ElseIf Me.chbxCerditosgestacion.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub chbxMadres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxMadres.CheckedChanged
        If Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
            Me.MostrarLotesSegunTipo()
            Me.motivosdefuncionComboBoxEx1.Enabled = False
        ElseIf Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxReemplazos.CheckState = CheckState.Checked Then
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxVerracos.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxCerditosgestacion.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub chbxReemplazos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxReemplazos.CheckedChanged
        If Me.chbxReemplazos.CheckState = CheckState.Checked Then
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
            Me.MostrarLotesSegunTipo()
            Me.motivosdefuncionComboBoxEx1.Enabled = False
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxVerracos.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxCerditosgestacion.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub motivosdefuncionComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles motivosdefuncionComboBoxEx1.SelectedIndexChanged
        Me.txtMotivo.Text = ""

        If Me.motivosdefuncionComboBoxEx1.SelectedValue.ToString = "True" Then
            Me.txtMotivo.Enabled = True
            Me.txtMotivo.Focus()
        Else
            Me.txtMotivo.Enabled = False
            Me.txtMotivo.Text = Trim(Me.motivosdefuncionComboBoxEx1.Text)
        End If
    End Sub

    Private Sub chbxVerracos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxVerracos.CheckedChanged
        If Me.chbxVerracos.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
            Me.MostrarLotesSegunTipo()
            Me.motivosdefuncionComboBoxEx1.Enabled = False
        ElseIf Me.chbxReemplazos.CheckState = CheckState.Checked Then
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxCerditosgestacion.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked

        End If
    End Sub

    Private Sub chbxCerditosgestacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxCerditosgestacion.CheckedChanged
        If Me.chbxCerditosgestacion.CheckState = CheckState.Checked Then
            With My.Forms.frmDefunciones_Antes_de_Destetar
                .ShowDialog()
            End With
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
        ElseIf Me.chbxVerracos.CheckState = CheckState.Checked Then
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
            Me.MostrarLotesSegunTipo()
            Me.motivosdefuncionComboBoxEx1.Enabled = False
        ElseIf Me.chbxReemplazos.CheckState = CheckState.Checked Then
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxEngorde.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxEngorde.CheckState = CheckState.Checked Then
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
            Me.chbxMadres.CheckState = CheckState.Unchecked
            Me.chbxReemplazos.CheckState = CheckState.Unchecked
            Me.chbxVerracos.CheckState = CheckState.Unchecked
            Me.chbxCerditosgestacion.CheckState = CheckState.Unchecked
        End If
    End Sub
End Class