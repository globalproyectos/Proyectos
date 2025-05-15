Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmSalidasFarmacos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim oDtsAlimentacion As New dtsAlimentacionBaseTabla
    Dim SalidaFarmacosAdapter As New dtsAlimentacionBaseTablaTableAdapters.SalidaFarmacosTableAdapter
    Dim DetSalidaFarmacosAdapter As New dtsAlimentacionBaseTablaTableAdapters.DetSalidaFarmacosTableAdapter
    Dim BodegaAdapter As New dtsAlimentacionBaseTablaTableAdapters.BodegasTableAdapter
    Dim materialesAdapter As New DtsBDGRANJATableAdapters.Inventario_MaterialesTableAdapter
    Dim existenciasAdapter As New dtsAlimentacionBaseTablaTableAdapters.ExistenciasTableAdapter
    Dim Proc_RecalculoSaldoMensualMateriales_X_CodigoAdapter As New dtsAlimentacionBaseTablaTableAdapters.Proc_RecalculoSaldoMensualMateriales_X_CodigoTableAdapter
    Dim etapasLotesAdapter As New dtsAlimentacionBaseTablaTableAdapters.EtapasSalidasFarmacosMaterialesTableAdapter
    Dim inventariomaterialesAdapter As New DtsBDGRANJATableAdapters.Inventario_MaterialesTableAdapter
    Dim nolinea As Integer

    Dim bsSalidaFarmacos As New BindingSource
    Dim bsDetSalidaFarmacos As New BindingSource
    Private Sub frmSalidasFarmacos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsAlimentacionBaseTabla.EtapasSalidasFarmacosMateriales' Puede moverla o quitarla según sea necesario.
        Me.EtapasSalidasFarmacosMaterialesTableAdapter.Fill(Me.DtsAlimentacionBaseTabla.EtapasSalidasFarmacosMateriales)
        'TODO: esta línea de código carga datos en la tabla 'DtsAlimentacionBaseTabla.Etapas_Cerdas_Lote' Puede moverla o quitarla según sea necesario.
        Me.Etapas_Cerdas_LoteTableAdapter.Fill(Me.DtsAlimentacionBaseTabla.Etapas_Cerdas_Lote)
        cargarsalidas()
        cargaretapas()
        Me.fechadigitacionTextBoxX2.Text = FechaSistema
        Me.usuarioTextBoxX3.Text = UsuarioSistema
        crearnuevo()
        recargarlineas()
    End Sub
    Sub crearnuevo()
        oDtsAlimentacion.SalidaFarmacos.FechaColumn.DefaultValue = FechaSistema
        oDtsAlimentacion.SalidaFarmacos.SalidaNoColumn.DefaultValue = SalidaFarmacosAdapter.GetNextCorrelativo()
        oDtsAlimentacion.SalidaFarmacos.UsuarioCreadorColumn.DefaultValue = UsuarioSistema
        oDtsAlimentacion.SalidaFarmacos.JustificacionColumn.DefaultValue = ""
        oDtsAlimentacion.SalidaFarmacos.TotalColumn.DefaultValue = 0
        oDtsAlimentacion.SalidaFarmacos.NoLineasColumn.DefaultValue = 0
        Me.bodegaTextBoxX3.Enabled = True
        Me.bodegaTextBoxX3.Focus()
        bsSalidaFarmacos.AddNew()
    End Sub
    Sub cargaretapas()
        Try
            etapaComboBoxEx1.DataSource = etapasLotesAdapter.GetData()
            etapaComboBoxEx1.DisplayMember = "Descripcion"
            etapaComboBoxEx1.ValueMember = "Id"


        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar etapas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarsalidas()
        Try
            SalidaFarmacosAdapter.Fill(oDtsAlimentacion.SalidaFarmacos)
            bsSalidaFarmacos.DataSource = oDtsAlimentacion.SalidaFarmacos

            Me.salidanoTextBoxX1.DataBindings.Clear()
            Me.fechadigitacionTextBoxX2.DataBindings.Clear()
            Me.justificacionTextBoxX5.DataBindings.Clear()
            Me.nolineasTextBoxX8.DataBindings.Clear()
            Me.usuarioTextBoxX3.DataBindings.Clear()
            Me.totalTextBoxX6.DataBindings.Clear()
            Me.bodegaTextBoxX3.DataBindings.Clear()

            Me.salidanoTextBoxX1.DataBindings.Add("Text", bsSalidaFarmacos, "SalidaNo", True, DataSourceUpdateMode.OnValidation)
            Me.fechadigitacionTextBoxX2.DataBindings.Add("Text", bsSalidaFarmacos, "Fecha", True, DataSourceUpdateMode.OnValidation)
            Me.justificacionTextBoxX5.DataBindings.Add("Text", bsSalidaFarmacos, "Justificacion", True, DataSourceUpdateMode.OnValidation)
            Me.nolineasTextBoxX8.DataBindings.Add("Text", bsSalidaFarmacos, "NoLineas", True, DataSourceUpdateMode.OnValidation)
            Me.usuarioTextBoxX3.DataBindings.Add("Text", bsSalidaFarmacos, "UsuarioCreador", True, DataSourceUpdateMode.OnValidation)
            Me.totalTextBoxX6.DataBindings.Add("Text", bsSalidaFarmacos, "Total", True, DataSourceUpdateMode.OnValidation)
            Me.bodegaTextBoxX3.DataBindings.Add("Text", bsSalidaFarmacos, "Bodega", True, DataSourceUpdateMode.OnValidation)

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar salidas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub recargarlineas()
        DetSalidaFarmacosAdapter.Fill(oDtsAlimentacion.DetSalidaFarmacos, bsSalidaFarmacos.Current(0))
        bsDetSalidaFarmacos.DataSource = oDtsAlimentacion.DetSalidaFarmacos

        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.DataSource = bsDetSalidaFarmacos
    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub bodegaTextBoxX3_KeyDown(sender As Object, e As KeyEventArgs) Handles bodegaTextBoxX3.KeyDown
        If e.KeyCode = Keys.F5 Then
            With My.Forms.dlgBodegas_existencias
                .txtDescripcionBodega.Text = ""
                .ventanallama = "salidafarmacos"
                .txtDescripcionBodega.Focus()
                .ShowDialog()

            End With
        End If
    End Sub
    Private Sub bodegaTextBoxX3_LostFocus(sender As Object, e As EventArgs) Handles bodegaTextBoxX3.LostFocus
        If RTrim(Me.bodegaTextBoxX3.Text) <> "" Then
            If BodegaAdapter.GetConteoBodega(Me.bodegaTextBoxX3.Text) > 0 Then
                Me.bodegadescripcionTextBoxX4.Text = BodegaAdapter.GetDescripcionBodega(Me.bodegaTextBoxX3.Text)
                Me.Panel2.Enabled = True
                Me.justificacionTextBoxX5.Focus()

            Else
                Me.bodegadescripcionTextBoxX4.Text = "LA BODEGA INGRESADA NO EXISTE"
                Me.Panel2.Enabled = False
                Me.bodegaTextBoxX3.Focus()
            End If
        End If
    End Sub

    Private Sub codigoTextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles codigoTextBoxX1.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ListaProductos.StartPosition = FormStartPosition.CenterParent
            My.Forms.ListaProductos.txtDescripcion.Clear()
            My.Forms.ListaProductos.ventanallama = "salidafarmacos"
            My.Forms.ListaProductos.ShowDialog()
        End If
    End Sub

    Private Sub codigoTextBoxX1_LostFocus(sender As Object, e As EventArgs) Handles codigoTextBoxX1.LostFocus
        If RTrim(Me.codigoTextBoxX1.Text) <> "" Then
            'MsgBox(RTrim(inventariomaterialesAdapter.GetEtapaMaterial(Me.codigoTextBoxX1.Text)))
            If RTrim(inventariomaterialesAdapter.GetTipoMaterial(Me.codigoTextBoxX1.Text)) <> "F" And RTrim(inventariomaterialesAdapter.GetTipoMaterial(Me.codigoTextBoxX1.Text)) <> "ME" Then
                Me.Panel2.Size = New Size(Panel2.Size.Width, 92)
                Me.Panel2.BackColor = Color.Red
                Me.errordetalleLabelX16.Text = "EL CÓDIGO DEBER SER DE TIPO FARMACO O MATERIAL, POR FAVOR VERIFIQUE EL CÓDIGO"
                Me.codigoTextBoxX1.Focus()
            Else
                Me.Panel2.Size = New Size(Panel2.Size.Width, 59)
                Me.Panel2.BackColor = Color.Transparent
                Me.errordetalleLabelX16.Text = ""

                If Me.materialesAdapter.GetContar(Me.codigoTextBoxX1.Text) > 0 Then
                    Me.descripcionTextBoxX2.Text = materialesAdapter.GetDescripcion(Me.codigoTextBoxX1.Text)
                    Dim existencia As Double = Math.Round(CDbl(existenciasAdapter.GetExistenciaActual(Me.codigoTextBoxX1.Text, Me.bodegaTextBoxX3.Text)), 2)


                    Proc_RecalculoSaldoMensualMateriales_X_CodigoAdapter.Fill(oDtsAlimentacion.Proc_RecalculoSaldoMensualMateriales_X_Codigo, SalidaFarmacosAdapter.GetMesNombre(FechaSistema), SalidaFarmacosAdapter.GetAño2Cifras(FechaSistema), FechaSistema, Me.codigoTextBoxX1.Text)
                    Me.unitarioTextBoxX3.Text = If(oDtsAlimentacion.Proc_RecalculoSaldoMensualMateriales_X_Codigo.Rows.Count > 0, oDtsAlimentacion.Proc_RecalculoSaldoMensualMateriales_X_Codigo.Rows(0).Item("CostoUnitario"), 0)
                    If Me.cantidadDoubleInput1.Value > 0 Then
                        Me.importeTextBoxX4.Text = Math.Round((CDbl(Me.cantidadDoubleInput1.Value) * CDbl(Me.unitarioTextBoxX3.Text)), 2)
                    End If


                    Dim cantidadconsumida As Double

                    For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                        If Me.DataGridViewX1.Rows(i).Cells("Codigo").Value = Me.codigoTextBoxX1.Text Then
                            cantidadconsumida += Me.DataGridViewX1.Rows(i).Cells("Cantidad").Value
                        End If
                    Next
                    Me.existenciaTextBoxX1.Text = (existencia - cantidadconsumida)
                Else
                    Me.descripcionTextBoxX2.Text = "EL CÓDIGO INGRESADO NO EXISTE"
                    Me.existenciaTextBoxX1.Text = ""
                    Me.unitarioTextBoxX3.Text = "0"
                    Me.codigoTextBoxX1.Focus()
                End If
            End If
        Else
            limpiardetallarproducto()
            Me.Panel2.Size = New Size(Panel2.Size.Width, 59)
            Me.Panel2.BackColor = Color.Transparent
            Me.errordetalleLabelX16.Text = ""
        End If
    End Sub
    Sub reconstruirexistencias()
        Dim _con As New SqlClient.SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
        Try
            Dim cmd As New SqlClient.SqlCommand("ActualizarExistencias", _con)
            cmd.CommandType = CommandType.StoredProcedure
            _con.Open()
            cmd.ExecuteNonQuery()
            _con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "<b>Error al reconstruir existencias</b>", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If _con.State = ConnectionState.Open Then
                _con.Close()
            End If
        End Try
    End Sub
    Private Sub cantidadDoubleInput1_KeyDown(sender As Object, e As KeyEventArgs) Handles cantidadDoubleInput1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX3_Click(sender, e)

        End If
    End Sub
    Private Sub cantidadDoubleInput1_LostFocus(sender As Object, e As EventArgs) Handles cantidadDoubleInput1.LostFocus
        If Me.cantidadDoubleInput1.Value > 0 Then
            Me.importeTextBoxX4.Text = Math.Round((CDbl(Me.cantidadDoubleInput1.Value) * CDbl(Me.unitarioTextBoxX3.Text)), 2)
        End If
    End Sub
    Sub limpiardetallarproducto()
        Me.codigoTextBoxX1.Clear()
        Me.descripcionTextBoxX2.Clear()
        Me.existenciaTextBoxX1.Text = "0.00"
        Me.cantidadDoubleInput1.Value = 0
        Me.unitarioTextBoxX3.Text = "0.00"
        Me.importeTextBoxX4.Text = "0.00"
        Me.cantidadcerdosIntegerInput1.Value = 0
        Me.cargaretapas()

    End Sub
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        If Me.descripcionTextBoxX2.Text = "" Or Me.descripcionTextBoxX2.Text = "EL CÓDIGO INGRESADO NO EXISTE" Then
            MessageBoxEx.Show("Debe ingresar un código válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.cantidadDoubleInput1.Value = 0 Then
            MessageBoxEx.Show("La cantidad debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CDbl(Me.cantidadDoubleInput1.Value) > CDbl(Me.existenciaTextBoxX1.Text) Then
            MessageBoxEx.Show("La cantidad ingresada sobrepasa la existencia actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            nolinea += 1
            Me.importeTextBoxX4.Text = CDbl(Me.cantidadDoubleInput1.Value) * CDbl(Me.unitarioTextBoxX3.Text)
            oDtsAlimentacion.DetSalidaFarmacos.SalidaNoColumn.DefaultValue = Me.salidanoTextBoxX1.Text
            oDtsAlimentacion.DetSalidaFarmacos.LineaNoColumn.DefaultValue = nolinea
            oDtsAlimentacion.DetSalidaFarmacos.FechaColumn.DefaultValue = fechadigitacionTextBoxX2.Text
            oDtsAlimentacion.DetSalidaFarmacos.CodigoColumn.DefaultValue = Me.codigoTextBoxX1.Text
            oDtsAlimentacion.DetSalidaFarmacos.DescripcionColumn.DefaultValue = Me.descripcionTextBoxX2.Text
            oDtsAlimentacion.DetSalidaFarmacos.CantidadColumn.DefaultValue = Me.cantidadDoubleInput1.Value
            oDtsAlimentacion.DetSalidaFarmacos.CostoUnitarioColumn.DefaultValue = Me.unitarioTextBoxX3.Text
            oDtsAlimentacion.DetSalidaFarmacos.ImporteColumn.DefaultValue = Me.importeTextBoxX4.Text
            oDtsAlimentacion.DetSalidaFarmacos.CantidadCerdosColumn.DefaultValue = Me.cantidadcerdosIntegerInput1.Value
            oDtsAlimentacion.DetSalidaFarmacos.IdEtapaColumn.DefaultValue = Me.etapaComboBoxEx1.SelectedValue
            oDtsAlimentacion.DetSalidaFarmacos.DetalleColumn.DefaultValue = ""
            oDtsAlimentacion.DetSalidaFarmacos.BodegaColumn.DefaultValue = Me.bodegaTextBoxX3.Text
            bsDetSalidaFarmacos.AddNew()
            limpiardetallarproducto()
            Me.codigoTextBoxX1.Focus()
            totalizar()
        End If
    End Sub
    Sub totalizar()
        Dim total As Double
        Me.nolineasTextBoxX8.Text = Me.DataGridViewX1.Rows.Count
        For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
            total += Me.DataGridViewX1.Rows(i).Cells("Importe").Value
        Next
        Me.totalTextBoxX6.Text = Math.Round(total, 2)
        If Me.DataGridViewX1.Rows.Count > 0 Then
            Me.bodegaTextBoxX3.Enabled = False
        Else
            Me.bodegaTextBoxX3.Enabled = True
        End If
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            If Me.DataGridViewX1.Rows.Count > 0 Then
                bsSalidaFarmacos.EndEdit()
                bsDetSalidaFarmacos.EndEdit()

                'SalidaFarmacosAdapter.Update(oDtsAlimentacion.SalidaFarmacos) 
                Dim lineas As Integer = 0
                lineas = Me.DataGridViewX1.RowCount - 1
                SalidaFarmacosAdapter.Insertar(Me.salidanoTextBoxX1.Text, Me.fechadigitacionTextBoxX2.Text, lineas, Me.totalTextBoxX6.Text, Me.usuarioTextBoxX3.Text, Me.justificacionTextBoxX5.Text, Me.bodegaTextBoxX3.Text)


                DetSalidaFarmacosAdapter.Update(oDtsAlimentacion.DetSalidaFarmacos)

                ActualizarExistencias()
                nolinea = 0
                crearnuevo()
                recargarlineas()
                MessageBoxEx.Show("Registro guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBoxEx.Show("El registro debe contener al menos un registro en el detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        If Me.DataGridViewX1.Rows.Count > 0 Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("¿Confirma que desea eliminar la fila seleccionada?", "Adevertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                bsDetSalidaFarmacos.RemoveCurrent()
                totalizar()
            End If
        Else
            MessageBoxEx.Show("No hay ningúna fila seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub cantidadcerdosIntegerInput1_KeyDown(sender As Object, e As KeyEventArgs) Handles cantidadcerdosIntegerInput1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX3_Click(sender, e)
        End If
    End Sub
    Private Sub etapaComboBoxEx1_KeyDown(sender As Object, e As KeyEventArgs) Handles etapaComboBoxEx1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX3_Click(sender, e)
        End If
    End Sub
    Private Sub codigoTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles codigoTextBoxX1.TextChanged

    End Sub
End Class