using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSystem.Utils
{
    public static class ArrayExtensionMethods
    {
        public static T[] SubArray<T>(this T[] data, int start, int end)
        {
            T[] result = new T[end - start];
            Array.Copy(data, start, result, 0, end - start);
            return result;
        }
    }
}
