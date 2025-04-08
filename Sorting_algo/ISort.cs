using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_algo
{
    public interface ISort
    {
        T[] Sort<T>(T[] array);
    }
}
