using System;

public abstract class Vehicle
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int Wheels { get; set; }

    public virtual void Paint(string color)
    {
        Console.WriteLine($"Перекрасили в {color} цвет");
    }

    public virtual int WheelsCount()
    {
        return Wheels;
    }
}
