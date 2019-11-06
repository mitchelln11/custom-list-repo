﻿using System;
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
            int number3 = 4;
            int number4 = 8;
            int number5 = 9;
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
            double expected = 5;
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
            int expected = 5;
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
        public void Add_Capacity()
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
            list1.Add(4);
            actual = list1.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Based_On_Boolean()
        {
            //arrange
            CustomClassList<bool> list1 = new CustomClassList<bool>();
            bool expected = true;
            bool actual;
            bool trueTest1 = true;
            bool trueTest2 = false;
            bool trueTest3 = true;

            //act
            list1.Add(trueTest1);
            list1.Add(trueTest2);
            list1.Add(trueTest3);
            actual = list1[2];
            // If count = capacity, return true

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //----------------Remove Testing------------

        [TestMethod]
        public void CustomList_Remove_Count()
        {
            //arrange
            CustomClassList<int> list1 = new CustomClassList<int>();
            int expected = 4;
            int actual;
            //act
            list1.Add(9);
            list1.Add(8);
            list1.Add(7);
            list1.Remove(8);
            list1.Add(5);
            list1.Add(4);
            actual = list1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_Index()
        {
            //arrange
            CustomClassList<double> doublelist1 = new CustomClassList<double>();
            double expected = 3;
            double actual;

            //act
            doublelist1.Add(5.0);
            doublelist1.Add(4.0);
            doublelist1.Add(3.0);
            doublelist1.Remove(4.0);

            actual = doublelist1[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Add number 5, 10, 13, 5, 7, remove first 5 found
        //[TestMethod]
        //public void Remove_First_Instance_Of_value()
        //{
        //    //arrange
        //    CustomClassList<int> list1 = new CustomClassList<int>();
        //    int expected = 10;
        //    int actual;
        //    //act
        //    list1.Add(5);
        //    list1.Add(10);
        //    list1.Add(13);
        //    list1.Add(5);
        //    list1.Add(7);
        //    list1.Remove(5);
        //    actual = list1[0];
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
