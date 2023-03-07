// ReSharper disable once CheckNamespace => Into the same namespace as the official guard clauses, so it is always picked up.
namespace Ardalis.GuardClauses;

public static class CellGuard
{
    public static void Cell(this IGuardClause guardClause, string input, string parameterName)
    {
        if (string.IsNullOrEmpty(input))
            throw new ArgumentNullException(parameterName, "Is null or empty!");

        if (input.Length != 2)
            throw new ArgumentOutOfRangeException(parameterName, "Should have a length of 2!");
    }
}