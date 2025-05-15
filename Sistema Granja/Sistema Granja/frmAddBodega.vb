Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmAddBodega
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim ManejaVapor As Boolean
    Dim Activa As Boolean
    Dim ExisteBodega As Boolean
    Dim Bodega As String
    Dim codBodega As String
    Dim descGranja As String
    Sub Limpiar()
        Me.txtBodega.Clear()
        Me.txtCtaCostos.Clear()
        Me.txtCtaInventario.Clear()
        Me.txtCtaVentas.Clear()
        Me.txtDescripción.Clear()
        Me.txtFacturar.Clear()
        Me.txtLiquidador.Clear()
        Me.txtVendedor.Clear()
        Me.txtCodGranja.Clear()
        Me.cbxActivaSi.CheckState = CheckState.Unchecked
        Me.cbxNo.CheckState = CheckState.Unchecked
        Me.cbxManejaVaporSi.CheckState = CheckState.Unchecked
        Me.cbxManejaVaporNo.CheckState = CheckState.Unchecked
    End Sub
    Sub Guardar()
        Try
            If Me.cbxActivaSi.CheckState = CheckState.Checked Then
                Me.Activa = True
            ElseIf Me.cbxNo.CheckState = CheckState.Checked Then
                Me.Activa = False
            End If
            If Me.cbxManejaVaporSi.CheckState = CheckState.Checked Then
                Me.ManejaVapor = True
            ElseIf Me.cbxManejaVaporNo.CheckState = CheckState.Checked Then
                Me.ManejaVapor = False
            End If
            sql = New SqlCommand("insert into BODEGAS values('" & Me.txtBodega.Text & "','" & Me.txtDescripción.Text & "','" & Me.txtFacturar.Text & "','" & Me.txtCtaVentas.Text & "','" & Me.txtCtaCostos.Text & "','" & Me.txtCtaInventario.Text & "','" & Me.txtVendedor.Text & "','" & Me.Activa & "','" & Me.txtLiquidador.Text & "','" & Me.ManejaVapor & "','" & Me.txtCodGranja.Text & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            Me.Limpiar()
            Me.txtBodega.Focus()
            Me.txtDescripción.Enabled = False
            Me.txtCtaCostos.Enabled = False
            Me.txtCtaInventario.Enabled = False
            Me.txtVendedor.Enabled = False
            Me.txtCtaVentas.Enabled = False
            Me.txtFacturar.Enabled = False
            Me.txtLiquidador.Enabled = False
            Me.cbxActivaSi.Enabled = False
            Me.cbxNo.Enabled = False
            Me.cbxManejaVaporSi.Enabled = False
            Me.cbxManejaVaporNo.Enabled = False
        Catch ex1 As System.Data.SqlClient.SqlException
            MessageBoxEx.Show("Se ha producido un error al intentar guardar la información, revise que el código de bodega que ha ingresado no este duplicado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
            Me.txtBodega.Focus()
            
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

  
    Private Sub cbxActivaSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxActivaSi.CheckedChanged
        If Me.cbxActivaSi.CheckState = CheckState.Checked Then
            Me.cbxNo.CheckState = CheckState.Unchecked
        ElseIf Me.cbxNo.CheckState = CheckState.Checked Then
            Me.cbxActivaSi.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub cbxNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxNo.CheckedChanged
        If Me.cbxNo.CheckState = CheckState.Checked Then
            Me.cbxActivaSi.CheckState = CheckState.Unchecked
        ElseIf Me.cbxActivaSi.CheckState = CheckState.Checked Then
            Me.cbxNo.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub cbxManejaVaporSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxManejaVaporSi.CheckedChanged
        If Me.cbxManejaVaporSi.CheckState = CheckState.Checked Then
            Me.cbxManejaVaporNo.CheckState = CheckState.Unchecked
        ElseIf Me.cbxManejaVaporNo.CheckState = CheckState.Checked Then
            Me.cbxManejaVaporSi.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub cbxManejaVaporNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxManejaVaporNo.CheckedChanged
        If Me.cbxManejaVaporNo.CheckState = CheckState.Checked Then
            Me.cbxManejaVaporSi.CheckState = CheckState.Unchecked
        ElseIf Me.cbxManejaVaporSi.CheckState = CheckState.Checked Then
            Me.cbxManejaVaporNo.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        If Me.txtBodega.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el Código de la bodega, este campo es obligatorio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtBodega.Focus()
        ElseIf Me.txtDescripción.Text = "" Then
            MessageBoxEx.Show("No ha ingresado la descripción de la bodega, este campo es obligatorio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtDescripción.Focus()
        ElseIf Me.txtLiquidador.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el liquidador de la bodega, este campo es obligatorio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtLiquidador.Focus()
        ElseIf Me.txtCodGranja.Text = "" Then
            MessageBoxEx.Show("No ha ingresado la bodega, este campo es obligatorio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtLiquidador.Focus()
        Else
            Me.Guardar()


        End If
    End Sub

    Private Sub txtDescripción_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripción.LostFocus
        Me.txtDescripción.Text = UCase(Me.txtDescripción.Text)
    End Sub

    Private Sub txtFacturar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturar.LostFocus
        Me.txtFacturar.Text = UCase(Me.txtFacturar.Text)
    End Sub

    Private Sub txtLiquidador_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLiquidador.LostFocus
        Me.txtLiquidador.Text = UCase(Me.txtLiquidador.Text)
    End Sub
    Private Sub txtBodega_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBodega.LostFocus
        ExisteBodega = False
        sql = New SqlCommand("select Bodega, Descripcion from BODEGAS where Bodega='" & Me.txtBodega.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            ExisteBodega = True
            Bodega = leer(1)
        End While
        con.Close()
        If Me.ExisteBodega = True Then
            MessageBoxEx.Show("El Código de la bodega que ha ingresado ya a sido asignado a la Bodega: " & Me.Bodega, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtBodega.Focus()
            Me.txtDescripción.Enabled = False
            Me.txtCtaCostos.Enabled = False
            Me.txtCtaInventario.Enabled = False
            Me.txtVendedor.Enabled = False
            Me.txtCtaVentas.Enabled = False
            Me.txtFacturar.Enabled = False
            Me.txtLiquidador.Enabled = False
            Me.cbxActivaSi.Enabled = False
            Me.txtCodGranja.Enabled = False
            Me.cbxNo.Enabled = False
            Me.cbxManejaVaporSi.Enabled = False
            Me.cbxManejaVaporNo.Enabled = False
        ElseIf Me.ExisteBodega = False Then
            Me.txtDescripción.Enabled = True
            Me.txtCtaCostos.Enabled = True
            Me.txtCtaInventario.Enabled = True
            Me.txtCtaVentas.Enabled = True
            Me.txtFacturar.Enabled = True
            Me.txtLiquidador.Enabled = True
            Me.cbxActivaSi.Enabled = True
            Me.cbxNo.Enabled = True
            Me.txtVendedor.Enabled = True
            Me.txtCodGranja.Enabled = True
            Me.cbxManejaVaporSi.Enabled = True
            Me.cbxManejaVaporNo.Enabled = True
            Me.txtDescripción.Focus()
        End If

    End Sub
    Private Sub txtCodGranja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub txtCodGranja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodGranja.KeyDown
        If e.KeyCode = Keys.F2 Then
            With My.Forms.dlgBodegas_nuevabodega
                .txtDescripcionGranja.Text = ""
                .txtDescripcionGranja.Focus()
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub txtCodGranja_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodGranja.LostFocus
        If Me.txtCodGranja.Text <> "" Then
            Try
                Dim existeGranja As Boolean = False

                sql = New SqlCommand("select Nombre from Granjas where Codigo_Granja='" & Me.txtCodGranja.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    existeGranja = True
                    descGranja = leer(0).ToString
                End While
                con.Close()
                If existeGranja = False And Me.txtCodGranja.Text <> "" Then
                    MessageBoxEx.Show("No hay ninguna granja registrada con código: " & Me.txtCodGranja.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtCodGranja.Text = ""
                    Me.txtDescripcionGranja.Text = ""
                    Me.txtCodGranja.Focus()
                Else
                    Me.txtDescripcionGranja.Text = descGranja.ToString


                End If
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        End If
        
    End Sub

   
   
    Private Sub txtCodGranja_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodGranja.TextChanged

    End Sub

    Private Sub txtBodega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBodega.TextChanged

    End Sub
End Class