Public Class frmRegistrarSubidas_a_Partos
    Dim oDtsProcesoCerdas As New dtsProcesosCerdas
    Dim SubidasPrePartosAdapter As New dtsProcesosCerdasTableAdapters.SubidasPrePartosTableAdapter
    Dim Proc_SubidaPrePartoDetalle_x_SubidaNoTableAdapter As New dtsProcesosCerdasTableAdapters.Proc_SubidaPrePartoDetalle_x_SubidaNoTableAdapter
    Dim SubidasPrePartosDetalleTableAdapter As New dtsProcesosCerdasTableAdapters.SubidasPrePartosDetalleTableAdapter
    Dim rptSubidasPrePartoDataTableAdapter As New dtsProcesosCerdasTableAdapters.rptSubidasPrePartoDataTableAdapter
    Dim bsSubidas As New BindingSource
    Public bsSubidasDetalles As New BindingSource
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub frmRegistrarSubidas_a_Partos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlista()
        If Me.DataGridViewX1.Rows.Count > 0 Then
            cargardetalle(Me.DataGridViewX1.CurrentRow.Cells("SubidaNo").Value)
        End If

    End Sub
    Sub cargarlista()
        Try
            SubidasPrePartosAdapter.Fill(oDtsProcesoCerdas.SubidasPrePartos)
            bsSubidas.DataSource = oDtsProcesoCerdas.SubidasPrePartos
            'Me.DataGridView1.AutoGenerateColumns = False
            'Me.DataGridView1.DataSource = bsSubidas
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsSubidas

            Me.entregaTextBoxX2.DataBindings.Clear()
            Me.recibeTextBoxX3.DataBindings.Clear()
            Me.notaTextBoxX1.DataBindings.Clear()

            Me.entregaTextBoxX2.DataBindings.Add("Text", bsSubidas, "Entrega", False, DataSourceUpdateMode.OnValidation)
            Me.recibeTextBoxX3.DataBindings.Add("Text", bsSubidas, "Recibe", False, DataSourceUpdateMode.OnValidation)
            Me.notaTextBoxX1.DataBindings.Add("Text", bsSubidas, "Nota", False, DataSourceUpdateMode.OnValidation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargardetalle(ByVal SubidaNo As Integer)
        Try
            ' Proc_SubidaPrePartoDetalle_x_SubidaNoTableAdapter.Fill(oDtsProcesoCerdas.Proc_SubidaPrePartoDetalle_x_SubidaNo, SubidaNo, "")
            SubidasPrePartosDetalleTableAdapter.Fill(oDtsProcesoCerdas.SubidasPrePartosDetalle, SubidaNo)
            bsSubidasDetalles.DataSource = oDtsProcesoCerdas.SubidasPrePartosDetalle
            Me.DataGridViewX2.AutoGenerateColumns = False
            Me.DataGridViewX2.DataSource = bsSubidasDetalles
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar detalle de subida", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            oDtsProcesoCerdas.SubidasPrePartos.SubidaNoColumn.DefaultValue = SubidasPrePartosAdapter.GetNextSubidaNo()
            oDtsProcesoCerdas.SubidasPrePartos.FechaNaturalColumn.DefaultValue = Today & " " & TimeOfDay
            oDtsProcesoCerdas.SubidasPrePartos.FechaSistemaColumn.DefaultValue = FechaSistema
            oDtsProcesoCerdas.SubidasPrePartos.TotalCerdasColumn.DefaultValue = 0
            oDtsProcesoCerdas.SubidasPrePartos.EntregaColumn.DefaultValue = ""
            oDtsProcesoCerdas.SubidasPrePartos.RecibeColumn.DefaultValue = ""
            oDtsProcesoCerdas.SubidasPrePartos.NotaColumn.DefaultValue = ""
            oDtsProcesoCerdas.SubidasPrePartos.UsuarioColumn.DefaultValue = UsuarioActual
            bsSubidas.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al crear linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub validarimpreso()
        If If(IsDBNull(bsSubidas.Current("Impreso")), False, bsSubidas.Current("Impreso")) = False Then
            Me.imprimirButtonX2.Enabled = True
            Me.DataGridViewX2.ReadOnly = False
            Me.DataGridViewX1.CurrentCell.ReadOnly = False
            Me.entregaTextBoxX2.Enabled = True
            Me.recibeTextBoxX3.Enabled = True
            Me.notaTextBoxX1.Enabled = True
            Me.añadircerdasLinkLabel2.Enabled = True
            Me.btnGuardar.Enabled = True
        Else
            Me.imprimirButtonX2.Enabled = False
            Me.DataGridViewX2.ReadOnly = True
            Me.DataGridViewX1.CurrentCell.ReadOnly = True
            Me.entregaTextBoxX2.Enabled = False
            Me.recibeTextBoxX3.Enabled = False
            Me.notaTextBoxX1.Enabled = False
            Me.añadircerdasLinkLabel2.Enabled = False
            Me.btnGuardar.Enabled = False
        End If
    End Sub
    Private Sub DataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        cargardetalle(Me.DataGridViewX1.CurrentRow.Cells("SubidaNo").Value)
        validarimpreso()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles añadircerdasLinkLabel2.LinkClicked
        Try
            If Me.entregaTextBoxX2.Text.Trim = "" Then
                MessageBox.Show("Debe ingresar el nombre de quien entrega", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.entregaTextBoxX2.Focus()
            ElseIf Me.recibeTextBoxX3.Text.Trim = "" Then
                MessageBox.Show("Debe ingresar el nombre de quien recibe", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.recibeTextBoxX3.Focus()
            Else
                guardarcambios()
                Dim x As New frmAñadirCerdasPreParto
                With x
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .subidanoLabelX3.Text = bsSubidas.Current("SubidaNo")
                    .p_fechasubida = bsSubidas.Current("FechaSubida")
                    .ShowDialog()
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub guardarcambios()
        Try
            bsSubidas.Current("TotalCerdas") = Me.DataGridViewX2.RowCount
            bsSubidas.EndEdit()
            SubidasPrePartosAdapter.Update(oDtsProcesoCerdas.SubidasPrePartos)

            bsSubidasDetalles.EndEdit()
            SubidasPrePartosDetalleTableAdapter.Update(oDtsProcesoCerdas.SubidasPrePartosDetalle)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardarcambios()
    End Sub
    Private Sub entregaTextBoxX2_GotFocus(sender As Object, e As EventArgs) Handles entregaTextBoxX2.GotFocus
        Me.entregaTextBoxX2.Text.Trim()

    End Sub
    Private Sub imprimirButtonX2_Click(sender As Object, e As EventArgs) Handles imprimirButtonX2.Click
        Try
            If Me.DataGridViewX2.RowCount > 0 Then
                Dim resp As MsgBoxResult = MessageBox.Show("Si imprime la hoja de subida ya no podra realizar modificaciones" & vbCrLf & vbCrLf & "¿Esta seguro(a) de continuar con la impresión?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resp = MsgBoxResult.Ok Then
                    guardarcambios()
                    Dim rptSubidas As New rptSubidaPreParto
                    Dim vistaprevia As New frmVIstaPreviaImpresiones
                    rptSubidasPrePartoDataTableAdapter.Fill(oDtsProcesoCerdas.rptSubidasPrePartoData, bsSubidas.Current("SubidaNo"))
                    rptSubidas.SetDataSource(oDtsProcesoCerdas.Tables("rptSubidasPrePartoData"))
                    With vistaprevia
                        .CrystalReportViewer1.ReportSource = rptSubidas
                        .WindowState = FormWindowState.Maximized
                        .ShowDialog()
                    End With
                    bsSubidas.Current("Impreso") = True
                    guardarcambios()
                    validarimpreso()
                End If


            Else
                MessageBox.Show("No hay datos para imprimir, debe añadir cerdas a la lista primero", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub
End Class