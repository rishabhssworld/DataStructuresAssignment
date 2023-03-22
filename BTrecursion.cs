using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Console.WriteLine("Pre-order traversal:");
            tree.Preorder(0);
            Console.WriteLine();
            Console.WriteLine("In-order traversal:");
            tree.Inorder(0);
            Console.WriteLine();
            Console.WriteLine("Post-order traversal:");
            tree.Postorder(0);
            Console.WriteLine();
        }
    }
    class Tree
    {
        /// <summary>
        /// a function for printing the Preorder
        /// </summary>
        /// <param name="n"></param>
        public void Preorder(int n)
        {
            if (n > 9)
            {
                return;
            }

            Console.Write(n + " "); //root
            Preorder(2 * n + 1); //left node
            Preorder(2 * n + 2); //right node
        }
        /// <summary>
        /// a function for printing the Inorder
        /// </summary>
        /// <param name="n"></param>
        public void Inorder(int n)
        {
            if (n > 9)
            {
                return;
            }

            Inorder(2 * n + 1); //left subtree
            Console.Write(n + " "); //root
            Inorder(2 * n + 2); //right subtree
        }
        /// <summary>
        /// a function for printing the Postorder
        /// </summary>
        /// <param name="n"></param>
        public void Postorder(int n)
        {
            if (n > 9)
            {
                return;
            }
            Postorder(2 * n + 1);//left subtree
            Postorder(2 * n + 2);//right subtree
            Console.Write(n + " ");//root
        }
    }
}
