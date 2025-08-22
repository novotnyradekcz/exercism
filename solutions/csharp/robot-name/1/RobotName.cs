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
        string name = "";

        while (!isUnique)
        {
            var letter0 = _letters[random.Next(0, 26)].ToString();
            var letter1 = _letters[random.Next(0, 26)].ToString();
            var number0 = random.Next(0, 10).ToString();
            var number1 = random.Next(0, 10).ToString();
            var number2 = random.Next(0, 10).ToString();

            name = letter0 + letter1 + number0 + number1 + number2;

            isUnique = !_namesList.Contains(name);
        }

        _namesList.Add(name);
        return name;
    }
}