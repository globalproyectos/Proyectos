Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports System.Data
Imports System.Data.SqlClient
Public Class ListaGranjas

    Private Sub ListaGranjas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql = New SqlCommand("select * from Granjas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then

                Else
                    Me.CbxGranjas.Items.Add(leer(1))
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al cargar granjas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub CbxGranjas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxGranjas.TextChanged
        SeleccionoGranja = True
        Try
            sql = New SqlCommand("select Codigo_Granja from Granjas WHERE Nombre='" & Me.CbxGranjas.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                Else
                    GranjaNo_ListaLotes = leer(0)
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error Recuperando Cod. Granjas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
End Class
