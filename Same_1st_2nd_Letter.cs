/*Count the number of words in a sentence that start and end with the same letter.

Input: Anna asked about the Ginseng recipe
Output: 2

Explanation: There are two words in the sentence that start and end with the same letter - "Anna" and "Ginseng". */

using System;
using System.Linq;
using System.Collections.Generic;

class Test
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] arr = s.Split(' ');
        int ans = 0;   
        for(int i=0; i<arr.Length; i++)
        {
            int sz = arr[i].Length;
            if(char.ToLower(arr[i][0]) == char.ToLower(arr[i][sz-1]))
            {
                ans++;
            }
            // Console.WriteLine(arr[i][0] + " " + arr[i][sz-1]);
        }
        Console.WriteLine(ans);
        
    }
}
