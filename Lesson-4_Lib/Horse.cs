/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 4. 
 * 
 * Задание 3***
 * Требуется обойти конём шахматную доску размером N × M, пройдя через все поля доски по одному разу.
 * Здесь алгоритм решения такой же, как и в задаче о 8 ферзях. Разница только в проверке положения коня.
 * 
 */

namespace Lesson_4_Lib
{
    /// <summary>
    /// Шахматный конь
    /// </summary>
    public class Horse
    {
        /// <summary>
        /// Делегат для вывода результата. Возвращает условие завершения работы
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns>выход</returns>
        public delegate bool Result(int[,] matrix);

        /// <summary>
        /// Матрица шахматного поля
        /// </summary>
        public int[,] Desk { get; private set; }

        /// <summary>
        /// Выводит результат и возвращает условие выхода
        /// </summary>
        public Result result;

        /// <summary>
        /// флаг выхода
        /// </summary>
        bool exit;

        /// <summary>
        /// Высота шахматного поля
        /// </summary>
        readonly int height;

        /// <summary>
        /// Ширина шахматного поля
        /// </summary>
        readonly int width;

        /// <summary>
        /// Счетчик ходов
        /// </summary>
        int steps;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="a">Ширина поля</param>
        /// <param name="b">Высота поля</param>
        public Horse(int a, int b)
        {
            height = b;
            width = a;
            Desk = new int[height, width];
            steps = 1;
        }

        /// <summary>
        /// Запускает расчет ходов
        /// </summary>
        /// <param name="x">стартовое положение поля первого хода по ширине</param>
        /// <param name="y">стартовое положение поля первого хода по высоте</param>
        public void Run(int x, int y)
        {
            FindNext(x, y);
        }

        /// <summary>
        /// Рекурсивный метод поиска ходов
        /// </summary>
        /// <param name="a">текущее положение по ширине поля</param>
        /// <param name="b">текущее положение по высоте поля</param>
        void FindNext(int a, int b)
        {
            if (exit) return;
            Desk[a, b] = steps;
            if (steps == height * width) { if(result != null) exit = result(Desk) ; }

            if (IsPossibly(a-2, b+1)) { steps++; FindNext(a-2, b+1); }
            if (IsPossibly(a-1, b+2)) { steps++; FindNext(a-1, b+2); }
            if (IsPossibly(a+1, b+2)) { steps++; FindNext(a+1, b+2); }
            if (IsPossibly(a+2, b+1)) { steps++; FindNext(a+2, b+1); }
            if (IsPossibly(a+2, b-1)) { steps++; FindNext(a+2, b-1); }
            if (IsPossibly(a+1, b-2)) { steps++; FindNext(a+1, b-2); }
            if (IsPossibly(a-1, b-2)) { steps++; FindNext(a-1, b-2); }
            if (IsPossibly(a-2, b-1)) { steps++; FindNext(a-2, b-1); }

            Desk[a, b] = 0;
            if(steps > 1) steps--;

            return;
        }

        /// <summary>
        /// Проверяет возможность следующего хода по координатам
        /// </summary>
        /// <param name="x">положение по ширине поля</param>
        /// <param name="y">положение по высоте поля</param>
        /// <returns></returns>
        private bool IsPossibly(int x, int y)
        {
            if (x < 0 || x >= height) return false;
            if (y < 0 || y >= width) return false;
            if (Desk[x, y] != 0) return false;
            return true;
        }
    }
}
