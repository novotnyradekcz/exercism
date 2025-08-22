using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _scores = null;
    
    public HighScores(List<int> list)
    {
        _scores = list;
    }

    public List<int> Scores() => _scores;

    public int Latest() => _scores.Last();

    public int PersonalBest() => _scores.Max();

    public List<int> PersonalTopThree()
    {
        var sortedScores = new List<int>(_scores);
        sortedScores.Sort();
        sortedScores.Reverse();
        return new List<int>(sortedScores.Take(3));
    }
}