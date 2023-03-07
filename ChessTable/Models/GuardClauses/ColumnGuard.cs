// ReSharper disable once CheckNamespace => Into the same namespace as the official guard clauses, so it is always picked up.
namespace Ardalis.GuardClauses;

public static class ColumnGuard
{
    public static void Column(this IGuardClause guardClause, char input, string parameterName)
    {
        if (input < 'a' || input > 'h')
            throw new ArgumentOutOfRangeException(parameterName, "Should be in range a-h!");
    }
}