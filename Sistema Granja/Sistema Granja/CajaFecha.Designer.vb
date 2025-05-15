<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CajaFecha
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFecha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuspendLayout()
        '
        'txtFecha
        '
        '
        '
        '
        Me.txtFecha.Border.Class = "TextBoxBorder"
        Me.txtFecha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFecha.Location = New System.Drawing.Point(1, 0)
        Me.txtFecha.MaxLength = 8
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 0
        '
        'CajaFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtFecha)
        Me.Name = "CajaFecha"
        Me.Size = New System.Drawing.Size(104, 20)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFecha As DevComponents.DotNetBar.Controls.TextBoxX

End Class
