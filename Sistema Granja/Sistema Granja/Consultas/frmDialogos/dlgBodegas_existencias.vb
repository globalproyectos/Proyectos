Public Class dlgBodegas_existencias
    Inherits DevComponents.DotNetBar.Office2007Form
    Public ventanallama As String
    Private Sub dlgBodegas_existencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDescripcionBodega.Text = ""
        Me.txtDescripcionBodega.Focus()
        FillToolStripButton_Click(sender, e)
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Consulta_Bodegas_x_descripcionTableAdapter.Fill(Me.DtsBDGRANJA.Consulta_Bodegas_x_descripcion, Me.txtDescripcionBodega.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub txtDescripcionBodega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcionBodega.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSeleccionar_Click(sender, e)
        End If
    End Sub

    Private Sub txtDescripcionBodega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionBodega.TextChanged
        FillToolStripButton_Click(sender, e)
    End Sub
    Sub seleccionar()
        If ventanallama = "consultaexistencias" Then
            With My.Forms.frmConsulta_existencias_x_bodega
                .txtBodega.Text = Consulta_Bodegas_x_descripcionDataGridViewX.CurrentRow.Cells("Bodega").Value
                Close()
            End With
        ElseIf ventanallama = "reqbasetabla" Then
            With My.Forms.frmRequisarBaseTablaEngordes
                .bodegaTextBoxX2.Text = Consulta_Bodegas_x_descripcionDataGridViewX.CurrentRow.Cells("Bodega").Value
                Close()
            End With
        ElseIf ventanallama = "salidafarmacos" Then
            With My.Forms.frmSalidasFarmacos
                .bodegaTextBoxX3.Text = Consulta_Bodegas_x_descripcionDataGridViewX.CurrentRow.Cells("Bodega").Value
                Close()
            End With
        End If
      
    End Sub
    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        seleccionar()
    End Sub
End Class