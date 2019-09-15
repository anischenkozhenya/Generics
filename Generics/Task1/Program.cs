using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте класс MyClass<T>, содержащий статический фабричный метод – T FactoryMethod(),
//который будет порождать экземпляры типа, указанного в качестве параметра типа(указателя места
//заполнения типом – Т). 
namespace Task1
{   
    class Program
    {
        static void Main(string[] args)
        {
            int my = MyClass<int>.FacrotyMethod();
            Random my1 = MyClass<Random>.FacrotyMethod();
            Console.WriteLine(my.GetType().ToString());
            Console.WriteLine(my1.GetType().ToString());
            Console.ReadKey();
        }
    }
}