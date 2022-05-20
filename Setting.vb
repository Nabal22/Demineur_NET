Imports System.IO

Public Class Setting
    Dim rowAndCollumn, timer, nbMines As Integer
    Private pause As Boolean


    Private Sub ScrollBar_Time_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollBar_Time.Scroll
        TimeValueLabel.Text = ScrollBar_Time.Value
    End Sub

    Function getRowAndCollumnValue() As Integer
        If rowAndCollumn = 6 Then
            Return 6
        ElseIf rowAndCollumn = 8 Then
            Return 8
        ElseIf rowAndCollumn = 10 Then
            Return 10
        End If
    End Function

    Private Sub ValidAndQuitButton_Click(sender As Object, e As EventArgs) Handles ValidAndQuitButton.Click
        Me.Close()
    End Sub

    Private Sub Setting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim file As New StreamWriter("config.txt")
        file.WriteLine(rowAndCollumn)
        file.WriteLine(pause)
        file.WriteLine(ScrollBar_MineValue.Value)
        file.WriteLine(ScrollBar_Time.Value)
        file.Close()
        Accueil.Show()
    End Sub

    Private Sub Radio10x10_CheckedChanged(sender As Object, e As EventArgs) Handles Radio10x10.CheckedChanged, Radio6x6.CheckedChanged, Radio8x8.CheckedChanged
        If Radio6x6.Checked = True Then
            rowAndCollumn = 6
        ElseIf Radio8x8.Checked = True Then
            rowAndCollumn = 8
        ElseIf Radio10x10.Checked = True Then
            rowAndCollumn = 10
        End If
    End Sub

    Private Sub PauseCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles PauseCheckbox.CheckedChanged
        If sender.checked = True Then
            pause = True
        Else
            pause = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ScrollBar_MineValue_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollBar_MineValue.Scroll
        MineValue.Text = ScrollBar_MineValue.Value
    End Sub

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim file As New StreamReader("config.txt")
        rowAndCollumn = file.ReadLine()
        Select Case rowAndCollumn
            Case 6
                Radio6x6.Checked = True
            Case 8
                Radio8x8.Checked = True
            Case 10
                Radio10x10.Checked = True
        End Select
        ScrollBar_MineValue.Minimum = 2
        ScrollBar_MineValue.Maximum = 19
        ScrollBar_MineValue.SmallChange = 1
        ScrollBar_MineValue.LargeChange = 4

        ScrollBar_Time.Minimum = 10
        ScrollBar_Time.Maximum = 184


        pause = file.ReadLine
        If pause = True Then
            PauseCheckbox.Checked = True
        Else
            PauseCheckbox.Checked = False
        End If
        ScrollBar_MineValue.Value = file.ReadLine
        ScrollBar_Time.Value = file.ReadLine
        file.Close()
        '' faire la partie timer

    End Sub
End Class