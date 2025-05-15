Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class frmPesosCerdosProcesos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim dtsPesos As New dtsPesosCerdosProcesos
    Dim PesosPorCerdoAdapter As New dtsPesosCerdosProcesosTableAdapters.PesosPorCerdoProcesosTableAdapter
    Dim listarPesosAdapter As New dtsPesosCerdosProcesosTableAdapters.Proc_ListarPartosDestetesParaPesoTableAdapter
    Dim bsPesosPorCerdo As New BindingSource
    Dim cnx As New SqlClient.SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
    Dim _rowindex As Integer
    Private Sub frmPesosCerdosProcesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsPesosCerdosProcesos.Sexo' Puede moverla o quitarla según sea necesario.
        Me.procesoComboBoxEx1.Text = "Partos"
        Me.SexoTableAdapter.Fill(Me.DtsPesosCerdosProcesos.Sexo)
        Me.desdeDateTimeInput1.Text = FechaSistema
        Me.hastaDateTimeInput2.Text = FechaSistema
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Sub cargar()
        Try
            Me.Cursor = Cursors.WaitCursor
            listarPesosAdapter.Fill(dtsPesos.Proc_ListarPartosDestetesParaPeso, procesoComboBoxEx1.Text, desdeDateTimeInput1.Text, hastaDateTimeInput2.Text, If(Me.criterioSwitchButton1.Value = True, "SIN PESO", "TODOS"))
            Me.listaDataGridViewX1.AutoGenerateColumns = False
            Me.listaDataGridViewX1.DataSource = dtsPesos.Proc_ListarPartosDestetesParaPeso

            'Dim ProgressBarItem As New DataGridViewProgressBarXColumn
            'Dim porcentaje As String = ""
            'porcentaje = Me.listaDataGridViewX1.Rows(0).Cells("vacio").Value & "%"
            'Me.listaDataGridViewX1.Rows(0).Cells("vacio").Value = 2


            'ProgressBarItem = CType(Me.listaDataGridViewX1.Rows(0).Cells("vacio").OwningColumn, DataGridViewProgressBarXColumn)
            'ProgressBarItem.Text = 2

            ''Dim temp As New Double
            ''temp = 0
            ''For i As Integer = 0 To Me.listaDataGridViewX1.Rows.Count - 1
            ''    Dim porcentaje As String = ""
            ''    Dim ProgressBarItem As New DataGridViewProgressBarXColumn
            ''    porcentaje = Me.listaDataGridViewX1.Rows(i).Cells("Completado").Value & "%"


            ''    'ProgressBarItem = CType(Me.listaDataGridViewX1.Rows(i).Cells("Completado").OwningColumn, DataGridViewProgressBarXColumn)
            ''    ProgressBarItem = CType(Me.listaDataGridViewX1.Rows(i).Cells("Completado").OwningColumn, DataGridViewProgressBarXColumn)
            ''    'ProgressBarItem.Text = porcentaje
            ''    ProgressBarItem.Text = CType(Me.listaDataGridViewX1.Rows(i).Cells("Completado").Value, Double).ToString

            ''    'Me.listaDataGridViewX1.Rows(i).Cells("vacio").Value = CType(Me.listaDataGridViewX1.Rows(0).Cells("Completado").Value, Double)
            ''    Me.listaDataGridViewX1.Rows(i).Cells("vacio").Value = CType(Me.listaDataGridViewX1.Rows(i).Cells("Completado").Value, Double)


            ''Next

            Me.Cursor = Cursors.Arrow
            ''Me.listaDataGridViewX1.Rows(0).Cells("Completado").Value = 9


        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        cargar()
    End Sub

    Private Sub listaDataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaDataGridViewX1.CellContentClick
        If Me.listaDataGridViewX1.CurrentCell.ColumnIndex = 6 Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("¿Desea registrar los pesos de los cerdos de la cerda " & Me.listaDataGridViewX1.CurrentRow.Cells("Codigo").Value & "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then

                If Me.pesosDataGridViewX2.Rows.Count > 0 Then
                    guardarcambios()
                    actualizarpeso()
                End If
                _rowindex = Me.listaDataGridViewX1.CurrentCell.RowIndex
                Try
                    Dim cmd As New SqlClient.SqlCommand("Proc_GenerarEntradaPesosCerdosProceso", cnx)

                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@IdInseminacion", SqlDbType.Int).Value = listaDataGridViewX1.CurrentRow.Cells("Id_Inseminacion").Value
                    cmd.Parameters.Add("@codigo", SqlDbType.Char, 8).Value = listaDataGridViewX1.CurrentRow.Cells("codigo").Value
                    cmd.Parameters.Add("@proceso", SqlDbType.NChar, 15).Value = Trim(Me.procesoComboBoxEx1.Text)
                    cmd.Parameters.Add("@fechasistema", SqlDbType.DateTime).Value = FechaSistema
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = UsuarioActual
                    cmd.Parameters.Add("@correlativoPartoNo", SqlDbType.Int).Value = listaDataGridViewX1.CurrentRow.Cells("correlativoparto").Value

                    cnx.Open()
                    cmd.ExecuteNonQuery()
                    cnx.Close()

                    PesosPorCerdoAdapter.Fill(dtsPesos.PesosPorCerdoProcesos, listaDataGridViewX1.CurrentRow.Cells("Id_Inseminacion").Value)
                    Me.pesosDataGridViewX2.AutoGenerateColumns = False
                    bsPesosPorCerdo.DataSource = dtsPesos.PesosPorCerdoProcesos
                    Me.pesosDataGridViewX2.DataSource = bsPesosPorCerdo.DataSource

                    contar()
                    Dim totalpeso_ As Double
                    For i As Integer = 0 To Me.pesosDataGridViewX2.Rows.Count - 1
                        totalpeso_ += Me.pesosDataGridViewX2.Rows(i).Cells("Peso").Value
                    Next
                    Me.listaDataGridViewX1.Rows(_rowindex).Cells("TotalPeso").Value = totalpeso_
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If cnx.State = ConnectionState.Open Then
                        cnx.Close()
                    End If
                End Try


            End If
        End If

    End Sub


    Private Sub pesosDataGridViewX2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles pesosDataGridViewX2.CellEnter
        contar()
        guardarcambios()
        actualizarpeso()

        Dim totalpeso_ As Double
        For i As Integer = 0 To Me.pesosDataGridViewX2.Rows.Count - 1
            totalpeso_ += Me.pesosDataGridViewX2.Rows(i).Cells("Peso").Value
        Next
        Me.listaDataGridViewX1.Rows(_rowindex).Cells("TotalPeso").Value = totalpeso_
    End Sub
    Sub actualizarpeso()
        Try
            Dim cmd As New SqlClient.SqlCommand("Proc_ActualizaPesoPorIdInseminacion", cnx)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdInseminacion", SqlDbType.Int).Value = listaDataGridViewX1.Rows(_rowindex).Cells("Id_Inseminacion").Value
            cmd.Parameters.Add("@proceso", SqlDbType.NChar, 15).Value = Trim(Me.procesoComboBoxEx1.Text)
            cmd.Parameters.Add("@codigo", SqlDbType.Char, 8).Value = listaDataGridViewX1.Rows(_rowindex).Cells("codigo").Value

            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()


        Catch ex As Exception
            MessageBoxEx.Show(ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
    End Sub


    Private Sub pesosDataGridViewX2_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles pesosDataGridViewX2.CellLeave
        actualizarpeso()
    End Sub
    Sub guardarcambios()
        Try
            bsPesosPorCerdo.EndEdit()
            PesosPorCerdoAdapter.Update(dtsPesos.PesosPorCerdoProcesos)


        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        guardarcambios()
        actualizarpeso()
        MessageBoxEx.Show("Cambios aplicados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub pesosDataGridViewX2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles pesosDataGridViewX2.CellContentClick

    End Sub

    Private Sub pesosDataGridViewX2_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles pesosDataGridViewX2.RowEnter
        'Dim cell As DataGridViewCell = pesosDataGridViewX2.Rows(e.RowIndex).Cells(2)

        'pesosDataGridViewX2.CurrentCell = cell
    End Sub
    Sub contar()
        Dim f As Integer, m As Integer, totalpeso As Double, pesocero As Integer
        For i As Integer = 0 To Me.pesosDataGridViewX2.Rows.Count - 1
            totalpeso += Me.pesosDataGridViewX2.Rows(i).Cells(2).Value
            If Me.pesosDataGridViewX2.Rows(i).Cells(3).Value = "F" Then
                f += 1
            ElseIf Me.pesosDataGridViewX2.Rows(i).Cells(3).Value = "M" Then
                m += 1
            End If
            If Me.pesosDataGridViewX2.Rows(i).Cells("Peso").Value > 0 Then
                pesocero += 1
            End If

        Next
        Me.totallineasTextBoxX1.Text = Me.pesosDataGridViewX2.Rows.Count
        Me.totalpesoTextBoxX2.Text = totalpeso
        Me.totalsexoTextBoxX3.Text = "M(" & CStr(m) & "), F(" & CStr(f) & ")"
        Me.listaDataGridViewX1.Rows(_rowindex).Cells("Completado").Value = CInt(Val(pesocero) / Val(Me.listaDataGridViewX1.Rows(_rowindex).Cells("NoVivos").Value) * 100)

    End Sub
    Private Sub criterioSwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles criterioSwitchButton1.ValueChanged
        cargar()
    End Sub
    Private Sub pesosDataGridViewX2_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles pesosDataGridViewX2.RowLeave
        If pesosDataGridViewX2.Rows(e.RowIndex).Cells("Peso").Value > 0 Then
            guardarcambios()
            actualizarpeso()
        End If

    End Sub

    'Private Sub listaDataGridViewX1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles listaDataGridViewX1.DataBindingComplete
    '    For i As Integer = 0 To Me.listaDataGridViewX1.Rows.Count - 1

    '    Next
    'End Sub
    
    
    
End Class