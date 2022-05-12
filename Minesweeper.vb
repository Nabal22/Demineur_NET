Public Class Minesweeper

    Private Sub Minesweeper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Voulez-vous vraiment quitter la partie ?", MsgBoxStyle.YesNo, "Fermeture du programme") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class