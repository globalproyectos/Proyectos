Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Ionic.Zip
Imports System.Net.Mail
Imports System .Net 
Public Class frmRespaldarReg
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim RutaCompletaBak As String
    Dim RutaCompletaLog As String
    Dim RutaDirectorio As String
    Dim enviaracorreo As Boolean
    Private Declare Function IsNetworkAlive Lib "SENSAPI.DLL" (ByRef lpdwFlags As Long) As Long
    Sub IniciarRespaldo()
        If Me.CheckBoxX1.CheckState = CheckState.Checked Then
            enviaracorreo = True
        ElseIf Me.CheckBoxX1.CheckState = CheckState.Unchecked Then
            enviaracorreo = False
        End If
        Me.LabelX4.Visible = False
        Me.btnRespaldar.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Me.ProgressBarX1.Visible = True
        Me.lbCreando.Visible = True
        Me.BW.RunWorkerAsync()
    End Sub
    Sub CancelarRespaldo()
        Me.LabelX4.Visible = True
        Me.Cursor = Cursors.Arrow
        Me.btnRespaldar.Enabled = True
        Me.BW.CancelAsync()
        Me.ProgressBarX1.Visible = False
        Me.lbCreando.Visible = False
        Me.TextBoxX1.Text = ""
    End Sub
    Private Sub frmRespaldarReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PartDisc() As String = System.IO.Directory.GetLogicalDrives
        Dim i As Long
        Me.ComboBoxEx1.Text = "C:\"
        For i = PartDisc.GetLowerBound(0) To PartDisc.GetUpperBound(0)
            Me.ComboBoxEx1.Items.Add(PartDisc(i))
        Next

        Me.CheckBoxX1.Checked = Configuraciones.Default.Enviar_x_Correo
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Sub RealizarRespaldo()
        If enviaracorreo = True Then
            For i As Integer = 0 To 10
                Me.BW.ReportProgress(i, "Preparando Respaldo...")
                Threading.Thread.Sleep(20)
            Next
            Try
                For Each arhivos As String In My.Computer.FileSystem.GetFiles(RutaDirectorio)
                    My.Computer.FileSystem.DeleteFile(arhivos)
                Next
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error limpiar directorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
            sql = New SqlCommand("BACKUP DATABASE BDGRANJA TO DISK='" & Me.RutaCompletaBak & "'", ConRespaldo)
            sql2 = New SqlCommand("BACKUP LOG BDGRANJA TO DISK='" & Me.RutaCompletaLog & "'", ConRespaldo)
            ConRespaldo.Open()
            For i As Integer = 10 To 15
                Me.BW.ReportProgress(i, "Generando archivo Bak...")
                Threading.Thread.Sleep(20)
            Next
            sql.ExecuteNonQuery()
            For i As Integer = 15 To 35
                Me.BW.ReportProgress(i, "Generando archivo Trn...")
                Threading.Thread.Sleep(20)
            Next
            sql2.ExecuteNonQuery()
            For i As Integer = 35 To 65
                Me.BW.ReportProgress(i, "Finalizando Respaldo...")
                Threading.Thread.Sleep(20)
            Next
            ConRespaldo.Close()
            'For i As Integer = 65 To 75
            '    Me.BW.ReportProgress(i, "Comprimiendo Respaldo...")
            '    Threading.Thread.Sleep(20)
            'Next
            'Try
            '    Using zip As ZipFile = New ZipFile()
            '        zip.Password = "J0$eMiguel003191087"
            '        zip.MaxOutputSegmentSize = 8388608
            '        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression
            '        zip.AddFile(RutaCompletaBak)
            '        zip.AddFile(RutaCompletaLog)
            '        zip.Save(RutaCompletaBak & ".zip")
            '    End Using
            'Catch ex As Exception
            '    MessageBoxEx.Show(ex.Message, "Error al comprimir BAK", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
            'For i As Integer = 75 To 85
            '    Me.BW.ReportProgress(i, "Finalizando Compresión...")
            '    Threading.Thread.Sleep(20)
            'Next
            'Try
            '    'My.Computer.FileSystem.DeleteFile(RutaCompletaBak)
            '    'My.Computer.FileSystem.DeleteFile(RutaCompletaLog)

            'Catch ex As Exception
            '    MessageBoxEx.Show(ex.Message, "Error al limpiar directorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
            For i As Integer = 85 To 90
                Me.BW.ReportProgress(i, "Enviando x Correo...")
                Threading.Thread.Sleep(20)
            Next
            Dim partNo As Integer = 0
            Dim partfin As Integer = 0
            Dim complAsunto As String = ""
            For Each Archivos As String In My.Computer.FileSystem.GetFiles(RutaDirectorio)
                partfin += 1
            Next
            If partfin > 1 Then
                complAsunto = "Parte-"
            Else
                complAsunto = ""
            End If
            Dim partesString As String = ""
            For Each Archivos As String In My.Computer.FileSystem.GetFiles(RutaDirectorio)
                partNo += 1
                If partfin > 1 Then
                    partesString = RTrim(partNo.ToString)
                Else
                    partesString = ""
                End If
                EnviarCorreo("joseduran@gumarsal.com.sv", "Backup " & RTrim(Me.TextBoxX1.Text) & complAsunto & partesString, Archivos)
            Next

            For i As Integer = 90 To 100
                Me.BW.ReportProgress(i, "Finalizando Envió...")
                Threading.Thread.Sleep(20)
            Next
            
        ElseIf enviaracorreo = False Then
            For i As Integer = 0 To 15
                Me.BW.ReportProgress(i, "Preparando Respaldo...")
                Threading.Thread.Sleep(20)
            Next
            sql = New SqlCommand("use master BACKUP DATABASE BDGRANJA TO DISK='" & Me.RutaCompletaBak & "'", ConRespaldo)
            sql2 = New SqlCommand("use master BACKUP LOG BDGRANJA TO DISK='" & Me.RutaCompletaLog & "'", ConRespaldo)
            ConRespaldo.Open()
            For i As Integer = 15 To 25
                Me.BW.ReportProgress(i, "Generando archivo Bak...")
                Threading.Thread.Sleep(20)
            Next
            sql.ExecuteNonQuery()
            For i As Integer = 25 To 50
                Me.BW.ReportProgress(i, "Generando archivo Trn...")
                Threading.Thread.Sleep(20)
            Next
            sql2.ExecuteNonQuery()
            For i As Integer = 50 To 70
                Me.BW.ReportProgress(i, "Finalizando Respaldo...")
                Threading.Thread.Sleep(20)
            Next
            ConRespaldo.Close()
            'For i As Integer = 70 To 90
            '    Me.BW.ReportProgress(i, "Comprimiendo Respaldo...")
            '    Threading.Thread.Sleep(20)
            'Next
            'Try
            '    Using zip As ZipFile = New ZipFile()
            '        zip.Password = "J0$eMiguel003191087"

            '        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression
            '        zip.AddFile(RutaCompletaBak)
            '        zip.AddFile(RutaCompletaLog)
            '        zip.Save(RutaCompletaBak & ".zip")
            '    End Using
            'Catch ex As Exception
            '    MessageBoxEx.Show(ex.Message, "Error al comprimir BAK", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
            'For i As Integer = 90 To 100
            '    Me.BW.ReportProgress(i, "Finalizando Compresión...")
            '    Threading.Thread.Sleep(20)
            'Next
            'Try
            '    'My.Computer.FileSystem.DeleteFile(RutaCompletaBak)
            '    'My.Computer.FileSystem.DeleteFile(RutaCompletaLog)
            'Catch ex As Exception
            '    MessageBoxEx.Show(ex.Message, "Error al limpiar directorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
        End If
    End Sub
    'Public Sub EnviarCorreo(ByVal Para As String, ByVal Asunto As String, ByVal Body As String, ByVal NombrePara As String, ByVal Adjuntar As String)
    '    Try
    '        Dim adjunto As New System.Net.Mail.Attachment(Adjuntar)
    '        Dim [Direccion] As New MailAddress("sggm2012@hotmail.com", "..::Sistema Granja::..")
    '        Dim [Para_x] As New MailAddress(Para, NombrePara)
    '        Dim correo As New System.Net.Mail.MailMessage([Direccion], [Para_x])
    '        correo.Subject = Asunto
    '        correo.Body = Body
    '        correo.Attachments.Add(adjunto)
    '        correo.IsBodyHtml = True
    '        Dim cliente As New System.Net.Mail.SmtpClient()
    '        Dim autentificacion As New System.Net.NetworkCredential("sggm2012@hotmail.com", "josemiguel003")
    '        cliente.Host = "smtp.live.com"
    '        cliente.UseDefaultCredentials = True
    '        cliente.Credentials = autentificacion
    '        cliente.Send(correo)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error de Envió", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    '    End Try
    'End Sub
    Public Sub EnviarCorreo(ByVal Para As String, ByVal Asunto As String, ByVal Adjunto As String)
        Try
            Dim insMail As New MailMessage(New MailAddress("jmdd8781@gmail.com"), New MailAddress(Para))
            Dim adjuntar As New Mail.Attachment(Adjunto)
            With insMail
                .Attachments.Add(adjuntar)
                .Subject = Asunto
                .IsBodyHtml = True
                .Body = "Correo enviado desde Sistema Granja"
                .From = New MailAddress("jmdd8781@gmail.com")

            End With
            Dim smtp As New System.Net.Mail.SmtpClient
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New System.Net.NetworkCredential("jmdd8781@gmail.com", "josemiguel003")
            smtp.Send(insMail)
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al enviar correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRespaldar.Click
        Me.RutaCompletaBak = ""
        Me.RutaCompletaLog = ""
        If Me.ComboBoxEx1.Text = "" Then
            MessageBoxEx.Show("No ha seleccionado la unidad de disco donde desea almacenar el respaldo", "Crear Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Me.TextBoxX1.Text = "" Then
            MessageBoxEx.Show("No ha establecido el nombre, con el que se guardará el respaldo", "Crear Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Not Directory.Exists(Me.ComboBoxEx1.Text & "BackUp_BD") Then
                Directory.CreateDirectory(Me.ComboBoxEx1.Text & "BackUp_BD")
                'SetAttr(Me.ComboBoxEx1.Text & "BackUp_BD", FileAttribute.Hidden)
                Me.RutaDirectorio = Me.ComboBoxEx1.Text + "BackUp_BD\"
                Me.RutaCompletaBak = Me.ComboBoxEx1.Text + "BackUp_BD\" + Me.TextBoxX1.Text + "_" + Format(FechaSistema, "ddMMyy") + ".bak"
                Me.RutaCompletaLog = Me.ComboBoxEx1.Text + "BackUp_BD\" + Me.TextBoxX1.Text + "_" + Format(FechaSistema, "ddMMyy") + ".trn"
                Me.IniciarRespaldo()
            Else
                Me.RutaDirectorio = Me.ComboBoxEx1.Text + "BackUp_BD\"
                Me.RutaCompletaBak = Me.ComboBoxEx1.Text + "BackUp_BD\" + Me.TextBoxX1.Text + "_" + Format(FechaSistema, "ddMMyy") + ".bak"
                Me.RutaCompletaLog = Me.ComboBoxEx1.Text + "BackUp_BD\" + Me.TextBoxX1.Text + "_" + Format(FechaSistema, "ddMMyy") + ".trn"
                Me.IniciarRespaldo()
            End If
        End If
    End Sub
    Private Sub BW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        Me.RealizarRespaldo()
    End Sub
    Private Sub BW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BW.ProgressChanged
        Me.ProgressBarX1.Value = e.ProgressPercentage
        Me.ProgressBarX1.Text = e.ProgressPercentage & "%"
        Me.lbCreando.Text = e.UserState
    End Sub
    Private Sub BW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        Me.CancelarRespaldo()
        'If enviaracorreo = True Then
        '    MessageBoxEx.Show("Se creo el respaldo y se envió por correo exitosamente a la cuenta de correo: joseduran@gumarsal.com.sv Administrador del Sistema", "Respaldo y Envió Existoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'ElseIf enviaracorreo = False Then
        '    MessageBoxEx.Show("Se creo el repaldo exitosamente para reestablecer este respaldo solicitelo al Administrador del Sistema", "Respaldo Existoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX1.TextChanged
        If Me.TextBoxX1.Text = "" Then
            Me.btnRespaldar.Enabled = False
        Else
            Me.btnRespaldar.Enabled = True
        End If
    End Sub
    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        Configuraciones.Default.Enviar_x_Correo = Me.CheckBoxX1.Checked
        Configuraciones.Default.Save()
    End Sub
End Class