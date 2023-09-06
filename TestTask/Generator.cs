namespace TestTask
{
    /// <summary>
    /// Класс, осуществляеющий генерацию и сортировку чисел
    /// </summary>
    internal class Generator
    {
        private Random random = new();
        /// <summary>
        /// Функция, осуществляющая вероятность 50 на 50
        /// </summary>
        /// <param name="truePercentage"></param>
        /// <returns></returns>
        private bool NextBool(int truePercentage = 50)
        {
            return random.NextDouble() < truePercentage / 100.0;
        }
        /// <summary>
        /// Генерация чисел
        /// </summary>
        /// <returns>Список случайных чисел диапазонам от -100 до 100 в случайном количестве, но не меньше 20 штук и не более 100</returns>
        internal List<sbyte> NumbersGeneration()
        {
            List<sbyte> numbers = new();
            int quantity = random.Next(20, 100);
            for (int i = 0; i < quantity; i++)
            {
                numbers.Add((sbyte)random.Next(-100, 100));
            }
            return numbers;
        }
        /// <summary>
        /// Сортировка
        /// </summary>
        /// <param name="nums"></param>
        internal void Sorting(ref List<sbyte> nums)
        {
            Sorter sorter = NextBool() ? new BubbleSorter(): new QuickSorter();
            sorter.Sorting(ref nums);
        }
        /// <summary>
        /// Вывод списка на консоль
        /// </summary>
        /// <param name="nums"></param>
        internal void PrintNumbers(ref List<sbyte> nums)
        {
            byte i = 0;
            nums.ForEach(x => { Console.WriteLine("number {0}: {1}", i, x); i++; });
            Console.WriteLine("\n---------------------------------------------------\n");
        }
    }
}
