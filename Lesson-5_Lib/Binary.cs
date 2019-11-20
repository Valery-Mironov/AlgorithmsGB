/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 5. 
 * 
 * Задание 1
 * Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
 * 
 */

namespace Lesson_5_Lib
{
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

        /// <summary>
        /// Представляет массив бит в виде строки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str ="";
            bool flag = false;
            for (int i = 0; i < cat.Length / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!flag && !cat[i * 4 + j] && i != cat.Length /4 -1) continue;
                    else flag = true;
                }
                if (flag)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (cat[i * 4 + k]) str += 1;
                        else str += 0;
                    }
                    str+=" ";
                }
            }
            if (!flag) str+=0;
            return str;
        }
    }
        
}
