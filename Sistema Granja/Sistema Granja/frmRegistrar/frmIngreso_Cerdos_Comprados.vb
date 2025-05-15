Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmIngreso_Cerdos_Comprados
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Sub MostrarGranjas()
        Try
            Me.cbxGranjas.Items.Clear()
            sql = New SqlCommand("select Nombre from Granjas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxGranjas.Items.Add(RTrim(leer(0)))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al mostrar granjas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub txtCostoTotal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoTotal.LostFocus
        If Me.txtCostoTotal.Text <> "" Then
            Me.txtCostoTotal.Text = Format(CDbl(Me.txtCostoTotal.Text), "###,###,#0.00")

        End If
    End Sub

    
    Private Sub frmIngreso_Cerdos_Comprados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarGranjas()
        Me.txtFechaIngreso.Text = Format(FechaSistema, "dd/MM/yy")
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If Me.cbxGranjas.Text = "" Then
            MessageBoxEx.Show("No ha seleccionado la Granja al que pertenceran los cerdos", "Sin Granja", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cbxGranjas.Focus()
        ElseIf Me.txtLote.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el lote al que enviará los cerdos", "Sin lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtLote.Focus()
        ElseIf Me.txtCantidad.Value = 0 Then
            MessageBoxEx.Show("No ha ingresado la cantidad de cerdos a los que se les dara ingreso", "Sin cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtCantidad.Focus()
        ElseIf Me.txtCostoTotal.Text = "0.00" Or Me.txtCostoTotal.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el costo total de los cerdos", "Sin costo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtCostoTotal.Focus()
        ElseIf Me.txtEdadDias.Value = 0 Then
            MessageBoxEx.Show("No ha ingresado la edad de los cerdos en dias", "Sin edad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtEdadDias.Focus()
        ElseIf Not IsDate(Me.txtFechaIngreso.Text) Then
            MessageBoxEx.Show("La fecha que ha ingresado es erronea", "Fecha no válidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaIngreso.Focus()
        Else
            Dim existelote As Boolean = False
            Try
                sql = New SqlCommand("select Lote_No from lotes where Lote_No='" & RTrim(Me.txtLote.Text) & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    existelote = True
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            If existelote = True Then
                MessageBoxEx.Show("El lote " & RTrim(Me.txtLote.Text) & " ya existe favor verificarlo", "Lote ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtLote.Focus()
            Else
                Dim codgranja As String = ""
                sql = New SqlCommand("select Codigo_Granja from Granjas where Nombre ='" & RTrim(Me.cbxGranjas.Text) & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    codgranja = RTrim(leer(0))
                End While
                con.Close()
                Try
                    sql = New SqlCommand("Ingreso_LotesComprados", con)
                    sql.CommandType = CommandType.StoredProcedure
                    sql.Parameters.Add(New SqlParameter("@Granja", SqlDbType.Char, 8)).Value = codgranja
                    sql.Parameters.Add(New SqlParameter("@loteno", SqlDbType.Char, 8)).Value = RTrim(Me.txtLote.Text)
                    sql.Parameters.Add(New SqlParameter("@Documento", SqlDbType.Char, 12)).Value = RTrim(Me.txtDocumento.Text)
                    sql.Parameters.Add(New SqlParameter("@Cantidad", SqlDbType.Int)).Value = RTrim(Me.txtCantidad.Text)
                    sql.Parameters.Add(New SqlParameter("@CostoTotal", SqlDbType.Float)).Value = RTrim(Me.txtCostoTotal.Text)
                    sql.Parameters.Add(New SqlParameter("@edaddias_ingreso", SqlDbType.Int)).Value = RTrim(Me.txtEdadDias.Text)
                    sql.Parameters.Add(New SqlParameter("@fechadigitacion", SqlDbType.DateTime)).Value = RTrim(Me.txtFechaIngreso.Text)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    MessageBoxEx.Show("Se grabo el ingreso exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "Error al grabar ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                End Try
            End If

        End If


        
    End Sub

    Private Sub txtLote_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLote.LostFocus
        Me.txtLote.Text = UCase(Me.txtLote.Text)
    End Sub

    Private Sub txtDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDocumento.LostFocus
        Me.txtDocumento.Text = UCase(Me.txtDocumento.Text)
    End Sub

    Private Sub txtFechaIngreso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaIngreso.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 47 And Not Asc(e.KeyChar) = 46 And Not Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If txtFechaIngreso.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            txtFechaIngreso.Text = txtFechaIngreso.Text & "/"
            txtFechaIngreso.SelectionStart = 4
        ElseIf txtFechaIngreso.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            txtFechaIngreso.Text = txtFechaIngreso.Text & "/"
            txtFechaIngreso.SelectionStart = 6
        End If
    End Sub

  
End Class