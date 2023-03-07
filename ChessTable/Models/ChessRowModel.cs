using Ardalis.GuardClauses;

namespace ChessTable.Models;

public class ChessRowModel
{
    public List<ChessSquareModel> Squares { get; }
    public int RowNumber { get; }
    
    public ChessSquareModel this[char column] => InColumn(column);

    public ChessRowModel(SquareColor startingColor, int rowNumber)
    {
        RowNumber = rowNumber;
        Squares = new List<ChessSquareModel>();
        
        for (var column = 0; column < 8; ++column)
        {
            var square = new ChessSquareModel { Color = startingColor };
            Squares.Add(square);
            startingColor = !startingColor;
        }
    }

    private ChessSquareModel InColumn(char column)
    {
        Guard.Against.Column(column, nameof(column));
        return Squares[column - 'a'];
    }
}