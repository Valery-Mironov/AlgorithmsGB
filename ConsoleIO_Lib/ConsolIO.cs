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
        /// Циклично запрашивает из консоли целое число. Определяет нажатие клавишь Esc и Enter
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool GetInt(out int nmbr, string msg1 = "", string msg2 = "")
        {
            string str = string.Empty;
            nmbr = default;
            bool isCorrect = false;
            bool result = false;
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine(msg1, msg2);
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key >= ConsoleKey.D0 && key.Key <= ConsoleKey.D9 || key.Key == ConsoleKey.OemMinus || key.Key == ConsoleKey.Backspace)
                    {
                        if (key.Key == ConsoleKey.Backspace && str.Length !=0)
                        {
                            str = str.Remove(str.Length - 1);
                            Console.MoveBufferArea(0, Console.CursorTop, Console.BufferWidth, 1, Console.BufferWidth, Console.CursorTop, ' ', Console.ForegroundColor, Console.BackgroundColor);
                            Console.SetCursorPosition(0, Console.CursorTop);
                            Console.Write(str);
                        }
                        else
                        {
                            str += key.KeyChar;
                            Console.SetCursorPosition(0, Console.CursorTop);
                            Console.Write(str);
                        }
                    }
                }
                while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape);

                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        nmbr = -2;
                        isCorrect = true;
                        break;
                    case ConsoleKey.Enter:
                        if (str != string.Empty)
                        {
                            isCorrect = int.TryParse(str, out nmbr);
                            if (!isCorrect)
                            {
                                Console.WriteLine($"\nОшибка ввода!\n\"{str}\" - не соответствует условию...\nПовторите ввод:");
                                str = string.Empty;
                            }
                            result = true;
                        }
                        else isCorrect = true;
                        break;
                }
            }
            while (!isCorrect);
            return result;
        }

        /// <summary>
        /// Циклично запрашивает из консоли строку. Определяет нажатие клавишь Esc и Enter
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool GetString(out string str, string msg1 = "", string msg2 = "")
        {
            str = string.Empty;
            bool isEmpty = false;
            ConsoleKeyInfo key;
            
            Console.WriteLine(msg1, msg2);
            do
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Backspace && str.Length >0)
                {
                    str = str.Remove(str.Length - 1);
                    Console.MoveBufferArea(0, Console.CursorTop, Console.BufferWidth, 1, Console.BufferWidth, Console.CursorTop, ' ', Console.ForegroundColor, Console.BackgroundColor);
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(str);
                }
                if (!char.IsControl(key.KeyChar))
                {
                    str += key.KeyChar;
                    isEmpty = true;
                }
                
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(str);
            }
            while (key.Key != ConsoleKey.Escape ^ (key.Key == ConsoleKey.Enter && isEmpty));
           
            return key.Key == ConsoleKey.Escape;
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

        /// <summary>
        /// Выводит в консоль матрицу шахматного поля
        /// </summary>
        /// <param name="matr"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Выводит в консоль матрицу пересечения множеств
        /// </summary>
        /// <param name="matr"></param>
        public static void PrintMatrix(int[,] matr)
        {
            for (int j = 0; j < matr.Length / matr.GetLength(0); j++)
            {
                if (j <= 1) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("-----------------");
                if (j <= 1) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else Console.ResetColor();
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("|");
                Console.ResetColor();
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    if (i == 0 || j == 0) Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else Console.ResetColor();
                    Console.Write(string.Format("\t{0:0}\t|", matr[i, j]));
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("-----------------");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Выводит в консоль матрицу количества ходов в табличном виде
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="msg"></param>
        public static void PrintMatrix(int[,] matrix, string msg)
        {
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2 - 6, Console.CursorTop + 1);
            Console.WriteLine($"- = {msg} = -");
            for (int j = 0; j < matrix.Length / matrix.GetLength(0); j++)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                Console.Write("|");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == -1) Console.Write(string.Format("\t{0:0}\t|", "X"));
                    else if (matrix[i, j] == 0 || matrix[i, j] < -1) Console.Write(string.Format("\t{0:0}\t|", "0"));
                    else Console.Write(string.Format("\t{0:0}\t|", matrix[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
