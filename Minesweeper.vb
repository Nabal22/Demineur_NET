﻿Public Class Minesweeper
    Dim temps As Integer = 64
    Dim tab(,) As Boolean
    Private Sub Minesweeper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        If MsgBox("Voulez-vous vraiment quitter la partie ?", MsgBoxStyle.YesNo, "Fermeture du programme") = MsgBoxResult.No Then
            e.Cancel = True
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
        Dim dimRowAndCollumn As Integer = 8, nbMines As Integer = 20
        Main(dimRowAndCollumn, nbMines)
        For i As Integer = 0 To dimRowAndCollumn - 1
            For j As Integer = 0 To dimRowAndCollumn - 1
                Dim newBtn As Button = New Button
                newBtn.Width = 25
                newBtn.Height = 25
                AddHandler newBtn.Click, AddressOf ClicOnBtn
                LayoutPanel.Controls.Add(newBtn, i, j)
            Next
        Next
    End Sub

    Private Sub ClicOnBtn(sender As Object, e As EventArgs)

        Dim row = LayoutPanel.GetRow(sender)
        Dim col = LayoutPanel.GetColumn(sender)
        If isAMine(row, col) = True Then
            sender.BackColor = Color.Red
        End If


        Console.WriteLine(mineAround(row, col))

        ''' reste plus qu'a mettre le code du démineur
        ''' 
    End Sub
End Class