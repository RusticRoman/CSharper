using System;
using ConsoleApp2.DataStructures;

namespace ConsoleApp2;

public class Program1
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        TreeNode left2 = new TreeNode(4);
        TreeNode right2 = new TreeNode(5);
        TreeNode left3 = new TreeNode(6);
        TreeNode right3 = new TreeNode(7);
        TreeNode left1 = new TreeNode(2, left2, right2);
        TreeNode right1 = new TreeNode(3, left3, right3);
        TreeNode root = new TreeNode(1, left1, right1);
        
        var b = new BreadthFirstPrint(root);
    }
}