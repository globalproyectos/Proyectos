Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmRevertirCompra
    Inherits DevComponents.DotNetBar.Office2007Form
    
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub Buscar_Compra_reversion_x_nodocBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Buscar_Compra_reversion_x_nodocBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsBDGRANJA)

    End Sub

    Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Buscar_Compra_reversion_x_nodocTableAdapter.Fill(Me.DtsBDGRANJA.Buscar_Compra_reversion_x_nodoc, Me.txtNoDoc.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtNoDoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoDoc.LostFocus
        If Me.txtNoDoc.Text <> "" Then
            FillToolStripButton_Click_1(sender, e)
        End If
    End Sub
    Private Sub No_DocumentoTextBoxX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No_DocumentoTextBoxX.TextChanged
        If Me.No_DocumentoTextBoxX.Text <> "" Then
            Me.btnRevertir.Enabled = True
        Else
            Me.btnRevertir.Enabled = False
        End If
    End Sub
    Private Sub btnRevertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevertir.Click
        Dim resp As MsgBoxResult
        resp = MessageBoxEx.Show("Esta seguro de eliminar el registro de Compra No: " & Me.No_DocumentoTextBoxX.Text & " de la base de datos", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If resp = MsgBoxResult.Yes Then
            Me.Buscar_Compra_reversion_x_nodocBindingSource.RemoveAt(Me.Buscar_Compra_reversion_x_nodocBindingSource.Position)
            Buscar_Compra_reversion_x_nodocBindingNavigatorSaveItem_Click_1(sender, e)
            Me.txtNoDoc.Text = ""
            Me.txtNoDoc.Focus()
            Me.btnRevertir.Enabled = False
            ActualizarExistencias()
        End If
    End Sub
End Class