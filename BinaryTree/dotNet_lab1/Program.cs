using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            //Add subscription to events
            int[] items = new int[] { 1, 9, 2 };
            binaryTree.Add(items[0]);
            binaryTree.itemAdd += (sender, e) => { Console.WriteLine(e.Data); };
            binaryTree.Add(items[1]);
            binaryTree.Add(items[2]);
            binaryTree.Add(12);
            binaryTree.Add(15);
            binaryTree.Add(4);
            binaryTree.Add(3);

            Console.WriteLine("PreOrder Traversal:");
            foreach (var item in binaryTree.PreOrder())
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            foreach (var item in binaryTree.InOrder())
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            foreach (var item in binaryTree.PostOrder())
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            Console.WriteLine("PreOrder Traversal after balance:");
            binaryTree.BalanceTree();
            foreach (var item in binaryTree.PreOrder())
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();
            Console.WriteLine($"Tree containce \"25\" " + binaryTree.Contains(25));
            Console.WriteLine($"Tree containce \"3\" " + binaryTree.Contains(3));
            Console.ReadKey();
        }
    }
}