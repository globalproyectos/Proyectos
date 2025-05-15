Public Class frmUbicaciones
    Dim ubicacionesAdapter As New DtsBDGRANJATableAdapters.UbicacionesEditableTableAdapter
    Public bsUbicaciones As New BindingSource
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub frmUbicaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
    Public Sub cargar()
        Try
            ubicacionesAdapter.Fill(odtsBDGRANJA.UbicacionesEditable)
            bsUbicaciones.DataSource = odtsBDGRANJA.UbicacionesEditable

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsUbicaciones

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub guardarcambios()
        Try
            bsUbicaciones.EndEdit()
            ubicacionesAdapter.Update(odtsBDGRANJA.UbicacionesEditable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub aceptarButtonX3_Click(sender As Object, e As EventArgs) Handles aceptarButtonX3.Click
        guardarcambios()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With frmUbicacionesAñadir
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
End Class