/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3. 
 * 
 */

using System;

namespace Lesson_3_Lib
{
    /// <summary>
    /// Класс с методами сортировки целочисленных массивов
    /// </summary>
    public class ArrayTest
    {
        /// <summary>
        /// Массив целых чисел
        /// </summary>
        public int[] arr;

        /// <summary>
        /// Возвращает отсортированный методом пузырька исходный массив
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <param name="operations">количество затраченных на сортировку условных операций</param>
        /// <returns></returns>
        public int[] BubbleSort(int[] arr, out int operations)
        {
            int temp;
            int[] array = (int[])arr.Clone();
            operations = 0;
            for (int i = 0; i < array.Length; i++)
            {
                operations++;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    operations++;
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                        operations++;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Возвращает отсортированный методом улучшенного пузырька исходный массив
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <param name="operations">количество затраченных на сортировку условных операций</param>
        /// <returns></returns>
        public int[] OptimizedBubbleSort(int[] arr, out int operations)
        {
            int temp;
            int[] array = (int[])arr.Clone();
            operations = 0;
            for (int i = 0; i < array.Length; i++)
            {
                operations++;
                for (int j = i + 1; j < array.Length; j++)
                {
                    operations++;
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        operations++;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Возвращает отсортированный шейкерным методом исходный массив
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] ShakerSort(int[] arr, out int operations)
        {
            int temp;
            int[] array = (int[])arr.Clone();
            operations = 0;
            int left = 0;
            int right = array.Length;

            while (right - left >= 0)
            {
                operations++;
                for (int i = left+1; i < right; i++)
                {
                    operations++;
                    if (array[left] > array[i])
                    {
                        temp = array[left];
                        array[left] = array[i];
                        array[i] = temp;
                        operations++;
                    }
                }
                right--;
                for (int j = right; j > left; j--)
                {
                    operations++;
                    if (array[right] < array[j])
                    {
                        temp = array[j];
                        array[j] = array[right];
                        array[right] = temp;
                        operations++;
                    }
                }
                left++;
            }
            return array;
        }

        /// <summary>
        /// Возвращает массив случайных целых чисел
        /// </summary>
        /// <param name="length">длина массива</param>
        /// <returns></returns>
        public int[] RandomArray(int length, int min =0, int max = 100)
        {
            Random rnd = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
            return arr;
        }

        /// <summary>
        /// Возвращает индекс искомого числа в массиве, или -1 при его отсутствии
        /// </summary>
        /// <param name="arr">отсортированный массив</param>
        /// <returns></returns>
        public int FindIndex(int[] arr, int find)
        {
            int minIndex = 0;
            int maxIndex = arr.Length;
            int findIndex = -1;
            Find(minIndex, maxIndex);

            void Find(int min, int max)
            {
                int index = min + (max - min)/2;
                if (index == max || index == min)
                {
                    return;
                }
                else if (arr[index] == find)
                {
                    findIndex = index;
                    return;
                }
                else if (arr[index] < find)
                {
                    minIndex = index;
                    Find(minIndex, maxIndex);
                }
                else if (arr[index] > find)
                {
                    maxIndex = index;
                    Find(minIndex, maxIndex);
                }
            }

            return findIndex;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="lengthArr">длина массива. По умолчанию = 100</param>
        public ArrayTest(int lengthArr = 100)
        {
            arr = RandomArray(lengthArr);
        }
    }
}
