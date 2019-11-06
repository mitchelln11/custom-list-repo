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
            count = 0;
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
            T[] tempArrayVal;
            if (count == capacity)
            {
                capacity *= 2;
                tempArrayVal = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                tempArrayVal[i] = items[i];
                }
                items = tempArrayVal;
            }
            items[count] = item;
            count++;
            
        }

        //public bool Remove(T item)
        //{
        //    return true;
        //}
    }
}
