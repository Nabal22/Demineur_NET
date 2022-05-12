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
        Me.TableSizeLabel = New System.Windows.Forms.Label()
        Me.ValueSizeLabel = New System.Windows.Forms.Label()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TimeValueLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(346, 80)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar1.TabIndex = 0
        '
        'TableSizeLabel
        '
        Me.TableSizeLabel.AutoSize = True
        Me.TableSizeLabel.Location = New System.Drawing.Point(96, 80)
        Me.TableSizeLabel.Name = "TableSizeLabel"
        Me.TableSizeLabel.Size = New System.Drawing.Size(82, 13)
        Me.TableSizeLabel.TabIndex = 1
        Me.TableSizeLabel.Text = "Taille de la grille"
        '
        'ValueSizeLabel
        '
        Me.ValueSizeLabel.AutoSize = True
        Me.ValueSizeLabel.Location = New System.Drawing.Point(571, 84)
        Me.ValueSizeLabel.Name = "ValueSizeLabel"
        Me.ValueSizeLabel.Size = New System.Drawing.Size(33, 13)
        Me.ValueSizeLabel.TabIndex = 2
        Me.ValueSizeLabel.Text = "Label"
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(346, 143)
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar2.TabIndex = 3
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(96, 147)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(102, 13)
        Me.TimeLabel.TabIndex = 4
        Me.TimeLabel.Text = "Temps de résolution"
        '
        'TimeValueLabel
        '
        Me.TimeValueLabel.AutoSize = True
        Me.TimeValueLabel.Location = New System.Drawing.Point(571, 147)
        Me.TimeValueLabel.Name = "TimeValueLabel"
        Me.TimeValueLabel.Size = New System.Drawing.Size(33, 13)
        Me.TimeValueLabel.TabIndex = 5
        Me.TimeValueLabel.Text = "Label"
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TimeValueLabel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.ValueSizeLabel)
        Me.Controls.Add(Me.TableSizeLabel)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents TableSizeLabel As Label
    Friend WithEvents ValueSizeLabel As Label
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents TimeLabel As Label
    Friend WithEvents TimeValueLabel As Label
End Class
