Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmListaCerdasLactancia
    Inherits DevComponents.DotNetBar.Office2007Form
    Public req_no As Integer
    Public corr_gen As Integer
    Public opcion As String
    Dim oDtsRequisiciones As New dtsRequisiciones
    Dim Lineas_de_Requisiciones_CerdasTableAdapter As New dtsRequisicionesTableAdapters.Lineas_de_Requisiciones_CerdasTableAdapter
    Public bsListaCerdas As New BindingSource
    Dim cerrar_desde As String = ""
    Public existencia As Double
    Private Sub frmListaCerdasLactancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.infoLabelX1.Text = "Req. No. " & req_no & ", Corr. Gen. " & corr_gen & ", Opción " & opcion
        cargarlista()
        totalizar()
    End Sub
    Public Sub cargarlista()
        Try
            Lineas_de_Requisiciones_CerdasTableAdapter.Fill(oDtsRequisiciones.Lineas_de_Requisiciones_Cerdas, req_no, corr_gen)
            bsListaCerdas.DataSource = oDtsRequisiciones.Lineas_de_Requisiciones_Cerdas


            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsListaCerdas
            totalizar()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cancelar()
        REQUISICIONES.Completo_Operacion = False
        REQUISICIONES.txtCodigo.Text = ""

        Try

            Dim cmd As New SqlCommand("p_generar_lista_cerdas_alimentar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Req_No", SqlDbType.Int).Value = CInt(Val(req_no))
            cmd.Parameters.Add("@Corr_Gen", SqlDbType.Int).Value = corr_gen
            cmd.Parameters.Add("@Gen_Descripcion", SqlDbType.NVarChar, 50).Value = opcion
            cmd.Parameters.Add("@Fecha_Digitacion", SqlDbType.DateTime).Value = FechaSistema
            cmd.Parameters.Add("@Accion", SqlDbType.NVarChar, 1).Value = "L"
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Me.Close()
    End Sub
    Private Sub CancelarButtonX1_Click(sender As Object, e As EventArgs) Handles CancelarButtonX1.Click
        cerrar_desde = "boton"
        Dim resp As MsgBoxResult = MessageBoxEx.Show("¿Confirma que desea cancelar el proceso?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = MsgBoxResult.Yes Then
            cancelar()

        End If

    End Sub
    Sub totalizar()
        Dim totalcantidad As Double, total_exclusiones As Integer, total_cerdas As Integer
        For i As Integer = 0 To Me.DataGridViewX1.RowCount - 1
            totalcantidad += CDbl(Val(Me.DataGridViewX1.Rows(i).Cells("Cantidad").Value))
            If Me.DataGridViewX1.Rows(i).Cells("Excluir").Value = True Then
                total_exclusiones += 1
            End If
        Next
        Me.totalcantidadLabel2.Text = totalcantidad
        total_cerdas = Me.DataGridViewX1.Rows.Count
        Me.totalexcluidasLabel5.Text = total_exclusiones
        Me.totalcerdasLabel3.Text = total_cerdas
        If CDbl(Me.totalcantidadLabel2.Text) > existencia Then
            Me.existenciaMsjLabelX1.Text = "La cantidad ingresada execede los " & existencia & " de existencia"
        Else
            Me.existenciaMsjLabelX1.Text = ""
        End If
    End Sub
    Private Sub DataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        totalizar()
    End Sub
    Private Sub DataGridViewX1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        totalizar()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles aceptarButtonX2.Click
        totalizar()
        Dim resp As MsgBoxResult = MessageBoxEx.Show("¿Confirma que la cantidad distribuida de: " & Me.totalcantidadLabel2.Text & " QQ.  ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = MsgBoxResult.Yes Then
            Try
                For i As Integer = 0 To Me.DataGridViewX1.RowCount - 1
                    Dim excluir As Boolean = False
                    With Me.DataGridViewX1.Rows(i)
                        If .Cells("Cantidad").Value > 0 Then
                            excluir = False
                        Else
                            excluir = True
                        End If
                        Lineas_de_Requisiciones_CerdasTableAdapter.Actualizar(.Cells("Cantidad").Value, excluir, 0, req_no, corr_gen, .Cells("Codigo_Cerda").Value)
                    End With
                Next
                REQUISICIONES.txtCantidad.Text = Me.totalcantidadLabel2.Text
                cerrar_desde = "boton"
                Me.Close()
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
    Private Sub frmListaCerdasLactancia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cerrar_desde <> "boton" Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("¿Confirma que desea cancelar el proceso?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                cancelar()
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub existenciaMsjLabelX1_Click(sender As Object, e As EventArgs) Handles existenciaMsjLabelX1.Click

    End Sub

    Private Sub existenciaMsjLabelX1_TextChanged(sender As Object, e As EventArgs) Handles existenciaMsjLabelX1.TextChanged
        If Me.existenciaMsjLabelX1.Text <> "" Then
            Me.aceptarButtonX2.Enabled = False
        Else
            Me.aceptarButtonX2.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With frmAddCerdaALista
            bsListaCerdas.EndEdit()
            Lineas_de_Requisiciones_CerdasTableAdapter.Update(oDtsRequisiciones.Lineas_de_Requisiciones_Cerdas)
            .req_no = req_no
            .corr_gen = corr_gen
            .buscarTextBoxX1.Text = ""
            .opcion = opcion
            .ShowDialog()
        End With
    End Sub
End Class