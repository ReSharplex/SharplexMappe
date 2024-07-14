using LeetCode.Exercises;
using LeetCode.Managers;

namespace LeetCode;

class LeetCodeStart
{
    static void Main(string[] args)
    {
        LeetCodeManager manager = new LeetCodeManager();
        manager.RegisterExercise(new Exercise1());
        manager.RegisterExercise(new Exercise2());
        manager.RegisterExercise(new Exercise3());
        manager.RegisterExercise(new Exercise4());
        manager.RegisterExercise(new Exercise5());
        
        manager.RunLast();
    }
}