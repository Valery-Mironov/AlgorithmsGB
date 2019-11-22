/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 5. 
 * 
 * Задание 2
 * Добавить в программу «Реализация стека на основе односвязного списка» проверку на выделение памяти. 
 * Если память не выделяется, то должно выводиться соответствующее сообщение. Постарайтесь создать ситуацию,
 * когда память не будет выделяться (добавлением большого количества данных).
 * 
 */

namespace Lesson_5_Lib
{
    /// <summary>
    /// Стек
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyStack<T>
    {
        /// <summary>
        /// Массив стека
        /// </summary>
        private T[] stek;

        /// <summary>
        /// Указатель на текущий индекс
        /// </summary>
        private int header;

        /// <summary>
        /// Флаг пустого стека
        /// </summary>
        public bool IsEmpty { get; private set; }

        /// <summary>
        /// Флаг полного стека
        /// </summary>
        public bool IsFull { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public MyStack(int length = 64)
        {
            stek = new T[length];
            header = -1;
            IsEmpty = true;
            IsFull = false;

        }

        /// <summary>
        /// Помещает в стек очередной объект
        /// </summary>
        /// <param name="obj"></param>
        public bool Push(T obj)
        {
            if (!IsFull)
            {
                stek[++header] = obj;
                if (header == stek.Length - 1) IsFull = true;
                IsEmpty = false;
                return true;
            }
            else
            {
                throw new System.StackOverflowException("Попытка поместить данные в стек вызвала переполнение стека");
            }
        }

        /// <summary>
        /// Извлекает с удалением из стека последний добавленный элемент
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T value = default;
            if (!IsEmpty)
            {
                value = stek[header--];
                if (header < 0) IsEmpty = true;
            }
            return value;
        }

        /// <summary>
        /// Извлекает из стека последний добавленный элемент без удаления
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            T value = default;
            if (!IsEmpty) value = stek[header];
            return value;
        }

        /// <summary>
        /// Очищает стек (сбрасывает указатель)
        /// </summary>
        public void Clear()
        {
            header = -1;
            IsEmpty = true;
            IsFull = false;
        }

        /// <summary>
        /// Возвращает содержимое стека в виде строки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = string.Empty;
            int position = 1;
            if (IsEmpty) return "Стек пуст!";
            else
            {
                for (int i = header; i >= 0; i--)
                {
                    result += string.Format($"\n{position} => {stek[i]}");
                    position++;
                }
            }
            return result;
        }
    }
}
