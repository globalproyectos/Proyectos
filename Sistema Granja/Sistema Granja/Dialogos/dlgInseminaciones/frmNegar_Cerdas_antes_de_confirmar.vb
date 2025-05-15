Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmNegar_Cerdas_antes_de_confirmar
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub frmNegar_Cerdas_antes_de_confirmar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MostrarLotesMontas_Pendientes_confirmar()
    End Sub
    Sub MostrarLotesMontas_Pendientes_confirmar()
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
            MessageBoxEx.Show("Error al mostrar lotes Montas P. Confirmación")
            con.Close()
        End Try
    End Sub

    Private Sub MostrarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Cerdas_Montas_Pendientes_ConfTableAdapter.Mostrar(Me.DtsBDGRANJA.Lista_Cerdas_Montas_Pendientes_Conf, Me.cbxLotesMontas.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cbxLotesMontas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesMontas.SelectedIndexChanged
        MostrarToolStripButton_Click(sender, e)
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.EndEdit()
        Dim NoNulas As Integer = 0
        For i As Integer = 0 To Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows.Count - 1
            If Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(i).Cells("EstadoActual").Value = "NULA" Then
                NoNulas += 1
            End If
        Next
        If NoNulas > 0 Then
            For I As Integer = 0 To Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows.Count - 1

                If Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("EstadoActual").Value = "NULA" Then
                    'MsgBox(Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value)
                    sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='" & 5 & "', Estado_Actual='V' WHERE Código_Cerda='" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='" & 5 & "', Estado_Actual='V' WHERE Código_Abuela='" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("UPDATE Estado_de_Partos set Estado_Parto='" & True & "' where Id_Enseminacion='" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("IDIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("UPDATE Reg_Enseminaciones_x_cerda SET Estado='N' WHERE Código_Cerda='" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value & "' and Id_Enseminacion='" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("IDIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    Actualizar_Estado_Parto(Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("IDIns").Value, True)
                    Dim NoNegacion As Integer = 0
                    sql = New SqlCommand("select MAX(No_Negaciones) FROM Registro_Inseminaciones_nulas_x_Cerdas WHERE Codigo_Cerda='" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value & "'", con)
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
                    Dim fechaInseminacion As Date
                    Dim verraco As String = ""
                    sql = New SqlCommand("select Fecha_Enseminacion,Verraco from Reg_Enseminaciones_x_cerda where Id_Enseminacion='" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("IDIns").Value & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        fechaInseminacion = leer(0)
                        verraco = leer(1)
                    End While
                    con.Close()
                    sql = New SqlCommand("insert into Registro_Inseminaciones_nulas_x_Cerdas values('" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("IDIns").Value & "','" & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value & "','" & fechaInseminacion & "','" & FechaSistema & "','" & NoNegacion & "','" & verraco & "','" & 0 & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    RegistrarMovimientoLote(Me.cbxLotesMontas.Text.ToString, 0, 0, 0, 0, 0, 1, FechaSistema, "Ci." & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value)
                    RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, "Ci." & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value)

                    InsertarProcesoCerda(Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("IDIns").Value, Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value, "Inseminacion Nula", FechaSistema, "Ci." & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value, Me.cbxLotesMontas.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("IDIns").Value, Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value, "Inseminacion Nula", FechaSistema, "Ci." & Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Rows(I).Cells("CodigoCerda").Value, "5", "E")

                End If
            Next
            If NoNulas = 1 Then
                MessageBoxEx.Show("El cambio se guardo exitosamente, la cerda fue movida al corral de las vacias", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarToolStripButton_Click(sender, e)
            ElseIf NoNulas > 1 Then
                MessageBoxEx.Show("El cambio se guardo exitosamente, las cerdas se movieron al corral de las vacias", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarToolStripButton_Click(sender, e)
            End If

        Else
            MessageBoxEx.Show("No se ha encontrado ningun cambio", "Sin Cambios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class