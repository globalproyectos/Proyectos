Public Class frmRegistrarCelos
    Dim posicion As Integer
    Dim posfinal As Integer
    Public mantto As Boolean
    Private Sub frmRegistrarCelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListado()
    End Sub
    Public Sub cargarListado()
        posfinal = posicion
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.DataSource = ClaseCelos.listar
        contarRegistros()
        Try
            Me.DataGridViewX1.Rows(posfinal).Selected = True
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        With frmAddEditCelos
            .StartPosition = FormStartPosition.CenterScreen
            .accion = "crear"
            mantto = True
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles editarButtonX2.Click
        With frmAddEditCelos
            .StartPosition = FormStartPosition.CenterScreen
            .accion = "editar"
            .idCelo = Me.DataGridViewX1.CurrentRow.Cells("ID_Celo").Value
            mantto = True
            .ShowDialog()
        End With
    End Sub
    Sub contarRegistros()
        Me.LabelX1.Text = String.Format("Listado de registro(s) de celos, {0} registro(s) ", Me.DataGridViewX1.Rows.Count)
        If Me.DataGridViewX1.Rows.Count > 0 Then
            editarButtonX2.Enabled = True
        Else
            editarButtonX2.Enabled = False
        End If
    End Sub

    Private Sub ButtonX2_Click_1(sender As Object, e As EventArgs) Handles ButtonX2.Click
        cargarListado()
    End Sub

    Private Sub DataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        If mantto = False Then
            Me.posicion = Me.DataGridViewX1.CurrentCell.RowIndex
        End If

    End Sub
End Class