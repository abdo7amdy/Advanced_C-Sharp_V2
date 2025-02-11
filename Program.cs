using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    #region Q1 Count numbers greater than X
    static int CountGreaterNumbers(int[] arr, int x)
    {
        return arr.Count(n => n > x);
    }
    #endregion

    #region Q2 Check if array is palindrome
    static bool IsPalindrome(int[] arr)
    {
        return arr.SequenceEqual(arr.Reverse());
    }

    #endregion

    #region Q3 Reverse a queue using a stack
    static Queue<T> ReverseQueue<T>(Queue<T> queue)
    {
        Stack<T> stack = new Stack<T>();
        while (queue.Count > 0) stack.Push(queue.Dequeue());
        while (stack.Count > 0) queue.Enqueue(stack.Pop());
        return queue;
    }

    #endregion

    #region Q4 Check balanced parentheses
    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> pairs = new Dictionary<char, char> { { ')', '(' }, { '}', '{' }, { ']', '[' } };

        foreach (char c in input)
        {
            if (pairs.Values.Contains(c)) stack.Push(c);
            else if (pairs.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != pairs[c]) return false;
            }
        }
        return stack.Count == 0;
    }

    #endregion

    #region Q5 Remove duplicates from an array
    static int[] RemoveDuplicates(int[] arr)
    {
        return arr.Distinct().ToArray();
    }

    #endregion

    #region Q6 Remove odd numbers from an ArrayList
    static List<int> RemoveOddNumbers(List<int> list)
    {
        return list.Where(n => n % 2 == 0).ToList();
    }
    #endregion

    #region Q7 Generic queue implementation
    static void GenericQueue()
    {
        Queue<object> queue = new Queue<object>();
        queue.Enqueue(1);
        queue.Enqueue("Apple");
        queue.Enqueue(5.28);
    }
    #endregion

    #region Q8 Search in stack
    static void SearchInStack(Stack<int> stack, int target)
    {
        int count = 0;
        foreach (int num in stack)
        {
            count++;
            if (num == target)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
                return;
            }
        }
        Console.WriteLine("Target was not found");
    }
    #endregion

    #region Q9 Find intersection of two arrays
    static int[] FindIntersection(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        List<int> result = new List<int>();

        // Count occurrences of elements in nums1
        foreach (int num in nums1)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        // Find intersection
        foreach (int num in nums2)
        {
            if (freq.ContainsKey(num) && freq[num] > 0)
            {
                result.Add(num);
                freq[num]--; // Decrease count to handle duplicates correctly
            }
        }

        return result.ToArray();
    }
    #endregion

    #region Q10 Find contiguous sublist with sum equal to target
    static List<int> FindContiguousSublist(List<int> list, int target)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int sum = 0;
            for (int j = i; j < list.Count; j++)
            {
                sum += list[j];
                if (sum == target) return list.GetRange(i, j - i + 1);
                if (sum > target) break;
            }
        }
        return new List<int>();
    }
    #endregion

    #region Q11 Reverse first K elements of a queue
    static Queue<int> ReverseFirstK(Queue<int> queue, int k)
    {
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < k; i++) stack.Push(queue.Dequeue());
        while (stack.Count > 0) queue.Enqueue(stack.Pop());
        for (int i = 0; i < queue.Count - k; i++) queue.Enqueue(queue.Dequeue());
        return queue;
    } 
    #endregion
}