using System;
using System.Collections.Generic;

public class Robot
{
    private static List<string> _namesList = new List<string>();
    private static Random random = new Random();
    private string _letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string _numbers = "0123456789";
    private string _name = string.Empty;

    public string Name
    {
        get
        {
            return _GetName();
        }
    }

    public void Reset()
    {
        _name = _GenerateRandomName();
    }

    private string _GetName()
    {
        if (_name == string.Empty)
        {
            _name = _GenerateRandomName();
        }
        return _name;
    }

    private string _GenerateRandomName()
    {
        bool isUnique = false;
        var name = new char[5];
        var robotName = string.Concat(name);

        while (!isUnique)
        {
            name[0] = _letters[random.Next(0, 26)];
            name[1] = _letters[random.Next(0, 26)];
            name[2] = _numbers[random.Next(0, 10)];
            name[3] = _numbers[random.Next(0, 10)];
            name[4] = _numbers[random.Next(0, 10)];

            robotName = string.Concat(name);

            isUnique = !_namesList.Contains(robotName);
        }

        _namesList.Add(robotName);
        return robotName;
    }
}