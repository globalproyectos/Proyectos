Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Public Class frmSubirRespaldos
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub
    Private Sub ComboBoxEx1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.TextChanged
        If Me.ComboBoxEx1.Text <> "" Then
            Me.btnSubir.Enabled = True
        Else
            Me.btnSubir.Enabled = False
        End If
    End Sub
    Sub SubirRespaldos()

        Try
            sql = New SqlCommand("USE master RESTORE DATABASE BDGRANJA FROM DISK='" & Me.ComboBoxEx1.Text & "' WITH REPLACE", ConRespaldo)
            ConRespaldo.Open()
            sql.ExecuteNonQuery()
            ConRespaldo.Close()
            MessageBoxEx.Show("Se completo el respaldo exitosamente", "Respaldos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al Respaldar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ConRespaldo.Close()
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        With Me.DialogoAbrir
            .Filter = "BAK|*.bak"
            .Multiselect = False
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.ComboBoxEx1.Text = .FileName
            End If
        End With
    End Sub

    Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click
        Me.SubirRespaldos()

    End Sub
End Class