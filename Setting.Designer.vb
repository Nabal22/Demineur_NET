<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableSizeLabel = New System.Windows.Forms.Label()
        Me.ScrollBar_Time = New System.Windows.Forms.HScrollBar()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TimeValueLabel = New System.Windows.Forms.Label()
        Me.Radio8x8 = New System.Windows.Forms.RadioButton()
        Me.Radio10x10 = New System.Windows.Forms.RadioButton()
        Me.GroupBoxChoixGrille = New System.Windows.Forms.GroupBox()
        Me.Radio6x6 = New System.Windows.Forms.RadioButton()
        Me.ValidAndQuitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MineValue = New System.Windows.Forms.Label()
        Me.ScrollBar_MineValue = New System.Windows.Forms.HScrollBar()
        Me.GroupBoxChoixGrille.SuspendLayout()
        Me.SuspendLayout()
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
        'ScrollBar_Time
        '
        Me.ScrollBar_Time.LargeChange = 5
        Me.ScrollBar_Time.Location = New System.Drawing.Point(287, 143)
        Me.ScrollBar_Time.Name = "ScrollBar_Time"
        Me.ScrollBar_Time.Size = New System.Drawing.Size(216, 17)
        Me.ScrollBar_Time.SmallChange = 5
        Me.ScrollBar_Time.TabIndex = 3
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
        Me.TimeValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeValueLabel.Location = New System.Drawing.Point(382, 160)
        Me.TimeValueLabel.Name = "TimeValueLabel"
        Me.TimeValueLabel.Size = New System.Drawing.Size(0, 20)
        Me.TimeValueLabel.TabIndex = 5
        '
        'Radio8x8
        '
        Me.Radio8x8.AutoSize = True
        Me.Radio8x8.Location = New System.Drawing.Point(80, 19)
        Me.Radio8x8.Name = "Radio8x8"
        Me.Radio8x8.Size = New System.Drawing.Size(48, 17)
        Me.Radio8x8.TabIndex = 6
        Me.Radio8x8.TabStop = True
        Me.Radio8x8.Text = "8 x 8"
        Me.Radio8x8.UseVisualStyleBackColor = True
        '
        'Radio10x10
        '
        Me.Radio10x10.AutoSize = True
        Me.Radio10x10.Location = New System.Drawing.Point(134, 19)
        Me.Radio10x10.Name = "Radio10x10"
        Me.Radio10x10.Size = New System.Drawing.Size(60, 17)
        Me.Radio10x10.TabIndex = 7
        Me.Radio10x10.TabStop = True
        Me.Radio10x10.Text = "10 x 10"
        Me.Radio10x10.UseVisualStyleBackColor = True
        '
        'GroupBoxChoixGrille
        '
        Me.GroupBoxChoixGrille.Controls.Add(Me.Radio6x6)
        Me.GroupBoxChoixGrille.Controls.Add(Me.Radio8x8)
        Me.GroupBoxChoixGrille.Controls.Add(Me.Radio10x10)
        Me.GroupBoxChoixGrille.Location = New System.Drawing.Point(287, 62)
        Me.GroupBoxChoixGrille.Name = "GroupBoxChoixGrille"
        Me.GroupBoxChoixGrille.Size = New System.Drawing.Size(216, 46)
        Me.GroupBoxChoixGrille.TabIndex = 8
        Me.GroupBoxChoixGrille.TabStop = False
        '
        'Radio6x6
        '
        Me.Radio6x6.AutoSize = True
        Me.Radio6x6.Location = New System.Drawing.Point(26, 19)
        Me.Radio6x6.Name = "Radio6x6"
        Me.Radio6x6.Size = New System.Drawing.Size(48, 17)
        Me.Radio6x6.TabIndex = 8
        Me.Radio6x6.TabStop = True
        Me.Radio6x6.Text = "6 x 6"
        Me.Radio6x6.UseVisualStyleBackColor = True
        '
        'ValidAndQuitButton
        '
        Me.ValidAndQuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidAndQuitButton.Location = New System.Drawing.Point(142, 206)
        Me.ValidAndQuitButton.Name = "ValidAndQuitButton"
        Me.ValidAndQuitButton.Size = New System.Drawing.Size(339, 51)
        Me.ValidAndQuitButton.TabIndex = 9
        Me.ValidAndQuitButton.Text = "Valider et Quitter"
        Me.ValidAndQuitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre de Mines"
        '
        'MineValue
        '
        Me.MineValue.AutoSize = True
        Me.MineValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MineValue.Location = New System.Drawing.Point(382, 42)
        Me.MineValue.Name = "MineValue"
        Me.MineValue.Size = New System.Drawing.Size(0, 20)
        Me.MineValue.TabIndex = 12
        '
        'ScrollBar_MineValue
        '
        Me.ScrollBar_MineValue.LargeChange = 1
        Me.ScrollBar_MineValue.Location = New System.Drawing.Point(287, 25)
        Me.ScrollBar_MineValue.Maximum = 20
        Me.ScrollBar_MineValue.Minimum = 5
        Me.ScrollBar_MineValue.Name = "ScrollBar_MineValue"
        Me.ScrollBar_MineValue.Size = New System.Drawing.Size(216, 17)
        Me.ScrollBar_MineValue.TabIndex = 11
        Me.ScrollBar_MineValue.Value = 5
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 281)
        Me.Controls.Add(Me.MineValue)
        Me.Controls.Add(Me.ScrollBar_MineValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ValidAndQuitButton)
        Me.Controls.Add(Me.GroupBoxChoixGrille)
        Me.Controls.Add(Me.TimeValueLabel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ScrollBar_Time)
        Me.Controls.Add(Me.TableSizeLabel)
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.GroupBoxChoixGrille.ResumeLayout(False)
        Me.GroupBoxChoixGrille.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableSizeLabel As Label
    Friend WithEvents ScrollBar_Time As HScrollBar
    Friend WithEvents TimeLabel As Label
    Friend WithEvents TimeValueLabel As Label
    Friend WithEvents Radio8x8 As RadioButton
    Friend WithEvents Radio10x10 As RadioButton
    Friend WithEvents Radio6x6 As RadioButton
    Friend WithEvents GroupBoxChoixGrille As GroupBox
    Friend WithEvents ValidAndQuitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MineValue As Label
    Friend WithEvents ScrollBar_MineValue As HScrollBar
End Class
