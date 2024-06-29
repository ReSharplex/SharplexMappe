namespace LeetCode.Managers;

public class LeetCodeManager
{
    private List<Exercise> _exercises = new List<Exercise>();

    public void RegisterExercise(Exercise exercise)
    {
        _exercises.Add(exercise);
    }

    public void Run()
    {
        foreach (var ex in _exercises)
        {
            ex.Print();
        }
    }
    
    public void Run(int id)
    {
        var ex = _exercises.Find(e => e.Id == id);
        if (ex is not null) ex.Print();
    }

    public void RunLast()
    {
        var ex = _exercises.LastOrDefault();
        if (ex is not null)
        {
            ex.Print();
        }
        else
        {
            PrinterManager.NotFound();
        }
    }
}