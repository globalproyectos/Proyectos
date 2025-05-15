Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmRastro
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim causa As String
    Dim CantidadCerdosActual As Integer
    Dim Tipo_Doc As String
    Dim Selecciono_TipoDoc As Boolean
    Sub lote_No()
        Try
            sql = New SqlCommand("select * from LOTES where Estado='A' or Estado='F'", con)
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
    Private Sub FrmRastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lote_No()
    End Sub
    Sub limpiar()
        Me.ListaLotes.Text = ""
        Me.txtCantidadRastro.Clear()
        Me.txtNoDocumento.TextBoxX1.Text = "0"
        Me.txtPeso.TextBoxX1.Text = "0.00"
        Me.cbxDestino.Text = ""
        Me.txtJustificacion.Text = ""
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidarFechas(Me.txtFechaRastro.Text) = False Then
            Me.txtFechaRastro.SelectAll()
            Me.txtFechaRastro.Focus()
        Else
            Try
                sql2 = New SqlCommand("Select Total_Cerdos from Total_Cerdos_Lote where Lote_No='" & Me.ListaLotes.Text & "'", con)
                con.Open()
                leer = sql2.ExecuteReader
                While leer.Read
                    CantidadCerdosActual = leer(0)
                End While
                con.Close()

                If CantidadCerdosActual < Me.txtCantidadRastro.Text Then
                    MessageBoxEx.Show("La Cantidad de cerdos que ha ingresado excede el Total de Cerdos actual, La cantidad actual es: " & CantidadCerdosActual, "Ingresar Reemplazos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If Me.Selecciono_TipoDoc = False Then
                        MessageBoxEx.Show("No ha seleccionado el tipo de documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.cbxTipoDocumento.Focus()
                    ElseIf Me.txtNoDocumento.TextBoxX1.Text = "0" Then
                        MessageBoxEx.Show("No ha ingresado el No de documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.txtNoDocumento.TextBoxX1.Focus()
                    ElseIf Me.cbxDestino.Text = "" Then
                        MessageBoxEx.Show("No ha ingresado el destino", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.cbxDestino.Focus()
                    ElseIf Me.txtJustificacion.Text = "" Then
                        MessageBoxEx.Show("No ha ingresado la justificación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.txtJustificacion.Focus()
                    Else
                        RegistrarMovimientoLote(Me.ListaLotes.Text, 0, 0, 0, Me.txtCantidadRastro.Text, 0, 0, Me.txtFechaRastro.Text, "Rs." & Me.txtNoDocumento.TextBoxX1.Text)

                       sql = New SqlCommand("insert into Detalles_de_Rastros values('" & Me.ListaLotes.Text & "','" & Me.txtCantidadRastro.Text & "','" & Me.Tipo_Doc & "','" & Me.txtNoDocumento.TextBoxX1.Text & "','" & Me.txtFechaRastro.Text & "','" & Me.txtPeso.TextBoxX1.Text & "','" & (Me.txtPeso.TextBoxX1.Text * 0.453592) & "','" & Me.cbxDestino.Text & "','" & Me.txtJustificacion.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                        ActualizarLote()
                        Me.limpiar()
                    End If
                End If
            Catch ex1 As System.Data.SqlClient.SqlException
                MessageBoxEx.Show(ex1.Message & ": el error se produjo por: " & ex1.InnerException.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message & ": el error se produjo por: " & ex.InnerException.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
       
    End Sub

    Private Sub txtCantidadRastro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadRastro.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadRastro.TextChanged
        If Me.txtCantidadRastro.TextLength <> 0 Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()

    End Sub

    Private Sub txtFechaDestazo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaRastro.GotFocus
        If Me.txtFechaRastro.Text = "dd/mm/aa" Then
            Me.txtFechaRastro.Clear()
        End If
    End Sub

  
    Private Sub txtFechaRastro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaRastro.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.txtFechaRastro.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaRastro.Text = Me.txtFechaRastro.Text & "/"
            Me.txtFechaRastro.SelectionStart = 4
        ElseIf Me.txtFechaRastro.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaRastro.Text = Me.txtFechaRastro.Text & "/"
            Me.txtFechaRastro.SelectionStart = 6
        End If
    End Sub

    Private Sub txtFechaRastro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaRastro.LostFocus
        If Me.txtFechaRastro.Text = "" Then
            Me.txtFechaRastro.Text = "dd/mm/aa"
        End If
    End Sub
    Private Sub cbxTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoDocumento.SelectedIndexChanged
        Me.Selecciono_TipoDoc = True
        If Me.cbxTipoDocumento.SelectedItem.ToString = "Fáctura" Then
            Me.Tipo_Doc = "Ft"
        ElseIf Me.cbxTipoDocumento.SelectedItem.ToString = "Crédito Fiscal" Then
            Me.Tipo_Doc = "Cr"
        End If
    End Sub
    Private Sub txtCorrelativo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorrelativo.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class