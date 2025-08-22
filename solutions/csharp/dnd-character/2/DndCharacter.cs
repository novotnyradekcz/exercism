using System;
using System.Collections.Generic;
using System.Linq;

public class DndCharacter
{
    public DndCharacter()
    {
        Strength = Ability();
        Dexterity = Ability();
        Constitution = Ability();
        Intelligence = Ability();
        Wisdom = Ability();
        Charisma = Ability();
        Hitpoints = 10 + Modifier(Constitution);
    }

    private static Random _die = new Random();

    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    public static int Modifier(int score) => (int)Math.Floor((score - 10) / 2.0);

    public static int Ability() 
    {
        var rolls = new List<int>();
        rolls.Add(_die.Next(1, 7));
        rolls.Add(_die.Next(1, 7));
        rolls.Add(_die.Next(1, 7));
        rolls.Add(_die.Next(1, 7));
        
        rolls.Remove(rolls.Min());
        
        return rolls.Sum();
    }

    public static DndCharacter Generate() => new DndCharacter();
}
