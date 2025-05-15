Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmCambiar_Servidor
    Inherits DevComponents.DotNetBar.Office2007Form

    Private Sub frmCambiar_Servidor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'My.Forms.Login.CheckBoxX1.CheckState = CheckState.Unchecked
    End Sub
    Private Sub frmCambiar_Servidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If Me.ComboBoxEx1.SelectedItem.ToString = "" Then
            MessageBoxEx.Show("No ha ingresado el nombre del servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ComboBoxEx1.Focus()
        Else
            Dim CadenaConexion As String = "Data Source='" & RTrim(Me.ComboBoxEx1.SelectedItem.ToString) & "'; Initial Catalog=BDGRANJA; User ID=sa; Password=josemiguel003"
           

            My.MySettings.Default.Save()
            MsgBox(My.MySettings.Default.BDGRANJAConnectionString.ToString)
           
            MessageBoxEx.Show("Se han guardado los cambios exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
End Class