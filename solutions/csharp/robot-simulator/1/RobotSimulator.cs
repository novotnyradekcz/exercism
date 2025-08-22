using System;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    private Direction _direction { get; set; }
    private int _x { get; set; }
    private int _y { get; set; }
    
    public RobotSimulator(Direction direction, int x, int y)
    {
        _direction = direction;
        _x = x;
        _y = y;
    }

    public Direction Direction
    {
        get
        {
            return _direction;
        }
    }

    public int X
    {
        get
        {
            return _x;
        }
    }

    public int Y
    {
        get
        {
            return _y;
        }
    }

    public void Move(string instructions)
    {
        foreach (char instruction in instructions)
        {
            if (instruction == 'L')
            {
                _direction = (Direction)(((int)_direction + 3) % 4);
            }
            else if (instruction == 'R')
            {
                _direction = (Direction)(((int)_direction + 1) % 4);
            }
            else if (instruction == 'A')
            {
                switch (_direction)
                {
                    case Direction.North:
                        _y++;
                        break;
                    case Direction.East:
                        _x++;
                        break;
                    case Direction.South:
                        _y--;
                        break;
                    case Direction.West:
                        _x--;
                        break;
                }
            }
            else
            {
                throw new ArgumentException("Invalid instruction.");
            }
        }
    }
}