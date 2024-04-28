using ConsoleApp2.DataStructures;

public class CountGoodNodesinBinaryTree
{
    private int count;

    public int GoodNodes(TreeNode root)
    {
        CountGoodNodes(root, int.MinValue);
        return count;
    }

    public void CountGoodNodes(TreeNode? node, int maxVal)
    {
        if (node == null) return;
        if (node.val >= maxVal)
        {
            count++;
            maxVal = node.val;
        }

        CountGoodNodes(node.left, maxVal);
        CountGoodNodes(node.right, maxVal);
    }
}