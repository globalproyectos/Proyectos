Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmPartos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim PartoNo As Integer
    Dim selecciono_lote As Boolean
    Dim CantidadCerdosActual As Integer
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Sub Habilitar()
        Me.btnGuardar.Enabled = True
        Me.txtCodigoCerda.Enabled = False
        Me.txtPartoNo.Enabled = True
        Me.CajaFecha1.Enabled = True
        Me.txtVerraco.Enabled = True
        Me.CajaFecha2.Enabled = False
        Me.txtVerraco1.Enabled = True
        Me.CajaFecha3.Enabled = True
        Me.txtNoVivos.Enabled = True
        Me.CajaFecha4.Enabled = True
        Me.txtMomias.Enabled = True
        Me.txtPCamada.Enabled = True
        Me.txtP_Prom.Enabled = True
        Me.txtP_Prom_1.Enabled = True
        Me.CajaFecha5.Enabled = True
        Me.txtNo_Destad.Enabled = True
        Me.txtP_Camada_1.Enabled = True
        Me.txtMuertos.Enabled = True
    End Sub
    'Sub MostrarCodigoCerdas()
    '    Try
    '        sql = New SqlCommand("select Código_Cerda from REG_MADRES", con)
    '        con.Open()
    '        leer = sql.ExecuteReader
    '        While leer.Read
    '            If leer.IsDBNull(0) = True Then
    '            Else
    '                Me.txtCodigoCerda.Items.Add(leer(0))
    '            End If
    '        End While
    '        con.Close()
    '    Catch ex As Exception
    '        MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        con.Close()
    '    End Try
    'End Sub
    Sub Deshabilitar()
        Me.btnGuardar.Enabled = False

        Me.txtCodigoCerda.Enabled = False
        Me.txtPartoNo.Enabled = False
        Me.CajaFecha1.Enabled = False
        Me.txtVerraco.Enabled = False
        Me.CajaFecha2.Enabled = False
        Me.txtVerraco1.Enabled = False
        Me.CajaFecha3.Enabled = False
        Me.txtNoVivos.Enabled = False
        Me.CajaFecha4.Enabled = False
        Me.txtMomias.Enabled = False
        Me.txtPCamada.Enabled = False
        Me.txtP_Prom.Enabled = False
        Me.txtP_Prom_1.Enabled = False
        Me.CajaFecha5.Enabled = False
        Me.txtNo_Destad.Enabled = False
        Me.txtP_Camada_1.Enabled = False
        Me.txtMuertos.Enabled = False
    End Sub
    Sub LimiarCajas()
        Me.txtCodigoCerda.Text = ""
        Me.txtPartoNo.Clear()
        Me.txtVerraco.Clear()
        Me.txtVerraco1.Clear()
        Me.txtNoVivos.Clear()
        Me.txtMomias.Clear()
        Me.txtPCamada.Clear()
        Me.txtP_Prom.Clear()
        Me.txtP_Prom_1.clear()
        Me.txtNo_Destad.Clear()
        Me.txtP_Camada_1.Clear()
        Me.txtMuertos.Clear()
    End Sub
    Sub Lotes()
        Try
            sql = New SqlCommand("Select * from LOTES WHERE Estado='A' or Estado='F'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotes.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub frmPartos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql = New SqlCommand("select MAX(Parto_No) from REG_PARTOS_X_CERDA WHERE Código_Cerda='" & Me.txtCodigoCerda.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    Me.PartoNo = 0
                Else
                    Me.PartoNo = leer(0) + 1

                End If
            End While
            con.Close()
            Me.txtPartoNo.Text = Me.PartoNo
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
        Me.CajaFecha2.txtFecha.Text = Format(FechaEstimada, "dd/MM/yy")
        Me.txtPartoNo.Enabled = False
        Me.Lotes()

    End Sub
    
    Sub GuardarParto()
        Try
        sql = New SqlCommand("insert into REG_PARTOS_X_CERDA values('" & Me.txtCodigoCerda.Text & "','" & Me.txtPartoNo.Text & "','" & Me.CajaFecha1.txtFecha.Text & "','" & Me.txtVerraco.Text & "','" & Me.CajaFecha2.txtFecha.Text & "','" & Me.CajaFecha3.txtFecha.Text & "','" & Me.txtVerraco1.Text & "','" & Me.CajaFecha4.txtFecha.Text & "','" & Me.txtNoVivos.Text & "','" & Me.txtMomias.Text & "','" & Me.txtMuertos.Text & "','" & Me.txtPCamada.Text & "','" & Me.txtP_Prom.Text & "','" & Me.CajaFecha5.txtFecha.Text & "','" & Me.txtNo_Destad.Text & "','" & Me.txtP_Camada_1.Text & "','" & Me.txtP_Prom_1.Text & "','" & True & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            sql = New SqlCommand("select Total_Cerdos FROM Total_Cerdos_Lote WHERE Lote_No='" & Me.cbxLotes.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.CantidadCerdosActual = leer(0)
            End While
            con.Close()
            sql = New SqlCommand("update Total_Cerdos_Lote set Total_Cerdos='" & (Me.CantidadCerdosActual + Me.txtNoVivos.Text) & "', Fecha_Ultima_Modificación='" & Me.CajaFecha4.txtFecha.Text & "' where Lote_No='" & Me.cbxLotes.Text & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            sql = New SqlCommand("Insert into MOVIMIENTO_LOTE (Lote_No , Reemplazos , Defuncion , Destazo , Rastro , Entrada , Salida ,Fecha_Movimiento ,Documento_NO) values('" & 0 & "', '" & 0 & "','" & 0 & "','" & 0 & "','" & Me.txtNoVivos.Text & "','" & 0 & "','" & Me.CajaFecha4.txtFecha.Text & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            sql = New SqlCommand("update Estado_de_Partos set Estado_Parto=1 where Id_Enseminacion='" & IdEnseminacion_x & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            CambiarEstadoCerda(Me.txtCodigoCerda.Text, "2")
            MessageBoxEx.Show("Se cambió el estado de la cerda código: " & RTrim(Me.txtCodigoCerda.Text) & " a estado Lactando...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       If Me.txtPartoNo.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el número del parto correspondiente a la cerda", "Numero parto Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.GuardarParto()
            Me.Close()
            Me.LimiarCajas()
            Me.Deshabilitar()
        End If
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Habilitar()
    End Sub
    Private Sub txtVerraco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVerraco.LostFocus
        If Me.txtVerraco.Text = "" Then
            Me.txtVerraco.Text = 0
        End If
    End Sub
    Private Sub txtVerraco1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVerraco1.LostFocus
        If Me.txtVerraco1.Text = "" Then
            Me.txtVerraco1.Text = 0
        End If
    End Sub
    Private Sub txtMomias_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMomias.LostFocus
        If Me.txtMomias.Text = "" Then
            Me.txtMomias.Text = 0
        End If
    End Sub
    Private Sub txtMuertos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMuertos.LostFocus
        If Me.txtMuertos.Text = "" Then
            Me.txtMuertos.Text = 0
        End If
    End Sub
    Private Sub txtPCamada_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPCamada.LostFocus
        If Me.txtPCamada.Text = "" Then
            Me.txtPCamada.Text = 0
        End If
    End Sub
    Private Sub txtP_Prom_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtP_Prom.LostFocus
        If Me.txtP_Prom.Text = "" Then
            Me.txtP_Prom.Text = 0
        End If
    End Sub

    Private Sub txtP_Prom_1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtP_Prom_1.LostFocus
        If Me.txtP_Prom_1.Text = "" Then
            Me.txtP_Prom_1.Text = 0
        End If
    End Sub
    Private Sub txtNo_Destad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNo_Destad.LostFocus
        If Me.txtNo_Destad.Text = "" Then
            Me.txtNo_Destad.Text = 0
        End If
    End Sub
    Private Sub txtP_Camada_1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtP_Camada_1.LostFocus
        If Me.txtP_Camada_1.Text = "" Then
            Me.txtP_Camada_1.Text = 0
        End If
    End Sub

End Class