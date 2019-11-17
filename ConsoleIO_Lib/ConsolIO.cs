using System;

/// <summary>
/// Бибилиотека для удобства работы с консолью
/// </summary>
namespace ConsoleIO_Lib
{
    /// <summary>
    /// Методы для работы с консолью
    /// </summary>
    public static class ConsolIO
    {
        /// <summary>
        /// Циклично запрашивает из консоли целое число
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static int GetNumber(string msg1 = "", string msg2 = "")
        {
            string str;
            int result;
            bool isCorrect = false;
            do
            {
                Console.WriteLine(msg1, msg2);
                str = Console.ReadLine();
                isCorrect = int.TryParse(str, out result);
                if (!isCorrect)
                {
                    Console.WriteLine($"Ошибка ввода!\n{str} - не соответствует условию...\n Повторите ввод:");
                }
            }
            while (!isCorrect);
            return result;
        }

        /// <summary>
        /// Ожидает нажатия любой клавиши, и очищает консоль
        /// </summary>
        public static void PauseClear()
        {
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Чистит консоль и выводит условие задачи
        /// </summary>
        /// <param name="msg"></param>
        public static void Greeting(string msg)
        {
            Console.Clear();
            Console.WriteLine(msg);
        }
    }
}
