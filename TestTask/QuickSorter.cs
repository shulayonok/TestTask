namespace TestTask
{
    /// <summary>
    /// Класс, осуществляющий алгоритм быстрой сортировки
    /// </summary>
    internal class QuickSorter: Sorter
    {
        internal QuickSorter() { Console.WriteLine("Был выбран алгоритм быстрой сортировки\n"); }
        /// <summary>
        /// Функция, возвращающая индекс опорного элемента
        /// </summary>
        /// <param name="list"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns>Индекс опорного элемента</returns>
        private int Partition(ref List<sbyte> list, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (list[i] < list[maxIndex])
                {
                    pivot++;
                    (list[pivot], list[i]) = (list[i], list[pivot]);
                }
            }

            pivot++;
            (list[pivot], list[maxIndex]) = (list[maxIndex], list[pivot]);
            return pivot;
        }

        /// <summary>
        /// Быстрая сортировка
        /// </summary>
        /// <param name="list"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        private void QuickSort(ref List<sbyte> list, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return;
            }

            var pivotIndex = Partition(ref list, minIndex, maxIndex);
            QuickSort(ref list, minIndex, pivotIndex - 1);
            QuickSort(ref list, pivotIndex + 1, maxIndex);
        }

        internal override void Sorting(ref List<sbyte> list)
        {
            QuickSort(ref list, 0, list.Count - 1);
        }
    }
}
