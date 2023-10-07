using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_lab1
{
    public class BinaryTree<T> : ICollection<T> where T : IComparable<T>
    {
        public event EventHandler<Events<T>> itemAdd;
        public event EventHandler<Events<T>> itemContaince;
        public event EventHandler itemClean;
        public Node<T>? Root { get; set; }
        public int Count { get; set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (IsReadOnly == true)
            {
                //change console to exception
                throw new Exception("coolection is readonly");
            }
            if (item == null)
            {
                throw new ArgumentNullException("item can't be null");
            }

            if (Root == null)
            {
                Root = new Node<T>(item);
                Count = 1;
                itemAdd?.Invoke(item, new Events<T>(item));
                return;
            }
            Root.Add(item);
            itemAdd?.Invoke(item, new Events<T>(item));
            Count++;
        }

        public void Clear()
        {
            Count = 0;
            Root = null;
            itemClean?.Invoke(this, EventArgs.Empty);
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item can't be null");
            }
            if (Root != null)
            {
                bool find = Root.Contains(item);
                if (find == true)
                {
                    itemContaince?.Invoke(this, new Events<T>(item));
                }
                return find;
            }
            return false;
        }

        public bool Remove(T item)
        {
            return false;
        }

        public void BalanceTree()
        {
            var InOrderList = InOrder();
            T[] sortArray = InOrderList.ToArray();
            Root = BalanceBST(sortArray, 0, sortArray.Length - 1);
            Count = sortArray.Length;
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The destination array cannot be null");
            }
            if (arrayIndex < 0)
            {
                throw new IndexOutOfRangeException("Index can't be negative");
            }
            if (array.Length-arrayIndex < Count)
            {
                throw new Exception("The destination array hasn't enough free space");
            }
            CopyTo(Root, array, ref arrayIndex);
        }

        private Node<T> BalanceBST(T[] sortArray, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = (left + right) / 2;
            Node<T> newNode = new Node<T>(sortArray[mid]);

            newNode.Left = BalanceBST(sortArray, left, mid - 1);
            newNode.Right = BalanceBST(sortArray, mid + 1, right);

            return newNode;
        }

        public MyList<T> InOrder()
        {
            if (Root == null)
            {
                return new MyList<T>();
            }

            return TraverseInOrder(Root);
        }

        public MyList<T> PreOrder()
        {
            if (Root == null)
            {
                return new MyList<T>();
            }

            return TraversePreOrder(Root);
        }

        public MyList<T> PostOrder()
        {
            if (Root == null)
            {
                return new MyList<T>();
            }

            return TraversePostOrder(Root);
        }

        //Preorder traversal is defined as a type of tree
        //traversal that follows the Root-Left-Right 
        private MyList<T> TraversePreOrder(Node<T> item)
        {
            MyList<T> list = new MyList<T>();
            if (item != null)
            {
                list.Add(item.Data);
                if (item.Left != null)
                {
                    list.AddItems(TraversePreOrder(item.Left));
                }

                if (item.Right != null)
                {
                    list.AddItems(TraversePreOrder(item.Right));
                }
            }
            return list;
        }

        //An inorder traversal first visits the left child (including its entire subtree)
        //then visits the node, and finally visits the right child (including its entire subtree)
        private MyList<T> TraverseInOrder(Node<T> item)
        {
            MyList<T> list = new MyList<T>();
            if (item != null)
            {
                if (item.Left != null)
                {
                    list.AddItems(TraverseInOrder(item.Left));
                }

                list.Add(item.Data);

                if (item.Right != null)
                {
                    list.AddItems(TraverseInOrder(item.Right));
                }
            }
            return list;
        }

        //Postorder Traversal (left-right-current) — Visit the current node
        //after visiting all the nodes of left and right subtrees
        private MyList<T> TraversePostOrder(Node<T> item)
        {
            MyList<T> list = new MyList<T>();
            if (item != null)
            {
                if (item.Left != null)
                {
                    list.AddItems(TraversePostOrder(item.Left));
                }

                if (item.Right != null)
                {
                    list.AddItems(TraversePostOrder(item.Right));
                }

                list.Add(item.Data);
            }
            return list;
        }

        private void CopyTo(Node<T> node, T[] array, ref int arrayIndex)
        {
            if (node != null)
            {
                array[arrayIndex++] = node.Data;
                CopyTo(node.Left, array, ref arrayIndex);
                CopyTo(node.Right, array, ref arrayIndex);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return PreOrder().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
