Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmDestazo
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim verif As Boolean = False
    Dim Destazo As Integer
    Dim Tipo_Doc As String
    Dim Selecciono_TipoDoc As Boolean
    Sub Lotes()
        Try
            sql = New SqlCommand("Select * from LOTES WHERE Estado='A' or Estado='F'", con)
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
    Private Sub FrmDestazo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Lotes()
    End Sub
    Sub Limpiar()
        Me.ListaLotes.Text = ""
        Me.txtCantidadDestazo.Clear()

    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub txtCantidadDestazo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadDestazo.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidadDestazo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadDestazo.TextChanged
        If Me.txtCantidadDestazo.TextLength <> 0 And IsNumeric(Me.txtCantidadDestazo.Text) Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidarFechas(Me.txtFechaDestazo.Text) = False Then
            Me.txtFechaDestazo.SelectAll()
            Me.txtFechaDestazo.Focus()
        Else
            Dim CerdosActuales As Integer
            Try
                sql = New SqlCommand("Select Total_Cerdos from Total_Cerdos_Lote where Lote_No='" & Me.ListaLotes.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CerdosActuales = leer(0)
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, ex.InnerException.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
         
            If CerdosActuales < Val(Me.txtCantidadDestazo.Text) Then
                MessageBoxEx.Show("La cantidad de cerdos que ha ingresado excede el total de cerdos en el Lote, la cantidad actual es: " & CerdosActuales & " Cerdos", "Registro de Destazo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCantidadDestazo.Focus()
            Else

                Try
                    RegistrarMovimientoLote(Me.ListaLotes.Text, 0, 0, Me.txtCantidadDestazo.Text, 0, 0, 0, Me.txtFechaDestazo.Text, "Dz." & Me.txtNoDocumento.TextBoxX1.Text)

                    sql = New SqlCommand("insert into Detalles_de_Destazos values('" & Me.ListaLotes.Text & "','" & Me.txtCantidadDestazo.Text & "','" & Me.Tipo_Doc & "','" & Me.txtNoDocumento.TextBoxX1.Text & "','" & Me.txtFechaDestazo.Text & "','" & Me.txtPeso.TextBoxX1.Text & "','" & (Me.txtPeso.TextBoxX1.Text * 0.453592) & "','" & Me.cbxDestino.Text & "','" & Me.txtJustificacion.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    ActualizarLote()
                    Me.Limpiar()
                Catch ex As Exception
                    MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub TextBoxX1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaDestazo.GotFocus
        If Me.txtFechaDestazo.Text = "dd/mm/aa" Then
            Me.txtFechaDestazo.Clear()
        End If
    End Sub

    Private Sub txtFechaDestazo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaDestazo.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.txtFechaDestazo.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaDestazo.Text = Me.txtFechaDestazo.Text & "/"
            Me.txtFechaDestazo.SelectionStart = 4
        ElseIf Me.txtFechaDestazo.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFechaDestazo.Text = Me.txtFechaDestazo.Text & "/"
            Me.txtFechaDestazo.SelectionStart = 6
        End If
    End Sub

    Private Sub txtFechaDestazo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaDestazo.LostFocus
        If Me.txtFechaDestazo.Text = "" Then
            Me.txtFechaDestazo.Text = "dd/mm/aa"
        End If
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoDocumento.SelectedIndexChanged
        Me.Selecciono_TipoDoc = True
        If Me.cbxTipoDocumento.SelectedItem.ToString = "Fáctura" Then
            Me.Tipo_Doc = "Ft"
        ElseIf Me.cbxTipoDocumento.SelectedItem.ToString = "Crédito Fiscal" Then
            Me.Tipo_Doc = "Cr"
        ElseIf Me.cbxTipoDocumento.SelectedItem.ToString = "Traslado" Then
            Me.Tipo_Doc = "Tr"
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