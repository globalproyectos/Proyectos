Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmDefunciones_Antes_de_Destetar
    Dim Lotes_Gestacion_ActivosTableAdapter As New DtsBDGRANJATableAdapters.Lotes_Gestacion_ActivosTableAdapter
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        With My.Forms.Defunciones
            .chbxCerditosgestacion.CheckState = CheckState.Unchecked
            Me.Close()
        End With

    End Sub
    Sub MostrarLotes_Gestacion_Lactancia()
        Try
            Me.cbxLotesLactando.Items.Clear()
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
                Me.cbxLotesLactando.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al mostrar lotes gestación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub frmDefunciones_Antes_de_Destetar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.Defunciones.NoDefuncionAuto()
    End Sub

    Private Sub frmDefunciones_Antes_de_Destetar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim db As New GRANJAEntities
        Motivo2.DataSource = db.MotivosDefuncionAntesDestete.ToList()
        Motivo2.ValueMember = "Motivo"
        Motivo2.DisplayMember = "Motivo"

        Me.MostrarLotes_Gestacion_Lactancia()
        Correlativo_Auto("select isnull((max(DefuncionNo)),1) from DEFUNCIONES", Me.txtDefuncionNo)

    End Sub
    Private Sub MostrarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Madres_Lactando_Reg_DefuncionTableAdapter.Mostrar(Me.DtsBDGRANJA.Lista_Madres_Lactando_Reg_Defuncion, Me.cbxLotesLactando.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cbxLotesLactando_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesLactando.SelectedIndexChanged
        MostrarToolStripButton_Click(sender, e)
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim HayCambios As Boolean = False
        For I As Integer = 0 To Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows.Count - 1
            If IsNumeric(Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("Defunciones").Value) Then
                If Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("Defunciones").Value > 0 Then
                    HayCambios = True
                    Dim MuertosGestacion As Integer = 0
                    sql = New SqlCommand("SELECT Muertos_Gestacion FROM REG_PARTOS_X_CERDA WHERE ID_Enseminacion='" & Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("IdIns").Value & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        MuertosGestacion = leer(0)
                    End While
                    con.Close()
                    sql = New SqlCommand("UPDATE REG_PARTOS_X_CERDA SET Muertos_Gestacion='" & (Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("Defunciones").Value + MuertosGestacion) & "' where ID_Enseminacion='" & Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("IdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    RegistrarDefuncion(Me.cbxLotesLactando.Text, Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("Defunciones").Value, "MUERTE DE CERDOS EN LACTANCIA, ID_INSEMINACION: " & Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("IdIns").Value, FechaSistema, Me.txtDefuncionNo.Text, Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("CodigoCerda").Value, Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("Motivo2").Value, Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("Peso").Value)
                    InsertarProcesosCerditos(Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("IdIns").Value, "MuertosGes", Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("Defunciones").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesLactando.Text), Me.cbxLotesLactando.Text, Lotes_Gestacion_ActivosTableAdapter.GetLoteDestino(Me.cbxLotesLactando.Text), Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(I).Cells("CodigoCerda").Value, "Df." & Trim(Me.txtDefuncionNo.Text))
                    Correlativo_Auto("select isnull((max(DefuncionNo)),1) from DEFUNCIONES", Me.txtDefuncionNo)



                End If
            End If
        Next
        If HayCambios = True Then
            MessageBoxEx.Show("Se han guardado los cambios exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With My.Forms.Defunciones
                .chbxCerditosgestacion.CheckState = CheckState.Unchecked
            End With
            Me.Close()
        End If
       
    End Sub
    Private Sub Lista_Madres_Lactando_Reg_DefuncionDataGridViewX_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.CellLeave
        Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.EndEdit()
        If IsNumeric(Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(e.RowIndex).Cells("Defunciones").Value) Then
            If Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(e.RowIndex).Cells("Defunciones").Value > Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(e.RowIndex).Cells("NoVivos").Value Then
                Dim index As Integer = 0
                index = e.RowIndex
                MessageBoxEx.Show("La cantidad de defunciones excede el numero de cerdos vivos de la cerda", "Error Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(index).Cells("Defunciones").Value = 0
            End If
        Else
            Me.Lista_Madres_Lactando_Reg_DefuncionDataGridViewX.Rows(e.RowIndex).Cells("Defunciones").Value = 0
        End If
    End Sub
End Class