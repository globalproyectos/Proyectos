Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmPesoSubidaEngorde
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim odtsPesos As New dtsPesosCerdosProcesos
    Dim pesosSubidaEngordeAdapter As New dtsPesosCerdosProcesosTableAdapters.PesoSubidaEngordeTableAdapter
    Dim bsPesosSubida As New BindingSource
    Private Sub frmPesoSubidaEngorde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsPesosCerdosProcesos.Lotes' Puede moverla o quitarla según sea necesario.

        cargardatos()
        Me.LotesTableAdapter.Fill(Me.DtsPesosCerdosProcesos.Lotes)
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Sub cargardatos()
        Try
            pesosSubidaEngordeAdapter.Fill(odtsPesos.PesoSubidaEngorde, FechaSistema)
            bsPesosSubida.DataSource = odtsPesos.PesoSubidaEngorde
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsPesosSubida
            odtsPesos.PesoSubidaEngorde.FechaSistemaColumn.DefaultValue = FechaSistema
            odtsPesos.PesoSubidaEngorde.UsuarioColumn.DefaultValue = UsuarioActual
            odtsPesos.PesoSubidaEngorde.FechaHoraRegistroColumn.DefaultValue = Today

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewX1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.RowEnter

    End Sub

   

  

    Private Sub DataGridViewX1_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.RowLeave
        Try

      
        Dim fila As Integer = e.RowIndex
        If LotesTableAdapter.GetExiste(If(IsDBNull(Me.DataGridViewX1.Rows(e.RowIndex).Cells("Lote").Value) = True, 0, Me.DataGridViewX1.Rows(e.RowIndex).Cells("Lote").Value)) = 0 And IsDBNull(Me.DataGridViewX1.Rows(e.RowIndex).Cells("Lote").Value) = False Then
            Me.DataGridViewX1.Rows(e.RowIndex).Cells("vacia").Value = "Error: Lote no existe o ya fue liquidado"
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        Else
            Me.DataGridViewX1.Rows(e.RowIndex).Cells("vacia").Value = ""
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
            Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Try
            Dim errores As Integer = 0
            For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                If Me.DataGridViewX1.Rows(i).Cells("vacia").Value <> "" Then
                    errores += 1
                End If
            Next
            If errores > 0 Then
                MessageBoxEx.Show("Hay errores que debe corregir, no puede continuar hasta que los corrija", "Errores detectados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                bsPesosSubida.CancelEdit()
                pesosSubidaEngordeAdapter.Update(odtsPesos.PesoSubidaEngorde)
                MessageBoxEx.Show("Se ha guardado la información exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class