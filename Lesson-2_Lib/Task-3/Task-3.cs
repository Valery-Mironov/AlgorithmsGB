/* Антон Алиев
 * Алгоритмы,  урок 3, задание 3**
 * 
 * Исполнитель «Калькулятор» преобразует целое число, записанное на экране. У исполнителя две команды, каждой присвоен номер:
 *    1. Прибавь 1.
 *    2. Умножь на 2.
 * Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза.
 * Определить, сколько существует программ, которые преобразуют число 3 в число 20:
 *    а. С использованием массива.
 *    b. *С использованием рекурсии.
 */

using Lesson_2_Lib.Task_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static ConsoleIO_Lib.ConsolIO;

namespace Lesson_2_Lib
{
    public class Task3
    {
        public static void Run()
        {
			ConsoleKeyInfo key;
			bool exitFlag = false;
            Console.WriteLine("Исполнитель «Калькулятор» преобразует целое число, записанное на экране. У исполнителя две команды, каждой присвоен номер:\n" +
                "* 1.Прибавь 1\n* 2.Умножь на 2\n* Первая команда увеличивает число на экране на 1,\nвторая увеличивает его в 2 раза.\n" +
                "* Определить, сколько существует программ, которые преобразуют число 3 в число 20:\n" +
                "*а.С использованием массива\n* b. * С использованием рекурсии.");

			Calculator calc = new Calculator(3, 20);

			do
			{
				calc.Reset();
				Console.Clear();
				Console.WriteLine("\"Spase\"\t- увеличить число на единицу\n\"Enter\"\t- удвоить число\n\"N\"\t- начать заново\n\"Esc\"\t- выйти\n");
				Console.WriteLine("Текущее число: ");

				while (calc.CheckState() < 0 && !exitFlag)
				{
					Console.SetCursorPosition(15, 5);
					Console.WriteLine($"{ calc.CurrState,-10}");
					key = Console.ReadKey(true);

					switch (key.Key)
					{
						case ConsoleKey.Spacebar:
							calc.StepAdd();
							break;
						case ConsoleKey.Enter:
							calc.StepRedouble();
							break;
						case ConsoleKey.N:
							calc.Reset();
							break;
						case ConsoleKey.Escape:
							exitFlag = true;
							break;
						default: continue;
					}
					if (calc.CheckState() == 0)
					{
						Console.WriteLine($"Вы выиграли!\nКоличество ходов {calc.Steps}");
						Console.ReadKey();
						break;
					}
					else if (calc.CheckState() > 0)
					{
						Console.WriteLine($"Число {calc.CurrState} превысило {calc.Finish}\nВы проиграли!");
						Console.ReadKey();
						break;
					}
				} 
			} while (!exitFlag);

			PauseClear();
        }
    }
}
