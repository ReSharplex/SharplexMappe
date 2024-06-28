namespace LeetCode.Managers;

public static class PrinterManager
{
    public static void Print(IEnumerable<int> list)
    {
        foreach (var val in list)
        {
            Console.WriteLine(val);
        }
    }
}