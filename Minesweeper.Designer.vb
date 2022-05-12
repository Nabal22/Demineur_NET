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
        Me.LayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LayoutPanel
        '
        Me.LayoutPanel.ColumnCount = 2
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LayoutPanel.Location = New System.Drawing.Point(305, 152)
        Me.LayoutPanel.Name = "LayoutPanel"
        Me.LayoutPanel.RowCount = 2
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LayoutPanel.Size = New System.Drawing.Size(141, 100)
        Me.LayoutPanel.TabIndex = 0
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
        Me.LeaveButton.Location = New System.Drawing.Point(600, 185)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(75, 23)
        Me.LeaveButton.TabIndex = 2
        Me.LeaveButton.Text = "Button1"
        Me.LeaveButton.UseVisualStyleBackColor = True
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.LayoutPanel)
        Me.Name = "Minesweeper"
        Me.Text = "Minesweeper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutPanel As TableLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NameLabel As Label
    Friend WithEvents LeaveButton As Button
End Class
