Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmRevisar_CierreLotes
    Sub MostrarLotes()
        Try
            Me.cbxLotes.Items.Clear()
            sql = New SqlCommand("select lote_no from lotes where Estado<>'T'", con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                Me.cbxLotes.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub frmRevisar_CierreLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MostrarLotes()
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If Me.cbxLotes.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el lote que se desea revisar", "Sin Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cbxLotes.Focus()
        Else
            RevisarCierre_Lote(Me.cbxLotes.Text, Me.cbxLotes)
            Me.MostrarLotes()
        End If

    End Sub
End Class