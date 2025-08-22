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

    public List<int> PersonalTopThree() =>
        _scores.OrderByDescending(score => score).Take(3).ToList();
}