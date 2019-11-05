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
        public int Count { get; }
        T[] items = new T[1];
        private int capacity { get; set; }
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
            items[Capacity] = capacity.value * 2; //Trying to double up
        }


        // member methods
        public void SwapCapacity<T>(ref T item1, ref T item2)
        {
            T temp;
            temp = item1;
            item1 = item2;
            item2 = temp;
        }

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
