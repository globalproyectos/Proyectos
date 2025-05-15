Public Class frmBuscarReemplazos
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Private Sub TextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarListado()
        End If
    End Sub
    Sub cargarListado()
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.DataSource = ClaseCerdas.listar(Me.TextBoxX1.Text)
        If Me.DataGridViewX1.Rows.Count > 0 Then
            Me.seleccionarButtonX1.Enabled = True
        Else
            Me.seleccionarButtonX1.Enabled = False
        End If
    End Sub

    Private Sub frmBuscarReemplazos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListado()
    End Sub

    Private Sub seleccionarButtonX1_Click(sender As Object, e As EventArgs) Handles seleccionarButtonX1.Click
        frmAddEditCelos.tipoCerdaTextBoxX3.Text = Me.DataGridViewX1.CurrentRow.Cells("Tipo_Cerda").Value
        frmAddEditCelos.idCerdaTextBoxX2.Text = Me.DataGridViewX1.CurrentRow.Cells("ID_Cerda").Value
        frmAddEditCelos.edadDiasDoubleInput1.Value = Me.DataGridViewX1.CurrentRow.Cells("EdadDias").Value
        frmAddEditCelos.clasificacionComboBox1.SelectedValue = Me.DataGridViewX1.CurrentRow.Cells("Clasificacion").Value
        Me.Close()
    End Sub

    Private Sub DataGridViewX1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentDoubleClick
        seleccionarButtonX1_Click(sender, e)
    End Sub
End Class