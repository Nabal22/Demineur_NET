<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(322, 80)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar1.TabIndex = 0
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HScrollBar1 As HScrollBar
End Class
