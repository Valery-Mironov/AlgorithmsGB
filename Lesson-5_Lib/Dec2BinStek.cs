/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 5. 
 * 
 * Задание 1
 * Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
 * 
 */
using System;

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
            if (decNumb == 0) return binNumb;
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
}
