using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Lib
{
    public class TestArray
    {
        public readonly int[] small;
        public readonly int[] medium;
        public readonly int[] large;

        public TestArray()
        {
            small = RandInit(1000);
            medium = RandInit(100000);
            large = RandInit(100000000);
        }

        /// <summary>
        /// Возвращает массив указанной длины со случайными целыми числами
        /// </summary>
        /// <param name="length">длина массива</param>
        /// <returns></returns>
        int[] RandInit(int length)
        {
            Random rnd = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
            }
            return arr;
        }
    }
}
