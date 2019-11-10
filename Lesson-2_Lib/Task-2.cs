/* Антон Алиев
 * Алгоритмы,  урок 2, задание 2
 * 
 * Реализовать функцию возведения числа a в степень b:
 * a) Без рекурсии.
 * b) Рекурсивно.
 * c) *Рекурсивно, используя свойство чётности степени.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleIO_Lib.ConsolIO;

namespace Lesson_2_Lib
{
    public class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Задание 2\nРеализовать функцию возведения числа a в степень b:\n" +
                "a) Без рекурсии\nb)Рекурсивно\nc)* Рекурсивно, используя свойство чётности степени");

			//double result;
			double number = GetNumber("Введите основание степени:");
			int power = GetNumber("Введите показатель степени:");
			Console.WriteLine($"Без рекурсии: {number}^{power}={Pow(number,power)}");
			Console.WriteLine($"С рекурсией: {number}^{power}={RecPow(number, power)}");
			Console.ReadKey();

			
			

		}

		/// <summary>
		/// Возведение числа в степень через цикл
		/// </summary>
		/// <param name="numb">число</param>
		/// <param name="pow">степень числа</param>
		/// <returns>numb^pow</returns>
		static double Pow(double numb, int pow)
		{
			double result = numb;
			if (numb == 0) return 0;
			else if (numb == 1 || pow == 0) return 1;

			if (pow > 0)
			{
				while (pow > 1)
				{
					result *= numb;
					pow--;
				}
			}
			else
			{
				while (pow < -1)
				{
					result *= numb;
					pow++;
				}
				return 1 / result;
			}
			return result;
		}

		/// <summary>
		/// Рекурсивный метод возведения в степень
		/// </summary>
		/// <param name="numb">число</param>
		/// <param name="pow">степень числа</param>
		/// <returns>numb^pow</returns>
		static double RecPow(double numb, int pow)
		{
			int absPow = Math.Abs(pow);
			if (numb == 0) return 0;
			if (numb == 1 || pow == 0) return 1;
			if (pow > 1) return RecPow(numb , --absPow) * numb;
			if (pow < -1) return 1/ (RecPow(numb, --absPow) * numb);
			return numb;
		}
	}
}
