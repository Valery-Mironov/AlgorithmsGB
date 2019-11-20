/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 5. 
 * 
 * Задание 1
 * Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
 * 
 * Задание 2
 * Добавить в программу «Реализация стека на основе односвязного списка» проверку на выделение памяти. 
 * Если память не выделяется, то должно выводиться соответствующее сообщение. Постарайтесь создать ситуацию,
 * когда память не будет выделяться (добавлением большого количества данных).
 * 
 * Задание 3
 * Написать программу, которая определяет, является ли введённая скобочная последовательность правильной.
 * Примеры правильных скобочных выражений – (), ([])(), {}(), ([{}]), неправильных – )(, ())({), (, ])}), ([(]),
 * для скобок – [, (, {. Например: (2+(2*2)) или [2/{5*(4+7)}].
 * 
 * Задание 4*
 * Создать функцию, копирующую односвязный список (то есть создающую в памяти копию односвязного списка без удаления первого списка).
 * 
 * Задание 5*
 * Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную.
 * 
 * Задание 6
 * Реализовать очередь: a) С использованием массива. b*) С использованием односвязного списка.
 * 
 * Задание 7*
 * Реализовать двустороннюю очередь.
 * 
 */

using Lesson_5_Lib;
using System;
using static ConsoleIO_Lib.ConsolIO;

namespace Main
{
    /// <summary>
    /// Консольный пользовательский интерфейс
    /// </summary>
    public class Tasks
    {
        /// <summary>
        /// Сообщения для ввывода
        /// </summary>
        readonly string[] message;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="numTests">количество тестов</param>
        /// <param name="testArrLength">длина массива</param>
        public Tasks(string[] msgs)
        {
            message = msgs;
        }

        /// <summary>
        /// Демонстрация решения задачи 1
        /// </summary>
        public void Task1()
        {
            int numb;
            bool result;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Greeting(this.message[0]);
            Console.WriteLine("Для выхода нажмите \"Esc\"");
            Console.ResetColor();
            Console.WriteLine($"\nВведите целое число в диапазоне от {int.MinValue} до {int.MaxValue}");
            do
            {
                result = GetInt(out numb);
                if (result)
                {
                    Binary bin = Dec2BinStek.Dec2Bin(numb);
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine($"Dec {numb}\nBin {bin}");
                }
                Console.SetCursorPosition(0, Console.CursorTop);
            } while (!(result == false && numb == -2));
        }

        /// <summary>
        /// Демонстрация решения задачи 2
        /// </summary>
        public void Task2()
        {
            int numb;
            bool exit;
            bool result;
            MyStack<int> stack;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Greeting(this.message[1]);
                
                Console.WriteLine("Для выхода нажмите \"Esc\"");
                Console.ResetColor();

                exit = GetInt(out numb, "\nВведите размер стека: ");
                if (exit && numb > 0)
                {
                    stack = new MyStack<int>(numb);
                    Console.WriteLine("\nПоочередно вводите целые числа для помещения в стек\nДля вывода содержимого стека нажмите \"Enter\"\nДля выхода нажмите \"Esc\"");
                    do
                    {
                        result = false;
                        try
                        {
                            exit = GetInt(out numb, "\nВведите очередное число число: ");
                            if (exit) { Console.WriteLine($"\t{result = stack.Push(numb)}"); }
                            else if (numb == 0) { Console.WriteLine(stack.ToString()); result = true; }
                        }
                        catch (StackOverflowException ex) { Console.WriteLine($"\nОшибка!\n{ex.Message}"); }
                    } while (result);
                }
            } while (!(exit == false && numb == -2));
        }

        /// <summary>
        /// Демонстрация решения задачи 3
        /// </summary>
        public void Task3()
        {
            string str;
            bool exit;
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Greeting(this.message[2]);
            Console.WriteLine("Для выхода нажмите \"Esc\"\n");
            Console.ResetColor();
            do
            {
                Console.Write("Введите строку...");
                exit = GetString(out str);
                if (!exit)
                {
                    if (Brace.IsCorrect(str)) { Console.WriteLine($"\nВ строке \"{str}\" все скобки расставлены верно.\n"); }
                    else { Console.WriteLine($"\nВ строке \"{str}\" скобки расставлены не верно.\n"); }
                }
            } while (!exit);
        }

        /// <summary>
        /// Демонстрация решения задачи 4
        /// </summary>
        public void Task4()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[3]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 5
        /// </summary>
        public void Task5()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[4]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 6
        /// </summary>
        public void Task6()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[5]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 7
        /// </summary>
        public void Task7()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[6]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
