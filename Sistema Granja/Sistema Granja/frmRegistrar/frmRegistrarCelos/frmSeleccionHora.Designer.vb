<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionHora
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TimeSelector1 = New DevComponents.Editors.DateTimeAdv.TimeSelector()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'TimeSelector1
        '
        Me.TimeSelector1.AutoSize = True
        '
        '
        '
        Me.TimeSelector1.BackgroundStyle.Class = "ItemPanel"
        Me.TimeSelector1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TimeSelector1.ContainerControlProcessDialogKey = True
        Me.TimeSelector1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeSelector1.HourText = "Hora"
        Me.TimeSelector1.Location = New System.Drawing.Point(0, 0)
        Me.TimeSelector1.MinuteText = "Minuto"
        Me.TimeSelector1.Name = "TimeSelector1"
        Me.TimeSelector1.Size = New System.Drawing.Size(252, 190)
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Sistema_Granja.My.Resources.Resources.DeleteRed
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX1.Location = New System.Drawing.Point(88, 198)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "&Cerrar"
        '
        'frmSeleccionHora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TimeSelector1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionHora"
        Me.Text = "Seleccione la hora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimeSelector1 As DevComponents.Editors.DateTimeAdv.TimeSelector
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
