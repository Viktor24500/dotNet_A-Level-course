using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_lab1
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (node.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = new Node<T>(data);
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node<T>(data);
                }
                else
                {
                    Right.Add(data);
                }
            }
        }

        public bool Contains(T data)
        {
            var node = new Node<T>(data);

            if (node.CompareTo(Data) == 0)
            {
                return true;
            }
            else if (node.CompareTo(Data) < 0 && Left != null)
            {
                return Left.Contains(data);
            }
            else if (node.CompareTo(Data) > 0 && Right != null)
            {
                return Right.Contains(data);
            }
            return false;
        }

        private int CompareTo(T data)
        {
            return Data.CompareTo(data);
        }
    }
}
