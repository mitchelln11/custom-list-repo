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

        private T[] arr = new T[100];
        public int nextIndex = 0;
        public T this[int i] => arr[i]; //Indexer to allow square brackets to check index

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
                capacity *= 2; //double capacity amount
                tempArrayVal = new T[capacity]; //Create empty list
                for (int i = 0; i < count; i++) // If we don't loop through, all the values before this will reset to 0;
                {
                tempArrayVal[i] = items[i]; //set loop iteration to list
                }
                items = tempArrayVal; // assign value
            }
            items[count] = item;
            count++;

            if (nextIndex >= arr.Length)
                throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            arr[nextIndex++] = item;

        }

        //public bool Remove(T item)
        //{
        //    return true;
        //}
    }
}
