Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmAnular_Requisicion

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub Buscar_Requisicion_AnulacionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Buscar_Requisicion_AnulacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsBDGRANJA)

    End Sub

    Private Sub BuscarReqToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Buscar_Requisicion_AnulacionTableAdapter.BuscarReq(Me.DtsBDGRANJA.Buscar_Requisicion_Anulacion, Me.txtNoReq.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub txtNoReq_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoReq.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarReqToolStripButton_Click(sender, e)
        End If
    End Sub
    Private Sub Req_NoTextBoxX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Req_NoTextBoxX.TextChanged
        If Req_NoTextBoxX.Text <> "" Then
            Me.btnRevertir.Enabled = True
        Else
            Me.btnRevertir.Enabled = False
        End If
    End Sub
    Private Sub btnRevertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevertir.Click
        Dim resp As MsgBoxResult
        resp = MessageBoxEx.Show("Esta seguro de Anular la Requisición No: " & Me.Req_NoTextBoxX.Text, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If resp = MsgBoxResult.Yes Then
            Me.Buscar_Requisicion_AnulacionBindingSource.RemoveAt(Me.Buscar_Requisicion_AnulacionBindingSource.Position)
            Buscar_Requisicion_AnulacionBindingNavigatorSaveItem_Click(sender, e)
            Me.txtNoReq.Text = ""
            Me.txtNoReq.Focus()
            Me.btnRevertir.Enabled = False
            ActualizarExistencias()
        End If
    End Sub
End Class