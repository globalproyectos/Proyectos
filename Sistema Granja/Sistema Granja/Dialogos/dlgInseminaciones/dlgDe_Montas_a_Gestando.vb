Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class dlgDe_Montas_a_Gestando
    Sub MostrarLotes_Gestacion()
        Try
            Me.cbxLoteGestacion.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No " _
                              & " FROM LOTES l" _
                              & " JOIN Etapas_Cerdas_Lote e ON l.IdEtapa_Cerdas = e.IdEtapa_Cerdas" _
                              & " where l.IdEtapa_Cerdas ='G' and l.Estado<>'T'"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                'Me.cbxLotePara.Text = leer(0).ToString
                Me.cbxLoteGestacion.Items.Add(leer(0)).ToString()
                'Me.txtDescLotePara.Text = leer(1).ToString

            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar lotes Gestación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub dlgDe_Montas_a_Gestando_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MostrarLotes_Gestacion()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        With My.Forms.frmEnseminaciones

            .Proceso = False
            Me.Close()
        End With
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.MostrarLotes_Gestacion()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With My.Forms.frmEnseminaciones
            .LoteGestacion = Me.cbxLoteGestacion.Text
            .Proceso = True
            Me.Close()
        End With
    End Sub
End Class