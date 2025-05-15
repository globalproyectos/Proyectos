Public Class frmNotasReingresoAddDetalle
    Inherits DevComponents.DotNetBar.Office2007Form
    Public cbxAgreados As New ComboBox
    Public salidano As Integer
    Dim odtsNotasReingreso As New dtsNotasReingreso
    Dim Lineas_de_SalidasTableAdapter As New dtsNotasReingresoTableAdapters.Lineas_de_SalidasTableAdapter
    Private Sub frmNotasReingresoAddDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar(salidano)
    End Sub
    Sub cargar(ByVal salidano As Integer)
        Try
            Lineas_de_SalidasTableAdapter.Fill(odtsNotasReingreso.Lineas_de_Salidas, salidano)
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = odtsNotasReingreso.Lineas_de_Salidas

            For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                For y As Integer = 0 To Me.cbxAgreados.Items.Count - 1
                    If Me.DataGridViewX1.Rows(i).Cells("LineaNo").Value = Me.cbxAgreados.Items(y).ToString Then

                        'Dim cbx As DataGridViewCheckBoxColumn
                        'cbx = DirectCast(Me.DataGridViewX1.Rows(i).Cells("Seleccionar").OwningColumn, DataGridViewCheckBoxColumn)
                        'cbx.FalseValue = True
                        Me.DataGridViewX1.Rows(i).Cells("Seleccionar").Value = True
                        Me.DataGridViewX1.Rows(i).ReadOnly = True
                        Exit For
                    End If

                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lineas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Try
            With frmNotaReingreso.DataGridViewX1
                .Rows.Clear()
                For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                    If Me.DataGridViewX1.Rows(i).Cells("Seleccionar").Value = True Then
                        .Rows.Add(Me.DataGridViewX1.Rows(i).Cells("LineaNo").Value, Me.DataGridViewX1.Rows(i).Cells("LoteNo").Value, Me.DataGridViewX1.Rows(i).Cells("Codigo").Value, Me.DataGridViewX1.Rows(i).Cells("TipoSalida").Value, Me.DataGridViewX1.Rows(i).Cells("Cantidad").Value, Me.DataGridViewX1.Rows(i).Cells("Unitario").Value, Me.DataGridViewX1.Rows(i).Cells("Importe").Value, Me.DataGridViewX1.Rows(i).Cells("PesoRealLbs").Value, Me.DataGridViewX1.Rows(i).Cells("PesoPromLbs").Value, Me.DataGridViewX1.Rows(i).Cells("PesoCanal").Value)
                    End If

                Next
            End With
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al adicionar lineas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
End Class