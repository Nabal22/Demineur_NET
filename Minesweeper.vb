Imports System.IO

Public Class Minesweeper
    Const cellHeightWidth = 25

    Private pause As Boolean
    Private estPause As Boolean = False
    Private timePause As Integer = 0

    Private temps As Integer = 64
    Private tab(,) As Boolean
    Private dimRowAndCollumn As Integer = 8, nbMines As Integer = 10

    Private Sub Minesweeper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        LayoutPanel.Visible = False
        If MsgBox("Voulez-vous vraiment quitter la partie ?", MsgBoxStyle.YesNo, "Fermeture du programme") = MsgBoxResult.No Then
            e.Cancel = True
            LayoutPanel.Visible = True
        Else
            setStateOfGame(True)
            Accueil.Show()
        End If
    End Sub

    Private Sub Minesweeper_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Timer1.Interval = 1000
        Timer1.Start()
        TimeLabel.Text = temps
        NameLabel.Text = Accueil.NomCbx.Text
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If estPause = False Then
            timePause += 1
        End If
        If temps >= 0 Then
            TimeLabel.Text = temps
            temps = temps - 1
        End If
        If temps = 0 Then
            setStateOfGame(True)
            MsgBox("temps écoulé")
            Me.Close()
        End If
    End Sub

    Private Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main(dimRowAndCollumn, nbMines)
        For i As Integer = 0 To dimRowAndCollumn - 1
            For j As Integer = 0 To dimRowAndCollumn - 1
                Dim newBtn As Button = New Button
                newBtn.Width = cellHeightWidth
                newBtn.Height = cellHeightWidth
                AddHandler newBtn.Click, AddressOf ClicOnBtn
                LayoutPanel.Controls.Add(newBtn, i, j)
            Next
        Next

        Dim file As New StreamReader("config.txt")
        file.ReadLine()
        pause = file.ReadLine()
        If pause = True Then
            PauseButton.Visible = True
        Else
            PauseButton.Visible = False
        End If
    End Sub

    Function getNbCaseDiscovered() As Integer
        Dim nbCaseDiscovered As Integer = 0
        For Each ctrl As Control In LayoutPanel.Controls
            If ctrl.Visible = False Then
                nbCaseDiscovered += 1
            End If
        Next
        Return nbCaseDiscovered
    End Function

    Private Sub ClicOnBtn(sender As Object, e As EventArgs)
        Dim index As Integer = LayoutPanel.Controls.GetChildIndex(sender)
        Dim topLeft, top, topRight, left, right, bottomLeft, bottom, bottomRight As Integer
        topLeft = index - dimRowAndCollumn - 1
        top = index - 1
        topRight = index + dimRowAndCollumn - 1
        left = index - dimRowAndCollumn
        right = index + dimRowAndCollumn
        bottomLeft = index - dimRowAndCollumn + 1
        bottom = index + 1
        bottomRight = index + dimRowAndCollumn + 1

        Dim row = LayoutPanel.GetRow(sender)
        Dim col = LayoutPanel.GetColumn(sender)
        If isAMine(row, col) = True Then
            sender.BackColor = Color.Red
            saveScore(NameLabel.Text, getNbCaseDiscovered(), TimeLabel.Text)
        ElseIf sender.Visible = True Then
            sender.visible = False
            Dim mineAroundClick As Integer = mineAround(row, col)
            If (mineAroundClick > 0) Then
                Dim newLabel As Label = New Label()
                newLabel.Text = mineAroundClick
                newLabel.Height = cellHeightWidth
                newLabel.Width = cellHeightWidth
                newLabel.AutoSize = False
                newLabel.TextAlign = ContentAlignment.MiddleCenter
                LayoutPanel.Controls.Add(newLabel, col, row)
            Else
                ''coin en haut a droite
                If (row = 0 And col = dimRowAndCollumn - 1) Then
                    ClicOnBtn(LayoutPanel.Controls.Item(left), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottomLeft), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottom), e)
                    ''coin case en haut à gauche
                ElseIf (row = 0 And col = 0) Then

                    ClicOnBtn(LayoutPanel.Controls.Item(right), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottomRight), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottom), e)
                    ''coin case en bas à droite
                ElseIf (row = dimRowAndCollumn - 1 And col = dimRowAndCollumn - 1) Then
                    ClicOnBtn(LayoutPanel.Controls.Item(left), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(topLeft), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(top), e)
                    ''coin case en bas à gauche
                ElseIf (row = dimRowAndCollumn - 1 And col = 0) Then
                    ClicOnBtn(LayoutPanel.Controls.Item(right), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(topRight), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(top), e)
                    ''pas de case en haut
                ElseIf (row = 0) Then
                    Console.WriteLine("haut")
                    ClicOnBtn(LayoutPanel.Controls.Item(left), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottomLeft), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottom), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(right), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottomRight), e)
                    ''pas de case en bas
                ElseIf (row = dimRowAndCollumn - 1) Then
                    ClicOnBtn(LayoutPanel.Controls.Item(left), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(topLeft), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(top), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(right), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(topRight), e)
                    ''pas de case à droite
                ElseIf (col = dimRowAndCollumn - 1) Then
                    ClicOnBtn(LayoutPanel.Controls.Item(left), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(topLeft), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(top), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottomLeft), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottom), e)
                    ''pas de case à gauche
                ElseIf (col = 0) Then
                    ClicOnBtn(LayoutPanel.Controls.Item(right), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(topRight), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(top), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottomRight), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottom), e)
                Else
                    ClicOnBtn(LayoutPanel.Controls.Item(right), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(left), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(topRight), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(topLeft), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(top), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottomRight), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottomLeft), e)
                    ClicOnBtn(LayoutPanel.Controls.Item(bottom), e)
                End If
            End If
        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        If estPause = True Then
            Timer1.Start()
            LayoutPanel.Visible = True
            estPause = False
        ElseIf estPause = False And timePause > 3 Then
            Timer1.Stop()
            LayoutPanel.Visible = False
            estPause = True
            timePause = 0
        End If

    End Sub
End Class