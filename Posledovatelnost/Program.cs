using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posledovatelnost
{
    class Program
    {
        static int[] a = new int[] {1,5,2,8,7,9,8 };
        static int[] b = new int[] {1,5,3,2,6,9,5,7, };
        static void Main(string[] args)
        {
            Console.WriteLine(Length(a,b));
            Console.ReadKey();
        }

        static int Length(int[] n, int[] m)
        {
            int length = 0;
            int i = 0;
            int j = 0;
            length = RecLength(i, j);
            

            int RecLength(int ai, int bj)
            {
                if (ai >= n.Length || bj >= m.Length) return 0;
                else if (n[ai] == m[bj]) return 1 + RecLength(ai+1, bj+1);
                else return Math.Max(RecLength(ai+1, bj), RecLength(ai, bj+1));
            }

            return length;
        }
    }
}
