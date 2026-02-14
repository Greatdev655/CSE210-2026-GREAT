using System;


using System.IO;
using System.Linq;

public class FileService
{
    public void Save(string filename, QuestManager manager)
    {
        using StreamWriter writer = new(filename);
        writer.WriteLine(manager.Score);

        foreach (Goal goal in manager.GetGoals())
        {
            writer.WriteLine(goal.Serialize());
        }
    }

    public QuestManager Load(string filename)
    {
        var manager = new QuestManager();

        if (!File.Exists(filename))
            return manager;

        string[] lines = File.ReadAllLines(filename);

        manager.SetScore(int.Parse(lines[0]));

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");

            switch (parts[0])
            {
                case "Simple":
                    var simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4]))
                        simple.RecordEvent();
                    manager.AddGoal(simple);
                    break;

                case "Eternal":
                    manager.AddGoal(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;

                case "Checklist":
                    var checklist = new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6])
                    );

                    int current = int.Parse(parts[4]);
                    for (int i = 0; i < current; i++)
                        checklist.RecordEvent();

                    manager.AddGoal(checklist);
                    break;
            }
        }

        return manager;
    }
}
