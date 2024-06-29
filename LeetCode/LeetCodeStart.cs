using LeetCode.Exercises;
using LeetCode.Managers;

namespace LeetCode;

class LeetCodeStart
{
    static void Main(string[] args)
    {
        LeetCodeManager manager = new LeetCodeManager();
        manager.RegisterExercise(new Exercise1());
        
        manager.Run();
    }
}