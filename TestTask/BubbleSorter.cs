namespace TestTask
{
    /// <summary>
    /// Класс, осуществляющий алгоритм методом пузырька
    /// </summary>
    internal class BubbleSorter: Sorter
    {
        internal BubbleSorter() { Console.WriteLine("Был выбран алгоритм сортировки методом пузырька\n"); }
        internal override void Sorting (ref List<sbyte> list)
        {
            sbyte temp;
            for (int i = 0; i <= list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
    }
}
