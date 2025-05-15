Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient

Public Class frmMuestraPartosProgramados
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub frmMuestraPartosProgramados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.rbtMadres.Checked = True Then
            Me.MostrarCodigoCerdasMadres()
        ElseIf Me.rbtAbuelas.Checked = True Then
            Me.MostrarCodigoCerdasAbuelas()
        End If
        Me.RecuperarInfoPartosPendientes()
    End Sub
    Sub RecuperarInfoPartosPendientes()
        Try
            sql = New SqlCommand("SELECT * from Reg_Enseminaciones_x_cerda AS a JOIN Estado_de_Partos AS b ON a.Id_Enseminacion=b.Id_Enseminacion WHERE b.Estado_Parto=0 AND a.Estado='C'", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("IdEnseminación"))
                .Add(New DataColumn("Código Cerda"))
                .Add(New DataColumn("Fecha de Enseminación"))
                .Add(New DataColumn("Estado"))
                .Add(New DataColumn("Fecha estimada de Parto"))
            End With
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                Else
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer(1)
                    dr(2) = leer(2)
                    dr(3) = leer(3)
                    dr(4) = Format(leer(4), "dd/MM/yy")
                    dt.Rows.Add(dr)
                End If
            End While
            con.Close()
            dv = New DataView(dt)
            Me.DataGridViewX1.DataSource = dv
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        EstiloDatagrid(Me.DataGridViewX1, 8, "Arial", FontStyle.Regular)
        Me.DataGridViewX1.Columns(0).Width = 90
        Me.DataGridViewX1.Columns(1).Width = 80
        Me.DataGridViewX1.Columns(2).Width = 80
        Me.DataGridViewX1.Columns(3).Width = 75
        Me.DataGridViewX1.Columns(4).Width = 80
        Me.lbNo.Text = Me.DataGridViewX1.Rows.Count
    End Sub
    Sub RecuperarInfoPartosPendientes_x_Codigo()
        Try
            sql = New SqlCommand("SELECT * from Reg_Enseminaciones_x_cerda AS a JOIN Estado_de_Partos AS b ON a.Id_Enseminacion=b.Id_Enseminacion WHERE b.Estado_Parto=0 AND a.Estado='C' and a.Código_Cerda='" & Me.cbxCodigosCerdas.Text & "'", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("IdEnseminación"))
                .Add(New DataColumn("Código Cerda"))
                .Add(New DataColumn("Fecha de Enseminación"))
                .Add(New DataColumn("Estado"))
                .Add(New DataColumn("Fecha estimada de Parto"))
            End With
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                Else
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer(1)
                    dr(2) = leer(2)
                    dr(3) = leer(3)
                    dr(4) = Format(leer(4), "dd/MM/yy")
                    dt.Rows.Add(dr)
                End If
            End While
            con.Close()
            dv = New DataView(dt)
            Me.DataGridViewX1.DataSource = dv
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        EstiloDatagrid(Me.DataGridViewX1, 8, "Arial", FontStyle.Regular)
        Me.DataGridViewX1.Columns(0).Width = 90
        Me.DataGridViewX1.Columns(1).Width = 80
        Me.DataGridViewX1.Columns(2).Width = 80
        Me.DataGridViewX1.Columns(3).Width = 75
        Me.DataGridViewX1.Columns(4).Width = 80
        Me.lbNo.Text = Me.DataGridViewX1.Rows.Count
    End Sub
    Sub MostrarCodigoCerdasMadres()
        Me.cbxCodigosCerdas.Items.Clear()
        Try
            sql = New SqlCommand("select Código_Cerda from REG_MADRES", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                Else
                    Me.cbxCodigosCerdas.Items.Add(leer(0))
                End If

            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub MostrarCodigoCerdasAbuelas()
        Me.cbxCodigosCerdas.Items.Clear()
        Try
            sql = New SqlCommand("select Código_Abuela from REG_ABUELAS", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                Else
                    Me.cbxCodigosCerdas.Items.Add(leer(0))
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub rbtMadres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMadres.CheckedChanged
        If Me.rbtMadres.Checked = True Then
            Me.MostrarCodigoCerdasMadres()
        End If
    End Sub
    Private Sub rbtAbuelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAbuelas.CheckedChanged
        If Me.rbtAbuelas.Checked = True Then
            Me.MostrarCodigoCerdasAbuelas()
        End If
    End Sub

    Private Sub cbxCodigosCerdas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCodigosCerdas.SelectedIndexChanged
        Me.RecuperarInfoPartosPendientes_x_Codigo()
    End Sub

    Private Sub DataGridViewX1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentDoubleClick
        Dim frmPart As New frmPartos()
        With frmPart
            .Habilitar()
            .txtCodigoCerda.Text = Me.DataGridViewX1.CurrentRow.Cells("Código Cerda").Value
            FechaEstimada = Me.DataGridViewX1.CurrentRow.Cells("Fecha estimada de Parto").Value
            IdEnseminacion_x = Me.DataGridViewX1.CurrentRow.Cells("IdEnseminación").Value
            .MdiParent = Me.MdiParent
            .Show()
        End With
        Me.Close()
    End Sub
    Private Sub DataGridViewX1_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DataGridViewX1.RowPrePaint
        If Me.DataGridViewX1.Rows(e.RowIndex).Cells("Fecha estimada de Parto").Value <> FechaSistema Then
            Me.DataGridViewX1.Rows(e.RowIndex).Cells("Fecha estimada de Parto").Style.ForeColor = Color.Red
        Else
            Me.DataGridViewX1.Rows(e.RowIndex).Cells("Fecha estimada de Parto").Style.ForeColor = Color.Green
        End If
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.RecuperarInfoPartosPendientes()
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        Dim frmPart As New frmPartos()
        With frmPart
            .Habilitar()
            .txtCodigoCerda.Text = Me.DataGridViewX1.CurrentRow.Cells("Código Cerda").Value
            FechaEstimada = Me.DataGridViewX1.CurrentRow.Cells("Fecha estimada de Parto").Value
            IdEnseminacion_x = Me.DataGridViewX1.CurrentRow.Cells("IdEnseminación").Value
            .MdiParent = Me.MdiParent
            .Show()
        End With
        Me.Close()
    End Sub
    Private Sub lbNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbNo.TextChanged
        If Me.lbNo.Text = "0" Then
            Me.btnSeleccionar.Enabled = False
        Else
            Me.btnSeleccionar.Enabled = True
        End If
    End Sub
End Class