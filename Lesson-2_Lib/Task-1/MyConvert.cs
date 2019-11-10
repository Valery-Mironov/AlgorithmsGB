using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Lib.Task_2
{
	public static class MyConvert
	{
		
		public static bool[] IntToBin(int dec)
		{
			bool[] bin = new bool[32];
			if (dec >= 0)
			{
				for (int i = bin.Length - 1; i >= 0; i--)
				{
					bin[i] = dec % 2 != 0;
					dec /= 2;
				}
			}
			else
			{
				dec = Math.Abs(dec + 1);
				for (int i = bin.Length - 1; i >= 0; i--)
				{
					bin[i] = dec % 2 == 0;
					dec /= 2;
				}
			}
			return bin;
		}
	}
}
