using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
//экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
//взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
//получения значения элемента по указанному индексу и свойство только для чтения для получения
//общего количества элементов. 
namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            var my = new Mylist<int>();
            my.Add(100);
            my.Add(200);
            my.Add(300);
            my.Add(400);
            my.Add(500);
            my.Add(600);
            Console.WriteLine(my.ToString());
            Console.WriteLine(my.Count.ToString());
            int c = my.IndexOf(400);
            Console.WriteLine(c == -1 ? "нет такого" : c.ToString());
            my[2] = 100;
            Console.WriteLine(my.ToString());
            my.Clear();
            Console.WriteLine(my.ToString());
            Console.WriteLine(my.Count.ToString());
            Console.ReadKey();
        }
    }
}