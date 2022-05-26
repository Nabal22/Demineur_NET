Imports System.Text

Public Class Joueur
    Private nom As String
    Private casesDécouvertes As New List(Of Integer)
    Private tempsEcoulé As New List(Of Integer)
    Private nombrePartieJouées As Integer
    Private cumulTemps As Integer

    Sub New(nom As String, casesDécouvertes As Integer, tempsEcoulé As Integer)
        Me.nom = nom
        Me.casesDécouvertes.Add(casesDécouvertes)
        Me.tempsEcoulé.Add(tempsEcoulé)
        Me.nombrePartieJouées = 1
        Me.cumulTemps = tempsEcoulé
    End Sub
    Public Function getNom() As String
        Return nom
    End Function

    Public Function toStringDebug() As String
        Dim tmp As StringBuilder = New StringBuilder()
        tmp.AppendLine(nom)
        For Each i As Integer In casesDécouvertes
            tmp.Append(i)
            tmp.Append(" ")
        Next
        tmp.AppendLine()
        For Each i As Integer In tempsEcoulé
            tmp.Append(i)
            tmp.Append(" ")
        Next
        tmp.AppendLine()
        tmp.AppendLine(nombrePartieJouées)
        tmp.AppendLine(cumulTemps)
        Return tmp.ToString()
    End Function

    Public Function toStringFileWriter() As String
        Dim tmp As StringBuilder = New StringBuilder()
        For i As Integer = 0 To casesDécouvertes.Count() - 1
            tmp.AppendLine(nom)
            tmp.AppendLine(casesDécouvertes(i))
            tmp.AppendLine(tempsEcoulé(i))
            tmp.AppendLine(nombrePartieJouées)
            tmp.AppendLine(cumulTemps)
        Next
        Return tmp.ToString()
    End Function
    Public Sub addGame(casesD As Integer, tempsE As Integer)
        casesDécouvertes.Add(casesD)
        tempsEcoulé.Add(tempsE)
        nombrePartieJouées += 1
        cumulTemps += tempsE
    End Sub

    Public Function getIdBestGame() As Integer
        Dim i As Integer = 0
        Dim tmp As Integer = 0
        For index As Integer = 0 To casesDécouvertes.Count() - 1
            If casesDécouvertes(index) > tmp Then
                tmp = casesDécouvertes(index)
                i = index
            End If
        Next
        Return i
    End Function

    Public Function getCasesDecouvertesByID(i As Integer) As Integer
        Return casesDécouvertes(i)
    End Function

    Public Function getTempsEcouléByID(i As Integer) As Integer
        Return tempsEcoulé(i)
    End Function

    Public Function getNbPartieJoué() As Integer
        Return nombrePartieJouées
    End Function

    Public Function getCumul() As Integer
        Return cumulTemps
    End Function
End Class
