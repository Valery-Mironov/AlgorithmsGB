using System.Collections;
using System.Collections.Generic;

namespace Lesson_5_Lib
{
    /// <summary>
    /// Односвяхный список
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyLinkList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Класс элемента односвязного списка
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class Node<T>
        {
            public Node(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public Node<T> Next { get; set; }
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
            tail = node;

            Count++;
        }
        
        /// <summary>
        /// Удаление элемента из списка по значению
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
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