namespace task4
{
    static class MyClass
    {
        public static T[] GetArray<T>(this Mylist<T> list)
        {
            T[] ts = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                ts[i] = list[i];
            }
            return ts;
        }
    }
}
