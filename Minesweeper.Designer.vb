<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minesweeper
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Minesweeper))
        Me.LayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutPanel
        '
        Me.LayoutPanel.AutoScroll = True
        Me.LayoutPanel.ColumnCount = 8
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LayoutPanel.Location = New System.Drawing.Point(153, 69)
        Me.LayoutPanel.Name = "LayoutPanel"
        Me.LayoutPanel.RowCount = 8
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LayoutPanel.Size = New System.Drawing.Size(531, 335)
        Me.LayoutPanel.TabIndex = 0
        '
        'Timer1
        '
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(51, 28)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(39, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Label1"
        '
        'LeaveButton
        '
        Me.LeaveButton.Location = New System.Drawing.Point(609, 18)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(75, 23)
        Me.LeaveButton.TabIndex = 2
        Me.LeaveButton.Text = "Abandonner"
        Me.LeaveButton.UseVisualStyleBackColor = True
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(150, 28)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(39, 13)
        Me.TimeLabel.TabIndex = 3
        Me.TimeLabel.Text = "Label1"
        '
        'PauseButton
        '
        Me.PauseButton.Location = New System.Drawing.Point(528, 18)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(75, 23)
        Me.PauseButton.TabIndex = 5
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.UseVisualStyleBackColor = True
        Me.PauseButton.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 41)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.LayoutPanel)
        Me.Name = "Minesweeper"
        Me.Text = "Minesweeper"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutPanel As TableLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NameLabel As Label
    Friend WithEvents LeaveButton As Button
    Friend WithEvents TimeLabel As Label
    Friend WithEvents PauseButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
