Public Class frmDesempeñosCerdas
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub
    Private Sub chbxAbuelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxAbuelas.CheckedChanged
        If Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.chbxMadres.CheckState = CheckState.Unchecked
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub chbxMadres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxMadres.CheckedChanged
        If Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.chbxAbuelas.CheckState = CheckState.Unchecked
        ElseIf Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.chbxMadres.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub MostrarAbuelasToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Desempeño_Cerdas_AbuelasTableAdapter.MostrarAbuelas(Me.DtsBDGRANJA.Desempeño_Cerdas_Abuelas, Me.txtCodigoCerda.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub actualizar()
        If Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.Desempeño_Cerdas_AbuelasDataGridViewX.Visible = True
            Me.Desempeño_Cerdas_MadresDataGridViewX.Visible = False
            Try
                Me.Desempeño_Cerdas_AbuelasTableAdapter.MostrarAbuelas(Me.DtsBDGRANJA.Desempeño_Cerdas_Abuelas, Me.txtCodigoCerda.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.Desempeño_Cerdas_MadresDataGridViewX.Visible = True
            Me.Desempeño_Cerdas_AbuelasDataGridViewX.Visible = False
            Try
                Me.Desempeño_Cerdas_MadresTableAdapter.MostrarMadres(Me.DtsBDGRANJA.Desempeño_Cerdas_Madres, Me.txtCodigoCerda.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub txtCodigoCerda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoCerda.KeyDown
        If e.KeyCode = Keys.Enter Then
            actualizar()
        End If
    End Sub
    Private Sub MostrarMadresToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Desempeño_Cerdas_MadresTableAdapter.MostrarMadres(Me.DtsBDGRANJA.Desempeño_Cerdas_Madres, Me.txtCodigoCerda.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmDesempeñosCerdas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.Desempeño_Cerdas_AbuelasDataGridViewX.Visible = True
            Me.Desempeño_Cerdas_MadresDataGridViewX.Visible = False
            MostrarAbuelasToolStripButton_Click(sender, e)
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.Desempeño_Cerdas_MadresDataGridViewX.Visible = True
            Me.Desempeño_Cerdas_AbuelasDataGridViewX.Visible = False
            MostrarMadresToolStripButton_Click(sender, e)
        End If
    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If Me.chbxAbuelas.CheckState = CheckState.Checked Then
            ExportarDatosExcel(Me.Desempeño_Cerdas_AbuelasDataGridViewX, "DESEMPEÑO DE CERDAS ABUELAS", "FECHA: " & FechaSistema, "", "M")
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            ExportarDatosExcel(Me.Desempeño_Cerdas_MadresDataGridViewX, "DESEMPEÑO DE CERDAS MADRES", "FECHA: " & FechaSistema, "", "M")
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        actualizar()
    End Sub
End Class