public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> resultList = new List<int>();
        int index1 = 0;
        int index2 = 0;
        for (int n = 0; n < select.Count(); n++)
        {
            int number = 0;
            if (select[n] == 1)
            {
                number = RemoveAndReturnRemoved(list1, index1);
                index1++;
            }
            else
            {
                number = RemoveAndReturnRemoved(list2, index2);
                index2++;
            }
            resultList.Add(number);

        }
        return resultList.ToArray();
    }

    private static int RemoveAndReturnRemoved(int[] listToRemove, int index)
    {
        int removedItem = listToRemove[index];
        listToRemove.Where((val, idx) => idx != index).ToArray();
        return removedItem;
    }
}