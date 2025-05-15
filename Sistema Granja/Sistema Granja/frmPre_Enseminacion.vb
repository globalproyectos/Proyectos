Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmPre_Enseminacion
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim dtLotesDe_A As New DataTable
    Dim dtLotesDe_M As New DataTable
    Dim DataSourceM As New BindingSource
    Dim DataSourceA As New BindingSource
    Dim dtLotePara As New DataTable
    Dim DescLote_De As String
    Dim DescLote_Para As String
    Dim Vacias_Actuales_M As Integer
    Dim Vacias_Actuales_A As Integer
    Dim Montas_Actuales_A As Integer
    Dim Montas_Actaules_M As Integer
    Dim Selecciono_LotePara As Boolean
    Dim No_Cerdas_que_salen_de_vacias As Integer
    Dim No_cerdas_que_entrar_lote_montas As Integer
    Dim ExisteLote As Boolean = False
    Sub MostrarLotes_para_vacias()
        Try
            Me.CbxLoteDe.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No ,e.Descripcion " _
                              & " FROM LOTES l" _
                              & " JOIN Etapas_Cerdas_Lote e ON l.IdEtapa_Cerdas = e.IdEtapa_Cerdas" _
                              & " where l.IdEtapa_Cerdas ='V' and l.Estado<>'T'"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read

                Me.CbxLoteDe.Items.Add(leer(0)).ToString()
                'Me.txtDescLoteDe.Text = leer(1).ToString

            End While
            con.Close()

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrar Lotes Vacias", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub NoPre_SeleccionAuto()
        Try
            Correlativo_Auto("SELECT MAX(Pre_Seleccion_NO) FROM Pre_Inseminaciones", Me.txtPreSeleccionNo)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error Pre-Inseminacion Auto", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Sub Mostrar_Lotes_monta()
        Try
            Me.cbxLotePara.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No ,e.Descripcion " _
                                         & " FROM LOTES l" _
                                         & " JOIN Etapas_Cerdas_Lote e ON l.IdEtapa_Cerdas = e.IdEtapa_Cerdas" _
                                         & " where l.IdEtapa_Cerdas ='M' and l.Estado<>'T'"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                Me.cbxLotePara.Text = leer(0).ToString
                Me.cbxLotePara.Items.Add(leer(0)).ToString()
                Me.txtDescLotePara.Text = leer(1).ToString

            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrar Lotes Montas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub frmPre_Enseminacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.NoPre_SeleccionAuto()
        Me.MostrarLotes_para_vacias()
        Me.Mostrar_Lotes_monta()
        With dtLotePara.Columns
            .Add(New DataColumn("Cód. Cerda"))
            .Add(New DataColumn("Fecha Nac."))
            .Add(New DataColumn("Seleccionar", System.Type.GetType("System.Boolean")))

        End With
        Me.dgvLotePara.DataSource = dtLotePara
        Me.dgvLotePara.Columns(0).Width = 60
        Me.dgvLotePara.Columns(1).Width = 70
        Me.dgvLotePara.Columns(2).Width = 70
        With dtLotesDe_A.Columns
            .Add(New DataColumn("Cód. Cerda"))
            .Add(New DataColumn("Fecha Nac."))
            .Add(New DataColumn("Seleccionar", System.Type.GetType("System.Boolean")))

        End With
        With dtLotesDe_M.Columns
            .Add(New DataColumn("Cód. Cerda"))
            .Add(New DataColumn("Fecha Nac."))
            .Add(New DataColumn("Seleccionar", System.Type.GetType("System.Boolean")))

        End With
       
        Me.dgvLotePara.Columns(0).ReadOnly = True
        Me.dgvLotePara.Columns(1).ReadOnly = True
    End Sub

    Private Sub CbxLoteDe_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxLoteDe.LostFocus
        CbxLoteDe_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub CbxLoteDe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxLoteDe.SelectedIndexChanged
        If Me.CbxLoteDe.Text <> "" Then
            Try
                Dim ExisteLote As Boolean = False
                Dim cmd As String = "SELECT e.Descripcion " _
                                            & " FROM LOTES l" _
                                            & " JOIN Etapas_Cerdas_Lote e ON l.IdEtapa_Cerdas = e.IdEtapa_Cerdas" _
                                            & " where l.IdEtapa_Cerdas ='V' and l.Lote_No='" & Me.CbxLoteDe.Text & "' and l.Estado<>'T'"
                sql = New SqlCommand(cmd, con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    ExisteLote = True
                    Me.DescLote_De = leer(0).ToString
                End While
                con.Close()
                If ExisteLote = False Then
                    MessageBoxEx.Show("No existe ningun Lote con el código: " & Me.CbxLoteDe.Text & " en el registro de la base de datos", "No existe Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.CbxLoteDe.Text = ""
                    Me.txtDescLoteDe.Text = ""
                    Me.CbxLoteDe.Focus()
                    Me.dtLotesDe_A.Rows.Clear()
                    Me.dtLotesDe_M.Rows.Clear()
                    Me.dtLotePara.Clear()
                Else
                    Me.txtDescLoteDe.Text = DescLote_De
                    If Me.rbtAbuelas.Checked = True Then
                        Try
                            Me.dtLotesDe_A.Rows.Clear()
                            sql = New SqlCommand("select Código_Abuela,Fecha_Nacimiento from REG_ABUELAS where Lote_No='" & Me.CbxLoteDe.Text & "' and(Estado_Actual<>'C' or Estado_Actual<>'P' or Estado_Actual<>'D' or Estado_Actual<>'DF')", con)
                            con.Open()
                            leer = sql.ExecuteReader
                            While leer.Read
                                dr = dtLotesDe_A.NewRow
                                dr(0) = leer(0)
                                dr(1) = Format(leer(1), "dd/MM/yyyy")
                                dr(2) = False

                                dtLotesDe_A.Rows.Add(dr)
                            End While
                            con.Close()
                            'dv = New DataView(dtLotesDe_A)
                            'Me.dgvLoteDe.DataSource = dv
                            Me.DataSourceA.DataSource = dtLotesDe_A
                            Me.dgvLoteDe.DataSource = DataSourceA
                            Me.lbCerdasVacias.Text = Me.dgvLoteDe.Rows.Count
                            Me.dgvLoteDe.Columns(0).Width = 60
                            Me.dgvLoteDe.Columns(1).Width = 70
                            Me.dgvLoteDe.Columns(2).Width = 70
                            Me.dgvLoteDe.Columns(0).ReadOnly = True
                            Me.dgvLoteDe.Columns(1).ReadOnly = True

                        Catch ex As Exception
                            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrar cerdas Lote Vacias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            con.Close()
                        End Try
                    ElseIf Me.rbtMadres.Checked = True Then
                        Try
                            dtLotesDe_M.Rows.Clear()
                            sql = New SqlCommand("select Código_Cerda,Fecha_Nacimiento from REG_MADRES where Lote_No='" & Me.CbxLoteDe.Text & "' and(Estado_Actual<>'C' or Estado_Actual<>'P' or Estado_Actual<>'D' or Estado_Actual<>'DF')", con)
                            con.Open()
                            leer = sql.ExecuteReader
                            While leer.Read
                                dr = dtLotesDe_M.NewRow
                                dr(0) = leer(0)
                                dr(1) = Format(leer(1), "dd/MM/yyyy")
                                dr(2) = False

                                dtLotesDe_M.Rows.Add(dr)
                            End While
                            con.Close()
                            'dv = New DataView(dtLotesDe_M)
                            'Me.dgvLoteDe.DataSource = dv
                            Me.DataSourceM.DataSource = dtLotesDe_M
                            Me.dgvLoteDe.DataSource = DataSourceM
                            Me.dgvLoteDe.Columns(0).Width = 60
                            Me.dgvLoteDe.Columns(1).Width = 70
                            Me.dgvLoteDe.Columns(2).Width = 70
                            Me.dgvLoteDe.Columns(0).ReadOnly = True
                            Me.dgvLoteDe.Columns(1).ReadOnly = True

                            Me.lbCerdasVacias.Text = Me.dgvLoteDe.Rows.Count
                        Catch ex As Exception
                            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrar cerdas Lote Vacias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            con.Close()
                        End Try
                    End If
                End If
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrar cerdas Lote Vacias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()

            End Try

        End If

    End Sub

    'Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.dgvLoteDe.Rows.Count <> 0 Then
    '        If Me.rbtMadres.Checked = True Then
    '            If Me.CheckBox1.CheckState = CheckState.Checked Then
    '                For i As Integer = 0 To Me.dgvLoteDe.RowCount - 1
    '                    Me.dgvLoteDe.Rows(i).Cells("Seleccionar").Value = True
    '                Next
    '            ElseIf Me.CheckBox1.CheckState = CheckState.Unchecked Then
    '                For i As Integer = 0 To Me.dgvLoteDe.RowCount - 1
    '                    Me.dgvLoteDe.Rows(i).Cells("Seleccionar").Value = False
    '                Next
    '            End If
    '        ElseIf Me.rbtAbuelas.Checked = True Then
    '            If Me.CheckBox1.CheckState = CheckState.Checked Then
    '                For i As Integer = 0 To Me.dgvLoteDe.RowCount - 1
    '                    Me.dgvLoteDe.Rows(i).Cells("Seleccionar").Value = True
    '                Next
    '            ElseIf Me.CheckBox1.CheckState = CheckState.Unchecked Then
    '                For i As Integer = 0 To Me.dgvLoteDe.RowCount - 1
    '                    Me.dgvLoteDe.Rows(i).Cells("Seleccionar").Value = False
    '                Next
    '            End If

    '        End If
    '    End If

    'End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dgvLoteDe_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLoteDe.CellValueChanged
        If e.ColumnIndex <> 1 Then
            Return
        End If
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvLoteDe.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            Dim bln As Boolean = CBool(cb.Value)
            MsgBox(bln.ToString)
        End If
    End Sub
    Private Sub dgvLoteDe_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLoteDe.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvLoteDe.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            Me.dgvLoteDe.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub dgvLotePara_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLotePara.CellValueChanged
        If e.ColumnIndex <> 1 Then
            Return
        End If
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvLotePara.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            Dim bln As Boolean = CBool(cb.Value)
            MsgBox(bln.ToString)
        End If
    End Sub
    Private Sub dgvLotePara_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLotePara.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvLotePara.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            Me.dgvLotePara.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub dgvLoteDe_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLoteDe.CellContentClick
        Try
            Dim NomColumna As String = Me.dgvLoteDe.Columns(Me.dgvLoteDe.CurrentCell.ColumnIndex).HeaderText
            Dim row As DataGridViewRow = Me.dgvLoteDe.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells(NomColumna), DataGridViewCheckBoxCell)
            If cellSelecion.Value = True Then
                dr = dtLotePara.NewRow
                dr(0) = Me.dgvLoteDe.Rows(Me.dgvLoteDe.CurrentCell.RowIndex).Cells(0).Value
                dr(1) = Me.dgvLoteDe.Rows(Me.dgvLoteDe.CurrentCell.RowIndex).Cells(1).Value
                dr(2) = True

                dtLotePara.Rows.Add(dr)
                Me.dgvLotePara.DataSource = dtLotePara
                Me.dgvLoteDe.Rows.RemoveAt(Me.dgvLoteDe.CurrentCell.RowIndex)
                Me.lbItems.Text = Me.dgvLotePara.Rows.Count
                Me.lbCerdasVacias.Text = Me.dgvLoteDe.Rows.Count
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbtAbuelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAbuelas.CheckedChanged

        Me.dtLotePara.Rows.Clear()
        CbxLoteDe_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub rbtMadres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMadres.CheckedChanged
        'If Me.lbItems.Text <> "0" Then
        '    Dim resp As MsgBoxResult
        '    resp = MessageBoxEx.Show("Hay Registros de cerdas Abuelas seleccionados al cambiar se perderar las seleccionadas, desea cambiar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        '    If resp = MsgBoxResult.Yes Then
        Me.dtLotePara.Rows.Clear()
        CbxLoteDe_SelectedIndexChanged(sender, e)
        '        Me.rbtMadres.Checked = True
        '    Else
        '        Me.rbtMadres.Checked = False
        '        Me.rbtAbuelas.Checked = True
        '    End If
        'End If



    End Sub

    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub dgvLotePara_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLotePara.CellContentClick
        If Me.rbtMadres.Checked = True Then
            Dim NomColumna As String = Me.dgvLotePara.Columns(Me.dgvLotePara.CurrentCell.ColumnIndex).HeaderText
            Dim row As DataGridViewRow = Me.dgvLotePara.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells(NomColumna), DataGridViewCheckBoxCell)
            If cellSelecion.Value = False Then
                dr = dtLotesDe_M.NewRow
                dr(0) = Me.dgvLotePara.Rows(Me.dgvLotePara.CurrentCell.RowIndex).Cells(0).Value
                dr(1) = Me.dgvLotePara.Rows(Me.dgvLotePara.CurrentCell.RowIndex).Cells(1).Value
                dr(2) = False

                dtLotesDe_M.Rows.Add(dr)
                Me.dgvLoteDe.DataSource = dtLotesDe_M

                Me.dgvLotePara.Rows.RemoveAt(Me.dgvLotePara.CurrentCell.RowIndex)
                Me.lbItems.Text = Me.dgvLotePara.Rows.Count
                Me.lbCerdasVacias.Text = Me.dgvLoteDe.Rows.Count
            End If
        ElseIf Me.rbtAbuelas.Checked = True Then
            Dim NomColumna As String = Me.dgvLotePara.Columns(Me.dgvLotePara.CurrentCell.ColumnIndex).HeaderText
            Dim row As DataGridViewRow = Me.dgvLotePara.Rows(e.RowIndex)
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells(NomColumna), DataGridViewCheckBoxCell)
            If cellSelecion.Value = False Then
                dr = dtLotesDe_A.NewRow
                dr(0) = Me.dgvLotePara.Rows(Me.dgvLotePara.CurrentCell.RowIndex).Cells(0).Value
                dr(1) = Me.dgvLotePara.Rows(Me.dgvLotePara.CurrentCell.RowIndex).Cells(1).Value
                dr(2) = False
                dtLotesDe_A.Rows.Add(dr)
                Me.dgvLoteDe.DataSource = dtLotesDe_A
                Me.dgvLotePara.Rows.RemoveAt(Me.dgvLotePara.CurrentCell.RowIndex)
                Me.lbItems.Text = Me.dgvLotePara.Rows.Count
                Me.lbCerdasVacias.Text = Me.dgvLoteDe.Rows.Count
            End If
        End If
    End Sub
    Sub ActualizarLotes_x_cerda()
        Try
            '********ACTUALIZA LISTA LOTES DE.....................
            If Me.rbtAbuelas.Checked = True Then
                For i As Integer = 0 To Me.dgvLotePara.Rows.Count - 1
                    sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='" & Me.cbxLotePara.Text & "' where Código_Abuela='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    sql = New SqlCommand("insert into Pre_Inseminaciones values('" & Me.txtPreSeleccionNo.Text & "','" & FechaSistema & "','" & UsuarioActual & "','" & Me.cbxLotePara.Text & "','" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    InsertarProcesoCerda(0, Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Pre-Inseminacion", FechaSistema, "Pi." & Trim(Me.txtPreSeleccionNo.Text), Me.cbxLotePara.Text, "E")
                    InsertarProcesoCerda(0, Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Pre-Inseminacion", FechaSistema, "Pi." & Trim(Me.txtPreSeleccionNo.Text), "5", "S")
                Next
                '**************RECUPERA EL NUMERO DE CERDOS QUE ESTAN EN LOS LOTES VACIAS******************
                sql = New SqlCommand("SELECT Cerdos_Nacidos FROM LOTES where Lote_No='" & Me.CbxLoteDe.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.Vacias_Actuales_A = leer(0)
                End While
                con.Close()
                '******************************************************************************
                '***********RECUPERA EL NUMERO DE CERDOS QUE ESTAN EN LOS LOTES MONTAS**********
                sql = New SqlCommand("SELECT Cerdos_Nacidos FROM LOTES where Lote_No='" & Me.cbxLotePara.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.Montas_Actuales_A = leer(0)
                End While
                con.Close()
                '******************************************************************************i
               
            ElseIf Me.rbtMadres.Checked = True Then
                For i As Integer = 0 To Me.dgvLotePara.Rows.Count - 1
                    sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='" & Me.cbxLotePara.Text & "' where Código_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    sql = New SqlCommand("insert into Pre_Inseminaciones values('" & Me.txtPreSeleccionNo.Text & "','" & FechaSistema & "','" & UsuarioActual & "','" & Me.cbxLotePara.Text & "','" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    InsertarProcesoCerda(0, Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Pre-Inseminacion", FechaSistema, "Pi." & Trim(Me.txtPreSeleccionNo.Text), Me.cbxLotePara.Text, "E")
                    InsertarProcesoCerda(0, Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Pre-Inseminacion", FechaSistema, "Pi." & Trim(Me.txtPreSeleccionNo.Text), "5", "S")
                Next
                '**************RECUPERA EL NUMERO DE CERDOS QUE ESTAN EN LOS LOTES VACIAS******************
                sql = New SqlCommand("SELECT Cerdos_Nacidos FROM LOTES where Lote_No='" & Me.CbxLoteDe.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.Vacias_Actuales_M = leer(0)
                End While
                con.Close()
                '******************************************************************************
                '***********RECUPERA EL NUMERO DE CERDOS QUE ESTAN EN LOS LOTES MONTAS**********
                sql = New SqlCommand("SELECT Cerdos_Nacidos FROM LOTES where Lote_No='" & Me.cbxLotePara.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.Montas_Actaules_M = leer(0)
                End While
                con.Close()
                
            End If


        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error actualizando lotes x cerda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
   
    Sub RegistrarMovimiento_en_Movimiento_Lotes()
        Try
            '*********AGREGA EL NUM. TOTAL DE CERDAS QUE SALEN DEL LOTE DE VACIAS********
            Me.No_Cerdas_que_salen_de_vacias = 0
            For a As Integer = 0 To Me.dgvLotePara.Rows.Count - 1
                Me.No_Cerdas_que_salen_de_vacias += 1
            Next
            RegistrarMovimientoLote(Me.CbxLoteDe.Text, 0, 0, 0, 0, 0, No_Cerdas_que_salen_de_vacias, FechaSistema, "Pi." & Me.txtPreSeleccionNo.Text)

            Me.No_cerdas_que_entrar_lote_montas = 0
            For a As Integer = 0 To Me.dgvLotePara.Rows.Count - 1
                Me.No_cerdas_que_entrar_lote_montas += 1
            Next
            RegistrarMovimientoLote(Me.cbxLotePara.Text, 0, 0, 0, 0, No_cerdas_que_entrar_lote_montas, 0, FechaSistema, "Pi." & Me.txtPreSeleccionNo.Text)
            HalarCostos_de_Vacias_a_Montas(Me.CbxLoteDe.Text, Me.cbxLotePara.Text, FechaSistema, "PRE-SELECCION DE CERDAS PARA INSEMINACION", No_Cerdas_que_salen_de_vacias, "Pi." & Me.txtPreSeleccionNo.Text)
            ActualizarLote()
            AgregarNoCerdas_Movimientos_Costos(Me.cbxLotePara.Text, No_cerdas_que_entrar_lote_montas)

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error actualizando tabla Movimientos Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Selecciono_LotePara = False And Me.txtDescLotePara.Text = "" Then
            MessageBoxEx.Show("No ha seleccionado ó Ingesado el lote al que moverá las cerdas porfavor seleccionelas, luego presione Guardar Movimiento", "No ha seleccionado el Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cbxLotePara.Focus()
        
        Else
            ActualizarLotes_x_cerda()


            Me.RegistrarMovimiento_en_Movimiento_Lotes()
            Me.dtLotePara.Rows.Clear()
            Me.dtLotesDe_A.Rows.Clear()
            Me.dtLotesDe_M.Rows.Clear()
            Me.lbItems.Text = "0"
            Dim resp As MsgBoxResult
            Dim cadenamsj As String = ""
            cadenamsj &= "Se guardó el movimiento exitosamente, desea agregar mas cerdas con el mismo numero de Pre-Seleccion," & vbCrLf & "recuerde que para revertir una Pre-Insemiancion es necesario el Numero de Pre-Inseminación"
            resp = MessageBoxEx.Show(cadenamsj, "Guardar Movimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = MsgBoxResult.No Then
                NoPre_SeleccionAuto()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub cbxLotePara_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLotePara.LostFocus
        'ExisteLote = False
        'sql = New SqlCommand("select Lote_No from LOTES where Lote_No='" & RTrim(Me.cbxLotePara.SelectedItem.ToString) & "' and IdEtapa_Cerdas='M'", con)
        'con.Open()
        'leer = sql.ExecuteReader
        'While leer.Read
        '    ExisteLote = True
        'End While
        'con.Close()
    End Sub

    Private Sub cbxLotePara_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotePara.SelectedIndexChanged
        Selecciono_LotePara = True
    End Sub
    
    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.rbtMadres.Checked = True Then
                Dim ret As Integer = Buscar("Cód. Cerda", Me.txtBuscar.Text, DataSourceM)
                If ret = -1 Then
                    MessageBoxEx.Show("No se encontro ningún dato de cerda con el código: " & Me.txtBuscar.Text, "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtBuscar.SelectAll()
                    Me.txtBuscar.Focus()
                Else
                    With dgvLoteDe
                        .DataSource = DataSourceM
                        .FirstDisplayedScrollingRowIndex = ret
                    End With
                    Me.txtBuscar.SelectAll()
                End If
                'Buscar("Cód. Cerda", Me.txtBuscar.Text, DataSourceM)
            ElseIf Me.rbtAbuelas.Checked = True Then
                Dim ret As Integer = Buscar("Cód. Cerda", Me.txtBuscar.Text, DataSourceA)
                If ret = -1 Then
                    MessageBoxEx.Show("No se encontro ningún dato de cerda con el código: " & Me.txtBuscar.Text, "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtBuscar.SelectAll()
                    Me.txtBuscar.Focus()
                Else
                    With dgvLoteDe
                        .DataSource = DataSourceA
                        .FirstDisplayedScrollingRowIndex = ret
                    End With
                    Me.txtBuscar.SelectAll()

                End If
                'Buscar("Cód. Cerda", Me.txtBuscar.Text, DataSourceA)
            End If

        End If
    End Sub
    Private Sub cbxLotePara_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLotePara.TextChanged
        Me.Selecciono_LotePara = True
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub lbItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbItems.Click

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        NoPre_SeleccionAuto()
    End Sub

    Private Sub lbItems_TextChanged(sender As Object, e As EventArgs) Handles lbItems.TextChanged
        If Me.lbItems.Text = "0" Then
            Me.rbtAbuelas.Enabled = True
            Me.rbtMadres.Enabled = True
            CbxLoteDe.Enabled = True
        Else
            Me.rbtAbuelas.Enabled = False
            Me.rbtMadres.Enabled = False
            CbxLoteDe.Enabled = False
        End If
    End Sub
End Class