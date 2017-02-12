using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSolution
{
    public class Node<T>
    {
        public Node<T> Next;
        public T nodeVal { get; set; }
        public Node(T value) { nodeVal = value; }
    }
}
