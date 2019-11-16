/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3. 
 * 
 */

using System;

namespace Lesson_3_Lib
{
    public static class ArraySort
    {
        /// <summary>
        /// Возвращает отсортированный методом пузырька исходный массив
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <param name="operations">количество затраченных на сортировку условных операций</param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] arr, out int operations)
        {
            int temp;
            operations = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                operations++;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    operations++;
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                        operations++;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Возвращает отсортированный методом улучшенного пузырька исходный массив
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <param name="operations">количество затраченных на сортировку условных операций</param>
        /// <returns></returns>
        public static int[] OptimizedBubbleSort(int[] arr, out int operations)
        {
            int temp;
            operations = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                operations++;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    operations++;
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        operations++;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Возвращает массив случайных целых чисел
        /// </summary>
        /// <param name="length">длина массива</param>
        /// <returns></returns>
        public static int[] RandomArray(int length, int min =0, int max = 51)
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
        /// Возвращает отсортированный шейкерным методом исходный массив
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] ShakerSort(int[] arr, out int operations)
        {
            int temp;
            operations = 0;
            int left = 0;
            int right = arr.Length;

            while (right - left >= 0)
            {
                operations++;
                for (int i = left+1; i < right; i++)
                {
                    if (arr[left] > arr[i])
                    {
                        temp = arr[left];
                        arr[left] = arr[i];
                        arr[i] = temp;
                        operations++;
                    }
                }
                right--;
                for (int j = right; j > left; j--)
                {
                    operations++;
                    if (arr[right] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[right];
                        arr[right] = temp;
                        operations++;
                    }
                }
                left++;
            }
            return arr;
        }
    }
}
