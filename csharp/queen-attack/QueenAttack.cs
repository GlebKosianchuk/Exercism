using System;

public class Queen
{
    public Queen(int row, int column)
    {
        const int boardSize = 8;

        if (row >= boardSize || row < 0 || column >= boardSize || column < 0)
            throw new ArgumentOutOfRangeException();

        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}
public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        var inOneColumnOrInOneRow = (white.Column == black.Column) || (white.Row == black.Row);
        var inOneDiagonal = Math.Abs(white.Column - black.Column) == Math.Abs(white.Row - black.Row);

        return inOneColumnOrInOneRow || inOneDiagonal;
    }
    public static Queen Create(int row, int column)
    {
        return new Queen(row, column);;
    }
}