Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class Visualizador
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub Visualizador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Me.CrReporteViewer�.ExportReport()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Me.CrReporteViewer�.PrintReport()
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Me.CrReporteViewer�.RefreshReport()
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Me.CrReporteViewer�.ShowFirstPage()
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        Me.CrReporteViewer�.ShowPreviousPage()
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        Me.CrReporteViewer�.ShowNextPage()
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        Me.CrReporteViewer�.ShowLastPage()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim Texto As String
        Texto = InputBox("Ingrese el texto que b�scar...", "Buscar Texto", "", 300, 300)
        Me.CrReporteViewer�.SearchForText(Texto)
    End Sub

    Private Sub SliderItem1_ValueChanging(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.CancelIntValueEventArgs) Handles SliderItem1.ValueChanging
        Me.CrReporteViewer�.Zoom(Me.SliderItem1.Value)
    End Sub
End Class