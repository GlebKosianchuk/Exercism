using System;

public class Queen
{
    public Queen(int row, int column)
    {
        if (row >= 8 || row < 0 || (column >= 8 || column < 0))
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
        return (white.Column == black.Column) || (white.Row == black.Row) || Math.Abs(white.Column - black.Column) == Math.Abs(white.Row - black.Row);
    }
    public static Queen Create(int row, int column)
    {
        var q = new Queen(row, column);
        return q;
    }
}