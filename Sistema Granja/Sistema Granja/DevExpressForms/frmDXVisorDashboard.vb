Public Class frmDXVisorDashboard
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub frmDXVisorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DashboardViewer1.LoadDashboard("C:\DashboardGranja\Reporte de Partos x Cerda.xml")
    End Sub

    
End Class