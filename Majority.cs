// Majority of an element means if an element is present in an array for more than n/2 times, 
//  where n is the length of the Array
//  Array = {3, 3, 4, 2, 4, 4, 2, 4, 4} => 4

using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        int[] arr = {3, 3, 4, 2, 4, 4, 2, 4, 4};
        int n = arr.Length;

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 1;
            else
                freq[num]++;

            if (freq[num] > n / 2)
            {
                Console.WriteLine("Majority element is: " + num);
                return;
            }
        }

        Console.WriteLine("No majority element found.");
    }
}
