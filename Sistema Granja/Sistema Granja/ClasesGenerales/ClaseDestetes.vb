Public Class ClaseDestetes
    Shared ctx As GRANJAEntities
    Shared Function getExisteMovimiento(a_lote As String) As Movimientos_Lotes_Int
        ctx = New GRANJAEntities
        Dim dato = (From a In ctx.Movimientos_Lotes_Int
                    Where a.A_Lote = a_lote And a.Documento_NO.Contains("Dt.")
                    Select a).SingleOrDefault()
        If dato IsNot Nothing Then
            Return dato
        Else
            Return Nothing
        End If
    End Function
    Shared Function insertarDesteteCompletoParcial(modelo As Destetes_Completos_o_Parciales) As String
        Try
            ctx = New GRANJAEntities
            ctx.Destetes_Completos_o_Parciales.Add(modelo)
            ctx.SaveChanges()
            Return "Registro insertado exitosamente"
        Catch ex As Exception
            Return "Error: " & ex.InnerException.ToString()
        End Try
    End Function
    Shared Function getFechaDesarrollo(lote As String) As Fecha_Dias_Desarrollo
        Try
            ctx = New GRANJAEntities
            Dim dato = (From a In ctx.Fecha_Dias_Desarrollo
                        Where a.Lote_No = lote
                        Select a).SingleOrDefault
            Return dato
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
