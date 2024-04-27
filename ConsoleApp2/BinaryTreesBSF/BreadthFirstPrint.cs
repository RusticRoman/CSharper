namespace ConsoleApp2.DataStructures;

public class BreadthFirstPrint
{
    public BreadthFirstPrint(TreeNode node)
    {
        var nodes = new Queue<TreeNode>();
        nodes.Enqueue(node);
        while (nodes.Count > 0)
        {
            var n = nodes.Dequeue();
            Console.WriteLine(n.val);
            if (n.left != null) nodes.Enqueue(n.left);

            if (n.right != null) nodes.Enqueue(n.right);
        }
    }
}