Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmEntradas
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim verif As Boolean = False
    Dim entrada As Integer
    Sub Lotes()
        Try
            sql = New SqlCommand("Select * from LOTES", con)
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
   
    Private Sub FrmEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Lotes()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtCantidaEntradas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidaEntradas.KeyPress
      If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCantidaEntradas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidaEntradas.TextChanged
        If Me.txtCantidaEntradas.TextLength <> 0 And IsNumeric(Me.txtCantidaEntradas.Text) Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub
    Sub Limpiar()
        Me.ListaLotes.Text = ""
        Me.txtCantidaEntradas.Clear()
        Me.txtCerdaMadres.Clear()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidarFechas(Me.txtFechaEntrada.Text) = False Then
            Me.txtFechaEntrada.SelectAll()
            Me.txtFechaEntrada.Focus()
        Else
            Try
                sql = New SqlCommand("Insert into MOVIMIENTO_LOTE (Lote_No , Reemplazos , Defuncion , Destazo , Rastro , Entrada , Salida ,Fecha_Movimiento ,Documento_NO) values('" & 0 & "', '" & 0 & "','" & 0 & "','" & 0 & "','" & Me.txtCantidaEntradas.Text & "','" & 0 & "','" & Me.txtFechaEntrada.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                ActualizarLote()
                Me.Limpiar()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                con.Close()
            End Try
        End If
       End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub txtFechaDestazo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaEntrada.GotFocus
        If Me.txtFechaEntrada.Text = "dd/mm/aa" Then
            Me.txtFechaEntrada.Clear()
        End If
    End Sub

    Private Sub txtFechaDestazo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaEntrada.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.txtFechaEntrada.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaEntrada.Text = Me.txtFechaEntrada.Text & "/"
            Me.txtFechaEntrada.SelectionStart = 4
        ElseIf Me.txtFechaEntrada.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaEntrada.Text = Me.txtFechaEntrada.Text & "/"
            Me.txtFechaEntrada.SelectionStart = 6
        End If
    End Sub

    Private Sub txtFechaDestazo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaEntrada.LostFocus
        If Me.txtFechaEntrada.Text = "" Then
            Me.txtFechaEntrada.Text = "dd/mm/aa"
        End If
    End Sub
End Class