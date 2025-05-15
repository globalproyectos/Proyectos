Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class dlgMov_del_Lote
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Seleccionar_etapas_cerdas_lotes_x_etapaTableAdapter.Fill(Me.DtsBDGRANJA.Seleccionar_etapas_cerdas_lotes_x_etapa, Me.txtDescripcion.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd_Click(sender, e)
        End If
    End Sub
    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        FillToolStripButton_Click(sender, e)
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        FillToolStripButton_Click(sender, e)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Me.Seleccionar_etapas_cerdas_lotes_x_etapaDataGridViewX.RowCount = 0 Then
            MessageBoxEx.Show("No hay ninguna etapa en la lista, por lo tanto no puede seleccionar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtDescripcion.Focus()
        Else
            With My.Forms.Creacion_Lotes
                .txtIdEtapa_Cerda.Text = Me.Seleccionar_etapas_cerdas_lotes_x_etapaDataGridViewX.CurrentRow.Cells("IdEtapa").Value
                Me.txtDescripcion.Text = ""
                Me.Close()
            End With
        End If
    End Sub
    Private Sub dlgMov_del_Lote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDescripcion.Text = ""
        Me.txtDescripcion.Focus()
        FillToolStripButton_Click(sender, e)
    End Sub
End Class
