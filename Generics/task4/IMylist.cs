namespace task4
{
    interface IMylist<T>
    {
        T this[int index] { get; }
        int IndexOf(T item);
    }
}
