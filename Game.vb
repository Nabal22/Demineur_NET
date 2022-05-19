Module Game

    Dim tab(,) As Boolean
    Dim dimTab As Integer

    Dim gameAsEnded As Boolean = False
    Sub Main(dimRowAndCollumn As Integer, nbMines As Integer)
        ReDim tab(dimRowAndCollumn, dimRowAndCollumn)
        dimTab = dimRowAndCollumn
        gameAsEnded = False

        Dim random As Random = New Random()
        Dim xTmp, yTmp As Integer
        '' on intialise le tableau
        For index As Integer = 0 To nbMines - 1
            xTmp = random.Next(0, dimRowAndCollumn)
            yTmp = random.Next(0, dimRowAndCollumn)
            While isAMine(xTmp, yTmp)
                xTmp = random.Next(0, dimRowAndCollumn)
                yTmp = random.Next(0, dimRowAndCollumn)
            End While
            tab.SetValue(True, xTmp, yTmp)
            Console.WriteLine(xTmp & " - " & yTmp)
        Next


    End Sub

    Function getStateOfGame() As Boolean
        Return gameAsEnded
    End Function

    Sub setStateOfGame(state As Boolean)
        gameAsEnded = state
    End Sub

    Function isAMine(row As Integer, col As Integer) As Boolean
        Return tab(row, col)
    End Function

    Function mineAround(row As Integer, col As Integer) As Integer
        Dim nbMinesAround As Integer = 0
        '' case en haut à gauche
        If (row = 0 And col = 0) Then
            If isAMine(row, col + 1) Then
                nbMinesAround += 1
            End If
            If isAMine(row + 1, col) Then
                nbMinesAround += 1
            End If
            If isAMine(row + 1, col + 1) Then
                nbMinesAround += 1
            End If
            Return nbMinesAround
        End If
        '' case en haut à droite
        If (row = 0 And col = dimTab - 1) Then
            If isAMine(row, col - 1) Then
                nbMinesAround += 1
            End If
            If isAMine(row + 1, col) Then
                nbMinesAround += 1
            End If
            If isAMine(row + 1, col - 1) Then
                nbMinesAround += 1
            End If
            Return nbMinesAround
        End If
        '' case en bas à droite
        If (row = dimTab - 1 And col = dimTab - 1) Then
            If isAMine(row, col - 1) Then
                nbMinesAround += 1
            End If
            If isAMine(row - 1, col) Then
                nbMinesAround += 1
            End If
            If isAMine(row - 1, col - 1) Then
                nbMinesAround += 1
            End If
            Return nbMinesAround
        End If
        '' case en bas à gauche
        If (row = dimTab - 1 And col = 0) Then
            If isAMine(row, col + 1) Then
                nbMinesAround += 1
            End If
            If isAMine(row - 1, col) Then
                nbMinesAround += 1
            End If
            If isAMine(row - 1, col + 1) Then
                nbMinesAround += 1
            End If
            Return nbMinesAround
        End If
        ''pas de case en haut
        If (row = 0) Then
            ''cas à droite
            If isAMine(row, col + 1) Then
                nbMinesAround += 1
            End If
            '' case à gauche
            If isAMine(row, col - 1) Then
                nbMinesAround += 1
            End If
            'diagonale bas droite
            If isAMine(row + 1, col + 1) Then
                nbMinesAround += 1
            End If
            ''diagonale bas gauche
            If isAMine(row + 1, col - 1) Then
                nbMinesAround += 1
            End If
            ''case en bas
            If isAMine(row + 1, col) Then
                nbMinesAround += 1
            End If
            Return nbMinesAround
        End If
        ''pas de case en bas
        If (row = dimTab - 1) Then
            ''case en haut
            If isAMine(row - 1, col) Then
                nbMinesAround += 1
            End If
            ''case en bas
            If isAMine(row + 1, col) Then
                nbMinesAround += 1
            End If
            ''cas à droite
            If isAMine(row, col + 1) Then
                nbMinesAround += 1
            End If
            ''diagonale haut gauche
            If isAMine(row - 1, col - 1) Then
                nbMinesAround += 1
            End If
            'diagonale haut droite
            If isAMine(row - 1, col + 1) Then
                nbMinesAround += 1
            End If
            '' case à gauche
            If isAMine(row, col - 1) Then
                nbMinesAround += 1
            End If
            Return nbMinesAround
        End If
        ''pas de case à gauche
        If (col = 0) Then
            ''case en haut
            If isAMine(row - 1, col) Then
                nbMinesAround += 1
            End If
            ''case en bas
            If isAMine(row + 1, col) Then
                nbMinesAround += 1
            End If
            ''cas à droite
            If isAMine(row, col + 1) Then
                nbMinesAround += 1
            End If
            'diagonale haut droite
            If isAMine(row - 1, col + 1) Then
                nbMinesAround += 1
            End If
            'diagonale bas droite
            If isAMine(row + 1, col + 1) Then
                nbMinesAround += 1
            End If
            Return nbMinesAround
        End If
        ''pas de case à droite
        If (col = dimTab - 1) Then
            ''case en haut
            If isAMine(row - 1, col) Then
                nbMinesAround += 1
            End If
            ''case en bas
            If isAMine(row + 1, col) Then
                nbMinesAround += 1
            End If
            '' case à gauche
            If isAMine(row, col - 1) Then
                nbMinesAround += 1
            End If
            ''diagonale haut gauche
            If isAMine(row - 1, col - 1) Then
                nbMinesAround += 1
            End If
            ''diagonale bas gauche
            If isAMine(row + 1, col - 1) Then
                nbMinesAround += 1
            End If
            Return nbMinesAround
        End If

        ''cas général
        ''case en haut
        If isAMine(row - 1, col) Then
            nbMinesAround += 1
        End If
        ''case en bas
        If isAMine(row + 1, col) Then
            nbMinesAround += 1
        End If
        ''cas à droite
        If isAMine(row, col + 1) Then
            nbMinesAround += 1
        End If
        '' case à gauche
        If isAMine(row, col - 1) Then
            nbMinesAround += 1
        End If
        ''diagonale haut gauche
        If isAMine(row - 1, col - 1) Then
            nbMinesAround += 1
        End If
        ''diagonale haut droite
        If isAMine(row - 1, col + 1) Then
            nbMinesAround += 1
        End If
        ''diagonale bas gauche
        If isAMine(row + 1, col - 1) Then
            nbMinesAround += 1
        End If
        'diagonale bas droite
        If isAMine(row + 1, col + 1) Then
            nbMinesAround += 1
        End If
        Return nbMinesAround
    End Function

End Module
