using System;

public abstract class Vehicle
{
    public string Model { get; set; }
    public string Brand { get; set; }

    public virtual void Paint(string color)
    {
        Console.WriteLine($"Перекрасили в {color} цвет");
    }
}
