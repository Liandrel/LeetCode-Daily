List<int?[]> arrays = new()
{
    new int?[] { 1, null, 1, 1, 1, null, null, 1, 1, null, 1, null, null, null, 1, null, 1 },
    new int?[] { 1, 1, 1, null, 1, null, null, 1, 1, null, 1 }
};



foreach(var arr in arrays)
{
    BinaryTree tree = BinaryTree.CreateBinaryTree(arr);

    var x = LongestZigZag(tree.Root);

}


int LongestZigZag(BinaryTreeNode root)
{
    return Math.Max(CountZigZag(root.Left, true, 0), CountZigZag(root.Right, false, 0));
}

int CountZigZag(BinaryTreeNode node, bool isLeft, int currentLength)
{
    if (node == null)
    {
        return currentLength;
    }

    if (isLeft)
    {
        return Math.Max(CountZigZag(node.Left, true, 0), CountZigZag(node.Right, false, currentLength + 1));
    }
    return Math.Max(CountZigZag(node.Left, true, currentLength + 1), CountZigZag(node.Right, false, 0));


}

public class BinaryTreeNode
{
    public int? Value;
    public BinaryTreeNode Left;
    public BinaryTreeNode Right;

    public BinaryTreeNode(int? value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public BinaryTreeNode Root;

    public BinaryTree()
    {
        Root = null;
    }

    public static BinaryTree CreateBinaryTree(int?[] arr)
    {
        BinaryTree tree = new BinaryTree();
        if (arr.Length == 0 || arr[0] == null) return tree;

        tree.Root = new BinaryTreeNode(arr[0]);
        Queue<BinaryTreeNode> nodeQueue = new();
        nodeQueue.Enqueue(tree.Root);
        int index = 1;

        while (nodeQueue.Count > 0 && index < arr.Length)
        {
            BinaryTreeNode currentNode = nodeQueue.Dequeue();

            // Assign left child
            if (index < arr.Length && arr[index] != null)
            {
                currentNode.Left = new BinaryTreeNode(arr[index]);
                nodeQueue.Enqueue(currentNode.Left);
            }
            index++;

            // Assign right child
            if (index < arr.Length && arr[index] != null)
            {
                currentNode.Right = new BinaryTreeNode(arr[index]);
                nodeQueue.Enqueue(currentNode.Right);
            }
            index++;
        }

        return tree;
    }

}

