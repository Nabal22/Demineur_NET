Imports System.IO

Public Class Accueil

    Private Sub FormButton_Click(sender As Object, e As EventArgs) Handles FormButton.Click
        Me.Hide()
        ScoreTab.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScoreTab.ScoreTab_Load(sender, e)
        Dim file As New StreamReader("score.txt")
        While (Not file.EndOfStream)
            Dim nom As String = file.ReadLine()
            If Not NomCbx.Items.Contains(nom) Then
                NomCbx.Items.Add(nom)
            End If
            file.ReadLine()
            file.ReadLine()
            file.ReadLine()
        End While
        file.Close()
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
