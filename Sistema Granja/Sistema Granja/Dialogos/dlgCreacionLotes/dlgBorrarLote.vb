Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class dlgBorrarLote
    Inherits DevComponents.DotNetBar.Office2007Form
    

    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX1.TextChanged
        
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim existelote As Boolean = False
            sql = New SqlCommand("select lote_no from lotes where lote_no=upper('" & Me.TextBoxX1.Text & "')", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                existelote = True

            End While
            con.Close()
            If existelote = True Then
                Dim permitidoborrar As Boolean = True
                sql = New SqlCommand("select Lote_No FROM Movimiento_Lote where Lote_No= upper('" & RTrim(Me.TextBoxX1.Text) & "')", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    permitidoborrar = False
                End While
                con.Close()
                If permitidoborrar = True Then
                    sql = New SqlCommand("delete from lotes where lote_no='" & RTrim(Me.TextBoxX1.Text) & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    MessageBoxEx.Show("EL Lote " & RTrim(Me.TextBoxX1.Text) & " ha sido borrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBoxX1.Text = ""

                Else
                    MessageBoxEx.Show("El Lote " & RTrim(Me.TextBoxX1.Text) & " no se puede borrar por que tiene movimientos.", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                End If
            Else
                MessageBoxEx.Show("El Lote " & RTrim(Me.TextBoxX1.Text) & " no existe, favor verificar", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.TextBoxX1.Focus()
            End If
           
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class