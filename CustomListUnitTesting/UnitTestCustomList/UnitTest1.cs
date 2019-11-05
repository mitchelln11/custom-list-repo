using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTesting;

namespace UnitTestCustomList
{
    [TestClass]
    public class CustomListUnitTesting
    {
        [TestMethod]
        public void Custom_List_Adding_Values()
        {
            //arrange
            CustomClassList<int> intList1 = new CustomClassList<int>();
            int expected = 1;
            int actual;
            int number1 = 5; // Reference in 

            //act
            actual = intList1.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
