Public Class CGame

    Private Const BoardSize As Integer = 9
    Private Const SquareSize As Integer = 40
    Private BoardMaxPixels As Integer
    Private Board(BoardSize - 1, BoardSize - 1) As Byte

    Private Players(1) As String
    Private PlayerToMove As Integer


    Public Sub New()

        ' initialize the board to all zeros (empty)
        For y = 0 To BoardSize - 1
            For x = 0 To BoardSize - 1
                Board(x, y) = 0
            Next
        Next

        ' put some pieces on the board for testing
        'Board(3, 3) = 1
        'Board(3, 7) = 2

        BoardMaxPixels = (SquareSize * BoardSize) + 1
        'MsgBox(BoardMaxPixels)
        MainForm.BoardDisplay.Width = BoardMaxPixels
        MainForm.BoardDisplay.Height = BoardMaxPixels

        Players(0) = "Black"
        Players(1) = "Red"
        PlayerToMove = 0

        ' Set the label to show whose go it is
        MainForm.MoveLabel.Text = Players(PlayerToMove) & " to move"

        ' tell windows that the board needs to be displayed
        MainForm.BoardDisplay.Refresh()

    End Sub

    Public Sub DisplayBoard(g As Graphics)

        Dim Pen As New Pen(Color.Black, 1)
        Dim Max As Integer

        Max = (SquareSize * BoardSize)

        ' draw the lines
        For x = 0 To BoardSize
            For y = 0 To BoardSize
                ' draw horizontal line at y
                g.DrawLine(Pen, 0, y * SquareSize, Max, y * SquareSize)
                ' draw vertical line at x
                g.DrawLine(Pen, x * SquareSize, 0, x * SquareSize, Max)
            Next
        Next

        ' draw the pieces

        Dim Brushes(1) As SolidBrush

        Brushes(0) = New SolidBrush(Color.Black)
        Brushes(1) = New SolidBrush(Color.Red)

        For x = 0 To BoardSize - 1
            For y = 0 To BoardSize - 1
                If Board(x, y) <> 0 Then
                    ' the space is not blank
                    g.FillEllipse(Brushes(Board(x, y) - 1), x * SquareSize + 2, y * SquareSize + 2, SquareSize - 4, SquareSize - 4)

                End If
            Next
        Next

    End Sub

    ' This is called when the user cicks on the board
    ' the XPixel and YPixel say where the user clicked on the board

    Public Sub PlayerMove(XPixel As Integer, YPixel As Integer)

        Dim X As Integer
        Dim Y As Integer

        ' comvert XPixel and YPixel to positions on the noard
        ' this could be a bit smarter and ignore clicks that are
        ' too close to a line
        X = XPixel \ SquareSize
        Y = YPixel \ SquareSize

        ' add piece to the board
        ' need to know whose go it is
        Board(X, Y) = PlayerToMove + 1

        If PlayerToMove = 0 Then
            PlayerToMove = 1
        Else
            PlayerToMove = 0
        End If

        ' Set the label to show whose go it is
        MainForm.MoveLabel.Text = Players(PlayerToMove) & " to move"

        ' tell Windows that we have changed the board
        ' and it need to be redrawn
        MainForm.BoardDisplay.Refresh()

    End Sub





End Class
