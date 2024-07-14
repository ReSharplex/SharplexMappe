using LeetCode.Managers;

namespace LeetCode.Exercises;

public class Exercise5() : Exercise(5)
{
    private string LongestPalindrome(string s)
    {

        return string.Empty;
    }
    
    public override void Print()
    {
        base.Print();

        var res = LongestPalindrome("babad");
        PrinterManager.Print(res);
    }
}