Imports System.IO

Public Class Accueil

    Private Sub FormButton_Click(sender As Object, e As EventArgs) Handles FormButton.Click
        Me.Hide()
        ScoreTab.Show()
    End Sub

    Public Sub Load_ComboBox()
        Dim file As New StreamReader("score.txt")
        While (Not file.EndOfStream)
            Dim nom As String = file.ReadLine()
            If Not NomCbx.Items.Contains(nom) Then
                NomCbx.Items.Add(nom)
            End If
            file.ReadLine()
            file.ReadLine()
            file.ReadLine()
            file.ReadLine()
        End While
        file.Close()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitScore()
        Load_ComboBox()
    End Sub

    Private Sub Accueil_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        Load_ComboBox()
        If getSombre() = False Then
            Clair()
        Else
            Sombre()
        End If
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
        Information.Show()
        Me.Hide()
    End Sub

    Private Sub Sombre()
        Me.BackColor = SystemColors.ControlDarkDark
        Me.FormButton.BackColor = SystemColors.ControlDark
        Me.FormButton.ForeColor = Color.White
        Me.QuitButton.BackColor = SystemColors.ControlDark
        Me.QuitButton.ForeColor = Color.White
        Me.ValidButton.BackColor = SystemColors.ControlDark
        Me.ValidButton.ForeColor = Color.White
        Me.SettingBtn.BackColor = SystemColors.ControlDark
        Me.SettingBtn.ForeColor = Color.White
        Me.NomCbx.BackColor = SystemColors.ControlDark
        Me.NomCbx.ForeColor = Color.White
    End Sub

    Private Sub Clair()
        Me.BackColor = Color.Gainsboro
        Me.FormButton.BackColor = SystemColors.ControlLightLight
        Me.FormButton.ForeColor = Color.Black
        Me.QuitButton.BackColor = SystemColors.ControlLightLight
        Me.QuitButton.ForeColor = Color.Black
        Me.QuitButton.BackColor = SystemColors.ControlLightLight
        Me.QuitButton.ForeColor = Color.Black
        Me.ValidButton.BackColor = SystemColors.ControlLightLight
        Me.ValidButton.ForeColor = Color.Black
        Me.SettingBtn.BackColor = SystemColors.ControlLightLight
        Me.SettingBtn.ForeColor = Color.Black
        Me.NomCbx.BackColor = SystemColors.ControlLightLight
        Me.NomCbx.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If getSombre() = True Then
            Clair()
            setSombre(False)
        Else
            Sombre()
            setSombre(True)
        End If
    End Sub

    Private Sub Accueil_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If getSombre() = False Then
            Clair()
        Else
            Sombre()
        End If
    End Sub
End Class