Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Data

Public Class frmRegSalidas
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim CompEr As String = ", el error se produjo en el BLOQUE RS_"
    Dim selecciono As Boolean = False
    Dim carrito As New DataTable("Detalles")
    Dim Fila As Byte
    Dim Total As Single
    Dim Granjas As String
    Dim TipoSalida As String
    Dim SeleccionoGranja As Boolean = False
    Dim seleccionTipoSalida As Boolean = False
    Dim PesoCerdo As Double
    Dim SeleccionoCodifgoCerdo As Boolean = False
    Dim CANTIDADCERDOS As Integer = 0
    Dim b As DevComponents.DotNetBar.Balloon
    Friend WithEvents balloonTipFocus As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents balloonTipHover As DevComponents.DotNetBar.BalloonTip
    Dim TipoDocumentosTableAdapter As New DtsBDGRANJATableAdapters.TipoDocumentosTableAdapter
    Dim odtsInventario As New dtsInventario
    Dim Proc_ImpresionSalidaCerdosDocsTableAdapter As New dtsInventarioTableAdapters.Proc_ImpresionSalidaCerdosDocsTableAdapter
    Dim AnexoImpresionSalidaDocsTableAdapter As New dtsInventarioTableAdapters.AnexoImpresionSalidaDocsTableAdapter
    Dim ubicacionesAdapter As New DtsBDGRANJATableAdapters.UbicacionesTableAdapter
    Dim odtsBDGRANJA As New DtsBDGRANJA
    Dim motivossalidasAdapter As New DtsBDGRANJATableAdapters.MotivosSalidasTableAdapter

    Sub MostrarGranjas()
        Try
            Me.cbxGranjas.Items.Clear()
            sql = New SqlCommand("select Nombre from Granjas", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.cbxGranjas.Items.Add(leer(0).ToString)
            End While
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al Mostrar Granjas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub cargartipodocs()
        Try
            Me.tipodocComboBoxEx1.DataSource = TipoDocumentosTableAdapter.GetData()
            Me.tipodocComboBoxEx1.DisplayMember = "Nombre"
            Me.tipodocComboBoxEx1.ValueMember = "TipoDoc"
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al cargar tipodocs", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarubicaciones()
        Try
            ubicacionComboBoxEx1.DataSource = ubicacionesAdapter.GetData()
            ubicacionComboBoxEx1.DisplayMember = "Descripcion"
            ubicacionComboBoxEx1.ValueMember = "Ubicacion"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmRegSalidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarLotes()
        Me.cargarubicaciones()
        Me.cargartipodocs()
        Me.txtFecha.Text = Format(FechaSistema, "dd/MM/yy")
        Me.cbxGranjas.Focus()
        Me.txtUserCreator.Text = UsuarioActual
        Me.MostrarGranjas()
        NoAuto()
        Me.tabla()
        ActualizarLote()
    End Sub
    Sub NoAuto()
        Try
            Correlativo_Auto("SELECT MAX(Documento_No) FROM ENCABEZADO_SALIDAS", Me.txtNoDocumento)

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al Mostrar No Documento", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Sub tabla()
        Try
            Dim dc0 As New DataColumn("Item#", System.Type.GetType("System.Int32"))
            Dim dc1 As New DataColumn("Lote", System.Type.GetType("System.String"))
            Dim dc2 As New DataColumn("Codigo", System.Type.GetType("System.String"))
            Dim dc3 As New DataColumn("Tipo Salida", System.Type.GetType("System.String"))
            Dim dc4 As New DataColumn("Cantidad", System.Type.GetType("System.Decimal"))
            Dim dc5 As New DataColumn("Peso Real en Pie Lbs.", System.Type.GetType("System.Decimal"))
            Dim dc6 As New DataColumn("Peso Prom. Lbs.", System.Type.GetType("System.Decimal"))
            Dim dc7 As New DataColumn("Unitario + IVA", System.Type.GetType("System.Decimal"))
            Dim dc8 As New DataColumn("Precio/Venta", System.Type.GetType("System.Decimal"))
            Dim dc9 As New DataColumn("Costo", System.Type.GetType("System.Decimal"))
            Dim dc10 As New DataColumn("Peso Real Canal Lbs.", System.Type.GetType("System.Decimal"))
            Dim dc11 As New DataColumn("Motivo", System.Type.GetType("System.String"))
            Dim dc12 As New DataColumn("Ubicacion", System.Type.GetType("System.String"))
            Dim dc13 As New DataColumn("Peso Cachetes Lbs.", System.Type.GetType("System.Decimal"))
            dc0.Unique = True
            dc9.Expression = "Cantidad*[Unitario + IVA]"
            With carrito.Columns
                .Add(dc0)
                .Add(dc1)
                .Add(dc2)
                .Add(dc3)
                .Add(dc4)
                .Add(dc5)
                .Add(dc6)
                .Add(dc7)
                .Add(dc8)
                .Add(dc9)
                .Add(dc10)
                .Add(dc11)
                .Add(dc12)
                .Add(dc13)

            End With
            Me.DgvDetalles.DataSource = carrito
            Me.DgvDetalles.Columns(0).Width = 45
            Me.DgvDetalles.Columns(1).Width = 65
            Me.DgvDetalles.Columns(2).Width = 70
            Me.DgvDetalles.Columns(3).Width = 70
            Me.DgvDetalles.Columns(4).Width = 70
            Me.DgvDetalles.Columns(5).Width = 70
            Me.DgvDetalles.Columns(6).Width = 70
            Me.DgvDetalles.Columns(7).Width = 80
            Me.DgvDetalles.Columns(8).Width = 80
            Me.DgvDetalles.Columns(9).Width = 90
            Me.DgvDetalles.Columns(10).Width = 90
            Me.DgvDetalles.Columns(11).Width = 2
            Me.DgvDetalles.Columns(12).Width = 2
            Me.DgvDetalles.Columns(13).Width = 2
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub CargarLotes()
        Try

            ' BLOQUE RS-1

        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message & CompEr, "Error al Cargar Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
    Sub GuardarEncabezadoSalida()
        Try
            sql = New SqlCommand("INSERT INTO ENCABEZADO_SALIDAS([Documento_No], [Fecha], [Tipo], [Cliente], [Total], [Viva], [Usuario_Creador], [Justificacion], [Total_Letras], [Granja], [Direccion_Cliente], [TipoDoc], [SerieDoc], [DocNo], [Transportista]) VALUES('" & Me.txtNoDocumento.Text & "','" & Me.txtFecha.Text & "','" & Me.txtTipoVenta.Text & "','" & Me.txtCliente.Text & "','" & Me.txtTotal.Text & "','" & True & "','" & UsuarioActual & "','" & Me.txtJustificación.Text & "','" & Me.txtValorEnLetras.Text & "','" & Granjas & "','" & Me.txtDireccion.Text & "', '" & Me.tipodocComboBoxEx1.SelectedValue & "', '" & Me.serieTextBoxX1.Text & "'," & Val(Me.DocNoTextBoxX2.Text) & ",'" & Me.transportistaTextBoxX1.Text & "')", con)
            con.Open()
            sql.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al grabar encabezado de salida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Sub GrabarLineas()
        Try
            Dim linea As Integer = 1
            For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1

                If Me.DgvDetalles.Rows(i).Cells("Lote").Value = "4" Then
                    sql = New SqlCommand("update Costo_Cerdas_Individual_Reemplazos set Se_movio_a_vacias='" & False & "', Fecha_Salio='" & Me.txtFecha.Text & "' where Codigo_Cerda='" & Me.DgvDetalles.Rows(i).Cells("Codigo").Value & "'", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                End If

                sql = New SqlCommand("INSERT INTO LINEAS_DE_SALIDAS VALUES('" & Me.txtNoDocumento.Text & "','" & linea & "','" & FechaSistema & "','" & Me.DgvDetalles.Rows(i).Cells("Lote").Value & "','" & Me.DgvDetalles.Rows(i).Cells("Codigo").Value & "','" & Me.DgvDetalles.Rows(i).Cells("Tipo Salida").Value & "','" & Me.DgvDetalles.Rows(i).Cells("Cantidad").Value & "','" & Me.DgvDetalles.Rows(i).Cells("Unitario + IVA").Value & "','" & Me.DgvDetalles.Rows(i).Cells("Costo").Value & "','" & Me.DgvDetalles.Rows(i).Cells("Peso Real en Pie Lbs.").Value & "','" & Me.DgvDetalles.Rows(i).Cells("Peso Prom. Lbs.").Value & "','" & True & "','" & UsuarioActual & "','','" & Me.DgvDetalles.Rows(i).Cells("Precio/Venta").Value & "'," & Me.DgvDetalles.Rows(i).Cells("Peso Real Canal Lbs.").Value & ", '" & Me.DgvDetalles.Rows(i).Cells("Motivo").Value & "', '" & Me.DgvDetalles.Rows(i).Cells("Ubicacion").Value & "', " & Me.DgvDetalles.Rows(i).Cells("Peso Cachetes Lbs.").Value & ")", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()

                If Me.DgvDetalles.Rows(i).Cells("Tipo Salida").Value = "EP" Then
                    Dim cmd As String = "DECLARE @Estado char(2)" _
                                     & " DECLARE @CodigoCerdo char(8)" _
                                     & " SET @Estado ='D'" _
                                     & " SET @CodigoCerdo ='" & Me.DgvDetalles.Rows(i).Cells("Codigo").Value & "'" _
                                     & " UPDATE REG_ABUELAS SET Estado_Actual = @Estado, Lote_No ='0'  WHERE Código_Abuela = @CodigoCerdo" _
                                     & " UPDATE REG_MADRES SET Estado_Actual = @Estado,Lote_No ='0'  WHERE Código_Cerda = @CodigoCerdo" _
                                     & " UPDATE REG_VERRACOS SET Estado_Actual =@Estado, Lote_No='0'  WHERE Codigo_Cerdo=@CodigoCerdo"

                    sql = New SqlCommand(cmd, con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = "N/A" Then
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 0, 0, 0, 1, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                        'RestarCosto_x_salidas(Me.DgvDetalles.Rows(i).Cells("Lote").Value, Me.txtFecha.Text, "SALIDA DE CERDOS X (V,D,R,R)", 1, "Sl." & Me.txtNoDocumento.Text)
                        sql = New SqlCommand("insert into MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) values('0','" & Me.DgvDetalles.Rows(i).Cells("Lote").Value & "','" & FechaSistema & "','SALIDA DE CERDOS ENGORDE','" & 1 & "','" & UsuarioActual & "','" & -Me.DgvDetalles.Rows(i).Cells("Unitario + IVA").Value & "','Sl." & Me.txtNoDocumento.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                    Else
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 0, 0, 0, 1, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                    End If

                ElseIf Me.DgvDetalles.Rows(i).Cells("Tipo Salida").Value = "DC" Then
                    Dim cmd As String = "DECLARE @Estado char(2)" _
                                      & " DECLARE @CodigoCerdo char(8)" _
                                      & " SET @Estado ='D'" _
                                      & " SET @CodigoCerdo ='" & Me.DgvDetalles.Rows(i).Cells("Codigo").Value & "'" _
                                      & " UPDATE REG_ABUELAS SET Estado_Actual = @Estado, Lote_No ='0'  WHERE Código_Abuela = @CodigoCerdo" _
                                      & " UPDATE REG_MADRES SET Estado_Actual = @Estado,Lote_No ='0'  WHERE Código_Cerda = @CodigoCerdo" _
                                      & " UPDATE REG_VERRACOS SET Estado_Actual =@Estado, Lote_No='0'  WHERE Codigo_Cerdo=@CodigoCerdo"

                    sql = New SqlCommand(cmd, con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = "N/A" Then
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 0, 0, 0, 1, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                        'RestarCosto_x_salidas(Me.DgvDetalles.Rows(i).Cells("Lote").Value, Me.txtFecha.Text, "SALIDA DE CERDOS X (V,D,R,R)", 1, "Sl." & Me.txtNoDocumento.Text)
                        sql = New SqlCommand("insert into MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) values('0','" & Me.DgvDetalles.Rows(i).Cells("Lote").Value & "','" & FechaSistema & "','SALIDA DE CERDOS ENGORDE','" & 1 & "','" & UsuarioActual & "','" & -Me.DgvDetalles.Rows(i).Cells("Unitario + IVA").Value & "','Sl." & Me.txtNoDocumento.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                    Else
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 0, 0, 0, 1, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                    End If
                ElseIf Me.DgvDetalles.Rows(i).Cells("Tipo Salida").Value = "DZ" Then
                    Dim cmd As String = "DECLARE @Estado char(2)" _
                                      & " DECLARE @CodigoCerdo char(8)" _
                                      & " SET @Estado ='D'" _
                                      & " SET @CodigoCerdo ='" & Me.DgvDetalles.Rows(i).Cells("Codigo").Value & "'" _
                                      & " UPDATE REG_ABUELAS SET Estado_Actual = @Estado, Lote_No ='0'  WHERE Código_Abuela = @CodigoCerdo" _
                                      & " UPDATE REG_MADRES SET Estado_Actual = @Estado,Lote_No ='0'  WHERE Código_Cerda = @CodigoCerdo" _
                                      & " UPDATE REG_VERRACOS SET Estado_Actual =@Estado, Lote_No='0'  WHERE Codigo_Cerdo=@CodigoCerdo"

                    sql = New SqlCommand(cmd, con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = "N/A" Then
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 1, 0, 0, 0, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                        'RestarCosto_x_salidas(Me.DgvDetalles.Rows(i).Cells("Lote").Value, Me.txtFecha.Text, "SALIDA DE CERDOS X (V,D,R,R)", 1, "Sl." & Me.txtNoDocumento.Text)
                        sql = New SqlCommand("insert into MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) values('0','" & Me.DgvDetalles.Rows(i).Cells("Lote").Value & "','" & FechaSistema & "','SALIDA DE CERDOS ENGORDE','" & 1 & "','" & UsuarioActual & "','" & -Me.DgvDetalles.Rows(i).Cells("Unitario + IVA").Value & "','Sl." & Me.txtNoDocumento.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                    Else
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 1, 0, 0, 0, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                    End If
                ElseIf Me.DgvDetalles.Rows(i).Cells("Tipo Salida").Value = "RS" Then
                    Dim cmd As String = "DECLARE @Estado char(2)" _
                                                         & " DECLARE @CodigoCerdo char(8)" _
                                                         & " SET @Estado ='D'" _
                                                         & " SET @CodigoCerdo ='" & Me.DgvDetalles.Rows(i).Cells("Codigo").Value & "'" _
                                                         & " UPDATE REG_ABUELAS SET Estado_Actual = @Estado, Lote_No ='0'  WHERE Código_Abuela = @CodigoCerdo" _
                                                         & " UPDATE REG_MADRES SET Estado_Actual = @Estado,Lote_No ='0'  WHERE Código_Cerda = @CodigoCerdo" _
                                                         & " UPDATE REG_VERRACOS SET Estado_Actual =@Estado, Lote_No='0'  WHERE Codigo_Cerdo=@CodigoCerdo"

                    sql = New SqlCommand(cmd, con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = "N/A" Then
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 0, 1, 0, 0, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                        'RestarCosto_x_salidas(Me.DgvDetalles.Rows(i).Cells("Lote").Value, Me.txtFecha.Text, "SALIDA DE CERDOS X (V,D,R,R)", 1, "Sl." & Me.txtNoDocumento.Text)
                        sql = New SqlCommand("insert into MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) values('0','" & Me.DgvDetalles.Rows(i).Cells("Lote").Value & "','" & FechaSistema & "','SALIDA DE CERDOS ENGORDE','" & 1 & "','" & UsuarioActual & "','" & -Me.DgvDetalles.Rows(i).Cells("Unitario + IVA").Value & "','Sl." & Me.txtNoDocumento.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                    Else
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 0, 1, 0, 0, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                    End If

                Else
                    Dim cmd As String = "DECLARE @Estado char(2)" _
                                                         & " DECLARE @CodigoCerdo char(8)" _
                                                         & " SET @Estado ='D'" _
                                                         & " SET @CodigoCerdo ='" & Me.DgvDetalles.Rows(i).Cells("Codigo").Value & "'" _
                                                         & " UPDATE REG_ABUELAS SET Estado_Actual = @Estado, Lote_No ='0'  WHERE Código_Abuela = @CodigoCerdo" _
                                                         & " UPDATE REG_MADRES SET Estado_Actual = @Estado,Lote_No ='0'  WHERE Código_Cerda = @CodigoCerdo" _
                                                         & " UPDATE REG_VERRACOS SET Estado_Actual =@Estado, Lote_No='0'  WHERE Codigo_Cerdo=@CodigoCerdo"

                    sql = New SqlCommand(cmd, con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                    If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = "N/A" Then
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 0, 0, 0, 1, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                        'RestarCosto_x_salidas(Me.DgvDetalles.Rows(i).Cells("Lote").Value, Me.txtFecha.Text, "SALIDA DE CERDOS X (V,D,R,R)", 1, "Sl." & Me.txtNoDocumento.Text)
                        sql = New SqlCommand("insert into MOVIMIENTOS_LOTES_INT (De_Lote, A_Lote,Fecha_Movimiento,Motivo,Cantidad,Usuario_Creador,Costo,Documento_NO) values('0','" & Me.DgvDetalles.Rows(i).Cells("Lote").Value & "','" & FechaSistema & "','SALIDA DE CERDOS ENGORDE','" & 1 & "','" & UsuarioActual & "','" & -Me.DgvDetalles.Rows(i).Cells("Unitario + IVA").Value & "','Sl." & Me.txtNoDocumento.Text & "')", con)
                        con.Open()
                        sql.ExecuteNonQuery()
                        con.Close()
                    Else
                        RegistrarMovimientoLote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, 0, 0, 0, 0, 0, 1, Me.txtFecha.Text, "Sl." & Me.txtNoDocumento.Text)
                    End If
                End If
                ActualizarLote()
                RevisarCierre_Lote(Me.DgvDetalles.Rows(i).Cells("Lote").Value, Me.cbxTipoSalida)

                linea += 1
            Next
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error al grabar Lineas de Salida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtTipoVenta.Text = "1" And Me.txtCliente.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el cliente", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtCliente.Focus()
        ElseIf Me.txtTipoVenta.Text = "" Then
            MessageBoxEx.Show("No ha ingresado el tipo de venta", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtTipoVenta.Focus()
        ElseIf SeleccionoGranja = False Then
            MessageBoxEx.Show("No ha seleccionado la granja", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cbxGranjas.Focus()
        ElseIf Me.txtJustificación.Text = "" Then
            MessageBoxEx.Show("No ha ingresado la justificación", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtJustificación.Focus()
        ElseIf Not IsDate(Me.txtFecha.Text) Then
            MessageBoxEx.Show("La fecha que ha ingresado es erronea", "Fecha Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtFecha.Focus()
            'Me.CajaFecha1.Focus()
        ElseIf Not IsNumeric(Me.DocNoTextBoxX2.Text) Then
            MessageBoxEx.Show("El valor en el campo DocNo debe ser un valor númerico", "DocNo error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DocNoTextBoxX2.Focus()
        ElseIf Me.serieTextBoxX1.Text.Trim.Length < 1 Then
            MessageBoxEx.Show("El campo serie no puede quedar en blanco", "Serie error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.serieTextBoxX1.Focus()
        ElseIf Me.tipodocComboBoxEx1.SelectedValue = "" Then
            MessageBoxEx.Show("Debe seleccionar un tipo de documento", "Serie error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tipodocComboBoxEx1.Focus()
            'ElseIf Me.transportistaTextBoxX1.Text.Trim.Length < 3 Then
            '    MessageBoxEx.Show("Debe ingresar el transportista", "Serie error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.tipodocComboBoxEx1.Focus()
        Else
            If Me.DgvDetalles.Rows.Count = 0 Then
                MessageBoxEx.Show("No hay ninguna linea en detalles", "Sin Detalles", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.GuardarEncabezadoSalida()
                Me.GrabarLineas()

                imprimirsalida(Me.txtNoDocumento.Text)


                '************************* inicio impresion***************************************
                '************************** deshabilitado por que no la estan imprimiendo ************

                'MessageBoxEx.Show("Se va a imprimir la salida prepare la impresora, luego presione ok", "Impresión Salida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'oAdapter = New SqlDataAdapter("SELECT * FROM LINEAS_DE_SALIDAS", con)
                'Dts = New DataSet
                'con.Open()
                'oAdapter.Fill(Dts, "LineasSalidas")
                'con.Close()
                'Dts.Tables("LineasSalidas").Clear()
                'For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
                '    dr = Dts.Tables("LineasSalidas").NewRow
                '    dr(0) = Me.txtNoDocumento.Text
                '    dr(1) = Me.DgvDetalles.Rows(i).Cells("Item#").Value
                '    dr(2) = Me.txtFecha.Text
                '    dr(3) = Me.DgvDetalles.Rows(i).Cells("Lote").Value
                '    dr(4) = Me.DgvDetalles.Rows(i).Cells("Codigo").Value
                '    dr(5) = Me.DgvDetalles.Rows(i).Cells("Tipo Salida").Value
                '    dr(6) = Me.DgvDetalles.Rows(i).Cells("Cantidad").Value
                '    dr(7) = Me.DgvDetalles.Rows(i).Cells("Unitario + IVA").Value
                '    dr(8) = Me.DgvDetalles.Rows(i).Cells("Costo").Value
                '    dr(9) = Me.DgvDetalles.Rows(i).Cells("Peso Real en Pie Lbs.").Value
                '    dr(10) = Me.DgvDetalles.Rows(i).Cells("Peso Prom. Lbs.").Value
                '    dr(11) = True
                '    dr(12) = UsuarioActual

                '    Dts.Tables("LineasSalidas").Rows.Add(dr)
                'Next
                'Dim vs As New Visualizador
                'Dim rpSalida As New rptSalidaCerdos_as
                'With rpSalida
                '    .SetDataSource(Dts.Tables("LineasSalidas"))
                '    .SetParameterValue("Cliente", Me.txtCliente.Text)
                '    .SetParameterValue("Direccion", Me.txtDireccion.Text)
                '    .SetParameterValue("NoDoc", Me.txtNoDocumento.Text)
                '    .SetParameterValue("Granja", Me.cbxGranjas.Text)
                '    .SetParameterValue("TotalLetras", Me.txtValorEnLetras.Text)
                '    .SetParameterValue("Peso", Me.txtPeso.Text)
                '    .SetParameterValue("Total", Me.txtTotal.Text)
                '    .SetParameterValue("TipoVenta", Me.txtDescripcionTipoVenta.Text)
                '    vs.CrReporteViewerç.ReportSource = rpSalida
                '    .PrintToPrinter(2, False, 1, 1)
                '    'vs.CrReporteViewerç.PrintReport()
                'End With

                '******************************fin impresion***************************


                Me.carrito.Rows.Clear()
                MostrarGranjas()
                Me.txtTipoVenta.Text = ""
                Me.txtDescripcionTipoVenta.Text = ""
                Me.txtValorEnLetras.Text = ""
                Me.txtCliente.Text = ""
                Me.txtTotal.Text = "0.00"
                Me.totalcanalTextBoxX1.Text = "0.00"
                Me.cbxGranjas.Focus()
                Me.txtJustificación.Text = ""
                Me.txtDireccion.Text = ""
                Me.txtPeso.Text = "0.00"
                Me.cbxGranjas.Enabled = True
                Me.txtTipoVenta.Enabled = True
                NoAuto()
            End If
           
        End If
    End Sub
    Private Sub txtFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        'If Me.txtFecha.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
        '    Me.txtFecha.Text = Me.txtFecha.Text & "/"
        '    Me.txtFecha.SelectionStart = 4
        'ElseIf Me.txtFecha.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
        '    Me.txtFecha.Text = Me.txtFecha.Text & "/"
        '    Me.txtFecha.SelectionStart = 6
        'End If
    End Sub

    Private Sub cbxTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.cbxTipoDocumento.SelectedItem.ToString = "Fáctura" Then
        '    Me.lbTipoDocumento.Text = "FÁCTURA"
        'ElseIf Me.cbxTipoDocumento.SelectedItem.ToString = "Crédito Fiscal" Then
        '    Me.lbTipoDocumento.Text = "CRÉDITO FISCAL"
        'End If
    End Sub

    Sub Totales()
        Dim TotalP As Single
        Dim totalPeso As Single
        Dim totalpesocanal As Single

        Dim Total As Double
        For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
            Total += Me.DgvDetalles.Rows(i).Cells("Precio/Venta").Value
            totalPeso += Me.DgvDetalles.Rows(i).Cells("Peso Real en Pie Lbs.").Value
            totalpesocanal += Me.DgvDetalles.Rows(i).Cells("Peso Real Canal Lbs.").Value
        Next
        TotalP = Total
        Me.txtTotal.Text = Total
        Me.txtPeso.Text = totalPeso
        Me.totalcanalTextBoxX1.Text = totalpesocanal
        Try
            'Dim TotalP As Single
            'For i As Integer = 0 To Me.carrito.Rows.Count - 1
            '    Total += carrito.Rows(i)(8)
            'Next
            'TotalP = Total
            'Me.txtTotal.Text = TotalP
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub BorrarLinea()
        Try
            Fila = Me.DgvDetalles.CurrentCell.RowIndex
            If Fila > -1 And Me.carrito.Rows.Count > 0 Then
                Total -= Single.Parse(Me.DgvDetalles.Item(8, Fila).Value)
                Me.carrito.Rows.RemoveAt(Fila)
                For i As Integer = 0 To carrito.Rows.Count - 1
                    carrito.Rows(i).BeginEdit()
                    carrito.Rows(i)(0) = 1 + 1
                    carrito.Rows(i).BeginEdit()
                Next
                Totales()
            End If
            CantidadCerdos_Engorde()
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, "Error remover fila", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BorrarLinea()
    End Sub

    Private Sub txtNoDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoDocumento.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cbxGranjas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxGranjas.SelectedIndexChanged
        SeleccionoGranja = True
        Me.txtTipoVenta.Focus()
        sql = New SqlCommand("select Codigo_Granja from Granjas where Nombre='" & Me.cbxGranjas.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            Granjas = leer(0).ToString
        End While
        con.Close()
        Me.cbxLote.Items.Clear()
        sql = New SqlCommand("select Lote_No from LOTES where Estado<>'T' AND Codigo_Granja='" & Granjas & "' and IdEtapa_Cerdas in ('E','VR','V','R')", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            Me.cbxLote.Items.Add(leer(0))
        End While
        con.Close()

    End Sub

    Private Sub txtTipoVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoVenta.KeyDown
        If e.KeyCode = Keys.F5 Then
            ButtonX4_Click(sender, e)
        End If
    End Sub

    Private Sub txtTipoVenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoVenta.LostFocus

        If Me.txtTipoVenta.Text = "2" Then
            Me.txtCliente.Enabled = False
            Me.txtDireccion.Enabled = False
        ElseIf Me.txtTipoVenta.Text <> "" Then
            Me.txtCliente.Enabled = True
            Me.txtDireccion.Enabled = True
            Me.txtCliente.Focus()
        End If
        If Me.txtTipoVenta.Text <> "" Then
            Dim ExisteTipoVenta As Boolean = False
            Dim DescripcionTipoVenta As String = ""
            sql = New SqlCommand("select Descripcion from Tipos_Ventas where Codigo='" & Me.txtTipoVenta.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ExisteTipoVenta = True
                DescripcionTipoVenta = leer(0).ToString
            End While
            con.Close()
            If ExisteTipoVenta = False Then
                MessageBoxEx.Show("No existe el tipo de venta que ha ingresado", "Error tipo de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtTipoVenta.Clear()
                Me.txtDescripcionTipoVenta.Clear()
                Me.txtTipoVenta.Focus()
            Else
                Me.txtDescripcionTipoVenta.Text = DescripcionTipoVenta
            End If
        End If
    End Sub
    Private Sub txtTipoVenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoVenta.TextChanged
        
    End Sub
    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoVenta.Click
        With My.Forms.dlgTipos_de_Venta
            .StartPosition = FormStartPosition.CenterScreen
            .txtDescripcion.Text = ""
            .txtDescripcion.Focus()
            .ShowDialog()
        End With
    End Sub
    Private Sub cbxLote_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLote.LostFocus
        cbxLote_SelectedIndexChanged(sender, e)
    End Sub
    Public Sub CantidadCerdos_Engorde()

        sql = New SqlCommand("SELECT Total_Cerdos  FROM Total_Cerdos_Lote  WHERE Lote_No ='" & Me.cbxLote.Text & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            CANTIDADCERDOS = leer(0)
        End While
        con.Close()
        Dim CerdosCargados As Integer = 0
        For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
            If Me.DgvDetalles.Rows(i).Cells("Lote").Value = Me.cbxLote.Text Then
                CerdosCargados += 1
            End If
        Next
        CANTIDADCERDOS = (CANTIDADCERDOS - CerdosCargados - Val(txtCantidad.Text) + 1)
    End Sub
    Private Sub cbxLote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLote.SelectedIndexChanged
        If Me.cbxLote.Text <> "" Then
            Try
                b.Close()
            Catch ex As Exception

            End Try
            Me.txtCostoUnitario.Text = "0.00"
            Dim ExisteLote As Boolean = False
            Dim DescrLote As String = ""
            Dim EtapaCerda As String = ""
            seleccionTipoSalida = False
            SeleccionoCodifgoCerdo = False
            

            Dim cmd As String = "SELECT e.Descripcion, l.IdEtapa_Cerdas FROM Lotes l JOIN Etapas_Cerdas_Lote e on l.IdEtapa_Cerdas=e.IdEtapa_Cerdas where l.Lote_No='" & Me.cbxLote.Text & "'"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ExisteLote = True
                DescrLote = RTrim(leer(0).ToString)
                EtapaCerda = leer(1).ToString
            End While
            con.Close()
            If ExisteLote = False Then
                MessageBoxEx.Show("No existe ningún lote con el codigo: " & Me.cbxLote.Text & " porfavor asegurese que el lote existe", "No existe Lote", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.cbxLote.Text = ""
                Me.txtDescrLote.Text = ""
                Me.cbxLote.Focus()

            Else
                ExisteLote = False
                Me.txtDescrLote.Text = RTrim(DescrLote)

            End If
            'MsgBox(EtapaCerda)
            If Me.txtDescrLote.Text.ToString = "ENGORDE" Then
                Me.txtCostoUnitario.Enabled = False
                Me.cbxTipoSalida.Items.Clear()
                sql = New SqlCommand("SELECT Descripcion FROM Tipos_Salidas", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.cbxTipoSalida.Items.Add(leer(0))
                End While
                con.Close()
                CantidadCerdos_Engorde()
                Me.cbxCodigoCerdo.Items.Clear()
                Me.cbxCodigoCerdo.Enabled = False
                Dim FECHANAC As Date
                Dim FECHAACTUAL As Date
                Dim EDAD As Integer

                sql = New SqlCommand("SELECT Fecha FROM Fecha_Dias_Desarrollo WHERE Lote_No='" & Me.cbxLote.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    FECHANAC = DateValue(leer(0))
                End While
                con.Close()
                FECHAACTUAL = DateValue(Me.txtFecha.Text)
                EDAD = DateDiff(DateInterval.Day, FECHANAC, FECHAACTUAL)
                Dim cmd2 As String = "DECLARE @Edad int" _
                             & " SET @Edad = '" & EDAD & "'" _
                             & " SELECT a.Peso_Vivo_Kg_Acumulado FROM tablaAlimenticiaLM80_HC40 AS a WHERE @Edad between a.Edad_Dias and a.Hasta_Dias"
                sql = New SqlCommand(cmd2, con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    PesoCerdo = leer(0)
                End While
                con.Close()

                Dim TotalCerdos As Integer = 0
                sql = New SqlCommand("select (isnull((SUM(ml.Entrada )),0)-(isnull((SUM(ml.Defuncion )),0)+isnull((SUM(ml.Destazo )),0)+isnull((SUM(ml.Rastro )),0)+isnull((SUM(ml.Reemplazos )),0)+isnull((SUM(ml.Salida )),0))) from MOVIMIENTO_LOTE ml where ml.Lote_No ='" & Me.cbxLote.Text & "' and (ml.Fecha_Movimiento <'" & FechaSistema & "' or ml.Documento_NO like 'Tg%')", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    TotalCerdos = leer(0)
                    CANTIDADCERDOS = leer(0)
                End While
                con.Close()

                Dim CostoLoteMovimiento_Int As Double = 0
                Dim CostoRequisiciones As Double = 0
                sql = New SqlCommand("(SELECT ISNULL((SUM(Costo)),0) FROM MOVIMIENTOS_LOTES_INT WHERE A_Lote ='" & Me.cbxLote.Text & "' and (Fecha_Movimiento<'" & FechaSistema & "' or Documento_NO like 'Tg%'))", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CostoLoteMovimiento_Int = leer(0)
                End While
                con.Close()

                sql = New SqlCommand("(SELECT ISNULL((SUM(IMPORTE)),0) FROM LINEAS_DE_REQUISICIONES WHERE Lote_No ='" & Me.cbxLote.Text & "' and Fecha_Liquidacion<'" & FechaSistema & "' and Viva='True')", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    CostoRequisiciones = leer(0)
                End While
                con.Close()
                Dim costoUnitario As Double = Math.Round((((CostoLoteMovimiento_Int + CostoRequisiciones) / TotalCerdos) * 1), 2)
                Me.txtCostoUnitario.Text = Val(costoUnitario)

            ElseIf Me.txtDescrLote.Text.ToString = "VERRACOS" Then
                If Me.cbxLote.Text <> "" Then
                    Me.cbxCodigoCerdo.Enabled = True
                    Me.cbxCodigoCerdo.Items.Clear()
                    Me.txtCostoUnitario.Enabled = True
                    Me.cbxCodigoCerdo.Focus()
                    sql = New SqlCommand("SELECT Código_Cerda from REG_MADRES where Lote_No='" & Me.cbxLote.Text & "' and Estado_Actual<>'D' and Estado_Actual<>'DF'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        Me.cbxCodigoCerdo.Items.Add(leer(0))
                    End While
                    con.Close()
                    sql = New SqlCommand("SELECT Código_Abuela from REG_ABUELAS where Lote_No='" & Me.cbxLote.Text & "' and Estado_Actual<>'D' and Estado_Actual<>'DF'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        Me.cbxCodigoCerdo.Items.Add(leer(0))
                    End While
                    con.Close()

                    sql = New SqlCommand("SELECT Codigo_Cerdo from REG_VERRACOS where Lote_No='" & Me.cbxLote.Text & "' and Estado_Actual<>'D' and Estado_Actual<>'DF' and Estado_Actual<>'NA'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        Me.cbxCodigoCerdo.Items.Add(leer(0))
                    End While
                    con.Close()

                    'For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
                    '    For y As Integer = 0 To Me.cbxCodigoCerdo.Items.Count - 1
                    '        If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = Me.cbxCodigoCerdo.Items(y).ToString Then
                    '            Me.cbxCodigoCerdo.Items.RemoveAt(y)
                    '        End If
                    '    Next
                    'Next

                    Me.cbxTipoSalida.Items.Clear()
                    sql = New SqlCommand("SELECT Descripcion FROM Tipos_Salidas", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        Me.cbxTipoSalida.Items.Add(leer(0))
                    End While
                    con.Close()
                End If

            Else
                If Me.cbxLote.Text <> "" Then
                    Me.cbxCodigoCerdo.Enabled = True
                    Me.cbxCodigoCerdo.Items.Clear()
                    Me.cbxCodigoCerdo.Focus()
                    Me.txtCostoUnitario.Enabled = False
                    sql = New SqlCommand("SELECT Código_Cerda from REG_MADRES where Lote_No='" & Me.cbxLote.Text & "' and Estado_Actual<>'D' and Estado_Actual<>'DF'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        Me.cbxCodigoCerdo.Items.Add(leer(0))
                    End While
                    con.Close()
                    sql = New SqlCommand("SELECT Código_Abuela from REG_ABUELAS where Lote_No='" & Me.cbxLote.Text & "' and Estado_Actual<>'D' and Estado_Actual<>'DF'", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        Me.cbxCodigoCerdo.Items.Add(leer(0))
                    End While
                    con.Close()

                    'sql = New SqlCommand("SELECT Codigo_Cerdo from REG_VERRACOS where Lote_No='" & Me.cbxLote.Text & "' and Estado_Actual<>'D'", con)
                    'con.Open()
                    'leer = sql.ExecuteReader
                    'While leer.Read
                    '    Me.cbxCodigoCerdo.Items.Add(leer(0))
                    'End While
                    'con.Close()

                    'For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
                    '    For y As Integer = 0 To Me.cbxCodigoCerdo.Items.Count - 1
                    '        If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = Me.cbxCodigoCerdo.Items(y).ToString Then
                    '            Me.cbxCodigoCerdo.Items.RemoveAt(y)
                    '        End If
                    '    Next
                    'Next

                    Me.cbxTipoSalida.Items.Clear()
                    sql = New SqlCommand("SELECT Descripcion FROM Tipos_Salidas", con)
                    con.Open()
                    leer = sql.ExecuteReader
                    While leer.Read
                        Me.cbxTipoSalida.Items.Add(leer(0))
                    End While
                    con.Close()
                End If

            End If
        End If



    End Sub

    Private Sub cbxTipoSalida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoSalida.SelectedIndexChanged
        seleccionTipoSalida = True
        If seleccionTipoSalida = True Then
            sql = New SqlCommand("SELECT Codigo_Salida FROM Tipos_Salidas WHERE Descripcion='" & Me.cbxTipoSalida.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                TipoSalida = leer(0)
            End While
            con.Close()

            If Trim(txtDescrLote.Text) = "ENGORDE" Then
                Me.txtCantidad.Enabled = True

                Me.txtCantidad.Focus()
            Else
                Me.txtCantidad.Enabled = False
            End If

            cargarmotivossalidas(TipoSalida)

        End If
    End Sub
    Sub cargarmotivossalidas(ByVal tiposalida As String)
        Try
            Me.motivoTextBoxX1.DataSource = motivossalidasAdapter.GetData(tiposalida)
            motivoTextBoxX1.DisplayMember = "Motivo"
            motivoTextBoxX1.ValueMember = "Motivo"

            If motivoTextBoxX1.Items.Count > 0 Then
                motivoTextBoxX1.DropDownStyle = ComboBoxStyle.DropDownList
            Else
                motivoTextBoxX1.DropDownStyle = ComboBoxStyle.Simple
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar motivos salidas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cbxCodigoCerdo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCodigoCerdo.SelectedIndexChanged
        If Me.txtDescrLote.Text = "VERRACOS" Then
            Me.txtCostoUnitario.Text = "0.00"
            SeleccionoCodifgoCerdo = True
            Dim FECHANAC As Date
            Dim FECHAACTUAL As Date
            FECHAACTUAL = DateValue(Me.txtFecha.Text)
            Dim EDADDIAS As Integer
            Dim EDADAÑOS As Integer
            Dim PRECIOCOMPRA As Double
            Dim FECHACOMPRA As Date
            sql = New SqlCommand("SELECT Fecha_Nacimiento FROM REG_ABUELAS WHERE Código_Abuela='" & Me.cbxCodigoCerdo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                FECHANAC = DateValue(leer(0))
            End While
            con.Close()
            sql = New SqlCommand("SELECT Fecha_Nacimiento FROM REG_MADRES WHERE Código_Cerda='" & Me.cbxCodigoCerdo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                FECHANAC = DateValue(leer(0))
            End While
            con.Close()
            sql = New SqlCommand("SELECT Fecha_Compra FROM REG_VERRACOS WHERE Codigo_Cerdo='" & Me.cbxCodigoCerdo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                FECHANAC = DateValue(leer(0))
            End While
            con.Close()
            EDADDIAS = DateDiff(DateInterval.Day, FECHANAC, FECHAACTUAL)
            EDADAÑOS = DateDiff(DateInterval.Year, FECHANAC, FECHAACTUAL)
            Dim cmd As String = "DECLARE @Edad int" _
                              & " SET @Edad = '" & EDADDIAS & "'" _
                              & " SELECT a.Peso_Vivo_Kg_Acumulado FROM tablaAlimenticiaLM80_HC40 AS a WHERE @Edad  between a.Edad_Dias and a.Hasta_Dias"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                PesoCerdo = leer(0)
            End While
            con.Close()
            sql = New SqlCommand("SELECT Costo,Fecha_Compra  FROM REG_VERRACOS WHERE Codigo_Cerdo='" & Me.cbxCodigoCerdo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                PRECIOCOMPRA = Math.Round((leer(0)), 2)
                FECHACOMPRA = Format(leer(1), "dd/MM/yyyy")
            End While
            con.Close()

            'balloonTipFocus.Enabled = True
            'balloonTipHover.Enabled = True
            Try
                b.Close()
            Catch ex As Exception

            End Try
            b = New DevComponents.DotNetBar.Balloon()
            b.Style = eBallonStyle.Alert
            'b.CaptionImage = CType(balloonTipFocus.CaptionImage.Clone(), Image)
            b.CaptionText = "INFORMACIÓN DEL VERRACO"
            b.Text = " CODIGO: " & Me.cbxCodigoCerdo.Text & "| FECHA COMPRA: " & FECHACOMPRA & " | PRECIO COMPRA: " & PRECIOCOMPRA
            b.AlertAnimation = eAlertAnimation.TopToBottom
            b.AutoResize()
            b.AutoClose = True
            b.AutoCloseTimeOut = 120
            b.Owner = Me
            b.Show(Me.txtCostoUnitario, False)
            Dim ValorDepreciado As Double = 0
            sql = New SqlCommand("select isnull((sum(Depreciacion_Valor_Precio)),0) from Historico_Depreciaciones_Verracos where Codigo='" & RTrim(Me.cbxCodigoCerdo.Text) & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                ValorDepreciado = leer(0)
            End While
            con.Close()
            Me.txtCostoUnitario.Text = (PRECIOCOMPRA - ValorDepreciado)
            Me.txtCostoUnitario.Enabled = False
        ElseIf RTrim(Me.txtDescrLote.Text) = "REEMPLAZOS" Then
            Dim COSTOTOTAL As Double = 0
            Dim CostoReemplazo As Double = 0
            Dim CostoAlimentacion As Double = 0
            Dim COSTOUNITARIO As Double = 0
            Dim FECHAINGRESO As Date
            Dim NOCERDASREEMPLAZOS As Integer = 0
            Me.txtCostoUnitario.Text = "0.00"
            SeleccionoCodifgoCerdo = True
            Dim FECHANAC As Date
            Dim FECHAACTUAL As Date
            FECHAACTUAL = DateValue(Me.txtFecha.Text)
            Dim EDADDIAS As Integer
            sql = New SqlCommand("SELECT Fecha_Nacimiento FROM REG_ABUELAS WHERE Código_Abuela='" & Me.cbxCodigoCerdo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                FECHANAC = DateValue(leer(0))
            End While
            con.Close()
            sql = New SqlCommand("SELECT Fecha_Nacimiento FROM REG_MADRES WHERE Código_Cerda='" & Me.cbxCodigoCerdo.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                FECHANAC = DateValue(leer(0))
            End While
            con.Close()

            EDADDIAS = DateDiff(DateInterval.Day, FECHANAC, FECHAACTUAL)

            Dim cmd As String = "DECLARE @Edad int" _
                              & " SET @Edad = '" & EDADDIAS & "'" _
                              & " SELECT a.Peso_Vivo_Kg_Acumulado FROM tablaAlimenticiaLM80_HC40 AS a WHERE @Edad  between a.Edad_Dias and a.Hasta_Dias"
            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                PesoCerdo = leer(0)
            End While
            con.Close()
            sql2 = New SqlCommand("SELECT Costo_Traia_de_Engorde, Fecha_Entro FROM Costo_Cerdas_Individual_Reemplazos WHERE Codigo_Cerda='" & RTrim(Me.cbxCodigoCerdo.Text) & "'", con)
            con.Open()
            leer = sql2.ExecuteReader()
            While leer.Read
                CostoReemplazo = leer(0)
                FECHAINGRESO = leer(1)
            End While
            con.Close()
            Dim FECHAVENTA As Date = Me.txtFecha.Text
            sql = New SqlCommand("DECLARE @FECHAINGRESO DATE DECLARE @FECHASALIDA DATE SET @FECHAINGRESO ='" & FECHAINGRESO & "' SET @FECHASALIDA ='" & FECHAVENTA & "' SELECT isnull((SUM(l.Importe)),0) FROM LINEAS_DE_REQUISICIONES l WHERE l.Viva ='TRUE' and l.Lote_No ='" & Me.cbxLote.Text & "' and l.Fecha_Liquidacion between @FECHAINGRESO and @FECHASALIDA", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                CostoAlimentacion = leer(0)
            End While
            con.Close()
            sql = New SqlCommand("SELECT ISNULL((T.Total_Cerdos),1)  FROM Total_Cerdos_Lote  T WHERE T.Lote_No ='" & Me.cbxLote.Text & "'", con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                NOCERDASREEMPLAZOS = leer(0)
            End While
            con.Close()
            'MsgBox(CostoReemplazo)
            'MsgBox(CostoAlimentacion)


            If NOCERDASREEMPLAZOS = 0 Then
                COSTOUNITARIO = ((CostoAlimentacion / 1) + CostoReemplazo)
            Else
                COSTOUNITARIO = ((CostoAlimentacion / NOCERDASREEMPLAZOS) + CostoReemplazo)
            End If
            Me.txtCostoUnitario.Text = COSTOUNITARIO

        Else
            If Me.txtDescrLote.Text <> "ENGORDE" Then
                Me.txtCostoUnitario.Text = "0.00"
                SeleccionoCodifgoCerdo = True
                Dim FECHANAC As Date
                Dim FECHAACTUAL As Date
                FECHAACTUAL = DateValue(Me.txtFecha.Text)
                Dim EDADDIAS As Integer
                sql = New SqlCommand("SELECT Fecha_Nacimiento FROM REG_ABUELAS WHERE Código_Abuela='" & Me.cbxCodigoCerdo.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    FECHANAC = DateValue(leer(0))
                End While
                con.Close()
                sql = New SqlCommand("SELECT Fecha_Nacimiento FROM REG_MADRES WHERE Código_Cerda='" & Me.cbxCodigoCerdo.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    FECHANAC = DateValue(leer(0))
                End While
                con.Close()
                'sql = New SqlCommand("SELECT Fecha_Nacimiento FROM REG_VERRACOS WHERE Codigo_Cerdo='" & Me.cbxCodigoCerdo.Text & "'", con)
                'con.Open()
                'leer = sql.ExecuteReader
                'While leer.Read
                '    FECHANAC = DateValue(leer(0))
                'End While
                'con.Close()
                EDADDIAS = DateDiff(DateInterval.Day, FECHANAC, FECHAACTUAL)

                Dim cmd As String = "DECLARE @Edad int" _
                                  & " SET @Edad = '" & EDADDIAS & "'" _
                                  & " SELECT a.Peso_Vivo_Kg_Acumulado FROM tablaAlimenticiaLM80_HC40 AS a WHERE @Edad  between a.Edad_Dias and a.Hasta_Dias"
                sql = New SqlCommand(cmd, con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    PesoCerdo = leer(0)
                End While
                con.Close()

                sql = New SqlCommand("SELECT Depreciacion_Costo FROM Depreciacion_x_Cerda WHERE Codigo_Cerda='" & Me.cbxCodigoCerdo.Text & "'", con)
                con.Open()
                leer = sql.ExecuteReader
                While leer.Read
                    Me.txtCostoUnitario.Text = Math.Round((leer(0)), 2)
                End While
                con.Close()

            End If
        End If

    End Sub
   
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Lineas As Integer = 1
        For I As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
            Lineas += 1
        Next
        If Lineas <= 30 Then
            If Me.txtDescrLote.Text = "ENGORDE" Then
                Me.CantidadCerdos_Engorde()
                Dim cantidad As Integer = 0
                cantidad = Val(Me.txtCantidad.Text)
                If seleccionTipoSalida = False Then
                    MessageBoxEx.Show("No ha seleccionado el tipo de salida con el que procesará los cerdos", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.cbxTipoSalida.Focus()
                ElseIf Me.txtPesoRealLbs.Text = "" Or txtPesoRealLbs.Text = "0.00" Or Me.txtPesoRealLbs.Text = "0" Then
                    MessageBoxEx.Show("No ha ingresado el peso en lbs. del cerdo/a", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtPesoRealLbs.Focus()
                ElseIf CANTIDADCERDOS <= 0 Then
                    MessageBoxEx.Show("La cantidad de cerdos excede el numero en existencias", "Cantidad Exedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Me.cbxTipoSalida.Text = "DESTAZO" And trim(Me.motivoTextBoxX1.Text) = "" Then
                    MessageBoxEx.Show("Debe ingresar el motivo por el cual se esta destazando", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.motivoTextBoxX1.Focus()
                ElseIf RTRIM(Me.ubicacionComboBoxEx1.Text) = "" Then
                    MessageBox.Show("Debe seleccionar la ubicación de donde esta sacando los cerdos", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Me.ubicacionComboBoxEx1.Focus()
                Else
                    'Try
                    'If TipoSalida = "LQ" Then
                    Dim pesoprome As Double = 0
                    Dim precioventa As Double = 0
                    Dim pesocanal As Double = 0
                    Dim pesochachetes As Double = 0
                    pesoprome = CDbl(Me.txtPesoRealLbs.Text) / CDbl(Me.txtCantidad.Text)
                    pesocanal = CDbl(Me.pesocanalTextBoxX1.Text) / CDbl(Me.txtCantidad.Text)
                    precioventa = CDbl(Me.txtPrecioVenta.Text) / CDbl(Me.txtCantidad.Text)
                    pesochachetes = CDbl(Me.pesocachetesLbsDoubleInput1.Value) / CDbl(Me.txtCantidad.Text)
                    For i As Integer = 1 To Me.txtCantidad.Text
                        dr = carrito.NewRow
                        dr(0) = carrito.Rows.Count + 1
                        dr(1) = Me.cbxLote.Text
                        dr(2) = "N/A"
                        dr(3) = TipoSalida
                        dr(4) = 1
                        dr(5) = pesoprome
                        dr(6) = PesoCerdo
                        dr(7) = txtCostoUnitario.Text
                        dr(8) = precioventa
                        dr(10) = pesocanal
                        dr(11) = Me.motivoTextBoxX1.Text
                        dr(12) = Me.ubicacionComboBoxEx1.SelectedValue
                        dr(13) = pesochachetes
                        carrito.Rows.Add(dr)
                    Next
                    Me.txtCantidad.Text = 1
                    Me.txtCantidad.Enabled = False
                    'Else
                    'dr = carrito.NewRow
                    'dr(0) = carrito.Rows.Count + 1
                    'dr(1) = Me.cbxLote.Text
                    'dr(2) = "N/A"
                    'dr(3) = TipoSalida
                    'dr(4) = Me.txtCantidad.Text
                    'dr(5) = Me.txtPesoRealLbs.Text
                    'dr(6) = PesoCerdo
                    'dr(7) = txtCostoUnitario.Text
                    'dr(8) = Me.txtPrecioVenta.Text
                    'carrito.Rows.Add(dr)
                    'End If

                    Me.DgvDetalles.DataSource = carrito
                    Me.Totales()
                    Me.txtPesoRealLbs.Text = "0.00"
                    Me.txtPrecioVenta.Text = "0.00"
                    Me.pesocanalTextBoxX1.Text = "0.00"
                    Me.pesocachetesLbsDoubleInput1.Value = 0
                    Me.motivoTextBoxX1.Text = ""
                    Me.txtCostoUnitario.Clear()
                    Me.cbxLote_SelectedIndexChanged(sender, e)
                    Me.txtValorEnLetras.Text = UCase((Convertir_a_Letras(Me.txtTotal.Text)))
                    Me.CantidadCerdos_Engorde()
                    Me.cbxLote.Focus()
                    For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
                        Me.DgvDetalles.CurrentCell = Me.DgvDetalles.Rows(i).Cells("Codigo")
                    Next
                    'MsgBox(CANTIDADCERDOS)

                    'Catch ex As Exception
                    '    MessageBoxEx.Show(CadenaError & ex.Message, "Error Cargar cod", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End Try
                End If
            ElseIf Me.txtDescrLote.Text = "VERRACOS" Then
                If SeleccionoCodifgoCerdo = False Then
                    MessageBoxEx.Show("No ha seleccionado el código del cerda/o que desea procesar", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.cbxCodigoCerdo.Focus()
                ElseIf Me.seleccionTipoSalida = False Then
                    MessageBoxEx.Show("No ha seleccionado el tipo de salida con el que procesará los cerdos", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.cbxTipoSalida.Focus()
                ElseIf Me.txtPesoRealLbs.Text = "" Or txtPesoRealLbs.Text = "0.00" Or Me.txtPesoRealLbs.Text = "0" Then
                    MessageBoxEx.Show("No ha ingresado el peso en lbs. del cerdo/a", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtPesoRealLbs.Focus()
                ElseIf Me.txtCostoUnitario.Text = "" Then
                    MessageBoxEx.Show("No ha costo unitario del cerdo/a", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Me.cbxTipoSalida.Text = "DESTAZO" And trim(Me.motivoTextBoxX1.Text) = "" Then
                    MessageBoxEx.Show("Debe ingresar el motivo por el cual se esta destazando", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.motivoTextBoxX1.Focus()
                Else
                    Try
                        Dim YaSeagrego As Boolean = False
                        For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
                            If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = Me.cbxCodigoCerdo.Text Then
                                YaSeagrego = True
                            End If
                        Next
                        If YaSeagrego = True Then
                            MessageBoxEx.Show("El Código ya ha sido agregado a detalles", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.cbxCodigoCerdo.Focus()
                            Me.txtPesoRealLbs.Text = "0.00"
                            Me.txtCostoUnitario.Text = "0.00"
                            Me.pesocanalTextBoxX1.Text = "0.00"
                            'Me.cbxLote_SelectedIndexChanged(sender, e)
                        Else
                            dr = carrito.NewRow
                            dr(0) = carrito.Rows.Count + 1
                            dr(1) = Me.cbxLote.Text
                            dr(2) = Me.cbxCodigoCerdo.Text
                            dr(3) = TipoSalida
                            dr(4) = Me.txtCantidad.Text
                            dr(5) = Me.txtPesoRealLbs.Text
                            dr(6) = 550
                            dr(7) = txtCostoUnitario.Text
                            dr(8) = txtPrecioVenta.Text
                            dr(10) = Val(pesocanalTextBoxX1.Text)
                            dr(11) = Me.motivoTextBoxX1.Text
                            dr(12) = Me.ubicacionComboBoxEx1.SelectedValue
                            dr(13) = Me.pesocachetesLbsDoubleInput1.Value
                            carrito.Rows.Add(dr)
                            Me.DgvDetalles.DataSource = carrito
                            Me.Totales()
                            Me.txtPesoRealLbs.Text = "0.00"
                            Me.txtPrecioVenta.Text = "0.00"
                            Me.pesocanalTextBoxX1.Text = "0.00"
                            Me.pesocachetesLbsDoubleInput1.Value = 0
                            Me.motivoTextBoxX1.Text = ""
                            Me.txtCostoUnitario.Clear()
                            Me.cbxLote_SelectedIndexChanged(sender, e)
                            Me.txtValorEnLetras.Text = UCase((Convertir_a_Letras(Me.txtTotal.Text)))
                            Me.cbxLote.Focus()
                            'b.AutoCloseTimeOut = 1
                            b.Close()

                        End If
                    Catch ex As Exception
                        MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                If SeleccionoCodifgoCerdo = False Then
                    MessageBoxEx.Show("No ha seleccionado el código del cerda/o que desea procesar", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.cbxCodigoCerdo.Focus()
                ElseIf Me.seleccionTipoSalida = False Then
                    MessageBoxEx.Show("No ha seleccionado el tipo de salida con el que procesará los cerdos", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.cbxTipoSalida.Focus()
                ElseIf Me.txtPesoRealLbs.Text = "" Or txtPesoRealLbs.Text = "0.00" Or Me.txtPesoRealLbs.Text = "0" Then
                    MessageBoxEx.Show("No ha ingresado el peso en lbs. del cerdo/a", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtPesoRealLbs.Focus()

                ElseIf Me.cbxTipoSalida.Text = "DESTAZO" And trim(Me.motivoTextBoxX1.Text) = "" Then
                    MessageBoxEx.Show("Debe ingresar el motivo por el cual se esta destazando", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.motivoTextBoxX1.Focus()
                Else
                    Try
                        Dim YaSeagrego As Boolean = False
                        For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
                            If Me.DgvDetalles.Rows(i).Cells("Codigo").Value = Me.cbxCodigoCerdo.Text Then
                                YaSeagrego = True
                            End If
                        Next
                        If YaSeagrego = True Then
                            MessageBoxEx.Show("El Código ya ha sido agregado a detalles", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.cbxCodigoCerdo.Focus()
                            Me.txtPesoRealLbs.Text = "0.00"
                            Me.txtCostoUnitario.Text = "0.00"
                            Me.pesocanalTextBoxX1.Text = "0.00"
                            'Me.cbxLote_SelectedIndexChanged(sender, e)
                        Else
                            dr = carrito.NewRow
                            dr(0) = carrito.Rows.Count + 1
                            dr(1) = Me.cbxLote.Text
                            dr(2) = Me.cbxCodigoCerdo.Text
                            dr(3) = TipoSalida
                            dr(4) = Me.txtCantidad.Text
                            dr(5) = Me.txtPesoRealLbs.Text
                            dr(6) = 380
                            dr(7) = txtCostoUnitario.Text
                            dr(8) = txtPrecioVenta.Text
                            dr(10) = Val(pesocanalTextBoxX1.Text)
                            dr(11) = Me.motivoTextBoxX1.Text
                            dr(12) = Me.ubicacionComboBoxEx1.SelectedValue
                            dr(13) = Me.pesocachetesLbsDoubleInput1.Value
                            carrito.Rows.Add(dr)
                            Me.DgvDetalles.DataSource = carrito
                            Me.Totales()
                            Me.txtPesoRealLbs.Text = "0.00"
                            Me.txtPrecioVenta.Text = "0.00"
                            Me.pesocanalTextBoxX1.Text = "0.00"
                            Me.pesocachetesLbsDoubleInput1.Value = 0
                            Me.txtCostoUnitario.Clear()
                            Me.cbxLote_SelectedIndexChanged(sender, e)
                            Me.txtValorEnLetras.Text = UCase((Convertir_a_Letras(Me.txtTotal.Text)))
                            Me.cbxLote.Focus()
                        End If
                    Catch ex As Exception
                        MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Else
            MessageBoxEx.Show("Numero de lineas permitido 30 porfavor cree un nuevo registro, para dar salida a otros cerdos", "Lineas Exedidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtPesoRealLbs.Text = "0.00"
            Me.cbxLote_SelectedIndexChanged(sender, e)
        End If
        cargarubicaciones()

    End Sub
    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If Me.DgvDetalles.Rows.Count = 0 Then
            MessageBoxEx.Show("No hay ninguna linea de detalles", "Sin Lineas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Me.carrito.Rows.RemoveAt(Me.DgvDetalles.CurrentCell.RowIndex)
            Dim i As Integer
            For i = 0 To carrito.Rows.Count - 1
                carrito.Rows(i).BeginEdit()
                carrito.Rows(i)(0) = i + 1
                carrito.Rows(i).EndEdit()
            Next
            Me.Totales()
            If Me.DgvDetalles.Rows.Count > 0 Then
                Me.cbxGranjas.Enabled = False
                Me.txtTipoVenta.Enabled = False
            Else
                Me.cbxGranjas.Enabled = True
                Me.txtTipoVenta.Enabled = True
            End If
            CantidadCerdos_Engorde()
        End If
    End Sub
    Private Sub txtCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCliente.Text = UCase(Me.txtCliente.Text)
        Me.txtCliente.SelectionStart = 60
    End Sub

    Private Sub txtPesoRealLbs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesoRealLbs.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtPesoRealLbs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoRealLbs.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtFecha_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 47 And Not Asc(e.KeyChar) = 46 And Not Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If txtFecha.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            txtFecha.Text = txtFecha.Text & "/"
            txtFecha.SelectionStart = 4
        ElseIf txtFecha.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            txtFecha.Text = txtFecha.Text & "/"
            txtFecha.SelectionStart = 6
        End If
    End Sub

   
    Private Sub txtCliente_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        Me.txtCliente.Text = UCase(Me.txtCliente.Text)
        Me.txtCliente.SelectionStart = 51
    End Sub

    Private Sub txtDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.TextChanged
        Me.txtDireccion.Text = UCase(Me.txtDireccion.Text)
        Me.txtDireccion.SelectionStart = 61

    End Sub

    Private Sub txtJustificación_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJustificación.TextChanged
        Me.txtJustificación.Text = UCase(Me.txtJustificación.Text)
        Me.txtJustificación.SelectionStart = 101
    End Sub
    Private Sub DgvDetalles_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDetalles.CellLeave
        If Me.DgvDetalles.Rows.Count > 0 Then
            Me.cbxGranjas.Enabled = False
            Me.txtTipoVenta.Enabled = False
            Me.btnTipoVenta.Enabled = False
        Else
            Me.cbxGranjas.Enabled = True
            Me.txtTipoVenta.Enabled = True
            Me.btnTipoVenta.Enabled = True
        End If
    End Sub
    Private Sub txtCostoUnitario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCostoUnitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtPrecioVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecioVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtPrecioVenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioVenta.LostFocus
        If Me.txtPrecioVenta.Text = "" Then
            Me.txtPrecioVenta.Text = "0.00"
        End If
    End Sub

   
    Private Sub txtPrecioVenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioVenta.TextChanged

    End Sub

    Private Sub txtPesoRealLbs_TextChanged(sender As Object, e As EventArgs) Handles txtPesoRealLbs.TextChanged

    End Sub

    Private Sub pesocanalTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles pesocanalTextBoxX1.TextChanged

    End Sub

    Private Sub pesocanalTextBoxX1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pesocanalTextBoxX1.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)


    End Sub
    Sub imprimirsalida(ByVal salidano As Integer)
        'Try
        'Dim rptSalidaCerdosDocs As New rptSalidaCerdosDoc
        '    Proc_ImpresionSalidaCerdosDocsTableAdapter.Fill(odtsInventario.Proc_ImpresionSalidaCerdosDocs, salidano)
        '    rptSalidaCerdosDocs.SetDataSource(odtsInventario.Tables("Proc_ImpresionSalidaCerdosDocs"))
        ' rptSalidaCerdosDocs.PrintToPrinter(0, False, 1, 1)


        Dim rptAnexo As New rptAnexoImpresionSalidaDocs
            AnexoImpresionSalidaDocsTableAdapter.Fill(odtsInventario.AnexoImpresionSalidaDocs, salidano)
            rptAnexo.SetDataSource(odtsInventario.Tables("AnexoImpresionSalidaDocs"))

            Dim frmVistaPrevia As New frmVistaPreviaAnexoImpresion
            With frmVistaPrevia
                .CrystalReportViewer1.ReportSource = rptAnexo
                .WindowState = FormWindowState.Maximized
                .ShowDialog()
            End With
        'Catch ex As Exception
        '    MessageBox.Show("Error al imprimir salida de cerdos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub ButtonX3_Click_1(sender As Object, e As EventArgs) Handles ButtonX3.Click
        imprimirsalida(Me.salidanoreimpresionTextBoxX1.Text)
    End Sub

    Private Sub RibbonClientPanel1_Click(sender As Object, e As EventArgs) Handles RibbonClientPanel1.Click

    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        With frmUbicaciones
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
            cargarubicaciones()
        End With
    End Sub

    Private Sub ubicacionComboBoxEx1_KeyDown(sender As Object, e As KeyEventArgs) Handles ubicacionComboBoxEx1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            dlg_BuscarClienteND.StartPosition = FormStartPosition.CenterScreen
            dlg_BuscarClienteND.ShowDialog()
        End If
    End Sub
End Class