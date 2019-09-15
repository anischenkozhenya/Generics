using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
//для данного урока.Выведите на экран значения элементов массива, который вернул расширяющий
//метод GetArray().
namespace task4
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
            int[] mycopy = my.GetArray();
            Console.WriteLine(my.ToString());
            Console.WriteLine(my.Count.ToString());
            int c = my.IndexOf(400);
            Console.WriteLine(c == -1 ? "нет такого" : c.ToString());
            my[2] = 100;
            Console.WriteLine(my.ToString());
            for (int i = 0; i < mycopy.Length; i++)
            {
                Console.WriteLine("Скопированный[{0}]" + mycopy[i].ToString(), i.ToString());
            }
            my.Clear();
            Console.WriteLine(my.ToString());
            Console.WriteLine(my.Count.ToString());
            Console.ReadKey();
        }
    }
}
