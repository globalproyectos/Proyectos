Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class dlgRevision_Inseminaciones_Pendientes_Comprobadas
    Dim dtPendientes_A As New DataTable
    Dim dtConfirmados_A As New DataTable
    Dim dtPendientes_M As New DataTable
    Dim dtConfirmados_M As New DataTable
    Dim DataSource_PendientesA As New BindingSource
    Dim DataSource_PendientesM As New BindingSource
    Dim DataSource_ConfirmadosA As New BindingSource
    Dim DataSource_ConfirmadosM As New BindingSource
    Dim estado As String = "P"
    Dim seVa_aGrabar As Boolean = False
    Dim existeLote As Boolean = False
    Dim presionoGuardar_y_MarcoHerrores As Boolean = False

    Dim odtsGranja As New DtsBDGRANJA
    Dim madresAdapter As New DtsBDGRANJATableAdapters.Reg_MadresTableAdapter
    Dim abuelasAdapter As New DtsBDGRANJATableAdapters.Reg_AbuelasTableAdapter

    Sub MostrarLotes_Montas()
        Try
            Me.cbxLotesMontas.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                           & " FROM LOTES l" _
                           & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                           & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                           & " where L.Estado <>'T' AND IdEtapa_Cerdas='M' AND ((rm.Estado_Actual ='P' OR RA.Estado_Actual ='P'))" _
                           & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
                           & " ORDER BY L.IdEtapa_Cerdas"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesMontas.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando Lotes Montas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub Mostrar_LotesGestacion()
        Try
            Me.cbxLotesGestacion.Items.Clear()
            'Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
            '             & " FROM LOTES l" _
            '             & "  JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
            '             & "  JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
            '             & " where L.Estado <>'T' and l.IdEtapa_Cerdas='G' AND l.IdEtapa_Cerdas<>'L'" _
            '             & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
            '             & " ORDER BY L.IdEtapa_Cerdas"
            Dim cmd As String = "select distinct rm.lote_no from Reg_Madres rm join Lotes l on rm.Lote_No = rm.Lote_No where l.Estado <>'T' and rm.Estado_Actual ='G'" _
                            & " UNION" _
                            & " select distinct rm.lote_no from Reg_Abuelas  rm join Lotes l on rm.Lote_No = rm.Lote_No where l.Estado <>'T' and rm.Estado_Actual ='G'"

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
    Private Sub dlgRevision_Inseminaciones_Pendientes_Comprobadas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        With My.Forms.frmRegistro_Inseminacion
            .CheckBoxX1.CheckState = CheckState.Unchecked
        End With
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub cbxLas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLas.SelectedIndexChanged
        If Me.cbxLas.SelectedItem.ToString = "PENDIENTES" Then
            For i As Integer = 0 To Me.cbxLotesMontas.Items.Count - 1
                Me.cbxLotesMontas.SelectedIndex = i
            Next
            Me.cbxLotesMontas.Enabled = True
            Me.cbxLotesGestacion.Enabled = False
            Me.cbxLotesGestacion.Text = ""
            If Me.cbxLotesMontas.Text <> "" Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            ElseIf Me.cbxLotesGestacion.Text <> "" Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            End If
        ElseIf Me.cbxLas.SelectedItem.ToString = "CONFIRMADOS" Then
            For i As Integer = 0 To Me.cbxLotesGestacion.Items.Count - 1
                Me.cbxLotesGestacion.SelectedIndex = i
            Next
            Me.cbxLotesMontas.Enabled = False
            Me.cbxLotesGestacion.Enabled = True
            Me.cbxLotesMontas.Text = ""
            If Me.cbxLotesGestacion.Text <> "" Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            ElseIf Me.cbxLotesMontas.Text <> "" Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            End If
        End If
    End Sub

   
    Private Sub AConfirmadasToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Abuelas_ConfirmadasTableAdapter.AConfirmadas(Me.DtsBDGRANJA.Lista_Cerdas_Abuelas_Confirmadas, Me.cbxLotesGestacion.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
   Private Sub dlgRevision_Inseminaciones_Pendientes_Comprobadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mostrar_LotesGestacion()
        Me.MostrarLotes_Montas()
        ConfirmacionAuto()
        presionoGuardar_y_MarcoHerrores = False
    End Sub
    'Sub GrabarConfirmacion()
    '    Try

    '    Catch ex As Exception
    '        MessageBoxEx.Show(CadenaError & ex.Message, "Error al grabar confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        con.Close()
    '    End Try
    'End Sub
    Private Sub cbxLotesMontas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesMontas.SelectedIndexChanged
        Try
            'If Me.rbtAbuelas.Checked = True Then
            If Me.cbxLas.Text = "PENDIENTES" Then
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Visible = True
                Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Visible = False
                Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Visible = False
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Visible = True
                APendientesToolStripButton_Click(sender, e)
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Focus()

            ElseIf Me.cbxLas.Text = "CONFIRMADOS" Then
                Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Visible = True
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Visible = False
                Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Visible = True
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Visible = False
                AConfirmadasToolStripButton_Click(sender, e)
                Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Focus()
            Else
                Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Visible = False
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Visible = False
                Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Visible = False
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Visible = False
            End If
            'ElseIf Me.rbtMadres.Checked = True Then
            If Me.cbxLas.Text = "PENDIENTES" Then
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Visible = True
                Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Visible = False
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Visible = True
                Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Visible = False
                MPendientesToolStripButton_Click(sender, e)
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Focus()
            ElseIf Me.cbxLas.Text = "CONFIRMADOS" Then
                Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Visible = True
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Visible = False
                Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Visible = True
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Visible = False
                MConfirmadasToolStripButton_Click(sender, e)
                Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Focus()
            Else
                Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Visible = False
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Visible = False
                Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Visible = False
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Visible = False
            End If
            'End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar Cerdas Abuelas Inseminadas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub APendientesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Abuelas_PendientesTableAdapter.APendientes(Me.DtsBDGRANJA.Lista_Cerdas_Abuelas_Pendientes, Me.cbxLotesMontas.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub rbtAbuelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAbuelas.CheckedChanged

        If Me.cbxLotesMontas.Text <> "" Then
            If Me.rbtAbuelas.Checked = True Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            End If
        ElseIf Me.cbxLotesGestacion.Text <> "" Then
            If Me.rbtAbuelas.Checked = True Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            End If
        End If
    End Sub

    Private Sub rbtMadres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMadres.CheckedChanged
        If Me.cbxLotesMontas.Text <> "" Then
            If Me.rbtMadres.Checked = True Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            End If
        ElseIf Me.cbxLotesGestacion.Text <> "" Then
            If Me.rbtMadres.Checked = True Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            End If
        End If
       
    End Sub

    Private Sub cbxLotesGestacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLotesGestacion.LostFocus
        existeLote = False
        sql = New SqlCommand("select Lote_No from LOTES where Lote_No='" & Me.cbxLotesGestacion.Text & "' and IdEtapa_Cerdas='G' and Estado='A'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            existeLote = True
        End While
        con.Close()
    End Sub

    Private Sub cbxLotesGestacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesGestacion.SelectedIndexChanged
        If seVa_aGrabar = False Then
            If Me.cbxLotesMontas.Text <> "" Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            ElseIf Me.cbxLotesGestacion.Text <> "" Then
                cbxLotesMontas_SelectedIndexChanged(sender, e)
            End If
        End If
       End Sub

    Private Sub AConfirmadasToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Abuelas_ConfirmadasTableAdapter.AConfirmadas(Me.DtsBDGRANJA.Lista_Cerdas_Abuelas_Confirmadas, Me.cbxLotesGestacion.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub APendientesToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Abuelas_PendientesTableAdapter.APendientes(Me.DtsBDGRANJA.Lista_Cerdas_Abuelas_Pendientes, Me.cbxLotesMontas.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Lista_Cerdas_Abuelas_PendientesDataGridViewX_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Abuelas_PendientesDataGridViewX.CellLeave
        Dim DepreciacionCosto As Double = 0
        Dim DepreciacionPartos As Integer = 0
        Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.EndEdit()
        sql = New SqlCommand("select isnull((Depreciacion_Costo),0), isnull((Depreciacion_Partos),1) FROM Depreciacion_x_Cerda where Codigo_Cerda='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells("APCodigoCerda").Value & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            DepreciacionCosto = leer(0)
            DepreciacionPartos = leer(1)
        End While
        con.Close()

        If abuelasAdapter.GetSeDeprecia(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells("APCodigoCerda").Value) = True Then
            If DepreciacionPartos > 0 Then
                If Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells("APEstado").Value = "CONFIRMADO" Then
                    Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells("APDepreciacion").Value = ((DepreciacionCosto - abuelasAdapter.GetValorResidual(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells("APCodigoCerda").Value)) / DepreciacionPartos)
                Else
                    Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells("APDepreciacion").Value = 0
                End If
            Else
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells("APDepreciacion").Value = 0
            End If
        End If
        If presionoGuardar_y_MarcoHerrores = True Then
            If RTrim(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells(6).Value) = "PENDIENTE" Then
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            ElseIf IsDBNull(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).Cells(6).Value) Then
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            Else
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
            End If
        End If
    End Sub
    Private Sub Lista_Cerdas_Madres_PendientesDataGridViewX_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Madres_PendientesDataGridViewX.CellLeave
        Me.Lista_Cerdas_Madres_PendientesDataGridViewX.EndEdit()
        Dim DepreciacionCosto As Double = 0
        Dim DepreciacionPartos As Integer = 0
        sql = New SqlCommand("select isnull((Depreciacion_Costo),0), isnull((Depreciacion_Partos),1) FROM Depreciacion_x_Cerda where Codigo_Cerda='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells("MPCodigoCerda").Value & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            DepreciacionCosto = leer(0)
            DepreciacionPartos = leer(1)
        End While
        con.Close()
        If madresAdapter.GetSeDeperecia(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells("MPCodigoCerda").Value) = True Then
            If DepreciacionPartos > 0 Then
                If Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells("MPEstado").Value = "CONFIRMADO" Then
                    Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells("MPDepreciacion").Value = ((madresAdapter.GetValorDepreciarMadre(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells("MPCodigoCerda").Value)))
                Else
                    Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells("MPDepreciacion").Value = 0
                End If
            Else
                If presionoGuardar_y_MarcoHerrores = True Then
                    If RTrim(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells(6).Value) = "PENDIENTE" Then
                        Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                    ElseIf IsDBNull(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells(6).Value) Then
                        Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                    Else
                        Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
                    End If
                End If
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(e.RowIndex).Cells("MPDepreciacion").Value = 0
            End If
        End If

    End Sub
    Private Sub Lista_Cerdas_Abuelas_PendientesDataGridViewX_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Lista_Cerdas_Abuelas_PendientesDataGridViewX.DataError
    End Sub
    '***************NO BORRAR********************************
    Private Sub Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.CellContentClick
    End Sub
    Private Sub Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.DataError
    End Sub
    '********************************************************
    Private Sub MConfirmadasToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Madres_ConfirmadasTableAdapter.MConfirmadas(Me.DtsBDGRANJA.Lista_Cerdas_Madres_Confirmadas, Me.cbxLotesGestacion.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MPendientesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Madres_PendientesTableAdapter.MPendientes(Me.DtsBDGRANJA.Lista_Cerdas_Madres_Pendientes, Me.cbxLotesMontas.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    '******************NO BORRAR********************************
    Private Sub Lista_Cerdas_Madres_PendientesDataGridViewX_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Lista_Cerdas_Madres_PendientesDataGridViewX.DataError
    End Sub
    Private Sub Lista_Cerdas_Madres_ConfirmadasDataGridViewX_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Lista_Cerdas_Madres_ConfirmadasDataGridViewX.DataError
    End Sub
    '***************************************************************

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.cbxLotesMontas.Text <> "" Then
            cbxLotesMontas_SelectedIndexChanged(sender, e)
        ElseIf Me.cbxLotesGestacion.Text <> "" Then
            cbxLotesMontas_SelectedIndexChanged(sender, e)
        End If
    End Sub
    Sub Guardar_Cambios_Cerdas_Abuelas_Pendientes()
        Try
            Dim NoDepreciaciones_a As Integer = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.RowCount - 1
                If Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APEstado").Value = "CONFIRMADO" Then
                    '*****************RECORDAR HALAR COSTOS A LOTE QUE SE MOVERAN****************
                    'AQUI!!
                    '****************************************************************************
                    sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='" & Me.cbxLotesGestacion.Text & "', Estado_Actual='G' WHERE Código_Abuela='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    sql = New SqlCommand("UPDATE Reg_Enseminaciones_x_cerda SET Estado='C' WHERE Código_Cerda='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "' and Id_Enseminacion='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("insert into Registro_Confirmaciones values('" & Me.txtConfirmacionNo.Text & "','" & Me.cbxLotesGestacion.Text & "','" & UsuarioActual & "','" & FechaSistema & "','" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "', " & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value & ")", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    
                   
                    If Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APDepreciacion").Value > 0 Then
                        NoDepreciaciones_a += 1
                        RevisarDepreciacion(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value, Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APDepreciacion").Value, FechaSistema)

                        Dim PartosDpc As Integer = 0
                        sql = New SqlCommand("select isnull((Depreciacion_Partos),0) from Depreciacion_x_Cerda where Codigo_Cerda='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "'", con)
                        con.Open()
                        leer = sql.ExecuteReader
                        While leer.Read
                            PartosDpc = leer(0)
                        End While
                        con.Close()

                        sql = New SqlCommand("insert into Historial_Dpc values('" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "','" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APDepreciacion").Value & "','" & FechaSistema & "','" & (PartosDpc) & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        sql = New SqlCommand("insert into MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) values('" & Me.cbxLotesMontas.Text & "','" & Me.cbxLotesGestacion.Text & "','" & FechaSistema & "','DEPRECIACION ABUELA: " & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "','" & 1 & "','" & UsuarioActual & "','" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APDepreciacion").Value & "','Ca." & Me.txtConfirmacionNo.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        sql = New SqlCommand("insert into Historico_Depreciaciones_Cerdas (codigo, valor_depreciado , quedan , fecha , lote ,documento, id_inseminacion) values('" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "','" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APDepreciacion").Value & "','" & (PartosDpc) & "','" & FechaSistema & "','" & Me.cbxLotesGestacion.Text & "','Ca." & Me.txtConfirmacionNo.Text & "','" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                    End If

                    InsertarProcesoCerda(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value, Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value, "Inseminacion Confirmada", FechaSistema, "Ca." & Me.txtConfirmacionNo.Text, Me.cbxLotesMontas.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value, Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value, "Inseminacion Confirmada", FechaSistema, "Ca." & Me.txtConfirmacionNo.Text, Me.cbxLotesGestacion.Text, "E")
                    '************************************************************
                ElseIf Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APEstado").Value = "NULO" Then
                    '*************************REGRESA LAS CERDAS AL CORRAL DE LAS VACIAS**********************

                    sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='" & 5 & "', Estado_Actual='V' WHERE Código_Abuela='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("UPDATE Reg_Enseminaciones_x_cerda SET Estado='N' WHERE Código_Cerda='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "' and Id_Enseminacion='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    Actualizar_Estado_Parto(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value, True)


                    Dim NoNegacion As Integer = 0
                    sql = New SqlCommand("select MAX(No_Negaciones) FROM Registro_Inseminaciones_nulas_x_Cerdas WHERE Codigo_Cerda='" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        If leer.IsDBNull(0) = True Then
                            NoNegacion = 1
                        Else
                            NoNegacion = leer(1) + 1
                        End If
                    End While
                    con.Close()
                    sql = New SqlCommand("insert into Registro_Inseminaciones_nulas_x_Cerdas values('" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value & "','" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value & "','" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APFechaInseminacion").Value & "','" & FechaSistema & "','" & NoNegacion & "','" & Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APVerraco").Value & "','" & Me.txtConfirmacionNo.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    RegistrarMovimientoLote(Me.cbxLotesMontas.Text, 0, 0, 0, 0, 0, 1, FechaSistema, "Ca." & Me.txtConfirmacionNo.Text)
                    RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Ca." & Me.txtConfirmacionNo.Text)

                    InsertarProcesoCerda(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value, Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value, "Inseminacion Nula", FechaSistema, "Ca." & Me.txtConfirmacionNo.Text, Me.cbxLotesMontas.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APIdIns").Value, Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APCodigoCerda").Value, "Inseminacion Nula", FechaSistema, "Ca." & Me.txtConfirmacionNo.Text, "5", "E")
                End If
            Next
            Dim Cerdas_que_salen_de_montas_a_gestacion As Integer = 0
            Dim Cerdas_que_se_van_de_vacias_a_montas As Integer = 0
            Dim CostoInseminacion As Double = 0
            Dim Depreciacion As Double = 0
            For I As Integer = 0 To Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows.Count - 1
                If Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(I).Cells("APEstado").Value = "CONFIRMADO" Then
                    Cerdas_que_salen_de_montas_a_gestacion += 1
                    Depreciacion += Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(I).Cells("APDepreciacion").Value
                ElseIf Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(I).Cells("APEstado").Value = "NULO" Then
                    Cerdas_que_se_van_de_vacias_a_montas += 1
                End If
            Next
            Dim CerdasTotales As Integer = 0
            For I As Integer = 0 To Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows.Count - 1
                CostoInseminacion += Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(I).Cells("APCosto").Value
                CerdasTotales += 1
            Next
            If Cerdas_que_salen_de_montas_a_gestacion <> 0 Then
                If NoDepreciaciones_a > 0 Then
                    sql = New SqlCommand("INSERT INTO Entradas_Lotes_Costos VALUES('" & Me.cbxLotesGestacion.Text & "','" & Depreciacion & "','Dpc." & Me.txtConfirmacionNo.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                End If
                AgregarNoCerdas_Movimientos_Costos(Me.cbxLotesGestacion.Text, Cerdas_que_salen_de_montas_a_gestacion)
                RegistrarMovimientoLote(Me.cbxLotesMontas.Text.ToString, 0, 0, 0, 0, 0, Cerdas_que_salen_de_montas_a_gestacion, FechaSistema, "Ca." & Me.txtConfirmacionNo.Text)
                RegistrarMovimientoLote(Me.cbxLotesGestacion.Text.ToString, 0, 0, 0, 0, Cerdas_que_salen_de_montas_a_gestacion, 0, FechaSistema, "Ca." & Me.txtConfirmacionNo.Text)
                ActualizarLote()
                HalarCostos_Montas_a_Gestacion(Me.cbxLotesMontas.Text, Me.cbxLotesGestacion.Text, FechaSistema, "CERDAS ABUELAS-SALEN DE MONTAS A GESTACION", Cerdas_que_salen_de_montas_a_gestacion, CerdasTotales, "Ca." & Me.txtConfirmacionNo.Text)

            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar cambios en cerdas abuelas Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub Guardar_Cambios_Cerdas_Abuelas_Confirmadas()
        Try
            For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.RowCount - 1
                If Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACEstado").Value = "ABORTADO" Then
                    '*************************REGRESA LAS CERDAS AL CORRAL DE LAS VACIAS**********************
                    sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='" & 5 & "', Estado_Actual='V' WHERE Código_Abuela='" & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("UPDATE Reg_Enseminaciones_x_cerda SET Estado='A' WHERE Código_Cerda='" & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACCodigoCerda").Value & "' and Id_Enseminacion='" & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    Dim NoAbortos As Integer = 0
                    sql = New SqlCommand("select ISNULL(MAX(No_Aborto),0) FROM Registro_Aborto_x_Cerda WHERE Codigo_Cerda='" & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACCodigoCerda").Value & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        If leer.IsDBNull(0) = True Then
                            NoAbortos = 1
                        Else
                            NoAbortos = leer(0) + 1
                        End If
                    End While
                    con.Close()
                    sql = New SqlCommand("insert into Registro_Aborto_x_Cerda values('" & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value & "','" & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACCodigoCerda").Value & "','" & NoAbortos & "','" & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACFechaInseminacion").Value & "','" & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACVerraco").Value & "','" & FechaSistema & "','DESCONOCIDO'," & Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACNoDias").Value & ")", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    Actualizar_Estado_Parto(Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value, True)
                    RegistrarMovimientoLote(Me.cbxLotesGestacion.Text, 0, 0, 0, 0, 0, 1, FechaSistema, "Ca." & CStr(Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value))
                    RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Ca." & CStr(Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value))

                    InsertarProcesoCerda(Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value, Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACCodigoCerda").Value, "Registro de Aborto", FechaSistema, "Ca." & CStr(Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value), Me.cbxLotesGestacion.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value, Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACCodigoCerda").Value, "Registro de Aborto", FechaSistema, "Ca." & CStr(Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.Rows(i).Cells("ACIdIns").Value), "5", "E")
                End If
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar cambios en cerdas abuelas Confirmadas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub Guardar_Cambios_Cerdas_Madres_Pendientes()
        Try
            Dim NoDepreciaciones_a As Integer = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Madres_PendientesDataGridViewX.RowCount - 1
                If Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPEstado").Value = "CONFIRMADO" Then
                    '*****************RECORDAR HALAR COSTOS A LOTE QUE SE MOVERAN****************
                    'AQUI!!
                    '****************************************************************************

                    sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='" & Me.cbxLotesGestacion.Text & "', Estado_Actual='G' WHERE Código_Cerda='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    sql = New SqlCommand("UPDATE Reg_Enseminaciones_x_cerda SET Estado='C' WHERE Código_Cerda='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "' and Id_Enseminacion='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    'RevisarDepreciacion(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value, Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPDepreciacion").Value, FechaSistema)
                    sql = New SqlCommand("insert into Registro_Confirmaciones values('" & Me.txtConfirmacionNo.Text & "','" & Me.cbxLotesGestacion.Text & "','" & UsuarioActual & "','" & FechaSistema & "','" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "', " & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value & ")", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()


                    If Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPDepreciacion").Value > 0 Then
                        NoDepreciaciones_a += 1
                        RevisarDepreciacion(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value, Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPDepreciacion").Value, FechaSistema)

                        Dim PartosDpc As Integer = 0
                        sql = New SqlCommand("select isnull((Depreciacion_Partos),0) from Depreciacion_x_Cerda where Codigo_Cerda='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "'", con)
                        con.Open()
                        leer = sql.ExecuteReader
                        While leer.Read
                            PartosDpc = leer(0)
                        End While
                        con.Close()

                        sql = New SqlCommand("insert into Historial_Dpc values('" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "','" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPDepreciacion").Value & "','" & FechaSistema & "','" & (PartosDpc) & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        sql = New SqlCommand("insert into MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) values('" & Me.cbxLotesMontas.Text & "','" & Me.cbxLotesGestacion.Text & "','" & FechaSistema & "','DEPRECIACION C40: " & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "','" & 1 & "','" & UsuarioActual & "','" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPDepreciacion").Value & "','Ca." & Me.txtConfirmacionNo.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        sql = New SqlCommand("insert into Historico_Depreciaciones_Cerdas (codigo, valor_depreciado , quedan , fecha , lote ,documento, id_inseminacion) values('" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "','" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPDepreciacion").Value & "','" & (PartosDpc) & "','" & FechaSistema & "','" & Me.cbxLotesGestacion.Text & "','Ca." & Me.txtConfirmacionNo.Text & "','" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                    End If

                    InsertarProcesoCerda(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value, Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value, "Inseminacion confirmada", FechaSistema, "Ca." & Me.txtConfirmacionNo.Text, Me.cbxLotesMontas.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value, Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value, "Inseminacion confirmada", FechaSistema, "Ca." & Me.txtConfirmacionNo.Text, Me.cbxLotesGestacion.Text, "E")
                ElseIf Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPEstado").Value = "NULO" Then
                    '*************************REGRESA LAS CERDAS AL CORRAL DE LAS VACIAS**********************
                    sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='" & 5 & "', Estado_Actual='V' WHERE Código_Cerda='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("UPDATE Reg_Enseminaciones_x_cerda SET Estado='N' WHERE Código_Cerda='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "' and Id_Enseminacion='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    Actualizar_Estado_Parto(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value, True)

                    Dim NoNegacion As Integer = 0
                    sql = New SqlCommand("select MAX(No_Negaciones) FROM Registro_Inseminaciones_nulas_x_Cerdas WHERE Codigo_Cerda='" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        If leer.IsDBNull(0) = True Then
                            NoNegacion = 1
                        Else
                            NoNegacion = leer(0) + 1
                        End If
                    End While
                    con.Close()
                    sql = New SqlCommand("insert into Registro_Inseminaciones_nulas_x_Cerdas values('" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value & "','" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value & "','" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPFechaInseminacion").Value & "','" & FechaSistema & "','" & NoNegacion & "','" & Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPVerraco").Value & "','" & Me.txtConfirmacionNo.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    RegistrarMovimientoLote(Me.cbxLotesMontas.Text.ToString, 0, 0, 0, 0, 0, 1, FechaSistema, "Ca." & Me.txtConfirmacionNo.Text)
                    RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Ca." & Me.txtConfirmacionNo.Text)

                    InsertarProcesoCerda(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value, Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value, "Inseminacion Nula", FechaSistema, "Ca." & Me.txtConfirmacionNo.Text, Me.cbxLotesMontas.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPIdIns").Value, Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPCodigoCerda").Value, "Inseminacion Nula", FechaSistema, "Ca." & Me.txtConfirmacionNo.Text, "5", "E")
                End If
            Next
            Dim Cerdas_que_salen_de_montas_a_gestacion As Integer = 0
            Dim cerdas_que_se_va_de_montas_a_vacias As Integer = 0
            Dim CostoInseminacion As Double = 0
            Dim Depreciacion As Double = 0
            For I As Integer = 0 To Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows.Count - 1
                If Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(I).Cells("MPEstado").Value = "CONFIRMADO" Then
                    Cerdas_que_salen_de_montas_a_gestacion += 1
                    Depreciacion += Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(I).Cells("MPDepreciacion").Value
                ElseIf Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(I).Cells("MPEstado").Value = "NULO" Then
                    cerdas_que_se_va_de_montas_a_vacias += 1
                End If
            Next
            Dim NoTolasCerdas As Integer = 0
            For I As Integer = 0 To Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows.Count - 1
                CostoInseminacion += Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(I).Cells("MPCosto").Value
                NoTolasCerdas += 1
            Next
            If Cerdas_que_salen_de_montas_a_gestacion <> 0 Then
                'sql = New SqlCommand("INSERT INTO Entradas_Lotes_Costos VALUES('" & Me.cbxLotesGestacion.Text & "','" & Depreciacion & "','Dpc." & Me.txtConfirmacionNo.Text & "')", con)
                'con.Open()
                'sql.ExecuteNonQuery()
                'con.Close()
                RegistrarMovimientoLote(Me.cbxLotesMontas.Text.ToString, 0, 0, 0, 0, 0, Cerdas_que_salen_de_montas_a_gestacion, FechaSistema, "Ca." & Me.txtConfirmacionNo.Text)
                RegistrarMovimientoLote(Me.cbxLotesGestacion.Text, 0, 0, 0, 0, Cerdas_que_salen_de_montas_a_gestacion, 0, FechaSistema, "Ca." & Me.txtConfirmacionNo.Text)
                ActualizarLote()
                HalarCostos_Montas_a_Gestacion(Me.cbxLotesMontas.Text, Me.cbxLotesGestacion.Text, FechaSistema, "CERDAS MADRES-SALEN DE MONTAS A GESTACION", Cerdas_que_salen_de_montas_a_gestacion, NoTolasCerdas, "Ca." & Me.txtConfirmacionNo.Text)
                AgregarNoCerdas_Movimientos_Costos(Me.cbxLotesGestacion.Text, Cerdas_que_salen_de_montas_a_gestacion)
            End If

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar cambios en cerdas madres Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub Guardar_Cambios_Cerdas_Madres_Confirmadas()
        Try

            For i As Integer = 0 To Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.RowCount - 1
                If Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCEstado").Value = "ABORTADO" Then
                    '*************************REGRESA LAS CERDAS AL CORRAL DE LAS VACIAS**********************

                    sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='" & 5 & "', Estado_Actual='V' WHERE Código_Cerda='" & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("UPDATE Reg_Enseminaciones_x_cerda SET Estado='A' WHERE Código_Cerda='" & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCCodigoCerda").Value & "' and Id_Enseminacion='" & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    Dim NoAbortos As Integer = 0
                    sql = New SqlCommand("select isnull(MAX(No_Aborto),0) FROM Registro_Aborto_x_Cerda WHERE Codigo_Cerda='" & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCCodigoCerda").Value & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        If leer.IsDBNull(0) = True Then
                            NoAbortos = 1
                        Else
                            NoAbortos = leer(0) + 1
                        End If
                    End While
                    con.Close()
                    sql = New SqlCommand("insert into Registro_Aborto_x_Cerda values('" & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value & "','" & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCCodigoCerda").Value & "','" & NoAbortos & "','" & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCFechaInseminacion").Value & "','" & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCVerraco").Value & "','" & FechaSistema & "','DESCONOCIDO'," & Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCNoDias").Value & ")", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    Actualizar_Estado_Parto(Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value, True)
                    RegistrarMovimientoLote(Me.cbxLotesGestacion.Text.ToString, 0, 0, 0, 0, 0, 1, FechaSistema, "Ca." & CStr(Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value))
                    RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Ca." & CStr(Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value))

                    InsertarProcesoCerda(Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value, Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCCodigoCerda").Value, "Registro de Aborto", FechaSistema, "Ca." & CStr(Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value), Me.cbxLotesGestacion.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value, Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCCodigoCerda").Value, "Registro de Aborto", FechaSistema, "Ca." & CStr(Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.Rows(i).Cells("MCIdIns").Value), "5", "E")
                End If
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar cambios en cerdas madres Confirmadas", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Sub ConfirmacionAuto()
        Try
            Correlativo_Auto("SELECT MAX(Confirmacion_No) FROM Registro_Confirmaciones", Me.txtConfirmacionNo)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando Confirmacion No Auto", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim errores As Integer = 0
        For i As Integer = 0 To Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows.Count - 1
            If RTrim(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells(6).Value) = "PENDIENTE" Then
                errores += 1
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf IsDBNull(Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells(6).Value) Then
                errores += 1
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).DefaultCellStyle.BackColor = Color.Red
            Else
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).DefaultCellStyle.BackColor = Nothing
            End If
        Next
        For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows.Count - 1
            If RTrim(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells(6).Value) = "PENDIENTE" Then
                errores += 1
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf IsDBNull(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells(6).Value) Then
                errores += 1
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).DefaultCellStyle.BackColor = Color.Red
            Else
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).DefaultCellStyle.BackColor = Nothing
            End If
        Next
        If errores > 0 And RTrim(Me.cbxLas.Text) = "PENDIENTES" Then
            presionoGuardar_y_MarcoHerrores = True
            If errores = 1 Then
                MessageBoxEx.Show("Se encontro " & errores & " error, no ha establecido ningun estado a la fila marcada", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf errores > 1 Then
                MessageBoxEx.Show("Se encontraron " & errores & " errores, no ha establecido ningun estado a las filas marcadas", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Try
                seVa_aGrabar = True
                Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.EndEdit()
                Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX.EndEdit()
                Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX.EndEdit()
                Me.Lista_Cerdas_Madres_PendientesDataGridViewX.EndEdit()
                'If Me.rbtMadres.Checked = True Then
                If Me.cbxLas.Text = "CONFIRMADOS" Then
                    Me.Guardar_Cambios_Cerdas_Madres_Confirmadas()
                    Me.Guardar_Cambios_Cerdas_Abuelas_Confirmadas()
                    ActualizarLote()
                    btnActualizar_Click(sender, e)
                    seVa_aGrabar = False

                ElseIf Me.cbxLas.Text = "PENDIENTES" Then
                    'Dim NoConfirmados As Integer = 0
                    Dim HayMadres As Boolean = False
                    Dim HayAbuelas As Boolean = False
                    For i As Integer = 0 To Me.Lista_Cerdas_Madres_PendientesDataGridViewX.RowCount - 1
                        If Me.Lista_Cerdas_Madres_PendientesDataGridViewX.Rows(i).Cells("MPEstado").Value = "CONFIRMADO" Then
                            HayMadres = True

                        End If
                    Next
                    For i As Integer = 0 To Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.RowCount - 1
                        If Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX.Rows(i).Cells("APEstado").Value = "CONFIRMADO" Then
                            HayAbuelas = True
                        End If
                    Next
                    If HayMadres = True Or HayAbuelas = True Then
                        If Me.cbxLotesGestacion.Text = "" Then
                            MessageBoxEx.Show("Para proceder con el cambio debe seleccionar a que lote de gestación moverá las cerdas", "Lote Gestación Requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Me.cbxLotesGestacion.Enabled = True
                            Me.cbxLotesGestacion.Focus()
                        ElseIf existeLote = False Then
                            MessageBoxEx.Show("El lote de gestación que ha ingresado no existe, para proceder con este movimiento debe crear el lote de gestacion", "No existe lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.cbxLotesGestacion.Focus()
                        Else
                            'Me.GrabarConfirmacion()
                            Dim movimientolotegestacion As Integer = 0
                            sql = New SqlCommand("select COUNT(*) from Movimiento_Lote m where m.Lote_No ='" & Me.cbxLotesGestacion.Text & "' and m.Documento_NO like 'Ca.%'", con)
                            con.Open()
                            leer = sql.ExecuteReader
                            While leer.Read
                                movimientolotegestacion = leer(0)
                            End While
                            con.Close()
                            If movimientolotegestacion > 0 Then

                                If RTrim(TipoUsuario) = "Admin" Then
                                    Dim resp As MsgBoxResult = MessageBoxEx.Show("El lote de gestación al que desea mover la cerdas ya contiene movimientos," & vbCrLf & "si continua podria generar problemas en la información, en el cuadro de costo al nacer" & vbCrLf & "¿Desea continuar de todas formas?", "Adevertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                    If resp = MsgBoxResult.Yes Then

                                        Me.Guardar_Cambios_Cerdas_Madres_Pendientes()
                                        Me.Guardar_Cambios_Cerdas_Abuelas_Pendientes()
                                        ActualizarLote()
                                        btnActualizar_Click(sender, e)
                                        seVa_aGrabar = False
                                        If Me.cbxLas.Text = "PENDIENTES" Then
                                            If Me.cbxLotesGestacion.Text <> "" Then
                                                RevisarCierre_Lote(Me.cbxLotesMontas.Text, Me.cbxLotesMontas)
                                                Me.MostrarLotes_Montas()
                                                Me.Mostrar_LotesGestacion()
                                            End If
                                            Me.cbxLotesGestacion.Text = ""
                                        End If
                                        ConfirmacionAuto()

                                    End If
                                Else
                                    MessageBoxEx.Show("No se puede realizar el proceso debido a que lote de gestación que ha seleccionado ya contiene movimientos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                Me.Guardar_Cambios_Cerdas_Madres_Pendientes()
                                Me.Guardar_Cambios_Cerdas_Abuelas_Pendientes()
                                ActualizarLote()
                                btnActualizar_Click(sender, e)
                                seVa_aGrabar = False
                                If Me.cbxLas.Text = "PENDIENTES" Then
                                    If Me.cbxLotesGestacion.Text <> "" Then
                                        RevisarCierre_Lote(Me.cbxLotesMontas.Text, Me.cbxLotesMontas)
                                        Me.MostrarLotes_Montas()
                                        Me.Mostrar_LotesGestacion()
                                    End If
                                    Me.cbxLotesGestacion.Text = ""
                                End If
                                ConfirmacionAuto()
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        'If Me.rbtMadres.Checked = True Then
        If Me.cbxLas.Text = "PENDIENTES" Then
            ExportarDatosExcel(Me.Lista_Cerdas_Madres_PendientesDataGridViewX, "LISTA DE MADRES PENDIENTES DE CONFIRMACION", "", "FECHA: " & FechaSistema, "J")
        ElseIf Me.cbxLas.Text = "CONFIRMADOS" Then
            ExportarDatosExcel(Me.Lista_Cerdas_Madres_ConfirmadasDataGridViewX, "LISTA DE MADRES CONFIRMADAS", "", "FECHA: " & FechaSistema, "J")
        End If
        'ElseIf Me.rbtAbuelas.Checked = True Then
        If Me.cbxLas.Text = "PENDIENTES" Then
            ExportarDatosExcel(Me.Lista_Cerdas_Abuelas_PendientesDataGridViewX, "LISTA DE ABUELAS PENDIENTES DE CONFIRMACION", "", "FECHA: " & FechaSistema, "J")
        ElseIf Me.cbxLas.Text = "CONFIRMADOS" Then
            ExportarDatosExcel(Me.Lista_Cerdas_Abuelas_ConfirmadasDataGridViewX, "LISTA DE ABUELAS CONFIRMADAS", "", "FECHA: " & FechaSistema, "J")
        End If
        'End If
    End Sub

    Private Sub Lista_Cerdas_Madres_ConfirmadasDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Madres_ConfirmadasDataGridViewX.CellContentClick

    End Sub

    Private Sub Lista_Cerdas_Madres_PendientesDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Madres_PendientesDataGridViewX.CellContentClick

    End Sub

    Private Sub Lista_Cerdas_Abuelas_PendientesDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Abuelas_PendientesDataGridViewX.CellContentClick

    End Sub

    Private Sub RibbonClientPanel1_Click(sender As Object, e As EventArgs) Handles RibbonClientPanel1.Click

    End Sub
End Class