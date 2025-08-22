using System;
using System.Globalization;

class WeighingMachine
{
    public int Precision { get; private set; }

    private double _weight;
    
    public double Weight
    {
        get { return this._weight; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Weight cannot be negative.");
            else
                this._weight = value;
        }
    }

    public string DisplayWeight
    {
        get
        {
            NumberFormatInfo format = new NumberFormatInfo() { NumberDecimalDigits = this.Precision };
            string displayWeight = (this.Weight - this.TareAdjustment).ToString("f", format);
            return $"{displayWeight} kg";
        }
    }

    public double TareAdjustment { get; set; } = 5.0;
    
    public WeighingMachine(int precision)
    {
        this.Precision = precision;
    }
}
