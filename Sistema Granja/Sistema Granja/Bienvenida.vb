Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public NotInheritable Class Bienvenida
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim No_Session As Integer
    Dim Tablas As Integer = 0
    Dim CargaTablasFinalizado As Boolean
    Dim NombreTablaCargada As String
    Private Sub Bienvenida_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Version.Text = "Versión: " & My.Application.Info.Version.ToString
        Copyright.Text = My.Application.Info.Copyright
        Me.lbFecha.Text = Today
    End Sub

    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version.Click

    End Sub
End Class
