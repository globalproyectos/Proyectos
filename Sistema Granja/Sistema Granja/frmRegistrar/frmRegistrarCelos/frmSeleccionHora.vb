Public Class frmSeleccionHora
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub TimeSelector1_OkClick(sender As Object, e As EventArgs) Handles TimeSelector1.OkClick
        frmAddEditCelos.horaLinkLabel1.Text = Me.TimeSelector1.SelectedTime.ToString
        Me.Close()
    End Sub
End Class