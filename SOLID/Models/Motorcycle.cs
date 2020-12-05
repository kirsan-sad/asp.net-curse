using System;

public class Motorcycle : Vehicle, Iparked
{
    public Motorcycle(string model, string brand)
        :base(model, brand)
    {

    }

    public void Park()
    {
        Console.WriteLine("Мотоцикл припарковался");
    }
}
