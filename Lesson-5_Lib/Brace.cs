/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 5. 
 * 
 * Задание 3
 * Написать программу, которая определяет, является ли введённая скобочная последовательность правильной.
 * Примеры правильных скобочных выражений – (), ([])(), {}(), ([{}]), неправильных – )(, ())({), (, ])}), ([(]),
 * для скобок – [, (, {. Например: (2+(2*2)) или [2/{5*(4+7)}].
 * 
 */

namespace Lesson_5_Lib
{
    /// <summary>
    /// Проверка строки на правильную последовательность скобок
    /// </summary>
    public static class Brace
    {
        /// <summary>
        /// стек
        /// </summary>
        static MyStack<char> stack = new MyStack<char>();

        /// <summary>
        /// Возвращает результат проверки строки на правильною последовательность скобок
        /// </summary>
        /// <param name="str">проверяемая строка</param>
        /// <returns></returns>
        public static bool IsCorrect(string str)
        {
            foreach (char ch in str)
            {
                if (ch == '(' || ch == '{' || ch == '[') stack.Push(ch);
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    switch(ch)
                    {
                        case ')':
                            if (stack.Peek() == '(') stack.Pop();
                            else { stack.Clear(); return false; }
                            break;
                        case '}':
                            if (stack.Peek() == '{') stack.Pop();
                            else { stack.Clear(); return false; }
                            break;
                        case ']':
                            if (stack.Peek() == '[') stack.Pop();
                            else { stack.Clear(); return false; }
                            break;
                    }
                }
            }
            return stack.IsEmpty;
        }
    }
}
