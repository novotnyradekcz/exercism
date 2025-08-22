using System;

class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _distance = 0;
    private int _battery = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => this._battery < this._batteryDrain;

    public int DistanceDriven() => this._distance;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this._distance += this._speed;
            this._battery -= this._batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _distance;
    
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
            car.Drive();
        return car.DistanceDriven() >= this._distance;
    }
}
