using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    /// <summary>
    /// Абстрактный класс сортировщика
    /// </summary>
    internal abstract class Sorter
    {
        abstract internal void Sorting(ref List<sbyte> list);
    }
}
