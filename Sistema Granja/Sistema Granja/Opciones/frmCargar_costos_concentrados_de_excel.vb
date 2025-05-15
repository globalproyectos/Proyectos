Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmCargar_costos_concentrados_de_excel
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim YaSegenero As Boolean = False
    Private Sub frmCargar_costos_concentrados_de_excel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtRango.Text = "A1:D61"
        Me.MostrarMeses()
        Dim MesActual As Integer = FechaSistema.Month
        Dim oMes As String = ""
        If MesActual = 1 Then
            oMes = "ENE"
        ElseIf MesActual = 2 Then
            oMes = "FEB"
        ElseIf MesActual = 3 Then
            oMes = "MAR"
        ElseIf MesActual = 4 Then
            oMes = "ABR"
        ElseIf MesActual = 5 Then
            oMes = "MAY"
        ElseIf MesActual = 6 Then
            oMes = "JUN"
        ElseIf MesActual = 7 Then
            oMes = "JUL"
        ElseIf MesActual = 8 Then
            oMes = "AGO"
        ElseIf MesActual = 9 Then
            oMes = "SEP"
        ElseIf MesActual = 10 Then
            oMes = "OCT"
        ElseIf MesActual = 11 Then
            oMes = "NOV"
        ElseIf MesActual = 12 Then
            oMes = "DIC"
        End If
        For i As Integer = 0 To Me.cbxMes.Items.Count - 1
            If oMes & FechaSistema.Year.ToString.Substring(2, 2) = Me.cbxMes.Items(i).ToString Then
                Me.cbxMes.SelectedIndex = i
            End If
        Next
        mostrarDias()

    End Sub
    Sub mostrarDias()
        Try
            If Me.cbxMes.SelectedItem.ToString = "ENE" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "01/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 1) & "/01/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "FEB" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "02/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 2) & "/02/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "MAR" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "03/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 3) & "/03/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "ABR" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "04/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 4) & "/04/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "MAY" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "05/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 5) & "/05/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "JUN" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "06/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 6) & "/06/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "JUL" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "07/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 7) & "/07/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "AGO" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "08/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 8) & "/08/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "SEP" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "09/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 9) & "/09/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "OCT" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "10/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 10) & "/10/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "NOV" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "11/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 11) & "/11/" & FechaSistema.Year.ToString.Substring(2, 2)
            ElseIf Me.cbxMes.SelectedItem.ToString = "DIC" & FechaSistema.Year.ToString.Substring(2, 2) Then
                Me.txtFechaInicio.Text = "01/" & "12/" & FechaSistema.Year.ToString.Substring(2, 2)
                Me.txtFechaFin.Text = Date.DaysInMonth(FechaSistema.Year.ToString.Substring(2, 2), 12) & "/12/" & FechaSistema.Year.ToString.Substring(2, 2)
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al mostrar dias", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub
    Sub MostrarMeses()
        Try
            Me.cbxMes.Items.Clear()
            For i As Integer = 1 To 12
                If i = 1 Then
                    Me.cbxMes.Items.Add("ENE" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 2 Then
                    Me.cbxMes.Items.Add("FEB" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 3 Then
                    Me.cbxMes.Items.Add("MAR" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 4 Then
                    Me.cbxMes.Items.Add("ABR" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 5 Then
                    Me.cbxMes.Items.Add("MAY" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 6 Then
                    Me.cbxMes.Items.Add("JUN" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 7 Then
                    Me.cbxMes.Items.Add("JUL" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 8 Then
                    Me.cbxMes.Items.Add("AGO" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 9 Then
                    Me.cbxMes.Items.Add("SEP" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 10 Then
                    Me.cbxMes.Items.Add("OCT" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 11 Then
                    Me.cbxMes.Items.Add("NOV" & FechaSistema.Year.ToString.Substring(2, 2))
                ElseIf i = 12 Then
                    Me.cbxMes.Items.Add("DIC" & FechaSistema.Year.ToString.Substring(2, 2))
                End If
            Next
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al mostrar meses", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        End Sub
    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX1.TextChanged
        If Me.TextBoxX1.Text <> "" Then

            Me.btnCargar.Enabled = True
        Else

            Me.btnCargar.Enabled = False
        End If
    End Sub
    Private Sub loadRange(ByVal sFileName As String, ByVal sSheetName As String, ByVal sRange As String,  ByVal dv As DataGridView) 
        Try

            ' // Comprobar que el archivo Excel existe 

            If System.IO.File.Exists(sFileName) Then



                Dim objDataSet As System.Data.DataSet

                Dim objDataAdapter As System.Data.OleDb.OleDbDataAdapter

                ' // Declarar la Cadena de conexión 

                Dim sCs As String = "provider=Microsoft.Jet.OLEDB.4.0; " & "data source=" & sFileName & "; Extended Properties=Excel 8.0;"

                Dim objOleConnection As System.Data.OleDb.OleDbConnection

                objOleConnection = New System.Data.OleDb.OleDbConnection(sCs)



                ' // Declarar la consulta SQL que indica el libro y el rango de la hoja 

                Dim sSql As String = "select * from " & "[" & sSheetName & "$" & sRange & "]"

                ' // Obtener los datos 

                objDataAdapter = New System.Data.OleDb.OleDbDataAdapter(sSql, objOleConnection)



                ' // Crear DataSet y llenarlo 

                objDataSet = New System.Data.DataSet



                objDataAdapter.Fill(objDataSet)

                ' // Cerrar la conexión 

                objOleConnection.Close()



                ' // Enlazar DataGrid al Dataset 

                With dv

                    .DataSource = objDataSet

                    .DataMember = objDataSet.Tables(0).TableName

                End With

            Else

                MsgBox("No se ha encontrado el archivo: " & sFileName, MsgBoxStyle.Exclamation)

            End If



            Exit Sub

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try



    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        With DialogoAbrir
            .Filter = "Documento Excel 97-2003|*.xls"
            .FileName = ""
            If (.ShowDialog(Me)) = Windows.Forms.DialogResult.OK Then
                Me.TextBoxX1.Text = .FileName.ToString
            End If
        End With
        
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Try
            loadRange(Me.TextBoxX1.Text, "Hoja1", Me.txtRango.Text, dgvVistaPrevia)
            For i As Integer = 0 To Me.dgvVistaPrevia.RowCount - 1
                Me.txtRegistros.Text = i
            Next
            Me.dgvVistaPrevia.Columns(0).Width = 80
            Me.dgvVistaPrevia.Columns(1).Width = 230
            Me.dgvVistaPrevia.Columns(2).Width = 80
            Me.dgvVistaPrevia.Columns(3).Width = 80
            Me.dgvVistaPrevia.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MessageBoxEx.Show("Se produjo el siguiente error: " & ex.Message, "Error al leer archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub txtRegistros_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegistros.TextChanged
        If Me.txtRegistros.Text <> "0" Then
            Me.btnSubir.Enabled = True
        Else
            Me.btnSubir.Enabled = False
        End If
    End Sub

    Private Sub cbxMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMes.SelectedIndexChanged
        mostrarDias()
    End Sub

    Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click
        YaSegenero = False
        sql = New SqlCommand("select * from Costos_Concentrados_x_Mes where Mes_a_Trabajar='" & RTrim(Me.cbxMes.SelectedItem.ToString) & "'", con)
        con.Open()
        leer = sql.ExecuteReader
        While leer.Read
            YaSegenero = True
        End While
        con.Close()
        If YaSegenero = True Then
            Dim resp As MsgBoxResult
            resp = MessageBoxEx.Show("Ya se encuentra un arhivo subido del mismo mes, si continua se reemplazará por el nuevo, desea continuar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = MsgBoxResult.Yes Then
                sql = New SqlCommand("delete from Costos_Concentrados_x_Mes where Mes_a_Trabajar='" & RTrim(Me.cbxMes.SelectedItem.ToString) & "'", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
                For i As Integer = 0 To Me.dgvVistaPrevia.RowCount - 1
                    sql = New SqlCommand("insert into Costos_Concentrados_x_Mes(Codigo,Descripcion,Costo_Unitario,Mes_Segun_Datalisys,Mes_a_Trabajar,Fecha_Inicio_Trabajar,Fecha_Fin_Trabajar) values('" & Me.dgvVistaPrevia.Rows(i).Cells(Me.dgvVistaPrevia.Columns(0).Name.ToString).Value & "','" & Me.dgvVistaPrevia.Rows(i).Cells(Me.dgvVistaPrevia.Columns(1).Name.ToString).Value & "','" & Me.dgvVistaPrevia.Rows(i).Cells(Me.dgvVistaPrevia.Columns(2).Name.ToString).Value & "','" & Me.dgvVistaPrevia.Rows(i).Cells(Me.dgvVistaPrevia.Columns(3).Name.ToString).Value & "','" & Me.cbxMes.SelectedItem.ToString & "','" & Me.txtFechaInicio.Text & "','" & Me.txtFechaFin.Text & "')", con)
                    con.Open()
                    sql.ExecuteNonQuery()
                    con.Close()
                Next
                Me.dgvVistaPrevia.DataSource = Nothing
                Me.TextBoxX1.Clear()
                Me.txtRegistros.Text = "0"
                MessageBoxEx.Show("Se ha subido el archivo exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            For i As Integer = 0 To Me.dgvVistaPrevia.RowCount - 1
                sql = New SqlCommand("insert into Costos_Concentrados_x_Mes(Codigo,Descripcion,Costo_Unitario,Mes_Segun_Datalisys,Mes_a_Trabajar,Fecha_Inicio_Trabajar,Fecha_Fin_Trabajar) values('" & Me.dgvVistaPrevia.Rows(i).Cells(Me.dgvVistaPrevia.Columns(0).Name.ToString).Value & "','" & Me.dgvVistaPrevia.Rows(i).Cells(Me.dgvVistaPrevia.Columns(1).Name.ToString).Value & "','" & Me.dgvVistaPrevia.Rows(i).Cells(Me.dgvVistaPrevia.Columns(2).Name.ToString).Value & "','" & Me.dgvVistaPrevia.Rows(i).Cells(Me.dgvVistaPrevia.Columns(3).Name.ToString).Value & "','" & Me.cbxMes.SelectedItem.ToString & "','" & Me.txtFechaInicio.Text & "','" & Me.txtFechaFin.Text & "')", con)
                con.Open()
                sql.ExecuteNonQuery()
                con.Close()
            Next
            Me.dgvVistaPrevia.DataSource = Nothing
            Me.TextBoxX1.Clear()
            Me.txtRegistros.Text = "0"
            MessageBoxEx.Show("Se ha subido el archivo exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
    End Sub
   
End Class