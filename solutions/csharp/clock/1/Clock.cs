// using System;

// public class Clock
// {
//     public Clock(int hours, int minutes)
//     {
//         throw new NotImplementedException("You need to implement this function.");
//     }

//     public Clock Add(int minutesToAdd)
//     {
//         throw new NotImplementedException("You need to implement this function.");
//     }

//     public Clock Subtract(int minutesToSubtract)
//     {
//         throw new NotImplementedException("You need to implement this function.");
//     }
// }

using System;

public class Clock
{
    private int totalMinutes;

    public Clock(int hours, int minutes)
    {
        totalMinutes = (hours * 60 + minutes) % (24 * 60);
        if (totalMinutes < 0)
        {
            totalMinutes += 24 * 60;
        }
    }

    public Clock Add(int minutesToAdd) => new Clock(0, totalMinutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(0, totalMinutes - minutesToSubtract);

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Clock other = (Clock)obj;
        return this.totalMinutes == other.totalMinutes;
    }

    public override int GetHashCode() => this.GetHashCode();

    public override string ToString()
        => $"{(totalMinutes / 60).ToString("D2")}:{(totalMinutes % 60).ToString("D2")}";
}
