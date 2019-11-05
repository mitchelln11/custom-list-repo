using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTesting
{
    public class CustomClassList<T>
    {
        private T[] items;
        private int capacity;
        private int count;

        public int Count
        {
            get 
            {
                return count;    
            }
        }
        public CustomClassList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity]; //Setting array inside CustomClassList
        }
    }
}
