Imports System.IO
Imports System.Text

Module Score
    Private tabJoueurs As New List(Of Joueur)

    Public Function getPlayerById(i As Integer) As Joueur
        Return tabJoueurs(i)
    End Function

    Public Function getNbPlayer() As Integer
        Return tabJoueurs.Count()
    End Function

    Private Function getPlayerByName(nom As String) As Joueur
        For Each j As Joueur In tabJoueurs
            If j.getNom() = nom Then
                Return j
            End If
        Next
    End Function

    Public Sub InitScore()
        Dim fileReader As New StreamReader("score.txt")
        While (Not fileReader.EndOfStream)
            Dim nom As String = fileReader.ReadLine()
            Dim caseD As String = fileReader.ReadLine()
            Dim tempsE As String = fileReader.ReadLine()
            If AlreadyExist(nom) Then
                getPlayerByName(nom).addGame(caseD, tempsE)
            Else
                tabJoueurs.Add(New Joueur(nom, caseD, tempsE))
            End If
            fileReader.ReadLine()
            fileReader.ReadLine()
        End While
        fileReader.Close()
    End Sub

    Private Function AlreadyExist(nom As String)
        For Each j As Joueur In tabJoueurs
            If j.getNom() = nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Sub saveScore(nom As String, nbCasesDiscovered As Integer, time As Integer)
        Dim fileReader As New StreamReader("score.txt")
        Dim stringTmp As New StringBuilder
        While Not fileReader.EndOfStream()
            stringTmp.AppendLine(fileReader.ReadLine())
        End While
        fileReader.Close()
        Dim fileWriter As New StreamWriter("score.txt")
        If AlreadyExist(nom) Then
            getPlayerByName(nom).addGame(nbCasesDiscovered, time)
        Else
            tabJoueurs.Add(New Joueur(nom, nbCasesDiscovered, time))
        End If
        For Each j As Joueur In tabJoueurs
            fileWriter.Write(j.toStringFileWriter())
        Next
        fileWriter.Close()
    End Sub

End Module
