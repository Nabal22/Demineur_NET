Module Game

    Private tab(,) As Boolean
    Private drapeau(,) As Boolean
    Private dimTab As Integer
    Private sombre As Boolean = False

    Dim gameAsEnded As Boolean = False
    Sub Init(dimRowAndCollumn As Integer, nbMines As Integer)
        ReDim tab(dimRowAndCollumn, dimRowAndCollumn)
        ReDim drapeau(dimRowAndCollumn, dimRowAndCollumn)
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
        Next
    End Sub

    Function getSombre() As Boolean
        Return sombre
    End Function

    Function setSombre(b As Boolean) As Boolean
        sombre = b
    End Function

    Function partieGagne(mine As Integer) As Boolean
        Dim estMarque As Integer = 0
        For i As Integer = 0 To dimTab
            For j As Integer = 0 To dimTab
                If tab.GetValue(i, j) = True And drapeau.GetValue(i, j) = True Then
                    estMarque += 1
                End If
            Next
        Next

        If estMarque + 1 = mine Then
            Return True
        Else
            Return False
        End If

    End Function

    Function isADrapeau(row As Integer, col As Integer) As Boolean
        Return drapeau(row, col)
    End Function

    Function setDrapeau(row As Integer, col As Integer, drap As Boolean)
        drapeau.SetValue(drap, row, col)
    End Function

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
