/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3. 
 * 
 * Задание 1
 * Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и неоптимизированной программы. 
 * Написать функции сортировки, которые возвращают количество операций.
 */

using System;

namespace Lesson_3_Lib
{
    public static class ArraySort
    {
        /// <summary>
        /// Количество условных операций сортировки пузырьком
        /// </summary>
        public static int bubbleOperat;

        /// <summary>
        /// Количество условных операций сортировки улучшенным пузырьком
        /// </summary>
        public static int optBubbleOperat;
        
        /// <summary>
        /// Возвращает отсортированный методом пузырька исходный массив
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <returns></returns>
        public static int BubbleSort(int[] arr)
        {
            int temp;
            int operations;
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
                return operations;
        }

        /// <summary>
        /// Возвращает отсортированный оптимизированным методом пузырька исходный массив
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <returns></returns>
        public static int OptimizedBubbleSort(int[] arr)
        {
            int temp;
            int operations;
            operations = 0;
            int left = 0;
            int right = arr.Length;

            while (right - left >= 0)
            {
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
                    if (arr[right] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[right];
                        arr[right] = temp;
                    }
                }
                left++;
            }
            return operations;
        }

        /// <summary>
        /// Возвращает массив случайных целых чисел
        /// </summary>
        /// <param name="length">длина массива</param>
        /// <returns></returns>
        public static int[] RandomArray(int length)
        {
            Random rnd = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
            }
            return arr;
        }

        /// <summary>
        /// Сортирует массив случайных целых чисел двумя способами
        /// </summary>
        public static void TestSort(int length)
        {
            int[] array = RandomArray(length);
            bubbleOperat = BubbleSort((int[])array.Clone());
            optBubbleOperat = OptimizedBubbleSort((int[])array.Clone());
        }
    }
}
