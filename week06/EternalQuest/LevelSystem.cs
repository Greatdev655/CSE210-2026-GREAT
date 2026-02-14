using System;


public class LevelSystem
{
    public int GetLevel(int score) => score / 1000;

    public string GetRank(int level)
    {
        if (level < 5) return "Beginner";
        if (level < 10) return "Faith Warrior";
        if (level < 20) return "Covenant Guardian";
        return "Legendary Eternal Champion";
    }
}
