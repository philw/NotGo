Public Class CGame

    Private Const BoardSize As Integer = 9
    Private Const SquareSize As Integer = 40
    Private BoardMaxPixels As Integer
    Private Board(BoardSize - 1, BoardSize - 1) As Char

    Public Sub New()

        ' initialize the board to all spaces (empty)
        For y = 0 To BoardSize - 1
            For x = 0 To BoardSize - 1
                Board(x, y) = " "
            Next
        Next

        BoardMaxPixels = (SquareSize * BoardSize) + 1
        MsgBox(BoardMaxPixels)
        MainForm.BoardDisplay.Width = BoardMaxPixels
        MainForm.BoardDisplay.Height = BoardMaxPixels

        ' tell windows that the board needs to be displayed
        MainForm.BoardDisplay.Refresh()

    End Sub

    Public Sub DisplayBoard(g As Graphics)

        Dim Pen As New Pen(Color.Black, 1)
        Dim Max As Integer

        Max = (SquareSize * BoardSize) - 1

        ' draw the lines
        For x = 0 To BoardSize
            For y = 0 To BoardSize
                ' draw horizontal line at y
                g.DrawLine(Pen, 0, y * SquareSize, Max, y * SquareSize)
                ' draw vertical line at x
                g.DrawLine(Pen, x * SquareSize, 0, x * SquareSize, Max)
            Next
        Next




    End Sub







End Class
