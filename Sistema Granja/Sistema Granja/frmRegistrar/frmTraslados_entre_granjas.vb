Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmTraslados_entre_granjas
    Dim SeleccionoGranjaDe As Boolean = False
    Dim SeleccionoGranajaA As Boolean = False
    Dim SeleccionoLoteDe As Boolean = False
    Dim SeleccionoLoteA As Boolean = False
    Dim CodigoGranjaDe As String
    Dim CodigoGranjaA As String
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Sub NoTrasladoAuto()
        Try
            Correlativo_Auto("SELECT MAX(No_Traslado) from TrasladosEntreGranjas", Me.txtTrasladoNo)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar No Traslado Auto", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Sub MostrarGranjas()
        Try
            Me.cbxGranjasDe.Items.Clear()
            Me.cbxGranjasA.Items.Clear()
            sql = New SqlCommand("SELECT * FROM Granjas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxGranjasDe.Items.Add(leer(1))
                Me.cbxGranjasA.Items.Add(leer(1))
            End While

            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar Granjas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub frmTraslados_entre_granjas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.txtFecha.Text = Format(FechaSistema, "dd/MM/yy")
    End Sub
    Sub HabilitarCajas()
        Me.cbxGranjasDe.Enabled = True
        Me.cbxGranjasA.Enabled = True
        Me.txtCosto.Enabled = False
        Me.txtCantidad.Enabled = True
        Me.cbxALote.Enabled = True
        Me.cbxDeLote.Enabled = True
    End Sub
    Sub DeshabilitarCajas()
        Me.cbxGranjasDe.Enabled = False
        Me.cbxGranjasA.Enabled = False
        Me.txtCosto.Enabled = False
        Me.txtCantidad.Enabled = False
        Me.cbxALote.Enabled = False
        Me.cbxDeLote.Enabled = False
    End Sub
    Sub Limipiar()
        Me.txtCantidad.Text = ""
        Me.txtCosto.Text = "0.00"
        Me.MostrarGranjas()
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limipiar()
        HabilitarCajas()
        Me.cbxGranjasDe.Focus()
        NoTrasladoAuto()
        Me.MostrarGranjas()
        Me.btnGuardar.Enabled = True
        Me.btnNuevo.Enabled = False
    End Sub

    Private Sub cbxGranjasA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxGranjasA.SelectedIndexChanged
        SeleccionoGranajaA = True
        If Me.cbxGranjasA.Text = Me.cbxGranjasDe.Text Then
            MessageBoxEx.Show("No puede seleccionar la misma granja para realizar un traslado entre granjas", "Granjas Iguales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cbxGranjasA.Focus()
            SeleccionoGranajaA = False
        Else
            CodigoGranjaA = ""
            sql = New SqlCommand("SELECT Codigo_Granja FROM Granjas where Nombre='" & Me.cbxGranjasA.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CodigoGranjaA = leer(0)
            End While
            con.Close()
            If CodigoGranjaA <> "" Then
                Me.MostrarLotesA()
            End If
        End If
    End Sub
    Sub MostrarLotesDe()
        Try
            Me.cbxDeLote.Items.Clear()
            sql = New SqlCommand("SELECT Lote_No from LOTES WHERE Codigo_Granja='" & CodigoGranjaDe & "' and IdEtapa_Cerdas='E' and Estado<>'T'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxDeLote.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar Lotes De", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub MostrarLotesA()
        Try
            Me.cbxALote.Items.Clear()
            sql = New SqlCommand("SELECT Lote_No from LOTES WHERE Codigo_Granja='" & CodigoGranjaA & "' and IdEtapa_Cerdas='E' and Estado<>'T'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxALote.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar Lotes A", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub cbxGranjasDe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxGranjasDe.SelectedIndexChanged
        SeleccionoGranjaDe = True
        If Me.cbxGranjasA.Text = Me.cbxGranjasDe.Text Then
            MessageBoxEx.Show("No puede seleccionar la misma granja para realizar un traslado entre granjas", "Granjas Iguales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cbxGranjasDe.Focus()
            SeleccionoGranjaDe = False
        Else
            CodigoGranjaDe = ""
            sql = New SqlCommand("SELECT Codigo_Granja FROM Granjas where Nombre='" & Me.cbxGranjasDe.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CodigoGranjaDe = leer(0)
            End While
            con.Close()
            If CodigoGranjaDe <> "" Then
                MostrarLotesDe()
            End If
        End If
    End Sub

    Private Sub cbxDeLote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDeLote.SelectedIndexChanged
        SeleccionoLoteDe = True
    End Sub

    Private Sub cbxALote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxALote.SelectedIndexChanged
        SeleccionoLoteA = True
    End Sub
    Sub GrabarTraslado()
        Try
            sql = New SqlCommand("INSERT INTO TrasladosEntreGranjas VALUES('" & Me.txtTrasladoNo.Text & "','" & CodigoGranjaDe & "','" & CodigoGranjaA & "','" & Me.cbxDeLote.Text & "','" & Me.cbxALote.Text & "','" & Me.txtCosto.Text & "','" & Me.txtCantidad.Text & "','" & Me.txtFecha.Text & "','N/A')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            Dim CostoAlNacer As Double = 0
            sql = New SqlCommand("select isnull((sum(Costo_al_Nacer)),0) from Costos_al_Nacer_x_Lotes where Lote_No='" & Me.cbxDeLote.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CostoAlNacer = leer(0)
            End While
            con.Close()
            Dim NoEngorges As Integer = 0
            sql = New SqlCommand("select No_Cerdos from Costos_al_Nacer_x_Lotes where Lote_No='" & Me.cbxDeLote.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                NoEngorges = leer(0)
            End While
            con.Close()
            sql = New SqlCommand("if not exists(select Lote_No from Costos_al_Nacer_x_Lotes where lote_no='" & RTrim(cbxALote.Text) & "') insert into Costos_al_Nacer_x_Lotes values('" & Me.cbxALote.Text & "','" & CostoAlNacer & "','" & FechaSistema & "','Tg." & Me.txtTrasladoNo.Text & "','" & NoEngorges & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            
            Try
                Dim Fecha As Date
                Dim FechaSemanal As Date
                sql = New SqlCommand("select Fecha,Fecha_Semanal from Fecha_Dias_Desarrollo where Lote_No='" & Me.cbxDeLote.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Fecha = leer(0)
                    FechaSemanal = leer(1)
                End While
                con.Close()
                sql = New SqlCommand("if not exists(select Lote_No from Fecha_Dias_Desarrollo where lote_no='" & RTrim(cbxALote.Text) & "') insert into Fecha_Dias_Desarrollo(Lote_No,Fecha,Dias,Fecha_Semanal) values('" & Me.cbxALote.Text & "','" & Fecha & "','" & 0 & "','" & FechaSemanal & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
          
            RegistrarMovimientoLote(Me.cbxDeLote.Text, 0, 0, 0, 0, 0, Me.txtCantidad.Text, Me.txtFecha.Text, "Tg." & Me.txtTrasladoNo.Text)
            RegistrarMovimientoLote(Me.cbxALote.Text, 0, 0, 0, 0, Me.txtCantidad.Text, 0, Me.txtFecha.Text, "Tg." & Me.txtTrasladoNo.Text)
            HalarCostos_Traslados(Me.cbxDeLote.Text, Me.cbxALote.Text, Me.txtFecha.Text, "TRASLADO DE CERDOS ENTRE GRANJAS", Me.txtCantidad.Text, "Tg." & Me.txtTrasladoNo.Text)
            ActualizarLote()
            RevisarCierre_Lote(Me.cbxDeLote.Text, Me.cbxDeLote)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error Guardar Traslado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.SeleccionoGranjaDe = False Then
            MessageBoxEx.Show("No ha seleccionado la granja de donde se moverán los cerdos", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.cbxGranjasDe.Focus()
        ElseIf SeleccionoGranajaA = False Then
            MessageBoxEx.Show("No ha seleccionado la granja a done se moverán los cerdos", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.cbxGranjasA.Focus()
        ElseIf SeleccionoLoteDe = False Then
            MessageBoxEx.Show("No ha seleccionado el lote de donde se moverán los cerdos", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.cbxDeLote.Focus()
        ElseIf SeleccionoLoteA = False Then
            MessageBoxEx.Show("No ha seleccionado el lote a donde se moverán los cerdos", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.cbxALote.Focus()
        ElseIf Me.txtCantidad.Text = "0" Or Me.txtCantidad.Text = "" Then
            MessageBoxEx.Show("No ha ingresado la cantidad de cerdos que desea trasladar", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txtCantidad.Focus()
        ElseIf Not IsDate(Me.txtFecha.Text) Then
            MessageBoxEx.Show("la fecha que ha ingresado es incorrecta, porfavor verifique y vuelva a intentarlo", "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFecha.Focus()
        Else
            GrabarTraslado()
            Me.Limipiar()
            NoTrasladoAuto()
            Me.DeshabilitarCajas()
            Me.btnGuardar.Enabled = False
            Me.btnNuevo.Enabled = True
        End If
    End Sub

    Private Sub txtCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.LostFocus
        Dim CostoLoteMovimiento_Int As Double = 0
        Dim CostoRequisiciones As Double = 0
        Dim TotalCerdos As Integer = 0
        sql = New SqlCommand("SELECT Total_Cerdos  FROM Total_Cerdos_Lote  WHERE Lote_No ='" & Me.cbxDeLote.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            TotalCerdos = leer(0)
        End While
        con.Close()
        sql = New SqlCommand("SELECT ISNULL((SUM(Costo)),0) FROM MOVIMIENTOS_LOTES_INT WHERE A_Lote ='" & Me.cbxDeLote.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            CostoLoteMovimiento_Int = leer(0)
        End While
        con.Close()
        sql = New SqlCommand("SELECT ISNULL((SUM(IMPORTE)),0) FROM LINEAS_DE_REQUISICIONES WHERE Lote_No ='" & Me.cbxDeLote.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            CostoRequisiciones = leer(0)
        End While
        con.Close()
        Me.txtCosto.Text = Math.Round((((CostoLoteMovimiento_Int + CostoRequisiciones) / TotalCerdos) * Val(Me.txtCantidad.Text)), 4)
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

    
   
End Class