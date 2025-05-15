Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmRegMedicamentos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim AfeccionesGeneralizadas(7) As String
    Dim SistemaDigestivo(5) As String
    Dim SistemaOsteoMuscular(2) As String
    Dim Ectoparasitos(4) As String
    Dim Intonxicaciónes(9) As String
    Dim AparatoReproductor(8) As String
    Dim SistemaNervioso(1) As String
    Dim SistemaRespiratorio(7) As String
    Dim EndoParasitos(4) As String
    Dim SeleccionoCategoria As Boolean
    Dim SeleccionoEnfermedad As Boolean
    Private Sub frmRegMedicamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AfeccionesGeneralizadas(0) = "Cólera porcino o peste porcina clasica"
        AfeccionesGeneralizadas(1) = "Erisipela porcina"
        AfeccionesGeneralizadas(2) = "Fiebre aftosa en los cerdos"
        AfeccionesGeneralizadas(3) = "Leptospirosis porcina"
        AfeccionesGeneralizadas(4) = "Peste porcina africana"
        AfeccionesGeneralizadas(5) = "Signos y Sintomas de la Fiebre Aftosa en Cerdos"
        AfeccionesGeneralizadas(6) = "Tratamiento de la fiebre aftosa en los cerdos"
        AfeccionesGeneralizadas(7) = "Tuberculosis"

        SistemaDigestivo(0) = "Disenteria porcina"
        SistemaDigestivo(1) = "Enteritis por clostridium"
        SistemaDigestivo(2) = "Enteritis rotaviral porcina"
        SistemaDigestivo(3) = "Gastroenteritis Transmisible porcina"
        SistemaDigestivo(4) = "Salmonelosis porcina"

        SistemaOsteoMuscular(0) = "Artritis infecciosa del cerdo"
        SistemaOsteoMuscular(1) = "Lesiones podales y degeneración de la pezuña"

        Ectoparasitos(0) = "Acaros"
        Ectoparasitos(1) = "Moscas"
        Ectoparasitos(2) = "Garrapatas"
        Ectoparasitos(3) = "Piojos"

        Intonxicaciónes(0) = "Intoxicación por arsenico"
        Intonxicaciónes(1) = "Envenenamiento por cianuro"
        Intonxicaciónes(2) = "Intoxicación por insecticidas derivados de plantas"
        Intonxicaciónes(3) = "Envenenamiento por fluoruros"
        Intonxicaciónes(4) = "Envenenamiento por gosipol"
        Intonxicaciónes(5) = "Intoxicación por compuestos a base de hidrocarburos clorados"
        Intonxicaciónes(6) = "Intoxicación con insecticidas a base de carbamato"
        Intonxicaciónes(7) = "Intoxicación por Organofosforados"
        Intonxicaciónes(8) = "Envenenamiento por cobre"

        AparatoReproductor(0) = "Cólera porcino o peste porcina clasica"
        AparatoReproductor(1) = "Erisipela porcina"
        AparatoReproductor(2) = "Fiebre aftosa en los cerdos"
        AparatoReproductor(3) = "Leptospirosis porcina"
        AparatoReproductor(4) = "Peste porcina africana"
        AparatoReproductor(5) = "Signos y Sintomas de la Fiebre Aftosa en Cerdos"
        AparatoReproductor(6) = "Tratamiento de la fiebre aftosa en los cerdos"
        AparatoReproductor(7) = "Tuberculosis"

        SistemaNervioso(0) = "Enfermedad de aujesky"

        SistemaRespiratorio(0) = "Complejo respiratorio porcino"
        SistemaRespiratorio(1) = "Influenza porcina"
        SistemaRespiratorio(2) = "Neumonia ezoótica porcina"
        SistemaRespiratorio(3) = "Pasteurelosis porcina"
        SistemaRespiratorio(4) = "Pleuroneumonia contagiosa porcina"
        SistemaRespiratorio(5) = "Rinitis atrófica del cerdo"
        SistemaRespiratorio(6) = "Rinitis necrótica del cerdo"

        EndoParasitos(0) = "Trematodos"
        EndoParasitos(1) = "Nematodo"
        EndoParasitos(2) = "Cestodes"
        EndoParasitos(3) = "Protozoarios"

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub cbxEnfermedad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCategoriaEnfermedad.SelectedIndexChanged
        Me.SeleccionoCategoria = True

        Me.cbxEnfernedad.Items.Clear()
        If Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Afecciones Generalizadas" Then
            For i As Integer = 0 To 7
                Me.cbxEnfernedad.Items.Add(Me.AfeccionesGeneralizadas(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Sistema Digestivo" Then
            For i As Integer = 0 To 4
                Me.cbxEnfernedad.Items.Add(Me.SistemaDigestivo(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Sistema Osteomuscular" Then
            For i As Integer = 0 To 1
                Me.cbxEnfernedad.Items.Add(Me.SistemaOsteoMuscular(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Ectoparasitosis" Then
            For i As Integer = 0 To 3
                Me.cbxEnfernedad.Items.Add(Me.Ectoparasitos(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Intoxicaciones" Then
            For i As Integer = 0 To 8
                Me.cbxEnfernedad.Items.Add(Me.Intonxicaciónes(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Aparato Reproductor" Then
            For i As Integer = 0 To 7
                Me.cbxEnfernedad.Items.Add(Me.AparatoReproductor(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Sistema Nervioso" Then
            For i As Integer = 0 To 1 - 1
                Me.cbxEnfernedad.Items.Add(Me.SistemaNervioso(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Sistema Respiratorio" Then
            For i As Integer = 0 To 6
                Me.cbxEnfernedad.Items.Add(Me.SistemaRespiratorio(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Endoparasitosis" Then
            For i As Integer = 0 To 3
                Me.cbxEnfernedad.Items.Add(Me.Ectoparasitos(i).ToString)
            Next
        ElseIf Me.cbxCategoriaEnfermedad.SelectedItem.ToString = "Otra" Then
            Me.cbxEnfernedad.Focus()
        End If
    End Sub
    Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.txtNombre.Clear()
        Me.txtDescripcion.Clear()
    End Sub
   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.txtCodigo.Text = "" Then
                MessageBoxEx.Show("No ha ingresado el codigo del medicamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodigo.Focus()
            ElseIf Me.txtNombre.Text = "" Then
                MessageBoxEx.Show("No ha ingresado el nombre del medicamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNombre.Focus()
            ElseIf Me.txtDescripcion.Text = "" Then
                MessageBoxEx.Show("No ha ingresado la descripción del medicamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodigo.Focus()
            ElseIf Me.SeleccionoCategoria = False Then
                MessageBoxEx.Show("No ha seleccionado la categoria de enefermedad al que pertenecerá el medicamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbxCategoriaEnfermedad.Focus()
            ElseIf Me.SeleccionoEnfermedad = False Then
                MessageBoxEx.Show("No ha seleccionado la enefermedad al que pertenecerá el medicamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbxEnfernedad.Focus()
            ElseIf Not IsDate(Me.CajaFecha1.txtFecha.Text) Then
                MessageBoxEx.Show("No ha seleccionado la enefermedad al que pertenecerá el medicamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CajaFecha1.Focus()
            Else
                sql = New SqlCommand("insert into Registro_Medicamento values('" & Me.txtCodigo.Text & "','" & Me.txtNombre.Text & "','" & Me.txtDescripcion.Text & "','" & Me.cbxCategoriaEnfermedad.Text & "','" & Me.cbxEnfernedad.Text & "','" & Me.CajaFecha1.txtFecha.Text & "','" & FechaSistema & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                Me.Limpiar()
            End If

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub cbxEnfernedad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEnfernedad.SelectedIndexChanged
        Me.SeleccionoEnfermedad = True
    End Sub
End Class