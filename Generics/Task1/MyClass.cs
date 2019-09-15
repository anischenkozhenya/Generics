using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MyClass<T> where T : new()
    {
        /// <summary>
        /// Создает объект типа T
        /// </summary>
        /// <returns>Возвращает ссылку на новый объект типа T</returns>
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}
