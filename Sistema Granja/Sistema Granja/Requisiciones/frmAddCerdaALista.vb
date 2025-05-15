Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmAddCerdaALista
    Dim oDtsRequisiciones As New dtsRequisiciones
    Dim vListaCerdasTableAdapter As New dtsRequisicionesTableAdapters.vListaCerdasTableAdapter
    Public req_no As Integer
    Public corr_gen As Integer
    Public opcion As String
    Dim Lineas_de_Requisiciones_CerdasTableAdapter As New dtsRequisicionesTableAdapters.Lineas_de_Requisiciones_CerdasTableAdapter
    Private Sub CancelarButtonX1_Click(sender As Object, e As EventArgs) Handles CancelarButtonX1.Click

        Me.Close()
    End Sub
    Sub cargar(buscar As String)
        Try
            vListaCerdasTableAdapter.Fill(oDtsRequisiciones.vListaCerdas, Trim(buscar))
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = oDtsRequisiciones.vListaCerdas
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmAddCerdaALista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles buscarTextBoxX1.TextChanged

    End Sub

    Private Sub TextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles buscarTextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargar(Me.buscarTextBoxX1.Text)
        End If
    End Sub

    Private Sub aceptarButtonX2_Click(sender As Object, e As EventArgs) Handles aceptarButtonX2.Click
        Try
            Dim codigocerda As String = ""
            If Me.DataGridViewX1.CurrentRow.Cells("Tipo").Value = "Madre" Then
                codigocerda = "RM;" & Me.DataGridViewX1.CurrentRow.Cells("Codigo_Cerda").Value
            ElseIf Me.DataGridViewX1.CurrentRow.Cells("Tipo").Value = "Abuela" Then
                codigocerda = "RA;" & Me.DataGridViewX1.CurrentRow.Cells("Codigo_Cerda").Value
            End If
            If Lineas_de_Requisiciones_CerdasTableAdapter.GetExisteCerda(req_no, corr_gen, codigocerda) > 0 Then
                MessageBoxEx.Show("El código de la cerda " & Me.DataGridViewX1.CurrentRow.Cells("Codigo_Cerda").Value & " ya esta en la lista, favor validar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Lineas_de_Requisiciones_CerdasTableAdapter.Insertar(req_no, corr_gen, codigocerda, 0, 0, 0, opcion, Me.DataGridViewX1.CurrentRow.Cells("Lote_No").Value)

                'With oDtsRequisiciones.Lineas_de_Requisiciones_Cerdas
                '    .Req_NoColumn.DefaultValue = req_no
                '    .Corr_GenColumn.DefaultValue = corr_gen
                '    .Lote_NoColumn.DefaultValue = Me.DataGridViewX1.CurrentRow.Cells("Lote_No").Value
                '    .Linea_NoColumn.DefaultValue = 0
                '    .Gen_DescripcionColumn.DefaultValue = opcion
                '    .Codigo_CerdoColumn.DefaultValue = codigocerda
                '    .CantidadColumn.DefaultValue = 0
                '    .ExcluirColumn.DefaultValue = 0
                'End With
                'frmListaCerdasLactancia.DataGridViewX1.Rows.Add(codigocerda, Me.DataGridViewX1.CurrentRow.Cells("Lote_No").Value, 0, 0)

                frmListaCerdasLactancia.cargarlista()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class