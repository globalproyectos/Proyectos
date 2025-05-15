Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmIngresoTraslados
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim dtsBDGRANJA As New DtsBDGRANJA
    Dim bodegasAdapter As New DtsBDGRANJATableAdapters.BodegasTableAdapter1
    Dim inventarioAdapter As New DtsBDGRANJATableAdapters.Inventario_MaterialesTableAdapter
    Dim costoxmesAdapter As New DtsBDGRANJATableAdapters.Costos_Concentrados_x_MesTableAdapter
    Dim trasladosencabezadosAdapter As New DtsBDGRANJATableAdapters.traslados_encabezadosTableAdapter
    Dim trasladosdetallesAdapter As New DtsBDGRANJATableAdapters.traslados_detallesTableAdapter
    Dim bstrasladosEncabezados As New BindingSource
    Dim bstrasladosDetalles As New BindingSource
    Dim msgrestriccion As Boolean = False

    Private Sub frmIngresoTraslados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.NuevoButtonX4.Text = "&Cancelar" Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Hay un registro en creación, si cierra la ventana se perderan los datos" & vbCrLf & vbCrLf & "¿Desea cerrar esta ventana de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = MsgBoxResult.Yes Then
                NuevoButtonX4_Click(sender, e)
            Else
                e.Cancel = True
            End If

        End If
    End Sub


    Private Sub frmIngresoTraslados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fechanaturalTextBoxX1.Text = Format(Today, "dd/MM/yyyy")
        'FechaSistema = "29/09/2013"
        'UsuarioActual = "JoseDuran"
        Me.fechaTextBoxX3.Text = FechaSistema
        'Me.trasladonoTextBoxX1.Text = trasladosencabezadosAdapter.GetCorrelativo()

        trasladosencabezadosAdapter.Fill(dtsBDGRANJA.traslados_encabezados)
        bstrasladosEncabezados.DataSource = dtsBDGRANJA
        bstrasladosEncabezados.DataMember = "traslados_encabezados"

        Me.trasladonoTextBoxX1.DataBindings.Add("text", bstrasladosEncabezados, "traslado_no", True, DataSourceUpdateMode.OnValidation)
        Me.documentoTextBoxX2.DataBindings.Add("text", bstrasladosEncabezados, "documento", True, DataSourceUpdateMode.OnValidation)
        Me.debodegaTextBoxX4.DataBindings.Add("text", bstrasladosEncabezados, "de_bodega", True, DataSourceUpdateMode.OnValidation)
        Me.abodegaTextBoxX6.DataBindings.Add("text", bstrasladosEncabezados, "a_bodega", True, DataSourceUpdateMode.OnValidation)
        Me.fechaTextBoxX3.DataBindings.Add("text", bstrasladosEncabezados, "fecha", True, DataSourceUpdateMode.OnValidation)
        Me.fechanaturalTextBoxX1.DataBindings.Add("text", bstrasladosEncabezados, "fecha_natural", True, DataSourceUpdateMode.OnValidation)
        Me.justificacionTextBoxX9.DataBindings.Add("text", bstrasladosEncabezados, "justificacion", True, DataSourceUpdateMode.OnValidation)
        Me.totalTextBoxX8.DataBindings.Add("text", bstrasladosEncabezados, "total_traslado", True, DataSourceUpdateMode.OnValidation)
        Me.LabelX9.DataBindings.Add("text", bstrasladosEncabezados, "no_items", True, DataSourceUpdateMode.OnValidation)

        cargardetalles()
        bstrasladosDetalles.DataSource = dtsBDGRANJA
        bstrasladosDetalles.DataMember = "traslados_detalles"

        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.DataSource = bstrasladosDetalles

        getnumber()

        AddHandler bstrasladosEncabezados.CurrentChanged, AddressOf bstrasladosEncabezados_indexchanged
        Me.GroupPanel4.Enabled = False

        descripcioncodigos()
        Me.bstrasladosEncabezados.MoveLast()


    End Sub
    Sub cargardetalles()
        If Me.trasladonoTextBoxX1.Text <> "" Then
            trasladosdetallesAdapter.Fill(dtsBDGRANJA.traslados_detalles, CInt(Me.trasladonoTextBoxX1.Text), Me.documentoTextBoxX2.Text)
            descripcioncodigos()
        End If

    End Sub
    Sub descripcioncodigos()
        For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
            Me.DataGridViewX1.Rows(i).Cells(2).Value = inventarioAdapter.GetDescripcion(Me.DataGridViewX1.Rows(i).Cells(1).Value)
        Next
    End Sub
    Private Sub bstrasladosEncabezados_indexchanged(ByVal sender As Object, ByVal e As EventArgs)
        cargardetalles()
        Me.LabelX9.Text = Me.DataGridViewX1.Rows.Count
        descripcioncodigos()

    End Sub
    Sub enumerar()
        Dim i As Integer
        For i = 0 To Me.DataGridViewX1.Rows.Count - 1
            'DetallesDataGridView.Rows(i).BeginEdit()
            Me.DataGridViewX1.Rows(i).Cells(0).Value = i + 1
            'carrito.Rows(i).EndEdit()
        Next
    End Sub
    Sub totalizar()
        Dim i As Integer
        Dim total As Double
        For i = 0 To Me.DataGridViewX1.Rows.Count - 1
            If Me.DataGridViewX1.Rows(i).Cells("importe").Value Is DBNull.Value = False Then
                total += Me.DataGridViewX1.Rows(i).Cells("importe").Value
            End If
        Next
        Me.totalTextBoxX8.Text = Format(total, "###,###,###,##0.00")
        Me.LabelX9.Text = Me.DataGridViewX1.RowCount

    End Sub
    Private Sub debodegaTextBoxX4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles debodegaTextBoxX4.TextChanged
        Me.debodegaDescTextBoxX5.Text = "" & bodegasAdapter.GetDescripcionBodega(debodegaTextBoxX4.Text)
    End Sub

    Private Sub abodegaTextBoxX6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abodegaTextBoxX6.TextChanged
        Me.abodegaDescTextBoxX7.Text = "" & bodegasAdapter.GetDescripcionBodega(abodegaTextBoxX6.Text)
    End Sub

    Private Sub DataGridViewX1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        enumerar()
        If Me.DataGridViewX1.Rows(e.RowIndex).Cells(1).Value Is DBNull.Value = False Then
            If Me.DataGridViewX1.Rows(e.RowIndex).Cells(1).Value <> "" Then
                Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                Me.DataGridViewX1.Rows(e.RowIndex).Cells(2).Value = inventarioAdapter.GetDescripcion(RTrim(Me.DataGridViewX1.Rows(e.RowIndex).Cells(1).Value))
                Me.DataGridViewX1.Rows(e.RowIndex).Cells(3).Value = costoxmesAdapter.GetCostoUnitarioMes(FechaSistema, RTrim(Me.DataGridViewX1.Rows(e.RowIndex).Cells(1).Value))
            Else

                Me.DataGridViewX1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Green
                Me.DataGridViewX1.Rows(e.RowIndex).Cells(2).Value = "<--- DIGITE EL CÓDIGO"
            End If
        End If
        totalizar()
        'Try
        If DataGridViewX1.Rows.Count > 0 Then
            If Me.DataGridViewX1.Rows(e.RowIndex).Cells(4).Value Is DBNull.Value = False Then
                Me.DataGridViewX1.Rows(e.RowIndex).Cells(5).Value = Val(Me.DataGridViewX1.Rows(e.RowIndex).Cells(3).Value) * (Me.DataGridViewX1.Rows(e.RowIndex).Cells(4).Value)
                Me.LabelX9.Text = Me.DataGridViewX1.Rows.Count
            End If
        End If

        'Catch ex As Exception
        '    'Me.DataGridViewX1.CurrentCell = Me.DataGridViewX1(5, Me.DataGridViewX1.CurrentCell.RowIndex)
        'End Try
    End Sub
    'Private Sub DataGridViewX1_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.RowLeave
    '    enumerar()
    'End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub LabelX9_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelX9.TextChanged
        If Val(Me.LabelX9.Text) > 0 Then
            Me.GroupPanel1.Enabled = False
            Me.GroupPanel2.Enabled = False
            Me.GroupPanel4.Enabled = False
        Else
            Me.GroupPanel1.Enabled = True
            Me.GroupPanel2.Enabled = True
            Me.GroupPanel4.Enabled = True
        End If

    End Sub

    Private Sub TextBoxX9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles justificacionTextBoxX9.LostFocus
        If Me.documentoTextBoxX2.Text <> "" And Me.debodegaTextBoxX4.Text <> "" And Me.abodegaTextBoxX6.Text <> "" And Me.debodegaDescTextBoxX5.Text <> "" And Me.abodegaDescTextBoxX7.Text <> "" And Me.justificacionTextBoxX9.Text <> "" Then
            Me.DataGridViewX1.Enabled = True
            Me.bstrasladosEncabezados.EndEdit()
            trasladosencabezadosAdapter.Update(dtsBDGRANJA.traslados_encabezados)

            dtsBDGRANJA.traslados_detalles.traslado_noColumn.DefaultValue = CInt(Me.trasladonoTextBoxX1.Text)
            dtsBDGRANJA.traslados_detalles.documentoColumn.DefaultValue = documentoTextBoxX2.Text
            dtsBDGRANJA.traslados_detalles.fechaColumn.DefaultValue = Me.fechaTextBoxX3.Text
            dtsBDGRANJA.traslados_detalles.de_bodegaColumn.DefaultValue = debodegaTextBoxX4.Text
            dtsBDGRANJA.traslados_detalles.a_bodegaColumn.DefaultValue = abodegaTextBoxX6.Text


            Me.bstrasladosDetalles.AddNew()
            Me.DataGridViewX1.Focus()
            Me.DataGridViewX1.CurrentCell = Me.DataGridViewX1(1, Me.DataGridViewX1.CurrentCell.RowIndex)
            Me.LabelX9.Text = Me.DataGridViewX1.Rows.Count


        End If
    End Sub

    Private Sub DataGridViewX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX1.KeyDown
        If e.KeyCode = Keys.A Then
            If Me.DataGridViewX1.Rows(Me.DataGridViewX1.CurrentCell.RowIndex).Cells(5).Value Is DBNull.Value = False Then
                If Me.DataGridViewX1.CurrentCell.ColumnIndex = 5 And Me.DataGridViewX1.Rows(Me.DataGridViewX1.CurrentCell.RowIndex).Cells(5).Value <> 0 Then
                    Try
                        totalizar()
                        Me.Validate()
                        Me.bstrasladosDetalles.EndEdit()
                        Me.bstrasladosEncabezados.EndEdit()
                        trasladosdetallesAdapter.Update(dtsBDGRANJA.traslados_detalles)
                        trasladosencabezadosAdapter.Update(dtsBDGRANJA.traslados_encabezados)


                        Me.bstrasladosDetalles.AddNew()
                        Me.DataGridViewX1.CurrentCell = Me.DataGridViewX1(1, Me.DataGridViewX1.CurrentCell.RowIndex)
                        Me.LabelX9.Text = Me.DataGridViewX1.Rows.Count
                    Catch ex As Exception
                        Dim msg As String = ex.Message.ToString
                        If msg.Substring(0, 31) = "Instrucción UPDATE en conflicto" Then
                            MessageBoxEx.Show("No hay existencias para cubrir su demanda, favor verificar", "Existencias agotadas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.DataGridViewX1.CurrentCell = Me.DataGridViewX1(1, Me.DataGridViewX1.CurrentCell.RowIndex)
                            Me.LabelX9.Text = Me.DataGridViewX1.Rows.Count
                        Else
                            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.DataGridViewX1.CurrentCell = Me.DataGridViewX1(1, Me.DataGridViewX1.CurrentCell.RowIndex)
                            Me.LabelX9.Text = Me.DataGridViewX1.Rows.Count
                        End If

                    End Try
                  
                End If
            End If
        End If

    End Sub
   
    Private Sub documentoTextBoxX2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles documentoTextBoxX2.LostFocus
        Me.documentoTextBoxX2.Text = UCase(Me.documentoTextBoxX2.Text)
    End Sub
    Sub getnumber()
        Me.panelnavTextBoxX1.Text = CStr(Me.bstrasladosEncabezados.Position + 1) & " de " & CStr(Me.bstrasladosEncabezados.Count)
    End Sub
    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButtonX7.Click
        Me.bstrasladosEncabezados.MoveNext()
        getnumber()
    End Sub

    Private Sub LastButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastButtonX6.Click
        Me.bstrasladosEncabezados.MoveLast()
        getnumber()
    End Sub

    Private Sub PreviousButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousButtonX5.Click
        Me.bstrasladosEncabezados.MovePrevious()
        getnumber()
    End Sub

    Private Sub FirstButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstButtonX3.Click
        Me.bstrasladosEncabezados.MoveFirst()
        getnumber()
    End Sub
    Private Sub documentoTextBoxX2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles documentoTextBoxX2.TextChanged
        Me.documentoTextBoxX2.Text = Me.documentoTextBoxX2.Text.Trim
    End Sub

    Private Sub trasladonoTextBoxX1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trasladonoTextBoxX1.TextChanged
        Me.trasladonoTextBoxX1.Text = Long.Parse(Me.trasladonoTextBoxX1.Text).ToString("00000000")
    End Sub

    Private Sub NuevoButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButtonX4.Click
        If Me.NuevoButtonX4.Text = "&Nuevo" Then
            Me.fechanaturalTextBoxX1.Text = Format(Today, "dd/MM/yyyy")
            Me.SuperValidator1.Enabled = True
            Me.GuardarButtonX2.Enabled = True
            Me.NavegacionGroupPanel6.Enabled = False
            Me.NuevoButtonX4.Text = "&Cancelar"
            Me.NuevoButtonX4.Image = New System.Drawing.Bitmap(My.Resources.DeleteRed)

            dtsBDGRANJA.traslados_encabezados.user_creadorColumn.DefaultValue = UsuarioActual
            dtsBDGRANJA.traslados_encabezados.no_itemsColumn.DefaultValue = CInt(Me.LabelX9.Text)
            Me.dtsBDGRANJA.traslados_encabezados.traslado_noColumn.DefaultValue = trasladosencabezadosAdapter.GetCorrelativo
            Me.dtsBDGRANJA.traslados_encabezados.fechaColumn.DefaultValue = FechaSistema
            Me.dtsBDGRANJA.traslados_encabezados.fecha_naturalColumn.DefaultValue = Format(Today, "dd/MM/yyyy")
            Me.dtsBDGRANJA.traslados_encabezados.total_trasladoColumn.DefaultValue = Format(0.0, "#0.00")

            Me.bstrasladosEncabezados.AddNew()
            getnumber()
            Me.GroupPanel1.Enabled = True
            Me.GroupPanel2.Enabled = True
            Me.GroupPanel4.Enabled = True
            Me.GroupPanel5.Enabled = True
            Me.documentoTextBoxX2.Focus()
        ElseIf Me.NuevoButtonX4.Text = "&Cancelar" Then
            Me.SuperValidator1.Enabled = False
            Me.DataGridViewX1.Enabled = False
            Me.NavegacionGroupPanel6.Enabled = True

            Me.SuperValidator1.ClearFailedValidations()
            Me.bstrasladosEncabezados.RemoveCurrent()
            getnumber()
            Me.GuardarButtonX2.Enabled = False
            Me.NuevoButtonX4.Text = "&Nuevo"
            Me.NuevoButtonX4.Image = New System.Drawing.Bitmap(My.Resources.tab_new_raised)
            Me.GroupPanel1.Enabled = False
            Me.GroupPanel2.Enabled = False
            Me.GroupPanel4.Enabled = False
            Me.GroupPanel5.Enabled = False

            Me.Validate()
            bstrasladosEncabezados.EndEdit()
            Me.trasladosencabezadosAdapter.Update(dtsBDGRANJA.traslados_encabezados)


            Try
                For I As Integer = 1 To Me.DataGridViewX1.Rows.Count - 1
                    bstrasladosDetalles.RemoveAt(I)
                Next
                bstrasladosDetalles.RemoveCurrent()
            Catch ex As Exception
            End Try
            
            bstrasladosDetalles.EndEdit()
            trasladosdetallesAdapter.Update(dtsBDGRANJA.traslados_detalles)

            Me.cargardetalles()
        End If
    End Sub

    Private Sub DataGridViewX1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridViewX1.DataError
        'NO BORRAR ESTE METODO
    End Sub

    Private Sub GuardarButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButtonX2.Click
        Try
            Me.Validate()
            bstrasladosEncabezados.EndEdit()
            bstrasladosDetalles.EndEdit()

            trasladosencabezadosAdapter.Update(dtsBDGRANJA.traslados_encabezados)
            trasladosdetallesAdapter.Update(dtsBDGRANJA.traslados_detalles)

            Me.DataGridViewX1.Enabled = False
            Me.GuardarButtonX2.Enabled = False
            Me.NuevoButtonX4.Text = "&Nuevo"
            Me.NuevoButtonX4.Image = New System.Drawing.Bitmap(My.Resources.tab_new_raised)
            Me.GroupPanel1.Enabled = False
            Me.GroupPanel2.Enabled = False
            Me.GroupPanel4.Enabled = False
            Me.GroupPanel5.Enabled = False
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       


    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub
End Class