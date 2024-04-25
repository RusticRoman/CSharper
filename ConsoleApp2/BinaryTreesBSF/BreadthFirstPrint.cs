namespace ConsoleApp2.BinaryTreeBSF;

public class BreadthFirstPrint
{
    public BreadthFirstPrint(TreeNode node)
    {
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(node);
        while (nodes.Count > 0)
        {
            TreeNode n = nodes.Dequeue();
            Console.WriteLine(n.val);
            if (n.left != null)
            {
                nodes.Enqueue(n.left);
            }
            if (n.right != null)
            {
                nodes.Enqueue(n.right);
            }
        }
    }
}