using System;

namespace Task_13
{
    public class MyRandom
    {
        private const int a = 48271;
        private const int m = int.MaxValue;
        private const int q = 127773;
        private const int r = 2836;
        private int seed;

        /// <summary>
        /// Конструктор. Использует системное время для инициализации начального значения
        /// </summary>
        public MyRandom()
        {
            int startNumb;
            DateTime time;
            do
            {
                time = DateTime.Now;
                startNumb = time.Millisecond;
            }
            while (startNumb == 0);

            this.seed = startNumb;

        }

        /// <summary>
        /// Возвращает псевдослучайное число в диапазоне от min до max
        /// </summary>
        /// <param name="min">минимальное значение</param>
        /// <param name="max">максимальное значение</param>
        /// <returns></returns>
        public int Next(int min, int max)
        {
            int hi = seed / q;
            int lo = seed % q;
            return (int)((max - min) * Generate() + min);
        }
        
        /// <summary>
        /// Алгоритм ГПС Лемера
        /// </summary>
        /// <returns></returns>
        private double Generate()
        {
            int hi = seed / q;
            int lo = seed % q;
            seed = (a * lo) - (r * hi);
            if (seed <= 0)
                seed = seed + m;
            return (seed * 1.0) / m;
        }
    }
}
