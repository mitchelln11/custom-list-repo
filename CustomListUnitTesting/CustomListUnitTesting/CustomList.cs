using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassList
{
    public class CustomClassList<T>
    {
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        // Member variables
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
            items = new T[capacity];
        }

        // ---------------Custom Add Method-------------------------------------
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
        }

        // ---------------Custom Remove Method-------------------------------------
        public void Remove(T item)
        {
            T[] tempArrayVal = new T[capacity];
            for (int i = 0, j = 0; i < count; i++, j++) // If we don't loop through, all the values before this will reset to 0;
            {
                if (item.Equals(items[i]))
                {
                    j--; // Needs to be here because the j++ runs after this is done. Essentially cancels out the j for one run
                }
                else
                {
                    tempArrayVal[j] = items[i];
                }
            }
            items = tempArrayVal;
            count--;
        }

        // ---------------Operator Overloading-------------------------------------
        //public static CustomClassList<T> operator + (CustomClassList<T> l1, CustomClassList<T> l2)
        //{
        //    // Enter a value in order to remove + operator error
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i=0; i<count; i++)
            {
                sb.Append(items[i]);
            }
            return sb.ToString();
        }
    }
}
