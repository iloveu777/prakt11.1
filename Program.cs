using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prakt11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 zadanie
            /*
            Person person = new Person("Tom", "Johnson", 29);
            person.Print();
            */
            //2 zadanie
            /*
            Address address = new Address(3300, "Приднестровье", "Тирасполь", "Магистральная", 5, 31);
            address.Print();
            */
            //3 задание
            Dog neapolitanMastiff = new Dog("Неаполитанский мастиф", "огромный", 3, "Серый");
            Dog maltese = new Dog("Мальтийская болонка", "маленькая", 2, "белая");
            Dog chowChow = new Dog("Чау-чау", "средняя", 4, "коричневая");
            Dog englandMastiff = new Dog("Английский мастиф", "самая большая порода в мире", 7, "Желтовато-коричневый");
            neapolitanMastiff.Run();
            maltese.Run();
            chowChow.Sit();
            englandMastiff.Eat();
            ReadKey();
        }
    }
}
