Public Class Accueil

    Private Sub FormButton_Click(sender As Object, e As EventArgs) Handles FormButton.Click
        Me.Hide()
        ScoreTab.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Accueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.YesNo, "Fermeture du programme") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ValidButton_Click(sender As Object, e As EventArgs) Handles ValidButton.Click
        If NomCbx.Text.Length <= 2 Then
            MsgBox("Le nom de joueur doit au moins contenir 3 caractères", MsgBoxStyle.Critical)
        Else
            Me.Hide()
            Minesweeper.Activate()

            Minesweeper.Show()
        End If
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub SettingBtn_Click(sender As Object, e As EventArgs) Handles SettingBtn.Click
        Me.Hide()
        Setting.Show()
    End Sub
End Class
