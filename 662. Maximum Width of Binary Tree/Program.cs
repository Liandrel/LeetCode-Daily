List<int?[]> arrays = new()
{
    new int?[] { 1},
    new int?[] {1,3,2,5,3,null,9},
    new int?[] { 1, 3, 2, 5, null, null, 9, 6, null, 7 },
    new int?[] { 1, 3, 2, 5 }
};



foreach (var arr in arrays)
{
    BinaryTree tree = BinaryTree.CreateBinaryTree(arr);

    var x = CountMaximumWidth(tree.Root);

}


int CountMaximumWidth(BinaryTreeNode root)
{
    if (root == null)
        return 0;

    int maxWidth = 0;
    Queue<(BinaryTreeNode node,int position)> queue = new();
    queue.Enqueue((root, 1));


    while(queue.Any())
    {
        int currentMinPosition = 0;
        int currentMaxPosition = 0;

        var levelNodesCount = queue.Count;

        for(int i = 0; i <levelNodesCount; i++)
        {
            (var node, var position) = queue.Dequeue();

            if (node.Left != null)
                queue.Enqueue((node.Left, position * 2 - 1));
            if (node.Right != null)
                queue.Enqueue((node.Right, position * 2));
            if (i == 0)
                currentMinPosition = position;

            if (i + 1 == levelNodesCount)
                currentMaxPosition = position;


        }

        maxWidth = Math.Max(maxWidth,currentMaxPosition - currentMinPosition + 1);
    }

    return maxWidth;
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

