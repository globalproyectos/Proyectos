Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmRevicionDestetes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim HayDestetesMadres As Boolean = False
    Dim HayDestetesAbuelas As Boolean = False
    Dim TotalEngordesDestetar As Integer = 0
    Dim ExisteLote As Boolean = False
    Dim DefuncionNo As Integer = 0
    Dim txtFecha_M As New TextBox
    Dim txtFecha_A As New TextBox
    Dim BorrandoCelda_M As Boolean
    Dim BorrandoCelda_A As Boolean
    Dim odtsProcesos As New dtsPesosCerdosProcesos
    Dim lotesAdapter As New dtsPesosCerdosProcesosTableAdapters.LotesTableAdapter

    Sub Mostrar_LotesGestacion()
        Try
            Me.cbxLotesGestacion.Items.Clear()
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
                Me.cbxLotesGestacion.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando Gestaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub MostrarLoteEngorde()
        Try
            Me.cbxLotesEngorde.Items.Clear()
            sql = New SqlCommand("select Lote_No from LOTES where IdEtapa_Cerdas='E' AND Estado='A'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesEngorde.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando Engordes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub frmRevicionDestetes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        With My.Forms.frmRegistrar_Parto
            .CheckBoxX1.CheckState = CheckState.Unchecked
        End With
    End Sub
    Private Sub frmRevicionDestetes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbxLotesEngorde.Text = ""
        Me.Mostrar_LotesGestacion()
        Me.MostrarLoteEngorde()
        Me.NoDesteteAuto()
        AddHandler Me.Lista_Abuelas_DesteteDataGridView.EditingControlShowing, AddressOf dataGridView1_EditingControlShowing_A
        AddHandler Me.Lista_Madres_DesteteDataGridView.EditingControlShowing, AddressOf dataGridView1_EditingControlShowing_M
    End Sub
    Private Sub dataGridView1_EditingControlShowing_M(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs)
        If Me.Lista_Madres_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
            txtFecha_M = CType(e.Control, TextBox)
            AddHandler txtFecha_M.TextChanged, AddressOf tb_TextChanged_M
        End If
    End Sub
    Private Sub dataGridView1_EditingControlShowing_A(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs)
        If Me.Lista_Abuelas_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
            txtFecha_A = CType(e.Control, TextBox)
            AddHandler txtFecha_A.TextChanged, AddressOf tb_TextChanged_A
        End If
    End Sub
    Private Sub tb_TextChanged_M(ByVal sender As Object, ByVal e As EventArgs)
        'If Me.Lista_Madres_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
        '    If BorrandoCelda_M = False Then
        '        If txtFecha_M.TextLength = 2 Then
        '            Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
        '            Me.txtFecha_M.SelectionStart = 3
        '        ElseIf Me.txtFecha_M.TextLength = 5 Then
        '            Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
        '            Me.txtFecha_M.SelectionStart = 6
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub tb_TextChanged_A(ByVal sender As Object, ByVal e As EventArgs)
        'If Me.Lista_Abuelas_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
        '    If BorrandoCelda_A = False Then
        '        If txtFecha_A.TextLength = 2 Then
        '            Me.txtFecha_A.Text = Me.txtFecha_A.Text & "/"
        '            Me.txtFecha_A.SelectionStart = 3
        '        ElseIf Me.txtFecha_A.TextLength = 5 Then
        '            Me.txtFecha_A.Text = Me.txtFecha_A.Text & "/"
        '            Me.txtFecha_A.SelectionStart = 6
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub FechaCelda_KeyPress_M(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Me.Lista_Madres_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
                If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Asc(e.KeyChar) <> 47 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If

            If Me.Lista_Madres_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then

                If txtFecha_M.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
                    Me.txtFecha_M.SelectionStart = 3
                ElseIf Me.txtFecha_M.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
                    Me.txtFecha_M.SelectionStart = 6
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FechaCelda_KeyPress_A(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Me.Lista_Abuelas_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
                If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Asc(e.KeyChar) <> 47 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If

            If Me.Lista_Abuelas_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then

                If txtFecha_A.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_A.Text = Me.txtFecha_A.Text & "/"
                    Me.txtFecha_A.SelectionStart = 3
                ElseIf Me.txtFecha_A.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_A.Text = Me.txtFecha_A.Text & "/"
                    Me.txtFecha_A.SelectionStart = 6
                End If

            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub CellOnKeyDown_A(ByVal sender As Object, ByVal e As KeyEventArgs)
        'Try

        '    If Me.Lista_Abuelas_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
        '        If (e.KeyCode = Keys.Back) Then
        '            BorrandoCelda_A = True
        '        Else
        '            BorrandoCelda_A = False
        '        End If
        '    End If

        'Catch ex As Exception
        'End Try
    End Sub
    Private Sub CellOnKeyDown_M(ByVal sender As Object, ByVal e As KeyEventArgs)
        'Try
        '    If Me.Lista_Madres_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
        '        If (e.KeyCode = Keys.Back) Then
        '            BorrandoCelda_M = True
        '        Else
        '            BorrandoCelda_M = False
        '        End If
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Lista_Madres_DesteteDataGridView.EndEdit()
        Me.Close()
    End Sub
    Private Sub ADestetesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Abuelas_DesteteTableAdapter.ADestetes(Me.DtsBDGRANJA.Lista_Abuelas_Destete, Me.cbxLotesGestacion.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cbxLotesGestacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotesGestacion.SelectedIndexChanged
        Me.lbTotalEngordes.Text = "0"
        Me.lbEngordes.Text = "0"
        Me.ADLoteDonar.Items.Clear()
        Me.MDLoteDonar.Items.Clear()

        If Me.cbxLotesGestacion.Text <> "" Then
            Dim LoteNo As String = Me.cbxLotesGestacion.Text
            Dim cmd As String = "DECLARE @LoteNo char(8) SET @LoteNo = '" & LoteNo & "' SELECT l.Lote_No FROM LOTES l where l.Estado <>'T' AND l.IdEtapa_Cerdas ='G' and l.Lote_No<>@LoteNo"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.ADLoteDonar.Items.Add(leer(0).ToString)
                Me.MDLoteDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
            Me.ADestetesToolStripButton_Click(sender, e)

            For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADDestetar").Value = True
                Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADSinDestetar").Value = 0
            Next

            Me.MDestetesToolStripButton_Click(sender, e)

            For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
                Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDDestetar").Value = True
                Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDSinDestetar").Value = 0
            Next

        End If
        Try
            For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADFechaRealDestete").Value = Format(FechaSistema, "dd/MM/yy")
            Next
            For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
                Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDFechaRealDestete").Value = Format(FechaSistema, "dd/MM/yy")
            Next
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            Dim TEngordes As Integer = 0
            For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
                TEngordes += Val(Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells(5).Value)
            Next
            For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                TEngordes += Val(Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells(5).Value)
            Next
            Me.lbTotalEngordes.Text = TEngordes

            Me.loteDestinoLabelX9.Text = "Eng. : " & lotesAdapter.GetLoteDestino(Me.cbxLotesGestacion.Text)
        Catch ex As Exception
        End Try
        Me.lbRegistros.Text = Val(Me.Lista_Abuelas_DesteteDataGridView.Rows.Count) + Val(Me.Lista_Madres_DesteteDataGridView.Rows.Count)



        Dim fechaDesarrollo As Fecha_Dias_Desarrollo = ClaseDestetes.getFechaDesarrollo(lotesAdapter.GetLoteDestino(Me.cbxLotesGestacion.Text))
        If fechaDesarrollo IsNot Nothing Then
            Me.fechaDesarrolloDateTimeInput1.Text = fechaDesarrollo.Fecha
        Else
            Me.fechaDesarrolloDateTimeInput1.Text = Nothing
        End If
    End Sub

    Private Sub Lista_Abuelas_DesteteDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Abuelas_DesteteDataGridView.CellEnter
        Try
            If Me.Lista_Abuelas_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
                Me.Lista_Abuelas_DesteteDataGridView.BeginEdit(True)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub totalizarengordesdestetarMadres()
        For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.RowCount - 1
            If Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDestetar").Value = True Then
                With Me.Lista_Madres_DesteteDataGridView.Rows(i)
                    .Cells("MDNoDestetar").Value = If(IsNumeric(.Cells("MDNoVivos").Value), .Cells("MDNoVivos").Value, 0) + If(IsNumeric(.Cells("MDDefunciones").Value), .Cells("MDDefunciones").Value, 0)
                End With
            Else
                With Me.Lista_Madres_DesteteDataGridView.Rows(i)
                    .Cells("MDNoDestetar").Value = 0
                End With
            End If
        Next
        totalizarengordes()
    End Sub
    Sub totalizarengordesdestetarAbuelas()
        For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.RowCount - 1
            If Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADestetar").Value = True Then
                With Me.Lista_Abuelas_DesteteDataGridView.Rows(i)
                    .Cells("ADNoDestetar").Value = If(IsNumeric(.Cells("ADNoVivos").Value), .Cells("ADNoVivos").Value, 0) + If(IsNumeric(.Cells("ADDefunciones").Value), .Cells("ADDefunciones").Value, 0)
                End With
            Else
                With Me.Lista_Abuelas_DesteteDataGridView.Rows(i)
                    .Cells("ADNoDestetar").Value = 0
                End With

            End If
        Next
        totalizarengordes()
    End Sub
    Private Sub Lista_Abuelas_DesteteDataGridView_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Abuelas_DesteteDataGridView.CellLeave
        totalizarengordes()

        Me.Lista_Abuelas_DesteteDataGridView.EndEdit()
        If Not IsNumeric(Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADSinDestetar").Value) Then
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADSinDestetar").Value = 0
        ElseIf Not IsNumeric(Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDefunciones").Value) Then
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDefunciones").Value = 0
        Else
            totalizarengordesdestetarAbuelas()
        End If

        If Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADSinDestetar").Value <> 0 And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDestetar").Value = True Then
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Style.BackColor = Color.White
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Style.BackColor = Color.White
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").ReadOnly = False
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").ReadOnly = False
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = True
        Else
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Style.BackColor = Color.Gray
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Style.BackColor = Color.Gray
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").ReadOnly = True
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").ReadOnly = True
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = False
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value = ""
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Value = ""

        End If
        If ADLoteDonar.Items.Count <> 0 And Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value <> "" Then
            ADCerdaDonar.Items.Clear()
            sql = New SqlCommand("select Código_Abuela from REG_ABUELAS where Lote_No='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value & "' and Estado_Actual='L'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ADCerdaDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
            sql = New SqlCommand("select Código_Cerda from REG_MADRES where Lote_No='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value & "' and Estado_Actual='L'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ADCerdaDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
        End If
        Try
            If (Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoDestetar").Value - Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDefunciones").Value) > Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoVivos").Value Then
                MessageBoxEx.Show("El Número de cerdos que ha ingresado excede el numero de cerdos que se registrarón en el parto de la cerda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoDestetar").Selected = True
                Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoDestetar").Value = Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoVivos").Value
            End If
        Catch ex As Exception

        End Try

        If Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE LOTE SE VAN A DONAR"
        ElseIf Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE CERDA SE VAN A DONAR"
        ElseIf Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value = "" And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE LOTE Y A QUE CERDA SE VAN A DONAR"
        Else
            Me.lbInfo.Text = ""
        End If

        Dim FechaCorrectas_Madres As Boolean = False
        Dim Errores As Integer = 0
        Dim FechaCorrectas_Abuelas As Boolean = False
        For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
            If IsDate(Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADFechaRealDestete").Value) Then
                FechaCorrectas_Abuelas = True
                Me.Lista_Abuelas_DesteteDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.White

            End If
        Next
    End Sub
    Private Sub Lista_Madres_DesteteDataGridView_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Madres_DesteteDataGridView.CellLeave

        totalizarengordes()
        Me.Lista_Madres_DesteteDataGridView.EndEdit()
        'Try
        If Not IsNumeric(Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDSinDestetar").Value) Then
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDSinDestetar").Value = 0
        ElseIf Not IsNumeric(Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDefunciones").Value) Then
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDefunciones").Value = 0
        Else
            totalizarengordesdestetarMadres()

        End If

        If Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDSinDestetar").Value <> 0 And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDestetar").Value = True Then
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Style.BackColor = Color.White
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Style.BackColor = Color.White
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").ReadOnly = False
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").ReadOnly = False
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = True
        Else
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Style.BackColor = Color.Gray
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Style.BackColor = Color.Gray
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").ReadOnly = True
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").ReadOnly = True
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = False
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value = ""
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Value = ""

        End If

        If MDLoteDonar.Items.Count <> 0 And Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value <> "" Then
            MDCerdaDonar.Items.Clear()
            sql = New SqlCommand("select Código_Abuela from REG_ABUELAS where Lote_No='" & Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value & "' and Estado_Actual='L'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                MDCerdaDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
            sql = New SqlCommand("select Código_Cerda from REG_MADRES where Lote_No='" & Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value & "' and Estado_Actual='L'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                MDCerdaDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
        End If
        Try
            If (Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoDestetar").Value - Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDefunciones").Value) > Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoVivos").Value Then
                MessageBoxEx.Show("El Número de cerdos que ha ingresado excede el numero de cerdos que se registrarón en el parto de la cerda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoDestetar").Selected = True
                Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoDestetar").Value = Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoVivos").Value
            End If
        Catch ex As Exception

        End Try


        If Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE LOTE SE VAN A DONAR"
        ElseIf Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE CERDA SE VAN A DONAR"
        ElseIf Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value = "" And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE LOTE Y A QUE CERDA SE VAN A DONAR"
        Else
            Me.lbInfo.Text = ""
        End If

        Me.Lista_Madres_DesteteDataGridView.EndEdit()

        Dim FechaCorrectas_Madres As Boolean = False
        Dim Errores As Integer = 0
        Dim FechaCorrectas_Abuelas As Boolean = False
        For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
            If IsDate(Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDFechaRealDestete").Value) Then
                FechaCorrectas_Madres = True
                Me.Lista_Madres_DesteteDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.White

                'Else
                '    FechaCorrectas_Madres = False
                '    Me.Lista_Madres_DesteteDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
                '    Errores += 1
            End If
        Next

    End Sub



    Private Sub Lista_Madres_DesteteDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Madres_DesteteDataGridView.CellEnter
        Try
            If Me.Lista_Madres_DesteteDataGridView.CurrentCell.ColumnIndex = 4 Then
                Me.Lista_Madres_DesteteDataGridView.BeginEdit(True)
            End If
        Catch ex As Exception
        End Try
    End Sub


    Sub totalizarengordes()
        TotalEngordesDestetar = 0
        Dim NoEngordes_Madres As Integer = 0
        Dim NoEngordes_Abuelas As Integer = 0

        For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
            'If Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDDestetar").Value = True Then

            NoEngordes_Madres += Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value
            'End If
        Next
        For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
            'If Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADDestetar").Value = True Then

            NoEngordes_Abuelas += Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value
            'End If
        Next
        TotalEngordesDestetar = (NoEngordes_Madres + NoEngordes_Abuelas)
        Me.lbEngordes.Text = TotalEngordesDestetar
    End Sub


    Private Sub Lista_Abuelas_DesteteDataGridView_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles Lista_Abuelas_DesteteDataGridView.RowPrePaint
        'Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADFechaRealDestete").Value = FechaSistema

    End Sub
    Private Sub Lista_Madres_DesteteDataGridViewX_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles Lista_Madres_DesteteDataGridView.RowPrePaint
        'Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDFechaRealDestete").Value = FechaSistema
    End Sub
    Private Sub Lista_Abuelas_DesteteDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Lista_Abuelas_DesteteDataGridView.DataError
    End Sub
    Private Sub Lista_Madres_DesteteDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Lista_Madres_DesteteDataGridView.DataError
    End Sub
    Private Sub lbRegistros_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbRegistros.TextChanged
        If Me.lbRegistros.Text = "0" Then
            Me.btnGuardar.Enabled = False
            Me.btnExportarExcel.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
            Me.btnExportarExcel.Enabled = False
        End If
    End Sub
    Private Sub lbInfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbInfo.TextChanged
        If Me.lbInfo.Text <> "" Then
            Me.btnGuardar.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
        End If
    End Sub



    Sub Guardar_Destetes_Abuelas()
        Try
            Me.Lista_Abuelas_DesteteDataGridView.EndEdit()
            Dim donaciones As Integer = 0
            Dim NoDestetarFull As Integer = 0
            Dim NoCerdasFull As Integer = 0
            Dim TotalEngordes_mas_Donaciones As Integer = 0
            For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                If (Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value > 0) Then
                    NoCerdasFull += 1
                    NoDestetarFull += Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value
                    TotalEngordes_mas_Donaciones += (Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value + Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADSinDestetar").Value)
                End If

            Next
            For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
                If (Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value > 0) Then
                    NoCerdasFull += 1
                    NoDestetarFull += Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value
                    TotalEngordes_mas_Donaciones += (Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value + Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDSinDestetar").Value)
                End If
            Next

            Dim movimientos As Movimientos_Lotes_Int = ClaseDestetes.getExisteMovimiento(Me.cbxLotesEngorde.Text)

            Dim no_destete As Integer, documento_destete As String
            If movimientos IsNot Nothing Then
                no_destete = Convert.ToInt32(movimientos.Documento_NO.Replace("Dt.", ""))
                documento_destete = movimientos.Documento_NO
            Else
                no_destete = Convert.ToInt32(Me.txtNodestete.Text)
                documento_destete = "Dt." & Me.txtNodestete.Text
            End If


            For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                If (Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value > 0) Then
                    Try
                        Dim MuertosGestacion_Existentes As Integer = 0
                        sql = New SqlCommand("select Muertos_Gestacion from REG_PARTOS_X_CERDA where ID_Enseminacion='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value & "'", con)
                        con.Open()
                        leer = sql.ExecuteReader
                        While leer.Read
                            MuertosGestacion_Existentes = leer(0)
                        End While
                        con.Close()
                        HayDestetesAbuelas = True
                        If Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADDefunciones").Value > 0 Then
                            RegistrarDefuncion(Me.cbxLotesGestacion.Text, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADDefunciones").Value, "MUERTE DE CERDOS EN LACTANCIA, REGISTRADOS EN EL DESTETE NO: " & Me.txtNodestete.Text & ", ID INSEMINACION: " & Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value, FechaSistema, DefuncionNo, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADCodigoCerda").Value, "DESCONOCIDO", 0)
                        End If

                        sql = New SqlCommand("UPDATE REG_PARTOS_X_CERDA SET No_Destetados='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value & "', Se_Destetaron='" & True & "', Fecha_real_destete='" & FechaSistema & "',Muertos_Gestacion= '" & (MuertosGestacion_Existentes + Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADDefunciones").Value) & "',Lote_se_cargaron='" & Me.cbxLotesEngorde.Text & "', Peso_Destetados='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ATotalPesoDestetados").Value & "' WHERE ID_Enseminacion='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        sql = New SqlCommand("UPDATE REG_ABUELAS SET Lote_No='5', Estado_Actual='V' WHERE Código_Abuela='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADCodigoCerda").Value & "'", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()

                        RegistrarMovimientoLote(Me.cbxLotesGestacion.Text, 0, 0, 0, 0, 0, 1, FechaSistema, documento_destete)
                        RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, documento_destete)
                        RegistrarMovimientoLote(Me.cbxLotesEngorde.Text, 0, 0, 0, 0, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value, 0, FechaSistema, documento_destete)
                        ActualizarLote()
                        IngresarHistorico(Me.cbxLotesEngorde.Text, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value, no_destete)


                        sql = New SqlCommand("insert into Registro_de_destetes values('" & no_destete & "','" & Me.cbxLotesGestacion.Text & "','" & FechaSistema & "','" & UsuarioActual & "','" & Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADCodigoCerda").Value & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()



                        InsertarProcesoCerda(Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADCodigoCerda").Value, "Destete", FechaSistema, documento_destete, Me.cbxLotesGestacion.Text, "S")
                        InsertarProcesoCerda(Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADCodigoCerda").Value, "Destete", FechaSistema, documento_destete, "5", "E")

                        If Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADDefunciones").Value > 0 Then
                            InsertarProcesosCerditos(Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value, "MuertosGes", Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADDefunciones").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Me.cbxLotesEngorde.Text, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADCodigoCerda").Value, "Dt." & Trim(txtNodestete.Text))
                        End If
                        If Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADSinDestetar").Value > 0 Then
                            InsertarProcesosCerditos(Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value, "Donaciones", Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADSinDestetar").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Me.cbxLotesEngorde.Text, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADCodigoCerda").Value, "Dt." & Trim(txtNodestete.Text))
                        End If
                        If Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value > 0 Then
                            InsertarProcesosCerditos(Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADIdIns").Value, "Destetados", Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Me.cbxLotesEngorde.Text, Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADCodigoCerda").Value, "Dt." & Trim(txtNodestete.Text))
                        End If
                    Catch ex As Exception
                        MessageBoxEx.Show(ex.Message, "Error al realizar destete abuelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                    End Try
                End If

            Next

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar Destetes Abuelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Sub Guardar_Destetes_Madres()
        'Try




        Me.Lista_Madres_DesteteDataGridView.EndEdit()
        Dim donaciones As Integer = 0
        Dim NoDestetarFull As Integer = 0
        Dim NoCerdasFull As Integer = 0
        Dim TotalEngordes_mas_Donaciones As Integer = 0
        For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
            If (Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value > 0) Then
                NoCerdasFull += 1
                NoDestetarFull += Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value
                TotalEngordes_mas_Donaciones += (Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value + Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADSinDestetar").Value)
            End If
        Next
        For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
            If (Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value > 0) Then
                NoCerdasFull += 1
                NoDestetarFull += Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value
                TotalEngordes_mas_Donaciones += (Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value + Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDSinDestetar").Value)
            End If
        Next

        Dim movimientos As Movimientos_Lotes_Int = ClaseDestetes.getExisteMovimiento(Me.cbxLotesEngorde.Text)

        Dim no_destete As Integer, documento_destete As String
        If movimientos IsNot Nothing Then
            no_destete = Convert.ToInt32(movimientos.Documento_NO.Replace("Dt.", ""))
            documento_destete = movimientos.Documento_NO
        Else
            no_destete = Convert.ToInt32(Me.txtNodestete.Text)
            documento_destete = "Dt." & Me.txtNodestete.Text
        End If


        For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
            If (Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value > 0) Then
                Try


                    Dim MuertosGestacion_Existentes As Integer = 0
                    sql = New SqlCommand("select Muertos_Gestacion from REG_PARTOS_X_CERDA where ID_Enseminacion='" & Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        MuertosGestacion_Existentes = leer(0)
                    End While
                    con.Close()
                    HayDestetesMadres = True
                    If Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDDefunciones").Value > 0 Then
                        RegistrarDefuncion(Me.cbxLotesGestacion.Text, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDDefunciones").Value, "MUERTE DE CERDOS EN LACTANCIA, REGISTRADOS EN EL DESTETE NO: " & no_destete & ", ID INSEMINACION: " & Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value, FechaSistema, DefuncionNo, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDCodigoCerda").Value, "DESCONOCIDO", 0)
                    End If
                    sql = New SqlCommand("UPDATE REG_PARTOS_X_CERDA SET No_Destetados='" & Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value & "', Se_Destetaron='" & True & "', Muertos_Gestacion= '" & (MuertosGestacion_Existentes + Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDDefunciones").Value) & "',Fecha_real_destete='" & FechaSistema & "',Lote_se_cargaron='" & Me.cbxLotesEngorde.Text & "', Peso_Destetados='" & Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MTotalPesoDestetados").Value & "' WHERE ID_Enseminacion='" & Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    sql = New SqlCommand("UPDATE REG_MADRES SET Lote_No='5', Estado_Actual='V' WHERE Código_Cerda='" & Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDCodigoCerda").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    RegistrarMovimientoLote(Me.cbxLotesGestacion.Text, 0, 0, 0, 0, 0, 1, FechaSistema, documento_destete)
                    RegistrarMovimientoLote("5", 0, 0, 0, 0, 1, 0, FechaSistema, documento_destete)
                    RegistrarMovimientoLote(Me.cbxLotesEngorde.Text, 0, 0, 0, 0, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value, 0, FechaSistema, documento_destete)
                    ActualizarLote()
                    IngresarHistorico(Me.cbxLotesEngorde.Text, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value, no_destete)


                    sql = New SqlCommand("insert into Registro_de_destetes values(" & no_destete & ",'" & Me.cbxLotesGestacion.Text & "','" & FechaSistema & "','" & UsuarioActual & "','" & Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDCodigoCerda").Value & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()


                    InsertarProcesoCerda(Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDCodigoCerda").Value, "Destete", FechaSistema, documento_destete, Me.cbxLotesGestacion.Text, "S")
                    InsertarProcesoCerda(Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDCodigoCerda").Value, "Destete", FechaSistema, documento_destete, "5", "E")

                    If Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDDefunciones").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value, "MuertosGes", Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDDefunciones").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Me.cbxLotesEngorde.Text, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDCodigoCerda").Value, documento_destete)
                    End If
                    If Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDSinDestetar").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value, "Donaciones", Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDSinDestetar").Value, FechaSistema, UsuarioActual, "E", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Me.cbxLotesEngorde.Text, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDCodigoCerda").Value, documento_destete)
                    End If
                    If Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value > 0 Then
                        InsertarProcesosCerditos(Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDIdIns").Value, "Destetados", Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value, FechaSistema, UsuarioActual, "I", Lotes_Gestacion_ActivosTableAdapter.GetLoteMonta(Me.cbxLotesGestacion.Text), Me.cbxLotesGestacion.Text, Me.cbxLotesEngorde.Text, Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDCodigoCerda").Value, documento_destete)
                    End If
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "Error al realizar destete madres", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try
            End If


        Next

        'Catch ex As Exception
        '    MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar Destetes Madres", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    con.Close()
        'End Try

    End Sub
    Public Sub Destetar()
        Try
            Dim NoDestetarFull As Integer = 0
            Dim NoCerdasFull As Integer = 0
            Dim TotalEngordes_mas_Donaciones As Integer = 0
            Dim totalPesoCerditos As Double = 0

            For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                If (Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value > 0) Then
                    NoCerdasFull += 1
                    NoDestetarFull += Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value
                    TotalEngordes_mas_Donaciones += (Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value + Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADSinDestetar").Value)
                    totalPesoCerditos += Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ATotalPesoDestetados").Value
                End If


            Next
            For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
                If (Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value > 0) Then
                    NoCerdasFull += 1
                    NoDestetarFull += Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value
                    TotalEngordes_mas_Donaciones += (Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value + Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDSinDestetar").Value)
                    totalPesoCerditos += Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MTotalPesoDestetados").Value
                End If

            Next
            If HayDestetesAbuelas = True Or HayDestetesMadres = True Then
                Dim movimientos_lote As Movimientos_Lotes_Int = ClaseDestetes.getExisteMovimiento(Me.cbxLotesEngorde.Text)

                Dim no_destete As Integer, documento_destete As String
                If movimientos_lote IsNot Nothing Then
                    no_destete = Convert.ToInt32(movimientos_lote.Documento_NO.Replace("Dt.", ""))
                    documento_destete = movimientos_lote.Documento_NO
                Else
                    no_destete = Convert.ToInt32(Me.txtNodestete.Text)
                    documento_destete = "Dt." & Me.txtNodestete.Text
                End If

                If movimientos_lote IsNot Nothing Then
                    HalarCostos_de_Gestacion_a_Engorde(Me.cbxLotesGestacion.Text, Me.cbxLotesEngorde.Text, FechaSistema, "(M. Y A.)DESTETE CERDOS-DE GESTACION A ENGORDE", TotalEngordes_mas_Donaciones, NoDestetarFull, NoCerdasFull, documento_destete, "actualizar", totalPesoCerditos, fechaDesarrolloDateTimeInput1.Text, movimientos_lote.Documento_NO)
                Else
                    HalarCostos_de_Gestacion_a_Engorde(Me.cbxLotesGestacion.Text, Me.cbxLotesEngorde.Text, FechaSistema, "(M. Y A.)DESTETE CERDOS-DE GESTACION A ENGORDE", TotalEngordes_mas_Donaciones, NoDestetarFull, NoCerdasFull, documento_destete, "insertar", totalPesoCerditos, fechaDesarrolloDateTimeInput1.Text)
                End If

            End If

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar Destetes Madres y Abuelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not IsDate(Me.fechaDesarrolloDateTimeInput1.Text) Then
            MessageBoxEx.Show("Debe especificar una fecha semanal de destete válida", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        calcularpesos()
        Try
            totalizarengordesdestetarAbuelas()
            totalizarengordesdestetarMadres()
        Catch ex As Exception
        End Try

        Try
            sql = New SqlCommand("select isnull((max(DefuncionNo)),1) from DEFUNCIONES", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                DefuncionNo = leer(0) + 1
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error recuperando Max-Defuncion No", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try


        Dim FechaCorrectas_Madres As Boolean = False
        Dim PesosACero As Integer = 0
        Dim Errores As Integer = 0
        Dim HayErrores As Boolean = False
        Dim FechaCorrectas_Abuelas As Boolean = False
        Me.Lista_Madres_DesteteDataGridView.EndEdit()
        Me.Lista_Abuelas_DesteteDataGridView.EndEdit()

        If HayErrores <> True Then

            con.Close()
            If Me.cbxLotesEngorde.Text = "" Then
                MessageBoxEx.Show("No ha seleccionado el lote Engorde al que se moverán los cerdos destetados", "Lote Engorde", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.cbxLotesEngorde.Focus()
            ElseIf ExisteLote = False Then
                MessageBoxEx.Show("El lote de engorde que ha ingresado no existe por favor asegúrese de haberlo creado con anterioridad", "No existe lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.cbxLotesEngorde.Focus()

            Else

                Dim HayDestetesAbuelas As Boolean = False
                Dim HayDestetesMadres As Boolean = False
                TotalEngordesDestetar = 0
                Dim NoEngordes_Madres As Integer = 0
                Dim NoEngordes_Abuelas As Integer = 0

                For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1

                    HayDestetesMadres = True
                    NoEngordes_Madres += Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value

                Next
                For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1

                    HayDestetesAbuelas = True
                    NoEngordes_Abuelas += Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value

                Next

                Dim movimientos As Movimientos_Lotes_Int = ClaseDestetes.getExisteMovimiento(Me.cbxLotesEngorde.Text)

                Dim no_destete As Integer, documento_destete As String
                If movimientos IsNot Nothing Then
                    no_destete = Convert.ToInt32(movimientos.Documento_NO.Replace("Dt.", ""))
                    documento_destete = movimientos.Documento_NO
                Else
                    no_destete = Convert.ToInt32(Me.txtNodestete.Text)
                    documento_destete = "Dt." & Me.txtNodestete.Text
                End If


                TotalEngordesDestetar = (NoEngordes_Madres + NoEngordes_Abuelas)

                If HayDestetesAbuelas = True Or HayDestetesMadres = True Then

                    Dim NoAbuelas As Integer = 0
                    For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                        NoAbuelas += 1
                    Next
                    Dim NoMadres As Integer = 0
                    For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
                        NoMadres += 1
                    Next
                    If NoAbuelas > 0 Then
                        Me.Lista_Abuelas_DesteteDataGridView.EndEdit()
                        Me.Guardar_Destetes_Abuelas()

                    End If
                    If NoMadres > 0 Then
                        Me.Lista_Madres_DesteteDataGridView.EndEdit()
                        Me.Guardar_Destetes_Madres()
                    End If

                    Destetar()

                    sql = New SqlCommand("UPDATE Entradas_Lotes_Costos SET Lote_No='" & Me.cbxLotesEngorde.Text & "' WHERE Lote_No='" & Me.cbxLotesGestacion.Text & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    ActualizarLote()


                    If movimientos IsNot Nothing Then
                        Costo_al_Nacer(Me.cbxLotesEngorde.Text, Val(Me.lbTotalEngordes.Text), Val(Me.lbEngordes.Text), FechaSistema, documento_destete, "actualizar")
                    Else
                        Costo_al_Nacer(Me.cbxLotesEngorde.Text, Val(Me.lbTotalEngordes.Text), Val(Me.lbEngordes.Text), FechaSistema, documento_destete, "insertar")
                    End If


                    sql = New SqlCommand("Actualizar_NoCerdos_Destetados_en_TablaCostoNacer", con)
                    sql.CommandType = CommandType.StoredProcedure
                    Try
                        sql.Parameters.Add(New SqlParameter("@LoteNo", SqlDbType.Char, 8)).Value = Me.cbxLotesEngorde.Text
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                    Catch ex As Exception

                    End Try


                    Me.NoDesteteAuto()
                    Me.lbEngordes.Text = "0"
                    If Me.cbxLotesEngorde.Text <> "" Then
                        RevisarCierre_Lote(Me.cbxLotesGestacion.Text, Me.cbxLotesGestacion)
                        Me.Mostrar_LotesGestacion()
                        Me.MostrarLoteEngorde()
                    End If

                    Dim indice As Integer = cbxLotesGestacion.SelectedIndex
                    Me.cbxLotesGestacion.SelectedIndex = indice
                    cbxLotesGestacion_SelectedIndexChanged(sender, e)
                    If Me.cbxLotesGestacion.Text = "" Then
                        For i As Integer = 0 To Me.cbxLotesGestacion.Items.Count - 1
                            Me.cbxLotesGestacion.SelectedIndex = i
                        Next
                    End If

                    Me.cbxLotesEngorde.Text = ""
                    If Me.cbxLotesGestacion.Text <> "" Then
                        Me.ADestetesToolStripButton_Click(sender, e)
                        Me.MDestetesToolStripButton_Click(sender, e)
                    End If
                End If

                Me.totalPesoDoubleInput1.Value = 0
                Me.DiferenciaPesoDoubleInput2.Value = 0
                Me.TotalPesoDistribuidoDoubleInput1.Value = 0

            End If
        End If

    End Sub
    Sub NoDesteteAuto()
        Try
            Correlativo_Auto("SELECT MAX(DesteteNo) FROM Registro_de_destetes", Me.txtNodestete)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando No Destete Auto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        If Me.rbtMadres.Checked = True Then
        ElseIf Me.rbtAbuelas.Checked = True Then
            ExportarDatosExcel(Me.Lista_Abuelas_DesteteDataGridView, "LISTA DE ABUELAS CON CERDOS PARA DESTETE", "", "FECHA: " & FechaSistema, "K")
        End If
    End Sub
    Private Sub MDestetesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_Madres_DesteteTableAdapter.MDestetes(Me.DtsBDGRANJA.Lista_Madres_Destete, Me.cbxLotesGestacion.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Lista_Madres_DesteteDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Madres_DesteteDataGridView.RowLeave
        Me.lbRegistros.Text = Me.Lista_Madres_DesteteDataGridView.RowCount
        Me.Lista_Madres_DesteteDataGridView.EndEdit()
        'Try
        If Not IsNumeric(Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDSinDestetar").Value) Then
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDSinDestetar").Value = 0
        ElseIf Not IsNumeric(Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDefunciones").Value) Then
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDefunciones").Value = 0
        Else
            With Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex)
                Try
                    If .Cells("MDSinDestetar").Value > 0 Or .Cells("MDDefunciones").Value > 0 Or .Cells("MDNoDestetar").Value > 0 Then
                        .Cells("MDNoDestetar").Value = .Cells("MDNoVivos").Value - .Cells("MDDefunciones").Value - .Cells("MDSinDestetar").Value
                    End If
                Catch ex As Exception

                End Try

            End With

        End If
        If Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDSinDestetar").Value <> 0 And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDestetar").Value = True Then
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Style.BackColor = Color.White
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Style.BackColor = Color.White
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").ReadOnly = False
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").ReadOnly = False
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = True
        Else
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Style.BackColor = Color.Gray
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Style.BackColor = Color.Gray
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").ReadOnly = True
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").ReadOnly = True
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = False
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value = ""
            Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Value = ""
        End If
        If MDLoteDonar.Items.Count <> 0 And Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value <> "" Then
            MDCerdaDonar.Items.Clear()
            sql = New SqlCommand("select Código_Abuela from REG_ABUELAS where Lote_No='" & Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value & "' and Estado_Actual='L'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                MDCerdaDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
            sql = New SqlCommand("select Código_Cerda from REG_MADRES where Lote_No='" & Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value & "' and Estado_Actual='L'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                MDCerdaDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
        End If
        Try
            If (Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoDestetar").Value - Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDefunciones").Value) > Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoVivos").Value Then
                MessageBoxEx.Show("El Número de cerdos que ha ingresado excede el numero de cerdos que se registrarón en el parto de la cerda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoDestetar").Selected = True
                Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoDestetar").Value = Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDNoVivos").Value
            End If
        Catch ex As Exception

        End Try

        If Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDestetar").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE LOTE SE VAN A DONAR"
        ElseIf Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDestetar").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE CERDA SE VAN A DONAR"
        ElseIf Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDestetar").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDDonaciones").Value = True And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDLoteDonar").Value = "" And Me.Lista_Madres_DesteteDataGridView.Rows(e.RowIndex).Cells("MDCerdaDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE LOTE Y A QUE CERDA SE VAN A DONAR"
        Else
            Me.lbInfo.Text = ""
        End If

        Me.Lista_Madres_DesteteDataGridView.EndEdit()
    End Sub

    Private Sub Lista_Abuelas_DesteteDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_Abuelas_DesteteDataGridView.RowLeave
        Me.lbRegistros.Text = Me.Lista_Abuelas_DesteteDataGridView.RowCount
        Me.Lista_Abuelas_DesteteDataGridView.EndEdit()
        If Not IsNumeric(Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADSinDestetar").Value) Then
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADSinDestetar").Value = 0
        ElseIf Not IsNumeric(Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDefunciones").Value) Then
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDefunciones").Value = 0
        Else

            With Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex)
                .Cells("ADNoDestetar").Value = .Cells("ACantidad_Destetar").Value + .Cells("ADDefunciones").Value
                'Try
                '    If .Cells("ADSinDestetar").Value > 0 Or .Cells("ADDefunciones").Value > 0 Or .Cells("ADNoDestetar").Value Then
                '        .Cells("ADNoDestetar").Value = .Cells("ADNoVivos").Value - .Cells("ADDefunciones").Value - .Cells("ADSinDestetar").Value
                '    End If
                'Catch ex As Exception
                'End Try

            End With
        End If

        If Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADSinDestetar").Value <> 0 And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDestetar").Value = True Then
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Style.BackColor = Color.White
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Style.BackColor = Color.White
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").ReadOnly = False
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").ReadOnly = False
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = True
        Else
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Style.BackColor = Color.Gray
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Style.BackColor = Color.Gray
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").ReadOnly = True
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").ReadOnly = True
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = False
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value = ""
            Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Value = ""

        End If
        If ADLoteDonar.Items.Count <> 0 And Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value <> "" Then
            ADCerdaDonar.Items.Clear()
            sql = New SqlCommand("select Código_Abuela from REG_ABUELAS where Lote_No='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value & "' and Estado_Actual='L'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ADCerdaDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
            sql = New SqlCommand("select Código_Cerda from REG_MADRES where Lote_No='" & Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value & "' and Estado_Actual='L'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ADCerdaDonar.Items.Add(leer(0).ToString)
            End While
            con.Close()
        End If
        Try
            If (Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoDestetar").Value - Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDefunciones").Value) > Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoVivos").Value Then
                MessageBoxEx.Show("El Número de cerdos que ha ingresado excede el numero de cerdos que se registrarón en el parto de la cerda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoDestetar").Selected = True
                Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoDestetar").Value = Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADNoVivos").Value
            End If
        Catch ex As Exception

        End Try

        If Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDestetar").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE LOTE SE VAN A DONAR"
        ElseIf Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDestetar").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE CERDA SE VAN A DONAR"
        ElseIf Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDestetar").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADDonaciones").Value = True And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADLoteDonar").Value = "" And Me.Lista_Abuelas_DesteteDataGridView.Rows(e.RowIndex).Cells("ADCerdaDonar").Value = "" Then
            Me.lbInfo.Text = "HAY DONACIONES SIN ESTABLECER A QUE LOTE Y A QUE CERDA SE VAN A DONAR"
        Else
            Me.lbInfo.Text = ""
        End If
    End Sub
    Private Sub Lista_Madres_DesteteDataGridView_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Lista_Abuelas_DesteteDataGridView.Focus()
    End Sub
    Private Sub cbxLotesEngorde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLotesEngorde.LostFocus
        If Me.btnGuardar.Enabled = True And Me.cbxLotesEngorde.Text <> "" Then
            ExisteLote = False
            sql = New SqlCommand("select Lote_No from Lotes where Lote_No='" & Me.cbxLotesEngorde.Text & "' and IdEtapa_Cerdas='E'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ExisteLote = True
            End While
            con.Close()
        End If
    End Sub
    Private Sub Lista_Abuelas_DesteteDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Lista_Abuelas_DesteteDataGridView.EditingControlShowing
        Try
            Dim cellTextBox As DataGridViewTextBoxEditingControl = TryCast(e.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler cellTextBox.KeyDown, AddressOf CellOnKeyDown_A
            AddHandler cellTextBox.KeyDown, AddressOf CellOnKeyDown_A

            Dim FechaCelda As DataGridViewTextBoxEditingControl = TryCast(e.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler FechaCelda.KeyPress, AddressOf FechaCelda_KeyPress_A
            AddHandler FechaCelda.KeyPress, AddressOf FechaCelda_KeyPress_A
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Lista_Madres_DesteteDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Lista_Madres_DesteteDataGridView.EditingControlShowing
        Try
            Dim cellTextBox As DataGridViewTextBoxEditingControl = TryCast(e.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler cellTextBox.KeyDown, AddressOf CellOnKeyDown_M
            AddHandler cellTextBox.KeyDown, AddressOf CellOnKeyDown_M

            Dim FechaCelda As DataGridViewTextBoxEditingControl = TryCast(e.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler FechaCelda.KeyPress, AddressOf FechaCelda_KeyPress_M
            AddHandler FechaCelda.KeyPress, AddressOf FechaCelda_KeyPress_M
        Catch ex As Exception
        End Try
    End Sub
    Sub calcularpesos()
        Dim total_a_destetar As Integer = CInt(Me.lbEngordes.Text)
        Dim total_peso As Double = CDbl(Me.totalPesoDoubleInput1.Value)
        Dim peso_por_cerdo As Double = total_peso / total_a_destetar

        Dim total_peso_establecido As Double = 0
        For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
            Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MTotalPesoDestetados").Value = Math.Round(peso_por_cerdo * Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value, 2)
            total_peso_establecido += peso_por_cerdo * Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDNoDestetar").Value
        Next
        For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
            Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ATotalPesoDestetados").Value = Math.Round(peso_por_cerdo * Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value, 2)
            total_peso_establecido += peso_por_cerdo * Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADNoDestetar").Value
        Next
        Me.TotalPesoDistribuidoDoubleInput1.Value = total_peso_establecido
        Me.DiferenciaPesoDoubleInput2.Value = total_peso - total_peso_establecido
    End Sub
    Private Sub lbEngordes_TextChanged(sender As Object, e As EventArgs) Handles lbEngordes.TextChanged
        calcularpesos()
    End Sub

    Private Sub totalPesoDoubleInput1_ValueChanged(sender As Object, e As EventArgs) Handles totalPesoDoubleInput1.ValueChanged
        calcularpesos()
    End Sub
    Private Sub marcarTodasMadresCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles marcarTodasMadresCheckBox1.CheckedChanged
        If Me.Lista_Madres_DesteteDataGridView.Rows.Count > 0 Then
            If Me.marcarTodasMadresCheckBox1.Checked Then
                For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
                    Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDestetar").Value = True
                Next
            Else
                For i As Integer = 0 To Me.Lista_Madres_DesteteDataGridView.Rows.Count - 1
                    Me.Lista_Madres_DesteteDataGridView.Rows(i).Cells("MDestetar").Value = False
                Next
            End If
            totalizarengordesdestetarMadres()
        End If

    End Sub
    Private Sub marcarTodasAbuelasCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles marcarTodasAbuelasCheckBox2.CheckedChanged
        If Me.Lista_Abuelas_DesteteDataGridView.Rows.Count > 0 Then
            If Me.marcarTodasMadresCheckBox1.Checked Then
                For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                    Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADestetar").Value = True
                Next
            Else
                For i As Integer = 0 To Me.Lista_Abuelas_DesteteDataGridView.Rows.Count - 1
                    Me.Lista_Abuelas_DesteteDataGridView.Rows(i).Cells("ADestetar").Value = False
                Next
            End If
            totalizarengordesdestetarAbuelas()
        End If

    End Sub
End Class