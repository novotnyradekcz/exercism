using System;

class RemoteControlCar
{
    private int _distance = 0;

    private int _battery = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distance} meters";

    public string BatteryDisplay()
    {
        if (_battery == 0)
            return "Battery empty";
        else
            return $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if (_distance < 2000)
            _distance += 20;
        if (_battery > 0)
            _battery -= 1;
    }
}
