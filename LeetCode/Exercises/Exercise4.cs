using LeetCode.Managers;

namespace LeetCode.Exercises;

public class Exercise4() : Exercise(4)
{
    private double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> nums = new List<int>();
        nums.AddRange(nums1);
        nums.AddRange(nums2);

        nums.Sort();

        int length = nums.Count;

        if (length % 2 == 0)
        {
            int split = length / 2;
            return (nums[split] + nums[split - 1]) / 2.0d;
        }

        return nums[length / 2];
    }

    public override void Print()
    {
        base.Print();

        var res = FindMedianSortedArrays([1, 2], [3, 4]);
        PrinterManager.Print(res);
    }
}