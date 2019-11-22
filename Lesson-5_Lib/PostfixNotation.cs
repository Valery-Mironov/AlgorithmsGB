/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 5. 
 * 
 * Задание 5*
 * Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную.
 * 
 */
 
using System.Collections.Generic;

namespace Lesson_5_Lib
{
    /// <summary>
    /// Конвертер InFix2PostFix
    /// </summary>
    public class PostfixNotation
    {
        /// <summary>
        /// Стек для хранения операций
        /// </summary>
        private MyStack<string> stack = new MyStack<string>();

        /// <summary>
        /// Массив операций
        /// </summary>
        private List<string> operations = new List<string> { "(", ")", "+", "-", "*", "/", "^" };

        /// <summary>
        /// Выходная строка
        /// </summary>
        private List<string> outStrList = new List<string>();

        /// <summary>
        /// Возвращает приоритет операции
        /// </summary>
        /// <param name="oper">символ операции</param>
        /// <returns></returns>
        private int GetPriority(string oper)
        {
            switch (oper)
            {
                case "(":
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "^":
                    return 3;
                default:
                    return 4;
            }
        }

        /// <summary>
        /// Конвертирует строковок выражение в постфиксную запись
        /// </summary>
        /// <param name="infix"></param>
        /// <returns></returns>
        public string ConvertToPostFix(string infix)
        {
            infix.Replace(" ", "");
            List<string> parsed = new List<string>();
            List<string> converted;
            string postfix = string.Empty;
            string temp = string.Empty;

            foreach(char ch in infix)
            {
                if (operations.Contains(ch.ToString()))
                {
                    if (temp != string.Empty) { parsed.Add(temp); temp = string.Empty; }
                    parsed.Add(ch.ToString());
                }
                else { temp += ch; }
            }
            parsed.Add(temp);

            converted = Convert2PFix(parsed);

            foreach (string str in converted)
            {
                postfix += str + " ";
            }
            return postfix;
        }

        /// <summary>
        /// Конвертер
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private List<string> Convert2PFix(List<string> input)
        {
            stack.Clear();
            foreach (string st in input)
            {
                if (operations.Contains(st))
                {
                    if (!stack.IsEmpty && st != "(")
                    {
                        if (st == ")")
                        {
                            string temp = stack.Pop();
                            while (temp != "(")
                            {
                                outStrList.Add(temp);
                                temp = stack.Pop();
                            }
                        }
                        else if (GetPriority(st) > GetPriority(stack.Peek()))
                            stack.Push(st);
                        else
                        {
                            while (!stack.IsEmpty && GetPriority(st) <= GetPriority(stack.Peek()))
                                outStrList.Add(stack.Pop());
                            stack.Push(st);
                        }
                    }
                    else
                        stack.Push(st);
                }
                else
                    outStrList.Add(st);
            }
            while (!stack.IsEmpty)
            {
                outStrList.Add(stack.Pop());
            }
            return outStrList;
        }
    }
}
