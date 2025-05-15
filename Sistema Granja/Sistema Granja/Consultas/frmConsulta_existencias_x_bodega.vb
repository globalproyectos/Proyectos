Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmConsulta_existencias_x_bodega
    Dim DescripcionBodega As String
    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Consulta_Existencias_bodegaTableAdapter.Fill(Me.DtsBDGRANJA.Consulta_Existencias_bodega, Me.txtBodega.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtBodega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBodega.KeyDown
        If e.KeyCode = Keys.Enter Then
            FillToolStripButton_Click(sender, e)
        End If
        If e.KeyCode = Keys.F5 Then
            With My.Forms.dlgBodegas_existencias
                .txtDescripcionBodega.Text = ""
                .ventanallama = "consultaexistencias"
                .txtDescripcionBodega.Focus()
                .ShowDialog()

            End With
        End If
    End Sub


    Private Sub txtBodega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBodega.TextChanged
        Try
            Dim ExisteBodega As Boolean = False

            sql = New SqlCommand("select Descripcion from BODEGAS where Bodega='" & Me.txtBodega.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                DescripcionBodega = leer(0).ToString
                ExisteBodega = True
            End While
            con.Close()
            If ExisteBodega = True Then
                Me.txtDescripcionBodega.Text = DescripcionBodega.ToString
            Else
                Me.txtDescripcionBodega.Text = ""
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ActualizarExistencias()
        FillToolStripButton_Click(sender, e)
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        ExportarDatosExcel(Me.Consulta_Existencias_bodegaDataGridViewX, "EXISTENCIAS BODEGA: " & Me.txtBodega.Text & " " & Me.txtDescripcionBodega.Text, "", "FECHA: " & FechaSistema, "F")
    End Sub
End Class