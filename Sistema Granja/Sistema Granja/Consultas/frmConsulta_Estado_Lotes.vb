Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmConsulta_Estado_Lotes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim odtsGranja As New DtsBDGRANJA
    Dim adapter As New DtsBDGRANJATableAdapters.Consulta_Estado_LotesTableAdapter
    Private Sub frmConsulta_Estado_Lotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsBDGRANJA.Consulta_Estado_Lotes' Puede moverla o quitarla según sea necesario.
        Me.MostrarDatos()
       
    End Sub
    Sub MostrarDatos()
        Try
            Me.Consulta_Estado_LotesDataGridViewX.DataSource = adapter.GetData()
            Me.lbResultados.Text = Me.Consulta_Estado_LotesDataGridViewX.Rows.Count
            For i As Integer = 0 To Me.Consulta_Estado_LotesDataGridViewX.Rows.Count - 1
                If Me.Consulta_Estado_LotesDataGridViewX.Rows(i).Cells("Descripcion").Value = "ENGORDE" Then

                ElseIf Me.Consulta_Estado_LotesDataGridViewX.Rows(i).Cells("Descripcion").Value = "" Then
                End If
            Next
        Catch ex As Exception

        End Try
        'Me.Consulta_Estado_LotesTableAdapter.Fill(Me.DtsBDGRANJA.Consulta_Estado_Lotes)

    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.MostrarDatos()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        ExportarDatosExcel(Me.Consulta_Estado_LotesDataGridViewX, "RESUMEN ESTADO DE LOTES", "", "FECHA: " & FechaSistema, "G")
    End Sub

    Private Sub lbResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbResultados.Click

    End Sub

    Private Sub lbResultados_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbResultados.TextChanged
        If Me.lbResultados.Text = "0" Then
            Me.btnExportar.Enabled = False
        Else
            Me.btnExportar.Enabled = True
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Buscar("Lote_No", Me.txtLoteNo.Text, Consulta_Estado_LotesBindingSource)
    End Sub
End Class