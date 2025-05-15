Imports System.Data.SqlClient
Imports System.Data
Public Class dlg_BuscarClienteND
    Public busqueda As Long
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub dlg_BuscarClienteND_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarListadoClientes()
    End Sub
    Sub cargarListadoClientes()
        Dim cn As New SqlConnection(My.MySettings.Default.BDGRANJAConnectionString)
        Try

            Dim cmd As New SqlCommand("select TOP 100 Cliente,Nombre,Departamento, Municipio, Direccion, DUI, NIT from v_ClientesNetData where Nombre like '%'+'" & Me.TextBoxX1.Text & "'+'%' or NIT like '%'+'" & Me.TextBoxX1.Text & "'+'%' or Cliente like '%'+'" & Me.TextBoxX1.Text & "'+'%' ", cn)
            cmd.CommandType = CommandType.Text
            Dim vListaClienteNetData As New List(Of v_ClientesNetData)
            Dim vClienteNetData As v_ClientesNetData

            Dim leer As SqlDataReader
            cn.Open()
            leer = cmd.ExecuteReader
            While leer.Read
                vClienteNetData = New v_ClientesNetData()
                vClienteNetData.Cliente = leer(0)
                vClienteNetData.Nombre = leer(1)
                vClienteNetData.Departamento = leer(2)
                vClienteNetData.Municipio = leer(3)
                vClienteNetData.Direccion = leer(4)
                vClienteNetData.DUI = leer(5)
                vClienteNetData.NIT = leer(6)

                vListaClienteNetData.Add(vClienteNetData)
            End While
            cn.Close()

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = vListaClienteNetData
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged
        Timer1.Enabled = True
        busqueda = 0
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If Me.DataGridViewX1.Rows.Count > 0 Then
            frmRegSalidas.txtCliente.Text = Me.DataGridViewX1.CurrentRow.Cells(0).Value + " - " + Me.DataGridViewX1.CurrentRow.Cells(1).Value
            frmRegSalidas.txtDireccion.Text = Me.DataGridViewX1.CurrentRow.Cells(4).Value
            Me.Close()
        End If

    End Sub

    Private Sub dlg_BuscarClienteND_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX2_Click(sender, e)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        busqueda += 1
        If busqueda = 2 Then
            cargarListadoClientes()
            Timer1.Enabled = False
        End If
    End Sub
End Class
Public Class v_ClientesNetData
    Private _Cliente As String
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _Departamento As String
    Public Property Departamento() As String
        Get
            Return _Departamento
        End Get
        Set(ByVal value As String)
            _Departamento = value
        End Set
    End Property
    Private _Municipio As String
    Public Property Municipio() As String
        Get
            Return _Municipio
        End Get
        Set(ByVal value As String)
            _Municipio = value
        End Set
    End Property
    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property
    Private _DUI As String
    Public Property DUI() As String
        Get
            Return _DUI
        End Get
        Set(ByVal value As String)
            _DUI = value
        End Set
    End Property
    Private _NIT As String
    Public Property NIT() As String
        Get
            Return _NIT
        End Get
        Set(ByVal value As String)
            _NIT = value
        End Set
    End Property
End Class