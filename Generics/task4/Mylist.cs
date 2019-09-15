namespace task4
{
    class Mylist<T> : IMylist<T>
    {
        private T[] arrayT;
        public Mylist()
        {
            arrayT = new T[0];
        }
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
        public int Count
        {
            get { return arrayT.Length; }
        }
        public void Clear()
        {
            arrayT = new T[0];
        }

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
