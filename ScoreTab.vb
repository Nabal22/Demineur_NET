Imports System.IO

Public Class ScoreTab
    Private tabNom As New List(Of String)
    Private tabMines As New List(Of String)
    Private tabTime As New List(Of String)
    Private tabNbGames As New List(Of String)

    Public Sub ScoreTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As New StreamReader("score.txt")
        While (Not file.EndOfStream)
            Dim nom As String = file.ReadLine()
            If Not ListBoxNom.Items.Contains(nom) Then
                ListBoxNom.Items.Add(nom)
                ComboBoxRechercheJoueur.Items.Add(nom)
            End If
            tabNom.Add(nom)
            Dim mines As String = file.ReadLine()
            If Not ListBoxMines.Items.Contains(mines) Then
                ListBoxMines.Items.Add(mines)
            End If
            tabMines.Add(mines)
            Dim time As String = file.ReadLine()
            If Not ListBoxTime.Items.Contains(time) Then
                ListBoxTime.Items.Add(time)
            End If
            tabTime.Add(time)
            Dim game As String = file.ReadLine()
            If Not ListBoxNbGame.Items.Contains(game) Then
                ListBoxNbGame.Items.Add(game)
            End If
            tabNbGames.Add(game)
        End While
        file.Close()
        Accueil.Show()
        ListBoxNom.Sorted = True
        ListBoxMines.Sorted = True
        ListBoxTime.Sorted = True
        ListBoxNbGame.Sorted = True
    End Sub

    Private Sub SelectIndexChange(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged, ListBoxMines.SelectedIndexChanged, ListBoxTime.SelectedIndexChanged
        Dim indice As Integer = 0

        For i As Integer = 0 To tabNom.Count - 1
            If sender.SelectedItem = tabNom(i) Then
                indice = i
            End If
            If sender.SelectedItem = tabMines(i) Then
                indice = i
            End If
            If sender.SelectedItem = tabTime(i) Then
                indice = i
            End If
            If sender.SelectedItem = tabNbGames(i) Then
                indice = i
            End If
        Next

        If ListBoxNom.Items.Contains(sender.SelectedItem) Then
            ListBoxNom.SelectedItem = sender.SelectedItem
        Else
            ListBoxNom.SelectedItem = tabNom(indice)
        End If

        If ListBoxMines.Items.Contains(sender.SelectedItem) Then
            ListBoxMines.SelectedItem = sender.SelectedItem
        Else
            ListBoxMines.SelectedItem = tabMines(indice)
        End If

        If ListBoxTime.Items.Contains(sender.SelectedItem) Then
            ListBoxTime.SelectedItem = sender.SelectedItem
        Else
            ListBoxTime.SelectedItem = tabTime(indice)
        End If

        If ListBoxNbGame.Items.Contains(sender.SelectedItem) Then
            ListBoxNbGame.SelectedItem = sender.SelectedItem
        Else
            ListBoxNbGame.SelectedItem = tabNbGames(indice)
        End If
    End Sub

    Private Sub ScoreTab_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Accueil.Show()
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim nom = ComboBoxRechercheJoueur.Text

        Dim indice As Integer = 0
        Dim nomInListBox As Boolean = False
        For i As Integer = 0 To tabNom.Count - 1
            If nom = tabNom(i) Then
                indice = i
                nomInListBox = True
            End If
        Next

        If nomInListBox Then
            ListBoxNom.SelectedItem = nom
            ListBoxMines.SelectedItem = tabMines(indice)
            ListBoxTime.SelectedItem = tabTime(indice)
            ListBoxNbGame.SelectedItem = tabNbGames(indice)
        Else
            MsgBox("Ce nom n'existe pas, veuillez résseayer !")
            ComboBoxRechercheJoueur.Text = ""
        End If

    End Sub

    Public Function getNbPartie(nomJoueur As String) As Integer
        Dim nbPartie As Integer = 1
        For index As Integer = 0 To tabNom.Count - 1
            If nomJoueur = tabNom(index) Then
                nbPartie += 1
            End If
        Next
        Return nbPartie
    End Function

End Class