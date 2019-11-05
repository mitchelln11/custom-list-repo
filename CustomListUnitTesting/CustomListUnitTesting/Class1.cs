using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTesting
{
    public class Class1
    {
        //member variables


        //constructor
        public class CustomClassList<T>
        {
            public int Count { get; }
            private int Capacity { get; set; }
            T[] items = new T[1];
        }

        //member methods
        public void Add()
        {

        }
    }

}
