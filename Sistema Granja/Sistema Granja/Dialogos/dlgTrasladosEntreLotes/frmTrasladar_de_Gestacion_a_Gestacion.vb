Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmTrasladar_de_Gestacion_a_Gestacion
    Public DeLote, ALote As String
    Public NoTraslado As Integer
    Public FechaTraslado As Date
    Dim CostoTraslado As Double
    Dim Cantiadad As Integer
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
    Dim NoTrasladar As Integer = 0
    Dim CostoTotalTraslado As Double = 0
    Dim HayTraslados As Boolean = False
    Dim Lotes_Gestacion_ActivosTableAdapter As New DtsBDGRANJATableAdapters.Lotes_Gestacion_ActivosTableAdapter
    Dim Reg_MadresTableAdapter As New DtsBDGRANJATableAdapters.Reg_MadresTableAdapter
    Dim Reg_AbuelasTableAdapter As New DtsBDGRANJATableAdapters.Reg_AbuelasTableAdapter

    Private Sub frmTrasladar_de_Gestacion_a_Gestacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarLote()
        Me.dtLotesDe_A.Columns.Clear()
        Me.dtLotesDe_M.Columns.Clear()
        Me.dtLotePara.Columns.Clear()
        Me.dtLotePara.Clear()
        Me.dtLotesDe_A.Clear()
        Me.dtLotesDe_M.Clear()
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
        Me.txtTrasladoNo.Text = NoTraslado
        Me.txtFechaTr.Text = FechaTraslado
        Me.CbxLoteDe.Text = DeLote
        Me.cbxLotePara.Text = ALote
        MostrarCerdas()
    End Sub
    Sub MostrarCerdas()
        If Me.CbxLoteDe.Text <> "" Then
            Dim ExisteLote As Boolean = False
            Dim cmd As String = "SELECT e.Descripcion " _
                                        & " FROM LOTES l" _
                                        & " JOIN Etapas_Cerdas_Lote e ON l.IdEtapa_Cerdas = e.IdEtapa_Cerdas" _
                                        & " where l.IdEtapa_Cerdas ='G' and l.Lote_No='" & Me.CbxLoteDe.Text & "' and l.Estado<>'T'"
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
                Try
                    dtLotesDe_M.Rows.Clear()
                    sql = New SqlCommand("select Código_Cerda,Fecha_Nacimiento from REG_MADRES where Lote_No='" & Me.CbxLoteDe.Text & "'", con)
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
                    sql = New SqlCommand("select Código_Abuela,Fecha_Nacimiento from REG_ABUELAS where Lote_No='" & Me.CbxLoteDe.Text & "'", con)
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
                    'Me.lbCerdasVacias.Text = Me.dgvLoteDe.Rows.Count
                Catch ex As Exception
                    MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrar cerdas Lote Gestación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
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
                'Me.lbCerdasVacias.Text = Me.dgvLoteDe.Rows.Count
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvLotePara_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLotePara.CellContentClick

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
    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
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
        End If
    End Sub
    Sub GuardarTraslado()
        Try
            sql = New SqlCommand("insert into TrasladosEntreLotes values('" & Me.txtTrasladoNo.Text & "','" & Me.CbxLoteDe.Text & "','" & Me.cbxLotePara.Text & "','" & NoTrasladar & "','" & 0 & "','" & Me.txtFechaTr.Text & "','N/A')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        HayTraslados = False
        NoTrasladar = 0
        For i As Integer = 0 To dgvLotePara.Rows.Count - 1
            Try
                HayTraslados = True
                Dim EsAbuela As Boolean = False
                Dim EsMadre As Boolean = False
                sql = New SqlCommand("SELECT Código_Abuela FROM REG_ABUELAS where Código_Abuela='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    EsAbuela = True
                End While
                con.Close()
                sql = New SqlCommand("SELECT Código_Cerda FROM REG_MADRES where Código_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    EsMadre = True
                End While
                con.Close()
                sql = New SqlCommand("insert into TrasladosEntreLotes values('" & Me.txtTrasladoNo.Text & "','" & Me.CbxLoteDe.Text & "','" & Me.cbxLotePara.Text & "','" & 1 & "','" & 0 & "','" & Me.txtFechaTr.Text & "','" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                If EsAbuela = True Then
                    sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='" & Me.cbxLotePara.Text & "' WHERE Código_Abuela='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    NoTrasladar += 1
                    Dim EstadoCerda As String = ""
                    sql = New SqlCommand("select Estado_Actual from REG_ABUELAS where Código_Abuela='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteReader()
                    While leer.Read
                        EstadoCerda = RTrim(leer(0))
                    End While
                    con.Close()
                    If EstadoCerda = "L" Then
                        Dim NoCerditos As Integer = Reg_MadresTableAdapter.GetTotalCerditosGestacionActual(Reg_AbuelasTableAdapter.GetIdInseminacion(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value))
                        MsgBox(NoCerditos)
                        InsertarProcesosCerditos(Reg_AbuelasTableAdapter.GetIdInseminacion(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value), "TrEntGest", NoCerditos, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotePara.Text), Me.cbxLotePara.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotePara.Text), Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Tr." & Trim(Me.txtTrasladoNo.Text))
                        InsertarProcesosCerditos(Reg_AbuelasTableAdapter.GetIdInseminacion(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value), "TrSalGest", NoCerditos, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.CbxLoteDe.Text), Me.CbxLoteDe.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.CbxLoteDe.Text), Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Tr." & Trim(Me.txtTrasladoNo.Text))
                        'sql = New SqlCommand("update REG_PARTOS_X_CERDA set Lote_Gestacion='" & Me.cbxLotePara.Text & "' where Código_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "' and Lote_Gestacion='" & Me.CbxLoteDe.Text & "'", con)
                        'con.Open()
                        'sql.ExecuteNonQuery()
                        'con.Close()
                    End If

                    InsertarProcesoCerda(ObtenerActualIdInseminacionCerda(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value), Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Traslado de Gest. a Gest.", FechaSistema, "Tr." & Me.txtTrasladoNo.Text, Me.CbxLoteDe.Text, "S")
                    InsertarProcesoCerda(ObtenerActualIdInseminacionCerda(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value), Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Traslado de Gest. a Gest.", FechaSistema, "Tr." & Me.txtTrasladoNo.Text, Me.cbxLotePara.Text, "E")
                ElseIf EsMadre = True Then
                    sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='" & Me.cbxLotePara.Text & "' WHERE Código_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    NoTrasladar += 1
                    Dim EstadoCerda As String = ""
                    sql = New SqlCommand("select Estado_Actual from REG_MADRES where Código_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader()
                    While leer.Read
                        EstadoCerda = RTrim(leer(0))
                    End While
                    con.Close()
                    If EstadoCerda = "L" Then
                        Dim NoCerditos As Integer = Reg_MadresTableAdapter.GetTotalCerditosGestacionActual(Reg_MadresTableAdapter.GetIdInseminacion(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value))
                        InsertarProcesosCerditos(Reg_MadresTableAdapter.GetIdInseminacion(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value), "TrEntGest", NoCerditos, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotePara.Text), Me.cbxLotePara.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotePara.Text), Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Tr." & Trim(Me.txtTrasladoNo.Text))
                        InsertarProcesosCerditos(Reg_MadresTableAdapter.GetIdInseminacion(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value), "TrSalGest", NoCerditos, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.CbxLoteDe.Text), Me.CbxLoteDe.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.CbxLoteDe.Text), Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Tr." & Trim(Me.txtTrasladoNo.Text))

                        'sql = New SqlCommand("update REG_PARTOS_X_CERDA set Lote_Gestacion='" & Me.cbxLotePara.Text & "' where Código_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "' and Lote_Gestacion='" & Me.CbxLoteDe.Text & "'", con)
                        'con.Open()
                        'sql.ExecuteNonQuery()
                        'con.Close()
                    End If
                End If

                InsertarProcesoCerda(ObtenerActualIdInseminacionCerda(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value), Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Traslado de Gest. a Gest.", FechaSistema, "Tr." & Me.txtTrasladoNo.Text, Me.CbxLoteDe.Text, "S")
                InsertarProcesoCerda(ObtenerActualIdInseminacionCerda(Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value), Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value, "Traslado de Gest. a Gest.", FechaSistema, "Tr." & Me.txtTrasladoNo.Text, Me.cbxLotePara.Text, "E")
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            
        Next
        Try
            If HayTraslados = True Then
                RegistrarMovimientoLote(Me.CbxLoteDe.Text, 0, 0, 0, 0, 0, NoTrasladar, Me.txtFechaTr.Text, "Tr." & Me.txtTrasladoNo.Text)
                RegistrarMovimientoLote(Me.cbxLotePara.Text, 0, 0, 0, 0, NoTrasladar, 0, Me.txtFechaTr.Text, "Tr." & Me.txtTrasladoNo.Text)
                HalarCostos_Traslados(Me.CbxLoteDe.Text, Me.cbxLotePara.Text, Me.txtFechaTr.Text, "TRASLADO DE CERDAS DE GESTACIÓN A GESTACIÓN", NoTrasladar, "Tr." & Me.txtTrasladoNo.Text)
                '*********************************RESTA O SUMA EL NUM. CERDAS EN TABLA MOVIMIENTO 
                Dim CerdasActuales_en_Tabla_No_Cerdas_Lotes_Moviento_Costo_LoteDe As Integer = 0
                sql = New SqlCommand("select No_Cerdos from No_Cerdas_Lotes_Moviento_Costo where Lote_No='" & Me.CbxLoteDe.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CerdasActuales_en_Tabla_No_Cerdas_Lotes_Moviento_Costo_LoteDe = leer(0)
                End While
                con.Close()
                Dim CerdasActuales_en_Tabla_No_Cerdas_Lotes_Moviento_Costo_LotePara As Integer = 0
                sql = New SqlCommand("select No_Cerdos from No_Cerdas_Lotes_Moviento_Costo where Lote_No='" & Me.cbxLotePara.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CerdasActuales_en_Tabla_No_Cerdas_Lotes_Moviento_Costo_LotePara = leer(0)
                End While
                con.Close()
                sql = New SqlCommand("UPDATE No_Cerdas_Lotes_Moviento_Costo SET No_Cerdos='" & (CerdasActuales_en_Tabla_No_Cerdas_Lotes_Moviento_Costo_LoteDe - NoTrasladar) & "' WHERE Lote_No='" & Me.CbxLoteDe.Text & "'", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                sql = New SqlCommand("UPDATE No_Cerdas_Lotes_Moviento_Costo SET No_Cerdos='" & (CerdasActuales_en_Tabla_No_Cerdas_Lotes_Moviento_Costo_LotePara + NoTrasladar) & "' WHERE Lote_No='" & Me.cbxLotePara.Text & "'", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                '***************************************************************************************************
                MessageBoxEx.Show("Se efectuó el traslado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ActualizarLote()
                RevisarCierre_Lote(Me.CbxLoteDe.Text, Me.CbxLoteDe)
                With My.Forms.frmTrasladosEntreLotes
                    .ButtonX2_Click(sender, e)
                    Me.Close()
                End With
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        
    End Sub

    Private Sub CbxLoteDe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxLoteDe.SelectedIndexChanged

    End Sub
End Class