using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте класс MyDictionary<TKey, TValue>.Реализуйте в простейшем приближении возможность
//использования его экземпляра аналогично экземпляру класса Dictionary(Урок 6 пример 5).
//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
//добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
//свойство только для чтения для получения общего количества пар элементов.
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var my = new MyDictionary<int, string>();
            my.Add(100, "qwerty");
            my.Add(200, "qwerty1");
            my.Add(300, "qwerty2");
            Console.WriteLine(my.Count);
            Console.WriteLine(my.ToString());
            Console.WriteLine(my[1]);
            Console.WriteLine(my[2]);
            my.Clear();
            Console.WriteLine(my.Count);
            Console.WriteLine(my.ToString());
            Console.ReadKey();
        }
    }
}
