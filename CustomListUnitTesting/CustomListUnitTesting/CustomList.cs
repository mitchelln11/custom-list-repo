using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassList
{
    public class CustomClassList<T> : IEnumerable
    {
        public T this[int i] // Creates ability to check index
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
         public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i=0; i<count; i++)
            {
                sb.Append(items[i]);
            }
            return sb.ToString();
        }

        public IEnumerator GetEnumerator() //Allows you to do a foreach loop
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        public static CustomClassList<T> operator +(CustomClassList<T> list1, CustomClassList<T> list2)
        {
            CustomClassList<T> comboList = new CustomClassList<T>();
            //list1 = new CustomClassList<T>(); // Don't need to instantiate lists when they're coming through as parameters
            //list2 = new CustomClassList<T>();
            for (int i=0; i<list1.count;i++)
            {
                comboList.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                comboList.Add(list2[i]);
            }
            return comboList;
        }

        public static CustomClassList<T> operator -(CustomClassList<T> list1, CustomClassList<T> list2)
        {
            CustomClassList<T> comboList = new CustomClassList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                bool isEqual = false;
                for (int j = 0; j < list2.count; j++)
                {
                    if (list1[i].Equals(list2[j])) //Don't add to the list if equal
                    {
                        isEqual = true;
                    }
                    else if((j == list2.count-1) && (isEqual == false)){
                        comboList.Add(list1[i]);
                    }
                }
            }
            return comboList; // Must have return outside the for loops when overriding operators

        }

        public static CustomClassList<T> ZipLists(CustomClassList<T> list1, CustomClassList<T> list2)
        {
            CustomClassList<T> comboList = new CustomClassList<T>();
            for (int i = 0, j=0; i < list1.count; i++, j++)
            {
                if ( (list1[i] != null) || (list2[i] != null) )
                {
                    comboList.Add(list1[i]);
                    comboList.Add(list2[i]);
                }
            }
            return comboList;
        }
    }
}
