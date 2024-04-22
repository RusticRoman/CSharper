using System;

namespace ConsoleApp2.BinaryTreeDSF;

public class CountGoodNodesinBinaryTree
{
    int count = 0;
    public int GoodNodes(TreeNode root) {
        CountGoodNodes(root, Int32.MinValue);
        return count;
    }

    public void CountGoodNodes(TreeNode? node, int maxVal) {
        if(node == null) return;
        if(node.val >= maxVal){
            count++;
            maxVal = node.val;
        }
        CountGoodNodes(node.left, maxVal);
        CountGoodNodes(node.right, maxVal);
    }
}