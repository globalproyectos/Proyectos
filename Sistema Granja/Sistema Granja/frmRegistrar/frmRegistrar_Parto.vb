Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmRegistrar_Parto
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim txtFecha_M As New TextBox
    Dim txtFecha_A As New TextBox
    Dim BorrandoCelda_M As Boolean
    Dim BorrandoCelda_A As Boolean
    Dim Lotes_Gestacion_ActivosTableAdapter As New DtsBDGRANJATableAdapters.Lotes_Gestacion_ActivosTableAdapter
    Sub TotalNacidos()
        Try
            Dim tvivos_M As Integer = 0
            Dim tvivos_A As Integer = 0
            Dim tmomias_M As Integer = 0
            Dim tmomias_A As Integer = 0
            Dim tmuertos_M As Integer = 0
            Dim tmuertos_A As Integer = 0

            For i As Integer = 0 To Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows.Count - 1
                tvivos_M += Val(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells(8).Value)
                tmomias_M += Val(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells(9).Value)
                tmuertos_M += Val(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells(10).Value)
            Next
            For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows.Count - 1
                tvivos_A += Val(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells(8).Value)
                tmomias_A += Val(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells(9).Value)
                tmuertos_A += Val(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells(10).Value)
            Next

            Me.lbVivos.Text = (tvivos_M + tvivos_A)
            Me.lbMomias.Text = (tmomias_M + tmomias_A)
            Me.lbMuertos.Text = (tmuertos_M + tmuertos_A)
            Me.lbNacidos.Text = (tvivos_M + tvivos_A + tmomias_M + tmomias_A + tmuertos_M + tmuertos_A)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmRegistrar_Parto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mostrar_LotesGestacion()
        Me.MostrarLotesLactancia()
        Me.PartoNoAuto()
        AddHandler Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.EditingControlShowing, AddressOf dataGridView1_EditingControlShowing_A
        AddHandler Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.EditingControlShowing, AddressOf dataGridView1_EditingControlShowing_M
    End Sub

    Private Sub dataGridView1_EditingControlShowing_M(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs)
        If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
            txtFecha_M = CType(e.Control, TextBox)
            AddHandler txtFecha_M.TextChanged, AddressOf tb_TextChanged_M
        End If
    End Sub
    Private Sub dataGridView1_EditingControlShowing_A(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs)
        If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
            txtFecha_A = CType(e.Control, TextBox)
            AddHandler txtFecha_A.TextChanged, AddressOf tb_TextChanged_A
        End If
    End Sub
    Private Sub tb_TextChanged_M(ByVal sender As Object, ByVal e As EventArgs)
        'If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
        '    If BorrandoCelda_M = False And Me.txtFecha_M.TextLength >= 2 Then
        '        If txtFecha_M.TextLength = 2 Then
        '            Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
        '            Me.txtFecha_M.SelectionStart = 3
        '        ElseIf Me.txtFecha_M.TextLength = 5 Then
        '            Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
        '            Me.txtFecha_M.SelectionStart = 6
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub tb_TextChanged_A(ByVal sender As Object, ByVal e As EventArgs)
        'If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
        '    If BorrandoCelda_A = False And Me.txtFecha_A.TextLength >= 2 Then
        '        If txtFecha_A.TextLength = 2 Then
        '            Me.txtFecha_A.Text = Me.txtFecha_A.Text & "/"
        '            Me.txtFecha_A.SelectionStart = 3
        '        ElseIf Me.txtFecha_A.TextLength = 5 Then
        '            Me.txtFecha_A.Text = Me.txtFecha_A.Text & "/"
        '            Me.txtFecha_A.SelectionStart = 6
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub FechaCelda_KeyPress_M(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
                If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Asc(e.KeyChar) <> 47 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If

            If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
                'If BorrandoCelda_M = False And Me.txtFecha_M.TextLength >= 2 Then
                If txtFecha_M.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
                    Me.txtFecha_M.SelectionStart = 3
                ElseIf Me.txtFecha_M.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
                    Me.txtFecha_M.SelectionStart = 6
                End If
                'End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FechaCelda_KeyPress_A(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
                If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Asc(e.KeyChar) <> 47 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If

            If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
                If txtFecha_A.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_A.Text = Me.txtFecha_A.Text & "/"
                    Me.txtFecha_A.SelectionStart = 3
                ElseIf Me.txtFecha_A.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_A.Text = Me.txtFecha_A.Text & "/"
                    Me.txtFecha_A.SelectionStart = 6
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub CellOnKeyDown_A(ByVal sender As Object, ByVal e As KeyEventArgs)
    '    Try

    '        If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
    '            If (e.KeyCode = Keys.Back) Then
    '                BorrandoCelda_A = True
    '            Else
    '                BorrandoCelda_A = False
    '            End If
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub CellOnKeyDown_M(ByVal sender As Object, ByVal e As KeyEventArgs)
    '    Try
    '        If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
    '            If (e.KeyCode = Keys.Back) Then
    '                BorrandoCelda_M = True
    '            Else
    '                BorrandoCelda_M = False
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Sub PartoNoAuto()
        Try
            Correlativo_Auto("SELECT MAX(Correlativo_Parto_No) FROM REG_PARTOS_X_CERDA", Me.txtPartoNo)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando Parto No Auto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Mostrar_LotesGestacion()
        Try
            Me.cbxLotesGestacion.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                           & " FROM LOTES l" _
                           & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                           & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                           & " where L.Estado <>'T' AND ((rm.Estado_Actual ='G' OR RA.Estado_Actual ='G'))" _
                           & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
                           & " ORDER BY L.IdEtapa_Cerdas"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesGestacion.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando Gestaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub MostrarLotesLactancia()
        Try
            Me.cbxLotesLactancia.Items.Clear()
            sql = New SqlCommand("select Lote_No from LOTES where IdEtapa_Cerdas='L' and Estado='A'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesLactancia.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando Lactancia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub APPendientesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Abuelas_PartosPendientesTableAdapter.APPendientes(Me.DtsBDGRANJA.Lista_Cerdas_Abuelas_PartosPendientes, Me.cbxLotesGestacion.Text)

            For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows.Count - 1
                If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells(13).Value = False Then
                    Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells(7).Value = Format(FechaSistema, "dd/MM/yy")
                Else
                    Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).ReadOnly = True
                End If

            Next
        Catch ex As System.Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub cbxLotesGestacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesGestacion.SelectedIndexChanged
        If Me.cbxLotesGestacion.Text <> "" Then
            'Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Visible = True
            'Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Visible = False
            APPendientesToolStripButton_Click(sender, e)
            MPPendientesToolStripButton_Click(sender, e)
            Me.lbRegistros.Text = Val(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows.Count) + Val(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows.Count)
        End If
    End Sub

    Private Sub Lista_Cerdas_Abuelas_PartosPendientesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        APPendientesToolStripButton_Click(sender, e)
    End Sub

    Private Sub Lista_Cerdas_Abuelas_PartosPendientesDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Abuelas_PartosPendientesDataGridView.CellEnter
        Try
            If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
                Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.BeginEdit(True)
            End If
            TotalNacidos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Lista_Cerdas_Abuelas_PartosPendientesDataGridView_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Abuelas_PartosPendientesDataGridView.CellLeave
        Try

            Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.EndEdit()
            Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPTotalNacidos").Value = (Val(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPNoVivos").Value) + Val(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPMomias").Value) + Val(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPMuertos").Value))
            'Me.lbNacidos.Text += Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPTotalNacidos").Value

            Dim FechaReal As Date = Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPFechaRealParto").Value
            Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPFechaDestete").Value = FechaReal.AddDays(Convert.ToInt32(ClaseCerdas.getConfiguracion(1)))
            Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.EndEdit()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbxLotesGestacion_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub MPPendientesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Madres_PartosPendientesTableAdapter.MPPendientes(Me.DtsBDGRANJA.Lista_Cerdas_Madres_PartosPendientes, Me.cbxLotesGestacion.Text)

            For i As Integer = 0 To Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows.Count - 1
                If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells(13).Value = False Then
                    Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells(7).Value = Format(FechaSistema, "dd/MM/yy")
                Else
                    Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).ReadOnly = True
                End If
            Next
        Catch ex As System.Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub rbtMadres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMadres.CheckedChanged
        Me.cbxLotesGestacion_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub rbtAbuelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAbuelas.CheckedChanged
        Me.cbxLotesGestacion_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub lbRegistros_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbRegistros.TextChanged
        'If Me.lbRegistros.Text = "0" Then
        '    Me.btnGuardar.Enabled = False
        'Else
        ''    Me.btnGuardar.Enabled = True
        'End If
    End Sub

    Private Sub Lista_Cerdas_Madres_PartosPendientesDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Madres_PartosPendientesDataGridView.CellEnter
        Try
            If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.CurrentCell.ColumnIndex = 7 Then
                Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.BeginEdit(True)
            End If
            TotalNacidos()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Lista_Cerdas_Madres_PartosPendientesDataGridView_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Madres_PartosPendientesDataGridView.CellLeave
        Try
            Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.EndEdit()
            Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPTotalNacidos").Value = (Val(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPNoVivos").Value) + Val(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPMomias").Value) + Val(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPMuertos").Value))
            'Me.lbNacidos.Text += Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPTotalNacidos").Value
            Dim FechaReal As Date = Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPFechaRealParto").Value
            Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPFechaDestete").Value = FechaReal.AddDays(Convert.ToInt32(ClaseCerdas.getConfiguracion(1)))
            Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.EndEdit()
        Catch ex As Exception

        End Try
       
    End Sub
    Sub Guardar_Parto_Madres()
        Try
            Dim NoPartos_a_Registrar As Integer = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows.Count - 1
                'If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells("MPPEstado").Value = True Then
                NoPartos_a_Registrar += 1
                'End If
            Next
           
            For I As Integer = 0 To Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows.Count - 1
                'If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPEstado").Value = True Then
                Dim FechaR1 As Date = "19 /01 /1999"
                If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells(11).Value > 0 Then
                    sql = New SqlCommand("insert into REG_PARTOS_X_CERDA values('" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPCodigoCerda").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPPartoNo").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPFechaInseminacion").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPVerraco").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPFechaEstParto").Value & "','" & FechaSistema & "','','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPFechaRealParto").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPNoVivos").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPMomias").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPMuertos").Value & "','" & 0 & "','" & 0 & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPFechaDestete").Value & "','" & 0 & "','" & 0 & "','" & 0 & "','" & True & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPIdIns").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPTotalNacidos").Value & "','" & False & "','" & FechaSistema & "','" & 0 & "','" & 0 & "','" & Me.txtPartoNo.Text & "','" & Me.cbxLotesGestacion.Text & "','" & FechaSistema & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MTotalPesoVivos").Value & "','" & 0 & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("insert into NoPartos_x_Cerda values('" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPIdIns").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPCodigoCerda").Value & "','" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPPartoNo").Value & "','" & Me.txtPartoNo.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("update REG_MADRES set Estado_Actual='L' where Código_Cerda='" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("update Estado_de_Partos set Estado_Parto='" & True & "' where Id_Enseminacion='" & Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    InsertarProcesoCerda(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPIdIns").Value, Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPCodigoCerda").Value, "Registro de Parto", FechaSistema, "Rp." & Trim(txtPartoNo.Text), Me.cbxLotesGestacion.Text, "E")
                    If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPNoVivos").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPIdIns").Value, "NoVivos", Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPNoVivos").Value, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesGestacion.Text), Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPCodigoCerda").Value, "Rp." & Trim(txtPartoNo.Text))
                    End If
                    If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPMomias").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPIdIns").Value, "Momias", Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPMomias").Value, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesGestacion.Text), Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPCodigoCerda").Value, "Rp." & Trim(txtPartoNo.Text))
                    End If
                    If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPMuertos").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPIdIns").Value, "NacMuertos", Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPMuertos").Value, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesGestacion.Text), Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(I).Cells("MPPCodigoCerda").Value, "Rp." & Trim(txtPartoNo.Text))
                    End If
                End If


                'End If
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar parto madres", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub Guardar_Parto_Abuelas()
        Try
            Dim NoPartos_a_Registrar As Integer = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows.Count - 1
                'If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells("APPEstado").Value = True Then
                NoPartos_a_Registrar += 1
                'End If
            Next

            For I As Integer = 0 To Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows.Count - 1
                'If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPEstado").Value = True Then
                Dim FechaR1 As Date = "19 /01 /1999"
                If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells(11).Value > 0 Then
                    sql = New SqlCommand("insert into REG_PARTOS_X_CERDA values('" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPCodigoCerda").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPPartoNo").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPFechaInseminacion").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPVerraco").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPFechaEstParto").Value & "','" & FechaSistema & "','','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPFechaRealParto").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPNoVivos").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPMomias").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPMuertos").Value & "','" & 0 & "','" & 0 & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPFechaDestete").Value & "','" & 0 & "','" & 0 & "','" & 0 & "','" & True & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPIdIns").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPTotalNacidos").Value & "','" & False & "','" & FechaSistema & "','" & 0 & "','" & 0 & "','" & Me.txtPartoNo.Text & "','" & Me.cbxLotesGestacion.Text & "','" & FechaSistema & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("ATotalPesoVivos").Value & "','" & 0 & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("insert into NoPartos_x_Cerda values('" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPIdIns").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPCodigoCerda").Value & "','" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPPartoNo").Value & "','" & Me.txtPartoNo.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("update REG_ABUELAS set Estado_Actual='L' where Código_Abuela='" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("update Estado_de_Partos set Estado_Parto='" & True & "' where Id_Enseminacion='" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("insert into No_Reemplazos_IdInseminacion values('" & Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPIdIns").Value & "','" & 0 & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    InsertarProcesoCerda(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPIdIns").Value, Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPCodigoCerda").Value, "Registro de Parto", FechaSistema, "Rp." & Trim(txtPartoNo.Text), Me.cbxLotesGestacion.Text, "E")

                    If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPNoVivos").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPIdIns").Value, "NoVivos", Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPNoVivos").Value, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesGestacion.Text), Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPCodigoCerda").Value, "Rp." & Trim(Me.txtPartoNo.Text))
                    End If
                    If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPMomias").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPIdIns").Value, "Momias", Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPMomias").Value, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesGestacion.Text), Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPCodigoCerda").Value, "Rp." & Trim(Me.txtPartoNo.Text))
                    End If
                    If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPMuertos").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPIdIns").Value, "NacMuertos", Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPMuertos").Value, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesGestacion.Text), Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(I).Cells("APPCodigoCerda").Value, "Rp." & Trim(Me.txtPartoNo.Text))
                    End If

                End If
               
                'End If
            Next

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar parto Abuelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Lista_Cerdas_Madres_PartosPendientesDataGridView_LostFocus(sender, e)
        Lista_Cerdas_Abuelas_PartosPendientesDataGridView_LostFocus(sender, e)


        Dim HayPartosMadres As Boolean = False
        Dim HayPartosAbuelas As Boolean = False
        For i As Integer = 0 To Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows.Count - 1
            'If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells("MPPEstado").Value = True Then
            HayPartosMadres = True
            'End If
        Next
        For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows.Count - 1
            'If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells("APPEstado").Value = True Then
            HayPartosAbuelas = True
            'End If
        Next
        If HayPartosAbuelas = True Or HayPartosMadres = True Then
            Dim NoPartos_a_Registrar As Integer = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows.Count - 1
                'If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells("MPPEstado").Value = True Then
                NoPartos_a_Registrar += 1
                'End If
            Next
            If NoPartos_a_Registrar > 0 Then
                Me.Guardar_Parto_Madres()
            End If
            'ElseIf Me.rbtAbuelas.Checked = True Then
            Dim NoPartos_a_Registrar2 As Integer = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows.Count - 1
                'If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells("APPEstado").Value = True Then
                NoPartos_a_Registrar2 += 1
                'End If
            Next
            If NoPartos_a_Registrar2 > 0 Then
                Me.Guardar_Parto_Abuelas()
            End If
            btnActualizar_Click(sender, e)
            Me.PartoNoAuto()
        End If

        'End If
    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        If Me.CheckBoxX1.CheckState = CheckState.Checked Then
            With My.Forms.frmRevicionDestetes
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub Lista_Cerdas_Madres_PartosPendientesDataGridView_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles Lista_Cerdas_Madres_PartosPendientesDataGridView.RowPrePaint
        If Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPFechaEstParto").Value < FechaSistema Then
            Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPFechaEstParto").Style.ForeColor = Color.Red
        Else
            Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("MPPFechaEstParto").Style.ForeColor = Color.Green
        End If
    End Sub
    Private Sub Lista_Cerdas_Abuelas_PartosPendientesDataGridView_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs)
        If Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPFechaEstParto").Value < FechaSistema Then
            Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPFechaEstParto").Style.ForeColor = Color.Red
        Else
            Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(e.RowIndex).Cells("APPFechaEstParto").Style.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnActualizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        'If Me.rbtMadres.Checked = True Then
        ExportarDatosExcel(Me.Lista_Cerdas_Madres_PartosPendientesDataGridView, "LISTA DE MADRES PENDIENTES DE PARTO", "", "FECHA: " & FechaSistema, "F")
        'ElseIf Me.rbtAbuelas.Checked = True Then
        ExportarDatosExcel(Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView, "LISTA DE ABUELAS PENDIENTES DE PARTO", "", "FECHA: " & FechaSistema, "F")
        'End If
    End Sub

   

    Private Sub Lista_Cerdas_Abuelas_PartosPendientesDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Lista_Cerdas_Abuelas_PartosPendientesDataGridView.EditingControlShowing
        Try
            'Dim cellTextBox As DataGridViewTextBoxEditingControl = TryCast(e.Control, DataGridViewTextBoxEditingControl)
            'RemoveHandler cellTextBox.KeyDown, AddressOf CellOnKeyDown_A
            'AddHandler cellTextBox.KeyDown, AddressOf CellOnKeyDown_A

            Dim FechaCelda As DataGridViewTextBoxEditingControl = TryCast(e.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler FechaCelda.KeyPress, AddressOf FechaCelda_KeyPress_A
            AddHandler FechaCelda.KeyPress, AddressOf FechaCelda_KeyPress_A
        Catch ex As Exception
        End Try
       
    End Sub

    Private Sub Lista_Cerdas_Madres_PartosPendientesDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Lista_Cerdas_Madres_PartosPendientesDataGridView.EditingControlShowing
        Try
            'Dim cellTextBox As DataGridViewTextBoxEditingControl = TryCast(e.Control, DataGridViewTextBoxEditingControl)
            'RemoveHandler cellTextBox.KeyDown, AddressOf CellOnKeyDown_M
            'AddHandler cellTextBox.KeyDown, AddressOf CellOnKeyDown_M

            Dim FechaCelda As DataGridViewTextBoxEditingControl = TryCast(e.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler FechaCelda.KeyPress, AddressOf FechaCelda_KeyPress_M
            AddHandler FechaCelda.KeyPress, AddressOf FechaCelda_KeyPress_M
        Catch ex As Exception
        End Try
        
    End Sub

   

    Private Sub Lista_Cerdas_Madres_PartosPendientesDataGridView_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista_Cerdas_Madres_PartosPendientesDataGridView.LostFocus
        Try
            For i As Integer = 0 To Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows.Count - 1
                Dim fecha As Date = Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells(7).Value
                Me.Lista_Cerdas_Madres_PartosPendientesDataGridView.Rows(i).Cells(12).Value = fecha.AddDays(Convert.ToInt32(ClaseCerdas.getConfiguracion(1)))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Lista_Cerdas_Abuelas_PartosPendientesDataGridView_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista_Cerdas_Abuelas_PartosPendientesDataGridView.LostFocus
        Try
            For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows.Count - 1
                Dim fecha As Date = Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells(7).Value
                Me.Lista_Cerdas_Abuelas_PartosPendientesDataGridView.Rows(i).Cells(12).Value = fecha.AddDays(Convert.ToInt32(ClaseCerdas.getConfiguracion(1)))
            Next
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub Lista_Cerdas_Madres_PartosPendientesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Madres_PartosPendientesDataGridView.CellContentClick

    End Sub
End Class