Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmPesosDestetes_Subidas
    Inherits DevComponents.DotNetBar.Office2007Form

    Dim odtsPesos As New dtsPesosCerdosProcesos
    Dim PesosDestetes_Subidas_EncabezadoAdapter As New dtsPesosCerdosProcesosTableAdapters.PesosDestetes_Subidas_EncabezadoTableAdapter
    Dim PesosDestetes_Subidas_CerdasAdapter As New dtsPesosCerdosProcesosTableAdapters.Proc_CerdasPesos_Dest_Subidas_ListarTableAdapter
    Dim PesosDestetes_Subidas_PesosAdapter As New dtsPesosCerdosProcesosTableAdapters.Proc_CerdasPesos_Dest_Subidas_pesos_ListarTableAdapter
    Dim lotesAdapter As New dtsPesosCerdosProcesosTableAdapters.LotesTableAdapter
    Dim vListaCerdasActivasAdapter As New dtsPesosCerdosProcesosTableAdapters.vListaCerdasActivasTableAdapter
    Dim loteEngordeAdapter As New dtsPesosCerdosProcesosTableAdapters.LotesEngordesTableAdapter

    Dim bsPesosDestetes_Subidas_Encabezado As New BindingSource
    Dim bsPesosDestetes_Subidas_Cerdas As New BindingSource
    Dim bsPesosDestetes_Subidas_Pesos As New BindingSource
    Private Sub FrmPesosDestetes_Subidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsPesosCerdosProcesos.vListaCerdasActivas' Puede moverla o quitarla según sea necesario.
        Me.VListaCerdasActivasTableAdapter.Fill(Me.DtsPesosCerdosProcesos.vListaCerdasActivas, Me.procesoComboBoxEx1.Text)
        'TODO: esta línea de código carga datos en la tabla 'DtsPesosCerdosProcesos.LotesGestacion' Puede moverla o quitarla según sea necesario.
        Me.LotesGestacionTableAdapter.Fill(Me.DtsPesosCerdosProcesos.LotesGestacion, Me.procesoComboBoxEx1.Text)
        'TODO: esta línea de código carga datos en la tabla 'DtsPesosCerdosProcesos.Sexo' Puede moverla o quitarla según sea necesario.
        Me.SexoTableAdapter.Fill(Me.DtsPesosCerdosProcesos.Sexo)
        CargarEncabezado(Me.procesoComboBoxEx1.Text)




    End Sub

    'Sub porcentajeEncabezadoGen()
    '    Try
    '        For y As Integer = 0 To Me.encabezadoDataGridViewX1.RowCount - 1
    '            Dim totalgeneralcerdos As Integer, totalgenerarlpesos As Integer
    '            totalgeneralcerdos = 0

    '            totalgeneralcerdos += PesosDestetes_Subidas_CerdasAdapter.GetTotalGenCerdos(Me.encabezadoDataGridViewX1.Rows(y).Cells("e_LoteGestacion").Value, Me.procesoComboBoxEx1.Text)

    '            totalgenerarlpesos = PesosDestetes_Subidas_PesosAdapter.GetTotalCerdosPesoMayorCero(Me.encabezadoDataGridViewX1.Rows(y).Cells("e_LoteGestacion").Value, Me.procesoComboBoxEx1.Text)

    '            If totalgeneralcerdos > 0 Then
    '                Me.encabezadoDataGridViewX1.Rows(y).Cells("e_Porcentaje").Value = CInt((totalgenerarlpesos / totalgeneralcerdos) * 100) & "%"
    '            Else
    '                Me.encabezadoDataGridViewX1.Rows(y).Cells("e_Porcentaje").Value = "0%"
    '            End If

    '        Next
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Sub cargarLotes()
        If Me.procesoComboBoxEx1.Text = "Destete" Then
            Me.e_LoteGestacion.DataSource = LotesGestacionTableAdapter.GetData(Me.procesoComboBoxEx1.Text)
            Me.e_LoteGestacion.DisplayMember = "Lote_No"
            Me.e_LoteGestacion.ValueMember = "Lote_No"
        ElseIf Me.procesoComboBoxEx1.Text = "Subida Eng." Or Me.procesoComboBoxEx1.Text = "Peso 49dias" Then

            Me.e_LoteGestacion.DataSource = loteEngordeAdapter.GetData(Me.procesoComboBoxEx1.Text)
            Me.e_LoteGestacion.DisplayMember = "Lote_No"
            Me.e_LoteGestacion.ValueMember = "Lote_No"
        End If
    End Sub
    Sub CargarEncabezado(ByVal proceso As String)
        Try
            Me.encabezadoDataGridViewX1.AutoGenerateColumns = False
            PesosDestetes_Subidas_EncabezadoAdapter.Fill(odtsPesos.PesosDestetes_Subidas_Encabezado, proceso, Me.LoteFiltroTextBoxX1.Text)
            bsPesosDestetes_Subidas_Encabezado.DataSource = odtsPesos.PesosDestetes_Subidas_Encabezado
            Me.encabezadoDataGridViewX1.AutoGenerateColumns = False
            Me.encabezadoDataGridViewX1.DataSource = bsPesosDestetes_Subidas_Encabezado

            If encabezadoDataGridViewX1.Rows.Count = 0 Then
                detalleCerdasDataGridViewX2.DataSource = Nothing
                PesosCerditosDataGridViewX3.DataSource = Nothing
            End If

            'porcentajeEncabezadoGen()


            cargarLotes()


        Catch ex As Exception
            MessageBoxEx.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ProcesoComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles procesoComboBoxEx1.SelectedIndexChanged
        Me.errorEncabezadoLabelX3.Visible = False
        Me.errorDetalleCerdasLabelX3.Visible = False
        CargarEncabezado(Me.procesoComboBoxEx1.Text)
        Me.modoSwitchButton1.Value = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.detalleCerdasDataGridViewX2.Rows.Count > 0 Then
            Me.encabezadoDataGridViewX1.Rows(Me.encabezadoDataGridViewX1.CurrentCell.RowIndex).ReadOnly = True
        Else
            Me.encabezadoDataGridViewX1.Rows(Me.encabezadoDataGridViewX1.CurrentCell.RowIndex).ReadOnly = False
        End If
        Try
            If modoSwitchButton1.Value = True Then


