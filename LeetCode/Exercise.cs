using LeetCode.Managers;

namespace LeetCode;

public abstract class Exercise(int id)
{
    public int Id = id;

    public virtual void Print()
    {
        PrinterManager.PrintId(id);
    }
}