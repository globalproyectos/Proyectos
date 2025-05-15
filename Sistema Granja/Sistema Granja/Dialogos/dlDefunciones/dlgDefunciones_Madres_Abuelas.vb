Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class dlgDefunciones_Madres_Abuelas
    Public DefuncioNo As Integer
    Public FechaDf As Date
    Public LoteNo As String
    Public Abuela_o_Madre As String

    Dim reg_madresAdapter As New DtsBDGRANJATableAdapters.Reg_MadresTableAdapter
    Dim reg_abuelasAdapter As New DtsBDGRANJATableAdapters.Reg_AbuelasTableAdapter
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Sub MostrarAbuelas_o_Madres()
        Try
            If Me.chbxAbuelas.CheckState = CheckState.Checked Then
                sql = New SqlCommand("select a.Código_Abuela ,a.Fecha_Nacimiento ,e.Descripcion from REG_ABUELAS a JOIN Etapas_Cerdas e on a.Estado_Actual=e.Codigo WHERE a.Lote_No='" & LoteNo & "' and (a.Estado_Actual<>'D' AND a.Estado_Actual<>'DF')", con)
                dt = New DataTable
                With dt.Columns
                    .Add(New DataColumn("Codigo"))
                    .Add(New DataColumn("Fecha Nac."))
                    .Add(New DataColumn("Estado Actual"))
                    .Add(New DataColumn("Defuncion", System.Type.GetType("System.Boolean")))
                    .Add(New DataColumn("Motivo"))
                    .Add(New DataColumn("Peso", System.Type.GetType("System.Double")))

                End With
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = Format(leer(1), "dd/MM/yyyy")
                    dr(2) = leer(2)
                    dr(3) = False
                    dr(4) = ""
                    dr(5) = 0
                    dt.Rows.Add(dr)
                End While
                con.Close()
                Me.DataGridViewX1.DataSource = dt
                Me.DataGridViewX1.Columns(0).Width = 60
                Me.DataGridViewX1.Columns(1).Width = 70
                Me.DataGridViewX1.Columns(2).Width = 150
                Me.DataGridViewX1.Columns(3).Width = 70
                Me.DataGridViewX1.Columns(4).Width = 280

                Me.DataGridViewX1.Columns(0).ReadOnly = True
                Me.DataGridViewX1.Columns(1).ReadOnly = True
                Me.DataGridViewX1.Columns(2).ReadOnly = True
                Me.DataGridViewX1.Columns(3).ReadOnly = True

                Me.DataGridViewX1.Columns(0).DefaultCellStyle.BackColor = Color.Gray
                Me.DataGridViewX1.Columns(1).DefaultCellStyle.BackColor = Color.Gray
                Me.DataGridViewX1.Columns(2).DefaultCellStyle.BackColor = Color.Gray
                Me.DataGridViewX1.Columns(3).DefaultCellStyle.BackColor = Color.Gray
            ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
                sql = New SqlCommand("select a.Código_Cerda ,a.Fecha_Nacimiento ,e.Descripcion from REG_MADRES a JOIN Etapas_Cerdas e on a.Estado_Actual=e.Codigo WHERE a.Lote_No='" & LoteNo & "' and (a.Estado_Actual<>'D' AND a.Estado_Actual<>'DF')", con)
                dt = New DataTable
                With dt.Columns
                    .Add(New DataColumn("Codigo"))
                    .Add(New DataColumn("Fecha Nac."))
                    .Add(New DataColumn("Estado Actual"))
                    .Add(New DataColumn("Defuncion", System.Type.GetType("System.Boolean")))
                    .Add(New DataColumn("Motivo"))
                    .Add(New DataColumn("Peso", System.Type.GetType("System.Double")))

                End With
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = Format(leer(1), "dd/MM/yyyy")
                    dr(2) = leer(2)
                    dr(3) = False
                    dr(4) = ""
                    dr(5) = 0
                    dt.Rows.Add(dr)
                End While
                con.Close()
                Me.DataGridViewX1.DataSource = dt
                Me.DataGridViewX1.Columns(0).Width = 60
                Me.DataGridViewX1.Columns(1).Width = 70
                Me.DataGridViewX1.Columns(2).Width = 150
                Me.DataGridViewX1.Columns(3).Width = 70
                Me.DataGridViewX1.Columns(4).Width = 280

                Me.DataGridViewX1.Columns(0).ReadOnly = True
                Me.DataGridViewX1.Columns(1).ReadOnly = True
                Me.DataGridViewX1.Columns(2).ReadOnly = True
                Me.DataGridViewX1.Columns(3).ReadOnly = True

                Me.DataGridViewX1.Columns(0).DefaultCellStyle.BackColor = Color.Gray
                Me.DataGridViewX1.Columns(1).DefaultCellStyle.BackColor = Color.Gray
                Me.DataGridViewX1.Columns(2).DefaultCellStyle.BackColor = Color.Gray
                Me.DataGridViewX1.Columns(3).DefaultCellStyle.BackColor = Color.Gray
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub dlgDefunciones_Madres_Abuelas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDefuncionNo.Text = DefuncioNo
        Me.txtFechaDefuncion.Text = FechaDf
        Me.txtLoteNo.Text = LoteNo
        If Abuela_o_Madre = "Abuelas" Then
            Me.chbxAbuelas.CheckState = CheckState.Checked
            Me.chbxMadres.CheckState = CheckState.Unchecked
        ElseIf Abuela_o_Madre = "Madres" Then
            Me.chbxMadres.CheckState = CheckState.Checked
            Me.chbxAbuelas.CheckState = CheckState.Unchecked

        End If
        Me.MostrarAbuelas_o_Madres()

    End Sub
    Private Sub DataGridViewX1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        Try
            Me.DataGridViewX1.EndEdit()
            If Me.DataGridViewX1.Rows(e.RowIndex).Cells("Defuncion").Value = True And Me.DataGridViewX1.Rows(e.RowIndex).Cells("Motivo").Value = "" Then
                Me.lbInfo.Text = "HAY DEFUNCIONES MARCADAS SIN ESPECIFICAR MOTIVOS"
            End If
            If Me.DataGridViewX1.Rows(e.RowIndex).Cells("Motivo").Value <> "" Then
                Me.DataGridViewX1.Rows(e.RowIndex).Cells("Defuncion").Value = True
            Else
                Me.DataGridViewX1.Rows(e.RowIndex).Cells("Defuncion").Value = False
            End If
        Catch ex As Exception
            Me.DataGridViewX1.Rows(e.RowIndex).Cells("Motivo").Value = ""
            Me.DataGridViewX1.Rows(e.RowIndex).Cells("Defuncion").Value = False
        End Try

    End Sub
    Sub GrabarDefuncion()
        Try
            If Me.chbxAbuelas.CheckState = CheckState.Checked Then
                For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                    If Me.DataGridViewX1.Rows(i).Cells("Defuncion").Value = True Then
                        If Trim(Me.reg_abuelasAdapter.GetEstadoCerda(RTrim(Me.DataGridViewX1.Rows(i).Cells("Codigo").Value))) = "VACIA" Then
                            RegistrarDefuncion(Me.txtLoteNo.Text, 1, Me.DataGridViewX1.Rows(i).Cells("Motivo").Value, Me.txtFechaDefuncion.Text, Me.txtDefuncionNo.Text, Me.DataGridViewX1.Rows(i).Cells("Codigo").Value, Me.DataGridViewX1.Rows(i).Cells("Motivo").Value, Me.DataGridViewX1.Rows(i).Cells("Peso").Value)
                            sql = New SqlCommand("UPDATE REG_ABUELAS SET Estado_Actual='DF',Lote_No='0' WHERE Código_Abuela='" & RTrim(Me.DataGridViewX1.Rows(i).Cells("Codigo").Value) & "'", con)
                            con.Open()
                            sql.ExecuteNonQuery()
                            con.Close()
                            RegistrarMovimientoLote(Me.txtLoteNo.Text, 0, 1, 0, 0, 0, 0, Me.txtFechaDefuncion.Text, "Df." & Me.txtDefuncionNo.Text)
                            MessageBoxEx.Show("Se guardó la defunción correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBoxEx.Show("No puede registrar una defunción para el código de cerda: " & RTrim(Me.DataGridViewX1.Rows(i).Cells("Codigo").Value) & " debido a que esta dentro de un proceso de producción" & vbCrLf & vbCrLf & "Estado Actual: " & Me.reg_abuelasAdapter.GetEstadoCerda(RTrim(Me.DataGridViewX1.Rows(i).Cells("Codigo").Value)) & vbCrLf & vbCrLf & "Qué se debe hacer para cada fase:" & vbCrLf & "Inseminada Pendiente: debe realizar la negación de la inseminación" & vbCrLf & "Gestando: debe realizar el proceso de aborto para liberar a la cerda el proceso" & vbCrLf & "Lactando: debe hacer una donación completa de todos los cerditos para liberar a la cerda el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        

                    End If
                Next
            ElseIf Me.chbxMadres.CheckState = CheckState.Checked Then
                For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                    If Me.DataGridViewX1.Rows(i).Cells("Defuncion").Value = True Then
                        If Trim(Me.reg_madresAdapter.GetEstadoCerda(RTrim(Me.DataGridViewX1.Rows(i).Cells("Codigo").Value))) = "VACIA" Then
                            RegistrarDefuncion(Me.txtLoteNo.Text, 1, Me.DataGridViewX1.Rows(i).Cells("Motivo").Value, Me.txtFechaDefuncion.Text, Me.txtDefuncionNo.Text, Me.DataGridViewX1.Rows(i).Cells("Codigo").Value, Me.DataGridViewX1.Rows(i).Cells("Motivo").Value, Me.DataGridViewX1.Rows(i).Cells("Peso").Value)
                            sql = New SqlCommand("UPDATE REG_MADRES SET Estado_Actual='DF',Lote_No='0' WHERE Código_Cerda='" & RTrim(Me.DataGridViewX1.Rows(i).Cells("Codigo").Value) & "'", con)
                            con.Open()
                            sql.ExecuteNonQuery()
                            con.Close()
                            RegistrarMovimientoLote(Me.txtLoteNo.Text, 0, 1, 0, 0, 0, 0, Me.txtFechaDefuncion.Text, "Df." & Me.txtDefuncionNo.Text)
                            MessageBoxEx.Show("Se guardó la defunción correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBoxEx.Show("No puede registrar una defunción para el código de cerda: " & RTrim(Me.DataGridViewX1.Rows(i).Cells("Codigo").Value) & " debido a que esta dentro de un proceso de producción" & vbCrLf & vbCrLf & "Estado Actual: " & Me.reg_madresAdapter.GetEstadoCerda(RTrim(Me.DataGridViewX1.Rows(i).Cells("Codigo").Value)) & vbCrLf & vbCrLf & "Qué se debe hacer para cada fase:" & vbCrLf & "Inseminada Pendiente: debe realizar la negación de la inseminación" & vbCrLf & "Gestando: debe realizar el proceso de aborto para liberar a la cerda el proceso" & vbCrLf & "Lactando: debe hacer una donación completa de todos los cerditos para liberar a la cerda el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        
                    End If
                Next
            End If
            RevisarCierre_Lote(Me.txtLoteNo.Text, Me.ComboBoxEx1)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar defuniones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.DataGridViewX1.RowCount > 0 Then
            GrabarDefuncion()

            With My.Forms.Defunciones
                .NoDefuncionAuto()
            End With
            Me.Close()
        End If
    End Sub

    

    Private Sub lbInfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbInfo.TextChanged
        If Me.lbInfo.Text <> "" Then
            Me.btnGuardar.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
        End If
    End Sub
End Class