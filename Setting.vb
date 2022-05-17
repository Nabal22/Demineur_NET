Public Class Setting
    Dim rowAndCollumn, timer, nbMines As Integer

    Private Sub ScrollBar_Time_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollBar_Time.Scroll
        TimeValueLabel.Text = ScrollBar_Time.Value
    End Sub

    Function getRowAndCollumnValue() As Integer
        If Radio6x6.Checked Then
            rowAndCollumn = 6
            Return 6
        ElseIf Radio8x8.Checked Then
            rowAndCollumn = 8
            Return 8
        ElseIf Radio10x10.Checked Then
            rowAndCollumn = 10
            Return 10
        End If
    End Function

    Private Sub ValidAndQuitButton_Click(sender As Object, e As EventArgs) Handles ValidAndQuitButton.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub ScrollBar_MineValue_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollBar_MineValue.Scroll
        MineValue.Text = ScrollBar_MineValue.Value
    End Sub

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Console.WriteLine(rowAndCollumn)
        Select Case rowAndCollumn
            Case 6
                Radio6x6.Checked = True
            Case 8
                Radio8x8.Checked = True
            Case 10
                Radio10x10.Checked = True
        End Select

        '' faire la partie timer

    End Sub
End Class