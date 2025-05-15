Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmRegistro_Inseminacion
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim dtInseminaciones As New DataTable("Inseminaciones")
    Dim selecciono As Boolean = False
    Dim No_Cerdas_que_salen_de_montas_a_Gestaciona As Integer
    Dim IdInseminacion As Integer
    Dim SeleccionoLoteGestacion As Boolean = False
    Dim Fila As Integer = 0
    Dim Columna As Integer = 0
    Dim Madres_Abuelas As String = ""
    Dim txtFecha_M As New TextBox
    Dim txtFecha_A As New TextBox
    Dim BorrandoCelda_M As Boolean
    Dim BorradonCelda_A As Boolean

    Dim Valor_Depreciable As Double = 0
    Dim CodigoVerraco As String = ""
    Dim Valor_Dpc_Restante As Double = 0
    Dim Total_Depreciado As Double = 0

    Dim a_Valor_Depreciable As Double = 0
    Dim a_CodigoVerraco As String = ""
    Dim a_Valor_Dpc_Restante As Double = 0
    Dim a_Total_Depreciado As Double = 0
    Dim DepreciacionDispobile As Boolean = False
    Dim FechaCelda As Date
    Private Sub frmRegistro_Inseminacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NoInseminacionAuto()
        ActualizarDpcs()
        'TODO: esta línea de código carga datos en la tabla 'DtsBDGRANJA.Estados_Inseminaciones' Puede moverla o quitarla según sea necesario.
        Me.Estados_InseminacionesTableAdapter.Fill(Me.DtsBDGRANJA.Estados_Inseminaciones)
        Me.MostrarLotes_Montas()
        'Me.Mostrar_LotesGestacion()
        AddHandler Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EditingControlShowing, AddressOf dataGridView1_EditingControlShowing_A
        AddHandler Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EditingControlShowing, AddressOf dataGridView1_EditingControlShowing_M


    End Sub
    Private Sub dataGridView1_EditingControlShowing_M(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs)
        If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell.ColumnIndex = 4 Then
            txtFecha_M = CType(e.Control, TextBox)
            AddHandler txtFecha_M.TextChanged, AddressOf tb_TextChanged_M
        End If
    End Sub
    Private Sub dataGridView1_EditingControlShowing_A(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs)
        If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.ColumnIndex = 4 Then
            txtFecha_A = CType(e.Control, TextBox)
            AddHandler txtFecha_A.TextChanged, AddressOf tb_TextChanged_A
        End If
    End Sub
    Private Sub tb_TextChanged_M(ByVal sender As Object, ByVal e As EventArgs)
        'If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell.ColumnIndex = 4 Then
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
        'If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.ColumnIndex = 4 Then
        '    If BorradonCelda_A = False Then
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
    Sub NoInseminacionAuto()
        Try
            Correlativo_Auto("SELECT MAX(Inseminacion_NO) FROM Reg_Enseminaciones_x_cerda", Me.txtInseminacionNo)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando No Insemiancion Auto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub MostrarLotes_Montas()
        Try
            Me.cbxLotes.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                           & " FROM LOTES l" _
                           & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                           & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                           & " where L.Estado <>'T' AND IdEtapa_Cerdas='M' AND ((rm.Estado_Actual ='V' OR RA.Estado_Actual ='V'))" _
                           & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
                           & " ORDER BY L.IdEtapa_Cerdas"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotes.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error mostrando Lotes Montas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EndEdit()
        Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()

        Me.Close()
    End Sub
    Private Sub cbxLotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotes.SelectedIndexChanged
        'If Me.rbtMadres.Checked = True Then
        ActualizarDpcs()
        selecciono = True
        'Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Visible = True
        'Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Visible = False
        FillToolStripButton_Click(sender, e)
        Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Focus()
        'Me.lbRegistros.Text = Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count
        'ElseIf Me.rbtAbuelas.Checked = True Then
        Me.selecciono = True
        'Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Visible = False
        'Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Visible = True
        FillToolStripButton_Click_1(sender, e)
        EstablerDatosMadres_Abuelas()
        'Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Focus()
        Me.lbRegistros.Text = Val(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count) + Val(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count)

        'End If
    End Sub
    Private Sub FillToolStripButton_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        FillToolStripButton_Click(sender, e)
    End Sub
    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_cerdas_montas_para_inseminaciones_MadresTableAdapter.Fill(Me.DtsBDGRANJA.Lista_cerdas_montas_para_inseminaciones_Madres, Me.cbxLotes.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FillToolStripButton_Click(sender, e)
        FillToolStripButton_Click_1(sender, e)
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CellEnter

        Try
            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.BeginEdit(True)
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CellLeave
        

        Try
            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EndEdit()
            Dim fechaInseminacion As Date = Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("FechaInseminacion").Value
            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("FechaEstParto").Value = fechaInseminacion.AddDays(114)
            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells(6).Value = Format(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells(6).Value, "dd/MM/yy")
            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EndEdit()
            'If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell.ColumnIndex = 3 Then
            Fila = Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell.RowIndex
            Dim existeVerraco As Boolean = False
            sql = New SqlCommand("select Codigo_Cerdo from REG_VERRACOS where Codigo_Cerdo='" & RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentRow.Cells("Verraco").Value) & "' and Estado_Actual<>'D' AND Estado_Actual<>'DF'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                existeVerraco = True
            End While
            con.Close()
            If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value <> "" Then
                If existeVerraco = False Then
                    MessageBoxEx.Show("El Código del Verraco que ha ingresado no existe ó  ya ha sido descartado del sistema", "Dato Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(Fila).Cells("Verraco").Value = "N/V"
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells(9).Value = 0.0
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells(7).Value = 0.0
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells(8).Value = 0.0
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell = Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Item(3, Fila)
                Else
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EndEdit()
                    Try
                        sql = New SqlCommand("select Valor_Depreciable from Depreciaciones_Verracos where Codigo='" & RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value) & "'", con)
                        con.Open()
                        leer = sql.ExecuteReader
                        While leer.Read
                            Valor_Depreciable = leer(0)
                        End While
                        con.Close()

                        For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
                            If RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value) = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("Verraco").Value) Then
                                Valor_Depreciable -= Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("MDpc").Value
                            End If
                        Next
                        For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
                            If RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value) = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("Verraco2").Value) Then
                                Valor_Depreciable -= Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("ADpc").Value
                            End If
                        Next
                    Catch ex As Exception

                    End Try
                    Valor_Dpc_Restante = (Valor_Depreciable)
                    Me.LabelX2.Text = Valor_Dpc_Restante
                    If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells(3).Value <> "N/V" Then
                        If Valor_Dpc_Restante >= Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value)), 2) Then
                            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MDpc").Value = 0
                            'Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MDpc").Value = Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value)), 2)
                        End If
                        'Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MAlimentacion").Value = Math.Round(DepreciarVerraco_Alimento(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value)), 2)
                        Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MAlimentacion").Value = 0
                    Else
                        'Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MDpc").Value = Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value)), 2)
                        'Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MAlimentacion").Value = Math.Round(DepreciarVerraco_Alimento(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value)), 2)
                        Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MDpc").Value = 0
                        Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MAlimentacion").Value = 0
                    End If
                End If
            End If
            Try
                If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value <> "N/V" Then
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MTotal_Inyeccion").ReadOnly = True
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MTotal_Inyeccion").Value = (Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MDpc").Value + Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MAlimentacion").Value)
                End If
                If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value = "N/V" Then
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MTotal_Inyeccion").ReadOnly = False
                    'Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MTotal_Inyeccion").Value = (Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MDpc").Value + Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MAlimentacion").Value)
                End If
                If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value = "" Then
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("Verraco").Value = "N/V"
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MTotal_Inyeccion").ReadOnly = False
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(e.RowIndex).Cells("MTotal_Inyeccion").Value = 0.0
                End If
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'End If
            If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Item(9, e.RowIndex).Style.BackColor = Color.Red And Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Item(9, e.RowIndex).Value > 0 Then
                Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Item(9, e.RowIndex).Style.BackColor = System.Drawing.SystemColors.ActiveCaption
            End If
            'Verificar_Valor_DPC_Madres()
            'Verificar_Valor_DPC_Abuelas()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


       
    End Sub
    Public Function DepreciarVerraco_Alimento(ByVal Verraco As String) As Double
        Dim Depreciacion_Valor_Alimento As Double = 0
        Dim o_Mes As String = ""
        If FechaSistema.Month = 1 Then
            o_Mes = "ENE"
        ElseIf FechaSistema.Month = 2 Then
            o_Mes = "FEB"
        ElseIf FechaSistema.Month = 3 Then
            o_Mes = "MAR"
        ElseIf FechaSistema.Month = 4 Then
            o_Mes = "ABR"
        ElseIf FechaSistema.Month = 5 Then
            o_Mes = "MAY"
        ElseIf FechaSistema.Month = 6 Then
            o_Mes = "JUN"
        ElseIf FechaSistema.Month = 7 Then
            o_Mes = "JUL"
        ElseIf FechaSistema.Month = 8 Then
            o_Mes = "AGO"
        ElseIf FechaSistema.Month = 9 Then
            o_Mes = "SEP"
        ElseIf FechaSistema.Month = 10 Then
            o_Mes = "OCT"
        ElseIf FechaSistema.Month = 11 Then
            o_Mes = "NOV"
        ElseIf FechaSistema.Month = 12 Then
            o_Mes = "DIC"
        End If
        Try
            Dim DepreciaAlimento As Boolean
            sql = New SqlCommand("select Se_Deprecia_Alimento from Depreciaciones_Verracos where Codigo='" & RTrim(Verraco) & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                DepreciaAlimento = leer(0)
            End While
            con.Close()
            If DepreciaAlimento = True Then
                Me.cbxTemp_Codigos.Items.Clear()
                Dim d_Años_a_Depreciar, d_Dias_x_Año, d_Total_Dias As Integer
                Dim d_Total_Dosis_Años, d_Precio_QQ, d_Total_Libras, d_Total_QQ, d_Total_Alimento_C As Double
                Dim d_No_Colectas_Anual As Integer
                Dim d_Dosis_Obtenidas, d_NoDosis As Double
                d_Total_Alimento_C = 0
                sql = New SqlCommand("Select * from Depreciaciones_Verracos where Codigo='" & RTrim(Verraco) & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    d_Años_a_Depreciar = leer(2)
                    d_Dias_x_Año = leer(5)
                    d_No_Colectas_Anual = leer(6)
                    d_NoDosis = leer(7)
                End While
                con.Close()
                sql = New SqlCommand("select * from Codigos_Concent_Depreciacion", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.cbxTemp_Codigos.Items.Add(leer(1))
                End While
                con.Close()
                d_Total_Dias = (d_Años_a_Depreciar * d_Dias_x_Año)
                For i As Integer = 0 To Me.cbxTemp_Codigos.Items.Count - 1
                    d_Total_Libras = 0
                    sql = New SqlCommand("select Valor_Libras from Codigos_Concent_Depreciacion where Codigo_Concentrado='" & RTrim(Me.cbxTemp_Codigos.Items(i).ToString) & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        d_Total_Libras = (d_Total_Dias * leer(0))
                    End While
                    con.Close()
                    d_Total_QQ = (d_Total_Libras / 100)
                    sql = New SqlCommand("select Costo_Unitario FROM Costos_Concentrados_x_Mes where Codigo='" & RTrim(Me.cbxTemp_Codigos.Items(i).ToString) & "' and Mes_a_Trabajar='" & o_Mes & FechaSistema.Year.ToString.Substring(2, 2) & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        d_Precio_QQ = leer(0)
                    End While
                    con.Close()
                    d_Total_Alimento_C += (d_Total_QQ * d_Precio_QQ)
                Next
                d_Dosis_Obtenidas = (d_No_Colectas_Anual / d_NoDosis)
                d_Total_Dosis_Años = (d_Dosis_Obtenidas * d_Años_a_Depreciar)
                Depreciacion_Valor_Alimento = (d_Total_Alimento_C / d_Total_Dosis_Años)
            ElseIf DepreciaAlimento = False Then
                Depreciacion_Valor_Alimento = 0
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al Depreciar Verraco", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Return Depreciacion_Valor_Alimento
    End Function
    Public Function DepreciarVerraco_Precio(ByVal Verraco As String) As Double
        Dim Depreciacion_Valor_Precio As Double = 0
        Try
            Dim DepreciaCosto As Boolean
            sql = New SqlCommand("select Se_Deprecia_Costo from Depreciaciones_Verracos where Codigo='" & RTrim(Verraco) & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                DepreciaCosto = leer(0)
            End While
            con.Close()
            If DepreciaCosto = True Then
                Dim d_Años_a_Depreciar, d_Dias_x_Año As Integer
                Dim d_Valor_Compra, d_Valor_Residual, d_Valor_Depreciar, d_Total_Dosis_Años As Double
                Dim d_No_Colectas_Anual As Integer
                Dim d_Dosis_Obtenidas, d_NoDosis As Double
                sql = New SqlCommand("Select * from Depreciaciones_Verracos where Codigo='" & RTrim(Verraco) & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    d_Años_a_Depreciar = leer(2)
                    d_Dias_x_Año = leer(5)
                    d_No_Colectas_Anual = leer(6)
                    d_NoDosis = leer(7)
                    d_Valor_Compra = leer(1)
                    d_Valor_Residual = leer(3)
                End While
                con.Close()
                d_Valor_Depreciar = (d_Valor_Compra - d_Valor_Residual)
                d_Dosis_Obtenidas = (d_No_Colectas_Anual / d_NoDosis)
                d_Total_Dosis_Años = (d_Dosis_Obtenidas * d_Años_a_Depreciar)
                Depreciacion_Valor_Precio = (d_Valor_Depreciar / d_Total_Dosis_Años)
            ElseIf DepreciaCosto = False Then
                Depreciacion_Valor_Precio = 0
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al Depreciar Verraco", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Return Depreciacion_Valor_Precio
    End Function
    Sub ActualizarDpcs()
        Try
            sql = New SqlCommand("ActualizarDepreciaciones_Verracos", con)
            sql.CommandType = CommandType.StoredProcedure
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al actualizar Dpcs", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CellEnter
        Try
            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.BeginEdit(True)
        Catch ex As Exception

        End Try
        'If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.ColumnIndex = 4 Then
        '    If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.IsCurrentCellInEditMode = True Then
        '        FechaCelda = Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(4).Value
        '        Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(4).Value = ""

        '    End If
        'End If
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CellLeave
        Try
            If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.ColumnIndex = 4 Then
                If Not IsDate(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(4).Value) Then
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(4).Value = FechaCelda
                End If
            End If

            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()
            Dim fechaInseminacion As Date = Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("FechaInseminacion2").Value
            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("FechaEstParto2").Value = fechaInseminacion.AddDays(114)
            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(6).Value = Format(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(6).Value, "dd/MM/yy")
            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()

            Fila = Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.RowIndex
            Dim existeVerraco As Boolean = False
            sql = New SqlCommand("select Codigo_Cerdo from REG_VERRACOS where Codigo_Cerdo='" & RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentRow.Cells("Verraco2").Value) & "' And Estado_Actual<>'D' AND Estado_Actual<>'DF'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                existeVerraco = True
            End While
            con.Close()
            If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value <> "" Then
                If existeVerraco = False Then

                    MessageBoxEx.Show("El Código del Verraco que ha ingresado no existe ó no ya ha sido descartado del sistema", "Dato Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(Fila).Cells("Verraco2").Value = "N/V"
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("ADpc").Value = 0.0
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("AAlimentacion").Value = 0.0
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("ACosto_Inyeccion").Value = 0.0
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell = Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Item(3, Fila)

                Else
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()
                    Try
                        sql = New SqlCommand("select Valor_Depreciable from Depreciaciones_Verracos where Codigo='" & RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value) & "'", con)
                        con.Open()
                        leer = sql.ExecuteReader
                        While leer.Read
                            Valor_Depreciable = leer(0)
                        End While
                        con.Close()
                        For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
                            If RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value) = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("Verraco2").Value) Then
                                Valor_Depreciable -= Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("ADpc").Value
                            End If
                        Next
                        For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
                            If RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value) = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("Verraco").Value) Then
                                Valor_Depreciable -= Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("MDpc").Value
                            End If
                        Next

                    Catch ex As Exception
                        MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    Valor_Dpc_Restante = (Valor_Depreciable)
                    Me.LabelX2.Text = Valor_Dpc_Restante
                    If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(3).Value <> "N/V" Then
                        If Valor_Dpc_Restante >= Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value)), 2) Then
                            ' Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("ADpc").Value = Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value)), 2)
                            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("ADpc").Value = 0
                        End If
                        Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("AAlimentacion").Value = 0
                        'Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("AAlimentacion").Value = Math.Round(DepreciarVerraco_Alimento(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value)), 2)
                    Else
                        Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("ADpc").Value = 0
                        Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("AAlimentacion").Value = 0
                        'Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("ADpc").Value = Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value)), 2)
                        'Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("AAlimentacion").Value = Math.Round(DepreciarVerraco_Alimento(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value)), 2)

                    End If
                End If
            End If
            Try
                'Dim Opera As Boolean = False
                If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value <> "N/V" Then
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(9).ReadOnly = True
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(9).Value = (Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("ADpc").Value + Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("AAlimentacion").Value)
                    'Opera = True
                End If
                'MsgBox(Opera)
                If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value = "N/V" Then
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(9).ReadOnly = False
                    'If Opera = True Then
                    'Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(9).Value = 0.0
                    '    Opera = False
                    'End If



                End If

                If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value = "" Then
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells("Verraco2").Value = "N/V"
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(9).ReadOnly = False
                    'If Opera = True Then
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(e.RowIndex).Cells(9).Value = 0.0
                    '    Opera = False
                    'End If


                End If
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'End If
            If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Item(9, e.RowIndex).Style.BackColor = Color.Red And Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Item(9, e.RowIndex).Value > 0 Then
                Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Item(9, e.RowIndex).Style.BackColor = System.Drawing.SystemColors.ActiveCaption
            End If
            'Verificar_Valor_DPC_Abuelas()
            'Verificar_Valor_DPC_Madres()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    'Sub Verificar_Valor_DPC_Abuelas()
    '    For y As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
    '        Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()
    '        Try
    '            sql = New SqlCommand("select Valor_Depreciable from Depreciaciones_Verracos where Codigo='" & RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("Verraco2").Value) & "'", con)
    '            con.Open()
    '            leer = sql.ExecuteReader
    '            While leer.Read
    '                Valor_Depreciable = leer(0)
    '            End While
    '            con.Close()
    '            For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
    '                If RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("Verraco2").Value) = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("Verraco2").Value) Then
    '                    Valor_Depreciable -= Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("ADpc").Value
    '                End If
    '            Next
    '            For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
    '                If RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("Verraco2").Value) = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("Verraco").Value) Then
    '                    Valor_Depreciable -= Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("MDpc").Value
    '                End If
    '            Next
    '        Catch ex As Exception
    '            MessageBoxEx.Show(ex.Message, "Error 1")
    '        End Try
    '        Valor_Dpc_Restante = (Valor_Depreciable)
    '        Me.LabelX2.Text = Valor_Dpc_Restante
    '        If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells(3).Value <> "N/V" Then
    '            If Valor_Dpc_Restante >= Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("Verraco2").Value)), 2) Then
    '                Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("ADpc").Value = Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("Verraco2").Value)), 2)

    '            End If
    '            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("AAlimentacion").Value = Math.Round(DepreciarVerraco_Alimento(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("Verraco2").Value)), 2)
    '        Else
    '            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("ADpc").Value = Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("Verraco2").Value)), 2)
    '            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("AAlimentacion").Value = Math.Round(DepreciarVerraco_Alimento(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(y).Cells("Verraco2").Value)), 2)
    '        End If
    '    Next
    '    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()
    'End Sub
    'Sub Verificar_Valor_DPC_Madres()
    '    For y As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
    '        Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EndEdit()

    '        Try
    '            sql = New SqlCommand("select Valor_Depreciable from Depreciaciones_Verracos where Codigo='" & RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("Verraco").Value) & "'", con)
    '            con.Open()
    '            leer = sql.ExecuteReader
    '            While leer.Read
    '                Valor_Depreciable = leer(0)
    '            End While
    '            con.Close()

    '            For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
    '                If RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("Verraco").Value) = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("Verraco").Value) Then
    '                    Valor_Depreciable -= Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("MDpc").Value
    '                End If
    '            Next
    '            For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
    '                If RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("Verraco").Value) = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("Verraco2").Value) Then
    '                    Valor_Depreciable -= Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("ADpc").Value
    '                End If
    '            Next
    '        Catch ex As Exception

    '        End Try
    '        Valor_Dpc_Restante = (Valor_Depreciable)
    '        Me.LabelX2.Text = Valor_Dpc_Restante
    '        If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells(3).Value <> "N/V" Then
    '            If Valor_Dpc_Restante >= Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("Verraco").Value)), 2) Then
    '                Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("MDpc").Value = Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("Verraco").Value)), 2)
    '            End If
    '            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("MAlimentacion").Value = Math.Round(DepreciarVerraco_Alimento(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("Verraco").Value)), 2)
    '        Else
    '            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("MDpc").Value = Math.Round(DepreciarVerraco_Precio(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("Verraco").Value)), 2)
    '            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("MAlimentacion").Value = Math.Round(DepreciarVerraco_Alimento(RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(y).Cells("Verraco").Value)), 2)
    '        End If
    '    Next
    'End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.DataError
        Dim Error_x As String = e.Exception.Message
        MessageBoxEx.Show(Error_x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
   Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasTableAdapter.Fill(Me.DtsBDGRANJA.Lista_cerdas_montas_para_inseminaciones_Abuelas, Me.cbxLotes.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub rbtMadres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMadres.CheckedChanged
        If Me.selecciono = True Then
            Me.cbxLotes_SelectedIndexChanged(sender, e)
        End If
    End Sub
    Private Sub rbtAbuelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAbuelas.CheckedChanged
        If Me.selecciono = True Then
            Me.cbxLotes_SelectedIndexChanged(sender, e)
        End If
    End Sub
    Sub GrabarInseminaciones_Abuelas()
        Try
            Me.No_Cerdas_que_salen_de_montas_a_Gestaciona = 0
            Dim CostoInseminacionTotal As Double = 0
            For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
                'If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("Inseminada2").Value = True Then
                sql = New SqlCommand("UPDATE REG_ABUELAS SET Estado_Actual='P' WHERE Código_Abuela='" & Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("CodigoCerda2").Value & "'", con)
                con.Open()
                sql.ExecuteReader()
                con.Close()
                sql = New SqlCommand("select MAX(Id_Enseminacion) from Reg_Enseminaciones_x_cerda", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        Me.IdInseminacion = 1
                    Else
                        Me.IdInseminacion = leer(0) + 1
                    End If
                End While
                con.Close()
                sql = New SqlCommand("insert into Reg_Enseminaciones_x_cerda values('" & Me.IdInseminacion & "','" & Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("CodigoCerda2").Value & "','" & True & "','" & Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("Verraco2").Value & "','" & Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("FechaInseminacion2").Value & "','P','" & Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("FechaEstParto2").Value & "','" & Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(9).Value & "','" & Me.txtInseminacionNo.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                Registrar_Estado_Parto(Me.IdInseminacion, False, Me.txtInseminacionNo.Text)

                RegistrarDepreciacionVerraco(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("Verraco2").Value, Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(7).Value, Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(8).Value, FechaSistema, Me.txtInseminacionNo.Text, Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(0).Value, Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(9).Value)
                Dim ID_Dpc As Integer = 0
                sql = New SqlCommand("select max(ID) FROM Historico_Depreciaciones_Verracos", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    ID_Dpc = leer(0)
                End While
                con.Close()

                sql = New SqlCommand("INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & 0 & "','" & Me.cbxLotes.Text & "','" & FechaSistema & "','INYECCIÓN INSEMINACION CON ID DEPRECIACION: " & ID_Dpc & "','" & 1 & "','" & UsuarioActual & "','" & Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(9).Value & "','Ri." & Me.txtInseminacionNo.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()

                InsertarProcesoCerda(Me.IdInseminacion, Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("CodigoCerda2").Value, "Inseminacion", FechaSistema, "Ri." & Me.txtInseminacionNo.Text, cbxLotes.Text, "E")

            Next
            ActualizarDpcs()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al grabar Inseminaciones Cerdas Abuelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub GrabarInseminaciones_Madres()
        Try
            Me.No_Cerdas_que_salen_de_montas_a_Gestaciona = 0
            Dim CostoInseminacionTotal As Double = 0
            For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
                'If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("Inseminada").Value = True Then
                sql = New SqlCommand("UPDATE REG_MADRES SET Estado_Actual='P' WHERE Código_Cerda='" & Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("CodigoCerda").Value & "'", con)
                con.Open()
                sql.ExecuteReader()
                con.Close()
                sql = New SqlCommand("select MAX(Id_Enseminacion) from Reg_Enseminaciones_x_cerda", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(0) = True Then
                        Me.IdInseminacion = 1
                    Else
                        Me.IdInseminacion = leer(0) + 1
                    End If
                End While
                con.Close()
                sql = New SqlCommand("insert into Reg_Enseminaciones_x_cerda values('" & Me.IdInseminacion & "','" & Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("CodigoCerda").Value & "','" & True & "','" & Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("Verraco").Value & "','" & Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("FechaInseminacion").Value & "','P','" & Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("FechaEstParto").Value & "','" & Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(9).Value & "','" & Me.txtInseminacionNo.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                Registrar_Estado_Parto(Me.IdInseminacion, False, Me.txtInseminacionNo.Text)
                ActualizarLote()
                'End If
                RegistrarDepreciacionVerraco(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("Verraco").Value, Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(7).Value, Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(8).Value, FechaSistema, Me.txtInseminacionNo.Text, Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(0).Value, Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(9).Value)
                Dim ID_Dpc As Integer = 0
                sql = New SqlCommand("select max(ID) FROM Historico_Depreciaciones_Verracos", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    ID_Dpc = leer(0)
                End While
                con.Close()

                sql = New SqlCommand("INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & 0 & "','" & Me.cbxLotes.Text & "','" & FechaSistema & "','INYECCIÓN INSEMINACION CON ID DEPRECIACION: " & ID_Dpc & "','" & 1 & "','" & UsuarioActual & "','" & Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(9).Value & "','Ri." & Me.txtInseminacionNo.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                InsertarProcesoCerda(Me.IdInseminacion, Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("CodigoCerda").Value, "Inseminacion", FechaSistema, "Ri." & Me.txtInseminacionNo.Text, cbxLotes.Text, "E")

            Next
            ActualizarDpcs()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al grabar Inseminaciones Cerdas Madres", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim errores As Integer = 0

        For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
            Dim TamañoFecha As String = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(4).Value)
            If TamañoFecha.Length < 8 Then
                errores += 1
                Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(4).Style.BackColor = Color.Red
            Else
                Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(4).Style.BackColor = Nothing
            End If
        Next
        For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
            Dim TamañoFecha As String = RTrim(Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(4).Value)
            If TamañoFecha.Length < 8 Then
                errores += 1
                Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(4).Style.BackColor = Color.Red
            Else
                Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(4).Style.BackColor = Nothing
            End If
        Next
        If errores > 0 Then
            MessageBoxEx.Show("Se encontraron errores de entrada de datos, Corrija las entradas malas y vuelva a intentarlo", "Error Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim HayValoresCero As Boolean = False
            Dim NoSinValores As Integer = 0
            For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
                If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(9).Value = 0 Then
                    HayValoresCero = True
                    NoSinValores += 1
                    Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Item(9, i).Style.BackColor = Color.Red
                End If
            Next
            For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
                If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(9).Value = 0 Then
                    HayValoresCero = True
                    NoSinValores += 1
                    Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(9).Style.BackColor = Color.Red
                End If
            Next
            'If HayValoresCero = True Then
            '    If NoSinValores = 1 Then
            '        MessageBoxEx.Show("Hay una Inseminación sin establer costo inyección", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    ElseIf NoSinValores > 1 Then
            '        MessageBoxEx.Show("Hay Inseminaciones sin establer costo inyección", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)

            '    End If
            'Else
            Dim HayInseminacionMadres As Boolean = False
                Dim HayInseminacionAbuelas As Boolean = False
                'Verificar_Valor_DPC_Madres()
                'Verificar_Valor_DPC_Abuelas()
                For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
                    If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells("Inseminada").Value = True Then
                        HayInseminacionMadres = True
                    End If
                Next
                For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
                    If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells("Inseminada2").Value = True Then
                        HayInseminacionAbuelas = True
                    End If
                Next
                If HayInseminacionAbuelas = True Or HayInseminacionMadres = True Then
                    Me.GrabarInseminaciones_Madres()
                    Me.GrabarInseminaciones_Abuelas()
                    Me.NoInseminacionAuto()
                    btnActualizar_Click(sender, e)
                    btnActualizar_Click(sender, e)
                End If
            End If
        'End If
    End Sub
    Private Sub cbxLotesGestacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SeleccionoLoteGestacion = True
    End Sub
    Private Sub cbxLotesGestacion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SeleccionoLoteGestacion = True
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX_DataError1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.DataError
        Dim Error_x As String = e.Exception.Message
        MessageBoxEx.Show(Error_x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Sub RegistrarDepreciacionVerraco(ByVal Verraco As String, ByVal Dpc_Valor_Precio As Double, ByVal Dpc_Valor_Alimento As Double, ByVal fecha As Date, ByVal Inseminacion_No As Integer, ByVal Cerda As String, ByVal Total_Depreciado As Double)
        Try
            Dim Dpc_No As Integer = 0
            sql = New SqlCommand("select isnull((max(Depreciacion_No)),0) from Historico_Depreciaciones_Verracos where Codigo='" & RTrim(Verraco) & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Dpc_No = leer(0)
            End While
            con.Close()
            sql = New SqlCommand("insert into Historico_Depreciaciones_Verracos (Codigo,Depreciacion_No,Depreciacion_Valor_Precio,Depreciacion_Valor_Alimento,Fecha,Inseminacion_No,Cerda,Total_Depreciado) values('" & Verraco & "','" & (Dpc_No + 1) & "','" & Dpc_Valor_Precio & "','" & Dpc_Valor_Alimento & "','" & fecha & "','" & Inseminacion_No & "','" & Cerda & "','" & Total_Depreciado & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al registrar Depreciacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        If Me.CheckBoxX1.CheckState = CheckState.Checked Then
            With My.Forms.dlgRevision_Inseminaciones_Pendientes_Comprobadas
                .ShowDialog()
            End With
        Else
            With My.Forms.dlgRevision_Inseminaciones_Pendientes_Comprobadas
                .Close()
            End With
        End If
    End Sub
    Private Sub lbRegistros_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbRegistros.TextChanged
        'If Me.lbRegistros.Text = "0" Then
        '    Me.btnGuardar.Enabled = False
        'Else
        '    Me.btnGuardar.Enabled = True
        'End If
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell.ColumnIndex = 3 Then
                With My.Forms.dlgLista_Verracos
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .Madres_o_Abuelas = "MADRES"
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub DataGrid_EditingControlShowing_M(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EditingControlShowing
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
    Private Sub DataGrid_EditingControlShowing_A(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EditingControlShowing
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
    Private Sub CellOnKeyDown_M(ByVal sender As Object, ByVal e As KeyEventArgs)
        Try

            If (e.KeyCode = Keys.F5) Then
                ' Finalizamos la operación de edición de la celda actual
                Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EndEdit()
                If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell.ColumnIndex = 3 Then
                    With My.Forms.dlgLista_Verracos
                        .WindowState = FormWindowState.Normal
                        .StartPosition = FormStartPosition.CenterScreen
                        .Madres_o_Abuelas = "MADRES"
                        .ShowDialog()
                    End With
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub FechaCelda_KeyPress_M(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell.ColumnIndex = 4 Then
                If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) <> 47 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If

            If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CurrentCell.ColumnIndex = 4 Then

                If txtFecha_M.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
                    Me.txtFecha_M.SelectionStart = 3
                ElseIf Me.txtFecha_M.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
                    Me.txtFecha_M.Text = Me.txtFecha_M.Text & "/"
                    Me.txtFecha_M.SelectionStart = 6
                End If

            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FechaCelda_KeyPress_A(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.ColumnIndex = 4 Then

                If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) <> 47 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
               
            End If

            If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.ColumnIndex = 4 Then

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
        Try
            If (e.KeyCode = Keys.F5) Then
                ' Finalizamos la operación de edición de la celda actual
                Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()
                If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.ColumnIndex = 3 Then
                    With My.Forms.dlgLista_Verracos
                        .WindowState = FormWindowState.Normal
                        .StartPosition = FormStartPosition.CenterScreen
                        .Madres_o_Abuelas = "ABUELAS"
                        .ShowDialog()
                    End With
                End If
                
            End If
        Catch ex As Exception
        End Try
    End Sub
   
    Sub EstablerDatosMadres_Abuelas()
        For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows.Count - 1
            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(4).Value = Format(FechaSistema, "dd/MM/yy")
            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.Rows(i).Cells(3).Value = "N/V"
        Next
        For i As Integer = 0 To Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows.Count - 1
            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(4).Value = Format(FechaSistema, "dd/MM/yy")
            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.Rows(i).Cells(3).Value = "N/V"
        Next
    End Sub
    
    Private Sub Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.CurrentCell.ColumnIndex = 3 Then
                With My.Forms.dlgLista_Verracos
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .Madres_o_Abuelas = "ABUELAS"
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.LostFocus
        If Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EditMode = DataGridViewEditMode.EditOnEnter Then
            Me.Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.EndEdit()
            'Verificar_Valor_DPC_Madres()
            'Verificar_Valor_DPC_Abuelas()
        End If
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.LostFocus
        If Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EditMode = DataGridViewEditMode.EditOnEnter Then
            Me.Lista_cerdas_montas_para_inseminaciones_AbuelasDataGridViewX.EndEdit()
            'Verificar_Valor_DPC_Abuelas()
            'Verificar_Valor_DPC_Madres()
        End If
    End Sub
    Private Sub Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_cerdas_montas_para_inseminaciones_MadresDataGridViewX.CellContentClick

    End Sub
End Class