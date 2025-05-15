Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports Excel = Microsoft.Office.Interop.Excel

Module Conexion
    Public con As New SqlConnection(My.Settings.BDGRANJAConnectionString.ToString)
    Public ConRespaldo As New SqlConnection(My.Settings.conMaster.ToString)
    Public sql, sql2 As SqlCommand
    Public dr As DataRow
    Public dt As DataTable
    Public leer, leer2 As SqlDataReader
    Public dv As DataView
    Public CadenaError As String = "Se ha producido la siguiente exepción: "
    Public oAdapter As SqlDataAdapter
    Public Dts As DataSet
    Dim oDr As DataRow
    Dim oDv As DataView
    Public UsuarioActual As String
    Dim ExisteLote As Boolean = True
    Public TipoUsuario As String
    Public GranjaNo_ListaLotes As String
    Public SeleccionoGranja As Boolean
    Public FechaEstimada As Date
    Public IdEnseminacion_x As Integer
    Public FechaSistema As Date
    Public UsuarioSistema As String
    Public CUnitario As String = "Mensual"
    Public odtsBDGRANJA As New DtsBDGRANJA
    Dim odtsPesos As New dtsPesosCerdosProcesos
    Public ProcesosCerdasAdapter As New dtsPesosCerdosProcesosTableAdapters.Procesos_CerdasTableAdapter

    'End If'************BLOQUEAR LETRAS*****************

    'If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
    'e.Handled = False
    'Else
    'e.Handled = True

    '*********************************************
    '********************BLOQUEAR NUMEROS*********
    'If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Then
    'e.Handled = False
    'Me.DetectorError.Clear()
    'Else
    'Me.DetectorError.SetError(Me.TxtSerie, "No se puede ingresar numeros en un campo serie")
    'e.Handled = True
    'End If
    '*********************************************
    '*********************FORMATO DE FECHAS****************************
    'If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 47 And Not Asc(e.KeyChar) = 46 And Not Asc(e.KeyChar) = 45 Then
    '          e.Handled = False
    '      Else
    '          e.Handled = True
    '      End If
    '      If txtFecha.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
    '          txtFecha.Text = txtFecha.Text & "/"
    '          txtFecha.SelectionStart = 4
    '      ElseIf txtFecha.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
    '          txtFecha.Text = txtFecha.Text & "/"
    '          txtFecha.SelectionStart = 6
    '      End If
    '******************************************************************
    Public Sub RegistrarDefuncion(ByVal LoteNo As String, ByVal NoDefunciones As Integer, ByVal Motivo As String, ByVal FechaDefuncion As Date, ByVal DefuncionNO As Integer, ByVal Codigo_Cerdo As String, ByVal Motivo2 As String, ByVal Peso As Double)
        Try
            sql = New SqlCommand("INSERT INTO DEFUNCIONES([Lote_No], [No_Defunciones], [Motivo], [Fecha_Defuncion], [DefuncionNo], [Codigo_Cerdo], [Motivo2], [Peso]) VALUES('" & LoteNo & "','" & NoDefunciones & "','" & Motivo & "','" & FechaDefuncion & "','" & DefuncionNO & "','" & Codigo_Cerdo & "', '" & Motivo2 & "', " & Peso & ")", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al registrar Defuncion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Public Sub IngresarHistorico(ByVal LoteNo As String, ByVal IDInseminacion As Integer, ByVal DesteNo As Integer)
        Try
            sql = New SqlCommand("insert into HistoricoLotes_Inseminacion values('" & LoteNo & "','" & IDInseminacion & "','" & DesteNo & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al ingresar historico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Public Sub RevisarDepreciacion(ByVal CodigoCerda As String, ByVal DepreciacionRestar As Double, ByVal Fecha As Date)
        Try
            Dim DepreciacionActualCosto As Double = 0
            Dim DepreciacionPartosActual As Integer = 0
            sql = New SqlCommand("select Depreciacion_Costo,Depreciacion_Partos from Depreciacion_x_Cerda where Codigo_Cerda='" & CodigoCerda & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                DepreciacionActualCosto = leer(0)
                DepreciacionPartosActual = leer(1)
            End While
            con.Close()

            sql = New SqlCommand("UPDATE Depreciacion_x_Cerda SET Depreciacion_Costo='" & (DepreciacionActualCosto - DepreciacionRestar) & "', Depreciacion_Partos='" & (DepreciacionPartosActual - 1) & "',Fecha_Ultima_Modificacion='" & Fecha & "' WHERE Codigo_Cerda='" & CodigoCerda & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al actualizar Depreciación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub AgregarNoCerdas_Movimientos_Costos(ByVal LoteNo As String, ByVal Cantidad As Integer)
        Try
            Dim existeLote As Boolean = False
            sql = New SqlCommand("select No_Cerdos from No_Cerdas_Lotes_Moviento_Costo where Lote_No='" & LoteNo & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                existeLote = True
            End While
            con.Close()
            If existeLote = False Then
                Try
                    Dim ID As Integer
                    sql = New SqlCommand("select max(ID) from No_Cerdas_Lotes_Moviento_Costo", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        If leer.IsDBNull(0) = True Then
                            ID = 0
                        Else
                            ID = leer(0) + 1
                        End If
                    End While
                    con.Close()

                    sql = New SqlCommand("insert into No_Cerdas_Lotes_Moviento_Costo values('" & ID & "','" & LoteNo & "','A','" & Cantidad & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "Error AgregarNoCerdas_Movimientos_Costos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try
            Else
                Try
                    Dim CerdosActuales As Integer = 0
                    sql = New SqlCommand("select No_Cerdos from No_Cerdas_Lotes_Moviento_Costo where Lote_No='" & LoteNo & "'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        CerdosActuales = leer(0)
                    End While
                    con.Close()
                
                    sql = New SqlCommand("update No_Cerdas_Lotes_Moviento_Costo set No_Cerdos='" & Cantidad + CerdosActuales & "' where Lote_No='" & LoteNo & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message, "Error AgregarNoCerdas_Movimientos_Costos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try
            End If
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al agregar registro de cerdas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Public Sub RevisarCierre_Lote(ByVal LoteNo As String, ByVal CajaTextoLimpiar As ComboBox)
        Dim NoCerdas As Integer = 0
        sql = New SqlCommand("select Total_Cerdos from Total_Cerdos_Lote where Lote_No='" & LoteNo & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            NoCerdas = leer(0)
        End While
        con.Close()
        If NoCerdas = 0 Then
            Try

                sql = New SqlCommand("update LOTES set Estado ='T' WHERE Lote_No='" & LoteNo & "'", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                sql = New SqlCommand("insert into Cierres_Lotes values('" & LoteNo & "','" & FechaSistema & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                MessageBoxEx.Show("El Lote: " & LoteNo & " se ha cerrado correctamente", "Lote Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CajaTextoLimpiar.Text = ""
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error RevisarCierre_Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        Else
            Try

                sql = New SqlCommand("update LOTES set Estado ='A' WHERE Lote_No='" & LoteNo & "'", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error RevisarCierre_Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub
    Public Function CorrelativoDonacion() As Integer


        sql = New SqlCommand("SELECT MAX(ID_Donacion) FROM Registro_Donaciones_Cerdas_Lotes", con)
        Dim ID_Donacion As Integer = 0
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            If leer.IsDBNull(0) = True Then
                ID_Donacion = 1
            Else
                ID_Donacion = leer(0) + 1
            End If
        End While
        con.Close()

        Return ID_Donacion
    End Function
    Public Sub RegistrarDonacion(ByVal ID_Donacion As Integer, ByVal Lote_que_Dona As String, ByVal Cerda_que_Dona As String, ByVal CantidadDonaciones As Integer, ByVal Lote_recibe_Donacion As String, ByVal Cerda_recibe_Donacion As String, ByVal NoCerdos_Traia_Cerda As Integer, ByVal Costo As Double, ByVal Id_Insem_Adopta As Integer, ByVal Id_Insem_Dona As Integer)
        Try

            sql = New SqlCommand("INSERT INTO Registro_Donaciones_Cerdas_Lotes VALUES('" & ID_Donacion & "','" & Lote_que_Dona & "','" & Cerda_que_Dona & "','" & CantidadDonaciones & "','" & Lote_recibe_Donacion & "','" & Cerda_recibe_Donacion & "','" & NoCerdos_Traia_Cerda & "','" & Costo & "','" & Id_Insem_Adopta & "','" & FechaSistema & "','" & Id_Insem_Dona & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al registrar Donación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub HalarCostos_de_Vacias_a_Montas(ByVal DeLote As String, ByVal ALote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal Cantidad As Integer, ByVal NoDocumento As String)
        Try
     
            'Dim Fecha1 As Date = DateAdd(DateInterval.Day, -1, FechaSistema)
            'Dim Fecha2 As Date = FechaSistema
            'Dim CMD2 As String = "INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & Cantidad & "','" & UsuarioActual & "',((SELECT ISNULL((SUM(Costo)),0) FROM MOVIMIENTOS_LOTES_INT m WHERE m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "')+(SELECT ISNULL((SUM(Importe)),0) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "' and (L.Fecha_Liquidacion between '" & Fecha1 & "' AND '" & Fecha2 & "') and Viva='" & True & "'))/" _
            '                     & " isnull((SELECT Total_Cerdos from Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "'),1)*'" & Cantidad & "','" & NoDocumento & "' )"
            'Dim CMD As String = "DECLARE @TotalCerdos int" _
            '                  & " DECLARE @FECHA1 DATE" _
            '                  & " DECLARE @FECHA2 DATE" _
            '                  & " SET @FECHA1 = '" & Fecha1 & "'" _
            '                  & " SET @FECHA2 = '" & Fecha2 & "'" _
            '                  & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
            '                  & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & Cantidad & "','" & UsuarioActual & "',((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
            '                  & " ((SELECT (isnull(SUM(Importe),0)) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "' and (L.Fecha_Liquidacion between @FECHA1 AND @FECHA2) and Viva='" & True & "'/" _
            '                  & " (@TotalCerdos)))*'" & Cantidad & "'), '" & NoDocumento & "')"
            'sql = New SqlCommand(CMD2, con)
            'con.Open()
            'sql.ExecuteNonQuery()
            'con.Close()

            Dim cmd As String = "INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & Cantidad & "','" & UsuarioActual & "',isnull((" _
                              & " select (((select sum(importe) from Lineas_de_Requisiciones lr" _
                              & " where lr.Viva = 'True' and lr.Lote_No = '" & DeLote & "' and lr.Fecha_Liquidacion <= '" & FechaMovimiento & "') -" _
                              & " (isnull((select SUM(costo) from Movimientos_Lotes_Int m where m.Fecha_Movimiento < '" & FechaMovimiento & "' and m.de_Lote = '" & DeLote & "'),0))) /" _
                              & " case when (select ((isnull((SUM(ml.Entrada )),0))-(isnull((SUM(ml.Defuncion)),0)+isnull((SUM(ml.Destazo)),0)+isnull((SUM(ml.Rastro)),0)+isnull((SUM(ml.Reemplazos)),0)+isnull((SUM(ml.Salida)),0))) from Movimiento_Lote ml where ml.Lote_No ='" & DeLote & "' and ml.Fecha_Movimiento < '" & FechaMovimiento & "') = 0" _
                              & " then" _
                              & "    1" _
                              & " else" _
                              & " (select ((isnull((SUM(ml.Entrada )),0))-(isnull((SUM(ml.Defuncion)),0)+isnull((SUM(ml.Destazo)),0)+isnull((SUM(ml.Rastro)),0)+isnull((SUM(ml.Reemplazos)),0)+isnull((SUM(ml.Salida)),0))) from Movimiento_Lote ml where ml.Lote_No ='" & DeLote & "' and ml.Fecha_Movimiento < '" & FechaMovimiento & "')" _
                              & " end" _
                              & " * '" & Cantidad & "')),0),'" & NoDocumento & "')"
            sql = New SqlCommand(cmd, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()

            'Dim cmd2 As String = "INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & 0 & "','" & DeLote & "','" & FechaMovimiento & "','" & Motivo & "','" & Cantidad & "','" & UsuarioActual & "',-isnull((" _
            '                  & " select (((select sum(importe) from Lineas_de_Requisiciones lr" _
            '                  & " where lr.Viva = 'True' and lr.Lote_No = '" & DeLote & "' and lr.Fecha_Liquidacion <= '" & FechaMovimiento & "') +" _
            '                  & " (isnull((select SUM(costo) from Movimientos_Lotes_Int m where m.Fecha_Movimiento < '" & FechaMovimiento & "' and m.A_Lote = '" & DeLote & "'),0))) /" _
            '                  & " case when (select ((isnull((SUM(ml.Entrada )),0))-(isnull((SUM(ml.Defuncion)),0)+isnull((SUM(ml.Destazo)),0)+isnull((SUM(ml.Rastro)),0)+isnull((SUM(ml.Reemplazos)),0)+isnull((SUM(ml.Salida)),0))) from Movimiento_Lote ml where ml.Lote_No ='" & DeLote & "' and ml.Fecha_Movimiento < '" & FechaMovimiento & "') = 0" _
            '                  & " then" _
            '                  & "    1" _
            '                  & " else" _
            '                  & " (select ((isnull((SUM(ml.Entrada )),0))-(isnull((SUM(ml.Defuncion)),0)+isnull((SUM(ml.Destazo)),0)+isnull((SUM(ml.Rastro)),0)+isnull((SUM(ml.Reemplazos)),0)+isnull((SUM(ml.Salida)),0))) from Movimiento_Lote ml where ml.Lote_No ='" & DeLote & "' and ml.Fecha_Movimiento < '" & FechaMovimiento & "')" _
            '                  & " end" _
            '                  & " * '" & Cantidad & "')),0),'" & NoDocumento & "')"
            'sql = New SqlCommand(cmd2, con)
            'con.Open()
            'sql.ExecuteNonQuery()
            'con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al halar el costo de Vacias a Montas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Sub HalarCostos_Montas_a_Gestacion(ByVal DeLote As String, ByVal ALote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal Cantidad As Integer, ByVal CantidadTotal As Integer, ByVal NoDocumento As String)
        Try
            'Dim ID_Movimiento As Integer = 0
            'sql = New SqlCommand("select max(ID_Movimiento) from MOVIMIENTOS_LOTES_INT", con)
            'con.Open()
            'leer = sql.ExecuteReader
            'While leer.Read
            '    If leer.IsDBNull(0) = True Then
            '        ID_Movimiento = 0
            '    Else
            '        ID_Movimiento = leer(0) + 1
            '    End If
            'End While
            'con.Close()
            Dim CMD As String = "DECLARE @TotalCerdos int" _
                              & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
                              & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & Cantidad & "','" & UsuarioActual & "',((((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
                              & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
                              & " ))))/(SELECT ISNULL((No_Cerdos),1) FROM No_Cerdas_Lotes_Moviento_Costo WHERE Lote_No='" & DeLote & "')))*('" & CantidadTotal & "')),'" & NoDocumento & "')"
            sql = New SqlCommand(CMD, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al halar el costo de Montas a Gestacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub HalarCostos_de_Gestacion_a_Engorde(ByVal DeLote As String, ByVal ALote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal CantidadTotal As Integer, ByVal CantidadTraladar As Integer, ByVal NoCerdas As Integer, ByVal NoDocumento As String, accion As String, total_peso_cerditos As Double, fechaDesarrollo As DateTime, Optional documento As String = "")
        Try

            If accion = "insertar" Then
                Dim TipoMovi As String = "Dt."
                Dim CMD As String = "DECLARE @TotalCerdos int" _
                                  & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
                                  & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & CantidadTraladar & "','" & UsuarioActual & "',(((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
                                  & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
                                  & " ))/(SELECT ISNULL((No_Cerdos),1) FROM No_Cerdas_Lotes_Moviento_Costo WHERE Lote_No='" & DeLote & "')*('" & NoCerdas & "'))))/('" & CantidadTotal & "'))*'" & CantidadTraladar & "','" & NoDocumento & "')"
                sql = New SqlCommand(CMD, con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                Try
                    Dim Dias As Integer = 0
                    Dias = Date.DaysInMonth(FechaSistema.Year, FechaSistema.Month)
                    Dim UltimaFechaMes As Date = Dias & "/" & FechaSistema.Month & "/" & FechaSistema.Year
                    sql = New SqlCommand("insert into Fechas_x_Lotes_para_GIFF values('" & ALote & "','" & UltimaFechaMes & "','" & True & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                End Try
            ElseIf accion = "actualizar" Then
                Dim TipoMovi As String = "Dt."
                Dim CMD As String = "DECLARE @TotalCerdos int" _
                                  & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
                                  & " UPDATE MOVIMIENTOS_LOTES_INT set Cantidad = Cantidad + " & CantidadTraladar & ", Costo = Costo + (((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
                                  & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
                                  & " ))/(SELECT ISNULL((No_Cerdos),1) FROM No_Cerdas_Lotes_Moviento_Costo WHERE Lote_No='" & DeLote & "')*('" & NoCerdas & "'))))/('" & CantidadTotal & "'))*'" & CantidadTraladar & "' where Documento_NO = '" & documento & "' and A_Lote='" & ALote & "'"
                sql = New SqlCommand(CMD, con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                Try
                    Dim Dias As Integer = 0
                    Dias = Date.DaysInMonth(FechaSistema.Year, FechaSistema.Month)
                    Dim UltimaFechaMes As Date = Dias & "/" & FechaSistema.Month & "/" & FechaSistema.Year
                    sql = New SqlCommand("update  Fechas_x_Lotes_para_GIFF set Fecha = '" & UltimaFechaMes & "'  where Lote_No ='" & ALote & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                End Try
            End If

            Dim r As String = ClaseDestetes.insertarDesteteCompletoParcial(New Destetes_Completos_o_Parciales() With {.Fecha = FechaMovimiento, .Documento = NoDocumento, .Lote_Engorde = ALote, .Lote_Gestacion = DeLote, .No_Cerdas = NoCerdas, .No_Cerditos = CantidadTraladar, .Tota_Peso = total_peso_cerditos})
            If r.Contains("Error: ") Then
                MessageBoxEx.Show(r, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Dim cmdStr As String = "if not exists(select f.Fecha from Fecha_Dias_Desarrollo f where f.Lote_No = '" & ALote & "') begin
	                                    insert Fecha_Dias_Desarrollo ([Lote_No], [Fecha], [Dias], [Fecha_Semanal])
	                                    select '" & ALote & "', '" & fechaDesarrollo & "', 0, NULL
                                    end
                                    else begin
	                                    update f
		                                    set Fecha = '" & fechaDesarrollo & "'
	                                    from Fecha_Dias_Desarrollo f
	                                    where f.Lote_No = '" & ALote & "'
                                    end"

            Dim cmd2 As New SqlCommand(cmdStr, con)
            cmd2.CommandType = CommandType.Text
            'cmd2.Parameters.Add("@LoteSeCargaron", SqlDbType.Char, 8).Value = ALote

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd2.ExecuteNonQuery()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al halar el costo de Gestacion a Engorde", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub Costo_al_Nacer(ByVal ALote As String, ByVal TotalEngordes As Integer, NoEngorgesDestetar As Integer, ByVal Fecha As Date, ByVal NoDocumento As String, accion As String)
        Try

            If accion = "insertar" Then
                sql = New SqlCommand("INSERT INTO Costos_al_Nacer_x_Lotes VALUES('" & ALote & "',((SELECT isnull((SUM(Costo)),0) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & ALote & "')/'" & TotalEngordes & "'),'" & Fecha & "','" & NoDocumento & "','" & NoEngorgesDestetar & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            ElseIf accion = "actualizar" Then
                sql = New SqlCommand("UPDATE Costos_al_Nacer_x_Lotes SET Costo_al_Nacer = Costo_al_Nacer +  ((SELECT isnull((SUM(Costo)),0) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & ALote & "')/'" & TotalEngordes & "'), No_Cerdos = No_Cerdos + " & NoEngorgesDestetar & " where DesteteNo ='" & NoDocumento & "' and Lote_No = '" & ALote & "'", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            End If



            'ACTUALIZA EL COSTO A NACER ESTIMADO, EL VALOR REAL LO DA EL RECALCULO
            Dim cadena As String = "update c
	                                    set Costo_al_Nacer = isnull((select m.Costo / m.Cantidad from Movimientos_Lotes_Int m where m.A_Lote = c.Lote_No and m.Documento_NO = c.DesteteNo and m.Motivo like '(M. Y A.)DESTETE CERDOS%' ),0)
                                    FROM Costos_al_Nacer_x_Lotes c
                                    where c.Lote_No = '" & ALote & "' and c.DesteteNo = '" & NoDocumento & "'"

            sql = New SqlCommand(cadena, con)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            sql.ExecuteNonQuery()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If



        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al " & accion & " costo al nacer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub HalarCostos_Donaciones(ByVal DeLote As String, ByVal ALote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal CantidadTotal As Integer, ByVal CantidadTraladar As Integer, ByVal Donaciones As Integer, ByVal NoCerdas As Integer, ByVal NoDocumento As String)
        Try
            'Dim ID_Movimiento As Integer = 0
            'sql = New SqlCommand("select max(ID_Movimiento) from MOVIMIENTOS_LOTES_INT", con)
            'con.Open()
            'leer = sql.ExecuteReader
            'While leer.Read
            '    If leer.IsDBNull(0) = True Then
            '        ID_Movimiento = 0
            '    Else
            '        ID_Movimiento = leer(0) + 1
            '    End If
            'End While
            'con.Close()
            Dim CMD As String = "DECLARE @TotalCerdos int" _
                              & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
                              & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & CantidadTraladar & "','" & UsuarioActual & "',((((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
                              & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
                              & " ))/(SELECT ISNULL((No_Cerdos),1) FROM No_Cerdas_Lotes_Moviento_Costo WHERE Lote_No='" & DeLote & "')*('" & NoCerdas & "'))))/('" & CantidadTotal & "'))*'" & CantidadTraladar & "'),'" & NoDocumento & "')"
            sql = New SqlCommand(CMD, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al halar el costo donaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        End Try
    End Sub

    'Public Sub HalarCostos_DonacionesCompleta(ByVal DeLote As String, ByVal ALote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal CantidadTotal As Integer, ByVal CantidadTraladar As Integer, ByVal Donaciones As Integer, ByVal NoCerdas As Integer, ByVal NoDocumento As String)
    '    Try
    '        'Dim ID_Movimiento As Integer = 0
    '        'sql = New SqlCommand("select max(ID_Movimiento) from MOVIMIENTOS_LOTES_INT", con)
    '        'con.Open()
    '        'leer = sql.ExecuteReader
    '        'While leer.Read
    '        '    If leer.IsDBNull(0) = True Then
    '        '        ID_Movimiento = 0
    '        '    Else
    '        '        ID_Movimiento = leer(0) + 1
    '        '    End If
    '        'End While
    '        'con.Close()
    '        Dim CMD As String = "DECLARE @TotalCerdos int" _
    '                          & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
    '                          & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & CantidadTraladar & "','" & UsuarioActual & "',((((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "' ),0))+" _
    '                          & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
    '                          & " ))/(SELECT ISNULL((No_Cerdos),1) FROM No_Cerdas_Lotes_Moviento_Costo WHERE Lote_No='" & DeLote & "')*('" & NoCerdas & "'))))/('" & CantidadTotal & "'))*'" & CantidadTraladar & "'),'" & NoDocumento & "')"
    '        sql = New SqlCommand(CMD, con)
    '        con.Open()
    '        sql.ExecuteNonQuery()
    '        con.Close()

    '        Dim CMD2 As String = "DECLARE @TotalCerdos int" _
    '                          & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
    '                          & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('0','" & DeLote & "','" & FechaMovimiento & "','" & Motivo & "','" & CantidadTraladar & "','" & UsuarioActual & "',-((((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
    '                          & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
    '                          & " ))/(SELECT ISNULL((No_Cerdos),1) FROM No_Cerdas_Lotes_Moviento_Costo WHERE Lote_No='" & DeLote & "')*('" & NoCerdas & "'))))/('" & CantidadTotal & "'))*'" & CantidadTraladar & "'),'" & NoDocumento & "')"
    '        sql = New SqlCommand(CMD2, con)
    '        con.Open()
    '        sql.ExecuteNonQuery()
    '        con.Close()
    '    Catch ex As Exception
    '        MessageBoxEx.Show(CadenaError & ex.Message, "Error al halar el costo donaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        con.Close()
    '    End Try
    'End Sub
    Public Sub HalarCostos_Traslados(ByVal DeLote As String, ByVal ALote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal CantidadTraladar As Integer, ByVal NoDocumento As String)
        Try
            'Dim ID_Movimiento As Integer = 0
            'sql = New SqlCommand("select max(ID_Movimiento) from MOVIMIENTOS_LOTES_INT", con)
            'con.Open()
            'leer = sql.ExecuteReader
            'While leer.Read
            '    If leer.IsDBNull(0) = True Then
            '        ID_Movimiento = 0
            '    Else
            '        ID_Movimiento = leer(0) + 1
            '    End If
            'End While
            'con.Close()
            Dim CMD As String = "DECLARE @TotalCerdos int" _
                              & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
                              & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & CantidadTraladar & "','" & UsuarioActual & "',((((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
                              & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
                              & " )))))/(SELECT ISNULL((Total_Cerdos),1) FROM Total_Cerdos_Lote WHERE Lote_No='" & DeLote & "'))*'" & CantidadTraladar & "'),'" & NoDocumento & "')"

            sql = New SqlCommand(CMD, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
            'sql = New SqlCommand("select max(ID_Movimiento) from MOVIMIENTOS_LOTES_INT", con)
            'con.Open()
            'leer = sql.ExecuteReader
            'While leer.Read
            '    If leer.IsDBNull(0) = True Then
            '        ID_Movimiento = 0
            '    Else
            '        ID_Movimiento = leer(0) + 1
            '    End If
            'End While
            'con.Close()
            Dim cmd2 As String = "DECLARE @TotalCerdos int" _
                              & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
                              & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & 0 & "','" & DeLote & "','" & FechaMovimiento & "','" & Motivo & "','" & CantidadTraladar & "','" & UsuarioActual & "',-((((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
                              & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
                              & " )))))/(SELECT ISNULL((Total_Cerdos ),1) FROM Total_Cerdos_Lote WHERE Lote_No='" & DeLote & "'))*'" & CantidadTraladar & "'),'" & NoDocumento & "')"
            sql = New SqlCommand(cmd2, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al halar costos traslados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub HalarCostos_de_Engorde_a_Reemplazos(ByVal DeLote As String, ByVal ALote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal CantidadTraladar As Integer, ByVal NoDocumento As String)
        Try
            'Dim ID_Movimiento As Integer = 0
            'sql = New SqlCommand("select max(ID_Movimiento) from MOVIMIENTOS_LOTES_INT", con)
            'con.Open()
            'leer = sql.ExecuteReader
            'While leer.Read
            '    If leer.IsDBNull(0) = True Then
            '        ID_Movimiento = 0
            '    Else
            '        ID_Movimiento = leer(0) + 1
            '    End If
            'End While
            'con.Close()
            Dim cmd2 As String = "DECLARE @TotalCerdos int" _
                              & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
                              & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & 0 & "','" & DeLote & "','" & FechaMovimiento & "','" & Motivo & "','" & CantidadTraladar & "','" & UsuarioActual & "',-((((((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+" _
                              & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'  and Viva='" & True & "' and Fecha_Liquidacion<'" & FechaSistema & "'),0)" _
                              & " )))))/(SELECT ISNULL((Total_Cerdos ),1) FROM Total_Cerdos_Lote WHERE Lote_No='" & DeLote & "'))*'" & CantidadTraladar & "'),'" & NoDocumento & "')"
            sql = New SqlCommand(cmd2, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al halar de Engorde a Reemplazos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Sub RestarCosto_x_salidas(ByVal DeLote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal CantidadTraladar As Integer, ByVal NoDocumento As String)
        Try
            'Dim ID_Movimiento As Integer = 0
            'sql = New SqlCommand("select max(ID_Movimiento) from MOVIMIENTOS_LOTES_INT", con)
            'con.Open()
            'leer = sql.ExecuteReader
            'While leer.Read
            '    If leer.IsDBNull(0) = True Then
            '        ID_Movimiento = 0
            '    Else
            '        ID_Movimiento = leer(0) + 1
            '    End If
            'End While
            'con.Close()
            Dim cmd2 As String = "DECLARE @TotalCerdos int" _
                                 & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
                                 & " INSERT INTO MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) VALUES('" & 0 & "','" & DeLote & "','" & FechaMovimiento & "','" & Motivo & "','" & CantidadTraladar & "','" & UsuarioActual & "',-(((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "' and m.Fecha_Movimiento<'" & FechaSistema & "'),0))+(SELECT isnull((SUM(IMPORTE)),0) FROM LINEAS_DE_REQUISICIONES WHERE Lote_No='" & DeLote & "' and Viva='True' and Fecha_Liquidacion<'" & FechaSistema & "'))/@TotalCerdos)*'" & CantidadTraladar & "','" & NoDocumento & "')"
            sql = New SqlCommand(cmd2, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al restar salidas x lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    'Sub HalarCostos_Gestacion_a_Lactancia(ByVal DeLote As String, ByVal ALote As String, ByVal FechaMovimiento As Date, ByVal Motivo As String, ByVal Cantidad As Integer)
    '    Try
    '        Dim ID_Movimiento As Integer = 0
    '        sql = New SqlCommand("select max(ID_Movimiento) from MOVIMIENTOS_LOTES_INT", con)
    '        con.Open()
    '        leer = sql.ExecuteReader
    '        While leer.Read
    '            If leer.IsDBNull(0) = True Then
    '                ID_Movimiento = 0
    '            Else
    '                ID_Movimiento = leer(0) + 1
    '            End If
    '        End While
    '        con.Close()
    '        Dim CMD As String = "DECLARE @TotalCerdos int" _
    '                          & " SET @TotalCerdos =(SELECT Total_Cerdos FROM Total_Cerdos_Lote t where t.Lote_No ='" & DeLote & "') IF (@TotalCerdos=0) BEGIN SET @TotalCerdos =1 END" _
    '                          & " INSERT INTO MOVIMIENTOS_LOTES_INT VALUES('" & ID_Movimiento & "','" & DeLote & "','" & ALote & "','" & FechaMovimiento & "','" & Motivo & "','" & Cantidad & "','" & UsuarioActual & "',((ISNULL((SELECT SUM(Costo) FROM MOVIMIENTOS_LOTES_INT m where m.A_Lote='" & DeLote & "'),0)/'" & Cantidad & "')+" _
    '                          & " ((isnull((SELECT SUM(Importe) from LINEAS_DE_REQUISICIONES l where l.Lote_No ='" & DeLote & "'),0)/" _
    '                          & " (@TotalCerdos)))*'" & Cantidad & "'))"
    '        sql = New SqlCommand(CMD, con)
    '        con.Open()
    '        sql.ExecuteNonQuery()
    '        con.Close()
    '    Catch ex As Exception
    '        MessageBoxEx.Show(CadenaError & ex.Message, "Error al halar el costo de gestacion a lactancia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        con.Close()
    '    End Try
    'End Sub
    Public Sub Registrar_Estado_Parto(ByVal IdInseminacion As Integer, ByVal Estado As Boolean, ByVal InseminacionNo As Integer)
        Try
            sql = New SqlCommand("insert into Estado_de_Partos values('" & IdInseminacion & "','" & Estado & "','" & InseminacionNo & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error Registrar_Estado_Parto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
       
    End Sub
    Public Sub Actualizar_Estado_Parto(ByVal IdInseminacion As Integer, ByVal Estado As Boolean)
        Try
            sql = New SqlCommand("update Estado_de_Partos SET Estado_Parto='" & Estado & "' WHERE Id_Enseminacion='" & IdInseminacion & "'", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error Actualizar_Estado_Parto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub RegistrarMovimientoLote(ByVal LoteNo As String, ByVal Reemplazos As Integer, ByVal Defuncion As Integer, ByVal Destazo As Integer, ByVal Rastro As Integer, ByVal Entradas As Integer, ByVal Salidas As Integer, ByVal Fecha As Date, ByVal NoDocumento As String)
        Try

            sql = New SqlCommand("insert into MOVIMIENTO_LOTE (Lote_No , Reemplazos , Defuncion , Destazo , Rastro , Entrada , Salida ,Fecha_Movimiento ,Documento_NO) values('" & LoteNo & "','" & Reemplazos & "','" & Defuncion & "','" & Destazo & "','" & Rastro & "','" & Entradas & "','" & Salidas & "','" & Fecha & "','" & NoDocumento & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error RegistrarMovimientoLote", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub Correlativo_Auto(ByVal CadenaSql As String, ByVal CajaTexto As TextBox)
        Try

            sql = New SqlCommand(CadenaSql, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                    CajaTexto.Text = 1
                Else
                    CajaTexto.Text = leer(0) + 1
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error Correlativo_Auto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub ActualizarExistencias()
        Try
            Dim cmd As String = "ActualizarExistencias"
            sql = New SqlCommand(cmd, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Function Buscar(ByVal Columna As String, ByVal texto As String, ByVal BindingSource As BindingSource) As Integer
        Try
            If BindingSource.DataSource Is Nothing Then
                Return -1
            End If
            Dim fila As Integer = BindingSource.Find(Columna.Trim, texto)
            BindingSource.Position = fila
            Return fila
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
        Return -1
    End Function

    'Public Sub ActualizarExistencias()
    '    Dim cmd As String = "UPDATE Existencias SET ingresos = 0, egresos = 0, Existencia_Actual = 0" _
    '                      & " UPDATE EXISTENCIAS SET" _
    '                      & " INGRESOS = isnull((select sum(unidades) from kardex b where a.codigo = b.codigo and a.bodega = b.bodega and ingreso_egreso = 'I'),0)," _
    '                      & " EGRESOS = isnull((select sum(unidades) from kardex b where a.codigo = b.codigo and a.bodega = b.bodega and ingreso_egreso = 'E'),0)," _
    '                      & " Existencia_Actual =" _
    '                      & " isnull((select sum(unidades) from kardex b where a.codigo = b.codigo and a.bodega = b.bodega and ingreso_egreso = 'I'),0) -" _
    '                      & " isnull((select sum(unidades) from kardex b where a.codigo = b.codigo and a.bodega = b.bodega and ingreso_egreso = 'E'),0) " _
    '                      & " FROM existencias a " _
    '                      & " UPDATE Inventario_Materiales SET ingresos = 0, egresos = 0, Existencia = 0" _
    '                      & " UPDATE Inventario_Materiales SET " _
    '                      & " Ingresos = isnull((select sum(unidades) from kardex as b where a.codigo = b.codigo and ingreso_egreso = 'I'),0)," _
    '                      & " Egresos = isnull((select sum(unidades) from kardex as b where a.codigo = b.codigo  and ingreso_egreso = 'E'),0)," _
    '                      & " Existencia =" _
    '                      & " isnull((select sum(unidades) from kardex b where a.codigo = b.codigo and ingreso_egreso = 'I'),0) -" _
    '                      & " isnull((select sum(unidades) from kardex b where a.codigo = b.codigo and ingreso_egreso = 'E'),0)," _
    '                      & " Costo_Unitario= isnull((select sum(Costo_Unitario) from kardex as b where a.codigo=b.codigo and Ingreso_Egreso='I'),0)/" _
    '                      & " (select count(Costo_Unitario) from kardex as b where a.codigo=b.codigo and Ingreso_Egreso='I')" _
    '                      & " FROM Inventario_Materiales AS a" _
    '                      & " UPDATE Inventario_Materiales SET" _
    '                      & " Costo_Total = (isnull((select sum(b.Costo_Unitario) from kardex as b where a.codigo=b.codigo and Ingreso_Egreso='I'),0)/" _
    '                      & " isnull((select count(b.Costo_Unitario) from kardex as b join Inventario_Materiales as a on b.Codigo =a.Codigo where a.codigo=b.codigo and Ingreso_Egreso='I'),0)*" _
    '                      & " (" _
    '                      & " isnull((select sum(b.unidades) from kardex b where a.codigo = b.codigo and ingreso_egreso = 'I'),0) -" _
    '                      & " isnull((select sum(b.unidades) from kardex b where a.codigo = b.codigo and ingreso_egreso = 'E'),0) " _
    '                      & " ))," _
    '                      & " Costo_Unitario= isnull((select sum(b.Costo_Unitario) from kardex as b where a.codigo=b.codigo and Ingreso_Egreso='I'),0)/" _
    '                      & " isnull((select count(b.Costo_Unitario) from kardex as b join Inventario_Materiales as a on b.Codigo =a.Codigo where a.Codigo = b.Codigo and Ingreso_Egreso ='I'),0)" _
    '                      & " FROM Inventario_Materiales AS a"
    '    sql = New SqlCommand(cmd, con)
    '    con.Open()
    '    sql.ExecuteNonQuery()
    '    con.Close()
    'End Sub
    Public Sub ActualizarLote()
        Try
            sql = New SqlCommand("ActualizarLotes", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al actualizar Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        'Dim CerdosActuales As Integer
        'Try
        '    Dim ExisteLote_en_lote As Boolean = False
        '    sql = New SqlCommand("select Lote_No from LOTES where Lote_No='" & LoteNo & "'", con)
        '    con.Open()
        '    leer = sql.ExecuteReader
        '    While leer.Read
        '        ExisteLote_en_lote = True
        '    End While
        '    con.Close()
        '    If ExisteLote_en_lote = True Then
        '        Dim ExisteLote_en_Total_cerdos_lote As Boolean = False
        '        sql = New SqlCommand("select Lote_No from Total_Cerdos_Lote where Lote_No='" & LoteNo & "'", con)
        '        con.Open()
        '        leer = sql.ExecuteReader
        '        While leer.Read
        '            ExisteLote_en_Total_cerdos_lote = True
        '        End While
        '        con.Close()
        '        If ExisteLote_en_Total_cerdos_lote = False Then
        '            sql = New SqlCommand("insert into Total_Cerdos_Lote values('" & LoteNo & "','0','" & FechaSistema & "')", con)
        '            con.Open()
        '            sql.ExecuteNonQuery()
        '            con.Close()
        '        Else
        '            Dim CadenaConsulta As String = "DECLARE @Reem int DECLARE @Defun int DECLARE @Dest int DECLARE @Rast int DECLARE @Entr int DECLARE @Sal int DECLARE @CerdosRegistrados int DECLARE @TotalCerdos int" _
        '                                 & " SET @Reem=(SELECT SUM(Reemplazos) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & LoteNo & "') if (@Reem=null) begin SET @Reem=0 End" _
        '                                 & " SET @Defun=(SELECT SUM(Defuncion) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & LoteNo & "') If (@Defun=null) Begin SET @Defun=0 End" _
        '                                 & " SET @Dest=(SELECT SUM(Destazo) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & LoteNo & "') If (@Dest=null) Begin SET @Dest=0 End" _
        '                                 & " SET @Rast=(SELECT SUM(Rastro) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & LoteNo & "') If (@Rast=null) Begin SET @Rast=0 End" _
        '                                 & " SET @Entr=(SELECT SUM(Entrada) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & LoteNo & "') If (@Entr=null) Begin SET @Entr=0 End" _
        '                                 & " SET @Sal=(SELECT SUM(Salida) FROM MOVIMIENTO_LOTE WHERE Lote_No='" & LoteNo & "') If (@Sal=null) Begin SET @Sal=0 End" _
        '                                 & " SET @CerdosRegistrados=(SELECT Cerdos_Nacidos FROM LOTES WHERE Lote_No='" & LoteNo & "') If (@CerdosRegistrados=null) Begin SET @CerdosRegistrados=0 End" _
        '                                 & " SET @TotalCerdos = ((@CerdosRegistrados+@Entr)-(@Reem+@Defun+@Dest+@Rast+@Sal))" _
        '                                 & " UPDATE Total_Cerdos_Lote SET Total_Cerdos=(@TotalCerdos), Fecha_Ultima_Modificación='" & FechaSistema & "' where Lote_No='" & LoteNo & "'"
        '            sql = New SqlCommand(CadenaConsulta, con)
        '            con.Open()
        '            sql.ExecuteNonQuery()
        '            con.Close()
        '            sql = New SqlCommand("select Total_Cerdos from dbo.Total_Cerdos_Lote Where Lote_No='" & LoteNo & "'", con)
        '            con.Open()
        '            leer = sql.ExecuteReader
        '            While leer.Read
        '                CerdosActuales = leer(0)
        '            End While
        '            con.Close()
        '            If CerdosActuales = 0 Then
        '                sql = New SqlCommand("Update LOTES set Estado='T' where Lote_No='" & LoteNo & "' and Estado<>'F'", con)
        '                con.Open()
        '                sql.ExecuteNonQuery()
        '                con.Close()
        '            Else
        '                sql = New SqlCommand("Update LOTES set Estado='A' where Lote_No='" & LoteNo & "'", con)
        '                con.Open()
        '                sql.ExecuteNonQuery()
        '                con.Close()
        '            End If
        '        End If
        '    Else
        '        MessageBoxEx.Show("El Lote No: " & LoteNo & " no existe en la base de datos asegurese de haberlo creado", "No existe Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If 
        'Catch ex As Exception
        '    MessageBoxEx.Show(CadenaError & ex.Message, "Error al Actualizar Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    con.Close()
        'End Try
    End Sub
    Public Sub MostrarLotesdeGranja(ByVal LoteDesde As ComboBox, ByVal LoteHasta As ComboBox, ByVal Granja As String)
        LoteDesde.Items.Clear()
        LoteHasta.Items.Clear()
        Try
            sql = New SqlCommand("SELECT a.Lote_No FROM LOTES AS a JOIN Granjas AS b ON a.Codigo_Granja=b.Codigo_Granja WHERE b.Nombre='" & Granja & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                If leer.IsDBNull(0) = True Then
                Else
                    LoteDesde.Items.Add(leer(0))
                    LoteHasta.Items.Add(leer(0))
                End If
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error recuperando Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub MandarReportACrystal(ByVal Datagrid As DataGridView, ByVal CadenaAdaptador As String, ByVal NombreTabla As String)
        Try
            oAdapter = New SqlDataAdapter(CadenaAdaptador, con)
            Dts = New DataSet
            con.Open()
            oAdapter.Fill(Dts, NombreTabla)
            con.Close()
            Dts.Tables(NombreTabla).Clear()
            For r As Integer = 0 To Datagrid.RowCount - 1
                oDr = Dts.Tables(NombreTabla).NewRow
                For c As Integer = 0 To Datagrid.ColumnCount - 1
                    Dim ColumnaName As String = Datagrid.Columns(c).Name
                    oDr(c) = Datagrid.Rows(r).Cells(ColumnaName).Value
                Next
                Dts.Tables(NombreTabla).Rows.Add(oDr)
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error se produjo en Mandar Reporte a Crystal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub CargarLotes(ByVal Lista As ComboBox)
        Try
            sql = New SqlCommand("select Lote_No from LOTES", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Lista.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al Cargar lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Public Sub ExportDataToExcel(ByVal FilePath As String, ByVal DataGrid As DataGridView)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To DataGrid.RowCount - 2
            For j = 0 To DataGrid.ColumnCount - 1
                For k As Integer = 1 To DataGrid.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGrid.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGrid(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("C:\texto\vbexcel.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)

        MsgBox("You can find the file D:\vbexcel.xlsx")
    End Sub

    Public Sub ExportarDatosExcel(ByVal DataGridView1 As DataGridView, ByVal Resumen As String, ByVal Granja As String, ByVal Valuados As String, ByVal HastaLetra As String)
        Try
            Dim m_Excel As New Excel.Application
            m_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True
            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                'Encabezado  
                .Range("B1:" & HastaLetra & "1").Merge()
                .Range("B1:" & HastaLetra & "1").Value = "PRODUCTOS AGROALIMENTICIOS S.A. DE C.V."
                .Range("B1:" & HastaLetra & "1").Font.Bold = True
                .Range("B1:" & HastaLetra & "1").Font.Size = 15
                .Range("B1:" & HastaLetra & "1").HorizontalAlignment = 3

                .Range("B2:" & HastaLetra & "2").Merge()
                .Range("B2:" & HastaLetra & "2").Value = Resumen
                .Range("B2:" & HastaLetra & "2").Font.Bold = True
                .Range("B2:" & HastaLetra & "2").Font.Size = 12
                .Range("B2:" & HastaLetra & "2").HorizontalAlignment = 3

                .Range("B3:" & HastaLetra & "3").Merge()
                .Range("B3:" & HastaLetra & "3").Value = Granja
                .Range("B3:" & HastaLetra & "3").Font.Bold = True
                .Range("B3:" & HastaLetra & "3").Font.Size = 12
                .Range("B3:" & HastaLetra & "3").HorizontalAlignment = 3

                .Range("B4:" & HastaLetra & "4").Merge()
                .Range("B4:" & HastaLetra & "4").Value = Valuados
                .Range("B4:" & HastaLetra & "4").Font.Bold = True
                .Range("B4:" & HastaLetra & "4").Font.Size = 12
                .Range("B4:" & HastaLetra & "4").HorizontalAlignment = 3
                'Copete  

                Const primeraLetra As Char = "B"
                Const primerNumero As Short = 6
                Dim Letra As Char, UltimaLetra As Char
                Dim Numero As Integer, UltimoNumero As Integer
                Dim cod_letra As Byte = Asc(primeraLetra) - 1
                Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
                Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
                'Establecer formatos de las columnas de la hija de cálculo  
                Dim strColumna As String = ""
                Dim LetraIzq As String = ""
                Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
                Letra = primeraLetra
                Numero = primerNumero
                Dim objCelda As Excel.Range
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra + Numero.ToString
                        objCelda = .Range(strColumna, Type.Missing)
                        objCelda.Value = c.HeaderText
                        objCelda.EntireColumn.Font.Size = 8
                        'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                        If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                            objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                        End If
                    End If
                Next

                Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
                objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
                UltimaLetra = Letra
                Dim UltimaLetraIzq As String = LetraIzq

                'CARGA DE DATOS  
                Dim i As Integer = Numero + 1

                For Each reg As DataGridViewRow In DataGridView1.Rows
                    LetraIzq = ""
                    cod_LetraIzq = Asc(primeraLetra) - 1
                    Letra = primeraLetra
                    cod_letra = Asc(primeraLetra) - 1
                    For Each c As DataGridViewColumn In DataGridView1.Columns
                        If c.Visible Then
                            If Letra = "Z" Then
                                Letra = primeraLetra
                                cod_letra = Asc(primeraLetra)
                                cod_LetraIzq += 1
                                LetraIzq = Chr(cod_LetraIzq)
                            Else
                                cod_letra += 1
                                Letra = Chr(cod_letra)
                            End If
                            strColumna = LetraIzq + Letra
                            ' acá debería realizarse la carga  
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                            '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
                            '.Range(strColumna + i, strColumna + i).In()  

                        End If
                    Next
                    Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                    objRangoReg.Rows.BorderAround()
                    objRangoReg.Select()
                    i += 1
                Next
                UltimoNumero = i

                'Dibujar las líneas de las columnas  
                LetraIzq = ""
                cod_LetraIzq = Asc("A")
                cod_letra = Asc(primeraLetra)
                Letra = primeraLetra
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                        objCelda.BorderAround()
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            LetraIzq = Chr(cod_LetraIzq)
                            cod_LetraIzq += 1
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                    End If
                Next


                'Dibujar el border exterior grueso  
                Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
                objRango.Select()
                objRango.Columns.AutoFit()
                objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            End With

            m_Excel.Cursor = Excel.XlMousePointer.xlDefault
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error Exportar datos a excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub EstiloDatagrid(ByVal Datagrid As DataGridView, ByVal TamañoFuente As Integer, ByVal Fuente As String, ByVal EstiloFuente As System.Drawing.FontStyle)
        Datagrid.ColumnHeadersDefaultCellStyle.Font = New Font(Fuente, TamañoFuente, EstiloFuente, GraphicsUnit.Point)
        Datagrid.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark
        Datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Datagrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Datagrid.DefaultCellStyle.Font = New Font(Fuente, TamañoFuente, FontStyle.Regular, GraphicsUnit.Point)
        Datagrid.DefaultCellStyle.BackColor = Color.Empty
        Datagrid.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
        Datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Datagrid.GridColor = SystemColors.ControlDarkDark
    End Sub
    Public Function Sumar(ByVal nombre_Columna As String, ByVal Dgv As DataGridView) As Double
        Dim total As Double = 0
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total
    End Function
    Public Sub CambiarEstadoCerda(ByVal CodigoCerda As Integer, ByVal LoteNo_Estado_Trasladar As String)
        Try
            Dim CadenaConsulta As String = "DECLARE @LoteNo_E numeric(7,0)" _
                                         & " DECLARE @CodigoCerda char(8)" _
                                         & " DECLARE @Estaba_en_LoteNo int" _
                                         & " DECLARE @NoCerdos_Lote int" _
                                         & " DECLARE @NoCerdas_Lote_E int" _
                                         & " SET @CodigoCerda='" & CodigoCerda & "'" _
                                         & " SET @Estaba_en_LoteNo =(Select Lote_No from REG_MADRES where Código_Cerda=@CodigoCerda)" _
                                         & " SET @NoCerdos_Lote = (Select Cerdos_Nacidos from LOTES where Lote_No=@Estaba_en_LoteNo)" _
                                         & " SET @LoteNo_E = '" & LoteNo_Estado_Trasladar & "'" _
                                         & " SET @NoCerdas_Lote_E = (Select Cerdos_Nacidos from LOTES Where Lote_No=@LoteNo_E)" _
                                         & " UPDATE LOTES set Cerdos_Nacidos=(@NoCerdas_Lote_E + 1) where Lote_No=@LoteNo_E" _
                                         & " UPDATE LOTES set Cerdos_Nacidos=(@NoCerdos_Lote -1)  where Lote_No=@Estaba_en_LoteNo" _
                                         & " UPDATE REG_MADRES set Lote_No=@LoteNo_E where Código_Cerda=@CodigoCerda"
            sql = New SqlCommand(CadenaConsulta, con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al cambiar estado a cerda", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Function ValidarFechas(ByVal Fecha As String) As Boolean
        Dim Valida As Boolean = False
        If Not IsDate(Fecha) Then
            MessageBoxEx.Show("La fecha ingresada es incorrecta, porfavor verifique que los dias ingresados correspondan al mes y al año", "Fecha Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Valida = True
        End If
        Return Valida
    End Function
    Public Function InsertarProcesoCerda(ByVal Id_Inseminacion As Integer, ByVal Codigo As String, ByVal Proceso As String, ByVal FechaSistema As String, ByVal Documento As String, ByVal Lote_No As String, ByVal entrada_salida As String) As String
        Dim resultado As String = ""
        Try
            ProcesosCerdasAdapter.Insertar(Id_Inseminacion, Codigo, Proceso, FechaSistema, Today & " " & TimeOfDay, UsuarioActual, Documento, Lote_No, entrada_salida)
            resultado = ""
        Catch ex As Exception
            resultado = "Error: " & ex.Message
        End Try
        Return resultado
    End Function
    Public Function ObtenerActualIdInseminacionCerda(ByVal codigo As String) As Integer
        Dim id_inseminacion As Integer
        Try
            id_inseminacion = ProcesosCerdasAdapter.GetActualIdInseminacionCerda(codigo)
        Catch ex As Exception
            id_inseminacion = 0
        End Try
        Return id_inseminacion
    End Function

    Public Sub InsertarProcesosCerditos(ByVal IdInseminacion As Integer, ByVal Proceso As String, ByVal Cantidad As Integer, ByVal FechaGuia As Date, ByVal Usuario As String, ByVal IngresoEgreso As String, ByVal LoteMonta As String, ByVal LoteGestacion As String, ByVal LoteEngorde As String, ByVal CodigoCerda As String, ByVal Documento As String)
        con = New SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
        Try

            sql = New SqlCommand("Proc_Insertar_Procesos_Cerditos", con)
            sql.CommandType = CommandType.StoredProcedure
            sql.CommandTimeout = 600000
            sql.Parameters.Add("@Id_Inseminacion", SqlDbType.Int).Value = IdInseminacion
            sql.Parameters.Add("@Proceso", SqlDbType.Char, 10).Value = Proceso
            sql.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad
            sql.Parameters.Add("@FechaGuia", SqlDbType.DateTime).Value = FechaGuia
            sql.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
            sql.Parameters.Add("@IngresoEgreso", SqlDbType.Char, 1).Value = IngresoEgreso
            sql.Parameters.Add("@LoteMonta", SqlDbType.Char, 8).Value = LoteMonta
            sql.Parameters.Add("@LoteGestacion", SqlDbType.Char, 8).Value = LoteGestacion
            sql.Parameters.Add("@LoteEngorde", SqlDbType.Char, 8).Value = LoteEngorde
            sql.Parameters.Add("@CodigoCerda", SqlDbType.Char, 8).Value = CodigoCerda
            sql.Parameters.Add("@Documento", SqlDbType.Char, 10).Value = Documento

            con.Open()
            sql.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al insertar procesos cerditos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Sub
    Public Function EstadoInventario(ByVal Codigo As String) As Boolean
        If Not IsDBNull(Codigo) And Codigo <> "" Then
            Dim estado As Boolean
            Dim odtsInventario As New dtsInventario
            Dim inventarioAdapter As New dtsInventarioTableAdapters.Inventario_Materiales_EstadosTableAdapter

            estado = inventarioAdapter.GetEstadoCodigo(Codigo)

            Return estado
        End If

    End Function
    Dim descripcion_ As String
    Public Property descripcion() As String
        Get
            Return descripcion_
        End Get
        Set(value As String)
            descripcion_ = value
        End Set
    End Property



End Module
