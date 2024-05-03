<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.txtEntradaDatos = New System.Windows.Forms.TextBox()
        Me.cmdEjecutarAlgoritmo = New System.Windows.Forms.Button()
        Me.lblSalidaDatos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEntradaDatos
        '
        Me.txtEntradaDatos.Location = New System.Drawing.Point(218, 12)
        Me.txtEntradaDatos.Name = "txtEntradaDatos"
        Me.txtEntradaDatos.Size = New System.Drawing.Size(291, 20)
        Me.txtEntradaDatos.TabIndex = 0
        '
        'cmdEjecutarAlgoritmo
        '
        Me.cmdEjecutarAlgoritmo.Location = New System.Drawing.Point(318, 73)
        Me.cmdEjecutarAlgoritmo.Name = "cmdEjecutarAlgoritmo"
        Me.cmdEjecutarAlgoritmo.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutarAlgoritmo.TabIndex = 1
        Me.cmdEjecutarAlgoritmo.Text = "Ejecutar"
        Me.cmdEjecutarAlgoritmo.UseVisualStyleBackColor = True
        '
        'lblSalidaDatos
        '
        Me.lblSalidaDatos.AutoSize = True
        Me.lblSalidaDatos.Location = New System.Drawing.Point(315, 57)
        Me.lblSalidaDatos.Name = "lblSalidaDatos"
        Me.lblSalidaDatos.Size = New System.Drawing.Size(64, 13)
        Me.lblSalidaDatos.TabIndex = 2
        Me.lblSalidaDatos.Text = "Texto Inicial"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSalidaDatos)
        Me.Controls.Add(Me.cmdEjecutarAlgoritmo)
        Me.Controls.Add(Me.txtEntradaDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEntradaDatos As TextBox
    Friend WithEvents cmdEjecutarAlgoritmo As Button
    Friend WithEvents lblSalidaDatos As Label
End Class
