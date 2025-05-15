Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class dlgTrasladar_de_Reemplazos_a_vacias
    Inherits DevComponents.DotNetBar.Office2007Form
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

    Dim costoinidivualreemplazoAdapter As New DtsBDGRANJATableAdapters.Costo_Cerdas_Individual_ReemplazosTableAdapter

    Private Sub dlgTrasladar_de_Reemplazos_a_vacias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtLotesDe_A.Columns.Clear()
        Me.dtLotesDe_M.Columns.Clear()
        Me.dtLotePara.Columns.Clear()
        Me.dtLotePara.Rows.Clear()
        Me.dtLotesDe_A.Rows.Clear()
        Me.dtLotesDe_M.Rows.Clear()
        With dtLotePara.Columns
            .Add(New DataColumn("Cód. Cerda"))
            .Add(New DataColumn("Fecha Nac."))
            .Add(New DataColumn("Seleccionar", System.Type.GetType("System.Boolean")))
            .Add(New DataColumn("Depreciacion/ Partos"))
            .Add(New DataColumn("Depreciar", System.Type.GetType("System.Boolean")))
            .Add(New DataColumn("Valor Residual"))
        End With
        Me.dgvLotePara.DataSource = dtLotePara
        Me.dgvLotePara.Columns(0).Width = 60
        Me.dgvLotePara.Columns(1).Width = 70
        Me.dgvLotePara.Columns(2).Width = 70
        Me.dgvLotePara.Columns(3).Width = 100
        Me.dgvLotePara.Columns(3).Width = 70
        Me.dgvLotePara.Columns(3).Width = 80
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
        Me.dgvLotePara.Columns(3).ReadOnly = False

        Me.txtTrasladoNo.Text = NoTraslado
        Me.txtFechaTr.Text = FechaTraslado
        Me.CbxLoteDe.Text = DeLote
        Me.cbxLotePara.Text = ALote
        MostrarLotesReemplazos()
    End Sub
    Sub MostrarLotesReemplazos()
        If Me.CbxLoteDe.Text <> "" Then
            Dim ExisteLote As Boolean = False
            Dim cmd As String = "SELECT e.Descripcion " _
                                        & " FROM LOTES l" _
                                        & " JOIN Etapas_Cerdas_Lote e ON l.IdEtapa_Cerdas = e.IdEtapa_Cerdas" _
                                        & " where l.IdEtapa_Cerdas ='R' and l.Lote_No='" & Me.CbxLoteDe.Text & "' and l.Estado<>'T'"
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
                dtLotesDe_M.Rows.Clear()
                If Me.tipocerdaComboBoxEx1.Text = "Madres" Then
                    sql = New SqlCommand("select Código_Cerda,Fecha_Nacimiento from REG_MADRES where Lote_No='" & Me.CbxLoteDe.Text & "' and(Estado_Actual<>'C' or Estado_Actual<>'P')", con)
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
                ElseIf Me.tipocerdaComboBoxEx1.Text = "Abuelas" Then
                    sql = New SqlCommand("select Código_Abuela,Fecha_Nacimiento from REG_Abuelas where Lote_No='" & Me.CbxLoteDe.Text & "' and(Estado_Actual<>'C' or Estado_Actual<>'P')", con)
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



                    Me.DataSourceM.DataSource = dtLotesDe_M
                    Me.dgvLoteDe.DataSource = DataSourceM
                    Me.dgvLoteDe.Columns(0).Width = 60
                    Me.dgvLoteDe.Columns(1).Width = 70
                    Me.dgvLoteDe.Columns(2).Width = 70
                    Me.dgvLoteDe.Columns(0).ReadOnly = True
                    Me.dgvLoteDe.Columns(1).ReadOnly = True
                End If
                Me.txtDescLoteDe.Text = DescLote_De


                'Try

               
                'Me.lbCerdasVacias.Text = Me.dgvLoteDe.Rows.Count
                'Catch ex As Exception
                '    MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrar cerdas Lote Vacias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    con.Close()
                'End Try
            End If
        End If
    End Sub
    'Private Sub CbxLoteDe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxLoteDe.SelectedIndexChanged



    'End Sub

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
                dr(3) = If(costoinidivualreemplazoAdapter.GetValorAjuste(Me.dgvLoteDe.CurrentRow.Cells("Cód. Cerda").Value) > 0, 2, 7)
                dr(4) = If(costoinidivualreemplazoAdapter.GetValorAjuste(Me.dgvLoteDe.CurrentRow.Cells("Cód. Cerda").Value) > 0, True, False)
                dr(5) = 350
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
        Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccionar"), DataGridViewCheckBoxCell)
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
    'Sub GrabarTraslado()
    '    Try

    '    Catch ex As Exception
    '        MessageBoxEx.Show(CadenaError & ex.Message, "Error grabar traslado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        con.Close()
    '    End Try
    'End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        HayTraslados = False
        NoTrasladar = 0
        For i As Integer = 0 To Me.dgvLotePara.RowCount - 1
            Try
                HayTraslados = True
                NoTrasladar += 1
                Dim CostoTraia_Cerda As Double = 0
                Dim CostoRequisicion As Double = 0
                Dim TotalCerdos As Integer = 0
                Dim FechaEntro_a_Reemplazos As Date
                sql = New SqlCommand("SELECT Costo_Traia_de_Engorde + isnull(valor_ajuste,0), Fecha_Entro FROM Costo_Cerdas_Individual_Reemplazos where Codigo_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "' and Se_movio_a_vacias='FALSE'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CostoTraia_Cerda = leer(0)
                    FechaEntro_a_Reemplazos = leer(1)
                End While
                con.Close()

                sql = New SqlCommand("SELECT ISNULL((SUM(IMPORTE)),0) FROM LINEAS_DE_REQUISICIONES WHERE Lote_No ='" & Me.CbxLoteDe.Text & "' AND Fecha_Liquidacion BETWEEN '" & FechaEntro_a_Reemplazos & "' AND '" & Me.txtFechaTr.Text & "' and Viva='True'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CostoRequisicion = leer(0)
                End While
                con.Close()

                sql = New SqlCommand("SELECT Total_Cerdos FROM Total_Cerdos_Lote WHERE Lote_No ='" & Me.CbxLoteDe.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    TotalCerdos = leer(0)
                End While
                con.Close()
                Dim Costo_Total As Double = 0
                Costo_Total = (((CostoRequisicion / TotalCerdos) * 1) + CostoTraia_Cerda)

                If Me.tipocerdaComboBoxEx1.Text = "Madres" Then
                    sql = New SqlCommand("UPDATE REG_MADRES SET Costo='" & Costo_Total & "' ,Depreciacion='" & Me.dgvLotePara.Rows(i).Cells("Depreciacion/ Partos").Value & "', Lote_No='" & Me.cbxLotePara.Text & "', Estado_Actual='V', se_deprecia = '" & Me.dgvLotePara.Rows(i).Cells("Depreciar").Value & "', valor_residual='" & Me.dgvLotePara.Rows(i).Cells("Valor Residual").Value & "' WHERE Código_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                ElseIf Me.tipocerdaComboBoxEx1.Text = "Abuelas" Then
                    sql = New SqlCommand("UPDATE REG_ABUELAS SET Costo='" & Costo_Total & "' ,Depreciacion='" & Me.dgvLotePara.Rows(i).Cells("Depreciacion/ Partos").Value & "', Lote_No='" & Me.cbxLotePara.Text & "', Estado_Actual='V' , valor_residual='" & Me.dgvLotePara.Rows(i).Cells("Valor Residual").Value & "' WHERE Código_Abuela='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                End If

               

                sql = New SqlCommand("UPDATE Costo_Cerdas_Individual_Reemplazos SET Se_movio_a_vacias='" & True & "',Fecha_Salio='" & FechaSistema & "' WHERE Codigo_Cerda='" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "'", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()

                Dim ID_DEPRECIACION As Integer = 0
                sql = New SqlCommand("SELECT max(ID_Depreciacion) FROM Depreciacion_x_Cerda", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        ID_DEPRECIACION = 1
                    Else
                        ID_DEPRECIACION = leer(0) + 1
                    End If
                End While
                con.Close()

                sql = New SqlCommand("INSERT INTO Depreciacion_x_Cerda VALUES('" & ID_DEPRECIACION & "','" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "','" & Costo_Total & "','" & Me.dgvLotePara.Rows(i).Cells("Depreciacion/ Partos").Value & "','" & Me.txtFechaTr.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                CostoTotalTraslado += ((CostoRequisicion / TotalCerdos) * 1) + CostoTraia_Cerda

                sql = New SqlCommand("insert into TrasladosEntreLotes values('" & Me.txtTrasladoNo.Text & "','" & Me.CbxLoteDe.Text & "','" & Me.cbxLotePara.Text & "','" & 1 & "','" & CostoTotalTraslado & "','" & Me.txtFechaTr.Text & "','" & Me.dgvLotePara.Rows(i).Cells("Cód. Cerda").Value & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            
        Next
        Try
            If HayTraslados = True Then
                RegistrarMovimientoLote(Me.CbxLoteDe.Text, 0, 0, 0, 0, 0, NoTrasladar, Me.txtFechaTr.Text, "Tr." & Me.txtTrasladoNo.Text)
                RegistrarMovimientoLote(Me.cbxLotePara.Text, 0, 0, 0, 0, NoTrasladar, 0, Me.txtFechaTr.Text, "Tr." & Me.txtTrasladoNo.Text)
                ActualizarLote()
                MessageBoxEx.Show("Se ha guardardo el traslado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
       
    End Sub

   

    Private Sub tipocerdaComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tipocerdaComboBoxEx1.SelectedIndexChanged
        Me.dtLotePara.Clear()
        MostrarLotesReemplazos()
    End Sub
End Class