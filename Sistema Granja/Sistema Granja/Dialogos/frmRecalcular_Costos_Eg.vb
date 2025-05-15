Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmRecalcular_Costos_Eg
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Codigo As String
    Dim NuevoCosto As Double
    Dim FechaInicio, FechaFin As Date
    Private Sub frmRecalcular_Costos_Eg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub Iniciar()
        Me.btnInciar.Enabled = False
        Me.Size = New Size(528, 236)
        Codigo = Me.txtCodigoProducto.Text
        NuevoCosto = Me.txtNuevoCosto.Text
        FechaInicio = Me.txtFechaInicio.Text
        FechaFin = Me.txtFechaFin.Text
        Me.BW.RunWorkerAsync()
    End Sub
    Sub Finalizar()
        Me.btnInciar.Enabled = True
        Me.Size = New Size(528, 126)
        Me.BW.CancelAsync()
    End Sub
    Private Sub txtFechaInicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaInicio.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 47 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If txtFechaInicio.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            txtFechaInicio.Text = txtFechaInicio.Text & "/"
            txtFechaInicio.SelectionStart = 4
        ElseIf txtFechaInicio.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            txtFechaInicio.Text = txtFechaInicio.Text & "/"
            txtFechaInicio.SelectionStart = 6
        End If
    End Sub

    Private Sub txtFechaFin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaFin.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 47 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If txtFechaFin.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            txtFechaFin.Text = txtFechaFin.Text & "/"
            txtFechaFin.SelectionStart = 4
        ElseIf txtFechaFin.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            txtFechaFin.Text = txtFechaFin.Text & "/"
            txtFechaFin.SelectionStart = 6
        End If
    End Sub
    Private Sub BW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        Try

       
            Me.BW.ReportProgress(100, "Recalculando")
            sql = New SqlCommand("Recalcular_Costo_lotes_engordes", con)
            sql.CommandType = CommandType.StoredProcedure
            sql.Parameters.Add(New SqlParameter("@Codigo_Concentrado", SqlDbType.Char, 8, ParameterDirection.Input, False, 0, 0, "", DataRowVersion.Current, Codigo))
            sql.Parameters.Add(New SqlParameter("@Nuevo_Costo_Unitario", SqlDbType.Float, 100000000, ParameterDirection.Input, False, 0, 0, "", DataRowVersion.Current, NuevoCosto))
            sql.Parameters.Add(New SqlParameter("@Fecha_Inicio", SqlDbType.Date, 8, ParameterDirection.Input, False, 0, 0, "", DataRowVersion.Current, FechaInicio))
            sql.Parameters.Add(New SqlParameter("@Fecha_Fin", SqlDbType.Date, 8, ParameterDirection.Input, False, 0, 0, "", DataRowVersion.Current, FechaFin))
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error recalculando costos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

       
    End Sub

    Private Sub BW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BW.ProgressChanged
        Me.ProgressBarX1.Value = e.ProgressPercentage
    End Sub

    Private Sub BW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        Me.Finalizar()
    End Sub

    Private Sub btnInciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInciar.Click
        If Me.txtCodigoProducto.Text = "" Then
            MessageBoxEx.Show("Porfavor ingrese el código del concentrado que desea recalcular", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtCodigoProducto.Focus()
        ElseIf Me.txtNuevoCosto.Text = "0.00" Or Me.txtNuevoCosto.Text = "" Then
            MessageBoxEx.Show("Porfavor ingrese el nuevo costo del concentrado que va a recalcular", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtNuevoCosto.Focus()
        ElseIf Not IsDate(Me.txtFechaInicio.Text) Then
            MessageBoxEx.Show("La fecha ingresada es erronea, porfavor verifiquela y vuelva a intentarlo", "Error Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaInicio.Focus()
        ElseIf Not IsDate(Me.txtFechaFin.Text) Then
            MessageBoxEx.Show("La fecha ingresada es erronea, porfavor verifiquela y vuelva a intentarlo", "Error Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaFin.Focus()
        Else
            Iniciar()
        End If
    End Sub
End Class