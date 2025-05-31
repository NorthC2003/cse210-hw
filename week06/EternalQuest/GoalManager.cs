public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int goalIndex)
    {
        int points = _goals[goalIndex].RecordEvent();
        _score += points;
        Console.WriteLine($"You earned {points} points! Total: {_score}");
    }

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i]._name} - {_goals[i]._description}");
        }
        Console.WriteLine($"Current Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using StreamWriter output = new(filename);
        output.WriteLine(_score);
        foreach (var goal in _goals)
            output.WriteLine(goal.GetSaveData());
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            var parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { _isComplete = bool.Parse(parts[4]) });
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]));
                    cg._currentCount = int.Parse(parts[5]);
                    _goals.Add(cg);
                    break;
            }
        }
    }
