Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents
Imports System.Data.SqlClient
Imports System.Data
Public Class frmPrincipal
    Inherits DevComponents.DotNetBar.Office2007RibbonForm
    Dim hijos As Integer = 0
    Public Tema As String
    Dim ventanas As Integer
    Public o_color As Color
    Dim m_color As Color
    Dim b As DevComponents.DotNetBar.Balloon
    Dim m_Lote, m_Granja As String
    Dim m_FechaCreacion As Date
    Dim m_NoSalidas, m_Existencia As Integer
    Dim m_PesoProm_x_Cerdo As Double
    Dim FechaTenia As Date

    Dim alertaPendientesConfirmarAdapter As New DtsBDGRANJATableAdapters.Alerta_PendientesConfirmarTableAdapter
    Dim alertaPendientesPartosAdapter As New DtsBDGRANJATableAdapters.Alerta_PendientesPartosTableAdapter
    Dim alertaPendientesDesteteAdapter As New DtsBDGRANJATableAdapters.Alerta_PendientesDesteteTableAdapter
    Dim alertaVaciasAdapter As New DtsBDGRANJATableAdapters.Alerta_CerdasVaciasTableAdapter
    Dim Alerta_Maximo7PartosAdapter As New DtsBDGRANJATableAdapters.Alerta_Maximo7PartosTableAdapter
    Dim alertaEdadVerracosAdapter As New DtsBDGRANJATableAdapters.Alerta_EdadVerracosTableAdapter

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        My.Forms.REQUISICIONES.MdiParent = Me
        My.Forms.REQUISICIONES.txtUserCreador.Text = Me.lbUsuario.Text
        My.Forms.REQUISICIONES.WindowState = FormWindowState.Maximized
        My.Forms.REQUISICIONES.Show()
    End Sub
    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim x As New Add_Producto(
        'Me.AddOwnedForm(x)
        'x.MdiParent = Me
        'x.habilitar_cajas()
        'x.limpiar_cajas()
        ''x.Cod_Product_Automatico()
        'x.btnGuardar.Enabled = True
        'x.btnNuevo.Enabled = False
        'x.Show()
        With My.Forms.frmRegistrarMedicamentos
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub
    Public Sub ActualizarAlertas(ToastNotificar As Boolean)
        Try
            alertaPendientesConfirmarAdapter.Fill(odtsBDGRANJA.Alerta_PendientesConfirmar, FechaSistema)
            alertaPendientesPartosAdapter.Fill(odtsBDGRANJA.Alerta_PendientesPartos, FechaSistema)
            alertaPendientesDesteteAdapter.Fill(odtsBDGRANJA.Alerta_PendientesDestete, FechaSistema)
            alertaVaciasAdapter.Fill(odtsBDGRANJA.Alerta_CerdasVacias, FechaSistema)
            Alerta_Maximo7PartosAdapter.Fill(odtsBDGRANJA.Alerta_Maximo7Partos)
            alertaEdadVerracosAdapter.Fill(odtsBDGRANJA.Alerta_EdadVerracos)

            Dim ExcedidosConfirmaciones, PorVencerConfirmaciones, ExcedidosPartos, PorVencerPartos, ExcedidosDestete, PorVencerDestete, ExcedidosVacias, PorVencerVacias, PartosExcedidos, PorExceder, EdadVerracosExcedidos, EdadVerracosPorVencer, EdadVerracosATiempo As Integer

            For i As Integer = 0 To odtsBDGRANJA.Alerta_PendientesConfirmar.Rows.Count - 1
                If odtsBDGRANJA.Alerta_PendientesConfirmar.Rows(i).Item("Estado1") = "Por vencer" Then
                    PorVencerConfirmaciones += 1
                ElseIf odtsBDGRANJA.Alerta_PendientesConfirmar.Rows(i).Item("Estado1") = "Excedido" Then
                    ExcedidosConfirmaciones += 1
                End If
            Next
            For i As Integer = 0 To odtsBDGRANJA.Alerta_PendientesPartos.Rows.Count - 1
                If odtsBDGRANJA.Alerta_PendientesPartos.Rows(i).Item("Estado1") = "Por vencer" Then
                    PorVencerPartos += 1
                ElseIf odtsBDGRANJA.Alerta_PendientesPartos.Rows(i).Item("Estado1") = "Excedido" Then
                    ExcedidosPartos += 1
                End If
            Next
            For i As Integer = 0 To odtsBDGRANJA.Alerta_PendientesDestete.Rows.Count - 1
                If odtsBDGRANJA.Alerta_PendientesDestete.Rows(i).Item("Estado") = "Por vencer" Then
                    PorVencerDestete += 1
                ElseIf odtsBDGRANJA.Alerta_PendientesDestete.Rows(i).Item("Estado") = "Excedido" Then
                    ExcedidosDestete += 1
                End If
            Next
            For i As Integer = 0 To odtsBDGRANJA.Alerta_CerdasVacias.Rows.Count - 1
                If If(IsDBNull(odtsBDGRANJA.Alerta_CerdasVacias.Rows(i).Item("Estado1")), "", odtsBDGRANJA.Alerta_CerdasVacias.Rows(i).Item("Estado1")) = "Por vencer" Then
                    PorVencerVacias += 1
                ElseIf If(IsDBNull(odtsBDGRANJA.Alerta_CerdasVacias.Rows(i).Item("Estado1")), "", odtsBDGRANJA.Alerta_CerdasVacias.Rows(i).Item("Estado1")) = "Excedido" Then
                    ExcedidosVacias += 1
                End If
            Next
            For i As Integer = 0 To odtsBDGRANJA.Alerta_Maximo7Partos.Rows.Count - 1
                If odtsBDGRANJA.Alerta_Maximo7Partos.Rows(i).Item("Alerta") = "Excedido" Then
                    PartosExcedidos += 1
                ElseIf odtsBDGRANJA.Alerta_Maximo7Partos.Rows(i).Item("Alerta") = "Próxima a excederse" Then
                    PorExceder += 1
                End If
            Next
            For i As Integer = 0 To odtsBDGRANJA.Alerta_EdadVerracos.Rows.Count - 1
                If odtsBDGRANJA.Alerta_EdadVerracos.Rows(i).Item("Estado") = "Edad Excedida" Then
                    EdadVerracosExcedidos += 1
                ElseIf odtsBDGRANJA.Alerta_EdadVerracos.Rows(i).Item("Estado") = "Cerca de exceder" Then
                    EdadVerracosPorVencer += 1
                ElseIf odtsBDGRANJA.Alerta_EdadVerracos.Rows(i).Item("Estado") = "A tiempo" Then
                    EdadVerracosATiempo += 1
                End If
            Next

            Dim msgConfirmaciones, msgPartos, msgDestete, msgVacias, msgPartosExecedidos, msgEdadVerracos As String


            msgConfirmaciones = "Inseminaciones pendientes de confirmar: Por vencer (" & PorVencerConfirmaciones & ") Excedido(" & ExcedidosConfirmaciones & ")"
            msgPartos = "Partos pendientes de efectuar: Por vencer (" & PorVencerPartos & ") Excedido(" & ExcedidosPartos & ")"
            msgDestete = "Destetes pendientes de efectuar: Por vencer (" & PorVencerDestete & ") Excedido(" & ExcedidosDestete & ")"
            msgVacias = "Hay registro de cerdas vacías que esta por vencer su tiempo de estadia en el lote de vacías desde su ultimo servicio: Por vencer(" & PorVencerVacias & ") Excedido(" & ExcedidosVacias & ")"
            msgPartosExecedidos = "Hay un total de (" & PorExceder & ") cerdas que estan próximas a exceder el numero de partos que son siete, y hay un total de (" & PartosExcedidos & ") cerdas ya excedieron el número de partos"
            msgEdadVerracos = String.Format("Hay {0} verraco(s) excedido(s), {1} por execederse y {2} a tiempo", EdadVerracosExcedidos, EdadVerracosPorVencer, EdadVerracosATiempo)

            Dim msgGeneral As String
            msgGeneral = "Tiene procesos que requieren su intervención, resumen: Por Vencer(" & PorVencerConfirmaciones + PorVencerDestete + PorVencerPartos + PorVencerVacias + PorExceder + EdadVerracosPorVencer & ")  Vencidos(" & ExcedidosConfirmaciones + ExcedidosDestete + ExcedidosPartos + ExcedidosVacias + PartosExcedidos + EdadVerracosExcedidos & ")"
            'msgGeneral += If((PorVencerConfirmaciones > 0 Or ExcedidosConfirmaciones > 0), msgConfirmaciones, "")
            'msgGeneral += If((PorVencerPartos > 0 Or ExcedidosPartos > 0), msgPartos, "")
            'msgGeneral += If((PorVencerDestete > 0 Or ExcedidosDestete > 0), msgDestete, "")
            'msgGeneral += "De clic sobre esta notificación para ver el detalle"

            odtsBDGRANJA.ResumenAlertas.Clear()
            If PorVencerConfirmaciones > 0 Or ExcedidosConfirmaciones > 0 Then
                odtsBDGRANJA.ResumenAlertas.Rows.Add("Inseminaciones", msgConfirmaciones, "Más Detalles")
            End If
            If PorVencerPartos > 0 Or ExcedidosPartos > 0 Then
                odtsBDGRANJA.ResumenAlertas.Rows.Add("Partos", msgPartos, "Más Detalles")
            End If
            If PorVencerDestete > 0 Or ExcedidosDestete > 0 Then
                odtsBDGRANJA.ResumenAlertas.Rows.Add("Destetes", msgDestete, "Más Detalles")
            End If
            If PorVencerVacias > 0 Or ExcedidosVacias > 0 Then
                odtsBDGRANJA.ResumenAlertas.Rows.Add("Cerdas vacías", msgVacias, "Más Detalles")
            End If

            If PorExceder > 0 Or PartosExcedidos > 0 Then
                odtsBDGRANJA.ResumenAlertas.Rows.Add("Límite de partos", msgPartosExecedidos, "Más Detalles")
            End If
            If EdadVerracosPorVencer > 0 Or EdadVerracosExcedidos > 0 Then
                odtsBDGRANJA.ResumenAlertas.Rows.Add("Límite de edad verracos", msgEdadVerracos, "Más Detalles")
            End If

            If PorVencerConfirmaciones > 0 Or PorVencerDestete > 0 Or PorVencerPartos > 0 Or ExcedidosConfirmaciones > 0 Or ExcedidosDestete > 0 Or ExcedidosPartos > 0 Or PorVencerVacias > 0 Or ExcedidosVacias > 0 Or PorExceder > 0 Or PartosExcedidos > 0 Or EdadVerracosExcedidos > 0 Or EdadVerracosPorVencer > 0 Then
                If ToastNotificar = True Then
                    'ToastNotificationsManager1.Notifications.Item(0).ID = "Alertas Sistema Granja"
                    'ToastNotificationsManager1.Notifications.Item(0).Template = DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02
                    'ToastNotificationsManager1.Notifications.Item(0).Image = My.Resources.notificacion_icon2
                    'ToastNotificationsManager1.Notifications.Item(0).Header = Me.lbUsuario.Text & ", el sistema le notifica que tiene alertas"
                    'ToastNotificationsManager1.Notifications.Item(0).Body = msgGeneral
                    'ToastNotificationsManager1.Notifications.Item(0).Sound = DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Looping_Alarm
                    'ToastNotificationsManager1.Notifications.Item(0).Duration = DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Long
                    'ToastNotificationsManager1.ShowNotification("ae7bbcc8-5677-4e84-8589-9b9653f5473e")
                End If


                Me.PanelControl1.Size = New Size(PanelControl1.Size.Width, 31)

            Else

                Me.PanelControl1.Size = New Size(PanelControl1.Size.Width, 0)
            End If


        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al actualizar alertas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        With My.Forms.Creacion_Lotes
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lbHora.Text = TimeOfDay
        Static rand As New Random()
        Me.lbFechaActual.Text = Format(FechaSistema, "dd/MM/yyyy")
        Static seg As Integer
        seg += 1
        If seg = 3 Then
            Me.Panel1notifi.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
            seg = 0
        End If

    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New Defunciones()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    'Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click

    'End Sub
    Sub Actualizar_control_de_Inicio_session()
        Try
            sql = New SqlCommand("update Control_de_Sessiones set Fecha_que_Finalizo_Sesion='" & FechaSistema & "', Hora_que_Finalizo_Sesion='" & TimeOfDay & "' where No_Session='" & Me.lbSession.Text & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show("Error al cerrar sesión ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            My.MySettings.Default.pFechasWidth = Me.PanelEx1.Width
            My.MySettings.Default.Save()
        Catch ex As Exception
        End Try
        Me.hijos = 0
        Dim resp As New MsgBoxResult
        For Each frm As Form In MdiChildren
            hijos += 1
        Next
        If hijos >= 1 Then
            If hijos = 1 Then
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventana abierta, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()
                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                Else
                    e.Cancel = True
                End If
            Else
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventanas abiertas, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()
                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                Else
                    e.Cancel = True
                End If
            End If
        Else
            Me.Actualizar_control_de_Inicio_session()
            End
        End If
    End Sub
    Private m_ColorSelected As Boolean = False
    Private m_ManagerStyle As eStyle = eStyle.Office2010Silver
    Private Sub buttonStyleCustom_ExpandChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColorPickerDropDown1.ExpandChange
        If Me.ColorPickerDropDown1.Expanded Then

            m_ColorSelected = False
            m_ManagerStyle = StyleManager.Style
        Else
            If Not m_ColorSelected Then
                StyleManager.ChangeStyle(m_ManagerStyle, Color.Empty)
            End If
        End If
        frmTableroInformativo.coloresPaneles()
    End Sub
    Private Sub buttonStyleCustom_ColorPreview(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ColorPreviewEventArgs) Handles ColorPickerDropDown1.ColorPreview
        StyleManager.ColorTint = e.Color
        o_color = e.Color
    End Sub
    Private Sub buttonStyleCustom_ColorPreview1(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ColorPreviewEventArgs) Handles ColorPickerDropDown2.ColorPreview
        StyleManager.ColorTint = e.Color
        o_color = e.Color
    End Sub
    'Private Sub ButtonItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem26.Click

    'End Sub
    Private Sub ButtonItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StyleManager1.ManagerStyle = eStyle.Office2007Blue
        Me.Tema = "O2007Blue"
    End Sub
    Private Sub ButtonItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StyleManager1.ManagerStyle = eStyle.Office2007Black
        Me.Tema = "O2007Black"
    End Sub
    Private Sub ButtonItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StyleManager1.ManagerStyle = eStyle.Office2007Silver
        Me.Tema = "O2007Silver"
    End Sub
    Private Sub ButtonItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StyleManager1.ManagerStyle = eStyle.Office2007VistaGlass
        Me.Tema = "O2007VistaGlass"
    End Sub
    Private Sub ButtonItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StyleManager1.ManagerStyle = eStyle.Office2010Blue
        Me.Tema = "O2010Blue"
    End Sub
    Private Sub ButtonItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StyleManager1.ManagerStyle = eStyle.Office2010Black
        Me.Tema = "O2010Black"
    End Sub
    Private Sub ButtonItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StyleManager1.ManagerStyle = eStyle.Office2010Silver
        Me.Tema = "O2010Silver"
    End Sub
    Private Sub ButtonItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StyleManager1.ManagerStyle = eStyle.Windows7Blue
        Me.Tema = "OWin7"
    End Sub
    Private Sub myMdiControlPaint(ByVal sender As Object, _
ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawImage(Me.imgFondo2.Image, 0, 0, Me.Width, Me.Height)
    End Sub

    Private Sub myMdiControlResize(ByVal sender As Object, _
    ByVal e As System.EventArgs)
        CType(sender, MdiClient).Invalidate()
    End Sub
    Public Sub ActualizarDatosPrincipales()
        Me.lbUsuario.Text = UsuarioActual
        Me.lbFechaActual.Text = FechaSistema
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PanelControl1.Size = New Size(Me.PanelControl1.Size.Width, 0)
        'Me.ToastNotificationsManager1.Notifications.Item(0).Body = "Esta es una pueba"
        'Me.ToastNotificationsManager1.Notifications.Item(0).Body2 = "Probando"

        'Me.ToastNotificationsManager1.ShowNotification(Me.ToastNotificationsManager1.Notifications.Item(0).ID)
        ActualizarExistencias()
        ActualizarLote()
        Me.RibbonControl1.Expanded = My.MySettings.Default.RibbonExpanded
        For Each c As Control In Me.Controls
            If TypeOf c Is MdiClient Then
                AddHandler c.Paint, AddressOf myMdiControlPaint
                AddHandler c.SizeChanged, AddressOf myMdiControlResize
                Exit For
            End If
        Next
        Me.ComandoPrivilegios.Execute()
        'Dim frmInicio As New frmInfo_Inicio
        'With frmInicio
        '    .MdiParent = Me
        '    .WindowState = FormWindowState.Normal
        '    .Show()
        'End With
        Me.lbFechaActual.Text = FechaSistema
        'If Tema = "O2007Blue" Then
        '    Me.StyleManager1.ManagerStyle = eStyle.Office2007Blue
        '    Me.StyleManager1.ManagerColorTint = o_color
        'ElseIf Me.Tema = "O2007Black" Then
        '    Me.StyleManager1.ManagerStyle = eStyle.Office2007Black
        '    Me.StyleManager1.ManagerColorTint = o_color
        'ElseIf Tema = "O2007Silver" Then
        '    Me.StyleManager1.ManagerStyle = eStyle.Office2007Silver
        '    Me.StyleManager1.ManagerColorTint = o_color
        'ElseIf Tema = "O2007VistaGlass" Then
        '    Me.StyleManager1.ManagerStyle = eStyle.Office2007VistaGlass
        '    Me.StyleManager1.ManagerColorTint = o_color
        'ElseIf Tema = "O2010Blue" Then
        '    Me.StyleManager1.ManagerStyle = eStyle.Office2010Blue
        '    Me.StyleManager1.ManagerColorTint = o_color
        'ElseIf Tema = "O2010Black" Then
        '    Me.StyleManager1.ManagerStyle = eStyle.Office2010Black
        '    Me.StyleManager1.ManagerColorTint = o_color
        'ElseIf Tema = "O2010Silver" Then
        '    Me.StyleManager1.ManagerStyle = eStyle.Office2010Silver
        '    Me.StyleManager1.ManagerColorTint = o_color
        'ElseIf Tema = "OWin7" Then
        '    Me.StyleManager1.ManagerStyle = eStyle.Windows7Blue
        '    Me.StyleManager1.ManagerColorTint = o_color
        'End If
        UsuarioActual = Me.lbUsuario.Text
        BuscarToolStripButton_Click(sender, e)
        Me.cbxCUnitario.Text = CUnitario
        'CUnitario = My.Settings.CUnitario_Setting.ToString
        Me.F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Try
            Me.PanelEx1.Size = New Size(My.Settings.pFechasWidth, Me.PanelEx1.Height)
        Catch ex As Exception
        End Try
        Me.SwitchButton1.Value = Configuraciones.Default.MostrarPanelRapido
        Me.PanelEx1.Visible = Configuraciones.Default.MostrarPanelRapido
        ActualizarAlertas(True)

        PanelControl1.BackColor = PanelEx1.ColorScheme.BarBackground
        mostrapanelRapido(False)


        If My.MySettings.Default.CargarTablero = True Then
            Me.mostrarSiCheckBoxItem1.Checked = True
            Me.mostrarNoCheckBoxItem2.Checked = False
        Else
            Me.mostrarSiCheckBoxItem1.Checked = False
            Me.mostrarNoCheckBoxItem2.Checked = True
        End If

        cargartableroinformativo()


    End Sub
    Private Sub ButtonItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = New SqlCommand("update OPCIONES Set Tema='" & Me.Tema & "',Color='" & (Me.o_color.ToString) & "' where Usuario='" & Me.lbUsuario.Text & "'", con)
        con.Open()
        sql.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim x As New Info()
        x.ShowDialog()
    End Sub
    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Actualizar_control_de_Inicio_session()
        Dim x As New Login()
        Me.AddOwnedForm(x)
        x.Show()
        Me.Hide()
    End Sub
    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.hijos = 0
        Dim resp As New MsgBoxResult
        For Each frm As Form In MdiChildren
            hijos += 1
        Next
        If hijos >= 1 Then
            If hijos = 1 Then
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventana abierta, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()

                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                End If
            Else
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventanas abiertas, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()

                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                End If
            End If

        Else
            Me.Actualizar_control_de_Inicio_session()
            End
        End If
    End Sub
    Private Sub NuevaRequisiciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.REQUISICIONES.MdiParent = Me
        My.Forms.REQUISICIONES.txtUserCreador.Text = Me.lbUsuario.Text
        My.Forms.REQUISICIONES.WindowState = FormWindowState.Maximized
        My.Forms.REQUISICIONES.Show()
    End Sub
    Private Sub NuevoProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New Add_Producto()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.habilitar_cajas()
        x.limpiar_cajas()
        'x.Cod_Product_Automatico()
        x.btnGuardar.Enabled = True
        x.btnNuevo.Enabled = False
        x.Show()
    End Sub
    Private Sub CrearLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New Creacion_Lotes()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub RegDefunciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New Defunciones()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub RepConsumoCantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepConsumoCantToolStripMenuItem.Click
        Dim x As New ReporteConsumoCantidad()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub RepConsumoCostosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepConsumoCostosToolStripMenuItem.Click
        Dim x As New ReporteConsumoCostos()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub RepXLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepXLotesToolStripMenuItem.Click
        Dim x As New Reporte_x_Lotes()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmReemplazo()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Label1.Text = Me.lbUsuario.Text
        x.Show()
    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmDestazo()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmRastro()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmEntradas()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmReg_Madres()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmReg_Abuelas()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim HayPendientes As Boolean = False
            sql = New SqlCommand("SELECT * from Reg_Enseminaciones_x_cerda AS a JOIN Estado_de_Partos AS b ON a.Id_Enseminacion=b.Id_Enseminacion WHERE b.Estado_Parto=0 AND a.Estado='C'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    HayPendientes = False
                Else
                    HayPendientes = True
                End If
            End While
            con.Close()
            If HayPendientes = True Then
                Dim x As New frmMuestraPartosProgramados()
                Me.AddOwnedForm(x)
                x.MdiParent = Me
                x.Show()
            Else
                MessageBoxEx.Show("No se ha encontrado ningún registro de parto pendiente en la tabla de enseminaciones del sistema, porfavor verifique que ha ingresado las enseminaciones correspondientes", "Reg. de Enseminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Tema, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub RegCerdasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegCerdasToolStripMenuItem.Click
        Dim x As New frmReg_Madres()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub RegAbuelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegAbuelasToolStripMenuItem.Click
        Dim x As New frmReg_Abuelas()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub RegPartosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegPartosToolStripMenuItem.Click

    End Sub

    Private Sub ButtonItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmFechas As New frmFechayHora()
        FrmFechas.StartPosition = FormStartPosition.CenterScreen
        FrmFechas.ShowDialog()
    End Sub
    Private Sub ButtonItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem62.Click
        Me.StyleManager1.ManagerStyle = eStyle.Office2007Blue
        My.Settings.Save()
        Me.Tema = "O2007Blue"
        frmTableroInformativo.coloresPaneles()
    End Sub

    Private Sub ButtonItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem63.Click
        Me.StyleManager1.ManagerStyle = eStyle.Office2007Silver
        Me.Tema = "O2007Silver"
        frmTableroInformativo.coloresPaneles()
    End Sub

    Private Sub ButtonItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem64.Click
        Me.StyleManager1.ManagerStyle = eStyle.Office2007Black
        Me.Tema = "O2007Black"
        frmTableroInformativo.coloresPaneles()
    End Sub
    Private Sub ButtonItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem65.Click
        Me.StyleManager1.ManagerStyle = eStyle.Office2007VistaGlass
        Me.Tema = "O2007VistaGlass"
        frmTableroInformativo.coloresPaneles()
    End Sub

    Private Sub ButtonItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem66.Click
        Me.StyleManager1.ManagerStyle = eStyle.Office2010Blue
        Me.Tema = "O2010Blue"
        frmTableroInformativo.coloresPaneles()
    End Sub

    Private Sub ButtonItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem68.Click
        Me.StyleManager1.ManagerStyle = eStyle.Office2010Black
        Me.Tema = "O2010Black"
        frmTableroInformativo.coloresPaneles()
    End Sub

    Private Sub ButtonItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem67.Click
        Me.StyleManager1.ManagerStyle = eStyle.Office2010Silver
        Me.Tema = "O2010Silver"
        frmTableroInformativo.coloresPaneles()
    End Sub

    Private Sub ButtonItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem69.Click
        Me.StyleManager1.ManagerStyle = eStyle.Windows7Blue
        Me.Tema = "OWin7"
        frmTableroInformativo.coloresPaneles()
    End Sub
    Private Sub ButtonItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem70.Click
        Try
            sql = New SqlCommand("update OPCIONES Set Tema='" & Me.Tema & "',Color='" & (Me.o_color.ToString) & "' where Usuario='" & Me.lbUsuario.Text & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmR As New frmReporte_x_LoteCostos()
        Me.AddOwnedForm(frmR)
        With frmR
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frmEns As New frmRegistro_Inseminacion()
        'With frmEns
        '    .MdiParent = Me
        '    .WindowState = FormWindowState.Maximized

        '    .Show()
        'End With

        My.Forms.frmRegistro_Inseminacion.MdiParent = Me
        My.Forms.frmRegistro_Inseminacion.WindowState = FormWindowState.Maximized
        My.Forms.frmRegistro_Inseminacion.Show()
    End Sub

    Private Sub ButtonItem37_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem37.Click
        Dim x As New frmRespaldarReg()
        x.StartPosition = FormStartPosition.CenterScreen
        x.ShowDialog()
    End Sub

    Private Sub ButtonItem39_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New ReporteConsumoCantidad()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem40_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New ReporteConsumoCostos()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem42_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmReporte_x_LoteCostos()
        Me.AddOwnedForm(x)
        x.WindowState = FormWindowState.Maximized
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem43_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmConsultaLotes()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.WindowState = FormWindowState.Maximized
        x.Show()
    End Sub

    Private Sub ButtonItem44_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmConsultaValuadosLotes()
        x.StartPosition = FormStartPosition.CenterScreen
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmRptEnseminacion As New frmReporteEnseminaciónG()
        With frmRptEnseminacion
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub
    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Opacity = 90
    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Opacity = 80
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Opacity = 60
    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Opacity = 100
    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.hijos = 0
        Dim resp As New MsgBoxResult
        For Each frm As Form In MdiChildren
            hijos += 1
        Next
        If hijos >= 1 Then
            If hijos = 1 Then
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventana abierta, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()

                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                End If
            Else
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventanas abiertas, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()
                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                End If
            End If
        Else
            Me.Actualizar_control_de_Inicio_session()
            End
        End If
    End Sub

    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTrasladosEntreLotes As New frmTrasladosEntreLotes()
        With frmTrasladosEntreLotes
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem29.Click
        My.Settings.Save()
    End Sub
    Private Sub RepXLoteCostosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepXLoteCostosToolStripMenuItem.Click
        Dim x As New Reporte_x_Lotes()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub RepDetalladoXLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepDetalladoXLoteToolStripMenuItem.Click
        Dim x As New frmConsultaLotes()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.WindowState = FormWindowState.Maximized
        x.Show()
    End Sub

    Private Sub RepDeValuadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepDeValuadosToolStripMenuItem.Click
        Dim x As New frmConsultaValuadosLotes()
        x.StartPosition = FormStartPosition.CenterScreen
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub RepEnseminaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepEnseminaciónToolStripMenuItem.Click
        Dim frmRptEnseminacion As New frmReporteEnseminaciónG()
        With frmRptEnseminacion
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub RegTrasladoEntreLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTrasladosEntreLotes As New frmTrasladosEntreLotes()
        With frmTrasladosEntreLotes
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub RegDeEnseminaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegDeEnseminaciónToolStripMenuItem.Click
        Dim frmEns As New frmEnseminaciones()
        With frmEns
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub RespaldarRegistrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmRespaldarReg()
        x.StartPosition = FormStartPosition.CenterScreen
        x.ShowDialog()
    End Sub
    Sub Bloquear()
        Me.btnSubirRespaldos.Enabled = False
        Me.btnInyectarGastos.Enabled = False
        Me.INYECTARGASTOSOPToolStripMenuItem.Enabled = False
        'Me.btnMenuSubirRespaldos.Enabled = False
        SUBIRRESPALDOToolStripMenuItem.Enabled = False
    End Sub
    Sub Permitir()
        Me.btnSubirRespaldos.Enabled = True
        Me.btnInyectarGastos.Enabled = True
        'Me.btnMenuSubirRespaldos.Enabled = True
        SUBIRRESPALDOToolStripMenuItem.Enabled = True
        Me.INYECTARGASTOSOPToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ComandoPrivilegios_Executed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComandoPrivilegios.Executed
        If TipoUsuario = "Admin" Then
            Permitir()
        ElseIf TipoUsuario = "User" Then
            Bloquear()
        End If
    End Sub

    Private Sub btnSubirRespaldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubirRespaldos.Click
        Dim resp As MsgBoxResult
        resp = MessageBoxEx.Show("Para realizar este proceso es necesario cerrar el sistema, desea continuar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If resp = MsgBoxResult.Yes Then
            Me.Actualizar_control_de_Inicio_session()
            Shell("C:\Extras_SistemaGranja\SubirRespaldos.exe", AppWinStyle.MaximizedFocus)
            Me.Close()
        End If

    End Sub

    Private Sub btnMenuSubirRespaldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim resp As MsgBoxResult
        resp = MessageBoxEx.Show("Para realizar este proceso es necesario cerrar el sistema, desea continuar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If resp = MsgBoxResult.Yes Then
            Me.Actualizar_control_de_Inicio_session()
            Shell(My.Application.Info.DirectoryPath & "\Extras\SubirRespaldos.exe")
            Me.Close()
        End If

    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.REQUISICIONES.MdiParent = Me
        My.Forms.REQUISICIONES.txtUserCreador.Text = Me.lbUsuario.Text
        My.Forms.REQUISICIONES.WindowState = FormWindowState.Maximized
        My.Forms.REQUISICIONES.Show()
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New Add_Producto()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.habilitar_cajas()
        x.limpiar_cajas()
        'x.Cod_Product_Automatico()
        x.btnGuardar.Enabled = True
        x.btnNuevo.Enabled = False
        x.Show()
    End Sub

    Private Sub ButtonItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New Creacion_Lotes()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New Defunciones()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmReemplazo()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmDestazo()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmRastro()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmEntradas()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem38_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTrasladosEntreLotes As New frmTrasladosEntreLotes()
        With frmTrasladosEntreLotes
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub
    Private Sub ButtonItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New ReporteConsumoCantidad()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New ReporteConsumoCostos()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem41_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Reporte_x_Lotes()
        Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub ButtonItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Reporte_x_Lotes()
        Me.AddOwnedForm(frm)
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub ButtonItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmReporte_x_LoteCostos()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmConsultaValuadosLotes()
        x.StartPosition = FormStartPosition.CenterScreen
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmRptEnseminacion As New frmReporteEnseminaciónG()
        With frmRptEnseminacion
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub
    Private Sub ButtonItem76_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmReg_Madres()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmReg_Abuelas()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New frmPartos()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub
    Private Sub ButtonItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEns As New frmEnseminaciones()
        With frmEns
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub
    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmRptParto As New frmReportePartos()
        With frmRptParto
            Me.AddOwnedForm(frmRptParto)
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub RepPartosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepPartosToolStripMenuItem.Click
        Dim frmRptParto As New frmReportePartos()
        With frmRptParto
            Me.AddOwnedForm(frmRptParto)
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmReemplazo()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub RegDestazoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmDestazo()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub RegRastroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmRastro()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub RegEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New FrmEntradas()
        Me.AddOwnedForm(x)
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub ButtonItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frmSalidas As New frmRegSalidas()
        'With frmSalidas
        '    .WindowState = FormWindowState.Normal
        '    .MdiParent = Me
        '    .Show() 
        'End With
        With My.Forms.frmRegSalidas
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub RegSálidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmSalidas As New frmRegSalidas()
        With frmSalidas
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.frmCargaCompras.MdiParent = Me
        My.Forms.frmCargaCompras.txtUserCreador.Text = Me.lbUsuario.Text
        My.Forms.frmCargaCompras.WindowState = FormWindowState.Maximized
        My.Forms.frmCargaCompras.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Actualizar_control_de_Inicio_session()
        Dim x As New Login()
        Me.AddOwnedForm(x)
        x.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.hijos = 0
        Dim resp As New MsgBoxResult
        For Each frm As Form In MdiChildren
            hijos += 1
        Next
        If hijos >= 1 Then
            If hijos = 1 Then
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventana abierta, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()

                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                End If
            Else
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventanas abiertas, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()
                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                End If
            End If
        Else
            Me.Actualizar_control_de_Inicio_session()
            End
        End If
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MosaicoVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MosaicoHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub CerrarTodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
    End Sub

    Private Sub ButtonItem54_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With My.Forms.frmRegistrar_Parto
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmMedicamento As New frmRegMedicamentos()
        With frmMedicamento
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub NuevoMedicamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmMedicamento As New frmRegMedicamentos()
        With frmMedicamento
            .MdiParent = Me
            .Show()
        End With
    End Sub

    'Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim frmBodega As New frmAddBodega()
    '    'With frmBodega
    '    '    .MdiParent = Me
    '    '    .Show()
    '    'End With

    'End Sub

    'Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
    '    With My.Forms.frmCambiar_estado_cerda_lactando_a_vacia
    '        .MdiParent = Me
    '        .WindowState = FormWindowState.Normal
    '        .Show()
    '    End With
    'End Sub

    Private Sub ButtonItem33_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem119_Click(sender, e)
    End Sub

    Private Sub ButtonItem35_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem46_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem38_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem10_Click(sender, e)
    End Sub

    Private Sub ButtonItem45_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem11_Click(sender, e)
    End Sub

    'Private Sub ButtonItem46_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem46.Click
    '    ButtonItem77_Click(sender, e)
    'End Sub

    Private Sub ButtonItem47_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ButtonItem7_Click(sender, e)
    End Sub

    Private Sub ButtonItem48_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem20_Click(sender, e)
    End Sub

    Private Sub ButtonItem49_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem49.Click
        ButtonItem21_Click(sender, e)
    End Sub

    Private Sub ButtonItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem30_Click(sender, e)
    End Sub

    Private Sub ButtonItem51_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem31_Click(sender, e)
    End Sub

    Private Sub ButtonItem52_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem32_Click(sender, e)
    End Sub

    Private Sub ButtonItem53_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem54_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem34_Click(sender, e)
    End Sub

    Private Sub ButtonItem72_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem28_Click(sender, e)
    End Sub

    Private Sub ButtonItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem12_Click(sender, e)
    End Sub

    Private Sub ButtonItem74_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem14_Click(sender, e)
    End Sub

    Private Sub ButtonItem75_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem15_Click(sender, e)
    End Sub

    Private Sub ButtonItem76_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem3_Click(sender, e)
    End Sub



    'Private Sub ButtonItem78_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem78.Click

    'End Sub

    Private Sub ButtonItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        ButtonItem53_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With My.Forms.frmRevertirCompra
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        ButtonItem16_Click_1(sender, e)
    End Sub

    'Private Sub ButtonItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click


    'End Sub

    'Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
    '    With My.Forms.frmPre_Enseminacion
    '        .MdiParent = Me
    '        .WindowState = FormWindowState.Maximized
    '        .Show()
    '    End With
    'End Sub

    Private Sub ButtonItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBoxEx.Show("Se Actualizarón los Lotes exitosamente", "Actualización Lotes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonItem22_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        With My.Forms.frmConsulta_Estado_Lotes
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With My.Forms.frmTraslados_entre_granjas
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub NUEVAGRANJAToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVAGRANJAToolStripMenuItem1.Click
        ButtonItem46_Click_1(sender, e)
    End Sub

    Private Sub NUEVABODEGAToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVABODEGAToolStripMenuItem1.Click
        ButtonItem119_Click(sender, e)
    End Sub

    Private Sub ACTUALIZARINVENTARIOToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTUALIZARINVENTARIOToolStripMenuItem1.Click
        ButtonItem18_Click(sender, e)
    End Sub

    Private Sub REGABUELASToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGABUELASToolStripMenuItem2.Click
        ButtonItem11_Click(sender, e)
    End Sub

    Private Sub REGMADRESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGMADRESToolStripMenuItem.Click
        ButtonItem10_Click(sender, e)
    End Sub

    Private Sub PREINSEMINACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PREINSEMINACIONToolStripMenuItem.Click
        ButtonItem116_Click(sender, e)
    End Sub

    Private Sub REGDEINSEMINACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGDEINSEMINACIONToolStripMenuItem.Click
        ButtonItem77_Click(sender, e)
    End Sub

    Private Sub REGPARTOSToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGPARTOSToolStripMenuItem2.Click
        ButtonItem53_Click_1(sender, e)
    End Sub

    Private Sub CREARLOTEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CREARLOTEToolStripMenuItem1.Click
        ButtonItem20_Click(sender, e)
    End Sub

    Private Sub ACTUALIZARLOTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTUALIZARLOTESToolStripMenuItem.Click
        ButtonItem19_Click_1(sender, e)
    End Sub

    Private Sub REGTRASLADOSENTRELOTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGTRASLADOSENTRELOTESToolStripMenuItem.Click
        ButtonItem28_Click(sender, e)
    End Sub

    Private Sub REGTRASLADOSENTREGRANJASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGTRASLADOSENTREGRANJASToolStripMenuItem.Click
        ButtonItem23_Click_1(sender, e)
    End Sub

    Private Sub REGSALIDASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGSALIDASToolStripMenuItem.Click
        ButtonItem34_Click(sender, e)
    End Sub

    Private Sub NUEVOINGRESOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVOINGRESOToolStripMenuItem.Click
        ButtonItem12_Click(sender, e)
    End Sub

    Private Sub NUEVAREQUISICIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVAREQUISICIONToolStripMenuItem.Click
        ButtonItem14_Click(sender, e)
    End Sub

    Private Sub NUEVOCONCENTRADOOMEDICAMENTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVOCONCENTRADOOMEDICAMENTOToolStripMenuItem.Click
        ButtonItem15_Click(sender, e)
    End Sub

    Private Sub REPCONSUMOCANTIDADToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPCONSUMOCANTIDADToolStripMenuItem1.Click
        ButtonItem39_Click_1(sender, e)
    End Sub

    Private Sub REPCONSUMOCOSTOSToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPCONSUMOCOSTOSToolStripMenuItem2.Click
        ButtonItem40_Click_1(sender, e)
    End Sub

    Private Sub REPCONSUMOCANTIDADXLOTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPCONSUMOCANTIDADXLOTEToolStripMenuItem.Click
        ButtonItem41_Click_1(sender, e)
    End Sub

    Private Sub REPCONSUMOCOSTOSXLOTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPCONSUMOCOSTOSXLOTEToolStripMenuItem.Click
        ButtonItem42_Click_1(sender, e)
    End Sub

    Private Sub REPDETALLADOXLOTEToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPDETALLADOXLOTEToolStripMenuItem2.Click
        ButtonItem43_Click_1(sender, e)
    End Sub

    Private Sub REPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPToolStripMenuItem.Click
        ButtonItem44_Click_1(sender, e)
    End Sub

    Private Sub REPINSEMINACIONESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPINSEMINACIONESToolStripMenuItem.Click
        ButtonItem27_Click(sender, e)
    End Sub

    Private Sub REPPARTOSToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPPARTOSToolStripMenuItem2.Click
        ButtonItem2_Click(sender, e)
    End Sub

    Private Sub EXISTENCIASXBODEGAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXISTENCIASXBODEGAToolStripMenuItem.Click
        ButtonItem27_Click_1(sender, e)
    End Sub

    Private Sub ESTADOLOTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADOLOTESToolStripMenuItem.Click
        ButtonItem22_Click_1(sender, e)
    End Sub

    Private Sub CERRARSESSIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERRARSESSIONToolStripMenuItem.Click
        ButtonItem56_Click(sender, e)
    End Sub

    Private Sub SALIRDELSISTEMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRDELSISTEMAToolStripMenuItem.Click
        ButtonItem57_Click_1(sender, e)
    End Sub

    Private Sub CASCADAToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CASCADAToolStripMenuItem.Click
        ButtonItem57_Click(sender, e)
    End Sub

    Private Sub MOSAICOVERTICALToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOSAICOVERTICALToolStripMenuItem.Click
        ButtonItem58_Click(sender, e)
    End Sub

    Private Sub MOSAICOHORIZONTALToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOSAICOHORIZONTALToolStripMenuItem.Click
        ButtonItem59_Click(sender, e)
    End Sub

    Private Sub CERRARTODOToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERRARTODOToolStripMenuItem.Click
        ButtonItem60_Click(sender, e)
    End Sub

    Private Sub RESPALDARREGISTROSToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESPALDARREGISTROSToolStripMenuItem.Click
        ButtonItem37_Click_1(sender, e)
    End Sub
    Private Sub SUBIRRESPALDOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUBIRRESPALDOToolStripMenuItem.Click
        btnSubirRespaldos_Click(sender, e)
    End Sub
    Private Sub ComandoPrivilegios_Executed_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComandoPrivilegios.Executed

    End Sub

    Private Sub ButtonItem24_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With My.Forms.frmRegistrar_Verraco
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub REGVERRACOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGVERRACOSToolStripMenuItem.Click
        ButtonItem24_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem47_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem47.Click
        With My.Forms.frmResumenLote_Costo_Nacer_costo_Actual
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem50_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With My.Forms.frmConsolidados_Concentrados_lotes__
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem51_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem51.Click
        Try
            With My.Forms.frmEstado_actual_Cerdas
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ESTADOACTUALCERDASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADOACTUALCERDASToolStripMenuItem.Click
        ButtonItem51_Click_2(sender, e)
    End Sub

    Private Sub RESUMENLOTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESUMENLOTESToolStripMenuItem.Click
        ButtonItem47_Click_2(sender, e)
    End Sub

    Private Sub REPCONSOLIDADOSCONCENTRADOSENGORDEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPCONSOLIDADOSCONCENTRADOSENGORDEToolStripMenuItem.Click
        ButtonItem50_Click_1(sender, e)
    End Sub
    Private Sub ButtonItem52_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem52.Click
        With frmAnular_Requisicion
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem53_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem53.Click
        With frmDesempeñosCerdas
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub DESEMPEÑOCERDASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DESEMPEÑOCERDASToolStripMenuItem.Click
        ButtonItem53_Click_2(sender, e)
    End Sub

    Private Sub btnInyectarGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInyectarGastos.Click
        With frmRegistrar_Gastos_x_Mes
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub INYECTARGASTOSOPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INYECTARGASTOSOPToolStripMenuItem.Click
        btnInyectarGastos_Click(sender, e)
    End Sub

    Private Sub ButtonItem76_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem76.Click
        With frmNegar_Cerdas_antes_de_confirmar
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem79_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem79.Click
        With frmDonar_Cerdos_antes_de_Destetar
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub DONACIONESANTESDEDESTETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DONACIONESANTESDEDESTETEToolStripMenuItem.Click
        ButtonItem79_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem80_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem80.Click
        Dim frmCortes As New frmCorteDiario
        With frmCortes
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterParent
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem81.Click
        With frmRevisar_CierreLotes
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem82.Click
        Dim Rc As New frmRecalcular_Costos_Eg
        With Rc
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim frmResumen As New frmHistorico_Resumen_Cerdas
        With frmResumen
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim frmComparativo As New frmCompartivo_Hato
        With frmComparativo
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub RibbonBar2_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonBar2.ItemClick

    End Sub

    Private Sub ButtonItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Dim Recalcular As New frmRecalcular_x_FechaInicio
        With Recalcular
            .StartPosition = FormStartPosition.CenterParent
            .WindowState = FormWindowState.Normal
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        With My.Forms.frmCargar_costos_concentrados_de_excel
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem46_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonItem119_Click(sender, e)
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        ButtonItem24_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        ButtonItem11_Click(sender, e)
    End Sub

    Private Sub ButtonItem11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        ButtonItem10_Click(sender, e)
    End Sub

    Private Sub ButtonItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        ButtonItem15_Click(sender, e)
    End Sub

    Private Sub ButtonItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        ButtonItem16_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        ButtonItem52_Click_2(sender, e)
    End Sub

    Private Sub F_Rev_Fechas_Inicio_Engordes_ConsultaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.F_Rev_Fechas_Inicio_Engordes_ConsultaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsBDGRANJA)

    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.F_Rev_Fechas_Inicio_Engordes_ConsultaTableAdapter.Buscar(Me.DtsBDGRANJA.F_Rev_Fechas_Inicio_Engordes_Consulta, Me.txtLoteNo.Text, New System.Nullable(Of Date)(CType(FechaSistema, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtLoteNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoteNo.TextChanged
        BuscarToolStripButton_Click(sender, e)
    End Sub

    Private Sub SwitchButtonItem1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.CellEnter

        Try
            FechaTenia = Me.F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.CurrentRow.Cells(1).Value
            If Me.F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.Rows.Count > 0 Then
                Dim cmd As String = "select l.Lote_No ,l.Fecha_Creacion, g.Nombre, (select isnull((SUM(cantidad)),0) from LINEAS_DE_SALIDAS ls where ls.Lote_No = l.Lote_No) as [No. Salidas],(select isnull((tl.Total_Cerdos),0)  from Total_Cerdos_Lote tl where tl.Lote_No = l.Lote_No ) as [Existencia Actual],isnull(((select isnull((t.Peso_Vivo_Kg_Acumulado),0)  from tablaAlimenticiaLM80_HC40 t where DATEdiff (DAY,(select fd.Fecha  from Fecha_Dias_Desarrollo fd where fd.Lote_No = l.Lote_No  ),'" & FechaSistema & "') between t.Edad_Dias and t.Hasta_Dias )),0) as [Peso Promedio x Cerdo] " _
                              & " from LOTES l" _
                              & " join Granjas g on l.Codigo_Granja = g.Codigo_Granja" _
                              & " where l.IdEtapa_Cerdas ='E' and l.Lote_No = '" & RTrim(Me.F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.CurrentRow.Cells(0).Value) & "'"

                sql = New SqlCommand(cmd, con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    m_Lote = leer(0)
                    m_FechaCreacion = leer(1)
                    m_Granja = leer(2)
                    m_NoSalidas = leer(3)
                    m_Existencia = leer(4)
                    m_PesoProm_x_Cerdo = leer(5)
                End While
                con.Close()
                Me.txtFechaCreac.Text = m_FechaCreacion
                Me.txtGranja.Text = m_Granja.Substring(7, m_Granja.Length - 7)
                Me.txtNoSalidas.Text = m_NoSalidas
                Me.txtPesoProm.Text = m_PesoProm_x_Cerdo
                Me.txtExistencia.Text = m_Existencia

            End If


        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Private Sub F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.CellLeave
        Me.F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.EndEdit()
        If IsDate(Me.F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.Rows(e.RowIndex).Cells(1).Value) Then
            If FechaTenia <> Me.F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.Rows(e.RowIndex).Cells(1).Value Then
                Dim resp As MsgBoxResult
                resp = MessageBoxEx.Show("Ha realizado cambios en la fecha del lote: " & RTrim(Me.F_Rev_Fechas_Inicio_Engordes_ConsultaDataGridViewX.Rows(e.RowIndex).Cells(0).Value) & ", desea guardar los cambios", "Actualizar Fecha", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    F_Rev_Fechas_Inicio_Engordes_ConsultaBindingNavigatorSaveItem_Click(sender, e)
                    BuscarToolStripButton_Click(sender, e)
                End If
            Else
                BuscarToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        If Me.CheckBoxX1.CheckState = CheckState.Checked Then
            Me.ExpandableSplitter2.Expanded = True
        ElseIf Me.CheckBoxX1.CheckState = CheckState.Unchecked Then
            Me.ExpandableSplitter2.Expanded = False
        End If
    End Sub

    Private Sub ButtonItem20_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        ButtonItem23_Click_1(sender, e)
    End Sub

    Private Sub ButtonItem19_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click
        ButtonItem28_Click(sender, e)
    End Sub

    Private Sub ButtonItem21_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        ButtonItem34_Click(sender, e)
    End Sub
    Private Sub ButtonItem23_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        ButtonItem12_Click(sender, e)
    End Sub
    Private Sub ButtonItem24_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        ButtonItem14_Click(sender, e)
    End Sub
    Public Sub mostrapanelRapido(ByVal mostrar As Boolean)
        Configuraciones.Default.MostrarPanelRapido = mostrar
        Me.PanelEx1.Visible = mostrar
        My.MySettings.Default.Save()
    End Sub
    Public Sub SwitchButton1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SwitchButton1.ValueChanged
        mostrapanelRapido(Me.SwitchButton1.Value)
    End Sub
    Private Sub cbxCUnitario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCUnitario.SelectedIndexChanged
        My.Settings.CUnitario_Setting = Me.cbxCUnitario.SelectedItem.ToString
        My.Settings.Save()
        CUnitario = Me.cbxCUnitario.SelectedItem.ToString
    End Sub
    'Private Sub ButtonItem32_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem32.Click

    'End Sub

    'Private Sub ButtonItem31_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem31.Click

    'End Sub
    Private Sub lbFechaActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFechaActual.Click
        Try
            sql = New SqlCommand("select Fecha from Guia_de_Digitacion where Usuario='" & UsuarioSistema & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read

                FechaSistema = Format(leer(0), "dd/MM/yyyy")
            End While
            con.Close()
            Me.lbFechaActual.Text = Format(FechaSistema, "dd/MM/yyyy")
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al actualizar fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    'Private Sub ButtonItem28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem28.Click

    'End Sub

    Private Sub ButtonItem33_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem33.Click
        ButtonItem20_Click(sender, e)
    End Sub

    Private Sub ButtonItem34_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem34.Click
        With dlgBorrarLote
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem35_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem35.Click

        With frmRequisarBaseTablaEngordes
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Private Sub ButtonItem30_Click_1(sender As Object, e As EventArgs) Handles ButtonItem30.Click
        With frmDXVisorDashboard
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem36_Click_1(sender As Object, e As EventArgs) Handles ButtonItem36.Click
        With frmReporteKardex
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem38_Click_3(sender As Object, e As EventArgs) Handles ButtonItem38.Click
        With frmReporteKardexHatos
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub RibbonBar13_ItemClick(sender As Object, e As EventArgs) Handles RibbonBar13.ItemClick

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub RibbonControl1_ExpandedChanged(sender As Object, e As EventArgs) Handles RibbonControl1.ExpandedChanged
        My.MySettings.Default.RibbonExpanded = If(Me.RibbonControl1.Expanded = True, True, False)
        My.MySettings.Default.Save()
    End Sub

    Private Sub ButtonItem45_Click_2(sender As Object, e As EventArgs) Handles ButtonItem45.Click
        Dim frmInTraslados As New frmIngresoTraslados
        With frmInTraslados
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub
    Private Sub ButtonItem54_Click_2(sender As Object, e As EventArgs) Handles ButtonItem54.Click
        With frmSalidasFarmacos
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub ButtonItem55_Click_1(sender As Object, e As EventArgs) Handles ButtonItem55.Click
      
    End Sub

    Private Sub ButtonItem72_Click_2(sender As Object, e As EventArgs) Handles ButtonItem72.Click
        With frmReporteInventarioDiario
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem73_Click_1(sender As Object, e As EventArgs) Handles ButtonItem73.Click
        With frmReporteInventarioDiarioReprod
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ToastNotificationsManager1_Activated(sender As Object, e As DevExpress.XtraBars.ToastNotifications.ToastNotificationEventArgs) Handles ToastNotificationsManager1.Activated
        With frmNotificaciones
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub lbFechaActual_TextChanged(sender As Object, e As EventArgs) Handles lbFechaActual.TextChanged
        If IsDate(lbFechaActual) Then
            ActualizarAlertas(True)
        End If

    End Sub

   

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.PanelControl1.Size = New Size(Me.PanelControl1.Size.Width, 0)
    End Sub
    Sub mostrarnotificaciones()
        With frmNotificaciones
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
    Private Sub PanelControl1_Click(sender As Object, e As EventArgs) Handles PanelControl1.Click
        mostrarnotificaciones()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mostrarnotificaciones()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        mostrarnotificaciones()
    End Sub

    Private Sub ButtonItem74_Click_2(sender As Object, e As EventArgs) Handles ButtonItem74.Click
        With frmReporteLotes
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub ButtonItem75_Click_2(sender As Object, e As EventArgs) Handles ButtonItem75.Click

        With frmReporteUbicacionHatoReproductivo
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem77_Click_1(sender As Object, e As EventArgs) Handles ButtonItem77.Click
        With frmCambiarFechaDesarrolloEngordes
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem83_Click(sender As Object, e As EventArgs) Handles ButtonItem83.Click
        'With frmPesosCerdosProcesos
        '    .procesoComboBoxEx1.Text = ""
        '    .WindowState = FormWindowState.Maximized
        '    .MdiParent = Me
        '    .Show()
        'End With
    End Sub

    Private Sub ButtonItem84_Click(sender As Object, e As EventArgs) Handles ButtonItem84.Click
        With frmPesosCerdosProcesos
            .procesoComboBoxEx1.Text = "Partos"
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem85_Click(sender As Object, e As EventArgs) Handles ButtonItem85.Click
        With frmPesosDestetes_Subidas
            .procesoComboBoxEx1.Text = "Destete"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem88_Click(sender As Object, e As EventArgs) Handles ButtonItem88.Click
        With frmReportePesosProcesos

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem61_Click(sender As Object, e As EventArgs) Handles ButtonItem61.Click

    End Sub

    Private Sub ButtonItem89_Click(sender As Object, e As EventArgs) Handles ButtonItem89.Click
        With frmInventarioMaterialesEstado
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterParent
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem90_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem94_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub ButtonItem95_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem96_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem97_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem98_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem99_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem100_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem101_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem103_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ButtonItem104_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem106_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem107_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem108_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem109_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem110_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem111_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem112_Click(sender As Object, e As EventArgs) Handles ButtonItem112.Click
        With frmPesosDestetes_Subidas
            .procesoComboBoxEx1.Text = "Peso 49dias"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem113_Click(sender As Object, e As EventArgs) Handles ButtonItem113.Click
        With frmRegistrarSubidas_a_Partos
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem114_Click(sender As Object, e As EventArgs) Handles ButtonItem114.Click
        With frmNotaReingreso

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem116_Click(sender As Object, e As EventArgs) Handles ButtonItem116.Click
        With My.Forms.frmPre_Enseminacion
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem117_Click(sender As Object, e As EventArgs) Handles ButtonItem117.Click
        With frmRegistro_Inseminacion
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem118_Click(sender As Object, e As EventArgs) Handles ButtonItem118.Click
        With dlgRevision_Inseminaciones_Pendientes_Comprobadas
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem18_Click(sender As Object, e As EventArgs) Handles ButtonItem18.Click
        ActualizarExistencias()
        ActualizarLote()
        MessageBoxEx.Show("Se actualizarón existencias correctamente", "Actualizar Existencias", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonItem46_Click_1(sender As Object, e As EventArgs) Handles ButtonItem46.Click
        Dim frmGranja As New frmAddGranja()
        With frmGranja
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem119_Click(sender As Object, e As EventArgs) Handles ButtonItem119.Click
        With My.Forms.frmAddBodega
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem7_Click_1(sender As Object, e As EventArgs) Handles ButtonItem7.Click
        With My.Forms.frmRevicionDestetes
            .WindowState = FormWindowState.Normal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem8_Click_1(sender As Object, e As EventArgs) Handles ButtonItem8.Click
        Dim x As New frmIngreso_Cerdos_Comprados
        x.StartPosition = FormStartPosition.CenterScreen
        x.ShowDialog()
    End Sub

    Private Sub ButtonItem16_Click_2(sender As Object, e As EventArgs) Handles ButtonItem16.Click
        With frmSeleccionReemplazos
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonItem28_Click_1(sender As Object, e As EventArgs) Handles ButtonItem28.Click
        Dim x As New frmRespaldarReg()
        x.StartPosition = FormStartPosition.CenterScreen
        x.ShowDialog()
    End Sub

    Private Sub ButtonItem27_Click_1(sender As Object, e As EventArgs) Handles ButtonItem27.Click
        With My.Forms.frmConsulta_existencias_x_bodega
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ButtonItem43_Click_2(sender As Object, e As EventArgs) Handles ButtonItem43.Click
        With frmRepConsumoSemEngordePorLote
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem44_Click_2(sender As Object, e As EventArgs) Handles ButtonItem44.Click
        With frmRepConsumoSemEngorde
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem48_Click_2(sender As Object, e As EventArgs) Handles ButtonItem48.Click
        With frmRepComparativovsTablaSugerida
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem50_Click_2(sender As Object, e As EventArgs) Handles ButtonItem50.Click
        With frmRepConsolidadoExistencias
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem31_Click_1(sender As Object, e As EventArgs) Handles ButtonItem31.Click
        With frmReportePesosDestete
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem41_Click_2(sender As Object, e As EventArgs) Handles ButtonItem41.Click
        With frmReportePesosSubidaEngorde
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem78_Click_1(sender As Object, e As EventArgs) Handles ButtonItem78.Click
        With frmReportePesosPartos
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem90_Click_1(sender As Object, e As EventArgs) Handles ButtonItem90.Click
        With frmReportePartosAcumulado
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem92_Click(sender As Object, e As EventArgs) Handles ButtonItem92.Click
        With frmReporteControlDefuncionesSemana
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem93_Click(sender As Object, e As EventArgs) Handles ButtonItem93.Click
        With frmReportePartosPorCerdosNacidos
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem91_Click(sender As Object, e As EventArgs) Handles ButtonItem91.Click
        With frmReporteSalidasPorFecha
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem95_Click_1(sender As Object, e As EventArgs) Handles ButtonItem95.Click
        With frmReporteDefuncionesFaseSemanavb
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem96_Click_1(sender As Object, e As EventArgs) Handles ButtonItem96.Click
        With frmReporteDefuncionAcumuladaLoteFase
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem98_Click_1(sender As Object, e As EventArgs) Handles ButtonItem98.Click
        With frmReporteDestazosFaseSemana
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem99_Click_1(sender As Object, e As EventArgs) Handles ButtonItem99.Click
        With frmReporteDestazosLoteFase
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem40_Click_2(sender As Object, e As EventArgs) Handles ButtonItem40.Click
        With frmReporteCorteDiario
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem100_Click_1(sender As Object, e As EventArgs) Handles ButtonItem100.Click

    End Sub

    Private Sub ButtonItem101_Click_1(sender As Object, e As EventArgs) Handles ButtonItem101.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub ButtonItem102_Click(sender As Object, e As EventArgs) Handles ButtonItem102.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub ButtonItem103_Click_1(sender As Object, e As EventArgs) Handles ButtonItem103.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ButtonItem104_Click_1(sender As Object, e As EventArgs) Handles ButtonItem104.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
    End Sub

    Private Sub ButtonItem56_Click(sender As Object, e As EventArgs) Handles ButtonItem56.Click
        Me.Actualizar_control_de_Inicio_session()
        Dim x As New Login()
        Me.AddOwnedForm(x)
        x.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonItem57_Click_1(sender As Object, e As EventArgs) Handles ButtonItem57.Click
        Me.hijos = 0
        Dim resp As New MsgBoxResult
        For Each frm As Form In MdiChildren
            hijos += 1
        Next
        If hijos >= 1 Then
            If hijos = 1 Then
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventana abierta, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()

                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                End If
            Else
                resp = MessageBoxEx.Show("Realmente desea salir del Sistema, aun hay " & hijos & " ventanas abiertas, si no ha guardado podria perder la información", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    For Each frmC As Form In Me.MdiChildren
                        frmC.Close()
                    Next
                    Me.Actualizar_control_de_Inicio_session()
                    End
                End If
            End If
        Else
            Me.Actualizar_control_de_Inicio_session()
            End
        End If
    End Sub

    Private Sub ButtonItem25_Click(sender As Object, e As EventArgs) Handles ButtonItem25.Click
        With frmReporteDestetesActuales
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Private Sub SwitchButtonItem1_ValueChanged_1(sender As Object, e As EventArgs)
        My.MySettings.Default.CargarTablero = Me.SwitchButton1.Value
        My.MySettings.Default.Save()
    End Sub
    Sub cargartableroinformativo()
        Dim frmtablero As New frmTableroInformativo
        If Me.mostrarSiCheckBoxItem1.Checked = True Then

            With frmtablero
                .StartPosition = FormStartPosition.CenterScreen
                .WindowState = FormWindowState.Maximized
                .MdiParent = Me
                .Show()
            End With

        End If
    End Sub

    Private Sub mostrarSiCheckBoxItem1_Click(sender As Object, e As EventArgs) Handles mostrarSiCheckBoxItem1.Click
        If Me.mostrarSiCheckBoxItem1.Checked = True Then
            Me.mostrarNoCheckBoxItem2.Checked = False
            My.MySettings.Default.CargarTablero = True
            My.MySettings.Default.Save()
        End If
    End Sub

    Private Sub mostrarNoCheckBoxItem2_Click(sender As Object, e As EventArgs) Handles mostrarNoCheckBoxItem2.Click
        If Me.mostrarSiCheckBoxItem1.Checked = False Then
            Me.mostrarNoCheckBoxItem2.Checked = True
            My.MySettings.Default.CargarTablero = False
            My.MySettings.Default.Save()
        End If
    End Sub

    Private Sub ButtonItem26_Click(sender As Object, e As EventArgs) Handles ButtonItem26.Click
        With frmReporteMontasVigentes
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem58_Click_1(sender As Object, e As EventArgs) Handles ButtonItem58.Click
        With frmReporteEstadoActualCerdas_os
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem59_Click_1(sender As Object, e As EventArgs) Handles ButtonItem59.Click
        With frmReporteGraficoComparativoAlimentacion
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem60_Click_1(sender As Object, e As EventArgs) Handles ButtonItem60.Click
        With frmReporteGraficoComparativoAlimentacionPorFecha
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem105_Click(sender As Object, e As EventArgs)
        With frmReporteHistoricoDestetes
            .WindowState = FormWindowState.Maximized
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ButtonItem106_Click_1(sender As Object, e As EventArgs) Handles ButtonItem106.Click
        With frmReporteAlimDiariaLactanciaUnoDos

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem107_Click_1(sender As Object, e As EventArgs) Handles ButtonItem107.Click
        With frmRegistrarCelos

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem108_Click_1(sender As Object, e As EventArgs) Handles ButtonItem108.Click
        With frmReporteCelosCerdas

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem109_Click_1(sender As Object, e As EventArgs) Handles ButtonItem109.Click
        With frmReporteDefuncionesXMotivoSemanas
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem110_Click_1(sender As Object, e As EventArgs) Handles ButtonItem110.Click
        With frmReporteHembrasEsperandoDestete
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem111_Click_1(sender As Object, e As EventArgs) Handles ButtonItem111.Click
        With frmRptEdadVerracos
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem120_Click(sender As Object, e As EventArgs) Handles ButtonItem120.Click
        With frmReportePesosPartosIndividuales
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem121_Click(sender As Object, e As EventArgs) Handles ButtonItem121.Click
        With frmReportePesosDestetesIndividuales
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem122_Click(sender As Object, e As EventArgs) Handles ButtonItem122.Click
        With frmReportePesosSubidasEngordeIndividuales
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem123_Click(sender As Object, e As EventArgs) Handles ButtonItem123.Click
        With frmRepHistoricoCerdas
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem124_Click(sender As Object, e As EventArgs) Handles ButtonItem124.Click
        With frmReporteHistoricoDestetes
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem126_Click(sender As Object, e As EventArgs) Handles ButtonItem126.Click
        With frmRepHistoricoSubEngordes
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub RibbonTabItem2_Click(sender As Object, e As EventArgs) Handles RibbonTabItem2.Click

    End Sub

    Private Sub ButtonItem127_Click(sender As Object, e As EventArgs) Handles ButtonItem127.Click
        With frmReporteSalidasFarmacosPorEtapa
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem86_Click(sender As Object, e As EventArgs) Handles ButtonItem86.Click
        With frmPesosDestetes_Subidas
            .procesoComboBoxEx1.Text = "Subida Eng."
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ButtonItem87_Click(sender As Object, e As EventArgs) Handles ButtonItem87.Click
        With frmComandosSQL
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
End Class
