namespace ConsoleApp2.DataStructures;

/**
872. Leaf-Similar Trees
Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a leaf value sequence.

For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).
Two binary trees are considered leaf-similar if their leaf value sequence is the same.
Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.

Example 1:


Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
Output: true
Example 2:

Input: root1 = [1,2,3], root2 = [1,3,2]
Output: false

Constraints:

The number of nodes in each tree will be in the range [1, 200].
Both of the given trees will have values in the range [0, 200].

 */
public class LeafSimilarTrees
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> leaves1 = new List<int>();
        List<int> leaves2 = new List<int>();
        traverse(root1, leaves1);
        traverse(root2, leaves2);
        if (leaves1.Count != leaves2.Count) return false;
        for (int i = 0; i < leaves1.Count; i++)
        {
            if (leaves1[i] != leaves2[i]) return false;
        }
        return true;
    }

    public void traverse(TreeNode? root, List<int> leaves)
    {
        if (root == null)
            return;
        if (root.left == null && root.right == null)
        {
            leaves.Add(root.val);
            return;
        }

        traverse(root.right, leaves);
        traverse(root.left, leaves);
    }
}