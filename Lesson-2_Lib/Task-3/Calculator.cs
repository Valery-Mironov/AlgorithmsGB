using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Lib.Task_3
{
    public class Calculator
    {
		/// <summary>
		/// Начальное число
		/// </summary>
        public int Start { get; private set; }

		/// <summary>
		/// Конечное число
		/// </summary>
        public int Finish { get; private set; }

		/// <summary>
		/// Текущее число
		/// </summary>
        public int CurrState { get; private set; }

		/// <summary>
		/// Количество шагов
		/// </summary>
        public int Steps { get; private set; }

		/// <summary>
		/// Минимальное количество шагов
		/// </summary>
		public int MinMoves { get; private set; }

		/// <summary>
		/// Параметризированный конструктор
		/// </summary>
		/// <param name="start">стартовое число</param>
		/// <param name="finish">конечное число</param>
        public Calculator(int start, int finish)
		{
			Init(start, finish);
		}
		
		/// <summary>
		/// Конструктор по-умолчанию
		/// </summary>
		public Calculator() : this(0, 20) { }
		
		/// <summary>
		/// Инициализирует начальное состояние
		/// </summary>
		/// <param name="start"></param>
		/// <param name="finish"></param>
		private void Init(int start, int finish)
		{
			Steps = 0;
			Start = start;
			Finish = finish;
			CurrState = start;
			MinMoves = MinMovesCalculate();
		}

		/// <summary>
		/// Инкрементирует текущее число
		/// </summary>
		internal void StepAdd()
        {
            CurrState++;
			Steps++;
			CheckState();
		}

		/// <summary>
		/// Удваивает текущее число
		/// </summary>
		internal void StepRedouble()
		{
			CurrState *= 2;
			Steps++;
			CheckState();
		}

		/// <summary>
		/// Сбрасывает состояние
		/// </summary>
		internal void Reset()
		{
			Init(Start, Finish);
		}

		/// <summary>
		/// Возвращает признак состояния игры
		/// </summary>
		/// <returns></returns>
		internal int CheckState()
		{
			if (CurrState == Finish) return 0;
			else if (CurrState > Finish || Steps > MinMoves) return 1;
			return -1;
		}

		/// <summary>
		/// Расчитывает варианты количества ходов
		/// </summary>
		private int MinMovesCalculate()
		{
			int temp = Finish;
			int stp = 0;
			while(temp > Start)
			{
				if(temp % 2 == 0)
				{
					temp /= 2;
					stp++;
				}
				else
				{
					temp--;
					stp++;
				}
			}
			return stp;
		}
	}
}
