using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) => this.birdsPerDay = birdsPerDay;

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => this.birdsPerDay[6];

    public void IncrementTodaysCount() => this.birdsPerDay[6]++;

    public bool HasDayWithoutBirds()
    {
        foreach (int day in this.birdsPerDay)
        {
            if (day == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdCount = 0;
        for (int i = 0; i < numberOfDays; i++)
            birdCount += this.birdsPerDay[i];
        return birdCount;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int day in this.birdsPerDay)
        {
            if (day >= 5)
                busyDays++;
        }
        return busyDays;
    }
}
