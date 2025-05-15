Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim verif As Boolean = False

    Dim usuarioFull, usuario As String
    Dim No_Session As Integer

    Sub verificar_user()
        If Me.txtUsuario.Text = "" Then
            MessageBoxEx.Show("No ha ingresado su nombre de usuario", "Inicio Sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                sql = New SqlCommand("SELECT Usuario, CONVERT(VARCHAR(50), DECRYPTBYPASSPHRASE('Constraseña',Contraseña)), Nombre_Completo, Privilegios FROM TBST", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    If leer.IsDBNull(1) = True Then

                    Else
                        If Me.txtUsuario.Text = leer(0) And Me.txtContraseña.Text = leer(1).ToString Then
                            verif = True
                            Me.usuarioFull = leer(2)
                            Me.usuario = leer(0)
                            TipoUsuario = leer(3).ToString
                        End If
                    End If
                End While
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
            If verif = True Then
                Dim x As New frmPrincipal
                Me.AddOwnedForm(x)
                Try
                    sql = New SqlCommand("select Fecha from Guia_de_Digitacion where Usuario='" & usuario & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        UsuarioSistema = usuario
                        FechaSistema = Format(leer(0), "dd/MM/yyyy")
                    End While
                    con.Close()
                    sql = New SqlCommand("select Tema, Color from OPCIONES where Usuario='" & Me.usuarioFull & "'", con)
                    con.Open()
                    With x
                        leer = sql.ExecuteReader
                        While leer.Read
                            If leer(0) = "O2007Blue" Then
                                .Tema = "O2007Blue"

                            ElseIf leer(0) = "O2007Black" Then
                                .Tema = "O2007Black"

                            ElseIf leer(0) = "O2007Silver" Then
                                .Tema = "O2007Silver"

                            ElseIf leer(0) = "O2007VistaGlass" Then
                                .Tema = "O2007VistaGlass"

                            ElseIf leer(0) = "O2010Blue" Then
                                .Tema = "O2010Blue"

                            ElseIf leer(0) = "O2010Black" Then
                                .Tema = "O2010Black"

                            ElseIf leer(0) = "O2010Silver" Then
                                .Tema = "O2010Silver"

                            ElseIf leer(0) = "OWin7" Then
                                .Tema = "OWin7"
                            End If
                        End While
                    End With
                    con.Close()
                Catch ex As Exception
                    MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
                End Try
                Try
                    sql = New SqlCommand("select MAX(No_Session) from Control_de_Sessiones", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        If leer.IsDBNull(0) = True Then
                            No_Session = 0
                            x.lbSession.Text = No_Session
                        Else
                            No_Session = leer(0) + 1
                            x.lbSession.Text = No_Session
                        End If
                    End While
                    con.Close()
                Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
                End Try
                Try
                    sql = New SqlCommand("insert into Control_de_Sessiones values('" & No_Session & "','" & Me.usuarioFull & "','" & FechaSistema & "','" & TimeOfDay & "','" & FechaSistema & "','" & 0 & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()

                    x.lbUsuario.Text = usuarioFull
                    Me.Hide()
                    x.Show()
                Catch ex As Exception
                MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
                End Try
            Else
                MessageBoxEx.Show("Usuario ó Contraseña Inorrecta", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtContraseña.SelectAll()
                Me.txtContraseña.Focus()
            End If
        End If
      End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        Me.verificar_user()
        If Me.recordarcredencialesCheckBoxX1.CheckState = CheckState.Checked Then
            My.MySettings.Default.recordarcredenciales = True
            My.MySettings.Default.usuario = Me.txtUsuario.Text
            My.MySettings.Default.contraseña = Me.txtContraseña.Text
        Else
            My.MySettings.Default.recordarcredenciales = False
            
        End If
        My.MySettings.Default.Save()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()

    End Sub
    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.verificar_user()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Version2.Text = "Versión: " & My.Application.Info.Version.ToString
        Me.txtUsuario.SelectAll()
        Me.txtUsuario.Focus()

        If My.MySettings.Default.recordarcredenciales = True Then
            Me.recordarcredencialesCheckBoxX1.CheckState = CheckState.Checked
            Me.txtUsuario.Text = My.MySettings.Default.usuario
            Me.txtContraseña.Text = My.MySettings.Default.contraseña
        Else
            Me.recordarcredencialesCheckBoxX1.CheckState = CheckState.Unchecked
        End If


    End Sub

    Private Sub recordarcredencialesCheckBoxX1_CheckedChanged(sender As Object, e As EventArgs) Handles recordarcredencialesCheckBoxX1.CheckedChanged

    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub CheckBoxX1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.CheckBoxX1.CheckState = CheckState.Checked Then
    '        Dim frmCambiar As New frmCambiar_Servidor
    '        With frmCambiar
    '            .WindowState = FormWindowState.Normal
    '            .ShowDialog()
    '        End With
    '    End If
    'End Sub
End Class