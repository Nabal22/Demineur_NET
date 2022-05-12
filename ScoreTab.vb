Public Class ScoreTab
    Private Sub ScoreTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ScoreTab_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Accueil.Show()
        Me.Close()
    End Sub
End Class