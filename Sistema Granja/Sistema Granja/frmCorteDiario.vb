Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmCorteDiario
    Inherits DevComponents.DotNetBar.Office2007Form

    Private Sub frmCorteDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PictureBox1.Image = New System.Drawing.Bitmap(My.Resources.tijeras)
        Me.txtUsuario.Text = UsuarioSistema
        Me.txtFechaProx.Text = Format(DateAdd(DateInterval.Day, 1, FechaSistema), "dd/MM/yy")
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub btnCortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCortar.Click
        Dim FechaProx As Date = Me.txtFechaProx.Text
        Dim MesDigicacionActual As Integer = FechaSistema.Month
        Dim MesFechaProx As Integer = FechaProx.Month
        Dim AñoDigitacionActual As Integer = FechaSistema.Year
        Dim AñoFechaProx As Integer = FechaSistema.Year

        If Not IsDate(Me.txtFechaProx.Text) Then
            MessageBoxEx.Show("La fecha ingresada es incorrecta, porfavor verifique y vuelva a intentarlo", "Fecha no Válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaProx.Focus()
        ElseIf (Me.txtFechaProx.Text.ToString.Length) < 8 Then
            MessageBoxEx.Show("La fecha que ha ingresado esta incompleta, el campo debe contener 8 caracteres", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFechaProx.Focus()

        Else
            Dim mesabierto As Boolean = True
            Dim realizo_cierre As String = ""
            sql = New SqlCommand("select mes,realizo_cierre from Meses_Cerrados mc where mc.mes = (left(DATENAME (MONTH , '" & Me.txtFechaProx.Text & "'),3)+ right(rtrim(convert(char,DATEPART (YEAR ,'" & Me.txtFechaProx.Text & "'))),2)) and mc.estado ='C'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                mesabierto = False
                realizo_cierre = leer(1)
            End While
            con.Close()
            If mesabierto = True Then
                If MesFechaProx > MesDigicacionActual Then
                    Dim resp As MsgBoxResult
                    resp = MessageBoxEx.Show("La fecha que ha ingresado es mayor segun mes digitado, si continua podria trabajar con una fecha " & vbCrLf & " que no corresponde al mes de digitación, desea continuar de todos modos", "Advertecnia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If resp = MsgBoxResult.Yes Then
                        GrabarCorte()
                        frmPrincipal.ActualizarAlertas(True)
                    Else
                        Me.txtFechaProx.Focus()
                    End If
                ElseIf AñoFechaProx > AñoDigitacionActual Then
                    Dim resp As MsgBoxResult
                    resp = MessageBoxEx.Show("La fecha que ha ingresado es mayor segun año digitado, si continua podria trabajar con una fecha que no corresponde al año de digitación, desea continuar de todos modos", "Advertecnia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If resp = MsgBoxResult.Yes Then
                        GrabarCorte()
                        frmPrincipal.ActualizarAlertas(True)
                    Else
                        Me.txtFechaProx.Focus()
                    End If
                Else
                    GrabarCorte()
                    frmPrincipal.ActualizarAlertas(True)
                End If
            ElseIf mesabierto = False And RTrim(realizo_cierre) = RTrim(Me.txtUsuario.Text) Then
                Dim resp1 As MsgBoxResult
                resp1 = MessageBoxEx.Show("El mes ya ha sido cerrado, sin embargo su usuario puede realizar el cambio solicitado, " & vbCrLf & " pero podria alterar la información del mes." & vbCrLf & vbCrLf & "¿Desea continuar de todos modos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp1 = MsgBoxResult.Yes Then
                    If MesFechaProx > MesDigicacionActual Then
                        Dim resp As MsgBoxResult
                        resp = MessageBoxEx.Show("La fecha que ha ingresado es mayor segun mes digitado, si continua podria trabajar con una fecha " & vbCrLf & " que no corresponde al mes de digitación, desea continuar de todos modos", "Advertecnia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If resp = MsgBoxResult.Yes Then
                            GrabarCorte()
                            frmPrincipal.ActualizarAlertas(True)
                        Else
                            Me.txtFechaProx.Focus()
                        End If
                    ElseIf AñoFechaProx > AñoDigitacionActual Then
                        Dim resp As MsgBoxResult
                        resp = MessageBoxEx.Show("La fecha que ha ingresado es mayor segun año digitado, si continua podria trabajar con una fecha que no corresponde al año de digitación, desea continuar de todos modos", "Advertecnia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If resp = MsgBoxResult.Yes Then
                            GrabarCorte()
                            frmPrincipal.ActualizarAlertas(True)
                        Else
                            Me.txtFechaProx.Focus()
                        End If
                    Else
                        GrabarCorte()
                        frmPrincipal.ActualizarAlertas(True)
                    End If
                End If

            Else
                MessageBoxEx.Show("El mes ya esta cerrado, no puede realizar el cambio", "Corte no permitido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

            
           
        End If
    End Sub
    Sub GrabarCorte()
        Dim Mes As String = FechaSistema.Month
        Dim MesLetras As String = ""
        Dim oYear As String = ""
        oYear = FechaSistema.Year
        oYear = oYear.Substring(2, 2)
        If Mes = "1" Then
            MesLetras = "ENE"
        ElseIf Mes = "2" Then
            MesLetras = "FEB"
        ElseIf Mes = "3" Then
            MesLetras = "MAR"
        ElseIf Mes = "4" Then
            MesLetras = "ABR"
        ElseIf Mes = "5" Then
            MesLetras = "MAY"
        ElseIf Mes = "6" Then
            MesLetras = "JUN"
        ElseIf Mes = "7" Then
            MesLetras = "JUL"
        ElseIf Mes = "8" Then
            MesLetras = "AGO"
        ElseIf Mes = "9" Then
            MesLetras = "SEP"
        ElseIf Mes = "10" Then
            MesLetras = "OCT"
        ElseIf Mes = "11" Then
            MesLetras = "NOV"
        ElseIf Mes = "12" Then
            MesLetras = "DIC"
        End If
        'Dim FechaCorte As Date = Me.txtFechaProx.Text
        'If FechaCorte.Month < CInt(Mes) Then
        '    MessageBoxEx.Show("No puede volver a mese anteriores")
        'Else
        ActualizarLote()
        sql = New SqlCommand("update Guia_de_Digitacion set Fecha='" & Me.txtFechaProx.Text & "'", con)
        con.Open()
        sql.ExecuteNonQuery()
        con.Close()
        sql = New SqlCommand("insert into Cortes_Diarios values('" & FechaSistema & "','" & Format(TimeOfDay, "hh:mm tt") & "','" & Me.txtFechaProx.Text & "','" & Me.txtUsuario.Text & "')", con)
        con.Open()
        sql.ExecuteNonQuery()
        con.Close()
        Dim cmd As String = "insert into Detalles_cortes_diarios (ID_Corte , Mes,Lote_No ,Existencia_Inicio_Dia ,Existencia_final_Dia ,Negativos)" _
                         & " select (select isnull((MAX(cd.ID )),1) from Cortes_Diarios cd),'" & MesLetras & oYear & "',t.Lote_No ,(select ((isnull((SUM(m.Entrada )),0))-(isnull((SUM(m.Defuncion )),0)+isnull((SUM(m.Destazo )),0)+isnull((SUM(m.Rastro )),0)+isnull((SUM(m.Reemplazos)),0)+isnull((SUM(m.Salida )),0))) from MOVIMIENTO_LOTE m where t.Lote_No = m.Lote_No and m.Fecha_Movimiento <= '" & FechaSistema & "')," _
                         & " (select ((isnull((SUM(m.Entrada )),0))-(isnull((SUM(m.Defuncion )),0)+isnull((SUM(m.Destazo )),0)+isnull((SUM(m.Rastro )),0)+isnull((SUM(m.Reemplazos)),0)+isnull((SUM(m.Salida )),0))) from MOVIMIENTO_LOTE m where t.Lote_No = m.Lote_No and m.Fecha_Movimiento <= '" & Me.txtFechaProx.Text & "'), " _
                         & " CASE WHEN (t.Total_Cerdos <0)" _
                         & " THEN" _
                         & " 'True'" _
                         & " WHEN (t.Total_Cerdos >0)" _
                         & " THEN" _
                         & " 'FALSE'" _
                         & " ELSE 'FALSE'" _
                         & " END" _
                         & " from Total_Cerdos_Lote t"
        sql = New SqlCommand(cmd, con)
        con.Open()
        sql.ExecuteNonQuery()
        con.Close()
        Dim cmd2 As String = "INSERT INTO Estados_Cerdas_Fin_del_Dia(Codigo_Cerda ,Lote_No ,Estado ,Fecha ,ID_Corte )" _
                           & " SELECT rm.Código_Cerda ,rm.Lote_No ,rm.Estado_Actual ,'" & FechaSistema & "',(SELECT isnull((MAX(ID)),1) FROM Cortes_Diarios cd) " _
                           & " FROM REG_MADRES rm" _
                           & " where rm.Estado_Actual <>'DF' AND rm.Estado_Actual <>'D'" _
                           & " UNION" _
                           & " SELECT rm.Código_Abuela  ,rm.Lote_No ,rm.Estado_Actual ,'" & FechaSistema & "',(SELECT isnull((MAX(ID)),1) FROM Cortes_Diarios cd)" _
                           & " FROM REG_ABUELAS  rm" _
                           & " where rm.Estado_Actual <>'DF' AND rm.Estado_Actual <>'D'"
        sql = New SqlCommand(cmd2, con)
        con.Open()
        sql.ExecuteNonQuery()
        con.Close()
        FechaSistema = Me.txtFechaProx.Text
        MessageBoxEx.Show("Se realizó el corte exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
        'End If
        
    End Sub
    Private Sub txtFechaProx_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaProx.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 47 And Not Asc(e.KeyChar) = 46 And Not Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If txtFechaProx.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            txtFechaProx.Text = txtFechaProx.Text & "/"
            txtFechaProx.SelectionStart = 4
        ElseIf txtFechaProx.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            txtFechaProx.Text = txtFechaProx.Text & "/"
            txtFechaProx.SelectionStart = 6
        End If
    End Sub

 
End Class