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
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxMines = New System.Windows.Forms.ListBox()
        Me.ListBoxTime = New System.Windows.Forms.ListBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.MineLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ChangeOrderButton = New System.Windows.Forms.Button()
        Me.ComboBoxRechercheJoueur = New System.Windows.Forms.ComboBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxNbGame = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.Location = New System.Drawing.Point(49, 162)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxNom.TabIndex = 0
        '
        'ListBoxMines
        '
        Me.ListBoxMines.FormattingEnabled = True
        Me.ListBoxMines.Location = New System.Drawing.Point(243, 162)
        Me.ListBoxMines.Name = "ListBoxMines"
        Me.ListBoxMines.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxMines.TabIndex = 1
        '
        'ListBoxTime
        '
        Me.ListBoxTime.FormattingEnabled = True
        Me.ListBoxTime.Location = New System.Drawing.Point(458, 162)
        Me.ListBoxTime.Name = "ListBoxTime"
        Me.ListBoxTime.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxTime.TabIndex = 2
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
        Me.ChangeOrderButton.Location = New System.Drawing.Point(669, 97)
        Me.ChangeOrderButton.Name = "ChangeOrderButton"
        Me.ChangeOrderButton.Size = New System.Drawing.Size(86, 23)
        Me.ChangeOrderButton.TabIndex = 6
        Me.ChangeOrderButton.Text = "ChangerOrdre"
        Me.ChangeOrderButton.UseVisualStyleBackColor = True
        '
        'ComboBoxRechercheJoueur
        '
        Me.ComboBoxRechercheJoueur.FormattingEnabled = True
        Me.ComboBoxRechercheJoueur.Location = New System.Drawing.Point(272, 44)
        Me.ComboBoxRechercheJoueur.Name = "ComboBoxRechercheJoueur"
        Me.ComboBoxRechercheJoueur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxRechercheJoueur.TabIndex = 7
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(622, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre De Parties Jouées"
        '
        'ListBoxNbGame
        '
        Me.ListBoxNbGame.FormattingEnabled = True
        Me.ListBoxNbGame.Location = New System.Drawing.Point(625, 162)
        Me.ListBoxNbGame.Name = "ListBoxNbGame"
        Me.ListBoxNbGame.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxNbGame.TabIndex = 10
        '
        'ScoreTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBoxNbGame)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ComboBoxRechercheJoueur)
        Me.Controls.Add(Me.ChangeOrderButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.MineLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.ListBoxTime)
        Me.Controls.Add(Me.ListBoxMines)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Name = "ScoreTab"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxMines As ListBox
    Friend WithEvents ListBoxTime As ListBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents MineLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ChangeOrderButton As Button
    Friend WithEvents ComboBoxRechercheJoueur As ComboBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxNbGame As ListBox
End Class
