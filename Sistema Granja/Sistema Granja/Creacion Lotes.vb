Imports System.Data
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class Creacion_Lotes
    Inherits DevComponents.DotNetBar.Office2007Form

    Dim odtsAlimentacion As New dtsAlimentacionBaseTabla
    Dim lotesAdapter As New dtsAlimentacionBaseTablaTableAdapters.LotesTableAdapter
    Dim Descr As String

    Private Sub Creacion_Lotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.txtCerdosNacidos.Text = "" Then
            Me.btnGuardar.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
        End If
    End Sub
    Sub Mostrar_Etapas_Cerda_Lote()
       
    End Sub
    Sub No_Lote_Automatico()
        Dim año As String
        año = FechaSistema.Year
        año = año.Substring(2, 2)
        Me.txtLoteNo.Text = año & Format(System.DateTime.Now.DayOfYear / 7, "##00") & Format(FechaSistema.Day, "00")
        'Try
        '    sql = New SqlCommand("select MAX(Lote_No) from LOTES", con)
        '    con.Open()
        '    leer = sql.ExecuteReader
        '    While leer.Read
        '        If leer.IsDBNull(0) = True Then
        '            Me.txtLoteNo.Text = "1"
        '        Else
        '            Me.txtLoteNo.Text = leer(0) + 1
        '        End If
        '    End While
        '    con.Close()
        '    Me.txtCerdosNacidos.Focus()
        'Catch ex As Exception
        '    MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    con.Close()
        'End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Sub limpiar_cajas()
        Me.txtLoteNo.Clear()
        Me.txtIdEtapa_Cerda.Clear()
        Me.txtDescricpionMov.Clear()
        Me.lotedestinoTextBoxX1.Clear()
    End Sub
    Sub guardar_lote()
        Try
            Dim existelote As Boolean = False
            sql = New SqlCommand("select Lote_No from lotes where Lote_No='" & RTrim(Me.txtLoteNo.Text) & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                existelote = True
            End While
            con.Close()
            If existelote = True Then
                MessageBoxEx.Show("El lote que ha ingresado ya existe favor verificar", "Error Lote ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtLoteNo.Focus()
            Else
                Dim sql2 As SqlCommand
                Dim Estado As String
                If Me.txtIdEtapa_Cerda.Text = "V" Then
                    Estado = "F"
                Else
                    Estado = "A"
                End If
                sql = New SqlCommand("insert into LOTES values('" & Me.txtLoteNo.Text & "','" & Me.CajaFecha1.txtFecha.Text & "','" & Me.txtCerdosNacidos.Text & "','','" & GranjaNo_ListaLotes & "','','" & Estado & "','" & Me.txtIdEtapa_Cerda.Text & "','" & Me.lotedestinoTextBoxX1.Text & "')", con)
                sql2 = New SqlCommand("Insert into Total_Cerdos_Lote values('" & Me.txtLoteNo.Text & "','" & Me.txtCerdosNacidos.Text & "','" & Me.CajaFecha1.txtFecha.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                con.Open()
                sql2.ExecuteNonQuery()
                con.Close()
                If RTrim(Me.txtDescricpionMov.Text) <> "E" And RTrim(GranjaNo_ListaLotes) <> "ZPT001" Then
                    sql = New SqlCommand("insert into Fecha_Dias_Desarrollo values('" & Me.txtLoteNo.Text & "','" & Me.CajaFecha1.txtFecha.Text & "','" & 0 & "','01/01/1901')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                End If

                Me.limpiar_cajas()
                Me.deshabilitar_cajas()
                Me.btnCrearLote.Enabled = True
                Me.btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtLoteNo.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el numero del lote", "Lote No", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtLoteNo.Focus()
        ElseIf Me.txtCerdosNacidos.Text = "" Then
            MessageBoxEx.Show("No ha ingresado la cantidad de cerdos, que pertencerán al lote", "Creación de Lotes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtCerdosNacidos.Focus()
        ElseIf ValidarFechas(Me.CajaFecha1.txtFecha.Text) = False Then
            Me.CajaFecha1.txtFecha.Focus()
        ElseIf SeleccionoGranja = False Then
            MessageBoxEx.Show("No ha seleccionado la granja al que va a pertencer el lote", "Seleccion de Granjas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.ListaGranjas1.CbxGranjas.Focus()
        ElseIf Me.txtIdEtapa_Cerda.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el mov de el lote", "Mov. Lotes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtIdEtapa_Cerda.Focus()
        ElseIf Me.txtIdEtapa_Cerda.Text = "G" And RTrim(Me.lotedestinoTextBoxX1.Text) = "" Then
            MessageBoxEx.Show("Debe especificar el lote de destino, en este caso seria el lote de engorde en el cual se destetarán los cerdos", "Lote Destino", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.lotedestinoTextBoxX1.Focus()
        ElseIf Me.txtIdEtapa_Cerda.Text = "G" And RTrim(Me.lotedestinoTextBoxX1.Text) <> "" And lotesAdapter.GetConteoMovimientosLote(Me.lotedestinoTextBoxX1.Text) > 0 Then
            MessageBoxEx.Show("El lote destino que ha ingresado ya tiene movimientos, debe especificar uno que no tenga ningún movimiento", "Lote Destino", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.lotedestinoTextBoxX1.Focus()
        Else

            Me.guardar_lote()
        End If
    End Sub
  Sub habilitar_cajas()
        Me.txtLoteNo.Enabled = True
        Me.CajaFecha1.Enabled = True
        'Me.txtCerdosNacidos.Enabled = True
        Me.ListaGranjas1.Enabled = True
        Me.txtIdEtapa_Cerda.Enabled = True

    End Sub
    Sub deshabilitar_cajas()
        Me.txtLoteNo.Enabled = False
        Me.CajaFecha1.Enabled = False
        'Me.txtCerdosNacidos.Enabled = False
        Me.ListaGranjas1.Enabled = False
        Me.txtIdEtapa_Cerda.Enabled = False

    End Sub
    Private Sub btnCrearLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearLote.Click
        Me.No_Lote_Automatico()
        Me.txtLoteNo.Focus()
        Me.btnCrearLote.Enabled = False
        Me.habilitar_cajas()
    End Sub

    Private Sub txtCerdosNacidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCerdosNacidos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.txtCerdosNacidos.Text <> "" Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub txtIdEtapa_Cerda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdEtapa_Cerda.KeyDown
        If e.KeyCode = Keys.F5 Then
            With My.Forms.dlgMov_del_Lote
                .txtDescripcion.Focus()
                .txtDescripcion.Text = ""
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub txtIdEtapa_Cerda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdEtapa_Cerda.LostFocus
        If Me.txtIdEtapa_Cerda.Text <> "" Then
            Try
                Dim Existe As Boolean = False
                sql = New SqlCommand("select Descripcion from Etapas_Cerdas_Lote where IdEtapa_Cerdas='" & Me.txtIdEtapa_Cerda.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Existe = True
                    Me.Descr = leer(0).ToString
                End While
                con.Close()
                If Existe = False Then
                    MessageBoxEx.Show("No hay ninguna etapa con el ID: " & Me.txtIdEtapa_Cerda.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtIdEtapa_Cerda.Text = ""
                    Me.txtDescricpionMov.Text = ""
                    Me.txtIdEtapa_Cerda.Focus()
                    Me.btnGuardar.Enabled = False
                Else

                    Me.txtDescricpionMov.Text = Descr
                    Me.btnGuardar.Enabled = True
                End If
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
        If RTrim(Me.txtIdEtapa_Cerda.Text) = "E" Then
            Me.ListaGranjas1.CbxGranjas.SelectedIndex = 1
        Else
            Me.ListaGranjas1.CbxGranjas.SelectedIndex = 0
        End If
        If RTrim(Me.txtIdEtapa_Cerda.Text) = "G" Then
            Me.lotedestinoTextBoxX1.Enabled = True
        Else
            Me.lotedestinoTextBoxX1.Enabled = False
        End If
    End Sub

    Private Sub txtIdEtapa_Cerda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdEtapa_Cerda.TextChanged
        Me.txtIdEtapa_Cerda.Text = UCase(Me.txtIdEtapa_Cerda.Text)
        Me.txtIdEtapa_Cerda.SelectionStart = 4
    End Sub

   

   
End Class