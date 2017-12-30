Public Class CGame

    Private Const BoardSize As Integer = 9
    Private Board(BoardSize - 1, BoardSize - 1) As Char



    Public Sub New()

        ' initialize the board to all spaces (empty)
        For y = 0 To BoardSize - 1
            For x = 0 To BoardSize - 1
                Board(x, y) = " "
            Next
        Next


    End Sub




End Class
