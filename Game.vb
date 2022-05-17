Module Game

    Dim tab(8, 8) As Boolean
    Sub Main()
        Console.WriteLine("test dans game" & Setting.getRowAndCollumnValue())

        Dim random As Random = New Random()
        Dim xTmp, yTmp As Integer
        '' on intialise le tableau
        For index As Integer = 0 To 9
            xTmp = random.Next(0, 8)
            yTmp = random.Next(0, 8)
            While isAMine(xTmp, yTmp)
                xTmp = random.Next(0, 8)
                yTmp = random.Next(0, 8)
            End While
            tab.SetValue(True, xTmp, yTmp)
        Next

        For i As Integer = 0 To 8
            Console.WriteLine("ligne")
            For j As Integer = 0 To 8
                Console.Write(tab(i, j))
            Next
        Next
    End Sub

    Function isAMine(row As Integer, col As Integer) As Boolean
        Return tab(row, col)
    End Function

    Function mineAround(row As Integer, col As Integer) As Integer
        Dim nbMinesAround As Integer = 0
        ''pas de case à gauche

        '' pas de case à 

    End Function
End Module
