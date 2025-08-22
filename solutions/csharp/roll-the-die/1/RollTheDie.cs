using System;

public class Player
{
    public int RollDie()
    {
        Random die = new Random();
        return die.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        Random spellStrength = new Random();
        return 100 * spellStrength.NextDouble();
    }
}
