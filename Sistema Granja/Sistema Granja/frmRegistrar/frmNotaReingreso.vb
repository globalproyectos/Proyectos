Public Class frmNotaReingreso
    Dim odtsNotasReingreso As New dtsNotasReingreso
    Dim Encabezado_SalidasTableAdapter As New dtsNotasReingresoTableAdapters.Encabezado_SalidasTableAdapter
    Dim NotaReingresoTableAdapter As New dtsNotasReingresoTableAdapters.NotaReingresoTableAdapter
    Dim DetNotaReingresoTableAdapter As New dtsNotasReingresoTableAdapters.DetNotaReingresoTableAdapter
    Dim rptNotaReingresoTableAdapter As New dtsNotasReingresoTableAdapters.rptNotaReingresoTableAdapter
    Private Sub frmNotaReingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.fechasistemaDateTimeInput1.Text = FechaSistema
        Me.usuarioTextBoxX2.Text = UsuarioActual
        Me.fechahoranatDateTimeInput2.Text = Today
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub quitarLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles quitarLinkLabel2.LinkClicked
        If Me.DataGridViewX1.Rows.Count > 0 Then
            If CInt(Me.CorrelativoTextBoxX1.Text) > 0 Then
                MessageBox.Show("Ya no puede quitar lineas a la nota de reingreso, debido a que ya se guardó. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Dim resp As MsgBoxResult = MessageBox.Show("Confirma que desea eliminar la fila seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    Me.DataGridViewX1.Rows.RemoveAt(Me.DataGridViewX1.CurrentCell.RowIndex)
                End If
            End If


        Else
            MessageBox.Show("No hay registros en la lista para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub añadirLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles añadirLinkLabel1.LinkClicked
        If IsNumeric(Me.salidanoIntegerInput1.Text) Then
            If CInt(Me.CorrelativoTextBoxX1.Text) > 0 Then
                MessageBox.Show("Ya no puede agregar lineas a la nota de reingreso, debido a que ya se guardó. Genere otra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf Encabezado_SalidasTableAdapter.GetExisteSalidaNo(Me.salidanoIntegerInput1.Text) = True Then
            With frmNotasReingresoAddDetalle
                    .salidano = Me.salidanoIntegerInput1.Text
                    .cbxAgreados.Items.Clear()
                    For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                        .cbxAgreados.Items.Add(Me.DataGridViewX1.Rows(i).Cells("Linea").Value)
                    Next
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With


            Else
                MessageBox.Show("El No. de sálida que ha ingresado no existe, favor validar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe ingresar un número de sálida valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Sub guardarnota()
        'Try
        Dim correlativo As Integer = NotaReingresoTableAdapter.GetNextCorrelativo()
            Me.CorrelativoTextBoxX1.Text = Format(correlativo, "0000000000")
        NotaReingresoTableAdapter.Insertar(correlativo, Me.documentoTextBoxX2.Text, Me.salidanoIntegerInput1.Text, Me.fechasistemaDateTimeInput1.Text, Me.fechahoranatDateTimeInput2.Text, UsuarioActual, Me.DataGridViewX1.RowCount, Me.JustificacionTextBoxX3.Text, "Pe")
        For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
            DetNotaReingresoTableAdapter.Insertar(correlativo, Me.DataGridViewX1.Rows(i).Cells("Linea").Value, Me.salidanoIntegerInput1.Text, Me.fechasistemaDateTimeInput1.Text, Me.DataGridViewX1.Rows(i).Cells("Lote_No").Value, Me.DataGridViewX1.Rows(i).Cells("Codigo").Value, Me.DataGridViewX1.Rows(i).Cells("Tipo_Salida").Value, Me.DataGridViewX1.Rows(i).Cells("Cantidad").Value, Me.DataGridViewX1.Rows(i).Cells("Unitario").Value, Me.DataGridViewX1.Rows(i).Cells("Importe").Value, Me.DataGridViewX1.Rows(i).Cells("Peso_Real_Lbs").Value, Me.DataGridViewX1.Rows(i).Cells("Peso_Prom_Lbs").Value, True, UsuarioActual, "", Me.DataGridViewX1.Rows(i).Cells("PrecioRealVenta").Value, 0, Me.DataGridViewX1.Rows(i).Cells("Motivo").Value, Me.DataGridViewX1.Rows(i).Cells("Ubicacion").Value, Me.DataGridViewX1.Rows(i).Cells("Comentario").Value)
        Next

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error al guardar nota de reingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub guardarButtonX2_Click(sender As Object, e As EventArgs) Handles guardarButtonX2.Click
        guardarnota()
    End Sub

    Private Sub CorrelativoTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles CorrelativoTextBoxX1.TextChanged
        If CInt(Me.CorrelativoTextBoxX1.Text) = 0 Then
            Me.guardarButtonX2.Enabled = True
            Me.imprimirButtonX3.Enabled = False
        Else
            Me.guardarButtonX2.Enabled = False
            Me.imprimirButtonX3.Enabled = True
        End If
    End Sub

    Private Sub salidanoIntegerInput1_ValueChanged(sender As Object, e As EventArgs) Handles salidanoIntegerInput1.ValueChanged
        Me.documentoTextBoxX2.Text = ""
        If Me.salidanoIntegerInput1.Text <> "" Then
            Me.documentoTextBoxX2.Text = Encabezado_SalidasTableAdapter.GetDocumento(CInt(Me.salidanoIntegerInput1.Text))
        Else
            Me.documentoTextBoxX2.Text = ""
        End If

    End Sub
    Sub crearnuevo()
        Me.CorrelativoTextBoxX1.Text = "0000000000"
        Me.salidanoIntegerInput1.Text = ""
        Me.documentoTextBoxX2.Text = ""
        Me.JustificacionTextBoxX3.Text = ""
        Me.DataGridViewX1.Rows.Clear()
    End Sub
    Private Sub imprimirButtonX3_Click(sender As Object, e As EventArgs) Handles imprimirButtonX3.Click
        'Try
        rptNotaReingresoTableAdapter.Fill(odtsNotasReingreso.rptNotaReingreso, Me.CorrelativoTextBoxX1.Text)
            Dim rptnotareingreso As New rptNotaReingreso
            rptnotareingreso.SetDataSource(odtsNotasReingreso.Tables("rptNotaReingreso"))
            Dim visualizador As New Visualizador
            With visualizador
                .CrReporteViewerç.ReportSource = rptnotareingreso
                .MdiParent = Me.MdiParent
                .Show()
            End With
            NotaReingresoTableAdapter.ActualizarEstado(Me.CorrelativoTextBoxX1.Text)
            Me.imprimirButtonX3.Enabled = False
            crearnuevo()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error al imprimir nota de reingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class