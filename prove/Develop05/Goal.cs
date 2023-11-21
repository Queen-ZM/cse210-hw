using System;
using System.Collections.Generic;
using System.IO;

// Base class for goals
public abstract class Goal
{
    protected string description;
    protected bool isCompleted;

    public Goal(string description)
    {
        this.description = description;
        this.isCompleted = false;
    }

    public abstract void Display();

    public void MarkAsCompleted()
    {
        isCompleted = true;
        Console.WriteLine($"Goal '{description}' marked as completed.");
    }
}