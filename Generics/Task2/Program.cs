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
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание массива
            var my = new Mylist<int>();
            //Заполнение массива
            my.Add(100);
            my.Add(200);
            my.Add(300);
            my.Add(400);
            my.Add(500);
            my.Add(600);
            //Выводит все элементы массива
            Console.WriteLine(my.ToString());
            //Количество элементов массива
            Console.WriteLine(my.Count.ToString());
            //Индекс элемента массива
            int c = my.IndexOf(400);
            Console.WriteLine(c == -1 ? "нет такого" : c.ToString());
            //Заменяет значение на новое
            my[2] = 100;
            //Выводит все элементы массива
            Console.WriteLine(my.ToString());
            //Очистка
            my.Clear();
            //Выводит все элементы массива
            Console.WriteLine(my.ToString());
            //Количество элементов массива
            Console.WriteLine(my.Count.ToString());
            Console.ReadKey();
        }
    }
}