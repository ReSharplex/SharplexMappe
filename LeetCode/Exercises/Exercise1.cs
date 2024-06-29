using LeetCode.Managers;

namespace LeetCode.Exercises;

public class Exercise1() : Exercise(1)
{
    private int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            var first = nums[i];

            for (int l = nums.Length - 1; l > i; l--)
            {
                var second = nums[l];
                
                if (first + second == target) return [i, l];
            }
        }

        return [];
    }
    
    public override void Print()
    {
        base.Print();

        var a = TwoSum([3,2,3], 6);
        a.Print();
    }
}