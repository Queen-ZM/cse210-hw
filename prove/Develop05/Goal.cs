// Base class for goals

using System;
using System.Collections.Generic;
using System.IO;
public abstract class Goal
{
    private string name;
    private bool isCompleted;
    private int points;

    public Goal(string name)
    {
        this.name = name;
        this.isCompleted = false;
        this.points = 0;
    }

    public string Name => name;

    public bool IsCompleted => isCompleted;

    public int Points => points;

    // Method to mark the goal as completed and update points
    public virtual void CompleteGoal()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            points += 10; //  points can be adjusted as needed
        }
    }

    // Method to display the goal status
    public virtual string DisplayStatus()
    {
        return isCompleted ? "[X]" : "[ ]";
    }

    // Method to save goal information to a string
    public virtual string SaveGoal()
    {
        return $"{GetType().Name},{name},{isCompleted},{points}";
    }

    // Method to load goal information from a string
    public virtual void LoadGoal(string data)
    {
        string[] parts = data.Split(',');
        name = parts[1];
        isCompleted = bool.Parse(parts[2]);
        points = int.Parse(parts[3]);
    }
}