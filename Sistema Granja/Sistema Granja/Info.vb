Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar

Public Class Info
    Inherits DevComponents.DotNetBar.Office2007RibbonForm
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbVersion.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        MessageBoxEx.Show(My.MySettings.Default.BDGRANJAConnectionString.ToString)
    End Sub
End Class