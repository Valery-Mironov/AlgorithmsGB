/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 5. 
 * 
 * Задание 7*
 * Реализовать двустороннюю очередь.
 * 
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson_5_Lib
{
    /// <summary>
    /// Двусвязный список список
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyDeq<T> : IEnumerable<T>
    {
        /// <summary>
        /// Класс элемента двусвязного списка
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class Node<T>
        {
            /// <summary>
            /// Конструктор элемента
            /// </summary>
            /// <param name="data"></param>
            public Node(T data)
            {
                Data = data;
            }
            /// <summary>
            /// Данные элемента
            /// </summary>
            public T Data { get; set; }
            /// <summary>
            /// Следующий элемент
            /// </summary>
            public Node<T> Next { get; set; }
            /// <summary>
            /// Предыдущий элемент
            /// </summary>
            public Node<T> Prev { get; set; }
        }

        /// <summary>
        /// Первый элемент списка
        /// </summary>
        Node<T> head;

        /// <summary>
        /// Последний элемент списка
        /// </summary>
        Node<T> tail;

        /// <summary>
        /// Добавление елемента в конец списка
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            
            node.Prev = tail;
            tail = node;
            Count++;
        }

        /// <summary>
        /// Добавление элемента в начало списка
        /// </summary>
        /// <param name="data"></param>
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (Count == 0)
                tail = head;
            Count++;
        }

        /// <summary>
        /// Возвращает первый элемент списка без удаления
        /// </summary>
        /// <returns></returns>
        public T GetFirst()
        {
            return head.Data;
        }

        /// <summary>
        /// Возвращает последний элемент списка без удаления
        /// </summary>
        /// <returns></returns>
        public T GetLast()
        {
            return tail.Data;
        }

        /// <summary>
        /// Извлекает из элемент из конца списка с удалением
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            T temp = tail.Data;
            tail = tail.Prev;
            tail.Next = null;
            Count--;
            return temp;
        }

        /// <summary>
        /// Извлекает элемент из начала списка с удалением
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            T temp = head.Data;
            head = head.Next;
            Count--;
            return temp;
        }

        /// <summary>
        /// Возвращает количество элементов списка
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Возвращает признак пустого списка
        /// </summary>
        public bool IsEmpty { get { return Count == 0; } }

        /// <summary>
        /// Очистка списка
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        /// <summary>
        /// Возращает признак вхождения элемента в список
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Возвращает копию односвязного списка
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public MyLinkList<T> Copy()
        {
            MyLinkList<T> temp = new MyLinkList<T>();
            foreach (var item in this)
            {
                temp.Add(item);
            }
            return temp;
        }

        /// <summary>
        /// Реализация интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
