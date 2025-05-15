Public Class frmReporteSalidasFarmacosPorEtapa
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim cn As New SqlClient.SqlConnection(My.Settings.BDGRANJAConnectionString)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim cmd As New SqlClient.SqlCommand("select [SalidaNo], [Fecha], [Codigo], [Descripcion], [Cantidad], [Bodega], [idBodega], [Etapa]
                                                    from vReporteSalidasFarmacosXEtapa v
                                                    where v.Fecha between @desde and @hasta", cn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value = desdeDateTimeInput1.Value.Date
            cmd.Parameters.Add("@hasta", SqlDbType.DateTime).Value = hastaDateTimeInput2.Value.Date

            Dim resultado As New List(Of vReporteSalidasFarmacosXEtapa)
            Dim l As SqlClient.SqlDataReader
            cn.Open()
            l = cmd.ExecuteReader
            While l.Read
                Dim dato As New vReporteSalidasFarmacosXEtapa
                dato.SalidaNo = l(0)
                dato.Fecha = l(1)
                dato.Codigo = l(2)
                dato.Descripcion = l(3)
                dato.Cantidad = l(4)
                dato.Bodega = l(5)
                dato.idBodega = l(6)
                dato.Etapa = l(7)
                resultado.Add(dato)
            End While
            cn.Close()
            'Dim db As New GRANJAEntities
            'Dim datos = db.vReporteSalidasFarmacosXEtapa.Where(Function(a) a.Fecha.Date >= desdeDateTimeInput1.Value.Date And a.Fecha.Date <= hastaDateTimeInput2.Value.Date).ToList()
            Me.PivotGridControl1.DataSource = resultado


            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al generar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        With SFD
            .Filter = "Archivo de Excel|*.xlsx"
            If .ShowDialog = DialogResult.OK Then

                Me.PivotGridControl1.ExportToXlsx(.FileName)
                MessageBox.Show("Reporte exportado correctamente", "Exportar a archivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End With
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        With SFD
            .Filter = "Archivo en PDF|*.pdf"
            If .ShowDialog = DialogResult.OK Then
                Me.PivotGridControl1.ExportToPdf(.FileName)
                MessageBox.Show("Reporte exportado correctamente", "Exportar a archivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End With
    End Sub
End Class