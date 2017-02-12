using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup a linked list of integers 
            //Nodes can contain integers or strings (to fulfill requirements of both
            //parts of question.  We process the integer list first
            LinkedList<int> intList = new LinkedList<int>();
            Console.WriteLine("Show Integer List:");
            intList.AddNode(12);
            intList.AddNode(34);
            intList.AddNode(55);
            intList.AddNode(33);
            intList.AddNode(18);
            intList.AddNode(11);
            intList.AddNode(19);
            intList.AddNode(44);
            intList.AddNode(23);
            intList.AddNode(7);
            intList.AddNode(29);
            intList.AddNode(59);
            //Print the Integer Linked List for Reference
            string results = intList.PrintAllNodes();
            Console.WriteLine(results);
            //setup node to hold nth element from end
            Node<int> foundIntNode;
            //run the nFromLast routine to find the node 5th from the end and then 
            //output the data
            foundIntNode = intList.nFromLast(5);
            Console.WriteLine("5th Value from Last: {0}", foundIntNode.nodeVal);
            //Inject a user response so data can be reviewed
            Console.ReadLine();

            //now we create a new linked list to hold string values to show that 
            //functionality.  The nFromLast call will work on both types of linked
            //lists 
            LinkedList<string> stringList = new LinkedList<string>();
            Console.WriteLine("Start String List:");
            stringList.AddNode("Marty");
            stringList.AddNode("Donn");
            stringList.AddNode("Annie");
            stringList.AddNode("Mike");
            stringList.AddNode("April");
            stringList.AddNode("Lucas");
            stringList.AddNode("Jacob");
            stringList.AddNode("Fran");
            stringList.AddNode("Char");
            stringList.AddNode("Pat");
            stringList.AddNode("Douglas");
            stringList.AddNode("David");
            stringList.AddNode("Jason");
            stringList.AddNode("Malcolm");
            stringList.AddNode("Susan");
            //Print the Sting Linked List for reference
            results = stringList.PrintAllNodes();
            Console.WriteLine(results);
            Node<string> foundStringNode;
            //run the nFromLast routine to find the node 5th from the end and write out
            //the response
            foundStringNode = stringList.nFromLast(5);
            Console.WriteLine("5th Value from Last: {0}", foundStringNode.nodeVal);
            Console.ReadLine();
        }
    }
}
