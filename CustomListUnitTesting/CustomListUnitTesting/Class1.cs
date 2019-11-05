using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTesting
{
    public class CustomClassList<T>
    {
        public int Count { get; }
        private int Capacity { get; set; }
        T[] items = new T[1];
    }
    //constructor


    //member methods
    public void Add(T item)
    {
        items[0] = item;

    }

    public bool Remove(T item)
    {

        return true;
    }
}
}
