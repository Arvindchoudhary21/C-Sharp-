/*
 *Input : 1 2 4 8 9 11 12 14
 *Output : 3 5 6 7 10 13
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		Dictionary<int,int> d = new Dictionary<int,int>();
		int maxi = 0;

        string s = Console.ReadLine();
        int[] arr = s.Split(' ').Select(int.Parse).ToArray();
        
        for(int i=0; i<arr.Length; i++)
        {
            if(d.ContainsKey(arr[i]) == false)
            {
                d[arr[i]] = 1;
            }
            maxi = Math.Max(maxi , arr[i]);
        }
        
        for(int i=1; i<=maxi; i++)
        {
            if(d.ContainsKey(i) == false)
            {
                Console.Write(i + " ");
            }
        }
        
        
		
	}
}
