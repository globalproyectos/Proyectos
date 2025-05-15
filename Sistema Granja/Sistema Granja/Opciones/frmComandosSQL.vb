Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmComandosSQL
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim cnx As New SqlClient.SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
    Dim cmd As SqlClient.SqlCommand
    Dim tiempoinicial As DateTime
    Dim tiempofinal As DateTime
    Dim salida As String
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ejecutarButtonX1.Click
        If Me.RichTextBoxEx1.Text <> "" Then
            
            iniciar()

        Else
            Me.RichTextBoxEx2.Text = "No hay ningun comando para ejecutar"
        End If
    End Sub
    Sub iniciar()
        Me.PictureBox1.Visible = True
        tiempoinicial = Today & " " & TimeOfDay
        Me.BW.RunWorkerAsync()
        Me.ejecutarButtonX1.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        cmd = New SqlClient.SqlCommand(Me.RichTextBoxEx1.Text, cnx)
        cmd.CommandTimeout = 66666666
        Me.RichTextBoxEx2.Text = "Ejecutando..."

    End Sub
    Sub finalizar()
        Me.PictureBox1.Visible = False
        Me.ejecutarButtonX1.Enabled = True
        Me.Cursor = Cursors.Arrow
        Me.RichTextBoxEx2.Text = salida
        Me.BW.CancelAsync()
    End Sub
    

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        Try
            Dim filasafectadas As String
            Threading.Thread.Sleep(100)
            cnx.Open()
            filasafectadas = cmd.ExecuteNonQuery
            cnx.Close()
            salida = "Filas afectadas: " & filasafectadas
        Catch ex As Exception

            salida = "Error: " & ex.Message
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
    End Sub

    Private Sub BW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW.ProgressChanged
        Me.RichTextBoxEx2.Text = "Ejecutando"
    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        tiempofinal = Today & " " & TimeOfDay
        salida &= If(salida.Contains("Error: "), "", ", tiempo de ejecución: " & CStr((DateDiff(DateInterval.Second, tiempoinicial, tiempofinal)) * 0.001) & " segundos")
        finalizar()
    End Sub
End Class