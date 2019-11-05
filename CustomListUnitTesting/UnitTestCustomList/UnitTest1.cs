using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

namespace UnitTestCustomList
{
    [TestClass]
    public class CustomListUnitTesting
    {
        [TestMethod]
        public void CustomList_Add_AddingFiveValueArrayResize()
        {
            //arrange
            CustomClassList<int> list1 = new CustomClassList<int>();
            int expected = 5;
            int actual;
            int number1 = 7;
            int number2 = 6;
            int number3 = 5;
            int number4 = 5;
            int number5 = 5;
            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            actual = list1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingFive_Double()
        {
            //arrange
            CustomClassList<double> doublelist1 = new CustomClassList<double>();
            double expected = 5.0;
            double actual;
            double double1 = 1.0;
            double double2 = 2.0;
            double double3 = 3.0;
            double double4 = 4.0;
            double double5 = 5.0;
            //act
            doublelist1.Add(double1);
            doublelist1.Add(double2);
            doublelist1.Add(double3);
            doublelist1.Add(double4);
            doublelist1.Add(double5);
            actual = doublelist1[4];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingFiveStrings()
        {
            //arrange
            CustomClassList<string> stringlist1 = new CustomClassList<string>();
            string expected = "test5";
            int actual;
            string string1 = "test1";
            string string2 = "test2";
            string string3 = "test3";
            string string4 = "test4";
            string string5 = "test5";
            //act
            stringlist1.Add(string1);
            stringlist1.Add(string2);
            stringlist1.Add(string3);
            stringlist1.Add(string4);
            stringlist1.Add(string5);
            actual = stringlist1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Swap_List()
        {
            //arrange
            CustomClassList<int> list1 = new CustomClassList<int>();
            int expected = 8;
            int actual;

            //act
            list1.Add(4);
            list1.Add(4);
            list1.Add(4);
            list1.Add(4);
            actual = list1.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Based_On_Boolean()
        {
            //arrange
            CustomClassList<string> list1 = new CustomClassList<string>();
            bool expected = true;
            bool actual;
            bool trueTest = true;

            //act
            list1.Add(trueTest);
            actual = list1[0];


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
