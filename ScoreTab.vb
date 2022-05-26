Imports System.IO

Public Class ScoreTab
    Private tabNom As New List(Of String)
    Private tabMines As New List(Of String)
    Private tabTime As New List(Of String)
    Private tabNbGames As New List(Of String)
    Private tabCumul As New List(Of String)

    Public Sub ScoreTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To getNbPlayer() - 1
            Dim joueur As Joueur = getPlayerById(i)

            Dim nom As String = joueur.getNom()
            If Not ListBoxNom.Items.Contains(nom) Then
                ListBoxNom.Items.Add(nom)
                ComboBoxRechercheJoueur.Items.Add(nom)
            End If
            tabNom.Add(nom)

            Dim mines As String = joueur.getCasesDecouvertesByID(joueur.getIdBestGame)
            If Not ListBoxMines.Items.Contains(mines) Then
                ListBoxMines.Items.Add(mines)
            End If
            tabMines.Add(mines)
            Dim time As String = joueur.getTempsEcouléByID(joueur.getIdBestGame)
            If Not ListBoxTime.Items.Contains(time) Then
                ListBoxTime.Items.Add(time)
            End If
            tabTime.Add(time)
            Dim game As String = joueur.getNbPartieJoué
            If Not ListBoxNbGame.Items.Contains(game) Then
                ListBoxNbGame.Items.Add(game)
            End If
            tabNbGames.Add(game)
            Dim cumul As String = joueur.getCumul
            If Not ListBoxCumul.Items.Contains(cumul) Then
                ListBoxCumul.Items.Add(cumul)
            End If
            tabCumul.Add(cumul)
        Next
        Accueil.Show()
        ListBoxNom.Sorted = True
        ListBoxMines.Sorted = True
        ListBoxTime.Sorted = True
        ListBoxNbGame.Sorted = True
        ListBoxCumul.Sorted = True
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
            If sender.SelectedItem = tabCumul(i) Then
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

        If ListBoxCumul.Items.Contains(sender.SelectedItem) Then
            ListBoxCumul.SelectedItem = sender.SelectedItem
        Else
            ListBoxCumul.SelectedItem = tabCumul(indice)
        End If
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
            ListBoxCumul.SelectedItem = tabCumul(indice)
        Else
            MsgBox("Ce nom n'existe pas, veuillez résseayer !")
            ComboBoxRechercheJoueur.Text = ""
        End If

    End Sub

    Private Sub ChangeOrderButton_Click(sender As Object, e As EventArgs) Handles ChangeOrderButton.Click
        ListBoxNom.Sorted = False
        ListBoxMines.Sorted = False
        ListBoxTime.Sorted = False
        ListBoxNbGame.Sorted = False
        ListBoxCumul.Sorted = False

        Dim items1() As Object = ListBoxNom.Items.Cast(Of Object).Reverse.ToArray
        ListBoxNom.Items.Clear()
        ListBoxNom.Items.AddRange(items1)

        Dim items2() As Object = ListBoxMines.Items.Cast(Of Object).Reverse.ToArray
        ListBoxMines.Items.Clear()
        ListBoxMines.Items.AddRange(items2)

        Dim items3() As Object = ListBoxTime.Items.Cast(Of Object).Reverse.ToArray
        ListBoxTime.Items.Clear()
        ListBoxTime.Items.AddRange(items3)

        Dim items4() As Object = ListBoxNbGame.Items.Cast(Of Object).Reverse.ToArray
        ListBoxNbGame.Items.Clear()
        ListBoxNbGame.Items.AddRange(items4)

        Dim items5() As Object = ListBoxCumul.Items.Cast(Of Object).Reverse.ToArray
        ListBoxCumul.Items.Clear()
        ListBoxCumul.Items.AddRange(items5)
    End Sub
End Class