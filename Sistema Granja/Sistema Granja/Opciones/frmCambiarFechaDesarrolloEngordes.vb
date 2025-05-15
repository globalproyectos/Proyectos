Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmCambiarFechaDesarrolloEngordes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Proc_SelectFechaDesarrolloEngordesAdapter As New DtsBDGRANJATableAdapters.Proc_SelectFechaDesarrolloEngordesTableAdapter
    Private Sub frmCambiarFechaDesarrolloEngordes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Sub cargar()
        Try
            Proc_SelectFechaDesarrolloEngordesAdapter.Fill(odtsBDGRANJA.Proc_SelectFechaDesarrolloEngordes)
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = odtsBDGRANJA.Proc_SelectFechaDesarrolloEngordes

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click

        Proc_SelectFechaDesarrolloEngordesAdapter.Update(odtsBDGRANJA.Proc_SelectFechaDesarrolloEngordes)


        Me.Close()
    End Sub

    Private Sub DataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        Me.DataGridViewX1.Rows(e.RowIndex).Cells("FechaSemanal").Value = DateAdd(DateInterval.Day, 7, Me.DataGridViewX1.Rows(e.RowIndex).Cells("Fecha").Value)
    End Sub

    Private Sub DataGridViewX1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        Me.DataGridViewX1.Rows(e.RowIndex).Cells("FechaSemanal").Value = DateAdd(DateInterval.Day, 7, Me.DataGridViewX1.Rows(e.RowIndex).Cells("Fecha").Value)
    End Sub
End Class