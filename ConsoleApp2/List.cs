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
        public void Show()
        {
            foreach (T item in _list)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        public bool Remove(T item)
        {
            if(!Contains(item))
            {
                return false;
            }
            for(int i = 0; i < _count; i++)
            {
                
            }
            return true;
        }
        public bool Contains(T? item)
        {
            if (item == null)
            {
                return false;
            }
            for(int i = 0; i < _count; i++)
            {
                if (item.Equals(_list[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public int Count => _count;
    }
}