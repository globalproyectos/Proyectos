Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmEstado_actual_Cerdas

    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

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
    Sub MostrarGranjas()
        Try
            Me.cbxGranjas.Items.Clear()
            sql = New SqlCommand("select Nombre from Granjas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxGranjas.Items.Add(leer(0)).ToString()
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar Granjas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub frmEstado_actual_Cerdas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MostrarGranjas()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub

    Private Sub MostrarAbuelasToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Consulta_estado_actual_abuelasTableAdapter.MostrarAbuelas(Me.DtsBDGRANJA.Consulta_estado_actual_abuelas, Me.cbxGranjas.Text, Me.txtCodigoCerda.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Me.chbxAbuelas.CheckState = CheckState.Checked Then
            Me.Consulta_estado_actual_abuelasDataGridViewX.Visible = True
            Me.Consulta_estado_actual_madresDataGridViewX.Visible = False
            MostrarAbuelasToolStripButton_Click(sender, e)
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            Me.Consulta_estado_actual_abuelasDataGridViewX.Visible = False
            Me.Consulta_estado_actual_madresDataGridViewX.Visible = True
            MostrarMadresToolStripButton_Click(sender, e)
        End If
    End Sub

    Private Sub MostrarMadresToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Consulta_estado_actual_madresTableAdapter.MostrarMadres(Me.DtsBDGRANJA.Consulta_estado_actual_madres, Me.cbxGranjas.Text, Me.txtCodigoCerda.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.ButtonX1_Click(sender, e)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If Me.chbxAbuelas.CheckState = CheckState.Checked Then
            ExportarDatosExcel(Me.Consulta_estado_actual_abuelasDataGridViewX, "ESTADO DE CERDAS ABUELAS", Me.cbxGranjas.Text, "FECHA: " & FechaSistema, "F")
        ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
            ExportarDatosExcel(Me.Consulta_estado_actual_madresDataGridViewX, "ESTADO DE CERDAS MADRES", Me.cbxGranjas.Text, "FECHA: " & FechaSistema, "F")

        End If
    End Sub
End Class