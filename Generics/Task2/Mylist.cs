namespace Task2
{
    class Mylist<T> : IMylist<T>
    {
        private T[] arrayT;
        public Mylist()
        {
            arrayT = new T[0];
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns>Возвращает элемент типа T по индексу index</returns>
        public T this[int index]
        {
            get
            {
                return arrayT[index];
            }
            set
            {
                arrayT[index] = value;
            }
        }
        /// <summary>
        /// Добавление элемента в массив
        /// </summary>
        /// <param name="newitem">Добавляемый элемент в массив типа T</param>
        public void Add(T newitem)
        {
            T[] newarrayT = new T[arrayT.Length + 1];
            for (int i = 0; i < arrayT.Length; i++)
            {
                newarrayT[i] = arrayT[i];
            }
            newarrayT[arrayT.Length] = newitem;
            arrayT = newarrayT;
        }
        /// <summary>
        /// Количество элементов в массиве
        /// </summary>
        public int Count
        {
            get { return arrayT.Length; }
        }
        /// <summary>
        /// Очистка массива
        /// </summary>
        public void Clear()
        {
            arrayT = new T[0];
        }
        /// <summary>
        /// Получить индекс элемента
        /// </summary>
        /// <param name="item">Элемент</param>
        /// <returns>Возвращает индекс элемента item</returns>
        public int IndexOf(T item)
        {
            for (var i = 0; i < Count; i++)
            {
                if ((int)(object)arrayT[i] == (int)(object)(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            string str = null;
            for (var i = 0; i < arrayT.Length; i++)
            {
                str += " " + arrayT[i].ToString();
            }
            return str;
        }
    }
}
