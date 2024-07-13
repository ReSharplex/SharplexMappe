using LeetCode.Managers;

namespace LeetCode.Exercises;

public class Exercise4() : Exercise(4)
{
    private double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {

        return 0;
    }
    
    public override void Print()
    {
        base.Print();

        var res = FindMedianSortedArrays([1, 3], [2]);
        PrinterManager.Print(res);
    }
}