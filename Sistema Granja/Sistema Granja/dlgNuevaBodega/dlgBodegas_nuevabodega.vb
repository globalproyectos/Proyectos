Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class dlgBodegas_nuevabodega
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Granas_x_descripcionTableAdapter.Fill(Me.DtsBDGRANJA.Granas_x_descripcion, Me.txtDescripcionGranja.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtDescripcionGranja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcionGranja.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX3_Click(sender, e)
        End If
    End Sub
    Private Sub txtDescripcionGranja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionGranja.TextChanged
        Try
            Me.Granas_x_descripcionTableAdapter.Fill(Me.DtsBDGRANJA.Granas_x_descripcion, Me.txtDescripcionGranja.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dlgBodegas_nuevabodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDescripcionGranja_TextChanged(sender, e)
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        txtDescripcionGranja_TextChanged(sender, e)
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            With My.Forms.frmAddBodega
                .txtCodGranja.Text = Me.Granas_x_descripcionDataGridViewX.CurrentRow.Cells("Codigo").Value
                Me.txtDescripcionGranja.Text = ""
                Me.Close()
            End With
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    'Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
    '    Try
    '        Me.Granas_x_descripcionTableAdapter.Fill(Me.DtsBDGRANJA.Granas_x_descripcion, DescrGranjaToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class
