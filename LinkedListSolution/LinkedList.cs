using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSolution
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> current;//This will have latest node
        public T AddNode(T val)
        {
            Node<T> newNode  = new Node<T>(val);
           

            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                current.Next = newNode;
                current = newNode;
            }
            return val;

        }

        public LinkedList()
        {
            
        }

        public string PrintAllNodes()
        {
            string results;
            if (head == null)
            {
                results = "Head ->NULL";
                return results;
            }
            //Traverse from head
           
            results = "Head ->";
            Node<T> curr = head;
            
            results += curr.nodeVal.ToString();
            results += "->";
            while (curr.Next != null)
            {
                curr = curr.Next;
                results += curr.nodeVal.ToString();
                results += "->";
                
            }
            results += "NULL";
            return results;
        }
        public Node<T> nFromLast(int n)
        {
            int i;
            Node<T> current = head;
            //we are not traversing the list twice here, what we're doing is going 
            //through the list until we are n items into the list and then we set
            //our current node.  Then we continue through the list
            for (i = 0; i < n; i++)
            {
                if (current != null)
                {
                    current = current.Next;
                }
                else
                {
                    return null;
                }
            }
            //now we complete the iteration until we get to the end of the list.
            //at that point behind will contain our nth from the end item.
            Node<T> behind = head;
           

            while (current != null)
            {
                current = current.Next;
                behind = behind.Next;
            }
            return behind;
        }
    }
   
   
}
