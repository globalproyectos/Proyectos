Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports System.Data
Imports System.Data.SqlClient
Public Class frmConsultaValuadosLotes
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim CompEr As String = ", el error se produjo en el BLOQUE CV-"
    Dim CodGranja As String
    Private Sub frmConsultaValuadosLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CargarGranja()
    End Sub
    Sub CargasLotes()

        Try
            'BLOQUE CV-1
            sql = New SqlCommand("Select Codigo_Granja FROM Granjas WHERE Nombre='" & Me.cbxGranja.Text & "' ", con)

            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CodGranja = leer(0)
            End While
            con.Close()
            Me.cbxLoteDesde.Items.Clear()
            Me.cbxLoteHasta.Items.Clear()
            sql = New SqlCommand("SELECT Lote_No FROM LOTES WHERE Codigo_Granja='" & CodGranja & "' AND Estado='A' or Estado='F'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLoteDesde.Items.Add(leer(0))
                Me.cbxLoteHasta.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & CompEr & 1, "Error al cargar Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub CargarGranja()
        'BOQUE CV-2
        Try
            sql = New SqlCommand("Select Nombre FROM Granjas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxGranja.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & CompEr & 2, "Error al cargar Granjas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
 Private Sub ComboBoxEx3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxFecha.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Me.cbxFecha.Text.Length = 2 And Not Asc(e.KeyChar) = 8 Then
            Me.cbxFecha.Text = Me.cbxFecha.Text & "/"
            Me.cbxFecha.SelectionStart = 4
        ElseIf Me.cbxFecha.Text.Length = 5 And Not Asc(e.KeyChar) = 8 Then
            Me.cbxFecha.Text = Me.cbxFecha.Text & "/"
            Me.cbxFecha.SelectionStart = 6
        End If
    End Sub
    Private Sub cbxGranja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxGranja.SelectedIndexChanged
        Me.CargasLotes()
    End Sub
    Private Sub cbxLoteDesde_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLoteDesde.Click
        If Me.cbxGranja.Text = "" Then
            MessageBoxEx.Show("No ha seleccionado la Granja, si no selecciona la grnaja no se mostrarán los Lotes", "Seleccionar Granja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub cbxLoteHasta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLoteHasta.Click
        If Me.cbxGranja.Text = "" Then
            MessageBoxEx.Show("No ha seleccionado la Granja, si no selecciona la grnaja no se mostrarán los Lotes", "Seleccionar Granja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If ValidarFechas(Me.cbxFecha.Text) = False Then
            Me.cbxFecha.Focus()
        Else
           Dim x As New frmCargaValuosLotes()
            x.Granja = CodGranja
            x.lbGranja.Text = UCase(Me.cbxGranja.Text)
            x.lbValuados.Text = "VALUADOS AL: " & UCase(Format(Me.cbxFecha.Text, "Long Date"))
            x.Granja = CodGranja
            x.LoteDesde = Me.cbxLoteDesde.Text
            x.LoteHasta = Me.cbxLoteHasta.Text
            x.FechaHasta = Me.cbxFecha.Text
            x.WindowState = FormWindowState.Maximized
            x.MdiParent = Me.MdiParent
            x.Show()
            Me.Close()
        End If

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

 

    Private Sub cbxLoteDesde_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLoteDesde.TextChanged
        If Me.cbxLoteDesde.Text = "" Or Me.cbxGranja.Text = "" Or Me.cbxLoteDesde.Text = "" Or Me.cbxFecha.Text = "" Then
            Me.btnConsultar.Enabled = False
        Else
            Me.btnConsultar.Enabled = True
        End If
    End Sub

    Private Sub cbxFecha_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFecha.TextChanged
        If Me.cbxLoteDesde.Text = "" Or Me.cbxGranja.Text = "" Or Me.cbxLoteDesde.Text = "" Or Me.cbxFecha.Text = "" Then
            Me.btnConsultar.Enabled = False
        Else
            Me.btnConsultar.Enabled = True
        End If
    End Sub
    Private Sub cbxLoteHasta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLoteHasta.TextChanged
        If Me.cbxLoteDesde.Text = "" Or Me.cbxGranja.Text = "" Or Me.cbxLoteDesde.Text = "" Or Me.cbxFecha.Text = "" Then
            Me.btnConsultar.Enabled = False
        Else
            Me.btnConsultar.Enabled = True
        End If
    End Sub

    Private Sub cbxGranja_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxGranja.TextChanged
        If Me.cbxLoteDesde.Text = "" Or Me.cbxGranja.Text = "" Or Me.cbxLoteDesde.Text = "" Or Me.cbxFecha.Text = "" Then
            Me.btnConsultar.Enabled = False
        Else
            Me.btnConsultar.Enabled = True
        End If
    End Sub
End Class