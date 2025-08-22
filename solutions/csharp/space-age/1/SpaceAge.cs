using System;

public class SpaceAge
{
    private double _seconds;
    private double _mercury = 0.2408467 * 31557600;
    private double _venus = 0.61519726 * 31557600;
    private double _earth = 31557600.0;
    private double _mars = 1.8808158 * 31557600;
    private double _jupiter = 11.862615 * 31557600;
    private double _saturn = 29.447498 * 31557600;
    private double _uranus = 84.016846 * 31557600;
    private double _neptune = 164.79132 * 31557600;

    
    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth()
    {
        return _seconds / _earth;
    }

    public double OnMercury()
    {
        return _seconds / _mercury;
    }

    public double OnVenus()
    {
        return _seconds / _venus;
    }

    public double OnMars()
    {
        return _seconds / _mars;
    }

    public double OnJupiter()
    {
        return _seconds / _jupiter;
    }

    public double OnSaturn()
    {
        return _seconds / _saturn;
    }

    public double OnUranus()
    {
        return _seconds / _uranus;
    }

    public double OnNeptune()
    {
        return _seconds / _neptune;
    }
}