Imports System.IO

Public Class Minesweeper
    Const cellHeightWidth = 25

    Private pause As Boolean
    Private estPause As Boolean = False
    Private timePause As Integer = 0

    Dim temps As Integer = 64
    Dim tab(,) As Boolean

    Private Sub Minesweeper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        LayoutPanel.Visible = False
        If MsgBox("Voulez-vous vraiment quitter la partie ?", MsgBoxStyle.YesNo, "Fermeture du programme") = MsgBoxResult.No Then
            e.Cancel = True
            LayoutPanel.Visible = True
        Else
            setStateOfGame(True)
            Accueil.Show()
        End If
    End Sub

    Private Sub Minesweeper_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Timer1.Interval = 1000
        Timer1.Start()
        TimeLabel.Text = temps
        NameLabel.Text = Accueil.NomCbx.Text
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If estPause = False Then
            timePause += 1
        End If
        If temps >= 0 Then
            TimeLabel.Text = temps
            temps = temps - 1
        End If
        If temps = 0 Then
            setStateOfGame(True)
            MsgBox("temps écoulé")
            Me.Close()
        End If
    End Sub

    Private Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dimRowAndCollumn As Integer = 8, nbMines As Integer = 15
        Main(dimRowAndCollumn, nbMines)
        For i As Integer = 0 To dimRowAndCollumn - 1
            For j As Integer = 0 To dimRowAndCollumn - 1
                Dim newBtn As Button = New Button
                newBtn.Width = cellHeightWidth
                newBtn.Height = cellHeightWidth
                AddHandler newBtn.Click, AddressOf ClicOnBtn
                LayoutPanel.Controls.Add(newBtn, i, j)
            Next
        Next

        Dim file As New StreamReader("config.txt")
        file.ReadLine()
        pause = file.ReadLine()
        If pause = True Then
            PauseButton.Visible = True
        Else
        PauseButton.Visible = False
        End If
    End Sub

    Private Sub ClicOnBtn(sender As Object, e As EventArgs)
        Dim row = LayoutPanel.GetRow(sender)
        Dim col = LayoutPanel.GetColumn(sender)
        If isAMine(row, col) = True Then
            sender.BackColor = Color.Red
        Else
            LayoutPanel.Controls.Remove(sender)
            Dim mineAroundClick As Integer = mineAround(row, col)
            If (mineAroundClick > 0) Then
                Dim newLabel As Label = New Label()
                newLabel.Text = mineAroundClick
                newLabel.Height = cellHeightWidth
                newLabel.Width = cellHeightWidth
                newLabel.AutoSize = False
                newLabel.TextAlign = ContentAlignment.MiddleCenter
                LayoutPanel.Controls.Add(newLabel, col, row)
            End If
        End If

    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        If estPause = True Then
            Timer1.Start()
            LayoutPanel.Visible = True
            estPause = False
        ElseIf estPause = False And timePause > 3 Then
            Timer1.Stop()
            LayoutPanel.Visible = False
            estPause = True
            timePause = 0
        End If

    End Sub
End Class