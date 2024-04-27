using ConsoleApp2.DataStructures;

namespace ConsoleApp2;

public class Program1
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        var left2 = new TreeNode(4);
        var right2 = new TreeNode(5);
        var left3 = new TreeNode(6);
        var right3 = new TreeNode(7);
        var left1 = new TreeNode(2, left2, right2);
        var right1 = new TreeNode(3, left3, right3);
        var root = new TreeNode(1, left1, right1);

        var b = new BreadthFirstPrint(root);
    }
}