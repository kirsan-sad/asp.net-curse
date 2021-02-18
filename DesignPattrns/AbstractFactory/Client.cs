using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            //Создаем экземпляр конкретной фабрики
            Console.WriteLine("Start Java fabric");
            ClientMethod(new Java());

            Console.WriteLine("\nStart CSharp fabric");
            ClientMethod(new CSharp());
        }
        

        //Принимает экземпляр конкретной фабрики
        public void ClientMethod(IAbstractFactory factory)
        {
            var m1 = factory.CreatMethod1();
            var m2 = factory.CreatMethod2();

            Console.WriteLine(m1.DoSomeWork1());
            Console.WriteLine(m2.DoSomeWork2());
        }
    }
}
