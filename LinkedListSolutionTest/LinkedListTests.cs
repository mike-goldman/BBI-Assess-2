using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListSolution;

namespace LinkedListSolutionTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestAddIntegerNode()
        {
            //Assign
            LinkedList<int> myList = new LinkedList<int>();
            var expected = 13;

            // Act


            //Assert
            Assert.AreEqual(expected, myList.AddNode(13));

        }
        [TestMethod]
        public void TestAddStringNode()
        {
            //Assign
            LinkedList<string> myList = new LinkedList<string>();
            var expected = "Joseph";

            // Act


            //Assert
            Assert.AreEqual(expected, myList.AddNode("Joseph"));
        }
        [TestMethod]
        public void TestStringNodeLinks()
        {
            //Assign
            LinkedList<string> myList = new LinkedList<string>();
            var expected = "Head ->Joseph->Max->NULL";

            // Act
            myList.AddNode("Joseph");
            myList.AddNode("Max");


            //Assert
            Assert.AreEqual(expected, myList.PrintAllNodes());
        }
        [TestMethod]
        public void TestIntegerNodeLinks()
        {
            //Assign
            LinkedList<int> myList = new LinkedList<int>();
            var expected = "Head ->13->24->NULL";

            // Act
            myList.AddNode(13);
            myList.AddNode(24);


            //Assert
            Assert.AreEqual(expected, myList.PrintAllNodes());

        }
        public void TestReturnNthString()
        {
            //Assign
            LinkedList<string> myList = new LinkedList<string>();
            var expected = "Lucas";

            // Act
            myList.AddNode("Mike");
            myList.AddNode("April");
            myList.AddNode("Lucas");
            myList.AddNode("Jacob");
            myList.AddNode("Fran");
            myList.AddNode("Char");
            myList.AddNode("Pat");

            var actual = myList.nFromLast(5);

            //Assert
            Assert.AreEqual(expected, actual.nodeVal);
        }
        [TestMethod]
        public void TestReturnNthInteger()
        {
            //Assign
            LinkedList<int> myList = new LinkedList<int>();
            var expected = "11";

            // Act
            myList.AddNode(33);
            myList.AddNode(18);
            myList.AddNode(11);
            myList.AddNode(19);
            myList.AddNode(44);
            myList.AddNode(23);
            myList.AddNode(7);

            var actual = myList.nFromLast(5);
            //Assert
            Assert.AreEqual(expected, actual.nodeVal.ToString());

        }

    }
}
