Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmRecalcular_x_FechaInicio
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim fechaInicio As Date
    Sub Iniciar()
        Me.Size = New Size(325, 152)
        Me.ButtonX1.Enabled = False
        Me.ProgressBar1.Maximum = 3
        fechaInicio = Me.MaskedTextBoxAdv1.Text
        Me.Cursor = Cursors.WaitCursor
        Me.BW.RunWorkerAsync()
    End Sub
    Sub Finalizar()
        Me.Size = New Size(325, 97)
        Me.ButtonX1.Enabled = True
        Me.Cursor = Cursors.Arrow
        Me.BW.CancelAsync()
    End Sub
    Private Sub BW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        Try
            For i As Integer = 0 To 3
                sql = New SqlCommand("Recalcular_Costos_x_FechaInicio", con)
                sql.CommandType = CommandType.StoredProcedure
                sql.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.Date)).Value = fechaInicio
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                Me.BW.ReportProgress(i, "Recalculando... " & i & " de " & 3)
                Threading.Thread.Sleep(20)
            Next
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al recalcular", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BW.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        Me.lbEstatus.Text = e.UserState.ToString
    End Sub

    Private Sub BW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        Finalizar()
    End Sub

    Private Sub MaskedTextBoxAdv1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBoxAdv1.LostFocus

    End Sub

    Private Sub MaskedTextBoxAdv1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBoxAdv1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBoxAdv1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBoxAdv1.TextChanged
        If IsDate(Me.MaskedTextBoxAdv1.Text) Then
            Me.ButtonX1.Enabled = True
        Else
            Me.ButtonX1.Enabled = False
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Iniciar()
    End Sub
End Class