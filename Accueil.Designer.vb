<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.NomCbx = New System.Windows.Forms.ComboBox()
        Me.ValidButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.FormButton = New System.Windows.Forms.Button()
        Me.SettingBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomCbx
        '
        Me.NomCbx.FormattingEnabled = True
        Me.NomCbx.Location = New System.Drawing.Point(303, 150)
        Me.NomCbx.Name = "NomCbx"
        Me.NomCbx.Size = New System.Drawing.Size(164, 21)
        Me.NomCbx.TabIndex = 0
        '
        'ValidButton
        '
        Me.ValidButton.BackColor = System.Drawing.Color.White
        Me.ValidButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ValidButton.Location = New System.Drawing.Point(338, 260)
        Me.ValidButton.Name = "ValidButton"
        Me.ValidButton.Size = New System.Drawing.Size(102, 47)
        Me.ValidButton.TabIndex = 1
        Me.ValidButton.Text = "Jouer"
        Me.ValidButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(102, 260)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(85, 47)
        Me.QuitButton.TabIndex = 2
        Me.QuitButton.Text = "Quitter"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'FormButton
        '
        Me.FormButton.Location = New System.Drawing.Point(568, 260)
        Me.FormButton.Name = "FormButton"
        Me.FormButton.Size = New System.Drawing.Size(94, 47)
        Me.FormButton.TabIndex = 3
        Me.FormButton.Text = "Score"
        Me.FormButton.UseVisualStyleBackColor = True
        '
        'SettingBtn
        '
        Me.SettingBtn.Location = New System.Drawing.Point(338, 356)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(94, 47)
        Me.SettingBtn.TabIndex = 4
        Me.SettingBtn.Text = "Réglages"
        Me.SettingBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 41)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(765, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SettingBtn)
        Me.Controls.Add(Me.FormButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ValidButton)
        Me.Controls.Add(Me.NomCbx)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NomCbx As ComboBox
    Friend WithEvents ValidButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents FormButton As Button
    Friend WithEvents SettingBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
