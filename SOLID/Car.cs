using System;

public class Car : Vehicle, IMove, IParked
{
    //S: Single Responsibility Principle
    //Класс машин отвечает только за машины, для другого вида транспорта есть отдельный класс,
    //например для мотоцикла есть свой класс
    //Наследуются они от абстрактного класса "Транспорт"

    public string BodyType { get; set; }
    public Car(string model, string brand, string bodytype)
    {
        model = Model;
        brand = Brand;
        bodytype = BodyType;
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
