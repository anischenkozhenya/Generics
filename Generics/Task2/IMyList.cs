namespace Task2
{
    interface IMylist<T>
    {
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns>Возвращает элемент типа T по индексу index</returns>
        T this[int index] { get; }
        /// <summary>
        /// Получить индекс элемента
        /// </summary>
        /// <param name="item">Элемент</param>
        /// <returns>Возвращает индекс элемента item</returns>
        int IndexOf(T item);
    }
}
