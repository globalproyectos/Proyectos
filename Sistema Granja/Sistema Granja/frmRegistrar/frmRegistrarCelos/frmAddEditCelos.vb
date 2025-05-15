Public Class frmAddEditCelos
    Public accion As String
    Public idCelo As Integer
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Sub cargarClasificaciones()
        Me.clasificacionComboBox1.DataSource = ClaseCerdas.listarClasificaciones()
        Me.clasificacionComboBox1.ValueMember = "IdClase"
        Me.clasificacionComboBox1.DisplayMember = "Descripcion"
    End Sub
    Private Sub frmAddEditCelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If accion = "crear" Then
            Me.LabelX1.Text = "Crear registro de celo"
            limpiarCampos()
            Me.ordenIntegerInput1.Enabled = False
            Me.ordenIntegerInput1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Info
            Me.ordenIntegerInput1.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.Info
        ElseIf accion = "editar" Then
            Me.LabelX1.Text = "Editar registro de celo"
            cargarEditar()
        End If
        Me.fechaDateTimeInput1.Text = FechaSistema
        Me.eventoTextBoxX4.Text = "Registro de Celo"
        Me.WarningBox1.Hide()

        cargarClasificaciones()
    End Sub
    Sub cargarEditar()
        Dim Reg_Celo As New Registo_Celo
        Reg_Celo = ClaseCelos.consultarPorId(idCelo)
        With Reg_Celo
            Me.idCeloTextBoxX1.Text = .ID_Celo
            Me.idCerdaTextBoxX2.Text = .Codigo_Cerda
            Me.tipoCerdaTextBoxX3.Text = .Tipo_Cerda
            Me.eventoTextBoxX4.Text = .Evento
            Me.fechaDateTimeInput1.Text = .Fecha
            Me.horaLinkLabel1.Text = .Hora.ToString
            Me.pesoDoubleInput1.Value = .Peso
            Me.observacionesTextBoxX1.Text = .Observaciones
            Me.ordenIntegerInput1.Value = .Orden
            Me.edadDiasDoubleInput1.Value = .EdadDias
            Me.clasificacionComboBox1.SelectedValue = .IdClase
            Me.etapaTextBoxX1.Text = .Etapa
            Me.ordenIntegerInput1.Enabled = True
            Me.ordenIntegerInput1.BackgroundStyle.BackColor = Nothing
            Me.ordenIntegerInput1.BackgroundStyle.BackColor2 = Nothing
        End With
    End Sub
    Private Sub horaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles horaLinkLabel1.LinkClicked
        With frmSeleccionHora
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
    Private Sub idCerdaTextBoxX2_KeyDown(sender As Object, e As KeyEventArgs) Handles idCerdaTextBoxX2.KeyDown
        If e.KeyCode = Keys.F5 Then
            With frmBuscarReemplazos
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        End If
    End Sub
    Sub limpiarCampos()
        Me.idCeloTextBoxX1.Text = ""
        Me.idCerdaTextBoxX2.Text = ""
        Me.tipoCerdaTextBoxX3.Text = ""
        Me.horaLinkLabel1.Text = "00:00:00"
        Me.fechaDateTimeInput1.Text = FechaSistema
        Me.observacionesTextBoxX1.Text = ""
        Me.etapaTextBoxX1.Text = ""
        Me.pesoDoubleInput1.Value = 0
        Me.ordenIntegerInput1.Value = 0
        Me.idCerdaTextBoxX2.Focus()
        Me.edadDiasDoubleInput1.Value = 0
        cargarClasificaciones()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If Not ClaseCerdas.getExiste(Me.idCerdaTextBoxX2.Text) Then
            Me.WarningBox1.Text = "<font color='red'><b>Campo requerido: </b> Debe ingresar un ID de cerda válido</font>"
            Me.WarningBox1.Show()
            Me.idCerdaTextBoxX2.Focus()
        Else
            Me.WarningBox1.Hide()
            If accion = "crear" Then
                Dim respuesta As String = ClaseCelos.insertar(New Registo_Celo With {
                                                          .Codigo_Cerda = Me.idCerdaTextBoxX2.Text,
                                                          .Tipo_Cerda = Me.tipoCerdaTextBoxX3.Text,
                                                          .Evento = Me.eventoTextBoxX4.Text,
                                                          .Fecha = CDate(Me.fechaDateTimeInput1.Text),
                                                          .Hora = TimeSpan.Parse(Me.horaLinkLabel1.Text),
                                                          .Fecha_Hora_Creacion = Today & " " & TimeOfDay,
                                                          .Orden = ClaseCelos.getNextOrden(Me.idCerdaTextBoxX2.Text),
                                                          .Peso = Me.pesoDoubleInput1.Value,
                                                          .Observaciones = Me.observacionesTextBoxX1.Text,
                                                          .Etapa = Me.etapaTextBoxX1.Text,
                                                          .EdadDias = Me.edadDiasDoubleInput1.Value,
                                                          .IdClase = Me.clasificacionComboBox1.SelectedValue})
                If respuesta.Contains("Error: ") Then
                    Me.WarningBox1.Text = "<font color='red'><b>Error: </b> " & respuesta & "</font>"
                    Me.WarningBox1.Show()
                Else
                    limpiarCampos()
                    frmRegistrarCelos.cargarListado()
                    Me.WarningBox1.Text = "<font color='green'><b>Exito: </b> Registro creado exitosamente</font>"
                    Me.WarningBox1.Show()
                End If
            ElseIf accion = "editar" Then
                Dim respuesta As String = ClaseCelos.editar(Me.idCeloTextBoxX1.Text, New Registo_Celo With {
                                                          .Codigo_Cerda = Me.idCerdaTextBoxX2.Text,
                                                          .Tipo_Cerda = Me.tipoCerdaTextBoxX3.Text,
                                                          .Evento = Me.eventoTextBoxX4.Text,
                                                          .Fecha = CDate(Me.fechaDateTimeInput1.Text),
                                                          .Hora = TimeSpan.Parse(Me.horaLinkLabel1.Text),
                                                          .Fecha_Hora_Creacion = Today & " " & TimeOfDay,
                                                          .Orden = CInt(Me.ordenIntegerInput1.Value),
                                                          .Peso = Me.pesoDoubleInput1.Value,
                                                          .Observaciones = Me.observacionesTextBoxX1.Text,
                                                          .Etapa = Me.etapaTextBoxX1.Text,
                                                           .EdadDias = Me.edadDiasDoubleInput1.Value,
                                                          .IdClase = Me.clasificacionComboBox1.SelectedValue})
                If respuesta.Contains("Error: ") Then
                    Me.WarningBox1.Text = "<font color='red'><b>Error: </b> " & respuesta & "</font>"
                    Me.WarningBox1.Show()
                Else

                    frmRegistrarCelos.cargarListado()
                    Me.WarningBox1.Text = "<font color='green'><b>Exito: </b> Registro modificado exitosamente</font>"
                    Me.WarningBox1.Show()
                End If
            End If

        End If
    End Sub
    Private Sub frmAddEditCelos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmRegistrarCelos.mantto = False
    End Sub
    Private Sub idCerdaTextBoxX2_LostFocus(sender As Object, e As EventArgs) Handles idCerdaTextBoxX2.LostFocus
        If Not String.IsNullOrEmpty(Me.idCerdaTextBoxX2.Text) Then

            If ClaseCerdas.getExiste(Me.idCerdaTextBoxX2.Text) = True Then
                    Dim v_consulta_remplazo As New v_consulta_reemplazos
                    v_consulta_remplazo = ClaseCerdas.getInfoCerda(Me.idCerdaTextBoxX2.Text)
                    With v_consulta_remplazo
                        Me.clasificacionComboBox1.SelectedValue = .IdClase
                    Me.edadDiasDoubleInput1.Value = .edaddias
                    Me.tipoCerdaTextBoxX3.Text = .Tipo
                End With
                End If


        End If
    End Sub
End Class