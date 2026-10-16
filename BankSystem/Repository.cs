using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Repository<T>
    {
        T[] arr;
        int count;
        public Repository(int size)
        {
            arr = new T[size];
            count = 0;
        }
        public void Add(T item)
        {
            if(count < arr.Length)
                arr[count++] = item;
            else
                Console.WriteLine("The Stack is full...");
        }

        public T Get(int index)
        {
            if(index >= 0 && index < count)
            {
                return arr[index];
            }
            else
            {
                return default;
            }
        }

        public void Display()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
