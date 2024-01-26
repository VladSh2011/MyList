using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyStack<T>
    {
        private MyList<T> _stack;
        public MyStack() 
        {
            _stack = new MyList<T>();
        }
        public void Clear() => _stack.Clear();
        public bool Contains(T item) => _stack.Contains(item);
        public void Push(T item) => _stack.Add(item);
        //Прибрати після реалізації IEnumerable
        public void Show()
        {
            for(int i = _stack.Count - 1; i >= 0; i--)
            {
                Console.Write(_stack[i] + " "); 
            }
            Console.WriteLine();
        }
    }
}
