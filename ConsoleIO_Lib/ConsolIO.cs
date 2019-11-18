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

        public static bool PrintDesk(int[,] matr)
        {
            bool exit = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("{0,3}{1,3}{2,3}{3,3}{4,3}{5,3}{6,3}{7,3}{8,3}\n", " ", "A", "B", "C", "D", "E", "F", "G", "H");
            Console.ResetColor();
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                for (int j = 0; j < matr.GetLength(0); j++)
                {
                    if (j == 0) { Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"{i + 1,3}"); Console.ResetColor(); }
                    if (matr[i, j] == 0) Console.Write("{0,3}", "*");
                    else Console.Write($"{matr[i, j],3}");
                }
                Console.WriteLine();
            }
            //Console.ReadKey();

            ConsoleKeyInfo key;

            Console.WriteLine("\nДля вывода следующего варианта решения - нажмите любую клавишу...\nДля возврата в основное меню - нажмите \"Esc\"");
            key = Console.ReadKey(true);
            Console.Clear();
            if (key.Key == ConsoleKey.Escape) exit = true;
            return exit;

        }
    }
}
