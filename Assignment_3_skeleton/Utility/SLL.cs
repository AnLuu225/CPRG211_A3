using Assignment_3_skeleton.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{

    [Serializable]
    public class SLL : LinkedListADT
    {
        private Node head;

        private int count;

        public SLL()
        {
            head = null;
            count = 0;
        }

        [Serializable]
        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }
            public Node(object data)
            {
                Data = data;
                Next = null;
            }
        }

            public void Append(object data)
            {

                var node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                var curr = head;
                while (curr.Next != null)
                    curr = curr.Next;
                curr.Next = node;
            }
                count++;
            }

        public void Prepend(object data)
        {
            var node = new Node(data);
            head = node;
            node.Next = head;
            count++;
        }
        public void Clear()
        {
            head = null;
            count = 0;
        }

        public bool Contains(object data)
        {
            return IndexOf(data) != -1;
        }

        public int IndexOf(object data)
        {
            var curr = head;
            int index = 0;
            while (curr != null)
            {
                if (curr.Data.Equals(data))
                    return index;
                curr = curr.Next;
                index++;
            }
            return -1; // Not found
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of bounds");
            if (index == 0)
                {
                head = head.Next;
            }
            else
            {
                var curr = head;
                for (int i = 0; i < index - 1; i++)
                {
                    curr = curr.Next;
                }
                curr.Next = curr.Next?.Next;
            }
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException("Index out of bounds");
            var node = new Node(data);
            if (index == 0)
            {
                node.Next = head;
                head = node;
            }
            else
            {
                var curr = head;
                for (int i = 0; i < index - 1; i++)
                {
                    curr = curr.Next;
                }
                node.Next = curr.Next;
                curr.Next = node;
                count++;
            }
        }

        public bool IsEmpty() => count == 0;

        public void Replace(object data, int index)
        {
           if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of bounds");
            var curr = head;
            for (int i = 0; i < index; i++)
            {
                curr = curr.Next;
            }
            curr.Data = data;
        }

        public object Retrieve(int index)
        {
           if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of bounds");
            var curr = head;
            for (int i = 0; i < index; i++)
            {
                curr = curr.Next;
            }
            return curr.Data;
        }

        public int Size() => count;
    }
}
