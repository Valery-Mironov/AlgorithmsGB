using System;
using System.Collections.Generic;

namespace Lesson_5_Lib
{
    public class MyQueue<T>
    {
        /// <summary>
        /// Массив очереди
        /// </summary>
        private T[] queue;

        /// <summary>
        /// Вершина очереди
        /// </summary>
        private int head;

        /// <summary>
        /// Конец очереди
        /// </summary>
        private int tail;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="capacity">Начальная емкость</param>
        public MyQueue(int capacity = 4)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();
            queue = new T[capacity];
            head = 0;
            tail = 0;
            Count = 0;
        }

        /// <summary>
        /// Возвращает количество элементов в очереди
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Очищает очередь
        /// </summary>
        public void Clear()
        {
            if (head < tail)
                Array.Clear(queue, head, Count);
            else
            {
                Array.Clear(queue, head, queue.Length - head);
                Array.Clear(queue, 0, tail);
            }
            head = 0;
            tail = 0;
            Count = 0;
        }

        /// <summary>
        /// Возращает признак вхождения элемента в очередь
        /// </summary>
        /// <param name="item">элемент</param>
        /// <returns>true, если элемент содержится в очереди.</returns>
        public bool Contains(T item)
        {
            int index = head;
            int num2 = Count;
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            while (num2-- > 0)
            {
                if (item == null)
                {
                    if (queue[index] == null)
                        return true;
                }
                else if ((queue[index] != null) && comparer.Equals(queue[index], item))
                    return true;
                index = (index + 1) % queue.Length;
            }
            return false;
        }

        /// <summary>
        /// Извлекает элемент из очереди
        /// </summary>
        /// <returns>Извлечённый элемент.</returns>
        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            T local = queue[head];
            queue[head] = default(T);
            head = (head + 1) % queue.Length;
            Count--;
            return local;
        }

        /// <summary>
        /// Добавляет элемент в очередь. Возвращает признак уведичения емкости очереди
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True - если емкость очереди была удвоена</returns>
        public bool Enqueue(T item)
        {
            bool result = false;
            if (Count == queue.Length)
            {
                var capacity = (int)(queue.Length * 2);
                if (capacity < (queue.Length + 4))
                    capacity = queue.Length + 4;
                SetCapacity(capacity);
                result = true;
            }
            queue[tail] = item;
            tail = (tail + 1) % queue.Length;
            Count++;
            return result;
        }

        /// <summary>
        /// Возвращает элемент из очереди без удаления
        /// </summary>
        /// <returns>Верхний элемент</returns>
        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return queue[head];
        }

        /// <summary>
        /// Увеличивает емкость очереди
        /// </summary>
        /// <param name="capacity"></param>
        private void SetCapacity(int capacity)
        {
            var destinationArray = new T[capacity];
            if (Count > 0)
            {
                if (head < tail)
                    Array.Copy(queue, head, destinationArray, 0, Count);
                else
                {
                    Array.Copy(queue, head, destinationArray, 0, queue.Length - head);
                    Array.Copy(queue, 0, destinationArray, queue.Length - head, tail);
                }
            }
            queue = destinationArray;
            head = 0;
            tail = (Count == capacity) ? 0 : Count;
        }

        /// <summary>
        /// Возвращает содержимое кучи в виде строки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = string.Empty;
            int temp = head;
            int position = 1;
            if (Count == 0) return "Куча пуста!";
            else
            {
                for (int i = 1; i <= Count; i++)
                {
                    result += string.Format($"\n{position} => {Peek()}");
                    position++;
                    head++;
                }
            }
            head = temp;
            return result;
        }
    }
}
