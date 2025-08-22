public class Telemetry
{
    private RemoteControlCar car;
    
    public Telemetry(RemoteControlCar car)
    {
        this.car = car;
    }

    public void Calibrate()
    {
    }

    public bool SelfTest() => true;

    public void ShowSponsor(string sponsorName)
    {
        car.SetSponsor(sponsorName);
    }

    public void SetSpeed(decimal amount, string unitsString)
    {
        car.SetSpeed(amount, unitsString);
    }
}

public class RemoteControlCar
{
    public string CurrentSponsor
    {
        get; private set;
    }

    private Speed currentSpeed;

    public Telemetry Telemetry
    {
        get; set;
    }

    public RemoteControlCar()
    {
        Telemetry = new(this);
    }

    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    internal void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;
    }

    internal void SetSpeed(decimal amount, string unitsString)
    {
        SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
        
        if (unitsString == "cps")
        {
            speedUnits = SpeedUnits.CentimetersPerSecond;
        }
    
        SetSpeed(new Speed(amount, speedUnits));
    }

    private void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }

    
}

public enum SpeedUnits
{
    MetersPerSecond,
    CentimetersPerSecond
}

public struct Speed
{
    public decimal Amount
    {
        get;
    }

    public SpeedUnits SpeedUnits
    {
        get;
    }

    public Speed(decimal amount, SpeedUnits speedUnits)
    {
        Amount = amount;
        SpeedUnits = speedUnits;
    }

    public override string ToString()
    {
        string unitsString = "meters per second";
        
        if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
        {
            unitsString = "centimeters per second";
        }
    
        return $"{Amount} {unitsString}";
    }
}