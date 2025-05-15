Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmEnseminaciones
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim MaximoPartos As Integer = 15
    Dim ProdEn As String = ", el error se produjo en el BLOQUE-FRmENS_"
    Dim Estado As String
    Dim IdEnseminacion As Integer
    Dim YaseRegistro_MismaFecha As Boolean
    Dim NoCerdosGestando, NoCerdos_Lote As Integer
    Dim Estaba_en_Lote, Esta_en_Lote_x As Integer
    Public LoteGestacion As Integer
    Public Proceso As Boolean
    Dim EstaPendiente As Boolean
    Private Sub frmEnseminaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MonstrarEnseminaciones()
        Me.chbxIngresar.CheckState = CheckState.Checked
        Me.MostrarLotesMonta()
    End Sub
    Sub MostrarLotesMonta()
        Try
            Me.cbxLoteMontas.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No ,e.Descripcion " _
                                         & " FROM LOTES l" _
                                         & " JOIN Etapas_Cerdas_Lote e ON l.IdEtapa_Cerdas = e.IdEtapa_Cerdas" _
                                         & " where l.IdEtapa_Cerdas ='M' and l.Estado<>'T'"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                'Me.cbxLotePara.Text = leer(0).ToString
                Me.cbxLoteMontas.Items.Add(leer(0)).ToString()
                'Me.txtDescLotePara.Text = leer(1).ToString
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrar Lotes Montas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub MostrarCodigoCerda()
        If Me.rbtMadres.Checked = True Then
            Try
                ' BLOQUE-BLOQUE-FRmENS_1
                Me.cbxCodigoCerda.Items.Clear()
                sql = New SqlCommand("select * from REG_MADRES where Lote_No='" & Me.cbxLoteMontas.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.cbxCodigoCerda.Items.Add(leer(0))
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message & ProdEn & 1, "Error al Mostrar Cód. Cerda", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        ElseIf Me.rbtAbuelas.Checked = True Then
            Try
                ' BLOQUE-BLOQUE-FRmENS_1
                Me.cbxCodigoCerda.Items.Clear()
                sql = New SqlCommand("select * from REG_ABUELAS where Lote_No='" & Me.cbxLoteMontas.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.cbxCodigoCerda.Items.Add(leer(0))
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message & ProdEn & 1, "Error al Mostrar Cód. Cerda", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
        
    End Sub
    Public Sub MonstrarEnseminaciones()
        Dim CadenaConsulta As String = "SELECT a.Id_Enseminacion, a.Código_Cerda, a.Fecha_Enseminacion, Estado, Fecha_Parto_Estimada" _
                                    & " FROM Reg_Enseminaciones_x_cerda AS a" _
                                    & " JOIN Estado_de_Partos AS b ON a.Id_Enseminacion= b.Id_Enseminacion" _
                                    & " WHERE (a.Estado='C' OR a.Estado='P') AND b.Estado_Parto='FALSE'"
        sql = New SqlCommand(CadenaConsulta, con)
        dt = New DataTable
        With dt.Columns
            .Add(New DataColumn("IdEnseminación"))
            .Add(New DataColumn("Código Cerda"))
            .Add(New DataColumn("Fecha Enseminación"))
            .Add(New DataColumn("Estado"))
            .Add(New DataColumn("Parto Estimado"))
        End With
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            dr = dt.NewRow
            dr(0) = leer(0)
            dr(1) = leer(1)
            dr(2) = leer(2)
            dr(3) = leer(3)
            dr(4) = leer(4)
            dt.Rows.Add(dr)
        End While
        dv = New DataView(dt)
        Me.DgvEnseminaciones.DataSource = dv
        con.Close()
        Me.lbItems.Text = Me.DgvEnseminaciones.Rows.Count
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub txtFecha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFecha.GotFocus
        If Not Me.txtFecha.Text <> "dd/mm/aa" Then
            Me.txtFecha.Clear()
        End If
    End Sub

    Private Sub txtFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.txtFecha.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFecha.Text = Me.txtFecha.Text & "/"
            Me.txtFecha.SelectionStart = 4
        ElseIf Me.txtFecha.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.txtFecha.Text = Me.txtFecha.Text & "/"
            Me.txtFecha.SelectionStart = 6
        End If
    End Sub
    Private Sub txtFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFecha.LostFocus
        If Me.txtFecha.Text = "" Then
            Me.txtFecha.Text = "dd/mm/aa"
        End If

    End Sub

    Private Sub txtFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFecha.TextChanged
        If Me.txtFecha.Text <> "" And Me.txtFecha.Text <> "dd/mm/aa" And Me.txtFecha.TextLength = 8 And Me.cbxCodigoCerda.Text <> "" And (Me.chboxConfirmado.CheckState <> CheckState.Unchecked Or Me.chkboxPendiente.CheckState <> CheckState.Unchecked Or Me.chbxFalso.CheckState <> CheckState.Unchecked) And Me.txtCosto.Text <> "" Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
        If IsDate(Me.txtFecha.Text) Then
            Dim FechaEnseminacion As Date = Me.txtFecha.Text
            Me.txtProximoParto.Text = FechaEnseminacion.AddDays(115)
            Dim fechaAprox As Date = Me.txtProximoParto.Text
        Else
            Me.txtProximoParto.Text = ""
        End If
    End Sub
    Private Sub cbxCodigoCerda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCodigoCerda.SelectedIndexChanged
        Try
            ' BLOQUE-FRmENS_2

            sql = New SqlCommand("select SUM(Parto_No) from REG_PARTOS_X_CERDA where Código_Cerda='" & Me.cbxCodigoCerda.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) Then
                    Me.TextBoxX2.Text = 0
                Else
                    Me.TextBoxX2.Text = leer(0)
                    Dim numPartos As Integer = leer(0)
                    If numPartos > 0 And numPartos < 3 Then
                        Me.RatingStar1.Rating = 1
                    ElseIf numPartos >= 3 And numPartos < 6 Then
                        Me.RatingStar1.Rating = 2
                    ElseIf numPartos >= 6 And numPartos < 9 Then
                        Me.RatingStar1.Rating = 3
                    ElseIf numPartos >= 9 And numPartos < 12 Then
                        Me.RatingStar1.Rating = 4
                    ElseIf numPartos >= 12 And numPartos <= 15 Then
                        Me.RatingStar1.Rating = 5
                    ElseIf numPartos = 0 Then
                        Me.RatingStar1.Rating = 0
                    End If
                End If
            End While
            con.Close()
            If Me.txtFecha.Text <> "" And Me.txtFecha.Text <> "dd/mm/aa" And Me.txtFecha.TextLength = 8 And Me.cbxCodigoCerda.Text <> "" And (Me.chboxConfirmado.CheckState <> CheckState.Unchecked Or Me.chkboxPendiente.CheckState <> CheckState.Unchecked Or Me.chbxFalso.CheckState <> CheckState.Unchecked) And Me.txtCosto.Text <> "" Then
                Me.btnGuardar.Enabled = True
            Else
                Me.btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & ProdEn & 2, "Error recuperar Num. Partos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckBoxX3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxFalso.CheckedChanged
        If Me.chbxFalso.CheckState = CheckState.Checked Then
            Me.chboxConfirmado.CheckState = CheckState.Unchecked
            Me.chkboxPendiente.CheckState = CheckState.Unchecked
        ElseIf Me.chboxConfirmado.CheckState = CheckState.Checked Then
            Me.chkboxPendiente.CheckState = CheckState.Unchecked
            Me.chbxFalso.CheckState = CheckState.Unchecked
        ElseIf Me.chkboxPendiente.CheckState = CheckState.Checked Then
            Me.chboxConfirmado.CheckState = CheckState.Unchecked
            Me.chbxFalso.CheckState = CheckState.Unchecked
        End If
        If Me.txtFecha.Text <> "" And Me.txtFecha.Text <> "dd/mm/aa" And Me.txtFecha.TextLength = 8 And Me.cbxCodigoCerda.Text <> "" And (Me.chboxConfirmado.CheckState <> CheckState.Unchecked Or Me.chkboxPendiente.CheckState <> CheckState.Unchecked Or Me.chbxFalso.CheckState <> CheckState.Unchecked) And Me.txtCosto.Text <> "" Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If

    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chboxConfirmado.CheckedChanged
        If Me.chboxConfirmado.CheckState = CheckState.Checked Then
            Me.chkboxPendiente.CheckState = CheckState.Unchecked
            Me.chbxFalso.CheckState = CheckState.Unchecked
        ElseIf Me.chbxFalso.CheckState = CheckState.Checked Then
            Me.chboxConfirmado.CheckState = CheckState.Unchecked
            Me.chkboxPendiente.CheckState = CheckState.Unchecked
        ElseIf Me.chkboxPendiente.CheckState = CheckState.Checked Then
            Me.chboxConfirmado.CheckState = CheckState.Unchecked
            Me.chbxFalso.CheckState = CheckState.Unchecked
        End If
        If Me.txtFecha.Text <> "" And Me.txtFecha.Text <> "dd/mm/aa" And Me.txtFecha.TextLength = 8 And Me.cbxCodigoCerda.Text <> "" And (Me.chboxConfirmado.CheckState <> CheckState.Unchecked Or Me.chkboxPendiente.CheckState <> CheckState.Unchecked Or Me.chbxFalso.CheckState <> CheckState.Unchecked) And Me.txtCosto.Text <> "" Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxX2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkboxPendiente.CheckedChanged
        If Me.chkboxPendiente.CheckState = CheckState.Checked Then
            Me.chboxConfirmado.CheckState = CheckState.Unchecked
            Me.chbxFalso.CheckState = CheckState.Unchecked
        ElseIf Me.chboxConfirmado.CheckState = CheckState.Checked Then
            Me.chkboxPendiente.CheckState = CheckState.Unchecked
            Me.chbxFalso.CheckState = CheckState.Unchecked
        ElseIf Me.chbxFalso.CheckState = CheckState.Checked Then
            Me.chboxConfirmado.CheckState = CheckState.Unchecked
            Me.chkboxPendiente.CheckState = CheckState.Unchecked
        End If
        If Me.txtFecha.Text <> "" And Me.txtFecha.Text <> "dd/mm/aa" And Me.txtFecha.TextLength = 8 And Me.cbxCodigoCerda.Text <> "" And (Me.chboxConfirmado.CheckState <> CheckState.Unchecked Or Me.chkboxPendiente.CheckState <> CheckState.Unchecked Or Me.chbxFalso.CheckState <> CheckState.Unchecked) And Me.txtCosto.Text <> "" Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub
    Sub VerifEstado()
        If Me.chbxFalso.CheckState = CheckState.Checked Then
            Estado = "N"
        ElseIf Me.chboxConfirmado.CheckState = CheckState.Checked Then
            Estado = "C"
        ElseIf Me.chkboxPendiente.CheckState = CheckState.Checked Then
            Estado = "P"
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.rbtMadres.Checked = True Then
            VerifEstado()
            If Estado = "C" Then
                With My.Forms.dlgDe_Montas_a_Gestando
                    .lbTipoCerda.Text = "MADRES"
                    .lbCodigoCerda.Text = Me.txtCodigoCerda.Text
                    .ShowDialog()
                End With
                If Proceso = True Then
                    sql = New SqlCommand("select * from Reg_Enseminaciones_x_cerda", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        If leer(1) = Me.cbxCodigoCerda.Text And leer(2) = Me.txtFecha.Text And leer(3) = "C" Then
                            Me.YaseRegistro_MismaFecha = True
                        End If
                    End While
                    con.Close()
                    sql = New SqlCommand("Select Lote_No from REG_MADRES where Código_Cerda='" & Me.cbxCodigoCerda.Text & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        Me.Esta_en_Lote_x = leer(0)
                    End While
                    con.Close()

                    sql = New SqlCommand("select * from Reg_Enseminaciones_x_cerda where Código_Cerda='" & Me.txtCodigoCerda.Text & "' and Estado='P'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        EstaPendiente = True
                    End While
                    con.Close()
                    If Me.YaseRegistro_MismaFecha = True Then
                        MessageBoxEx.Show("Ya hay un registro de Ensenimación para la Cerda con código: " & LTrim(Me.cbxCodigoCerda.Text) & " en el registro de enseminaciones, esta error se ha producido porque no puede haber dos enseminaciones con estado confirmado y la misma fecha de enseminación", "Enseminación existente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf EstaPendiente = True Then
                        MessageBoxEx.Show("Ya hay un registro de Ensenimación para la Cerda con código: " & LTrim(Me.cbxCodigoCerda.Text) & " en el registro de enseminaciones, esta error se ha producido porque no puede haber dos enseminaciones con estado confirmado o mientras esta pendiente de confirmación y la misma fecha de enseminación", "Enseminación existente", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else
                        sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='" & LoteGestacion & "' WHERE Código_Cerda='" & Me.txtCodigoCerda.Text & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        sql = New SqlCommand("select MAX(Id_Enseminacion) FROM Reg_Enseminaciones_x_cerda", con)
                        con.Open()
                        leer = sql.ExecuteReader
                        While leer.Read
                            If leer.IsDBNull(0) = True Then
                                Me.IdEnseminacion = 0
                            Else
                                Me.IdEnseminacion = leer(0) + 1
                            End If
                        End While
                        con.Close()

                        sql = New SqlCommand("insert into Reg_Enseminaciones_x_cerda values('" & Me.IdEnseminacion & "','" & Me.cbxCodigoCerda.Text & "','" & Me.txtFecha.Text & "','" & Estado & "','" & Me.txtProximoParto.Text & "','" & Me.txtCosto.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                        sql = New SqlCommand("insert into Estado_de_Partos values('" & Me.IdEnseminacion & "','" & 0 & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                        'Dim res As MsgBoxResult
                        'res = MessageBoxEx.Show("Se recomienda que imprima el reporte de enseminación, para tenerlo como documento de respaldo, desea imprimir el reporte", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        'If res = MsgBoxResult.Yes Then
                        '    Me.VerifEstado()
                        '    Dim dts1 As New DataSet()
                        '    dt = New DataTable("Prueba")
                        '    With dt.Columns
                        '        .Add(New DataColumn("Código_Cerda"))
                        '        .Add(New DataColumn("Fecha_Enseminacion"))
                        '        .Add(New DataColumn("Estado"))
                        '        .Add(New DataColumn("Fecha_Parto_Estimada"))
                        '    End With
                        '    dr = dt.NewRow
                        '    dr(0) = Me.cbxCodigoCerda.Text
                        '    dr(1) = Me.txtFecha.Text
                        '    dr(2) = Estado
                        '    dr(3) = Me.txtProximoParto.Text
                        '    dt.Rows.Add(dr)
                        '    dts1.Tables.Add(dt)
                        'Dim Rpt As New Cr_Reporte_de_Enseminacion_x_cerda()
                        'With Rpt
                        '    Rpt.SetDataSource(dts1.Tables("Prueba"))
                        '    .PrintToPrinter(1, False, 1, 1)
                        'End With
                        'End If
                        Me.cbxCodigoCerda.Text = ""
                        Me.txtFecha.Text = ""
                        Me.txtCosto.Text = ""
                        Me.chboxConfirmado.CheckState = CheckState.Unchecked
                        Me.chbxFalso.CheckState = CheckState.Unchecked
                        Me.chkboxPendiente.CheckState = CheckState.Unchecked
                        Me.MostrarCodigoCerda()

                    End If
                End If
                ElseIf Estado = "P" Then

                End If
            End If




        'If rbtMadres.Checked = True Then
        '    Try
        '        Me.VerifEstado()
        '        Me.YaseRegistro_MismaFecha = False

        '        If Me.Estado = "C" Then
        '            If Me.rbtMadres.Checked = True Then
        '                EstaPendiente = False
        '               
        '               
        '            End If
        '        ElseIf Estado = "P" Then
        '            EstaPendiente = False
        '            sql = New SqlCommand("select MAX(Id_Enseminacion) FROM Reg_Enseminaciones_x_cerda", con)
        '            con.Open()
        '            leer = sql.ExecuteReader
        '            While leer.Read
        '                If leer.IsDBNull(0) = True Then
        '                    Me.IdEnseminacion = 0
        '                Else
        '                    Me.IdEnseminacion = leer(0) + 1
        '                End If
        '            End While
        '            con.Close()

        '            sql = New SqlCommand("select * from Reg_Enseminaciones_x_cerda", con)
        '            con.Open()
        '            leer = sql.ExecuteReader
        '            While leer.Read
        '                If leer(1) = Me.cbxCodigoCerda.Text And leer(2) = Me.txtFecha.Text And leer(3) = "C" Then
        '                    Me.YaseRegistro_MismaFecha = True
        '                End If
        '            End While
        '            con.Close()
        '            sql = New SqlCommand("Select Lote_No from REG_MADRES where Código_Cerda='" & Me.cbxCodigoCerda.Text & "'", con)
        '            con.Open()
        '            leer = sql.ExecuteReader
        '            While leer.Read
        '                Me.Esta_en_Lote_x = leer(0)
        '            End While
        '            con.Close()

        '            sql = New SqlCommand("select * from Reg_Enseminaciones_x_cerda where Código_Cerda='" & Me.txtCodigoCerda.Text & "' and Estado='P'", con)
        '            con.Open()
        '            leer = sql.ExecuteReader
        '            While leer.Read
        '                EstaPendiente = True
        '            End While
        '            con.Close()
        '            If Me.YaseRegistro_MismaFecha = True Then
        '                MessageBoxEx.Show("Ya hay un registro de Ensenimación para la Cerda con código: " & LTrim(Me.cbxCodigoCerda.Text) & " en el registro de enseminaciones, esta error se ha producido porque no puede haber dos enseminaciones con estado confirmado y la misma fecha de enseminación", "Enseminación existente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            ElseIf EstaPendiente = True Then
        '                MessageBoxEx.Show("Ya hay un registro de Ensenimación para la Cerda con código: " & LTrim(Me.cbxCodigoCerda.Text) & " en el registro de enseminaciones, esta error se ha producido porque no puede haber dos enseminaciones con estado confirmado o mientras esta pendiente de confirmación y la misma fecha de enseminación", "Enseminación existente", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '            Else
        '                sql = New SqlCommand("insert into Reg_Enseminaciones_x_cerda values('" & Me.IdEnseminacion & "','" & Me.cbxCodigoCerda.Text & "','" & Me.txtFecha.Text & "','" & Estado & "','" & Me.txtProximoParto.Text & "','" & Me.txtCosto.Text & "')", con)
        '                con.Open()
        '                sql.ExecuteNonQuery()
        '                con.Close()
        '                sql = New SqlCommand("insert into Estado_de_Partos values('" & Me.IdEnseminacion & "','" & 0 & "')", con)
        '                con.Open()
        '                sql.ExecuteNonQuery()
        '                con.Close()
        '                'Dim res As MsgBoxResult
        '                'res = MessageBoxEx.Show("Se recomienda que imprima el reporte de enseminación, para tenerlo como documento de respaldo, desea imprimir el reporte", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        '                'If res = MsgBoxResult.Yes Then
        '                '    Me.VerifEstado()
        '                '    Dim dts1 As New DataSet()
        '                '    dt = New DataTable("Prueba")
        '                '    With dt.Columns
        '                '        .Add(New DataColumn("Código_Cerda"))
        '                '        .Add(New DataColumn("Fecha_Enseminacion"))
        '                '        .Add(New DataColumn("Estado"))
        '                '        .Add(New DataColumn("Fecha_Parto_Estimada"))
        '                '    End With
        '                '    dr = dt.NewRow
        '                '    dr(0) = Me.cbxCodigoCerda.Text
        '                '    dr(1) = Me.txtFecha.Text
        '                '    dr(2) = Estado
        '                '    dr(3) = Me.txtProximoParto.Text
        '                '    dt.Rows.Add(dr)
        '                '    dts1.Tables.Add(dt)
        '                'Dim Rpt As New Cr_Reporte_de_Enseminacion_x_cerda()
        '                'With Rpt
        '                '    Rpt.SetDataSource(dts1.Tables("Prueba"))
        '                '    .PrintToPrinter(1, False, 1, 1)
        '                'End With
        '                'End If
        '                Me.cbxCodigoCerda.Text = ""
        '                Me.txtFecha.Text = ""
        '                Me.txtCosto.Text = ""
        '                Me.chboxConfirmado.CheckState = CheckState.Unchecked
        '                Me.chbxFalso.CheckState = CheckState.Unchecked
        '                Me.chkboxPendiente.CheckState = CheckState.Unchecked
        '            End If
        '        End If

        '    Catch ex As Exception
        '        MessageBoxEx.Show(CadenaError & ex.Message & ProdEn & 3, "Error al guardar R.Enseminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        con.Close()
        '    End Try
        'ElseIf Me.rbtAbuelas.Checked = True Then
        '    Try
        '        Me.VerifEstado()
        '        Me.YaseRegistro_MismaFecha = False
        '        If Me.Estado = "C" Then
        '            If Me.rbtMadres.Checked = True Then
        '                With My.Forms.dlgDe_Montas_a_Gestando
        '                    .lbTipoCerda.Text = "ABUELAS"
        '                    .lbCodigoCerda.Text = Me.txtCodigoCerda.Text
        '                    .ShowDialog()
        '                End With
        '                If Proceso = True Then
        '                    sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='" & LoteGestacion & "' WHERE Código_Abuela='" & Me.txtCodigoCerda.Text & "'", con)
        '                    con.Open()
        '                    sql.ExecuteNonQuery()
        '                    con.Close()
        '                    Me.cbxCodigoCerda.Text = ""
        '                    Me.txtFecha.Text = ""
        '                    Me.txtCosto.Text = ""
        '                    Me.chboxConfirmado.CheckState = CheckState.Unchecked
        '                    Me.chbxFalso.CheckState = CheckState.Unchecked
        '                    Me.chkboxPendiente.CheckState = CheckState.Unchecked

        '                End If
        '            End If
        '        ElseIf Estado = "P" Then
        '            sql = New SqlCommand("select MAX(Id_Enseminacion) FROM Reg_Enseminaciones_x_cerda", con)
        '            con.Open()
        '            leer = sql.ExecuteReader
        '            While leer.Read
        '                If leer.IsDBNull(0) = True Then
        '                    Me.IdEnseminacion = 0
        '                Else
        '                    Me.IdEnseminacion = leer(0) + 1
        '                End If
        '            End While
        '            con.Close()

        '            sql = New SqlCommand("select * from Reg_Enseminaciones_x_cerda", con)
        '            con.Open()
        '            leer = sql.ExecuteReader
        '            While leer.Read
        '                If leer(1) = Me.cbxCodigoCerda.Text And leer(2) = Me.txtFecha.Text And leer(3) = "C" Then
        '                    Me.YaseRegistro_MismaFecha = True
        '                End If
        '            End While
        '            con.Close()
        '            sql = New SqlCommand("Select Lote_No from REG_ABUELAS where Código_Abuelas='" & Me.cbxCodigoCerda.Text & "'", con)
        '            con.Open()
        '            leer = sql.ExecuteReader
        '            While leer.Read
        '                Me.Esta_en_Lote_x = leer(0)
        '            End While
        '            con.Close()

        '            If Me.YaseRegistro_MismaFecha = True Then
        '                MessageBoxEx.Show("Ya hay un registro de Ensenimación para la Cerda con código: " & LTrim(Me.cbxCodigoCerda.Text) & " en el registro de enseminaciones, esta error se ha producido porque no puede haber dos enseminaciones con estado confirmado y la misma fecha de enseminación", "Enseminación existente", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '            Else
        '                sql = New SqlCommand("insert into Reg_Enseminaciones_x_cerda values('" & Me.IdEnseminacion & "','" & Me.cbxCodigoCerda.Text & "','" & Me.txtFecha.Text & "','" & Estado & "','" & Me.txtProximoParto.Text & "','" & Me.txtCosto.Text & "')", con)
        '                con.Open()
        '                sql.ExecuteNonQuery()
        '                con.Close()
        '                sql = New SqlCommand("insert into Estado_de_Partos values('" & Me.IdEnseminacion & "','" & 0 & "')", con)
        '                con.Open()
        '                sql.ExecuteNonQuery()
        '                con.Close()
        '                'Dim res As MsgBoxResult
        '                'res = MessageBoxEx.Show("Se recomienda que imprima el reporte de enseminación, para tenerlo como documento de respaldo, desea imprimir el reporte", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        '                'If res = MsgBoxResult.Yes Then
        '                '    Me.VerifEstado()
        '                '    Dim dts1 As New DataSet()
        '                '    dt = New DataTable("Prueba")
        '                '    With dt.Columns
        '                '        .Add(New DataColumn("Código_Cerda"))
        '                '        .Add(New DataColumn("Fecha_Enseminacion"))
        '                '        .Add(New DataColumn("Estado"))
        '                '        .Add(New DataColumn("Fecha_Parto_Estimada"))
        '                '    End With
        '                '    dr = dt.NewRow
        '                '    dr(0) = Me.cbxCodigoCerda.Text
        '                '    dr(1) = Me.txtFecha.Text
        '                '    dr(2) = Estado
        '                '    dr(3) = Me.txtProximoParto.Text
        '                '    dt.Rows.Add(dr)
        '                '    dts1.Tables.Add(dt)
        '                'Dim Rpt As New Cr_Reporte_de_Enseminacion_x_cerda()
        '                'With Rpt
        '                '    Rpt.SetDataSource(dts1.Tables("Prueba"))
        '                '    .PrintToPrinter(1, False, 1, 1)
        '                'End With
        '                'End If
        '                Me.cbxCodigoCerda.Text = ""
        '                Me.txtFecha.Text = ""
        '                Me.txtCosto.Text = ""
        '                Me.chboxConfirmado.CheckState = CheckState.Unchecked
        '                Me.chbxFalso.CheckState = CheckState.Unchecked
        '                Me.chkboxPendiente.CheckState = CheckState.Unchecked
        '            End If
        '        End If

        '    Catch ex As Exception
        '        MessageBoxEx.Show(CadenaError & ex.Message & ProdEn & 3, "Error al guardar R.Enseminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        con.Close()
        '    End Try
        'End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.VerifEstado()
            Dim dts1 As New DataSet()
            dt = New DataTable("Prueba")
            With dt.Columns
                .Add(New DataColumn("Código_Cerda"))
                .Add(New DataColumn("Fecha_Enseminacion"))
                .Add(New DataColumn("Estado"))
                .Add(New DataColumn("Fecha_Parto_Estimada"))
            End With
            dr = dt.NewRow
            dr(0) = Me.cbxCodigoCerda.Text
            dr(1) = Me.txtFecha.Text
            dr(2) = Estado
            dr(3) = Me.txtProximoParto.Text
            dt.Rows.Add(dr)
            dts1.Tables.Add(dt)
            Dim Rpt As New Cr_Reporte_de_Enseminacion_x_cerda()
            With Rpt

                Rpt.SetDataSource(dts1.Tables("Prueba"))
                .PrintToPrinter(1, False, 1, 1)
            End With
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCosto.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

  
    Private Sub chbxIngresar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxIngresar.CheckedChanged
        If Me.chbxIngresar.CheckState = CheckState.Checked Then
            Me.chbxCambiarEstado.CheckState = CheckState.Unchecked
            Me.GrupBoxCambios.Visible = False
            Me.Size = New Size(449, 341)
            Me.cbxCodigoCerda.Focus()
            Me.panelEnseminaciones.Enabled = True
        ElseIf Me.chbxCambiarEstado.CheckState = CheckState.Checked Then
            Me.chbxIngresar.CheckState = CheckState.Unchecked

        End If
    End Sub

    Private Sub chbxCambiarEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxCambiarEstado.CheckedChanged
        If Me.chbxCambiarEstado.CheckState = CheckState.Checked Then
            Me.chbxIngresar.CheckState = CheckState.Unchecked
            Me.GrupBoxCambios.Visible = True
            Me.Size = New Size(883, 341)
            Me.MonstrarEnseminaciones()

            Me.txtCodigoCerda.Clear()
            Me.txtCodigoCerda.Focus()
            Me.panelEnseminaciones.Enabled = False
        ElseIf Me.chbxIngresar.CheckState = CheckState.Checked Then
            Me.chbxCambiarEstado.CheckState = CheckState.Unchecked
            
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Me.GrupBoxCambios.Visible = False
        Me.Size = New Size(449, 341)
        Me.chbxCambiarEstado.CheckState = CheckState.Unchecked
        Me.chbxIngresar.CheckState = CheckState.Checked
        Me.cbxCodigoCerda.Focus()
    End Sub
    Private Sub DgvEnseminaciones_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DgvEnseminaciones.RowPrePaint
        If Me.DgvEnseminaciones.Rows(e.RowIndex).Cells("Estado").Value = "C" Then
            Me.DgvEnseminaciones.Rows(e.RowIndex).Cells("Estado").Style.ForeColor = Color.Green
        ElseIf Me.DgvEnseminaciones.Rows(e.RowIndex).Cells("Estado").Value = "P" Then
            Me.DgvEnseminaciones.Rows(e.RowIndex).Cells("Estado").Style.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.DgvEnseminaciones.CurrentRow.Cells("Estado").Value = "C" Then
            Dim frmCambiar As New DfrmCambioEstadoEnseminacion()
            With frmCambiar
                .cbxEstado.Items.Add("Abortó")
                .txtCódigoCerda.Text = Me.DgvEnseminaciones.CurrentRow.Cells("Código Cerda").Value
                .CodigoCerda = Me.DgvEnseminaciones.CurrentRow.Cells("Código Cerda").Value
                .IdEnsemeninacion = Me.DgvEnseminaciones.CurrentRow.Cells("IdEnseminación").Value
                .ShowDialog()
            End With
        ElseIf Me.DgvEnseminaciones.CurrentRow.Cells("Estado").Value = "P" Then
            Dim frmCambiar As New DfrmCambioEstadoEnseminacion()
            With frmCambiar
                .cbxEstado.Items.Add("Confirmado")
                .cbxEstado.Items.Add("Nulo")
                .txtCódigoCerda.Text = Me.DgvEnseminaciones.CurrentRow.Cells("Código Cerda").Value
                .CodigoCerda = Me.DgvEnseminaciones.CurrentRow.Cells("Código Cerda").Value
                .IdEnsemeninacion = Me.DgvEnseminaciones.CurrentRow.Cells("IdEnseminación").Value
                .ShowDialog()
            End With
        End If

    End Sub
    Private Sub btnGuardarModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCodigoCerda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoCerda.TextChanged
        Dim CadenaConsulta As String = "SELECT a.Id_Enseminacion, a.Código_Cerda, a.Fecha_Enseminacion, Estado, Fecha_Parto_Estimada" _
                                            & " FROM Reg_Enseminaciones_x_cerda AS a" _
                                            & " JOIN Estado_de_Partos AS b ON a.Id_Enseminacion= b.Id_Enseminacion" _
                                            & " WHERE (a.Estado='C' OR a.Estado='P') AND b.Estado_Parto='FALSE' and a.Código_Cerda like '" & Me.txtCodigoCerda.Text & "%'"
        sql = New SqlCommand(CadenaConsulta, con)
        dt = New DataTable
        With dt.Columns
            .Add(New DataColumn("IdEnseminación"))
            .Add(New DataColumn("Código Cerda"))
            .Add(New DataColumn("Fecha Enseminación"))
            .Add(New DataColumn("Estado"))
            .Add(New DataColumn("Parto Estimado"))
        End With
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            dr = dt.NewRow
            dr(0) = leer(0)
            dr(1) = leer(1)
            dr(2) = leer(2)
            dr(3) = leer(3)
            dr(4) = leer(4)
            dt.Rows.Add(dr)
        End While
        dv = New DataView(dt)
        Me.DgvEnseminaciones.DataSource = dv
        con.Close()
        Me.lbItems.Text = Me.DgvEnseminaciones.Rows.Count
    End Sub

    Private Sub lbItems_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbItems.TextChanged
        If Me.lbItems.Text = 0 Then
            Me.btnModificar.Enabled = False
        Else
            Me.btnModificar.Enabled = True
        End If
    End Sub

    Private Sub txtCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCosto.TextChanged
        If Me.txtFecha.Text <> "" And Me.txtFecha.Text <> "dd/mm/aa" And Me.txtFecha.TextLength = 8 And Me.cbxCodigoCerda.Text <> "" And (Me.chboxConfirmado.CheckState <> CheckState.Unchecked Or Me.chkboxPendiente.CheckState <> CheckState.Unchecked Or Me.chbxFalso.CheckState <> CheckState.Unchecked) And Me.txtCosto.Text <> "" Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub DgvEnseminaciones_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvEnseminaciones.CellContentDoubleClick
        If Me.DgvEnseminaciones.CurrentRow.Cells("Estado").Value = "C" Then
            Dim frmCambiar As New DfrmCambioEstadoEnseminacion()
            With frmCambiar
                .cbxEstado.Items.Add("Abortó")
                .txtCódigoCerda.Text = Me.DgvEnseminaciones.CurrentRow.Cells("Código Cerda").Value
                .ShowDialog()
            End With
        ElseIf Me.DgvEnseminaciones.CurrentRow.Cells("Estado").Value = "P" Then
            Dim frmCambiar As New DfrmCambioEstadoEnseminacion()
            With frmCambiar
                .cbxEstado.Items.Add("Confirmado")
                .cbxEstado.Items.Add("Nulo")
                .txtCódigoCerda.Text = Me.DgvEnseminaciones.CurrentRow.Cells("Código Cerda").Value
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub cbxLoteMontas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLoteMontas.SelectedIndexChanged
        Me.MostrarCodigoCerda()
    End Sub

    Private Sub rbtAbuelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAbuelas.CheckedChanged
        Me.MostrarCodigoCerda()
    End Sub
End Class