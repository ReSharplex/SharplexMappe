using LeetCode.Managers;

namespace LeetCode.Exercises;

public class Exercise3() : Exercise(3)
{
    public int LengthOfLongestSubstring(string s)
    {
        var charsOfText = s.ToArray();
        var tempChars = new List<char>();
        int maxLength = 0;
        int tmpLength = 0;
        int numForWhile = 0;

        int lengthOfCharsText = charsOfText.Length;
        while (numForWhile < lengthOfCharsText)
        {
            for (int i = numForWhile; i < lengthOfCharsText; i++)
            {
                var value = charsOfText[i];
                
                if (tempChars.Contains(value))
                {
                    if (tmpLength > maxLength)
                    {
                        maxLength = tmpLength;
                    }
                
                    tempChars.Clear();
                    tmpLength = 0;
                    break;
                }
                tempChars.Add(value);
                tmpLength++;
            }
            
            if (tmpLength > maxLength)
            {
                maxLength = tmpLength;
            }

            numForWhile++;
        }

        return maxLength;
    }
    
    public override void Print()
    {
        base.Print();
        
        var result = LengthOfLongestSubstring("dvdf");
        PrinterManager.Print(result);
    }
    
    /*
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
     */
}