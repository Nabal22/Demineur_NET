<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreTab
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.MineLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ChangeOrderButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(49, 162)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(243, 162)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(458, 162)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 2
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(46, 125)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(29, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Nom"
        '
        'MineLabel
        '
        Me.MineLabel.AutoSize = True
        Me.MineLabel.Location = New System.Drawing.Point(240, 135)
        Me.MineLabel.Name = "MineLabel"
        Me.MineLabel.Size = New System.Drawing.Size(126, 13)
        Me.MineLabel.TabIndex = 4
        Me.MineLabel.Text = "Nombre de mines révélés"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(455, 134)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(39, 13)
        Me.TimeLabel.TabIndex = 5
        Me.TimeLabel.Text = "Temps"
        '
        'ChangeOrderButton
        '
        Me.ChangeOrderButton.Location = New System.Drawing.Point(665, 124)
        Me.ChangeOrderButton.Name = "ChangeOrderButton"
        Me.ChangeOrderButton.Size = New System.Drawing.Size(86, 23)
        Me.ChangeOrderButton.TabIndex = 6
        Me.ChangeOrderButton.Text = "ChangerOrdre"
        Me.ChangeOrderButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(272, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(446, 42)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 8
        Me.SearchButton.Text = "Rechercher"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ScoreTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ChangeOrderButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.MineLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "ScoreTab"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents MineLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ChangeOrderButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SearchButton As Button
End Class
