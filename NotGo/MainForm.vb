﻿Public Class MainForm

    Private Game As CGame


    ' create these Event Subroutines using the property window
    ' make sure you have given things sensible names before
    ' you create any of these

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Game = New CGame

    End Sub


    Private Sub BoardDisplay_Paint(sender As Object, e As PaintEventArgs) Handles BoardDisplay.Paint

        ' pass the graphics object from the PaintEventArgs
        ' to the game DisplayBoard subroutine
        Game.DisplayBoard(e.Graphics)

    End Sub

    Private Sub BoardDisplay_MouseClick(sender As Object, e As MouseEventArgs) Handles BoardDisplay.MouseClick

        Game.PlayerMove(e.X, e.Y)

    End Sub
End Class
