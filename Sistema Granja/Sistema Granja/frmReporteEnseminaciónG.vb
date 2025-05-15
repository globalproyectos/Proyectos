Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports System.Data
Imports System.Data.SqlClient
Public Class frmReporteEnseminaciónG
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Valida As Boolean
 Private Sub TextBoxX1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesde.GotFocus
        If Not Me.txtDesde.Text <> "dd/mm/aa" Then
            Me.txtDesde.Clear()
        End If
    End Sub
    Private Sub TextBoxX1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesde.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.txtDesde.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtDesde.Text = Me.txtDesde.Text & "/"
            Me.txtDesde.SelectionStart = 4
        ElseIf Me.txtDesde.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtDesde.Text = Me.txtDesde.Text & "/"
            Me.txtDesde.SelectionStart = 6
        End If
    End Sub
    Private Sub txtHasta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHasta.GotFocus
        If Not Me.txtHasta.Text <> "dd/mm/aa" Then
            Me.txtHasta.Clear()
        End If
    End Sub
    Private Sub txtHasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHasta.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.txtHasta.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtHasta.Text = Me.txtHasta.Text & "/"
            Me.txtHasta.SelectionStart = 4
        ElseIf Me.txtHasta.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtHasta.Text = Me.txtHasta.Text & "/"
            Me.txtHasta.SelectionStart = 6
        End If
    End Sub

    Private Sub txtHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHasta.LostFocus
        If Me.txtHasta.Text = "" Then
            Me.txtHasta.Text = "dd/mm/aa"
        End If
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        If Not IsDate(Me.txtDesde.Text) Then
            MessageBoxEx.Show("La fecha es incorrecta porfavor asegurese de haberla ingresado correctamente", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtDesde.SelectAll()
            Me.txtDesde.Focus()
        ElseIf Not IsDate(Me.txtHasta.Text) Then
            MessageBoxEx.Show("La fecha es incorrecta porfavor asegurese de haberla ingresado correctamente", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtHasta.SelectAll()
            Me.txtHasta.Focus()
        Else
            Me.MostrarEnseminaciones()
            Me.MostrarPartos()
        End If
    End Sub
    Sub MostrarEnseminaciones()
        Try

       
            sql = New SqlCommand("select * from Reg_Enseminaciones_x_cerda where Fecha_Enseminacion BETWEEN '" & Me.txtDesde.Text & "' AND '" & Me.txtHasta.Text & "'", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Código Cerda"))
                .Add(New DataColumn("Fecha Enseminación"))
                .Add(New DataColumn("Estado"))
                .Add(New DataColumn("Fecha Estimada de Parto"))
            End With
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                dr = dt.NewRow
                dr(0) = leer(1)
                dr(1) = leer(2)
                dr(2) = leer(3)
                dr(3) = leer(4)
                dt.Rows.Add(dr)
            End While
            con.Close()
            dv = New DataView(dt)
            Me.DataGridView1.DataSource = dv
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        EstiloDatagrid(Me.DataGridView1, 10, "Arial", FontStyle.Regular)
        Me.DataGridView1.Columns(0).Width = 85
        Me.DataGridView1.Columns(1).Width = 111
        Me.DataGridView1.Columns(2).Width = 95
        Me.DataGridView1.Columns(3).Width = 111
    End Sub
    Sub MostrarPartos()
        Try
            sql = New SqlCommand("select * from REG_PARTOS_X_CERDA WHERE Fecha_Monta BETWEEN '" & Me.txtDesde.Text & "' AND '" & Me.txtHasta.Text & "'", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Código Cerda"))
                .Add(New DataColumn("Partos"))
                .Add(New DataColumn("Fecha Enseminación"))
                .Add(New DataColumn("Fecha Estimada"))
                .Add(New DataColumn("Fecha Real del Parto"))
                .Add(New DataColumn("Cerdos Vivos"))
                .Add(New DataColumn("Cerdos Muertos"))
                .Add(New DataColumn("Momias"))
            End With
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    MessageBoxEx.Show("No ha sido registrado ningún parto", "Partos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer("Parto_No")
                    dr(2) = leer("Fecha_Monta")
                    dr(3) = leer("Fecha_Estimada_DP")
                    dr(4) = leer("Fecha_Real")
                    dr(5) = leer("No_Vivos")
                    dr(6) = leer("Momias")
                    dr(7) = leer("Muertos")
                    dt.Rows.Add(dr)

                End If
            End While
            con.Close()
            dv = New DataView(dt)
            Me.DataGridView2.DataSource = dv
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        EstiloDatagrid(Me.DataGridView2, 9, "Arial", FontStyle.Regular)
        Me.DataGridView2.Columns(0).Width = 75
        Me.DataGridView2.Columns(1).Width = 90
        Me.DataGridView2.Columns(2).Width = 90
        Me.DataGridView2.Columns(3).Width = 90
        Me.DataGridView2.Columns(4).Width = 80
        Me.DataGridView2.Columns(5).Width = 80
        Me.DataGridView2.Columns(6).Width = 80

    End Sub
    Private Sub txtDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesde.LostFocus
        If Me.txtDesde.Text = "" Then
            Me.txtDesde.Text = "dd/mm/aa"
        End If
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If IsDate(Me.txtDesde.Text) And IsDate(Me.txtHasta.Text) Then
            Me.ComboBoxEx1.Enabled = False
            Me.ComboBoxEx1.Text = ""
            Me.MostrarEnseminaciones()
            Me.MostrarPartos()
        Else
            Me.txtDesde.Focus()
        End If
     End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.ComboBoxEx1.Enabled = True
        Me.ComboBoxEx1.Focus()
    End Sub
    Sub CodigoCerdas()
        Try

            sql = New SqlCommand("select Código_Cerda from REG_MADRES", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    MessageBoxEx.Show("No hay registrado ningún Código de Cerdas en la Tabla Reg_Madres", "Cód. Cerdas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.ComboBoxEx1.Items.Add(leer(0))
                End If

            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub frmReporteEnseminaciónG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CodigoCerdas()
        Me.RadioButton2.Checked = True
    End Sub
    Sub Mostrar_x_Codigo()
        Try

       
            sql = New SqlCommand("select * from Reg_Enseminaciones_x_cerda where Código_Cerda='" & Me.ComboBoxEx1.Text & "' AND Fecha_Enseminacion BETWEEN '" & Me.txtDesde.Text & "' AND '" & Me.txtHasta.Text & "'", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Código Cerda"))
                .Add(New DataColumn("Fecha Enseminación"))
                .Add(New DataColumn("Estado"))
                .Add(New DataColumn("Fecha Estimada de Parto"))
            End With
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                dr = dt.NewRow
                dr(0) = leer(1)
                dr(1) = leer(2)
                dr(2) = leer(3)
                dr(3) = leer(4)
                dt.Rows.Add(dr)
            End While
            con.Close()
            dv = New DataView(dt)
            Me.DataGridView1.DataSource = dv
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        EstiloDatagrid(Me.DataGridView1, 9, "Arial", FontStyle.Regular)
        Me.DataGridView1.Columns(0).Width = 85
        Me.DataGridView1.Columns(1).Width = 111
        Me.DataGridView1.Columns(2).Width = 95
        Me.DataGridView1.Columns(3).Width = 111

        '**************************************************************************************
        Try

            sql = New SqlCommand("select * from REG_PARTOS_X_CERDA WHERE Código_Cerda='" & Me.ComboBoxEx1.Text & "' AND Fecha_Monta BETWEEN '" & Me.txtDesde.Text & "' AND '" & Me.txtHasta.Text & "'", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Código Cerda"))
                .Add(New DataColumn("Partos"))
                .Add(New DataColumn("Fecha Enseminación"))
                .Add(New DataColumn("Fecha Estimada"))
                .Add(New DataColumn("Fecha Real del Parto"))
                .Add(New DataColumn("Cerdos Vivos"))
                .Add(New DataColumn("Cerdos Muertos"))
                .Add(New DataColumn("Momias"))
            End With
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    MessageBoxEx.Show("No ha sido registrado ningún parto", "Partos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer("Parto_No")
                    dr(2) = leer("Fecha_Monta")
                    dr(3) = leer("Fecha_Estimada_DP")
                    dr(4) = leer("Fecha_Real")
                    dr(5) = leer("No_Vivos")
                    dr(6) = leer("Momias")
                    dr(7) = leer("Muertos")
                    dt.Rows.Add(dr)
                End If
            End While
            con.Close()
            dv = New DataView(dt)
            Me.DataGridView2.DataSource = dv
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        EstiloDatagrid(Me.DataGridView2, 9, "Arial", FontStyle.Regular)
        Me.DataGridView2.Columns(0).Width = 75
        Me.DataGridView2.Columns(1).Width = 90
        Me.DataGridView2.Columns(2).Width = 90
        Me.DataGridView2.Columns(3).Width = 90
        Me.DataGridView2.Columns(4).Width = 80
        Me.DataGridView2.Columns(5).Width = 80
        Me.DataGridView2.Columns(6).Width = 80
    End Sub
    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        If Not IsDate(Me.txtDesde.Text) Or Not IsDate(Me.txtHasta.Text) Or Me.txtDesde.Text = "dd/mm/aa" Or Me.txtHasta.Text = "dd/mm/aa" Then
            MessageBoxEx.Show("La fecha que ha ingresado es erronea, o esta incompleta porfavor verifique que la ingreso correctamente", "Error Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtDesde.SelectAll()
            Me.txtHasta.SelectAll()
        Else
            Me.Mostrar_x_Codigo()

        End If

    End Sub


    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        ExportarDatosExcel(Me.DataGridView1, "..::Reporte de Enseminaciones G::..", "Fecha Desde: " & Me.txtDesde.Text & " Hasta: " & Me.txtHasta.Text, "", "E")
        ExportarDatosExcel(Me.DataGridView2, "..::Reporte de Partos G::..", "Fecha Desde: " & Me.txtDesde.Text & " Hasta: " & Me.txtHasta.Text, "", "I")
    End Sub
End Class