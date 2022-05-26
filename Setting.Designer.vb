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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting))
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
        Me.PauseLabel = New System.Windows.Forms.Label()
        Me.PauseCheckbox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lvl5RadioButton = New System.Windows.Forms.RadioButton()
        Me.Lvl4RadioButton = New System.Windows.Forms.RadioButton()
        Me.Lvl1RadioButton = New System.Windows.Forms.RadioButton()
        Me.Lvl2RadioButton = New System.Windows.Forms.RadioButton()
        Me.Lvl3RadioButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxChoixGrille.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ValidAndQuitButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ValidAndQuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidAndQuitButton.Location = New System.Drawing.Point(108, 328)
        Me.ValidAndQuitButton.Name = "ValidAndQuitButton"
        Me.ValidAndQuitButton.Size = New System.Drawing.Size(339, 51)
        Me.ValidAndQuitButton.TabIndex = 9
        Me.ValidAndQuitButton.Text = "Valider et Quitter"
        Me.ValidAndQuitButton.UseVisualStyleBackColor = False
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
        'PauseLabel
        '
        Me.PauseLabel.AutoSize = True
        Me.PauseLabel.Location = New System.Drawing.Point(96, 197)
        Me.PauseLabel.Name = "PauseLabel"
        Me.PauseLabel.Size = New System.Drawing.Size(119, 13)
        Me.PauseLabel.TabIndex = 13
        Me.PauseLabel.Text = "Activer le bouton pause"
        '
        'PauseCheckbox
        '
        Me.PauseCheckbox.AutoSize = True
        Me.PauseCheckbox.Location = New System.Drawing.Point(287, 197)
        Me.PauseCheckbox.Name = "PauseCheckbox"
        Me.PauseCheckbox.Size = New System.Drawing.Size(15, 14)
        Me.PauseCheckbox.TabIndex = 14
        Me.PauseCheckbox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lvl5RadioButton)
        Me.GroupBox1.Controls.Add(Me.Lvl4RadioButton)
        Me.GroupBox1.Controls.Add(Me.Lvl1RadioButton)
        Me.GroupBox1.Controls.Add(Me.Lvl2RadioButton)
        Me.GroupBox1.Controls.Add(Me.Lvl3RadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 46)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Lvl5RadioButton
        '
        Me.Lvl5RadioButton.AutoSize = True
        Me.Lvl5RadioButton.Location = New System.Drawing.Point(327, 19)
        Me.Lvl5RadioButton.Name = "Lvl5RadioButton"
        Me.Lvl5RadioButton.Size = New System.Drawing.Size(66, 17)
        Me.Lvl5RadioButton.TabIndex = 10
        Me.Lvl5RadioButton.TabStop = True
        Me.Lvl5RadioButton.Text = "Machine"
        Me.Lvl5RadioButton.UseVisualStyleBackColor = True
        '
        'Lvl4RadioButton
        '
        Me.Lvl4RadioButton.AutoSize = True
        Me.Lvl4RadioButton.Location = New System.Drawing.Point(266, 19)
        Me.Lvl4RadioButton.Name = "Lvl4RadioButton"
        Me.Lvl4RadioButton.Size = New System.Drawing.Size(55, 17)
        Me.Lvl4RadioButton.TabIndex = 9
        Me.Lvl4RadioButton.TabStop = True
        Me.Lvl4RadioButton.Text = "Expert"
        Me.Lvl4RadioButton.UseVisualStyleBackColor = True
        '
        'Lvl1RadioButton
        '
        Me.Lvl1RadioButton.AutoSize = True
        Me.Lvl1RadioButton.Location = New System.Drawing.Point(6, 19)
        Me.Lvl1RadioButton.Name = "Lvl1RadioButton"
        Me.Lvl1RadioButton.Size = New System.Drawing.Size(87, 17)
        Me.Lvl1RadioButton.TabIndex = 8
        Me.Lvl1RadioButton.TabStop = True
        Me.Lvl1RadioButton.Text = "Entrainement"
        Me.Lvl1RadioButton.UseVisualStyleBackColor = True
        '
        'Lvl2RadioButton
        '
        Me.Lvl2RadioButton.AutoSize = True
        Me.Lvl2RadioButton.Location = New System.Drawing.Point(100, 19)
        Me.Lvl2RadioButton.Name = "Lvl2RadioButton"
        Me.Lvl2RadioButton.Size = New System.Drawing.Size(69, 17)
        Me.Lvl2RadioButton.TabIndex = 6
        Me.Lvl2RadioButton.TabStop = True
        Me.Lvl2RadioButton.Text = "Débutant"
        Me.Lvl2RadioButton.UseVisualStyleBackColor = True
        '
        'Lvl3RadioButton
        '
        Me.Lvl3RadioButton.AutoSize = True
        Me.Lvl3RadioButton.Location = New System.Drawing.Point(175, 19)
        Me.Lvl3RadioButton.Name = "Lvl3RadioButton"
        Me.Lvl3RadioButton.Size = New System.Drawing.Size(85, 17)
        Me.Lvl3RadioButton.TabIndex = 7
        Me.Lvl3RadioButton.TabStop = True
        Me.Lvl3RadioButton.Text = "Intermédiaire"
        Me.Lvl3RadioButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 41)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(563, 401)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PauseCheckbox)
        Me.Controls.Add(Me.PauseLabel)
        Me.Controls.Add(Me.MineValue)
        Me.Controls.Add(Me.ScrollBar_MineValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ValidAndQuitButton)
        Me.Controls.Add(Me.GroupBoxChoixGrille)
        Me.Controls.Add(Me.TimeValueLabel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ScrollBar_Time)
        Me.Controls.Add(Me.TableSizeLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.GroupBoxChoixGrille.ResumeLayout(False)
        Me.GroupBoxChoixGrille.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PauseLabel As Label
    Friend WithEvents PauseCheckbox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lvl5RadioButton As RadioButton
    Friend WithEvents Lvl4RadioButton As RadioButton
    Friend WithEvents Lvl1RadioButton As RadioButton
    Friend WithEvents Lvl2RadioButton As RadioButton
    Friend WithEvents Lvl3RadioButton As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
