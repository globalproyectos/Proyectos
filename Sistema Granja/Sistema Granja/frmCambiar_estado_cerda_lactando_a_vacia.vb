Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Public Class frmCambiar_estado_cerda_lactando_a_vacia
    Sub Mostrar()
        Try
            Me.cbxCodigoCerda.Items.Clear()
            sql = New SqlCommand("select Código_Cerda from REG_MADRES where Lote_No='2'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxCodigoCerda.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub frmCambiar_estado_cerda_lactando_a_vacia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mostrar()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            CambiarEstadoCerda(Me.cbxCodigoCerda.Text, "5")
            MessageBoxEx.Show("Se ha cambiado el estado de la cerda: " & RTrim(Me.cbxCodigoCerda.Text) & " a estado vacía", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Mostrar()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
End Class