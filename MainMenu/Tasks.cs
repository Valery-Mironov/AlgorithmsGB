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

using System;

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
        string[] message;

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
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[1]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 2
        /// </summary>
        public void Task2()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[2]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 3
        /// </summary>
        public void Task3()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[3]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 4
        /// </summary>
        public void Task4()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[4]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 5
        /// </summary>
        public void Task5()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[5]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 6
        /// </summary>
        public void Task6()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[6]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 7
        /// </summary>
        public void Task7()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[7]);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
