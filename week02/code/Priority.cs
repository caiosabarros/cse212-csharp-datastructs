public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
        // Expected Result: 
        // [hi (Pri:0), hi (Pri:1)]
        Console.WriteLine("Test 1");
        for (int n = 0; n < 2; n++)
        {
            priorityQueue.Enqueue("hi", n);
        }
        // check Queue
        Console.WriteLine(priorityQueue.ToString());

        // clean up
        for (int n = 0; n < 2; n++)
        {
            priorityQueue.Dequeue();
        }

        // Defect(s) Found: 
        Console.WriteLine("---------");

        // Test 2
        // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: 
        // [hi (Pri:0), hi (Pri:1), hi (Pri:0), hi (Pri:1), hi (Pri:2), hi (Pri:3), hi (Pri:4), hi (Pri:5), hi (Pri:6), hi (Pri:7), hi (Pri:8), hi (Pri:9)]
        // hi 
        // After: [hi (Pri:0), hi (Pri:1), hi (Pri:0), hi (Pri:1), hi (Pri:2), hi (Pri:3), hi (Pri:4), hi (Pri:5), hi (Pri:6), hi (Pri:7), hi (Pri:8)]
        Console.WriteLine("Test 2");
        for (int n = 0; n < 10; n++)
        {
            priorityQueue.Enqueue("hi", n);
        }
        Console.WriteLine($"Before: {priorityQueue.ToString()}");
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine($"After: {priorityQueue.ToString()}");

        // clean up
        for (int n = 0; n < 9; n++)
        {
            priorityQueue.Dequeue();
        }

        // Defect(s) Found: 
        // 1. The Dequeue function was not removing the element from the Queue.
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: 
        // [hi (Pri:0), hi (Pri:1), hi (Pri:0), hi (Pri:1), hi (Pri:2), hi (Pri:3), hi (Pri:4), hi (Pri:5), hi (Pri:6), hi (Pri:7), hi (Pri:8), hi (Pri:9)]
        // hi 
        // After: [hi (Pri:0), hi (Pri:1), hi (Pri:0), hi (Pri:1), hi (Pri:2), hi (Pri:3), hi (Pri:4), hi (Pri:5), hi (Pri:6), hi (Pri:7), hi (Pri:8)]
        Console.WriteLine("Test 3");
        for (int n = 0; n < 10; n++)
        {
            priorityQueue.Enqueue("hi", n);
        }
        Console.WriteLine($"Before: {priorityQueue.ToString()}");
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine($"After: {priorityQueue.ToString()}");

        // clean up
        for (int n = 0; n < 9; n++)
        {
            priorityQueue.Dequeue();
        }

        // Defect(s) Found: 
        // 1. The Dequeue function was trying to find the highestpriority element by couting up to _queue.Count - 1, whereas it should count up to _queue.Count;

        Console.WriteLine("---------");

        // Test 4
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 4");
        // try removing from empty Queue
        priorityQueue.Dequeue();
        Console.WriteLine("---------");
        // Defect(s) Found: 

    }
}