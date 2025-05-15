Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmConsolidados_Concentrados_lotes__
    Dim Tipo As String = "C"
    


    Private Sub MostarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Reporte_Consolidado_Lotes_Engorde_x_fechasTableAdapter.Mostar(Me.DtsBDGRANJA.Reporte_Consolidado_Lotes_Engorde_x_fechas, Me.cbxGranjas.Text, New System.Nullable(Of Date)(CType(Me.txtFechaDesde.Text, Date)), New System.Nullable(Of Date)(CType(Me.txtFechaHasta.Text, Date)), Tipo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub chbxCosto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxCosto.CheckedChanged
        Tipo = "C"
    End Sub

    Private Sub chbxCantidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxCantidad.CheckedChanged
        Tipo = "Q"
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
    Private Sub frmConsolidados_Concentrados_lotes___Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostarGranjas()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Not IsDate(Me.txtFechaDesde.Text) Then
            MessageBoxEx.Show("La fecha desde que ha ingresado no es válida, porfavor verifiquela y vuelva a intentarlo", "Error fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaDesde.Focus()
        ElseIf Not IsDate(Me.txtFechaHasta.Text) Then
            MessageBoxEx.Show("La fecha hasta que ha ingresado no es válida, porfavor verifiquela y vuelva a intentarlo", "Error fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaHasta.Focus()
        Else
            If Me.chbxCosto.CheckState = CheckState.Checked Then
                Me.txtTipo.Text = "$"
            ElseIf Me.chbxCantidad.CheckState = CheckState.Checked Then
                Me.txtTipo.Text = "QQ"
            End If
            MostarToolStripButton_Click(sender, e)
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

   

    Private Sub Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CellLeave
        Try
            Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.EndEdit()
            If Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "Granja" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "LoteNo" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "FechaCreacion" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "NoDias" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "CostoNacer" Then
            Else
                Me.lbTotal.Text = "TOTAL " & Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).HeaderText.ToString
                Me.TextBoxX1.Text = Format(Sumar(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name.ToString, Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX), "###,###,###,###,###,###.00")
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.RowLeave
        Try
            Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.EndEdit()
            If Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "Granja" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "LoteNo" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "FechaCreacion" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "NoDias" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "CostoNacer" Then
            Else
                Me.lbTotal.Text = "TOTAL " & Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).HeaderText.ToString
                Me.TextBoxX1.Text = Format(Sumar(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name.ToString, Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX), "###,###,###,###,###,###.00")
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CellContentClick
        Try
            Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.EndEdit()
            If Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "Granja" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "LoteNo" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "FechaCreacion" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "NoDias" Or Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name = "CostoNacer" Then
            Else
                Me.lbTotal.Text = "TOTAL " & Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).HeaderText.ToString
                Me.TextBoxX1.Text = Format(Sumar(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.Columns(Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX.CurrentCell.ColumnIndex).Name.ToString, Me.Reporte_Consolidado_Lotes_Engorde_x_fechasDataGridViewX), "###,###,###,###,###,###.00")
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class