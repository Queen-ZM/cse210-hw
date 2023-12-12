using System;
using System.Collections.Generic;

class Activity
{
    private DateTime date;
    private int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public int GetMinutes()
    {
        return minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0; // Base class doesn't have a distance, overridden in derived classes
    }

    public virtual double GetSpeed()
    {
        return 0.0; // Base class doesn't have a speed, overridden in derived classes
    }

    public virtual double GetPace()
    {
        return 0.0; // Base class doesn't have a pace, overridden in derived classes
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} (Unknown Activity) - {minutes} min";
    }
}