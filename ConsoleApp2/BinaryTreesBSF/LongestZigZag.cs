namespace ConsoleApp2.DataStructures;

public class LongestZigZag
{
    public int LongestZigZagSolution(TreeNode? root)
    {
        if (root == null) return 0;
        
        int a = maxZigZag(root.left, false, 1);
        
        int b = maxZigZag(root.right, true, 1);
        
        return Math.Max(a, b);
    }

    public int maxZigZag(TreeNode? node, bool directionRight, int length)
    {
        if (node == null) return length-1;
        int leftLength, rightLength;
        // Handling the left child
        if (directionRight) {
            // If the previous direction was to the right, now go left
            leftLength = maxZigZag(node.left, false, length + 1);
        } else {
            // If the previous direction was to the left, continue from 1 (reset)
            leftLength = maxZigZag(node.left, false, 1);
        }
        // Handling the right child
        if (!directionRight) {
            // If the previous direction was to the left, now go right
            rightLength = maxZigZag(node.right, true, length + 1);
        } else {
            // If the previous direction was to the right, continue from 1 (reset)
            rightLength = maxZigZag(node.right, true, 1);
        }
        return Math.Max(leftLength, rightLength);
    }
}