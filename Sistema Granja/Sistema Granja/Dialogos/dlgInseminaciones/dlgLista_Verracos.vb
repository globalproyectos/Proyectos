Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class dlgLista_Verracos
    Inherits DevComponents.DotNetBar.Office2007Form
    Public Madres_o_Abuelas As String = ""
    Private Sub dlgLista_Verracos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCodigoVerraco.Clear()
        BuscarToolStripButton_Click(sender, e)
    End Sub
    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Verracos_Buscar_x_CodigoTableAdapter.Buscar(Me.DtsBDGRANJA.Lista_Verracos_Buscar_x_Codigo, Me.txtCodigoVerraco.Text)
        Catch ex As System.Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Lista_Verracos_Buscar_x_CodigoDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Verracos_Buscar_x_CodigoDataGridViewX.CellContentDoubleClick
        ButtonX2_Click(sender, e)

    End Sub

    Private Sub txtCodigoVerraco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoVerraco.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX2_Click(sender, e)
        End If

    End Sub

    Private Sub txtCodigoVerraco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoVerraco.TextChanged
        BuscarToolStripButton_Click(sender, e)
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If Madres_o_Abuelas = "MADRES" Then
                If Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.RowCount <> 0 Then
                    With My.Forms.frmRegistro_Inseminacion
                        .Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentRow.Cells("Verraco").Value = RTrim(Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.CurrentRow.Cells("CodVerraco").Value)
                        .Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EndEdit()
                        Me.Close()

                    End With
                Else
                    MessageBoxEx.Show("No hay ningun registro en la lista", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf Madres_o_Abuelas = "ABUELAS" Then
                If Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.RowCount <> 0 Then
                    With My.Forms.frmRegistro_Inseminacion
                        .Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentRow.Cells("Verraco2").Value = RTrim(Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.CurrentRow.Cells("CodVerraco").Value)
                        .Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()
                        Me.Close()

                    End With
                Else
                    MessageBoxEx.Show("No hay ningun registro en la lista", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
       
           
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Lista_Verracos_Buscar_x_CodigoDataGridViewX_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista_Verracos_Buscar_x_CodigoDataGridViewX.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False
            ButtonX2_Click(sender, e)
        End If
    End Sub
End Class