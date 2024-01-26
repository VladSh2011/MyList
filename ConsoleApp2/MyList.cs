using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public class MyList<T>
    {
        private T[] _list;
        private int _count;
        public MyList()
        {
            _list = new T[0];
            _count = 0;
        }

        public void Clear()
        {
            _list = new T[0];
            _count = 0;
        }
        //Прибрати дублювання коду
        public void Add(T item)
        {
            if (_count == 0)
            {
                _count++;
                _list = new T[_count];
                _list[0] = item;
            }
            else
            {
                T[] tmp = new T[_count + 1];
                for (int i = 0; i < _count; i++)
                {
                    tmp[i] = _list[i];
                }
                tmp[_count] = item;
                _count++;
                _list = tmp;
            }
        }
        //Прибрати після реалізації IEnumerable
        public void Show()
        {
            foreach (T item in _list)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        public bool RemoveAt(int index)
        {
            if (index > Count - 1 || index < 0)
            {
                return false;
            }
            T[] tmp = new T[_count - 1];
            for (int i = 0; i < index; i++)
            {
                tmp[i] = _list[i];
            }
            for (int i = index; i < _count - 1; i++)
            {
                tmp[i] = _list[i + 1];
            }
            _list = tmp;
            _count--;
            return true;
        }
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            return RemoveAt(index);
        }
        public bool Contains(T? item)
        {
            if (item == null)
            {
                return false;
            }
            for (int i = 0; i < _count; i++)
            {
                if (item.Equals(_list[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (item.Equals(_list[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Reverse()
        {
            T[] tmp = new T[_count];
            for (int i = Count - 1; i >= 0; i--)
            {
                tmp[Count - 1 - i] = _list[i];
            }
            _list = tmp;
        }
        public int LastIndexOf(T item)
        {
            for (int i = _count-1; i >= 0; i--)
            {
                if (_list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Insert(int index, T value)
        {
            if (index < 0 || index > 0 || value == null)
            {
                return;
            }
            T[] tmp = new T[_count + 1];
            for(int i = 0; i < index; i++)
            {
                tmp[i] = _list[i];
            }
            tmp[index] = value;
            for(int i = index;  i < _count; i++)
            {
                tmp[i+1] = _list[i];
            }
            _list = tmp;
            _count++;
        }
        //Добавити IEnumerable в клас
        //Попробувати написати метод InsertRange, який отримує першим параметром індекс, а другим колекцію
        public int Count => _count;
    }
}