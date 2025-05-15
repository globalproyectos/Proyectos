Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports DevComponents
Imports System.Data.SqlClient
Imports System.Data
Public Class ListaProductos
    Inherits DevComponents.DotNetBar.Office2007Form
    Public ventanallama As String
    Sub mostrar_productos()
        Try
            sql = New SqlCommand("select Codigo, Descripcion from inventario_materiales", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Código"))
                .Add(New DataColumn("Descripción"))
              
            End With

            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    MessageBoxEx.Show("No hay ningun producto registrado", "Lista de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer(1)
                   
                    dt.Rows.Add(dr)
                End If
            End While
            dv = New DataView(dt)
            Me.DgvResultados.DataSource = dv
            con.Close()
            Me.lbResultados.Text = Me.DgvResultados.Rows.Count - 1
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error Recuperando Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ListaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mostrar_productos()
        Me.DgvResultados.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
        Me.DgvResultados.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark
        Me.DgvResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.DgvResultados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DgvResultados.DefaultCellStyle.Font = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)
        Me.DgvResultados.DefaultCellStyle.BackColor = Color.Empty
        Me.DgvResultados.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
        Me.DgvResultados.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Me.DgvResultados.GridColor = SystemColors.ControlDarkDark

        Me.DgvResultados.Columns(0).Width = 77
        Me.DgvResultados.Columns(1).Width = 360
 
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.Focus()
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                seleccionar()
            End If
        Catch ex As Exception
            Dim resp As New MsgBoxResult
            resp = MessageBoxEx.Show("No hay resultados de Búsqueda, por lo tanto no hay ningún código seleccionado, desea cancelar la búsqueda", "Selección de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If resp = MsgBoxResult.Yes Then
                Me.Close()
            Else
                Me.txtDescripcion.SelectAll()
                Me.txtDescripcion.Focus()
            End If
        End Try
    End Sub
    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Me.txtDescripcion.Text = UCase(Me.txtDescripcion.Text)
        Me.txtDescripcion.SelectionStart = 60
        Try

      
            sql = New SqlCommand("select Codigo, Descripcion from inventario_materiales where Descripcion like '%" & Me.txtDescripcion.Text & "%'", con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("Código"))
                .Add(New DataColumn("Descripción"))
            End With
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    MessageBoxEx.Show("No hay ningun producto registrado", "Lista de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dr = dt.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer(1)
                    dt.Rows.Add(dr)
                End If
            End While
            dv = New DataView(dt)
            Me.DgvResultados.DataSource = dv
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Me.lbResultados.Text = Me.DgvResultados.Rows.Count - 1
    End Sub
    Sub seleccionar()
        If ventanallama = "requisicion" Then
            My.Forms.REQUISICIONES.txtCodigo.Text = Me.DgvResultados.CurrentRow.Cells("Código").Value
            Me.Close()
        ElseIf ventanallama = "reportekardex" Then
            My.Forms.frmReporteKardex.codigoTextBoxX1.Text = Me.DgvResultados.CurrentRow.Cells("Código").Value
            Me.Close()
        ElseIf ventanallama = "reqbasetabla" Then
            My.Forms.frmRequisarBaseTablaEngordes.codigoprodTextBoxX4.Text = Me.DgvResultados.CurrentRow.Cells("Código").Value
            Me.Close()
        ElseIf ventanallama = "salidafarmacos" Then
            My.Forms.frmSalidasFarmacos.codigoTextBoxX1.Text = Me.DgvResultados.CurrentRow.Cells("Código").Value
            Me.Close()
        ElseIf ventanallama = "repconsolidadoexistencias" Then
            My.Forms.frmRepConsolidadoExistencias.codigoTextBoxX1.Text = Me.DgvResultados.CurrentRow.Cells("Código").Value
            Me.Close()
        End If
    End Sub
    Private Sub DgvResultados_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvResultados.CellContentDoubleClick
        Try
            seleccionar()
        Catch ex As Exception
            Dim resp As New MsgBoxResult
            resp = MessageBoxEx.Show("No hay resultados de Búsqueda, por lo tanto hay ningun código seleccionado, desea cancelar la búsqueda", "Selección de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If resp = MsgBoxResult.Yes Then
                Me.Close()
            Else
                Me.txtDescripcion.SelectAll()
                Me.txtDescripcion.Focus()
            End If
        End Try
    End Sub
    Public Function Seleccionar_fn() As String
        Dim descripcion As String


        descripcion = Me.DgvResultados.CurrentRow.Cells("Código").Value
        If descripcion.Length = 0 Then
            descripcion = "SIN RESULTADO"
        End If
        Return descripcion
        Me.Close()
    End Function
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            seleccionar()

        Catch ex As Exception
            Dim resp As New MsgBoxResult
            resp = MessageBoxEx.Show("No hay resultados de Búsqueda, por lo tanto hay ningun código seleccionado, desea cancelar la búsqueda", "Selección de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If resp = MsgBoxResult.Yes Then
                Me.Close()
            Else
                Me.txtDescripcion.SelectAll()
                Me.txtDescripcion.Focus()
            End If
        End Try
    End Sub

    Private Sub DgvResultados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DgvResultados.KeyPress
        
        Try
            If e.KeyChar = "S" Or e.KeyChar = "s" Then

                seleccionar()
            End If
        Catch ex As Exception
            Dim resp As New MsgBoxResult
            resp = MessageBoxEx.Show("No hay resultados de Búsqueda, por lo tanto hay ningun código seleccionado, desea cancelar la búsqueda", "Selección de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If resp = MsgBoxResult.Yes Then
                Me.Close()
            Else
                Me.txtDescripcion.SelectAll()
                Me.txtDescripcion.Focus()
            End If
        End Try
    End Sub
    Private Sub DgvResultados_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvResultados.RowLeave
        con.Close()
        Try
            sql = New SqlCommand("select Unidad,Peso,Costo_Unitario,Etapa,Unidad_x_Presentacion from inventario_materiales where Codigo='" & Me.DgvResultados.CurrentRow.Cells("Código").Value & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.txtUnidad.Text = leer(0)
                Me.txtPeso.Text = leer(1)
                Me.txtCosto.Text = leer(2)
                Me.txtEtapa.Text = leer(3)
                Me.txtUnidadXPrentacion.Text = leer(4)
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub txtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCosto.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtEtapa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEtapa.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidad.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtUnidadXPrentacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidadXPrentacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub DgvResultados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvResultados.CellContentClick

    End Sub
End Class