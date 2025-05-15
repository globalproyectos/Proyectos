Imports System.Data.SqlClient
Imports System.Data
Public Class ClaseCelos
    Shared Function listar()
        Dim ctx As New GRANJAEntities
        Dim datos = (From a In ctx.Registo_Celo
                     Select a).ToList

        Return datos
    End Function
    Shared Function insertar(regitro_celo As Registo_Celo) As String
        Dim mensaje As String = ""
        Try
            Dim ctx As New GRANJAEntities
            ctx.Registo_Celo.Add(regitro_celo)
            ctx.SaveChanges()
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
        End Try
        Return mensaje
    End Function
    Shared Function editar(p_id_celo As Integer, regitro_celo As Registo_Celo) As String
        Dim mensaje As String = ""
        Try
            Dim ctx As New GRANJAEntities
            Dim dato As Registo_Celo = (From a In ctx.Registo_Celo
                                        Where a.ID_Celo = p_id_celo
                                        Select a).SingleOrDefault
            With dato
                .Codigo_Cerda = regitro_celo.Codigo_Cerda
                .Tipo_Cerda = regitro_celo.Tipo_Cerda
                .Evento = regitro_celo.Evento
                .Fecha = regitro_celo.Fecha
                .Hora = regitro_celo.Hora
                .Peso = regitro_celo.Peso
                .Orden = regitro_celo.Orden
            End With
            ctx.SaveChanges()
        Catch ex As Exception
            mensaje = "Error: " & ex.Message
        End Try
        Return mensaje
    End Function
    Shared Function consultarPorId(p_id_celo As Integer) As Registo_Celo
        Try
            Dim ctx As New GRANJAEntities
            Dim dato = (From a In ctx.Registo_Celo
                        Where a.ID_Celo = p_id_celo
                        Select a).SingleOrDefault
            Return dato
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Shared Function getNextOrden(p_codigo_cerda As String) As String
        Dim cnx As New SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
        Try
            Dim siguiente As Integer = 0

            Dim cmd As New SqlCommand("select isnull(max(Orden),0) + 1 from Registo_Celo where Codigo_Cerda = '" & p_codigo_cerda & "'", cnx)
            Dim leer As SqlDataReader
            cnx.Open()
            leer = cmd.ExecuteReader
            While leer.Read
                siguiente = leer(0)
            End While
            cnx.Close()

            Return siguiente
        Catch ex As Exception
            Return Nothing
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

    End Function
End Class
