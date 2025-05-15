Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Public Class frmResultados_Granjas
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Granja As String = ""
    Private Sub frmResultados_Granjas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostarGranjas()
    End Sub

    Private Sub Mostar_RSToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Resultados_Granjas_Resumen_SalidasTableAdapter.Mostar_RS(Me.DtsBDGRANJA.Resultados_Granjas_Resumen_Salidas, Granja, New System.Nullable(Of Date)(CType(Me.txtFechaDesde.Text, Date)), New System.Nullable(Of Date)(CType(Me.txtFechaHasta.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub MostarGranjas()
        Try
            Me.cbxGranjas.Items.Clear()

            sql = New SqlCommand("select Nombre from Granjas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxGranjas.Items.Add(leer(0).ToString)
            End While
            con.Close()
            Me.cbxGranjas.Items.Add("TODAS")
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al mostrar granjas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Not IsDate(Me.txtFechaDesde.Text) Then
            MessageBoxEx.Show("La fecha desde que ha ingresado no es válida, porfavor verifiquela y vuelva a intentarlo", "Error fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaDesde.Focus()
        ElseIf Not IsDate(Me.txtFechaHasta.Text) Then
            MessageBoxEx.Show("La fecha hasta que ha ingresado no es válida, porfavor verifiquela y vuelva a intentarlo", "Error fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaHasta.Focus()
        Else
            Mostar_RSToolStripButton_Click(sender, e)
        End If

    End Sub

    Private Sub cbxGranjas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxGranjas.SelectedIndexChanged
        If Me.cbxGranjas.SelectedItem.ToString = "TODAS" Then
            Granja = "GR"
            MsgBox(Granja)
        Else
            Granja = Me.cbxGranjas.SelectedItem.ToString
        End If
    End Sub
End Class