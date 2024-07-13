namespace LeetCode.Managers;

using static Console;

public static class PrinterManager
{
    public static void Print(this IEnumerable<int> list)
    {
        SetColor(ConsoleColor.Yellow);

        Write("Result: ");
        foreach (var val in list)
        {
            Write($"{val}, ");
        }
        
        ResetColor();
        ResetLine();
    }
    
    public static void Print<TSource>(TSource source)
    {
        SetColor(ConsoleColor.Yellow);

        Write("Result: ");
        Write($"{source}, ");
        
        ResetColor();
        ResetLine();
    }

    public static void NotFound()
    {
        WriteLine("Not Found");
    }

    public static void PrintId(int id)
    {
        SetColor();
        WriteLine($"ID: {id}");
    }
    
    private static void SetColor(ConsoleColor color = ConsoleColor.Green)
    {
        ForegroundColor = color;
    }
    
    private static void ResetColor()
    {
        ForegroundColor = ConsoleColor.White;
    }

    private static void ResetLine()
    {
        WriteLine();
    }
}