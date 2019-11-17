/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3. 
 * 
 * Задание 1
 * Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и неоптимизированной программы. 
 * Написать функции сортировки, которые возвращают количество операций.
 * 
 * Задание 2*
 * Реализовать шейкерную сортировку
 * 
 * Задание 3
 * Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.
 * Функция возвращает индекс найденного элемента или –1, если элемент не найден.
 * 
 * Задание 4*
 * Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.
 */

using System;

namespace Lesson_3_Lib
{
    /// <summary>
    /// Консольный пользовательский интерфейс
    /// </summary>
    public class Tasks
    {
        #region Messages
        static string msg1 = "Задание 1\nПопробовать оптимизировать пузырьковую сортировку.\n" +
            "Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.\n" +
            "Написать функции сортировки, которые возвращают количество операций.";

        static string msg2 = "Задание 2*\nРаелизовать шейкерную сортировку";

        static string msg3 = "Задание 3\nРеализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.\n" +
            "Функция возвращает индекс найденного элемента или –1, если элемент не найден.";

        static string msg4 = "4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.\n";
        #endregion

        /// <summary>
        /// Количество тестов сортировки для расчета среднего значения
        /// </summary>
        int testArrLength;

        /// <summary>
        /// Экземпляр класса сортировки
        /// </summary>
        ArrayTest arrayTest;

        /// <summary>
        /// Экземпляр класса тестирования
        /// </summary>
        TestSorts test;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="numTests">количество тестов</param>
        /// <param name="testArrLength">длина массива</param>
        public Tasks(int numTests, int testArrLength)
        {
            this.testArrLength = testArrLength;
            this.arrayTest = new ArrayTest();
            this.test = new TestSorts(numTests);
        }

        /// <summary>
        /// Демонстрация решения задачи 1
        /// </summary>
        public void Task1()
        {

            ConsoleIO_Lib.ConsolIO.Greeting(msg1);

            PrintArr(arrayTest.RandomArray(testArrLength), "\nИсходный массив:");
            
            PrintArr(arrayTest.BubbleSort((int[])arrayTest.arr.Clone(), out test.BubbleOperat), "\nСортировка пузырьком:");
            Console.WriteLine($"\nПроизведено {test.BubbleOperat} операций");

            PrintArr(arrayTest.OptimizedBubbleSort((int[])arrayTest.arr.Clone(), out test.OptBubbleOperat), "\nСортировка улучшеным пузырьком:");
            Console.WriteLine($"\nПроизведено {test.OptBubbleOperat} операций\n");

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        /// <summary>
        /// Демонстрация решения задачи 2
        /// </summary>
        public void Task2()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(msg2);

            PrintArr(arrayTest.RandomArray(testArrLength), "Исходный массив");
            
            PrintArr(arrayTest.ShakerSort((int[])arrayTest.arr.Clone(), out test.ShakeOperat), "\nШейкерная сортировка");
            Console.WriteLine($"\nПроизведено {test.ShakeOperat} операций\n");

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        /// <summary>
        /// Демонстрация решения задачи 3
        /// </summary>
        public void Task3()
        {
            int findNumb;
            int[] sortedArr = arrayTest.ShakerSort((int[])arrayTest.arr.Clone(), out test.ShakeOperat);
            ConsoleIO_Lib.ConsolIO.Greeting(msg3);

            PrintArr(sortedArr, "Отсортированный массив:");

            Console.WriteLine("\nВведите число для поиска:");
            findNumb = ConsoleIO_Lib.ConsolIO.GetNumber();
            Console.WriteLine($"\nИндекс искомого числа: {arrayTest.FindIndex(sortedArr,findNumb)}"); 
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 4
        /// </summary>
        public void Task4()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(msg4);

            Console.WriteLine($"Тестируем сортировку {test.SmalArr.Length} массивов из {test.SmalArr[0].Length} элементов...");
            test.RunTestSorts(test.SmalArr);
            PrintTestResult();

            Console.WriteLine($"Тестируем сортировку {test.MedArr.Length} массивов из {test.MedArr[0].Length} элементов...");
            test.RunTestSorts(test.MedArr);
            PrintTestResult();

            Console.WriteLine($"Тестируем сортировку {test.LargeArr.Length} массивов из {test.LargeArr[0].Length} элементов...");
            test.RunTestSorts(test.LargeArr);
            PrintTestResult();

            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Выводит в консоль результат тестирования
        /// </summary>
        void PrintTestResult()
        {
            Console.WriteLine($"Среднее количество операций методом пузырька: \t\t {test.BubbleOperat,15:### ### ###}");
            Console.WriteLine($"Среднее количество операций улучшенным методом пузырька: {test.OptBubbleOperat,15:### ### ###}");
            Console.WriteLine($"Среднее количество шейкерным методом \t\t\t {test.ShakeOperat,15:### ### ###}");
            Console.WriteLine("Тест завершен!\n");
        }

        /// <summary>
        /// Выводит в консоль массив
        /// </summary>
        /// <param name="arr"></param>
        void PrintArr(int[] arr, string msg)
        {
            Console.WriteLine($"\n{msg}");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
