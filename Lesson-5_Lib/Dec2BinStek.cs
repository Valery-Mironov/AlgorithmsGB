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
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Lib
{
    /// <summary>
    /// Конверитрует число из десятичной системы счисления в двоичную, с использованием стека
    /// </summary>
    public static class Dec2BinStek
    {
        public static Binary Dec2Bin(int decNumb)
        {
            Binary binNumb = new Binary();
            MyStack<bool> stack = new MyStack<bool>();
            int temp;
            if (decNumb == 0) binNumb = default;
            {

            }
            if(decNumb > 0)
            {
                temp = decNumb;
                for (int i = 0; i < binNumb.Length; i++)
                {
                    stack.Push(temp % 2 == 1);
                    temp /= 2;
                }
                
            }
            if (decNumb < 0)
            {
                temp = Math.Abs(decNumb + 1);
                for (int i = 0; i < binNumb.Length; i++)
                {
                    stack.Push(temp % 2 == 0);
                    temp /= 2;
                }
            }

            for (int i = 0; i < binNumb.Length; i++)
            {
                binNumb.cat[i] = stack.Pop();
            }

            return binNumb;
        }
    }

    /// <summary>
    /// Представляет двуичное число в видее массива bool[]
    /// </summary>
    public class Binary
    {
        public bool[] cat;
        public int Length { get; private set; }
        public Binary(int length = 32)
        {
            Length = length;
            cat = new bool[Length];    
        }

        public override string ToString()
        {
            string str ="";
            foreach (bool item in cat)
            {
                if (item) str += "1";
                else str += "0";
            }
            return  str;
        }
    }
        
}
