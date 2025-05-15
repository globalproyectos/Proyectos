Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmInfo_Inicio
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Seg As Integer
    Private Sub frmInfo_Inicio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i As Integer = 0 To 100
            Me.Opacity = i / 1000
        Next
    End Sub
    Private Sub frmInfo_Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtusuario.Text = UsuarioSistema
        Me.txtFecha.Text = Format(FechaSistema, "dd/MM/yyyy")
    End Sub
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Seg += 1
        If Seg = 45 Then
            Me.Close()
        End If

    End Sub
End Class