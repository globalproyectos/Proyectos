Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmAddGranja
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim ExisteGranja As Boolean
    Dim NombreGranja As String
 Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Sub Guardar()
        Try
            sql = New SqlCommand("insert into Granjas values('" & Me.txtCodigoGranja.Text & "','" & Me.txtNombre.Text & "','" & Me.txtCajaFecha.txtFecha.Text & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            Me.txtCodigoGranja.Clear()
            Me.txtNombre.Clear()
            Me.txtCodigoGranja.Focus()
            Me.txtNombre.Enabled = False
            Me.txtCajaFecha.Enabled = False
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
  
    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        Me.txtNombre.Text = UCase(Me.txtNombre.Text)
    End Sub

    Private Sub txtCodigoGranja_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoGranja.LostFocus
        Try
            Me.ExisteGranja = False
            sql = New SqlCommand("select Codigo_Granja, Nombre from Granjas where Codigo_Granja='" & Me.txtCodigoGranja.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.ExisteGranja = True
                Me.NombreGranja = leer(1)
            End While
            con.Close()
            If Me.ExisteGranja = True Then
                MessageBoxEx.Show("El código de la granja que ha ingresado ya existe para la granja: " & Me.NombreGranja, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCodigoGranja.Focus()
                Me.txtNombre.Enabled = False
                Me.txtCajaFecha.Enabled = False
            Else
                Me.txtNombre.Enabled = True
                Me.txtCajaFecha.Enabled = True
                Me.txtNombre.Focus()
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Me.txtCodigoGranja.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el Código de la Granja, este es un campo obligatorio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtCodigoGranja.Focus()
        ElseIf Me.txtNombre.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el nombre de la Granja, este es un campo obligatorio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtNombre.Focus()
        ElseIf Not IsDate(Me.txtCajaFecha.txtFecha.Text) Then
            MessageBoxEx.Show("La fecha ingresada es erronea, porfavor verifique que los dias correspondan al mes correcto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtCajaFecha.Focus()
        Else
            Me.Guardar()

        End If
    End Sub
End Class