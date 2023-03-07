namespace ChessTable;

public class SquareColor
{
    public static readonly SquareColor Dark = new("dark");
    public static readonly SquareColor Light = new("light");
    
    public string Class { get; }

    private SquareColor(string @class)
    {
        Class = @class;
    }

    public static SquareColor operator!(SquareColor color)
        => color == Dark ? Light : Dark;
}