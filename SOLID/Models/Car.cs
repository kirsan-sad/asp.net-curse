using System;

public class Car : Vehicle, IMove, Iparked
{
    public Car(string model, string brand)
        : base(model, brand)
    {

    }

    public void Move()
    {
        Console.WriteLine("Машина едет");
    }

    public void Park()
    {
        Console.WriteLine("Машина припарковалась");
    }
}
