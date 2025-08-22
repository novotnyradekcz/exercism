class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int passedMinutes)
    {
        return ExpectedMinutesInOven() - passedMinutes;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return 2 * layers;
    }

    public int ElapsedTimeInMinutes(int layers, int timeInOven)
    {
        return PreparationTimeInMinutes(layers) + timeInOven;
    }
}
