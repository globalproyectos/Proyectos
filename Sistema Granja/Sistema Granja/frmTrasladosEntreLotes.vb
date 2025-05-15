Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Public Class frmTrasladosEntreLotes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Codigo_Granja As String
    Dim NoTraslado As Integer
    Dim VerifCBXLotesDe, VerifCBXLotesA As Boolean
    Dim cerdosActuales As Integer
    Dim TipoLoteGestacion_De As String = ""
    Dim TipoLoteGestacion_A As String = ""
    Dim DeLoteEs As String
    Dim ALoteEs As String
    Dim SeleccionoDe As Boolean = False
    Dim NoVecesSeleccionoDe As Integer = 0
    Private Sub frmTrasladosEntreLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarGranjas()
        Me.txtFechaTraslado.Text = FechaSistema
    End Sub
    Sub CargarGranjas()
        Try
            Me.cbxGranjas.Items.Clear()
            sql = New SqlCommand("select * from Granjas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read

                Me.cbxGranjas.Items.Add(leer(1))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCostoTraslado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoTraslado.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Sub MostrarLotesEngorde()
        Try
            Me.cbxLotesDe.Items.Clear()
            Me.cbxLotesA.Items.Clear()
            sql = New SqlCommand("select Codigo_Granja FROM Granjas WHERE Nombre='" & Me.cbxGranjas.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.Codigo_Granja = leer(0)
            End While
            con.Close()
            sql = New SqlCommand("select * from LOTES WHERE Codigo_Granja='" & Me.Codigo_Granja & "' and (Estado='A' or Estado='F') and IdEtapa_Cerdas='E'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesDe.Items.Add(leer(0))
                Me.cbxLotesA.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al cargar lotes Engorde", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub MostrarLotesEngorde_y_Reemplazos()
        Try
            sql = New SqlCommand("select Codigo_Granja FROM Granjas WHERE Nombre='" & Me.cbxGranjas.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.Codigo_Granja = leer(0)
            End While
            con.Close()
            Me.cbxLotesDe.Items.Clear()
            Me.cbxLotesA.Items.Clear()
            sql = New SqlCommand("select * from LOTES WHERE Codigo_Granja='" & Me.Codigo_Granja & "' and (Estado='A' or Estado='F') and IdEtapa_Cerdas='E'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesDe.Items.Add(leer(0))

            End While
            con.Close()
            sql = New SqlCommand("select * from LOTES WHERE Codigo_Granja='" & Me.Codigo_Granja & "' and (Estado='A' or Estado='F') and IdEtapa_Cerdas='R'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesA.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al cargar lotes Engorde y Reemplazos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

        
    End Sub
    Public Sub MostrarLotes_Reemplazos_Vacias()
        Try
            sql = New SqlCommand("select Codigo_Granja FROM Granjas WHERE Nombre='" & Me.cbxGranjas.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.Codigo_Granja = leer(0)
            End While
            con.Close()
            Me.cbxLotesDe.Items.Clear()
            Me.cbxLotesA.Items.Clear()
            sql = New SqlCommand("select * from LOTES WHERE Codigo_Granja='" & Me.Codigo_Granja & "' and (Estado='A' or Estado='F') and IdEtapa_Cerdas='R'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesDe.Items.Add(leer(0))
            End While
            con.Close()
            sql = New SqlCommand("select * from LOTES WHERE Codigo_Granja='" & Me.Codigo_Granja & "' and (Estado='A' or Estado='F') and IdEtapa_Cerdas='V'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesA.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al cargar lotes Reemplazos y Vacias", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub MostrarLotesGestacion()
        Try
            sql = New SqlCommand("select Codigo_Granja FROM Granjas WHERE Nombre='" & Me.cbxGranjas.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.Codigo_Granja = leer(0)
            End While
            con.Close()
            Me.cbxLotesDe.Items.Clear()
            Me.cbxLotesA.Items.Clear()
            Dim cmd As String = "select distinct l.lote_no  from Lotes l where l.Estado  <>'T' and l.IdEtapa_Cerdas ='G' and l.Codigo_Granja='" & RTrim(Codigo_Granja) & "'"

            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesDe.Items.Add(leer(0))
                Me.cbxLotesA.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al cargar lotes Gestacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
       
    End Sub
 
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Sub Limpiar()
        Me.txtCantidad.Clear()
        Me.txtCostoTraslado.Clear()

    End Sub
    Sub Habilitar()
        If Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked Then
            Me.cbxGranjas.Enabled = True
            Me.txtCantidad.Enabled = True
            Me.txtCostoTraslado.Enabled = False
            Me.cbxLotesA.Enabled = True
            Me.cbxLotesDe.Enabled = True
            Me.btnGuardar.Enabled = True
        ElseIf Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Checked Then
            Me.cbxGranjas.Enabled = True
            Me.txtCantidad.Enabled = False
            Me.txtCostoTraslado.Enabled = False
            Me.cbxLotesA.Enabled = True
            Me.cbxLotesDe.Enabled = True
            Me.btnGuardar.Enabled = True
        ElseIf Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Checked Then
            Me.cbxGranjas.Enabled = True
            Me.txtCantidad.Enabled = False
            Me.txtCostoTraslado.Enabled = False
            Me.cbxLotesA.Enabled = True
            Me.cbxLotesDe.Enabled = True
            Me.btnGuardar.Enabled = True
        ElseIf Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then
            Me.cbxGranjas.Enabled = True
            Me.txtCantidad.Enabled = False
            Me.txtCostoTraslado.Enabled = False
            Me.cbxLotesA.Enabled = True
            Me.cbxLotesDe.Enabled = True
            Me.btnGuardar.Enabled = True
        End If
       
    End Sub
    Sub Deshabilitar()
        Me.cbxGranjas.Enabled = False
        Me.txtCantidad.Enabled = False
        Me.txtCostoTraslado.Enabled = False
        Me.cbxLotesA.Enabled = False
        Me.cbxLotesDe.Enabled = False
        Me.btnGuardar.Enabled = False
    End Sub
    Sub NoTrasladoAutatico()
        Try
            Correlativo_Auto("select MAX(No_Traslado) from TrasladosEntreLotes", Me.txtNoTraslado)
     
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.NoTrasladoAutatico()
        Me.btnNuevo.Enabled = False
        Me.Habilitar()
    End Sub
    Public Sub RegrearInicio()
        Me.Deshabilitar()
        Me.Limpiar()
        Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked
        Me.btnGuardar.Enabled = False
        Me.btnNuevo.Enabled = True
        If Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked Then
            Me.Limpiar()
            Me.MostrarLotesEngorde()
            Me.VerifCBXLotesA = False
            Me.VerifCBXLotesDe = False
        ElseIf Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Checked Then
            Me.Limpiar()
            Me.MostrarLotesEngorde_y_Reemplazos()
            Me.VerifCBXLotesA = False
            Me.VerifCBXLotesDe = False
        ElseIf Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Checked Then
            Me.Limpiar()
            MostrarLotes_Reemplazos_Vacias()
            Me.VerifCBXLotesA = False
            Me.VerifCBXLotesDe = False
        End If
    End Sub
    Private Sub cbxGranjas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxGranjas.SelectedIndexChanged
        If Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked Then
            Me.Limpiar()
            Me.MostrarLotesEngorde()
            Me.VerifCBXLotesA = False
            Me.VerifCBXLotesDe = False
        ElseIf Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Checked Then
            Me.Limpiar()
            Me.MostrarLotesEngorde_y_Reemplazos()
            Me.VerifCBXLotesA = False
            Me.VerifCBXLotesDe = False
        ElseIf Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Checked Then
            Me.Limpiar()
            MostrarLotes_Reemplazos_Vacias()
            Me.VerifCBXLotesA = False
            Me.VerifCBXLotesDe = False
        ElseIf Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then
            Me.Limpiar()
            Me.MostrarLotesGestacion()
            Me.VerifCBXLotesA = False
            Me.VerifCBXLotesDe = False
        End If
    End Sub
    Private Sub cbxLotesDe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesDe.SelectedIndexChanged
        NoVecesSeleccionoDe += 1
        Dim EstadoDe As String = "Gestando"
        Dim EstadoA As String = "Gestando"
        sql = New SqlCommand("select Estado_Actual from REG_MADRES where Lote_No='" & Me.cbxLotesDe.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            DeLoteEs = RTrim(leer(0))
        End While
        con.Close()
        VerifCBXLotesDe = True
        If NoVecesSeleccionoDe >= 2 Then
            If Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then
                If Me.cbxLotesDe.Text = Me.cbxLotesA.Text Then
                    MessageBoxEx.Show("Debe seleccionar un lote de gestación diferente, no puede realizar un traslado entre el mismo lote", "Error Lote", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Me.cbxLotesDe.Focus()
                    VerifCBXLotesDe = False
                    'ElseIf DeLoteEs <> ALoteEs Then
                    '    If DeLoteEs = "L" Then
                    '        EstadoDe = "Lactando"
                    '    ElseIf DeLoteEs = "G" Then
                    '        EstadoDe = "Gestando"
                    '    End If
                    '    If ALoteEs = "L" Then
                    '        EstadoA = "Lactando"
                    '    ElseIf ALoteEs = "G" Then
                    '        EstadoA = "Gestando"
                    '    End If
                    '    VerifCBXLotesDe = False
                    '    MessageBoxEx.Show("El Lote [De] que esta seleccionando es de diferente estado, el Lote: " & Me.cbxLotesDe.Text & " se encuentra: " & EstadoDe & ", mientras que el Lote: " & Me.cbxLotesA.Text & " se encuentra: " & EstadoA, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Me.cbxLotesDe.Focus()
                Else
                    Me.txtCantidad.Text = ""
                    Me.txtCostoTraslado.Text = "0.00"
                    Me.VerifCBXLotesDe = True
                End If
                'sql = New 
            Else
                Me.txtCantidad.Text = ""
                Me.txtCostoTraslado.Text = "0.00"
                Me.VerifCBXLotesDe = True
            End If
        End If
        
       
    End Sub
    Private Sub cbxLotesA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesA.SelectedIndexChanged
        Dim EstadoDe As String = "Gestando"
        Dim EstadoA As String = "Gestando"
        sql = New SqlCommand("select Estado_Actual from REG_MADRES where Lote_No='" & Me.cbxLotesA.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            ALoteEs = RTrim(leer(0))
        End While
        con.Close()
        If Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then

            If Me.cbxLotesA.Text = Me.cbxLotesDe.Text Then
                MessageBoxEx.Show("Debe seleccionar un lote de gestación diferente, no puede realizar un traslado entre el mismo lote", "Error Lote", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                VerifCBXLotesA = False
                Me.cbxLotesA.Focus()
                'ElseIf ALoteEs <> DeLoteEs Then
                '    If ALoteEs = "L" Then
                '        EstadoA = "Lactando"
                '    ElseIf ALoteEs = "G" Then
                '        EstadoA = "Gestando"
                '    End If
                '    If DeLoteEs = "L" Then
                '        EstadoDe = "Lactando"
                '    ElseIf DeLoteEs = "G" Then
                '        EstadoDe = "Gestando"
                '    End If
                '    VerifCBXLotesA = False
                '    MessageBoxEx.Show("El Lote [A] que esta seleccionando es de diferente estado, el Lote: " & Me.cbxLotesA.Text & " se encuentra: " & EstadoA & ", mientras que el Lote: " & Me.cbxLotesDe.Text & " se encuentra: " & EstadoDe, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Me.cbxLotesA.Focus()
            Else
                Me.txtCantidad.Text = ""
                Me.txtCostoTraslado.Text = "0.00"
                Me.VerifCBXLotesA = True
            End If
        Else
            Me.txtCantidad.Text = ""
            Me.txtCostoTraslado.Text = "0.00"
            Me.VerifCBXLotesA = True
        End If
    End Sub
    Sub GuardarTraslado()
        Try
            sql = New SqlCommand("insert into TrasladosEntreLotes values('" & Me.txtNoTraslado.Text & "','" & Me.cbxLotesDe.Text & "','" & Me.cbxLotesA.Text & "','" & Me.txtCantidad.Text & "','" & Me.txtCostoTraslado.Text & "','" & Me.txtFechaTraslado.Text & "','N/A')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub RegistrarTraslado()
        RegistrarMovimientoLote(Me.cbxLotesDe.Text, 0, 0, 0, 0, 0, Me.txtCantidad.Text, txtFechaTraslado.Text, "Tr." & Me.txtNoTraslado.Text)
        RegistrarMovimientoLote(Me.cbxLotesA.Text, 0, 0, 0, 0, Me.txtCantidad.Text, 0, Me.txtFechaTraslado.Text, "Tr." & Me.txtNoTraslado.Text)
        HalarCostos_Traslados(Me.cbxLotesDe.Text, Me.cbxLotesA.Text, txtFechaTraslado.Text, "TRASLADO DE CERDOS ENGORDE ENTRE LOTES", Me.txtCantidad.Text, "Tr." & Me.txtNoTraslado.Text)
        ActualizarLote()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked Then
            If Me.VerifCBXLotesDe = False Then
                MessageBoxEx.Show("No ha seleccionado el lote del que va realizar el traslado", "Traslados Entre Lotes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbxLotesDe.Focus()
            ElseIf Me.VerifCBXLotesA = False Then
                MessageBoxEx.Show("No ha seleccionado el lote al que va a trasladar los cerdos", "Traslados Entre Lotes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbxLotesA.Focus()
            ElseIf Me.txtCantidad.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la cantidad de cerdos que va a trasladar", "Traslados entre Lotes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCantidad.Focus()
            ElseIf Me.txtCostoTraslado.Text = "" Then
                MessageBoxEx.Show("No ha ingresado el costo del traslado", "Traslados entre Lotes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCostoTraslado.Focus()
            Else
                sql = New SqlCommand("select Total_Cerdos FROM Total_Cerdos_Lote WHERE Lote_No='" & Me.cbxLotesDe.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.cerdosActuales = leer(0)
                End While
                con.Close()
                If Me.cerdosActuales < Me.txtCantidad.Text Then
                    MessageBoxEx.Show("La cantidad que ha ingresado excede el número de cerdos actuales, la cantidad actual es: " & Me.cerdosActuales, "Solicitud de cerdos Excedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.GuardarTraslado()
                    Me.RegistrarTraslado()
                    ActualizarLote()
                    Me.Limpiar()
                    Me.Deshabilitar()
                    Me.btnNuevo.Enabled = True
                    Me.btnGuardar.Enabled = False

                End If
                'CODIGO GUARDAR AQUI!

            End If
        ElseIf Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Checked Then
            If Me.VerifCBXLotesA = False Then
                MessageBoxEx.Show("No ha seleccionado el lote donde se moverán l@s cerd@s", "Seleccione el Lote A", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.cbxLotesA.Focus()
            ElseIf VerifCBXLotesDe = False Then
                MessageBoxEx.Show("No ha seleccionado el lote de donde se obtendran l@s cerd@s", "Seleccione el Lote De", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.cbxLotesDe.Focus()
                'ElseIf Me.txtCantidad.Text = "" Or Me.txtCantidad.Text = "0" Then
                '    MessageBoxEx.Show("la cantidad de cerd@s que se moverán", "Ingrese la Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Me.txtCantidad.Focus()
            Else
                With My.Forms.dlgCodificarCerdasReemplazos
                    .DeLote = Me.cbxLotesDe.Text
                    .ALote = Me.cbxLotesA.Text
                    .NoTraslado = Me.txtNoTraslado.Text
                    '.Cantidad = Me.txtCantidad.Text
                    .CostoTotal = Me.txtCostoTraslado.Text
                    .FechaTraslado = Me.txtFechaTraslado.Text
                    RegrearInicio()
                    .ShowDialog()
                End With
            End If
        ElseIf Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Checked Then
            If Me.VerifCBXLotesA = False Then
                MessageBoxEx.Show("No ha seleccionado el lote donde se moverán l@s cerd@s", "Seleccione el Lote A", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.cbxLotesA.Focus()
            ElseIf VerifCBXLotesDe = False Then
                MessageBoxEx.Show("No ha seleccionado el lote de donde se obtendran l@s cerd@s", "Seleccione el Lote De", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.cbxLotesDe.Focus()
            Else
                With My.Forms.dlgTrasladar_de_Reemplazos_a_vacias
                    .DeLote = Me.cbxLotesDe.Text
                    .ALote = Me.cbxLotesA.Text
                    .NoTraslado = Me.txtNoTraslado.Text
                    '.Cantidad = Me.txtCantidad.Text
                    '.CostoTotal = Me.txtCostoTraslado.Text
                    .FechaTraslado = Me.txtFechaTraslado.Text
                    RegrearInicio()
                    .ShowDialog()
                End With

            End If
        ElseIf Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then
            If Me.VerifCBXLotesA = False Then
                MessageBoxEx.Show("No ha seleccionado el lote donde se moverán l@s cerd@s", "Seleccione el Lote A", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.cbxLotesA.Focus()
            ElseIf VerifCBXLotesDe = False Then
                MessageBoxEx.Show("No ha seleccionado el lote de donde se obtendran l@s cerd@s", "Seleccione el Lote De", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.cbxLotesDe.Focus()
            Else
                With My.Forms.frmTrasladar_de_Gestacion_a_Gestacion
                    .DeLote = Me.cbxLotesDe.Text
                    .ALote = Me.cbxLotesA.Text
                    .NoTraslado = Me.txtNoTraslado.Text
                    .FechaTraslado = Me.txtFechaTraslado.Text
                    RegrearInicio()
                    .ShowDialog()

                End With
            End If
           
        End If
    End Sub

    Private Sub txtCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.LostFocus
        If Me.txtCantidad.Text <> "" Then
            Dim CostoLoteMovimiento_Int As Double = 0
            Dim CostoRequisiciones As Double = 0
            Dim TotalCerdos As Integer = 0
            sql = New SqlCommand("SELECT Total_Cerdos  FROM Total_Cerdos_Lote  WHERE Lote_No ='" & Me.cbxLotesDe.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                TotalCerdos = leer(0)
            End While
            con.Close()
            sql = New SqlCommand("SELECT ISNULL((SUM(Costo)),0) FROM MOVIMIENTOS_LOTES_INT WHERE A_Lote ='" & Me.cbxLotesDe.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CostoLoteMovimiento_Int = leer(0)
            End While
            con.Close()
            sql = New SqlCommand("SELECT ISNULL((SUM(IMPORTE)),0) FROM LINEAS_DE_REQUISICIONES WHERE Lote_No ='" & Me.cbxLotesDe.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CostoRequisiciones = leer(0)
            End While
            con.Close()
            Me.txtCostoTraslado.Text = Math.Round((((CostoLoteMovimiento_Int + CostoRequisiciones) / TotalCerdos) * Val(Me.txtCantidad.Text)), 4)

        End If
    End Sub

   
    Private Sub chbxDeEngorde_a_Engorde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxDeEngorde_a_Engorde.CheckedChanged
        If Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
            Me.txtCantidad.Enabled = True
            Me.btnGuardar.Image = New System.Drawing.Bitmap(My.Resources.filesave)
            Me.btnGuardar.Text = "&Guardar Traslado"
        ElseIf Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
        End If
        cbxGranjas_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub chbxDeEngorde_a_Reemplazos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbxDeEngorde_a_Reemplazos.CheckedChanged
        If Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
            Me.txtCantidad.Enabled = False
            Me.btnGuardar.Image = New System.Drawing.Bitmap(My.Resources.agt_forward)
            Me.btnGuardar.Text = "&Códificar Cerdas"
        ElseIf Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
        End If
        cbxGranjas_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub chbxDeReemplazos_a_Vacias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxDeReemplazos_a_Vacias.CheckedChanged
        If Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
            Me.txtCantidad.Enabled = False
            Me.btnGuardar.Image = New System.Drawing.Bitmap(My.Resources.agt_forward)
            Me.btnGuardar.Text = "&Seleccionar Cerdas"
        ElseIf Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
        End If
        cbxGranjas_SelectedIndexChanged(sender, e)

    End Sub

    Public Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RegrearInicio()
    End Sub

  

    Private Sub chbxDeGestacion_a_Gestacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxDeGestacion_a_Gestacion.CheckedChanged
        If Me.chbxDeGestacion_a_Gestacion.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            Me.txtCantidad.Enabled = True
            Me.btnGuardar.Image = New System.Drawing.Bitmap(My.Resources.agt_forward)
            Me.btnGuardar.Text = "&Seleccionar Cerdas"
        ElseIf Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Unchecked
            chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        ElseIf Me.chbxDeReemplazos_a_Vacias.CheckState = CheckState.Checked Then
            Me.chbxDeEngorde_a_Engorde.CheckState = CheckState.Unchecked
            Me.chbxDeEngorde_a_Reemplazos.CheckState = CheckState.Unchecked
            chbxDeGestacion_a_Gestacion.CheckState = CheckState.Unchecked
        End If
    End Sub
End Class