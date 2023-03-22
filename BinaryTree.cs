using System;
using System.Collections.Generic;

public class TreeNode
{
    public int val; // The value of the node
    public TreeNode left; // The left child of the node
    public TreeNode right; // The right child of the node
    public TreeNode(int x) 
    {
        val = x; // Constructor for initializing the node value
    }
}

public class BinaryTree
{
    public TreeNode root; // The root node of the binary tree

    // Function to print the binary tree in BFS order
    public void PrintBFS(TreeNode root, int height)
    {
        if (root == null)
        {
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int level = 0; // The current level of the tree
        int nodesAtLevel = 1; // The number of nodes at the current level
        int nodesAtNextLevel = 0; // The number of nodes at the next level
        int nodeWidth = (int)Math.Pow(2, height - level) - 1; // The width of each node in the current level

        while (queue.Count > 0)
        {
            if (level > height)
            {
                break;
            }

            // Print spaces to center the node
            Console.Write(new string(' ', nodeWidth / 2));

            // Print the nodes at the current level
            for (int i = 0; i < nodesAtLevel; i++)
            {
                TreeNode node = queue.Dequeue();

                // If the node is not null, print its value and enqueue its children
                if (node != null)
                {
                    Console.Write("{0}", node.val);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                    nodesAtNextLevel += 2;
                }
                // If the node is null, print 'N' and enqueue two null nodes for its children
                else
                {
                    Console.Write("N");
                    queue.Enqueue(null);
                    queue.Enqueue(null);
                    nodesAtNextLevel += 2;
                }

                // Print spaces to center the next node
                Console.Write(new string(' ', nodeWidth));
            }

            Console.WriteLine();

            // Update the variables for the next level
            nodesAtLevel = nodesAtNextLevel;
            nodesAtNextLevel = 0;
            level++;

            // Update the width of each node for the next level
            nodeWidth = (int)Math.Pow(2, height - level) - 1;
        }
    }
}

public class Program
{
    public static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // Create a binary tree
        tree.root = new TreeNode(0);
        tree.root.left = new TreeNode(1);
        tree.root.right = new TreeNode(2);
        tree.root.left.left = new TreeNode(3);
        tree.root.left.right = new TreeNode(4);
        tree.root.right.left = new TreeNode(5);
        tree.root.right.right = new TreeNode(6);
        tree.root.left.left.left = new TreeNode(7);
        tree.root.left.left.right = new TreeNode(8);
        tree.root.left.right.left = new TreeNode(9);
        tree.root.right.right.left = new TreeNode(10);

        // Print the binary tree in BFS order
        tree.PrintBFS(tree.root, 4);
    }
}

