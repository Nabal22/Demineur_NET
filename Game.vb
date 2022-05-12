Module Game
    Dim tab(8, 8) As Boolean ''true si mine sinon false
    ''initialisaton du tableau
    Dim random As Random = New Random()

    Sub Main()
        Dim xTmp, yTmp As Integer
        '' on intialise le tableau
        For index As Integer = 0 To 10
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


    Function isAMine(x As Integer, y As Integer) As Boolean
        Return tab(x, y)
    End Function

End Module
