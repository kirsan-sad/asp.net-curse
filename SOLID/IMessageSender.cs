using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID
{
    //D: Dependency Inversion Principle
    //Принцип зависимости на абстракциях, а не на конкретике. Через IoC контейнеры мы можем управлять зависимостями
    //менять на лету ту или иную зависимость при какихто условиях или в без условий.
    //в данном примере оправка сообщений идет через интерфей, а его реализуют нужные классы. А в контейнере мы вибираем
    //нужную имплементацию.
    public interface IMessageSender
    {
        string Send();
    }
}
