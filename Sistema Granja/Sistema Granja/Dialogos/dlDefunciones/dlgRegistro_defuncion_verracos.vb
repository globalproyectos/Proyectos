Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class dlgRegistro_defuncion_verracos
    Public DefuncioNo As Integer
    Public FechaDf As Date
    Public LoteNo As String
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Sub MostrarVerracos()
        Try
            sql = New SqlCommand("SELECT Codigo_Cerdo,Fecha_Compra FROM REG_VERRACOS where Lote_No='" & LoteNo & "' and Estado_Actual<>'D' AND Estado_Actual<>'DF'", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Codigo"))
                .Add(New DataColumn("Fecha Nac."))
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
                dr(2) = False
                dr(3) = ""
                dr(4) = 0
                dt.Rows.Add(dr)
            End While
            con.Close()
            Me.DataGridViewX1.DataSource = dt
            Me.DataGridViewX1.Columns(0).Width = 60
            Me.DataGridViewX1.Columns(1).Width = 70
            Me.DataGridViewX1.Columns(2).Width = 70
            Me.DataGridViewX1.Columns(3).Width = 250

            Me.DataGridViewX1.Columns(0).ReadOnly = True
            Me.DataGridViewX1.Columns(1).ReadOnly = True
            Me.DataGridViewX1.Columns(2).ReadOnly = True
            Me.DataGridViewX1.Columns(3).ReadOnly = False

            Me.DataGridViewX1.Columns(0).DefaultCellStyle.BackColor = Color.Gray
            Me.DataGridViewX1.Columns(1).DefaultCellStyle.BackColor = Color.Gray
            Me.DataGridViewX1.Columns(2).DefaultCellStyle.BackColor = Color.Gray
            Me.DataGridViewX1.Columns(3).DefaultCellStyle.BackColor = Color.White

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al mostrar Verracos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub dlgRegistro_defuncion_verracos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDefuncionNo.Text = DefuncioNo
        Me.txtFechaDefuncion.Text = FechaDf
        Me.txtLoteNo.Text = LoteNo
        Me.MostrarVerracos()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.DataGridViewX1.RowCount > 0 Then
            GrabarDefuncion()
            MessageBoxEx.Show("Se guardó la defuncion exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With My.Forms.Defunciones
                .NoDefuncionAuto()
            End With
            Me.Close()
        End If
    End Sub

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

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
            For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                If Me.DataGridViewX1.Rows(i).Cells("Defuncion").Value = True Then
                    RegistrarDefuncion(Me.txtLoteNo.Text, 1, Me.DataGridViewX1.Rows(i).Cells("Motivo").Value, Me.txtFechaDefuncion.Text, Me.txtDefuncionNo.Text, Me.DataGridViewX1.Rows(i).Cells("Codigo").Value, Me.DataGridViewX1.Rows(i).Cells("Motivo").Value, Me.DataGridViewX1.Rows(i).Cells("Peso").Value)
                    sql = New SqlCommand("UPDATE REG_VERRACOS SET Estado_Actual='DF',Lote_No='0' WHERE Codigo_Cerdo='" & Me.DataGridViewX1.Rows(i).Cells("Codigo").Value & "' and Lote_No='" & Me.txtLoteNo.Text & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    RegistrarMovimientoLote(Me.txtLoteNo.Text, 0, 1, 0, 0, 0, 0, Me.txtFechaDefuncion.Text, "Df." & Me.txtDefuncionNo.Text)
                End If
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar defuniones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

 
    Private Sub lbInfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbInfo.TextChanged
        If Me.lbInfo.Text <> "" Then
            Me.btnGuardar.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
        End If
    End Sub
End Class