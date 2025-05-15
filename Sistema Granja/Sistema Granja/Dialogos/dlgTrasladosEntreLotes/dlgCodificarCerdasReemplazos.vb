Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Public Class dlgCodificarCerdasReemplazos
    Inherits DevComponents.DotNetBar.Office2007Form
    Public DeLote, ALote As String
    Public Cantidad As Integer
    Public CostoTotal As Double
    Public FechaTraslado As Date
    Public NoTraslado As Integer
    Dim FechaNacimiento As Date
    Dim Padre As String
    Dim Madre As String
    'Public Sub CrearTabla_Codificador()
    '    dt = New DataTable
    '    With dt.Columns
    '        .Add(New DataColumn("No."))
    '        .Add(New DataColumn("Cód. Cerda"))
    '        .Add(New DataColumn("Fecha Nacimiento"))
    '        .Add(New DataColumn("Padre"))
    '        .Add(New DataColumn("Madre"))
    '        .Add(New DataColumn("Genética"))
    '        .Add(New DataColumn("Costo $"))
    '        .Add(New DataColumn("Lote No"))

    '    End With
    '    For i As Integer = 1 To Cantidad

    '    Next


    'End Sub
    Public Sub HalarInformacion_Lote()
        'Try
        Dim cmd As String = "SELECT p.Fecha_Real, p.Verraco,p.Código_Cerda, (p.No_Destetados-(select isnull((Reemplazos),0) from No_Reemplazos_IdInseminacion where p.ID_Enseminacion = ID_Enseminacion )),p.ID_Enseminacion " _
                          & " from REG_PARTOS_X_CERDA p" _
                          & " join REG_ABUELAS a on p.Código_Cerda =a.Código_Abuela" _
                          & " where p.Lote_se_cargaron='" & DeLote & "'"
        sql = New SqlCommand(cmd, con)
        dt = New DataTable
        With dt.Columns
            .Add(New DataColumn("Ins."))
            .Add(New DataColumn("No."))
            .Add(New DataColumn("Cód. Cerda"))
            .Add(New DataColumn("Es Reemplazo", System.Type.GetType("System.Boolean")))
            .Add(New DataColumn("Fecha Nacimiento"))
            .Add(New DataColumn("Padre"))
            .Add(New DataColumn("Madre"))
            .Add(New DataColumn("Genética"))
            .Add(New DataColumn("Costo $"))
            .Add(New DataColumn("Lote No"))
        End With
        con.Open()
        leer = sql.ExecuteReader
        Dim Item As Integer = 0
        While leer.Read
            For i As Integer = 1 To leer(3)
                Item += 1
                dr = dt.NewRow
                dr(0) = leer(4)
                dr(1) = Item
                dr(2) = ""
                dr(3) = False
                dr(4) = Format(leer(0), "dd/MM/yyyy")
                dr(5) = leer(1)
                dr(6) = leer(2)
                dr(7) = ""
                dr(8) = (CostoTotal / Cantidad) * 1
                dr(9) = ALote
                dt.Rows.Add(dr)
            Next
            FechaNacimiento = leer(0)
            Padre = leer(1)
            Madre = leer(2)
        End While
        con.Close()
        Me.DataGridViewX1.DataSource = dt
        Me.DataGridViewX1.Columns(0).Width = 30
        Me.DataGridViewX1.Columns(1).Width = 30
        Me.DataGridViewX1.Columns(2).Width = 70
        Me.DataGridViewX1.Columns(3).Width = 70
        Me.DataGridViewX1.Columns(4).Width = 70
        Me.DataGridViewX1.Columns(5).Width = 60
        Me.DataGridViewX1.Columns(6).Width = 60
        Me.DataGridViewX1.Columns(7).Width = 55
        Me.DataGridViewX1.Columns(8).Width = 60
        Me.DataGridViewX1.Columns(9).Width = 50

        Me.DataGridViewX1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewX1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DataGridViewX1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewX1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewX1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewX1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewX1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewX1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewX1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewX1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.DataGridViewX1.Columns(0).ReadOnly = True
        Me.DataGridViewX1.Columns(1).ReadOnly = True
        Me.DataGridViewX1.Columns(2).ReadOnly = False
        Me.DataGridViewX1.Columns(3).ReadOnly = True
        Me.DataGridViewX1.Columns(4).ReadOnly = True
        Me.DataGridViewX1.Columns(5).ReadOnly = True
        Me.DataGridViewX1.Columns(6).ReadOnly = True
        Me.DataGridViewX1.Columns(7).ReadOnly = False
        Me.DataGridViewX1.Columns(8).ReadOnly = True
        Me.DataGridViewX1.Columns(9).ReadOnly = True

        Me.DataGridViewX1.Columns(0).DefaultCellStyle.BackColor = Color.Gray
        Me.DataGridViewX1.Columns(1).DefaultCellStyle.BackColor = Color.Gray

        Me.DataGridViewX1.Columns(3).DefaultCellStyle.BackColor = Color.Gray
        Me.DataGridViewX1.Columns(4).DefaultCellStyle.BackColor = Color.Gray
        Me.DataGridViewX1.Columns(5).DefaultCellStyle.BackColor = Color.Gray
        Me.DataGridViewX1.Columns(6).DefaultCellStyle.BackColor = Color.Gray

        Me.DataGridViewX1.Columns(8).DefaultCellStyle.BackColor = Color.Gray
        Me.DataGridViewX1.Columns(9).DefaultCellStyle.BackColor = Color.Gray
        'Catch ex As Exception
        '    MessageBoxEx.Show(CadenaError & ex.Message, "Error al obtener información de el Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    con.Close()
        'End Try
    End Sub
    Sub HalarCostoTotal()
        Dim CostoLoteMovimiento_Int As Double = 0
        Dim CostoRequisiciones As Double = 0
        Dim TotalCerdos As Integer = 0
        sql = New SqlCommand("SELECT Total_Cerdos  FROM Total_Cerdos_Lote  WHERE Lote_No ='" & DeLote & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            TotalCerdos = leer(0)
        End While
        con.Close()
        sql = New SqlCommand("SELECT ISNULL((SUM(Costo)),0) FROM MOVIMIENTOS_LOTES_INT WHERE A_Lote ='" & DeLote & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            CostoLoteMovimiento_Int = leer(0)
        End While
        con.Close()
        sql = New SqlCommand("SELECT ISNULL((SUM(IMPORTE)),0) FROM LINEAS_DE_REQUISICIONES WHERE Lote_No ='" & DeLote & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            CostoRequisiciones = leer(0)
        End While
        con.Close()
        Me.txtCostoTotal.Text = Math.Round((((CostoLoteMovimiento_Int + CostoRequisiciones) / TotalCerdos)), 4)
    End Sub
    Private Sub dlgCodificarCerdasReemplazos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TotalCerdos As Integer = 0
        sql = New SqlCommand("SELECT Total_Cerdos  FROM Total_Cerdos_Lote  WHERE Lote_No ='" & DeLote & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            TotalCerdos = leer(0)
        End While
        con.Close()
        Cantidad = TotalCerdos
        Dim CostoLoteMovimiento_Int As Double = 0
        Dim CostoRequisiciones As Double = 0
        sql = New SqlCommand("SELECT ISNULL((SUM(Costo)),0) FROM MOVIMIENTOS_LOTES_INT WHERE A_Lote ='" & DeLote & "' and Fecha_Movimiento<'" & FechaSistema & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            CostoLoteMovimiento_Int = leer(0)
        End While
        con.Close()
        sql = New SqlCommand("SELECT ISNULL((SUM(IMPORTE)),0) FROM LINEAS_DE_REQUISICIONES WHERE Lote_No ='" & DeLote & "' and Fecha_Liquidacion<'" & FechaSistema & "' and Viva='" & True & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            CostoRequisiciones = leer(0)
        End While
        con.Close()
        CostoTotal = Math.Round((((CostoLoteMovimiento_Int + CostoRequisiciones) / TotalCerdos) * TotalCerdos), 4)

        HalarCostoTotal()
        HalarInformacion_Lote()
        Me.txtALote.Text = ALote
        Me.txtDeLote.Text = DeLote
        Me.txtCantidad.Text = Cantidad
        Me.txtFechaTr.Text = FechaTraslado
        Me.txtTrasladoNo.Text = NoTraslado
        Me.txtCostoTotal.Text = CostoTotal


    End Sub
    Private Sub DataGridViewX1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        Try
            Me.DataGridViewX1.EndEdit()
            Dim ExisteCodigo As Boolean = False
            sql = New SqlCommand("select Código_Cerda from REG_MADRES where Código_Cerda='" & Me.DataGridViewX1.Rows(e.RowIndex).Cells("Cód. Cerda").Value & "'", con)
            con.Open()
            leer = sql.ExecuteReader()
            While leer.Read
                ExisteCodigo = True
            End While
            con.Close()

            If Me.DataGridViewX1.Rows(e.RowIndex).Cells("Cód. Cerda").Value <> "" Then
                Me.DataGridViewX1.Rows(e.RowIndex).Cells("Es Reemplazo").Value = True
            Else
                Me.DataGridViewX1.Rows(e.RowIndex).Cells("Es Reemplazo").Value = False
            End If

            If ExisteCodigo = True Then
                ExisteCodigo = False
                MessageBoxEx.Show("El Código que ha ingresado ya existe en la base de datos porfavor ingrese otro código", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridViewX1.Rows(e.RowIndex).Cells("Cód. Cerda").Value = ""
                Me.DataGridViewX1.Rows(e.RowIndex).Selected = True
            End If
            'If Me.DataGridViewX1.Rows(e.RowIndex).Cells("Cód. Cerda").Value <> "" Then


            'End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataGridViewX1.Rows(e.RowIndex).Cells("Cód. Cerda").Value = ""
        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim HayMovimientos As Boolean = False
        For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
            Try
                If Me.DataGridViewX1.Rows(i).Cells("Es Reemplazo").Value = True Then
                    HayMovimientos = True
                    sql = New SqlCommand("insert into REG_MADRES values('" & Me.DataGridViewX1.Rows(i).Cells("Cód. Cerda").Value & "','" & Me.DataGridViewX1.Rows(i).Cells("Fecha Nacimiento").Value & "','" & Me.DataGridViewX1.Rows(i).Cells("Padre").Value & "','" & Me.DataGridViewX1.Rows(i).Cells("Madre").Value & "','" & Me.DataGridViewX1.Rows(i).Cells("Genética").Value & "','" & Me.DataGridViewX1.Rows(i).Cells("Costo $").Value & "','" & 0 & "','" & FechaSistema & "','" & Me.DataGridViewX1.Rows(i).Cells("Lote No").Value & "','R')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    sql = New SqlCommand("insert into Costo_Cerdas_Individual_Reemplazos values('" & Me.DataGridViewX1.Rows(i).Cells("Cód. Cerda").Value & "','" & FechaTraslado & "','19/01/1999','" & Me.DataGridViewX1.Rows(i).Cells("Costo $").Value & "','" & False & "','Sr." & Me.txtTrasladoNo.Text & "','" & RTrim(Me.txtDeLote.Text) & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    sql = New SqlCommand("insert into TrasladosEntreLotes values('" & NoTraslado & "','" & DeLote & "','" & ALote & "','" & 1 & "','" & Me.DataGridViewX1.Rows(i).Cells("Costo $").Value & "','" & FechaTraslado & "','" & Me.DataGridViewX1.Rows(i).Cells("Cód. Cerda").Value & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    RegistrarMovimientoLote(DeLote, 1, 0, 0, 0, 0, 0, FechaTraslado, "Sr." & Me.txtTrasladoNo.Text)
                    RegistrarMovimientoLote(ALote, 0, 0, 0, 0, 1, 0, FechaTraslado, "Sr." & Me.txtTrasladoNo.Text)
                    sql = New SqlCommand("UPDATE No_Reemplazos_IdInseminacion SET Reemplazos = ((SELECT Reemplazos FROM No_Reemplazos_IdInseminacion WHERE Id_Enseminacion='" & Me.DataGridViewX1.Rows(i).Cells("Ins.").Value & "')+1) FROM No_Reemplazos_IdInseminacion WHERE Id_Enseminacion='" & Me.DataGridViewX1.Rows(i).Cells("Ins.").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                End If
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        Next
        Try
            Dim NoTraslados As Integer = 0
            Dim CostoT As Double = 0
            For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                If Me.DataGridViewX1.Rows(i).Cells("Es Reemplazo").Value = True Then
                    NoTraslados += 1
                    CostoT += Me.DataGridViewX1.Rows(i).Cells("Costo $").Value
                End If
            Next
            If HayMovimientos = True Then
                HalarCostos_de_Engorde_a_Reemplazos(DeLote, ALote, FechaTraslado, "DE ENGORDE A REEMPLAZOS", NoTraslados, "Sr." & Me.txtTrasladoNo.Text)
                ActualizarLote()
                MessageBoxEx.Show("Se efectuó el traslado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                HalarInformacion_Lote()
                With My.Forms.frmTrasladosEntreLotes
                    .ButtonX2_Click(sender, e)
                    Me.Close()
                End With
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try


    End Sub
End Class