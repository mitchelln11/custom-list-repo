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

        // ---------------toSting Overloading-------------------------------------


    }
    // ---------------Operator Overloading-------------------------------------
    //public class CustomClassList2<T>
    //{
    //    // For overriding operators
    //    public int number1, number2;
    //    public CustomClassList2(int num1, int num2)
    //    {
    //        // For overriding operators
    //        number1 = num1;
    //        number2 = num2;
    //    }

    //    public static CustomClassList2<T> operator -(CustomClassList2<T> c1)
    //    {
    //        c1.number1 = -c1.number1;
    //        c1.number2 = -c1.number2;
    //        Console.WriteLine("Number1" + c1.number1);
    //        Console.ReadLine();
    //        return c1;
    //    }
    //}
}
