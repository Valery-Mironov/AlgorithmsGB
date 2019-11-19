/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3. 
 * 
 */

using System.Threading;

namespace Lesson_3_Lib
{
    /// <summary>
    /// Делегат для метода сортировки целочисленного массива
    /// </summary>
    /// <param name="arr">массив целых чисел</param>
    /// <param name="operatins">количество условных операций затраченных на сортировку</param>
    /// <returns></returns>
    public delegate int[] SortMethod(int[] arr, out int operatins);

    /// <summary>
    /// Класс тестирования различных методов сортировки целочисленных массивов
    /// </summary>
    public class TestSorts
    {
        /// <summary>
        /// Массив масивов небольшого размера
        /// </summary>
        public int[][] SmalArr { get; private set; }

        /// <summary>
        /// Массив масивов среднего размера
        /// </summary>
        public int[][] MedArr { get; private set; }

        /// <summary>
        /// Массив масивов большого размера
        /// </summary>
        public int[][] LargeArr { get; private set; }

        /// <summary>
        /// Количество условных операций пузырьковой сортировки
        /// </summary>
        public int BubbleOperat;

        /// <summary>
        /// Количество условных операций улучшенной пузырьковой сортировки
        /// </summary>
        public int OptBubbleOperat;

        /// <summary>
        /// Количество условных операций шейкерной сортировки
        /// </summary>
        public int ShakeOperat;

        /// <summary>
        /// Экземпляр класса сортировки
        /// </summary>
        ArrayTest arrayTest = new ArrayTest();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="numTests"> Количество тестов для расчета среднего показателя</param>
        public TestSorts(int numTests)
        {
            SmalArr = new int[numTests][]; 
            MedArr = new int[numTests][];
            LargeArr = new int[numTests][];

            InitArray(SmalArr, 100);
            InitArray(MedArr, 1000);
            InitArray(LargeArr, 10000);
        }

        /// <summary>
        /// Наполняет массив случайными целыми числами
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="length">длина массива</param>
        void InitArray(int[][] arr, int length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arrayTest.RandomArray(length,0,length);
                Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Производит сортировку каждого массива указанным методом
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sort">метод сортировка целочисленного массива</param>
        /// <returns></returns>
        public int TestSort(int[][] arr, SortMethod sort)
        {
            int medOper = 0;
            foreach (var item in arr)
            {
                int operations = 0;
                sort(item, out operations);
                medOper +=operations;
            }
            medOper /= arr.Length;
            return medOper;
        }

        /// <summary>
        /// Поочередно вызывает разные методы сортировки
        /// </summary>
        /// <param name="arr"></param>
        public void RunTestSorts(int[][] arr)
        {
            BubbleOperat = TestSort(arr, arrayTest.BubbleSort);
            OptBubbleOperat = TestSort(arr, arrayTest.OptimizedBubbleSort);
            ShakeOperat = TestSort(arr, arrayTest.ShakerSort);
        }
    }
}
