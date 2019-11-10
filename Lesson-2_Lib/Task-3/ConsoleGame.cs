using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Lib.Task_3
{
	public class ConsoleGame : Calculator
	{
		public ConsoleGame() {}
		public ConsoleGame(int start, int finish) : base(start, finish) {}

		public void StartGame()
		{
			ConsoleKeyInfo key;
			bool exitFlag = false;
			do
			{
				this.Reset();
				Console.Clear();
				Console.WriteLine("\"Spase\"\t- увеличить число на единицу\n\"Enter\"\t- удвоить число\n\"N\"\t- начать заново\n\"Esc\"\t- выйти\n");
				Console.SetCursorPosition(40, 0);
				//Console.WriteLine($"Для выигрыша необходимо набрать {this.Finish} за {this.MinMoves} ходов!");

				while (this.CheckState() < 0 && !exitFlag)
				{
					Console.SetCursorPosition(0, 5);
					Console.WriteLine($"Необходимe число:\t{this.Finish}\nТекущее число:\t\t{this.CurrState}\nОсталось ходов: {this.MinMoves - this.Steps}");
					key = Console.ReadKey(true);

					switch (key.Key)
					{
						case ConsoleKey.Spacebar:
							this.StepAdd();
							break;
						case ConsoleKey.Enter:
							this.StepRedouble();
							break;
						case ConsoleKey.N:
							this.Reset();
							break;
						case ConsoleKey.Escape:
							exitFlag = true;
							break;
						default: continue;
					}
					if (this.CheckState() == 0)
					{
						Console.Clear();
						Console.WriteLine($"Вы выиграли!\nКоличество ходов {this.Steps}");
						Console.ReadKey();
						break;
					}
					else if (this.CheckState() > 0)
					{
						Console.WriteLine($"Число {this.CurrState} превысило {this.Finish}\nВы проиграли!");
						Console.ReadKey();
						break;
					}
				}
			} while (!exitFlag);

			Console.Clear();
		}
	}
}
