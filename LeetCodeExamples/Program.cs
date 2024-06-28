using System.Text;

namespace LeetCodeExamples;

public class Program
{
    public static void Main(string[] args)
    {
        var res = IsMatch("aab", "c*a*b");
        Console.WriteLine(res);
    }

    public static bool IsMatch(string s, string p)
    {
        if (p == ".*") return true;

        bool isStar = false;
        char lastChar = ' ';
        
        int count = 0;
        while (count < s.Length)
        {
            if (count < p.Length)
            {
                var charOfP = p[count];
                var charOfS = s[count];

                if (charOfP == '*')
                {
                    isStar = true;
                    lastChar = count == 0 ? charOfS : s[count - 1];
                    count++;
                    continue;
                }
            
                if (charOfS != charOfP)
                {
                    return false;
                }
            }
            else
            {
                var charOfS = s[count];
                
                if (isStar)
                {
                    if (lastChar != charOfS)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            count++;
        }

        if (isStar) return true;
        return false;
    }
}