Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data
Public Class frmRegistrar_Gastos_x_Mes
    Dim _MES As Integer
    Dim _AÑO As Integer
    Dim oFechaHasta As Date
    Dim TablaGastos As New DataTable("Gastos")
    Dim b As DevComponents.DotNetBar.Balloon
    Friend WithEvents balloonTipFocus As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents balloonTipHover As DevComponents.DotNetBar.BalloonTip
    Sub MostrarMes()
        Dim Año As String = FechaSistema.Year
        Año = Año.Substring(2, 2)
        Me.cbxMes.Items.Clear()
        Me.cbxMes.Items.Add("ENE " & Año)
        Me.cbxMes.Items.Add("FEB " & Año)
        Me.cbxMes.Items.Add("MAR " & Año)
        Me.cbxMes.Items.Add("ABR " & Año)
        Me.cbxMes.Items.Add("MAY " & Año)
        Me.cbxMes.Items.Add("JUN " & Año)
        Me.cbxMes.Items.Add("JUL " & Año)
        Me.cbxMes.Items.Add("AGO " & Año)
        Me.cbxMes.Items.Add("SEP " & Año)
        Me.cbxMes.Items.Add("OCT " & Año)
        Me.cbxMes.Items.Add("NOV " & Año)
        Me.cbxMes.Items.Add("DIC " & Año)
    End Sub
    Private Sub frmRegistrar_Gastos_x_Mes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MostrarMes()
        Me.txtFecha.Text = FechaSistema
    End Sub
    Private Sub cbxMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMes.SelectedIndexChanged
        Me.btnGenerar.Enabled = True
        Dim Mes As String
        Dim Año As String = FechaSistema.Year
        Año = Año.Substring(2, 2)
        If Me.cbxMes.SelectedItem.ToString = "ENE " & Año Then
            Mes = "01"
            _MES = 1
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/01/" & Año
            Dim FECHAHASTA As Date = DIAS & "/01/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                              & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA  AND L.IdEtapa_Cerdas ='E'"
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()

            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E'"
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************


        ElseIf Me.cbxMes.SelectedItem.ToString = "FEB " & Año Then
            Mes = "02"
            _MES = 2
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/02/" & Año
            Dim FECHAHASTA As Date = DIAS & "/02/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                              & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E'  "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "MAR " & Año Then
            Mes = "03"
            _MES = 3
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/03/" & Año
            Dim FECHAHASTA As Date = DIAS & "/03/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E'"
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "ABR " & Año Then
            Mes = "04"
            _MES = 4
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/04/" & Año
            Dim FECHAHASTA As Date = DIAS & "/04/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E'"
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "MAY " & Año Then
            Mes = "05"
            _MES = 5
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/05/" & Año
            Dim FECHAHASTA As Date = DIAS & "/05/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "JUN " & Año Then
            Mes = "06"
            _MES = 6
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/06/" & Año
            Dim FECHAHASTA As Date = DIAS & "/06/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "JUL " & Año Then
            Mes = "07"
            _MES = 7
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/07/" & Año
            Dim FECHAHASTA As Date = DIAS & "/07/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "AGO " & Año Then
            Mes = "08"
            _MES = 8
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/08/" & Año
            Dim FECHAHASTA As Date = DIAS & "/08/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E'"
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "SEP " & Año Then
            Mes = "09"
            _MES = 9
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/09/" & Año
            Dim FECHAHASTA As Date = DIAS & "/09/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "OCT " & Año Then
            Mes = "10"
            _MES = 10
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/10/" & Año
            Dim FECHAHASTA As Date = DIAS & "/10/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try

            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "NOV " & Año Then
            Mes = "11"
            _MES = 11
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/11/" & Año
            Dim FECHAHASTA As Date = DIAS & "/11/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try

            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        ElseIf Me.cbxMes.SelectedItem.ToString = "DIC " & Año Then
            Mes = "12"
            _MES = 12
            _AÑO = Año
            Me.txtGiff_No.Text = "G" & Mes & Año
            Dim DIAS As Integer = Date.DaysInMonth(Año, _MES)
            Dim FECHADESDE As Date = "01/12/" & Año
            Dim FECHAHASTA As Date = DIAS & "/12/" & Año
            oFechaHasta = FECHAHASTA
            '*******************************BALLON*************************************************
            'Try
            '    b.Close()
            'Catch ex As Exception

            'End Try
            Dim ALERTA As String = ""
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Balloon
            b.CaptionText = "NO LOTES AFECTADOS"
            Dim CMD As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                              & " SELECT COUNT(L.Lote_No)" _
                              & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ALERTA = " Nº LOTES: " & leer(0) & " |"
            End While
            con.Close()
            Me.cbxLotesAfectados.Items.Clear()
            Dim CMD2 As String = "DECLARE @FECHADESDE DATE DECLARE @FECHAHASTA DATE SET @FECHADESDE='" & FECHADESDE & "' SET @FECHAHASTA ='" & FECHAHASTA & "'" _
                               & " SELECT L.Lote_No" _
                               & " FROM LOTES L" _
                               & " JOIN Fechas_x_Lotes_para_GIFF fd on L.Lote_No=fd.Lote_No and fd.Incluye='True'" _
                               & " WHERE fd.Fecha BETWEEN @FECHADESDE AND @FECHAHASTA   AND L.IdEtapa_Cerdas ='E' "
            sql = New SqlCommand(CMD2, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxLotesAfectados.Items.Add(leer(0))
                ALERTA &= "," & leer(0)
            End While
            con.Close()

            b.Text = ALERTA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.btnGenerar, False)
            '*******************************BALLON*************************************************
        End If
    End Sub
    Sub CrearTabla_Entrada()
        Try
            TablaGastos.Clear()
            TablaGastos.Columns.Clear()
            With TablaGastos.Columns
                .Add(New DataColumn("CÓDIGO"))
                .Add(New DataColumn("TIPO G."))
                .Add(New DataColumn("DETALLE DE CUENTA"))
                .Add(New DataColumn(Me.cbxMes.Text))
            End With
            Me.dgvEntradaGastos.DataSource = TablaGastos
            Me.dgvEntradaGastos.Columns(0).Width = 70
            Me.dgvEntradaGastos.Columns(1).Width = 60
            Me.dgvEntradaGastos.Columns(2).Width = 200
            Me.dgvEntradaGastos.Columns(3).Width = 70

            Me.dgvEntradaGastos.Columns(0).ReadOnly = True
            Me.dgvEntradaGastos.Columns(1).ReadOnly = True
            Me.dgvEntradaGastos.Columns(2).ReadOnly = True
            Me.dgvEntradaGastos.Columns(3).ReadOnly = False

            Me.dgvEntradaGastos.Columns(3).DefaultCellStyle.Format = "##0.00"
            Me.dgvEntradaGastos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al Crear Tabla", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        ActualizarLote()
        Dim YAEXISTE_GIFF As Boolean = False
        sql = New SqlCommand("SELECT GIFF FROM REG_GASTOS_OPERACIONES WHERE GIFF='" & Me.txtGiff_No.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader()
        While leer.Read
            YAEXISTE_GIFF = True
        End While
        con.Close()
        If YAEXISTE_GIFF = True Then
            Dim resp As MsgBoxResult
            resp = MessageBoxEx.Show("Ya se ha generado el Mes: " & Me.cbxMes.Text & " anteriormente, si desea agregar mas gastos a la misma entrada presione Yes, si desea generar una nueva entrada con el mismo mes Presione No, ¡¡NOTA: RECUERDE QUE SI GENERA UNA NUEVA ENTRADA, SE TOMARÁN EN CUENTA LOS DATOS DE LA NUEVA ENTRADA", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = MsgBoxResult.Yes Then
                CrearTabla_Entrada()
                Dim CMD As String = "SELECT RG.CODIGO AS [CÓDIGO],RG.TIPO_GASTO AS [TIPO G.],CG.DESCRIPCION AS [DETALLE DE CUENTA], RG.ENTRADAS" _
                                  & " FROM REG_GASTOS_OPERACIONES RG" _
                                  & " JOIN Cuentas_Gastos CG ON RG.CODIGO =CG.CODIGO AND RG.TIPO_GASTO=CG.TIPO_GASTO" _
                                  & " WHERE RG.GIFF ='" & Me.txtGiff_No.Text & "'"
                sql = New SqlCommand(CMD, con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    dr = TablaGastos.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer(1)
                    dr(2) = leer(2)
                    dr(3) = leer(3)
                    Me.TablaGastos.Rows.Add(dr)
                End While
                con.Close()
                Me.btnGuardareInyectar.Enabled = True
                Me.btnGenerar.Enabled = False
                Me.txtTotal.Text = Sumar(Me.cbxMes.Text, dgvEntradaGastos)
                Me.cbxMes.Enabled = False
                Me.btnCerrar.Text = "&Cancelar"
                Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.button_cancel)
            ElseIf resp = MsgBoxResult.No Then

                CrearTabla_Entrada()
                Dim CMD As String = "SELECT CG.CODIGO AS [CÓDIGO] ,CG.TIPO_GASTO AS [TIPO G.] ,CG.DESCRIPCION AS [DETALLE DE CUENTA]" _
                                  & " FROM Cuentas_Gastos CG" _
                                  & " ORDER BY CG.TIPO_GASTO"
                sql = New SqlCommand(CMD, con)
                con.Open()
                leer = sql.ExecuteReader()
                While leer.Read
                    dr = TablaGastos.NewRow
                    dr(0) = leer(0)
                    dr(1) = leer(1)
                    dr(2) = leer(2)
                    dr(3) = Format(0, "##0.00")
                    TablaGastos.Rows.Add(dr)
                End While
                con.Close()
                Me.btnGuardareInyectar.Enabled = True
                Me.txtTotal.Text = "0.00"
                Me.btnGenerar.Enabled = False
                Me.cbxMes.Enabled = False
                Me.btnCerrar.Text = "&Cancelar"
                Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.button_cancel)
            End If
        Else
            CrearTabla_Entrada()
            Dim CMD As String = "SELECT CG.CODIGO AS [CÓDIGO] ,CG.TIPO_GASTO AS [TIPO G.] ,CG.DESCRIPCION AS [DETALLE DE CUENTA]" _
                              & " FROM Cuentas_Gastos CG" _
                              & " ORDER BY CG.TIPO_GASTO"
            sql = New SqlCommand(CMD, con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                dr = TablaGastos.NewRow
                dr(0) = leer(0)
                dr(1) = leer(1)
                dr(2) = leer(2)
                dr(3) = Format(0, "##0.00")
                TablaGastos.Rows.Add(dr)
            End While
            con.Close()
            Me.btnGuardareInyectar.Enabled = True
            Me.btnGenerar.Enabled = False
            Me.cbxMes.Enabled = False
            Me.btnCerrar.Text = "&Cancelar"
            Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.button_cancel)
        End If
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If Me.btnCerrar.Text = "&Cerrar" Then
            Me.Close()
        ElseIf Me.btnCerrar.Text = "&Cancelar" Then
            Dim resp As MsgBoxResult
            resp = MessageBoxEx.Show("Si cancela la operación se perderán los datos que haya ingresado desea continuar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = MsgBoxResult.Yes Then
                TablaGastos.Rows.Clear()
                TablaGastos.Columns.Clear()
                Me.btnGuardareInyectar.Enabled = False
                Me.txtTotal.Text = "0.00"
                Me.btnGenerar.Enabled = True
                Me.cbxMes.Enabled = True
                Me.btnCerrar.Text = "&Cerrar"
                Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
                b.Close()
            End If
        End If
    End Sub
    Sub TotalesGastosGySueldosP()
        Try
            Dim totalGastosG, totalsueldosp As Integer
            For i As Integer = 0 To Me.dgvEntradaGastos.RowCount - 1
                If RTrim(Me.dgvEntradaGastos.Rows(i).Cells("TIPO G.").Value) = "SP" Then
                    totalsueldosp += Me.dgvEntradaGastos.Rows(i).Cells(3).Value
                ElseIf RTrim(Me.dgvEntradaGastos.Rows(i).Cells("TIPO G.").Value) = "GG" Then
                    totalGastosG += Me.dgvEntradaGastos.Rows(i).Cells(3).Value
                End If
            Next
            Me.TotalSueldosyP.Text = totalsueldosp
            Me.TotalGastosG.Text = totalGastosG
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub dgvEntradaGastos_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEntradaGastos.CellEnter
        
    End Sub

    Private Sub dgvEntradaGastos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEntradaGastos.RowEnter
        TotalesGastosGySueldosP()
    End Sub
    Private Sub dgvEntradaGastos_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEntradaGastos.RowLeave
        Me.dgvEntradaGastos.EndEdit()
        Try
            If Me.dgvEntradaGastos.Rows(e.RowIndex).Cells(Me.cbxMes.Text).Value = "" Then
                Me.dgvEntradaGastos.Rows(e.RowIndex).Cells(Me.cbxMes.Text).Value = "0.00"
            End If
            Try
                Me.txtTotal.Text = Sumar(Me.cbxMes.Text, dgvEntradaGastos)
            Catch ex As Exception

            End Try
        Catch ex As Exception
            If ex.Message.ToString = "El operador '=' no está definido para tipo 'DBNull' ni para cadena """ Then
                Me.dgvEntradaGastos.Rows(e.RowIndex).Cells(Me.cbxMes.Text).Value = "0.00"
            Else
                Me.dgvEntradaGastos.Rows(e.RowIndex).Cells(Me.cbxMes.Text).Value = "0.00"
            End If
        End Try
    End Sub
    Sub Guardar_e_InyectarGIFF()
        Try
            Dim TotalCerdosLotes As Integer = 0
            For i As Integer = 0 To Me.cbxLotesAfectados.Items.Count - 1
                sql = New SqlCommand("select No_Cerdos from Costos_al_Nacer_x_Lotes where Lote_No='" & Me.cbxLotesAfectados.Items(i).ToString & "' and DesteteNo like 'Dt.%'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    TotalCerdosLotes += leer(0)
                End While
                con.Close()
            Next
            Dim TotalEntradas As Double = Sumar(Me.cbxMes.Text, Me.dgvEntradaGastos)
            For I As Integer = 0 To Me.dgvEntradaGastos.Rows.Count - 1
                sql = New SqlCommand("INSERT INTO REG_GASTOS_OPERACIONES (GIFF,CODIGO,TIPO_GASTO,MES,AÑO,ENTRADAS,FECHA,USUARIO_CREADOR)" _
                                 & " VALUES('" & Me.txtGiff_No.Text & "','" & Me.dgvEntradaGastos.Rows(I).Cells("CÓDIGO").Value & "','" & Me.dgvEntradaGastos.Rows(I).Cells("TIPO G.").Value & "','" & Me.cbxMes.Text & "','" & _AÑO & "','" & Me.dgvEntradaGastos.Rows(I).Cells(cbxMes.Text).Value & "','" & oFechaHasta & "','" & UsuarioActual & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            Next
            For I As Integer = 0 To Me.cbxLotesAfectados.Items.Count - 1
                Dim ENTRADA As Double = 0
                Dim ENTRADATOTAL As Double = 0
                Dim CERDOSLOTES As Integer = 0
                sql = New SqlCommand("select No_Cerdos from Costos_al_Nacer_x_Lotes where Lote_No='" & Me.cbxLotesAfectados.Items(I).ToString & "'  and DesteteNo like 'Dt.%'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CERDOSLOTES += leer(0)
                End While
                con.Close()

                Dim FechaDestete As DateTime
                Try
                    sql = New SqlCommand("select convert(datetime, Fecha_movimiento) from Movimientos_Lotes_Int mi where mi.A_Lote= '" & RTrim(Me.cbxLotesAfectados.Items(I).ToString) & "' and mi.Documento_NO LIKE 'Dt%' and mi.Motivo like '(M. Y A.)DESTETE CERDOS%'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    FechaDestete = Me.txtFecha.Text
                    While leer.Read
                        FechaDestete = Format(leer(0), "dd/MM/yyyy")
                    End While
                    con.Close()

                Catch ex As Exception
                    FechaDestete = "01/01/1901"
                End Try

                ENTRADA = (((TotalEntradas / TotalCerdosLotes) * CERDOSLOTES) / CERDOSLOTES)
                ENTRADATOTAL = ((TotalEntradas / TotalCerdosLotes) * CERDOSLOTES)
                Dim CMDINSERTAR As String = "DECLARE @ENTRADA FLOAT DECLARE @ENTRADATOTAL FLOAT DECLARE @LOTE_NO char(8) DECLARE @GIFF CHAR(12) SET @ENTRADA ='" & ENTRADA & "' SET @ENTRADATOTAL='" & ENTRADATOTAL & "' SET @LOTE_NO ='" & Me.cbxLotesAfectados.Items(I).ToString & "' SET @GIFF ='" & Me.txtGiff_No.Text & "'" _
                              & " INSERT INTO Costos_al_Nacer_x_Lotes VALUES(@LOTE_NO ,@ENTRADA,'" & FechaDestete & "',@GIFF,'" & 0 & "')" _
                              & " INSERT INTO Entradas_Lotes_Costos VALUES(@LOTE_NO ,@ENTRADATOTAL,@GIFF)" _
                              & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES(0,@LOTE_NO ,'" & FechaDestete & "','INYECCIÓN GIFF GASTOS DE OPERACIONES','" & CERDOSLOTES & "','" & UsuarioActual & "',@ENTRADATOTAL,@GIFF)" _
                              & " UPDATE LOTES SET Asignacion_GIF =@GIFF WHERE Lote_No =@LOTE_NO"


                sql = New SqlCommand(CMDINSERTAR, con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al guardar e inyectar GIFF", MessageBoxButtons.OK, MessageBoxIcon.Error)
        con.Close()
        End Try
    End Sub
    Private Sub btnGuardareInyectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardareInyectar.Click
        If Me.cbxLotesAfectados.Items.Count = 0 Then
            MessageBoxEx.Show("No se encontro ningún lote en el mes: " & Me.cbxMes.Text, "Sin Lotes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Me.txtTotal.Text = "0.00" Or Me.txtTotal.Text = "0" Then
            MessageBoxEx.Show("No hay ningun gasto ingresado el total es: 0.00, no puede proceder", "Sin Entradas", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            Dim YAEXISTE_GIFF As Boolean = False
            sql = New SqlCommand("SELECT GIFF FROM REG_GASTOS_OPERACIONES WHERE GIFF='" & Me.txtGiff_No.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                YAEXISTE_GIFF = True
            End While
            con.Close()
            If YAEXISTE_GIFF = True Then
                Dim resp As MsgBoxResult
                resp = MessageBoxEx.Show("Se ha encontrado una entrada de gastos que se generó el mismo mes de:" & Me.cbxMes.Text & " si procede se reemplazará el GIFF, por la nueva entrada ó los gastos que se hayan agregado a la misma, ¿desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    Dim CMDBORRARENTRADAS As String = "declare @GIFF char(12) set @GIFF = '" & Me.txtGiff_No.Text & "'" _
                                                   & " DELETE FROM REG_GASTOS_OPERACIONES WHERE GIFF =@GIFF" _
                                                   & " DELETE FROM Costos_al_Nacer_x_Lotes WHERE DesteteNo =@GIFF" _
                                                   & " DELETE FROM Entradas_Lotes_Costos WHERE Doc_Entrada= @GIFF" _
                                                   & " DELETE FROM MOVIMIENTOS_LOTES_INT WHERE Documento_NO =@GIFF"
                    sql = New SqlCommand(CMDBORRARENTRADAS, con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    Guardar_e_InyectarGIFF()
                    b.Close()
                    Dim LOTESAFECTADOS As String = ""
                    For I As Integer = 0 To Me.cbxLotesAfectados.Items.Count - 1
                        LOTESAFECTADOS &= "," & Me.cbxLotesAfectados.Items(I).ToString
                    Next
                    MessageBoxEx.Show("Se ha Inyectado el GIFF de Gastos exitosamente a el/los Lote/s: [" & LOTESAFECTADOS & "]", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cbxLotesAfectados.Items.Clear()
                    TablaGastos.Rows.Clear()
                    TablaGastos.Columns.Clear()
                    Me.btnGuardareInyectar.Enabled = False
                    Me.txtTotal.Text = "0.00"
                    Me.btnGenerar.Enabled = True
                    Me.cbxMes.Enabled = True
                    Me.btnCerrar.Text = "&Cerrar"
                    Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
                    Me.MostrarMes()
                    Me.btnGenerar.Enabled = False
                    b.Close()

                End If
            Else
                Guardar_e_InyectarGIFF()
                b.Close()
                Dim LOTESAFECTADOS As String = ""
                For I As Integer = 0 To Me.cbxLotesAfectados.Items.Count - 1
                    LOTESAFECTADOS &= "," & Me.cbxLotesAfectados.Items(I).ToString
                Next
                MessageBoxEx.Show("Se ha Inyectado el GIFF de Gastos exitosamente a el/los Lote/s: [" & LOTESAFECTADOS & "]", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cbxLotesAfectados.Items.Clear()
                TablaGastos.Rows.Clear()
                TablaGastos.Columns.Clear()
                Me.btnGuardareInyectar.Enabled = False
                Me.txtTotal.Text = "0.00"
                Me.btnGenerar.Enabled = True
                Me.cbxMes.Enabled = True
                Me.btnCerrar.Text = "&Cerrar"
                Me.btnCerrar.Image = New System.Drawing.Bitmap(My.Resources.cerrar)
                Me.MostrarMes()
                Me.btnGenerar.Enabled = False
                b.Close()
            End If
        End If
        
    End Sub

   
    Private Sub dgvEntradaGastos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEntradaGastos.CellContentClick

    End Sub

    Private Sub dgvEntradaGastos_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntradaGastos.CellLeave
        
    End Sub
End Class