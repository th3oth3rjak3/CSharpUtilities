namespace Utilities;

public static class Generic
{
    /// <summary>
    /// Prints a string to the console.
    /// </summary>
    /// <param name="s">The string to print.</param>
    public static void Print<T>(T val) => Console.WriteLine(val);
}