using System;

class Program
{
    static void Main()
    {
        var manager = new QuestManager();
        var fileService = new FileService();
        var levelSystem = new LevelSystem();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine($"Score: {manager.Score}");
            Console.WriteLine($"Level: {levelSystem.GetLevel(manager.Score)}");
            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Select choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    manager.DisplayGoals();
                    Console.Write("Select goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoal(index);
                    break;

                case "4":
                    fileService.Save("goals.txt", manager);
                    Console.WriteLine("Saved.");
                    break;

                case "5":
                    manager = fileService.Load("goals.txt");
                    Console.WriteLine("Loaded.");
                    break;

                case "6":
                    running = false;
                    break;
            }
        }
    }

    static void CreateGoal(QuestManager manager)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;

            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;

            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }
}
