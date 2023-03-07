// ReSharper disable once CheckNamespace => Into the same namespace as the official guard clauses, so it is always picked up.
namespace Ardalis.GuardClauses;

public static class RowGuard
{
    public static void Row(this IGuardClause guardClause, int input, string parameterName)
    {
        if (input < 1 || input > 8)
            throw new ArgumentOutOfRangeException(parameterName, "Should be in range 1-8!");
    }
    
    public static void Row(this IGuardClause guardClause, char input, string parameterName)
    {
        if (input < '1' || input > '8')
            throw new ArgumentOutOfRangeException(parameterName, "Should be in range 1-8!");
    }
}
