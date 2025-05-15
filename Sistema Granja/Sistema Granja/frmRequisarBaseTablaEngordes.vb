Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmRequisarBaseTablaEngordes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim odtsAlimentacion As New dtsAlimentacionBaseTabla
    Dim NivelesAdapter As New dtsAlimentacionBaseTablaTableAdapters.TablaAlimentacionEngordesNivelesTableAdapter
    Dim BodegaAdapter As New dtsAlimentacionBaseTablaTableAdapters.BodegasTableAdapter
    Dim materialesAdapter As New DtsBDGRANJATableAdapters.Inventario_MaterialesTableAdapter
    Dim existenciasAdapter As New dtsAlimentacionBaseTablaTableAdapters.ExistenciasTableAdapter
    Dim distribucionPreviewAdapter As New dtsAlimentacionBaseTablaTableAdapters.Proc_DistribuirAlimentoEngordesPreviewTableAdapter
    Dim RepAlimentacionEngordesAdapter As New dtsAlimentacionBaseTablaTableAdapters.RepAlimentacionEngordesTableAdapter
    Private Sub frmRequisarBaseTablaEngordes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.fechaTextBoxX1.Text = FechaSistema
        cargarniveles()
        cargarinformedeldia()
    End Sub
    Sub cargarniveles()
        Try
            Me.nivelComboBoxEx1.DataSource = NivelesAdapter.GetData()
            Me.nivelComboBoxEx1.DisplayMember = "descripcion"
            Me.nivelComboBoxEx1.ValueMember = "nivel"
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar niveles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bodegaTextBoxX2_KeyDown(sender As Object, e As KeyEventArgs) Handles bodegaTextBoxX2.KeyDown
        If e.KeyCode = Keys.F5 Then
            With My.Forms.dlgBodegas_existencias
                .txtDescripcionBodega.Text = ""
                .ventanallama = "reqbasetabla"
                .txtDescripcionBodega.Focus()
                .ShowDialog()

            End With
        End If
    End Sub
    Private Sub bodegaTextBoxX2_LostFocus(sender As Object, e As EventArgs) Handles bodegaTextBoxX2.LostFocus
        If RTrim(Me.bodegaTextBoxX2.Text) <> "" Then
            If BodegaAdapter.GetConteoBodega(Me.bodegaTextBoxX2.Text) > 0 Then
                Me.bodegadescripcionTextBoxX3.Text = BodegaAdapter.GetDescripcionBodega(Me.bodegaTextBoxX2.Text)
            Else
                Me.bodegadescripcionTextBoxX3.Text = "LA BODEGA INGRESADA NO EXISTE"
                Me.bodegaTextBoxX2.Focus()
            End If
        End If
    End Sub

    Private Sub codigoprodTextBoxX4_KeyDown(sender As Object, e As KeyEventArgs) Handles codigoprodTextBoxX4.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ListaProductos.StartPosition = FormStartPosition.CenterParent
            My.Forms.ListaProductos.txtDescripcion.Clear()
            My.Forms.ListaProductos.ventanallama = "reqbasetabla"
            My.Forms.ListaProductos.ShowDialog()
        End If
    End Sub

   
    Private Sub codigoprodTextBoxX4_LostFocus(sender As Object, e As EventArgs) Handles codigoprodTextBoxX4.LostFocus
        If RTrim(Me.codigoprodTextBoxX4.Text) <> "" Then
            If Me.materialesAdapter.GetContar(Me.codigoprodTextBoxX4.Text) > 0 Then
                Me.descripcionproductoTextBoxX5.Text = materialesAdapter.GetDescripcion(Me.codigoprodTextBoxX4.Text)
                Me.etapaTextBoxX6.Text = materialesAdapter.GetEtapaMaterial(Me.codigoprodTextBoxX4.Text)
                Me.existenciaTextBoxX2.Text = Math.Round(CDbl(existenciasAdapter.GetExistenciaActual(Me.codigoprodTextBoxX4.Text, Me.bodegaTextBoxX2.Text)), 2)
            Else
                Me.descripcionproductoTextBoxX5.Text = "EL CÓDIGO INGRESADO NO EXISTE"
                Me.existenciaTextBoxX2.Text = ""
                Me.etapaTextBoxX6.Text = ""
                Me.codigoprodTextBoxX4.Focus()
            End If
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If Me.bodegadescripcionTextBoxX3.Text = "" Or Me.bodegadescripcionTextBoxX3.Text = "LA BODEGA INGRESADA NO EXISTE" Then
            MessageBoxEx.Show("Debe ingresar una bodega válida", "Error en bodega", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.bodegaTextBoxX2.Focus()
        ElseIf Me.descripcionproductoTextBoxX5.Text = "" Or Me.descripcionproductoTextBoxX5.Text = "EL CÓDIGO INGRESADO NO EXISTE" Then
            MessageBoxEx.Show("Debe ingresar un código de producto válido", "Error en código", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.codigoprodTextBoxX4.Focus()
        ElseIf Me.cantidadTextBoxX1.Value <= 0 Then
            MessageBoxEx.Show("La cantidad debe ser mayor a 0", "Error en cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cantidadTextBoxX1.Focus()
        ElseIf Me.cantidadTextBoxX1.Value > CDbl(Me.existenciaTextBoxX2.Text) Then
            MessageBoxEx.Show("La cantidad ingresada sobrepasa la existencia actual", "Error de existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = distribucionPreviewAdapter.GetData(Me.nivelComboBoxEx1.SelectedValue, Me.codigoprodTextBoxX4.Text, Me.cantidadTextBoxX1.Value, Me.fechaTextBoxX1.Text, Me.bodegaTextBoxX2.Text, UsuarioSistema)

            totalizar()
            cargarinformedeldia()
            If Me.DataGridViewX1.Rows.Count > 0 Then
                Me.btnprocesarButtonX2.Enabled = True
            Else
                Me.btnprocesarButtonX2.Enabled = False
            End If
        End If
    End Sub
    Sub totalizar()
        Dim totallbsguerido, totalqqsugerido, totalcerdos, porcentajesugerido, totallbsreal, totalqqreal, nolotes, diferencialbs, diferenciaqq As Double
        For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
            totallbsguerido += Me.DataGridViewX1.Rows(i).Cells(2).Value
            totalqqsugerido += Me.DataGridViewX1.Rows(i).Cells(3).Value
            totalcerdos += Me.DataGridViewX1.Rows(i).Cells(4).Value
            porcentajesugerido += CDbl(Me.DataGridViewX1.Rows(i).Cells(12).Value)
            totallbsreal += Me.DataGridViewX1.Rows(i).Cells(6).Value
            totalqqreal += Me.DataGridViewX1.Rows(i).Cells(7).Value
            nolotes += Me.DataGridViewX1.Rows(i).Cells(8).Value
            diferencialbs += Me.DataGridViewX1.Rows(i).Cells(10).Value
            diferenciaqq += Me.DataGridViewX1.Rows(i).Cells(11).Value

            If Me.DataGridViewX1.Rows(i).Cells(10).Value < 0 Then
                Me.DataGridViewX1.Rows(i).Cells(10).Style.ForeColor = Color.Red
            Else
                Me.DataGridViewX1.Rows(i).Cells(10).Style.ForeColor = Nothing
            End If

            If Me.DataGridViewX1.Rows(i).Cells(11).Value < 0 Then
                Me.DataGridViewX1.Rows(i).Cells(11).Style.ForeColor = Color.Red
            Else
                Me.DataGridViewX1.Rows(i).Cells(11).Style.ForeColor = Nothing
            End If
        Next

        Me.totalLibrasSugeridasLabelX8.Text = Format(totallbsguerido, "###,###,###,###,##0.00")
        Me.totalquintalessugeridasLabelX9.Text = Format(totalqqsugerido, "###,###,###,###,##0.00")
        Me.totalcerdosLabelX10.Text = Format(totalcerdos, "###,###,###,###,##0.00")
        Me.totalporcentajesugeridoLabelX11.Text = Format(porcentajesugerido, "##.00%")
        Me.totallibrasrealLabelX12.Text = Format(totallbsreal, "###,###,###,###,##0.00")
        Me.totalquintalesrealLabelX13.Text = Format(totalqqreal, "###,###,###,###,##0.00")
        Me.totalnolotesLabelX14.Text = Format(nolotes, "###,###,###,###,##0.00")

        If diferencialbs < 0 Then
            Me.totaldiferencialibrasLabelX16.ForeColor = Color.Red
        Else
            Me.totaldiferencialibrasLabelX16.ForeColor = Nothing
        End If

        If diferenciaqq < 0 Then
            Me.totaldiferenciaquintalesLabelX17.ForeColor = Color.Red
        Else
            Me.totaldiferenciaquintalesLabelX17.ForeColor = Nothing
        End If

        Me.totaldiferencialibrasLabelX16.Text = Format(diferencialbs, "###,###,###,###,##0.00")
        Me.totaldiferenciaquintalesLabelX17.Text = Format(diferenciaqq, "###,###,###,###,##0.00")

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles btnprocesarButtonX2.Click
        Dim resp As MsgBoxResult = MessageBoxEx.Show("Confirma el proceso de distribucción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = MsgBoxResult.Yes Then
            Try

                If Me.bodegadescripcionTextBoxX3.Text = "" Or Me.bodegadescripcionTextBoxX3.Text = "LA BODEGA INGRESADA NO EXISTE" Then
                    MessageBoxEx.Show("Debe ingresar una bodega válida", "Error en bodega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.bodegaTextBoxX2.Focus()
                ElseIf Me.descripcionproductoTextBoxX5.Text = "" Or Me.descripcionproductoTextBoxX5.Text = "EL CÓDIGO INGRESADO NO EXISTE" Then
                    MessageBoxEx.Show("Debe ingresar un código de producto válido", "Error en código", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.codigoprodTextBoxX4.Focus()
                ElseIf Me.cantidadTextBoxX1.Value <= 0 Then
                    MessageBoxEx.Show("La cantidad debe ser mayor a 0", "Error en cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.cantidadTextBoxX1.Focus()
                ElseIf Me.cantidadTextBoxX1.Value > CDbl(Me.existenciaTextBoxX2.Text) Then
                    MessageBoxEx.Show("La cantidad ingresada sobrepasa la existencia actual", "Error de existencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim dr As DataRow
                    Dim _dt As New DataTable("resultado")
                    With _dt.Columns
                        .Add(New DataColumn("codigo"))
                        .Add(New DataColumn("mensaje"))
                    End With



                    Dim _con As New SqlClient.SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
                    Dim cmd As New SqlClient.SqlCommand("Proc_DistribuirAlimentoEngordes", _con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 10000000
                    cmd.Parameters.Add("@Nivel", SqlDbType.Int).Value = Me.nivelComboBoxEx1.SelectedValue
                    cmd.Parameters.Add("@Codigo", SqlDbType.Char).Value = Me.codigoprodTextBoxX4.Text
                    cmd.Parameters.Add("@CantidadQQ", SqlDbType.Decimal).Value = Me.cantidadTextBoxX1.Value
                    cmd.Parameters.Add("@FechaDigitacion", SqlDbType.Date).Value = CDate(Me.fechaTextBoxX1.Text)
                    cmd.Parameters.Add("@DeBodega", SqlDbType.Char).Value = Me.bodegaTextBoxX2.Text
                    cmd.Parameters.Add("@Usuario", SqlDbType.Char).Value = UsuarioSistema


                    _con.Open()
                    leer = cmd.ExecuteReader
                    While leer.Read
                        dr = _dt.NewRow
                        dr(0) = leer(0)
                        dr(1) = leer(1)
                        _dt.Rows.Add(dr)
                    End While
                    _con.Close()
                    If _dt.Rows(0).Item(0) = 1 Then
                        Dim msj As String = _dt.Rows(0).Item(1)
                        MessageBoxEx.Show(msj, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpiar()
                        cargarinformedeldia()
                        If Me.DataGridViewX1.Rows.Count > 0 Then
                            Me.btnprocesarButtonX2.Enabled = True
                        Else
                            Me.btnprocesarButtonX2.Enabled = False
                        End If
                    Else
                        Dim msj As String = _dt.Rows(0).Item(1)
                        MessageBoxEx.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If


            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
    Sub limpiar()
        Me.codigoprodTextBoxX4.Text = ""
        Me.descripcionproductoTextBoxX5.Text = ""
        Me.etapaTextBoxX6.Text = ""
        Me.cantidadTextBoxX1.Value = 0
        Me.existenciaTextBoxX2.Text = "0"
        Me.DataGridViewX1.DataSource = Nothing
        Me.totalcerdosLabelX10.Text = "0.00"
        Me.totaldiferencialibrasLabelX16.Text = "0.00"
        Me.totaldiferenciaquintalesLabelX17.Text = "0.00"
        Me.totallibrasrealLabelX12.Text = "0.00"
        Me.totalLibrasSugeridasLabelX8.Text = "0.00"
        Me.totalnolotesLabelX14.Text = "0.00"
        Me.totalporcentajesugeridoLabelX11.Text = "0.00"
        Me.totalquintalesrealLabelX13.Text = "0.00"
        Me.totalquintalessugeridasLabelX9.Text = "0.00"

    End Sub
    Sub cargarinformedeldia()
        Try
            Me.DataGridViewX2.DataSource = RepAlimentacionEngordesAdapter.GetData(Me.fechaTextBoxX1.Text)
            Dim alimentados, sinalimentar, total As Integer
            For i As Integer = 0 To Me.DataGridViewX2.Rows.Count - 1
                If Me.DataGridViewX2.Rows(i).Cells("CantidadRealQQ").Value > 0 Then
                    alimentados += 1
                Else
                    sinalimentar += 1
                End If
                total += 1
            Next
            Me.alimentadosLabelX8.Text = "Alimentado(s) " & Trim(CStr(alimentados)) & " de " & Trim(CStr(total))
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bodegaTextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles bodegaTextBoxX2.TextChanged

    End Sub

    Private Sub codigoprodTextBoxX4_TextChanged(sender As Object, e As EventArgs) Handles codigoprodTextBoxX4.TextChanged

    End Sub
End Class