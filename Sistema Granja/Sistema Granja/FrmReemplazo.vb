Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmReemplazo
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim verif As Boolean = False
    Dim reemp As Integer
    Dim CantidadCerdosActual As Integer
    Dim Mover_a_Lote As Integer
    Dim Selecciono_Movimiento As Boolean
    Sub lote_No()
        Try
            sql = New SqlCommand("select * from LOTES WHERE (Estado='A' OR Estado='F') and Descripcion=''", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.ListaLotes.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub FrmReemplazo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lote_No()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtCantidaReemp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidaReemp.KeyPress
      If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidaReemp.TextChanged
        If Me.txtCantidaReemp.TextLength <> 0 And IsNumeric(Me.txtCantidaReemp.Text) Then
            Me.ButtonX1.Enabled = True
        Else
            Me.ButtonX1.Enabled = False
        End If
    End Sub
    Sub Limpiar()
        Me.ListaLotes.Text = ""
        Me.txtCantidaReemp.Clear()
        Me.txtMotivo.Clear()
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If ValidarFechas(Me.CajaFecha1.txtFecha.Text) = False Then
            Me.CajaFecha1.txtFecha.SelectAll()
            Me.CajaFecha1.txtFecha.Focus()
        Else
            Try
                Dim sql2 As SqlCommand

                sql = New SqlCommand("Insert into MOVIMIENTO_LOTE (Lote_No , Reemplazos , Defuncion , Destazo , Rastro , Entrada , Salida ,Fecha_Movimiento ,Documento_NO) values('" & Me.txtCantidaReemp.Text & "', '" & 0 & "','" & 0 & "','" & 0 & "','" & 0 & "','" & 0 & "','" & Me.CajaFecha1.txtFecha.Text & "')", con)
                sql2 = New SqlCommand("Select Total_Cerdos from Total_Cerdos_Lote where Lote_No='" & Me.ListaLotes.Text & "'", con)
                con.Open()
                leer = sql2.ExecuteReader
                While leer.Read
                    CantidadCerdosActual = leer(0)
                End While
                con.Close()
                'sql2 = New SqlCommand("UPDATE Total_Cerdos_Lote SET Total_Cerdos='" & (CantidadCerdosActual - Val(Me.txtCantidaReemp.Text)) & "', Fecha_Ultima_Modificación='" & FechaSistema & "' WHERE Lote_No='" & Me.ListaLotes.Text & "'", con)

                If CantidadCerdosActual < Me.txtCantidaReemp.Text Then
                    MessageBoxEx.Show("La Cantidad de cerdos que ha ingresado excede el Total de Cerdos actual, La cantidad actual es: " & CantidadCerdosActual, "Ingresar Reemplazos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Me.Selecciono_Movimiento = False Then
                    MessageBoxEx.Show("No ha seleccionado a donde va a mover los cerdos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.cbxMovimientos.Focus()
                Else
                    con.Open()
                    sql.ExecuteNonQuery()
                    'sql2.ExecuteNonQuery()
                    con.Close()
                    sql = New SqlCommand("Insert into MOVIMIENTO_LOTE (Lote_No , Reemplazos , Defuncion , Destazo , Rastro , Entrada , Salida ,Fecha_Movimiento ,Documento_NO) values('" & 0 & "', '" & 0 & "','" & 0 & "','" & 0 & "','" & Me.txtCantidaReemp.Text & "','" & 0 & "','" & Me.CajaFecha1.txtFecha.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    sql = New SqlCommand("insert into MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) values('" & Me.Mover_a_Lote & "','" & Me.CajaFecha1.txtFecha.Text & "','" & Me.txtMotivo.Text & "','" & Me.txtCantidaReemp.Text & "','" & Me.Label1.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    ActualizarLote()
                    Me.Limpiar()
                End If
            Catch ex1 As System.Data.SqlClient.SqlException
                MessageBoxEx.Show(ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show("Se ha producido el siguiente error: " & ex.Message, "Error al guardar reemplazos")
                con.Close()
            End Try
        End If
       
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()

    End Sub

    Private Sub txtFechaRastro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.CajaFecha1.txtFecha.Text = "dd/mm/aa" Then
            Me.CajaFecha1.txtFecha.Clear()
        End If
    End Sub

    Private Sub txtFechaRastro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.CajaFecha1.txtFecha.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.CajaFecha1.txtFecha.Text = Me.CajaFecha1.txtFecha.Text & "/"
            Me.CajaFecha1.txtFecha.SelectionStart = 4
        ElseIf Me.CajaFecha1.txtFecha.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.CajaFecha1.txtFecha.Text = Me.CajaFecha1.txtFecha.Text & "/"
            Me.CajaFecha1.txtFecha.SelectionStart = 6
        End If
    End Sub
    Private Sub cbxMovimientos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMovimientos.SelectedIndexChanged
        Me.Selecciono_Movimiento = True
        If Me.cbxMovimientos.SelectedItem.ToString = "Reemplazos" Then
            Me.Mover_a_Lote = 1
        ElseIf Me.cbxMovimientos.SelectedItem.ToString = "Lactando" Then
            Me.Mover_a_Lote = 2
        ElseIf Me.cbxMovimientos.SelectedItem.ToString = "Gestando" Then
            Me.Mover_a_Lote = 3
        ElseIf Me.cbxMovimientos.SelectedItem.ToString = "Verracos" Then
            Me.Mover_a_Lote = 4

        End If
    End Sub
    Private Sub txtMotivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMotivo.TextChanged
        Me.txtMotivo.Text = UCase(Me.txtMotivo.Text)
        Me.txtMotivo.SelectionStart = 60
    End Sub
End Class