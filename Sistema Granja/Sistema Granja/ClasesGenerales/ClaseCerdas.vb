Imports System.Data.SqlClient
Imports System.Data
Public Class ClaseCerdas
    Shared Function listar(buscar As String)
        Try
            Dim ctx As New GRANJAEntities
            Dim datos = (From a In ctx.v_consulta_reemplazos
                         Where a.IdCerda.Contains(buscar)
                         Select a).ToList
            Return datos
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Shared Function listarClasificaciones()
        Try
            Dim ctx As New GRANJAEntities
            Dim datos = (From a In ctx.ClasesHatosReprod
                         Select a).ToList
            Return datos
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Shared Function getExiste(p_codigo_cerda) As Boolean
        Dim cnx As New SqlConnection(My.MySettings.Default.BDGRANJAConnectionString.ToString)
        Try
            Dim existe As Boolean = False

            Dim cmd As New SqlCommand("select convert(bit,(case when(select count(*) from v_consulta_reemplazos v where v.IdCerda = '" & p_codigo_cerda & "')>0 then 1 else 0 end))", cnx)
            Dim leer As SqlDataReader
            cnx.Open()
            leer = cmd.ExecuteReader
            While leer.Read
                existe = leer(0)
            End While
            cnx.Close()
            Return existe
        Catch ex As Exception
            Return Nothing
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

    End Function
    Shared Function getInfoCerda(p_codigo_cerda As String) As v_consulta_reemplazos
        Dim ctx As New GRANJAEntities
        Dim dato = (From a In ctx.v_consulta_reemplazos
                    Where a.IdCerda = p_codigo_cerda
                    Select a).SingleOrDefault()

        If dato IsNot Nothing Then
            Return dato
        Else
            Return Nothing
        End If

    End Function
    Shared Function getConfiguracion(_id As Integer) As String
        Dim _valor As String = ""
        Dim ctx As New GRANJAEntities
        _valor = (From a In ctx.Configuraciones_Globales
                  Where a.Id = _id
                  Select a.Valor).Single
        Return _valor
    End Function
End Class
