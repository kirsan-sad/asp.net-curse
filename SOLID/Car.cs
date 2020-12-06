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

    //O: Open-Closed Principle
    //Принцип говорит, что классы должны быть открыты для расширения, но закрытвы дял модификаций
    //Через переопределение виртуальных методов или реализацию интерфейсов расширяем функционал класса не модифицируя
    //методы самого класса

    public void Park()
    {
        Console.WriteLine("Машина припарковалась");
    }

    public override void Paint(string color)
    {
        Console.WriteLine($"Вашу машину перекрасили в {color} цвет");
    }
}
