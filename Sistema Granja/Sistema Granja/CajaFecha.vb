Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class CajaFecha

    Private Sub CajaFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFecha.Text = Format(FechaSistema, "dd/MM/yy")
    End Sub

    Private Sub txtFecha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFecha.GotFocus
        Me.txtFecha.SelectAll()

    End Sub

    Private Sub TextBoxX1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 47 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If txtFecha.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            txtFecha.Text = txtFecha.Text & "/"
            txtFecha.SelectionStart = 4
        ElseIf txtFecha.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            txtFecha.Text = txtFecha.Text & "/"
            txtFecha.SelectionStart = 6
        End If
    End Sub

    Private Sub txtFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFecha.LostFocus
        If Me.txtFecha.Text = "" Then
            Me.txtFecha.Text = Format(FechaSistema, "dd/MM/yy")
        End If
    End Sub

   
    Private Sub txtFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFecha.TextChanged

    End Sub
End Class
