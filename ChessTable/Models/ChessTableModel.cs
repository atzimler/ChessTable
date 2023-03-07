using Ardalis.GuardClauses;

namespace ChessTable.Models;

public class ChessTableModel
{
    public List<ChessRowModel> Rows { get; } = new();

    public string this[string cell]
    {
        get => InCell(cell).Content;
        set => InCell(cell).Content = value;
    } 
    
    public ChessTableModel()
    {
        var row = 8;
        var startingColor = SquareColor.Light;
        while (row > 0)
        {
            Rows.Add(new ChessRowModel(startingColor, row));
            startingColor = !startingColor;
            row--;
        }
    }

    private ChessSquareModel InCell(string cell)
    {
        Guard.Against.Cell(cell, nameof(cell));

        var column = cell[0];
        var row = cell[1];
        Guard.Against.Row(row, nameof(row));
        return InCell(column, row - '0');
    }

    private ChessSquareModel InCell(char column, int row)
    {
        Guard.Against.Row(row, nameof(row));
        return Rows[8 - row][column];
    }
}