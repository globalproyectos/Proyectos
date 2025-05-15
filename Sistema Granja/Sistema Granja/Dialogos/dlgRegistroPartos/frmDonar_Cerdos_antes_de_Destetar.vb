Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmDonar_Cerdos_antes_de_Destetar
    Dim Fila As Integer = 0
    Dim No_A_Donar As Integer = 0
    Dim Adoptados As Integer = 0
    Dim FILA2 As Integer = 0
    Dim codigo_Cerda As String = ""
    Dim IdInseminacion As Integer = 0
    Dim hayDonaciones As Boolean = False
    Dim Id_Insem_Dona As Integer = 0
    Dim Lotes_Gestacion_ActivosTableAdapter As New DtsBDGRANJATableAdapters.Lotes_Gestacion_ActivosTableAdapter


    Private Sub frmDonar_Cerdos_antes_de_Destetar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostarLotesGestacion_Lactancia()
    End Sub
    Sub MostarLotesGestacion_Lactancia()
        Try
            Me.CbxLoteDe.Items.Clear()
            Me.cbxLotesA.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                           & " FROM LOTES l" _
                           & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                           & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                           & " where L.Estado <>'T' AND ((rm.Estado_Actual ='L' OR RA.Estado_Actual ='L'))" _
                           & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
                           & " ORDER BY L.IdEtapa_Cerdas"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.CbxLoteDe.Items.Add(leer(0))
                Me.cbxLotesA.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al mostrar lotes Gestacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub MostrarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Cerdos_Donaciones_ComplTableAdapter.Mostrar(Me.DtsBDGRANJA.Lista_Cerdas_Cerdos_Donaciones_Compl, Me.CbxLoteDe.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub dgvLoteDe_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CellValueChanged
        If e.ColumnIndex <> 1 Then
            Return
        End If
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            Dim bln As Boolean = CBool(cb.Value)
            MsgBox(bln.ToString)
        End If
    End Sub

    Private Sub Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.CellLeave
        Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.EndEdit()
        FILA2 = e.RowIndex
        Me.txtDonaciones.Text = (No_A_Donar - Adoptados)
        If IsNumeric(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(e.RowIndex).Cells("Adopciones").Value) Then

            Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.EndEdit()
            Adoptados = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
                Adoptados += Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value
            Next
            Me.txtDonaciones.Text = (No_A_Donar - Adoptados)
            Me.txtAdopciones.Text = Adoptados
            If Adoptados > No_A_Donar Then
                MessageBoxEx.Show("El numero de cerditos que desea adoptarle a la cerda es mayor de las donaciones disponibles", "Excedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(FILA2).Cells("Adopciones").Value = 0
                Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.CurrentCell = Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(FILA2).Cells("Adopciones")
                Me.txtDonaciones.Text = (No_A_Donar - Adoptados)
                Me.txtAdopciones.Text = Adoptados
                Adoptados = 0
                For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
                    Adoptados += Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value
                Next
            Else
                Adoptados = 0
                For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
                    Adoptados += Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value
                Next
                Me.txtDonaciones.Text = (No_A_Donar - Adoptados)
                Me.txtAdopciones.Text = Adoptados
            End If
            Adoptados = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
                Adoptados += Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value
            Next
            Me.txtDonaciones.Text = (No_A_Donar - Adoptados)
            Me.txtAdopciones.Text = Adoptados
        End If
    End Sub
    Private Sub dgvLoteA_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.CellValueChanged
        If e.ColumnIndex <> 1 Then
            Return
        End If
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            Dim bln As Boolean = CBool(cb.Value)
            MsgBox(bln.ToString)
        End If
    End Sub
    Private Sub dgvLoteDe_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub dgvLoteA_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub CbxLoteDe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxLoteDe.SelectedIndexChanged
        MostrarToolStripButton_Click(sender, e)

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If Me.btnCancelar.Text = "&Cerrar" Then
            Me.Close()
        Else
            Me.btnCancelar.Text = "&Cerrar"
            Me.btnCancelar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
            Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Rows(Fila).Cells("Donar").Value = False
            Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Enabled = True
            Me.CbxLoteDe.Enabled = True
            Me.SwitchButton1.Enabled = True
            Me.txtDonaciones.Text = "0"
            Me.txtAdopciones.Text = "0"
            Me.cbxLotesA.Enabled = False
            No_A_Donar = 0
            Adoptados = 0
            Me.cbxLotesA.Text = ""
            hayDonaciones = False
            Mostrar2ToolStripButton_Click(sender, e)
        End If
    End Sub
    Private Sub Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CellContentClick
        Dim NomColumna As String = Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Columns(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentCell.ColumnIndex).HeaderText
        Dim row As DataGridViewRow = Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Rows(e.RowIndex)
        Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Donar"), DataGridViewCheckBoxCell)
        Id_Insem_Dona = 0
        If cellSelecion.Value = True Then
            Fila = e.RowIndex
            Id_Insem_Dona = Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Rows(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentCell.RowIndex).Cells("IdIns").Value
            Me.txtDonaciones.Text = Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Rows(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentCell.RowIndex).Cells("NoVivos").Value
            Me.No_A_Donar = Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Rows(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentCell.RowIndex).Cells("NoVivos").Value
            codigo_Cerda = Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Rows(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentCell.RowIndex).Cells("CodigoCerda").Value
            hayDonaciones = True
            Me.btnCancelar.Text = "&Cancelar"
            Me.btnCancelar.Image = New System.Drawing.Bitmap(My.Resources.button_cancel)
            Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Enabled = False
            Me.SwitchButton1.Enabled = False
            Me.CbxLoteDe.Enabled = False
            If Me.SwitchButton1.Value = False Then
                Me.cbxLotesA.Text = Me.CbxLoteDe.Text
                cbxLotesA_SelectedIndexChanged(sender, e)
            Else
                Me.cbxLotesA.Text = ""
            End If

        Else
            Me.btnCancelar.Text = "&Cerrar"
            Me.btnCancelar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
            Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Enabled = True
            Me.CbxLoteDe.Enabled = True
            Me.cbxLotesA.Enabled = False
        End If
    End Sub
    Private Sub Mostrar2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Cerdos_Donaciones_Compl1TableAdapter.Mostrar2(Me.DtsBDGRANJA.Lista_Cerdas_Cerdos_Donaciones_Compl1, Me.cbxLotesA.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub cbxLotesA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesA.SelectedIndexChanged
        Mostrar2ToolStripButton_Click(sender, e)
        Adoptados = 0

        For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
            If IsNumeric(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value) Then
                Adoptados += Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value
            End If
        Next
        Me.txtDonaciones.Text = (No_A_Donar - Adoptados)
        Me.txtAdopciones.Text = Adoptados
        For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
            If RTrim(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("CodigoCerda2").Value) = RTrim(codigo_Cerda) Then
                Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).ReadOnly = True
                Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.RowEnter
        Adoptados = 0

        For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
            If IsNumeric(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value) Then
                Adoptados += Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value
            End If
        Next
        Me.txtDonaciones.Text = (No_A_Donar - Adoptados)
        Me.txtAdopciones.Text = Adoptados
    End Sub

    Private Sub btnGuardarMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarMovimiento.Click
        If hayDonaciones = True Then
            Adoptados = 0
            For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
                If IsNumeric(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value) Then
                    Adoptados += Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value
                End If
            Next
            If Me.SwitchButton1.Value = True Then
                If Adoptados = No_A_Donar Then

                    If RTrim(Me.CbxLoteDe.Text) = RTrim(Me.cbxLotesA.Text) Then
                        sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='5', Estado_Actual='V' WHERE Código_Cerda='" & codigo_Cerda & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                        sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='5', Estado_Actual='V' WHERE Código_Abuela='" & codigo_Cerda & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                        IdInseminacion = Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value
                        sql = New SqlCommand("update REG_PARTOS_X_CERDA SET Se_Destetaron='" & True & "' where ID_Enseminacion='" & IdInseminacion & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Dc." & IdInseminacion)
                        RegistrarMovimientoLote(Me.CbxLoteDe.Text, 0, 0, 0, 0, 0, 1, FechaSistema, "Dc." & IdInseminacion)

                        InsertarProcesoCerda(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value, codigo_Cerda, "Donacion completa", FechaSistema, "Dc." & IdInseminacion, Me.CbxLoteDe.Text, "S")
                        InsertarProcesoCerda(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value, codigo_Cerda, "Donacion completa", FechaSistema, "Dc." & IdInseminacion, "5", "E")


                        'InsertarProcesosCerditos(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value, "Donaciones", Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("Adopciones").Value, FechaSistema, UsuarioSistema, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesA.Text), Me.cbxLotesA.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesA.Text), codigo_Cerda, "Dc." & IdInseminacion)
                        For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
                            If IsNumeric(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value) Then
                                If Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value > 0 Then
                                    Dim corrDonacion As Integer = CorrelativoDonacion()
                                    RegistrarDonacion(corrDonacion, Me.CbxLoteDe.Text, codigo_Cerda, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, Me.cbxLotesA.Text, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("CodigoCerda2").Value, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("NoVivos2").Value, 0, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("IdIns2").Value, Id_Insem_Dona)
                                    InsertarProcesosCerditos(Id_Insem_Dona, "Donaciones", Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.CbxLoteDe.Text), Me.CbxLoteDe.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.CbxLoteDe.Text), codigo_Cerda, "Dc." & corrDonacion)
                                    InsertarProcesosCerditos(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("IdIns2").Value, "Adopciones", Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, FechaSistema, UsuarioSistema, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesA.Text), Me.cbxLotesA.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesA.Text), Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("CodigoCerda2").Value, "Dc." & corrDonacion)
                                End If
                            End If
                        Next
                        MessageBoxEx.Show("Se ha efectuado el movimiento exitosamente la cerda código: " & RTrim(codigo_Cerda) & " , ha sido devuelta al corral de las vacias", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ActualizarLote()
                        RevisarCierre_Lote(Me.CbxLoteDe.Text, Me.CbxLoteDe)
                        Me.CbxLoteDe.Text = ""
                        Me.cbxLotesA.Text = ""
                        Me.SwitchButton1.Enabled = True
                        Me.CbxLoteDe.Enabled = True
                        Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Enabled = True
                        Mostrar2ToolStripButton_Click(sender, e)
                        MostrarToolStripButton_Click(sender, e)
                        hayDonaciones = False
                        No_A_Donar = 0
                        Adoptados = 0
                        codigo_Cerda = ""
                        Me.txtAdopciones.Text = "0"
                        Me.txtDonaciones.Text = "0"
                        Me.btnCancelar.Text = "&Cerrar"
                        Me.btnCancelar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
                        IdInseminacion = 0
                    Else

                        sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='5', Estado_Actual='V' WHERE Código_Cerda='" & codigo_Cerda & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                        sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='5', Estado_Actual='V' WHERE Código_Abuela='" & codigo_Cerda & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        IdInseminacion = Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value
                        sql = New SqlCommand("update REG_PARTOS_X_CERDA SET Se_Destetaron='" & True & "' where ID_Enseminacion='" & IdInseminacion & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Dc." & IdInseminacion)
                        RegistrarMovimientoLote(Me.CbxLoteDe.Text, 0, 0, 0, 0, 0, 1, FechaSistema, "Dc." & IdInseminacion)

                        InsertarProcesoCerda(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value, codigo_Cerda, "Donacion completa", FechaSistema, "Dc." & IdInseminacion, Me.CbxLoteDe.Text, "S")
                        InsertarProcesoCerda(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value, codigo_Cerda, "Donacion completa", FechaSistema, "Dc." & IdInseminacion, "5", "E")

                        For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
                            If IsNumeric(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value) Then
                                If Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value > 0 Then
                                    Dim corrDonacion As Integer = CorrelativoDonacion()
                                    RegistrarDonacion(corrDonacion, Me.CbxLoteDe.Text, codigo_Cerda, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, Me.cbxLotesA.Text, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("CodigoCerda2").Value, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("NoVivos2").Value, 0, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("IdIns2").Value, Id_Insem_Dona)
                                    InsertarProcesosCerditos(Id_Insem_Dona, "Donaciones", Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.CbxLoteDe.Text), Me.CbxLoteDe.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.CbxLoteDe.Text), codigo_Cerda, "Dc." & corrDonacion)
                                    InsertarProcesosCerditos(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("IdIns2").Value, "Adopciones", Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesA.Text), Me.cbxLotesA.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesA.Text), Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("CodigoCerda2").Value, "Dc." & corrDonacion)
                                End If
                            End If
                        Next

                        HalarCostos_Traslados(Me.CbxLoteDe.Text, Me.cbxLotesA.Text, FechaSistema, "DONACION COMPLETA DE CERDOS, DONADOS: " & Adoptados & ", ID INSEMINACION: " & RTrim(CStr(Id_Insem_Dona)), 1, "Dc." & IdInseminacion)
                        MessageBoxEx.Show("Se ha efectuado el movimiento exitosamente la cerda código: " & RTrim(codigo_Cerda) & " , ha sido devuelta al corral de las vacias", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ActualizarLote()
                        RevisarCierre_Lote(Me.CbxLoteDe.Text, Me.CbxLoteDe)
                        Me.CbxLoteDe.Text = ""
                        Me.cbxLotesA.Text = ""
                        Me.SwitchButton1.Enabled = True
                        Me.CbxLoteDe.Enabled = True
                        Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Enabled = True
                        Mostrar2ToolStripButton_Click(sender, e)
                        MostrarToolStripButton_Click(sender, e)
                        hayDonaciones = False
                        No_A_Donar = 0
                        Adoptados = 0
                        codigo_Cerda = ""
                        Me.txtAdopciones.Text = "0"
                        Me.txtDonaciones.Text = "0"
                        Me.btnCancelar.Text = "&Cerrar"
                        Me.btnCancelar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
                        IdInseminacion = 0

                    End If
                Else
                    MessageBoxEx.Show("No ha distribuido totos los cerdos, no puede continuar hasta que los distribuya todos", "No Completado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf SwitchButton1.Value = False Then
                For i As Integer = 0 To Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows.Count - 1
                    If IsNumeric(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value) Then
                        If Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value > 0 Then
                            Dim corrDonacion As Integer = CorrelativoDonacion()
                            RegistrarDonacion(corrDonacion, Me.CbxLoteDe.Text, codigo_Cerda, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, Me.cbxLotesA.Text, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("CodigoCerda2").Value, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("NoVivos2").Value, 0, Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("IdIns2").Value, Id_Insem_Dona)
                            InsertarProcesosCerditos(Id_Insem_Dona, "Donaciones", Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.CbxLoteDe.Text), Me.CbxLoteDe.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.CbxLoteDe.Text), codigo_Cerda, "Dc." & corrDonacion)
                            InsertarProcesosCerditos(Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("IdIns2").Value, "Adopciones", Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("Adopciones").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesA.Text), Me.cbxLotesA.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesA.Text), Me.Lista_Cerdas_Cerdos_Donaciones_Compl1DataGridViewX.Rows(i).Cells("CodigoCerda2").Value, "Dc." & corrDonacion)
                        End If
                    End If
                Next
                Dim donotodos As Boolean = False
                Try
                    If Val(Me.txtDonaciones.Text) = 0 Then
                        sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='5', Estado_Actual='V' WHERE Código_Cerda='" & codigo_Cerda & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                        sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='5', Estado_Actual='V' WHERE Código_Abuela='" & codigo_Cerda & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                        donotodos = True
                    End If
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "Error al devolver cerda a Vácias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                End Try
                If donotodos = True Then
                    RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Dc." & IdInseminacion)
                    RegistrarMovimientoLote(Me.CbxLoteDe.Text, 0, 0, 0, 0, 0, 1, FechaSistema, "Dc." & IdInseminacion)

                    InsertarProcesoCerda(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value, codigo_Cerda, "Donacion completa", FechaSistema, "Dc." & IdInseminacion, Me.CbxLoteDe.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.CurrentRow.Cells("IdIns").Value, codigo_Cerda, "Donacion completa", FechaSistema, "Dc." & IdInseminacion, "5", "E")

                    MessageBoxEx.Show("Se ha efectuado el movimiento exitosamente la cerda código: " & RTrim(codigo_Cerda) & " , ha donado" & RTrim(Me.txtAdopciones.Text) & " Cerdo/os" & vbCrLf & "y la cerda ha sido devuelta a corral de las vacias", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBoxEx.Show("Se ha efectuado el movimiento exitosamente la cerda código: " & RTrim(codigo_Cerda) & " , ha donado" & RTrim(Me.txtAdopciones.Text) & " Cerdo/os", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.CbxLoteDe.Text = ""
                Me.cbxLotesA.Text = ""
                Me.SwitchButton1.Enabled = True
                Me.CbxLoteDe.Enabled = True
                Me.Lista_Cerdas_Cerdos_Donaciones_ComplDataGridViewX.Enabled = True
                Mostrar2ToolStripButton_Click(sender, e)
                MostrarToolStripButton_Click(sender, e)
                hayDonaciones = False
                No_A_Donar = 0
                Adoptados = 0
                codigo_Cerda = ""
                Me.txtAdopciones.Text = "0"
                Me.txtDonaciones.Text = "0"
                Me.btnCancelar.Text = "&Cerrar"
                Me.btnCancelar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
                IdInseminacion = 0
            End If
        Else
            MessageBoxEx.Show("No se encontro ninguna adopcion", "Sin Adopciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SwitchButton1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SwitchButton1.ValueChanged
        If Me.SwitchButton1.Value = False Then
            Me.cbxLotesA.Enabled = False
        ElseIf Me.SwitchButton1.Value = True Then
            Me.cbxLotesA.Enabled = True
        End If
    End Sub
End Class