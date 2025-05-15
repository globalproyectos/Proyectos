Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Windows.Forms

Public Class DfrmCambioEstadoEnseminacion
    Inherits DevComponents.DotNetBar.Office2007Form
    Public IdEnsemeninacion As Integer
    Public CodigoCerda As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DfrmCambioEstadoEnseminacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub cbxEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEstado.SelectedIndexChanged
        Me.btnAceptar.Enabled = True
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.cbxEstado.SelectedItem.ToString = "Abortó" Then
            sql = New SqlCommand("update Reg_Enseminaciones_x_cerda set Estado='A' WHERE Id_Enseminacion='" & Me.IdEnsemeninacion & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            CambiarEstadoCerda(Me.CodigoCerda, "5")
            MessageBoxEx.Show("Se cambió el estado de la cerda con código: " & RTrim(Me.CodigoCerda) & " exitosamente, la cerda pasará automaticamente a estado Vacía", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Forms.frmEnseminaciones.MonstrarEnseminaciones()
            Me.Close()
        ElseIf Me.cbxEstado.SelectedItem.ToString = "Confirmado" Then
            sql = New SqlCommand("update Reg_Enseminaciones_x_cerda set Estado='C' WHERE Id_Enseminacion='" & Me.IdEnsemeninacion & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            CambiarEstadoCerda(Me.CodigoCerda, "3")
            MessageBoxEx.Show("Se cambió el estado de la cerda con código: " & RTrim(Me.CodigoCerda) & " exitosamente, la cerda pasará automaticamente a estado Gestando...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Forms.frmEnseminaciones.MonstrarEnseminaciones()
            Me.Close()
        ElseIf Me.cbxEstado.SelectedItem.ToString = "Nulo" Then
            sql = New SqlCommand("update Reg_Enseminaciones_x_cerda set Estado='N' WHERE Id_Enseminacion='" & Me.IdEnsemeninacion & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()

            MessageBoxEx.Show("Se cambió el estado de la cerda con código: " & RTrim(Me.CodigoCerda) & " exitosamente, la cerda se mantiene en estado Vacía", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Forms.frmEnseminaciones.MonstrarEnseminaciones()
            Me.Close()
        End If
       

    End Sub
End Class
