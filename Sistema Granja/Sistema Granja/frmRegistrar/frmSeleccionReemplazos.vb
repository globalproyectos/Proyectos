Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmSeleccionReemplazos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim existencia_e As Integer = 0
    Dim claseHatoReprodAdapter As New DtsBDGRANJATableAdapters.ClasesHatosReprodTableAdapter
    Private Sub frmSeleccionReemplazos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarlotese()
        ActualizarLotes()
        cargarClasesHatoReprod()
    End Sub
    Sub mostrarlotese()
        Try
            Me.cbxLotes.Items.Clear()
            sql = New SqlCommand("select Lote_No from lotes where IdEtapa_Cerdas='E' and Estado='A' order by Lote_No", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotes.Items.Add(RTrim(leer(0)))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub cbxLotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLotes.SelectedIndexChanged

        
    End Sub
    Sub ActualizarLotes()
        Try
            sql = New SqlCommand("ActualizarLotes", con)
            sql.CommandType = CommandType.StoredProcedure
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim existe_lote As Boolean = False
        sql = New SqlCommand("select Lote_No from Lotes where IdEtapa_Cerdas='E'  and Estado='A' and Lote_No='" & RTrim(Me.cbxLotes.Text) & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            existe_lote = True
        End While
        con.Close()

        Try

            sql = New SqlCommand("select Total_Cerdos from Total_Cerdos_Lote where Lote_No='" & RTrim(Me.cbxLotes.Text) & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                existencia_e = leer(0)
            End While
            con.Close()

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

        If existe_lote = False Then
            MessageBoxEx.Show("El lote que ha ingresado no existe ó ya ha sido cerrado", "Lote erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cbxLotes.Focus()
        ElseIf Val(Me.txtCantidad.Text) = 0 Then
            MessageBoxEx.Show("No ha ingresado la cantidad de reemplazos a seleccionar", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtCantidad.Focus()
        ElseIf Val(Me.txtCantidad.Text) > existencia_e Then
            MessageBoxEx.Show("La cantidad que ha ingresado excede el total actual, el total actual es de: " & existencia_e & " cerdos/as", "Cantidad Excedida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtCantidad.Focus()
        Else
            'Try
            sql = New SqlCommand("Sr_Reemplazos", con)
                sql.CommandType = CommandType.StoredProcedure
                sql.Parameters.Add(New SqlParameter("@DeLote", SqlDbType.Char, 8)).Value = RTrim(Me.cbxLotes.Text)
                sql.Parameters.Add(New SqlParameter("@NoReemp_a_Sacar", SqlDbType.Int)).Value = Val(Me.txtCantidad.Text)
                sql.Parameters.Add(New SqlParameter("@Clasificacion", SqlDbType.Char, 2)).Value = Me.clasificacionComboBoxEx1.SelectedValue
                dt = New DataTable
                With dt.Columns
                    .Add(New DataColumn("No."))
                    .Add(New DataColumn("Código Cerda"))
                    .Add(New DataColumn("Cósto Reeemplazo"))
                End With
                con.Open()
                leer = sql.ExecuteReader

                While leer.Read
                    dr = dt.NewRow
                    dr(0) = dt.Rows.Count + 1
                    dr(1) = RTrim(leer(0))
                    dr(2) = RTrim(leer(1))
                    dt.Rows.Add(dr)
                End While
                con.Close()
                Me.DataGridViewX1.DataSource = dt
                With Me.DataGridViewX1
                    .Columns(0).Width = 40
                    .Columns(1).Width = 90
                    .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .Columns(2).DefaultCellStyle.Format = "C2"
                    .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End With
                ActualizarLotes()
                MessageBoxEx.Show("Se efectuo la selección de reemplazos exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cbxLotes.Text = ""
                Me.txtCantidad.Text = 0
                cargarClasesHatoReprod()
            'Catch ex As Exception
            '    MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    con.Close()
            'End Try
        End If
    End Sub
    Sub cargarClasesHatoReprod()
        Try
            Me.clasificacionComboBoxEx1.DataSource = claseHatoReprodAdapter.GetData
            Me.clasificacionComboBoxEx1.DisplayMember = "Descripcion"
            Me.clasificacionComboBoxEx1.ValueMember = "IdClase"
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar Clases H. Reprod.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class