Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class dlgEtapas_Alimentos_Medicamentos

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Consulta_Rapida_Etapas_MedTableAdapter.Fill(Me.DtsBDGRANJA.Consulta_Rapida_Etapas_Med, Me.txtDescripcion.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dlgEtapas_Alimentos_Medicamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillToolStripButton_Click(sender, e)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        FillToolStripButton_Click(sender, e)
    End Sub


    Private Sub Consulta_Rapida_Etapas_MedDataGridViewX_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Consulta_Rapida_Etapas_MedDataGridViewX.CellContentDoubleClick
        If Me.Consulta_Rapida_Etapas_MedDataGridViewX.RowCount = 0 Then
            MessageBoxEx.Show("No hay ningun registro de la lista", "Sin Registros", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            With My.Forms.frmRegistrarMedicamentos
                .txtIdEtapa.Text = Consulta_Rapida_Etapas_MedDataGridViewX.CurrentRow.Cells("IdEtapa").Value
                Me.txtDescripcion.Text = ""
                Me.Close()
            End With
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Me.Consulta_Rapida_Etapas_MedDataGridViewX.RowCount = 0 Then
            MessageBoxEx.Show("No hay ningun registro de la lista", "Sin Registros", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            With My.Forms.frmRegistrarMedicamentos
                .txtIdEtapa.Text = Consulta_Rapida_Etapas_MedDataGridViewX.CurrentRow.Cells("IdEtapa").Value
                Me.txtDescripcion.Text = ""
                Me.Close()
            End With
        End If

    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd_Click(sender, e)
        End If
    End Sub
    Private Sub Consulta_Rapida_Etapas_MedDataGridViewX_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Consulta_Rapida_Etapas_MedDataGridViewX.KeyDown
        e.Handled = False
        If e.KeyCode = Keys.Enter Then
            If Me.Consulta_Rapida_Etapas_MedDataGridViewX.RowCount = 0 Then
                MessageBoxEx.Show("No hay ningun registro de la lista", "Sin Registros", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                With My.Forms.frmRegistrarMedicamentos
                    .txtIdEtapa.Text = Consulta_Rapida_Etapas_MedDataGridViewX.CurrentRow.Cells("IdEtapa").Value
                    Me.txtDescripcion.Text = ""
                    Me.Close()
                End With
            End If
        End If
    End Sub
    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        FillToolStripButton_Click(sender, e)
    End Sub
End Class