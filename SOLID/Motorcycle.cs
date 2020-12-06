using System;

public class Motorcycle : Vehicle, IParked
{
    public bool Trunk { get; set; }
    public Motorcycle(string model, string brand, bool trunk, int wheels)
    {
        model = Model;
        brand = Brand;
        trunk = Trunk;
        wheels = Wheels;
    }

    public void Park()
    {
        Console.WriteLine("Мотоцикл припарковался");
    }
}
