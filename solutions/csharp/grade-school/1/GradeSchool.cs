using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private SortedDictionary<int, List<string>> _roster = new SortedDictionary<int, List<string>>();
    
    public bool Add(string student, int grade)
    {
        if (Roster().Contains(student))
        {
            return false;
        }
        else
        {
            if (!_roster.ContainsKey(grade))
            {
                _roster[grade] = new List<string>();
            }
            _roster[grade].Add(student);
            _roster[grade].Sort();
            return true;
        }
    }

    public IEnumerable<string> Roster()
    {
        
        return _roster.Values.SelectMany(grade => grade);
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (!_roster.ContainsKey(grade))
            return Array.Empty<string>();
        return _roster[grade];
    }
}