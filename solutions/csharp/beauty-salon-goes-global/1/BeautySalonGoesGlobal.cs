using System;
using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        DateTime appointmentTime = DateTime.Parse(appointmentDateDescription);
        TimeZoneInfo timeZoneInfo = GetTimeZoneInfo(location);
        return TimeZoneInfo.ConvertTimeToUtc(appointmentTime, timeZoneInfo);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        TimeSpan alertInterval;
        switch (alertLevel)
        {
            case AlertLevel.Early:
                alertInterval = new TimeSpan(1, 0, 0, 0);
                break;
            case AlertLevel.Standard:
                alertInterval = new TimeSpan(1, 45, 0);
                break;
            case AlertLevel.Late:
                alertInterval = new TimeSpan(0, 30, 0);
                break;
            default:
                throw new ArgumentException("No such notification level.");
        }
        return appointment - alertInterval;
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        TimeZoneInfo timeZoneInfo = GetTimeZoneInfo(location);
        bool daylightSavingsNow = timeZoneInfo.IsDaylightSavingTime(dt);
        bool daylightSavingsLastWeek = timeZoneInfo.IsDaylightSavingTime(dt - new TimeSpan(7, 0, 0, 0));
        return daylightSavingsNow != daylightSavingsLastWeek;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo cultureInfo;
        switch (location)
        {
            case Location.NewYork:
                cultureInfo = CultureInfo.GetCultureInfo("en-US");
                break;
            case Location.London:
                cultureInfo = CultureInfo.GetCultureInfo("en-GB");
                break;
            case Location.Paris:
                cultureInfo = CultureInfo.GetCultureInfo("fr-FR");
                break;
            default:
                throw new ArgumentException("No salon branch in this city.");
        }
        bool validDate = DateTime.TryParse(dtStr, cultureInfo, DateTimeStyles.None, out DateTime dateTime);
        return validDate ? dateTime : new DateTime(1, 1, 1);
    }

    private static TimeZoneInfo GetTimeZoneInfo(Location location)
    {
        string timeZoneId;
        
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            switch (location)
            {
                case Location.NewYork:
                    timeZoneId = "Eastern Standard Time";
                    break;
                case Location.London:
                    timeZoneId = "GMT Standard Time";
                    break;
                case Location.Paris:
                    timeZoneId = "W. Europe Standard Time";
                    break;
                default:
                    throw new ArgumentException("No salon branch in this city.");
            }
        }
        else
        {
            switch (location)
            {
                case Location.NewYork:
                    timeZoneId = "America/New_York";
                    break;
                case Location.London:
                    timeZoneId = "Europe/London";
                    break;
                case Location.Paris:
                    timeZoneId = "Europe/Paris";
                    break;
                default:
                    throw new ArgumentException("No salon branch in this city.");
            }
        }
        return TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
    }
}
