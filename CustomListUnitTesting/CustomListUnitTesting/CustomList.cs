using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassList
{
    public class CustomClassList<T>
    {
        //member variables
        //public int Count { get; }
        private int count;
        T[] items;

        public int Count 
        {
            get 
            {
                return count;
            }
        }
        private int capacity;
        public int Capacity //Pulls value from private version of capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        //constructor
        public CustomClassList()
        {
            capacity = 4;
            items = new T[capacity]; //Trying to double up

        }


        // member methods
        //public void SwapCapacity<T>(ref T item1, ref T item2)
        //{
        //    T temp;
        //    temp = item1;
        //    item1 = item2;
        //    item2 = temp;
        //}

        //public CustomClassList()
        //{
        //    Count = 0;
        //}
        public void Add(T item)
        {
            if (count == capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {

            }
        }

        //public bool Remove(T item)
        //{
        //    return true;
        //}
    }
}
