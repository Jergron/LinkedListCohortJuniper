using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        public string objName;
        public string obj2Name;

        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return next; }
            set
            {
                if (this == value)
                {
                    throw new ArgumentException();
                }
                next = value;
            }
        }

        private string value;
        

        public string Value 
        {
            get { return value; }
        }

     
        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public static implicit operator string (SinglyLinkedListNode v)
        {
            return null;
        }

        public SinglyLinkedListNode(string value)
        {
            this.value = value;

            // Used by the visualizer:
            allNodes.Add(this);
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            SinglyLinkedListNode objectRef = obj as SinglyLinkedListNode;

            if (obj == null)
            {
                return 0;
            }      
           else
            {
                return Value.CompareTo(objectRef.Value);
            }
          
        }

        public bool IsLast()
        {
            return (Next == null);        
        }

        public override string ToString()
        {
            return value;
        }


        public override bool Equals(object obj)
        {
            SinglyLinkedListNode objectRef = obj as SinglyLinkedListNode;

            if( objectRef == null)
            {
                return false;
            }
            return Value.Equals(objectRef.Value); 
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

    }
}