Nuevo:
                Me.encabezadoDataGridViewX1.Rows(Me.encabezadoDataGridViewX1.CurrentCell.RowIndex).ReadOnly = False
                cargarLotes()
                odtsPesos.PesosDestetes_Subidas_Encabezado.ProcesoColumn.DefaultValue = Me.procesoComboBoxEx1.Text
                odtsPesos.PesosDestetes_Subidas_Encabezado.FechaSistemaColumn.DefaultValue = FechaSistema
                odtsPesos.PesosDestetes_Subidas_Encabezado.FechaHoraRegistroColumn.DefaultValue = Today & " " & TimeOfDay
                odtsPesos.PesosDestetes_Subidas_Encabezado.TotalPesoColumn.DefaultValue = 0
                odtsPesos.PesosDestetes_Subidas_Encabezado.TotalCerdasColumn.DefaultValue = 0
                odtsPesos.PesosDestetes_Subidas_Encabezado.TotalCerdosColumn.DefaultValue = 0
                odtsPesos.PesosDestetes_Subidas_Encabezado.UsuarioCreadorColumn.DefaultValue = UsuarioActual

                bsPesosDestetes_Subidas_Encabezado.AddNew()

                ListarCerdas(If(IsDBNull(Me.encabezadoDataGridViewX1.CurrentRow.Cells("e_LoteGestacion").Value), "", Me.encabezadoDataGridViewX1.CurrentRow.Cells("e_LoteGestacion").Value), Me.procesoComboBoxEx1.Text)

            Else
                Dim resp As MsgBoxResult = MessageBoxEx.Show("No puede adicionar registros en modo consulta, desea establecer el modo MODIFICAR?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    modoSwitchButton1.Value = True
                    GoTo Nuevo
                End If
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message.ToString, "Error añadir", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Function hayerrores() As Integer
        Dim errores As Integer = 0
        For i As Integer = 0 To Me.encabezadoDataGridViewX1.RowCount - 1
            If Me.encabezadoDataGridViewX1.Rows(i).DefaultCellStyle.BackColor = Color.Red Then
                errores += 1
            End If
        Next
        For y As Integer = 0 To Me.detalleCerdasDataGridViewX2.RowCount - 1
            If Me.detalleCerdasDataGridViewX2.Rows(y).DefaultCellStyle.BackColor = Color.Red Then
                errores += 1
            End If
        Next

        Return errores
    End Function
    Sub GrabarEncabezado()
        Try
            If modoSwitchButton1.Value = True And Not odtsPesos.HasErrors() Then

                If hayerrores() = 0 Then
                    bsPesosDestetes_Subidas_Encabezado.EndEdit()
                    PesosDestetes_Subidas_EncabezadoAdapter.Update(odtsPesos.PesosDestetes_Subidas_Encabezado)
                End If
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message.ToString, "Error grabar encabezado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub encabezadoDataGridViewX1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles encabezadoDataGridViewX1.RowEnter
        If Not IsDBNull(Me.encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteGestacion").Value) Then
            GrabarEncabezado()
            ListarCerdas(Me.encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteGestacion").Value, Me.procesoComboBoxEx1.Text)

        End If

    End Sub
    Private Sub encabezadoDataGridViewX1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles encabezadoDataGridViewX1.DataError


        If e.Exception.ToString.Contains("NoNullAllowedEx") Then
            MessageBoxEx.Show("Error de entrada de datos, vuelva a intentarlo, recuerde no dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Exception.ToString.Contains("UniqueConstraint") Then
            MessageBoxEx.Show("No puede insertar un valor duplicado, ya esta presente el valor " & Trim(encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteGestacion").Value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bsPesosDestetes_Subidas_Encabezado.RemoveCurrent()

            'Else
            '    MessageBoxEx.Show(e.Exception.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub
    Sub validarSiHayPesosBloquearCampo()
        'For i As Integer = 0 To Me.detalleCerdasDataGridViewX2.RowCount - 1
        '    If PesosDestetes_Subidas_CerdasAdapter.GetNumeroCerditosPorCerdaReferencia(bsPesosDestetes_Subidas_Cerdas.Current("LoteGestacion"), Me.procesoComboBoxEx1.Text, Me.detalleCerdasDataGridViewX2.Rows(i).Cells("c_CodigoCerda").Value) > 0 Then
        '        Me.detalleCerdasDataGridViewX2.Rows(i).Cells("c_TotalCerdos").ReadOnly = True
        '    Else
        '        Me.detalleCerdasDataGridViewX2.Rows(i).Cells("c_TotalCerdos").ReadOnly = False
        '    End If
        'Next
    End Sub
    Sub cargarCodigosCerdas()
        If Me.procesoComboBoxEx1.Text = "Destete" Then
            Me.c_CodigoCerda.DataSource = vListaCerdasActivasAdapter.GetData(Me.procesoComboBoxEx1.Text)
            Me.c_CodigoCerda.ValueMember = "CodigoCerda"
            Me.c_CodigoCerda.DisplayMember = "CodigoCerda"
        Else
            Me.c_CodigoCerda.DataSource = Nothing
        End If
    End Sub
    Sub ListarCerdas(ByVal LoteGestacion As String, ByVal Proceso As String)
        Try
            PesosDestetes_Subidas_CerdasAdapter.Fill(odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar, LoteGestacion, Proceso)
            bsPesosDestetes_Subidas_Cerdas.DataSource = odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar
            Me.detalleCerdasDataGridViewX2.AutoGenerateColumns = False
            Me.detalleCerdasDataGridViewX2.DataSource = bsPesosDestetes_Subidas_Cerdas


            cargarCodigosCerdas()
            validarSiHayPesosBloquearCampo()

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message.ToString, "Error Listar Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            If modoSwitchButton1.Value = True Then
Nuevo:
                If encabezadoDataGridViewX1.CurrentRow.DefaultCellStyle.BackColor <> Color.Red Then
                    If If(IsDBNull(Me.encabezadoDataGridViewX1.CurrentRow.Cells("e_LoteGestacion").Value), "", Me.encabezadoDataGridViewX1.CurrentRow.Cells("e_LoteGestacion").Value) <> "" Then
                        GrabarEncabezado()
                        cargarCodigosCerdas()
                        odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.LoteGestacionColumn.DefaultValue = bsPesosDestetes_Subidas_Encabezado.Current("LoteGestacion")
                        odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.UsuarioCreadorColumn.DefaultValue = UsuarioActual
                        If Me.procesoComboBoxEx1.Text = "Subida Eng." Then
                            odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.CodigoCerdaColumn.DefaultValue = Trim(bsPesosDestetes_Subidas_Encabezado.Current("LoteGestacion")) & If(Me.procesoComboBoxEx1.Text = "Subida Eng." And Me.detalleCerdasDataGridViewX2.RowCount > 0, "_" & Me.detalleCerdasDataGridViewX2.RowCount + 1, "")
                        Else
                            odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.CodigoCerdaColumn.DefaultValue = Nothing
                        End If
                        odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.FechaSistemaColumn.DefaultValue = FechaSistema
                        odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.ProcesoColumn.DefaultValue = procesoComboBoxEx1.Text
                        odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.AccionColumn.DefaultValue = "Reg. Pesos"
                        odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.TotalCerdosColumn.DefaultValue = 0
                        odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.TotalPesoColumn.DefaultValue = 0
                        odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar.OriginalCodigoCerdaColumn.DefaultValue = ""

                        bsPesosDestetes_Subidas_Cerdas.AddNew()
                    Else
                        MessageBoxEx.Show("Debe ingresar el lote de Gestación/Engorde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    MessageBoxEx.Show("Debe corregir el error que se muestra en el registro del encabezado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Dim resp As MsgBoxResult = MessageBoxEx.Show("No puede adicionar registros en modo consulta, desea establecer el modo MODIFICAR?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    modoSwitchButton1.Value = True
                    GoTo Nuevo
                End If
            End If

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message.ToString, "Error añadir Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub GrabarCerdas()
        Try

            If modoSwitchButton1.Value = True And Not odtsPesos.HasErrors() And Not IsDBNull(bsPesosDestetes_Subidas_Encabezado.Current("LoteGestacion")) Then

                If hayerrores() = 0 Then

                    bsPesosDestetes_Subidas_Cerdas.EndEdit()
                    PesosDestetes_Subidas_CerdasAdapter.Update(odtsPesos.Proc_CerdasPesos_Dest_Subidas_Listar)

                    Dim totalpeso As Integer, totalcerdos As Integer
                    For i As Integer = 0 To Me.detalleCerdasDataGridViewX2.RowCount - 1
                        totalpeso += Val(Me.detalleCerdasDataGridViewX2.Rows(i).Cells("c_TotalPeso").Value)
                        totalcerdos += Val(Me.detalleCerdasDataGridViewX2.Rows(i).Cells("c_TotalCerdos").Value)
                    Next
                    Try

                        PesosDestetes_Subidas_EncabezadoAdapter.Actualizar(UsuarioActual, totalpeso, Me.detalleCerdasDataGridViewX2.RowCount, totalcerdos, bsPesosDestetes_Subidas_Encabezado.Current("LoteGestacion"), bsPesosDestetes_Subidas_Encabezado.Current("Proceso"))
                    Catch ex As Exception
                    End Try

                End If
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message.ToString, "Error Grabar Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub detalleCerdasDataGridViewX2_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles detalleCerdasDataGridViewX2.RowEnter
        If Not IsDBNull(Me.detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_CodigoCerda").Value) Then
            GrabarCerdas()
        End If
    End Sub
    Sub CargarPesos(ByVal LoteGestacion As String, ByVal Proceso As String, ByVal CodigoCerda As String)
        Try
            PesosDestetes_Subidas_PesosAdapter.Fill(odtsPesos.Proc_CerdasPesos_Dest_Subidas_pesos_Listar, LoteGestacion, Proceso, CodigoCerda)
            bsPesosDestetes_Subidas_Pesos.DataSource = odtsPesos.Proc_CerdasPesos_Dest_Subidas_pesos_Listar
            Me.PesosCerditosDataGridViewX3.AutoGenerateColumns = False
            Me.PesosCerditosDataGridViewX3.DataSource = bsPesosDestetes_Subidas_Pesos

            odtsPesos.Proc_CerdasPesos_Dest_Subidas_pesos_Listar.UsuarioModificadorColumn.DefaultValue = UsuarioActual

            totalizar()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message.ToString, "Error cargar pesos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DetalleCerdasDataGridViewX2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles detalleCerdasDataGridViewX2.CellContentClick
        If detalleCerdasDataGridViewX2.CurrentCell.ColumnIndex = 3 Then
            If modoSwitchButton1.Value = True Then
                If Me.detalleCerdasDataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.BackColor <> Color.Red Then
                    If Not IsDBNull(detalleCerdasDataGridViewX2.CurrentRow.Cells("c_TotalCerdos").Value) Then
                        If detalleCerdasDataGridViewX2.CurrentRow.Cells("c_TotalCerdos").Value > 0 Then
                            Dim resp As MsgBoxResult = MessageBoxEx.Show("¿Desea generar la entrada para los pesos de la cerda: " & Trim(detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_CodigoCerda").Value) & "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If resp = MsgBoxResult.Yes Then
                                GrabarCerdas()
                                Dim cnx As New SqlClient.SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
                                Try
                                    Dim cmd As New SqlClient.SqlCommand("Proc_CerdasPesos_Dest_Subidas_pesos_Generar", cnx)
                                    cmd.CommandTimeout = 60000
                                    cmd.CommandType = CommandType.StoredProcedure
                                    Dim LoteGestacion As String = bsPesosDestetes_Subidas_Cerdas.Current("LoteGestacion")
                                    Dim Proceso As String = bsPesosDestetes_Subidas_Encabezado.Current("Proceso")
                                    Dim CodigoCerda = bsPesosDestetes_Subidas_Cerdas.Current("CodigoCerda")
                                    Dim totalCerdos As Integer = bsPesosDestetes_Subidas_Cerdas.Current("TotalCerdos")
                                    cmd.Parameters.Add("@LoteGestacion", SqlDbType.Char, 8).Value = LoteGestacion
                                    cmd.Parameters.Add("@Proceso", SqlDbType.NChar, 15).Value = Proceso
                                    cmd.Parameters.Add("@CodigoCerda", SqlDbType.Char, 8).Value = CodigoCerda
                                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = UsuarioActual
                                    cmd.Parameters.Add("@FechaSistema", SqlDbType.DateTime).Value = FechaSistema
                                    cmd.Parameters.Add("@NoCerdos", SqlDbType.Int).Value = totalCerdos

                                    cnx.Open()
                                    cmd.ExecuteNonQuery()
                                    cnx.Close()

                                    CargarPesos(bsPesosDestetes_Subidas_Cerdas.Current("LoteGestacion"), bsPesosDestetes_Subidas_Cerdas.Current("Proceso"), bsPesosDestetes_Subidas_Cerdas.Current("CodigoCerda"))
                                    PesosDestetes_Subidas_CerdasAdapter.ActualizarTotalCerdos(Me.PesosCerditosDataGridViewX3.RowCount, bsPesosDestetes_Subidas_Cerdas.Current("LoteGestacion"), Me.procesoComboBoxEx1.Text, bsPesosDestetes_Subidas_Cerdas.Current("CodigoCerda"))
                                    'porcentajeEncabezadoGen()
                                    validarSiHayPesosBloquearCampo()

                                Catch ex As Exception
                                    MessageBoxEx.Show(ex.Message.ToString, "Error generar pesos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Finally
                                    If cnx.State = ConnectionState.Open Then
                                    cnx.Close()
                                End If
                                End Try

                            End If
                        Else
                            MessageBoxEx.Show("El total de cerdos debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If


                Else
                    MessageBoxEx.Show("Debe corregir el error para poder registrar los pesos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBoxEx.Show("No puede adicionar registros en modo consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        End If
    End Sub

    Sub totalizar()
        If modoSwitchButton1.Value = True Then
            Try

                Dim totalineas As Integer, totalpesos As Double, f As Integer, m As Integer, contarpesosreg As Integer
                For i As Integer = 0 To Me.PesosCerditosDataGridViewX3.RowCount - 1
                    totalineas += 1
                    totalpesos += Val(Me.PesosCerditosDataGridViewX3.Rows(i).Cells("d_Peso").Value)

                    If Me.PesosCerditosDataGridViewX3.Rows(i).Cells("d_Genero").Value = "F" Then
                        f += 1
                    ElseIf Me.PesosCerditosDataGridViewX3.Rows(i).Cells("d_Genero").Value = "M" Then
                        m += 1
                    End If

                    If Me.PesosCerditosDataGridViewX3.Rows(i).Cells("d_Peso").Value > 0 Then
                        contarpesosreg += 1
                    End If
                Next

                Try
                    bsPesosDestetes_Subidas_Cerdas.Current("TotalPeso") = totalpesos
                    bsPesosDestetes_Subidas_Cerdas.Current("UsuarioModificador") = UsuarioActual
                    bsPesosDestetes_Subidas_Cerdas.Current("FechaHoraModificacion") = Today & " " & TimeOfDay
                    'If bsPesosDestetes_Subidas_Cerdas IsNot Nothing Then
                    '    bsPesosDestetes_Subidas_Pesos.Current("FechaHoraModificacion") = Today & " " & TimeOfDay
                    '    bsPesosDestetes_Subidas_Pesos.Current("UsuarioModificador") = UsuarioActual
                    'End If

                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                Me.totalesLabelX3.Text = String.Format("{0} Cerdos(as)      {1} Lbs.     F({2}), M({3})", totalineas, Format(totalpesos, "###,###,###,##0.00"), f, m)
                'Me.totalpesoLabelX3.Text = String.Format("{0} Lbs.", Format(totalpesos, "###,###,###,##0.00"))
                'Me.totalgeneroLabelX4.Text = String.Format("F({0}), M({1})", f, m)

                Me.detalleCerdasDataGridViewX2.CurrentRow.Cells("c_Porcentaje").Value = CInt((contarpesosreg / Me.PesosCerditosDataGridViewX3.RowCount) * 100) & "%"

            Catch ex As Exception
            End Try
        End If

    End Sub
    Private Sub PesosCerditosDataGridViewX3_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles PesosCerditosDataGridViewX3.CellEnter
        totalizar()
    End Sub
    Sub grabarpesos()
        'Try
        If modoSwitchButton1.Value = True And Not odtsPesos.HasErrors() And Not IsDBNull(bsPesosDestetes_Subidas_Encabezado.Current("LoteGestacion")) Then



            bsPesosDestetes_Subidas_Pesos.EndEdit()
            PesosDestetes_Subidas_PesosAdapter.Update(odtsPesos.Proc_CerdasPesos_Dest_Subidas_pesos_Listar)

            Dim totalpeso As Integer, totalcerdos As Integer
            For i As Integer = 0 To Me.detalleCerdasDataGridViewX2.RowCount - 1
                totalpeso += Val(Me.detalleCerdasDataGridViewX2.Rows(i).Cells("c_TotalPeso").Value)
                totalcerdos += Val(Me.detalleCerdasDataGridViewX2.Rows(i).Cells("c_TotalCerdos").Value)
            Next

            PesosDestetes_Subidas_EncabezadoAdapter.Actualizar(UsuarioActual, totalpeso, Me.detalleCerdasDataGridViewX2.RowCount, totalcerdos, bsPesosDestetes_Subidas_Cerdas.Current("LoteGestacion"), bsPesosDestetes_Subidas_Cerdas.Current("Proceso"))
            'porcentajeEncabezadoGen()
        End If
        'Catch ex As Exception
        '    MessageBoxEx.Show(ex.Message, "Error al grabar pesos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub PesosCerditosDataGridViewX3_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles PesosCerditosDataGridViewX3.RowEnter
        If modoSwitchButton1.Value = True Then
            totalizar()
            GrabarEncabezado()
            GrabarCerdas()
            grabarpesos()
        End If


    End Sub

    Private Sub detalleCerdasDataGridViewX2_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles detalleCerdasDataGridViewX2.RowLeave

    End Sub

    Private Sub detalleCerdasDataGridViewX2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles detalleCerdasDataGridViewX2.CellEnter
        If Not IsDBNull(detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_CodigoCerda").Value) Then
            CargarPesos(bsPesosDestetes_Subidas_Cerdas.Current("LoteGestacion"), bsPesosDestetes_Subidas_Cerdas.Current("Proceso"), bsPesosDestetes_Subidas_Cerdas.Current("CodigoCerda"))
        End If

        If Not IsDBNull(detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_CodigoCerda").Value) Then

            'If vListaCerdasActivasAdapter.GetExisteCodigoCerda(detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_CodigoCerda").Value) = 0 And Me.procesoComboBoxEx1.Text = "Destete" Then
            '    Me.detalleCerdasDataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            '    Me.errorDetalleCerdasLabelX3.Visible = True
            '    Me.errorDetalleCerdasLabelX3.Text = "CÓDIGO DE CERDA NO EXISTE O YA FUE DESCARTADA"
            'Else
            '    Me.detalleCerdasDataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
            '    Me.errorDetalleCerdasLabelX3.Visible = False
            '    Me.errorDetalleCerdasLabelX3.Text = ""
            'End If
        End If
    End Sub


    Private Sub encabezadoDataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles encabezadoDataGridViewX1.CellEnter
        If Me.detalleCerdasDataGridViewX2.Rows.Count > 0 Then
            Me.encabezadoDataGridViewX1.Rows(Me.encabezadoDataGridViewX1.CurrentCell.RowIndex).ReadOnly = True
        Else
            Me.encabezadoDataGridViewX1.Rows(Me.encabezadoDataGridViewX1.CurrentCell.RowIndex).ReadOnly = False
        End If
        If Me.detalleCerdasDataGridViewX2.Rows.Count = 0 Then
            Me.PesosCerditosDataGridViewX3.DataSource = Nothing
        End If
        If Not IsDBNull(encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteGestacion").Value) Then

            If lotesAdapter.GetExisteLote(encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteGestacion").Value) = 0 Then
                Me.encabezadoDataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                Me.errorEncabezadoLabelX3.Visible = True
                Me.errorEncabezadoLabelX3.Text = "LOTE INGRESADO NO EXISTE O NO ES DE TIPO GESTACIÓN"

            Else
                Me.encabezadoDataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
                Me.errorEncabezadoLabelX3.Visible = False
                Me.errorEncabezadoLabelX3.Text = ""
                Me.encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteEngorde").Value = lotesAdapter.GetLoteEngordeDestino(encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteGestacion").Value)
            End If
        Else
            Me.encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteEngorde").Value = ""
        End If
    End Sub
    Private Sub PesosCerditosDataGridViewX3_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles PesosCerditosDataGridViewX3.CellLeave

    End Sub

    Private Sub detalleCerdasDataGridViewX2_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles detalleCerdasDataGridViewX2.DataError
        If e.Exception.ToString.Contains("UniqueConstraint") Then
            MessageBoxEx.Show("Ya esta presente el registro: " & detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_CodigoCerda").Value & ", no puede insertar un registro duplicado", "Erro de llave única", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBoxEx.Show(e.Exception.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub PesosCerditosDataGridViewX3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PesosCerditosDataGridViewX3.CellContentClick

    End Sub

    Private Sub ModoSwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles modoSwitchButton1.ValueChanged
        If Me.modoSwitchButton1.Value = True Then
            If Me.detalleCerdasDataGridViewX2.RowCount > 0 Then
                Me.encabezadoDataGridViewX1.Rows(Me.encabezadoDataGridViewX1.CurrentCell.RowIndex).ReadOnly = True
            Else
                Me.encabezadoDataGridViewX1.Rows(Me.encabezadoDataGridViewX1.CurrentCell.RowIndex).ReadOnly = False
            End If

            Me.detalleCerdasDataGridViewX2.ReadOnly = False
            Me.PesosCerditosDataGridViewX3.ReadOnly = False
            Me.aceptarButtonX3.Enabled = True

        Else
            Me.encabezadoDataGridViewX1.Rows(Me.encabezadoDataGridViewX1.CurrentCell.RowIndex).ReadOnly = True
            Me.detalleCerdasDataGridViewX2.ReadOnly = True
            Me.PesosCerditosDataGridViewX3.ReadOnly = True
            Me.aceptarButtonX3.Enabled = False
        End If
    End Sub

    Private Sub ButtonX2_Click_1(sender As Object, e As EventArgs) Handles ButtonX2.Click

        Me.Close()
    End Sub

    Private Sub ButtonX3_Click_1(sender As Object, e As EventArgs) Handles aceptarButtonX3.Click
        Dim errores As Integer
        For i As Integer = 0 To encabezadoDataGridViewX1.RowCount - 1
            If Me.encabezadoDataGridViewX1.Rows(i).DefaultCellStyle.BackColor = Color.Red Then
                errores += 1
            End If
        Next
        For y As Integer = 0 To Me.detalleCerdasDataGridViewX2.RowCount - 1
            If Me.detalleCerdasDataGridViewX2.Rows(y).DefaultCellStyle.BackColor = Color.Red Then
                errores += 1
            End If
        Next
        If errores > 0 Then
            MessageBoxEx.Show("Tiene errores que no ha corregido, debe corregirlos y luego intenta nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            totalizar()
            GrabarEncabezado()
            GrabarCerdas()
            grabarpesos()
            MessageBoxEx.Show("Cambios aplicados correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.modoSwitchButton1.Value = False
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        CargarEncabezado(Me.procesoComboBoxEx1.Text)
        modoSwitchButton1.Value = False
    End Sub

    Private Sub encabezadoDataGridViewX1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles encabezadoDataGridViewX1.RowPrePaint
        Me.encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_Porcentaje").ReadOnly = True
        Me.encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_vacia").ReadOnly = True
        If procesoComboBoxEx1.Text = "Subida Eng." Then
            Me.encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteEngorde").ReadOnly = True
        Else

            Me.encabezadoDataGridViewX1.Rows(e.RowIndex).Cells("e_LoteEngorde").ReadOnly = False
        End If
    End Sub



    Private Sub detalleCerdasDataGridViewX2_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles detalleCerdasDataGridViewX2.RowPrePaint
        Me.detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_TotalPeso").ReadOnly = True
        Me.detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_Porcentaje").ReadOnly = True
        Me.detalleCerdasDataGridViewX2.Rows(e.RowIndex).Cells("c_vacia").ReadOnly = True
    End Sub

    Private Sub PesosCerditosDataGridViewX3_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles PesosCerditosDataGridViewX3.RowPrePaint
        Me.PesosCerditosDataGridViewX3.Rows(e.RowIndex).Cells("d_vacia").ReadOnly = True
        Me.PesosCerditosDataGridViewX3.Rows(e.RowIndex).Cells("d_LineaNo").ReadOnly = True
    End Sub

    Private Sub frmPesosDestetes_Subidas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.M Then
            modoSwitchButton1.Value = True
        End If
        If e.Control And e.KeyCode = Keys.Q Then
            If modoSwitchButton1.Value = True Then
                ButtonX3_Click_1(sender, e)
                modoSwitchButton1.Value = False
            End If

        End If
    End Sub
End Class