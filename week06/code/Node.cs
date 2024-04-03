public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Data is root
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        else
        {
            // equality case
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // here, we just need to compare with the values and go down the tree since it's already sorted
        if (value < Data)
        {
            // null means it hasnt found an equality
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else if (value > Data)
        {
            // null means it hasnt found an equality
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
        else if (value == Data)
        {
            // equality case
            return true;
        }
        // just in case
        return Left == null || Right == null;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        // this one's hard, sir hahaha

        return 0; // Replace this line with the correct return statement(s)
    }
}