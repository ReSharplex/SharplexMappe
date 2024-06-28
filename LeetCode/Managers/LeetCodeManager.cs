namespace LeetCode.Managers;

public class LeetCodeManager
{
    private List<Exercise> _exercises = new List<Exercise>();

    public void RegisterExercise(Exercise exercise)
    {
        _exercises.Add(exercise);
    }
}