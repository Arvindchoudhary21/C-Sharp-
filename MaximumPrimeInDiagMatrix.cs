/* 12 4 8
    5 7 6
    4 8 13
    
    Maxumum prime of the 2 diagonals 13
*/ 

using System;
using System.Collections.Generic;

public class Test
{
    public static bool check(int n)
    {
        int cnt = 0;
        for(int i=1; i<=n; i++)
        {
            if(n % i == 0)
            {
                cnt++;
            }
        }
        if(cnt > 2) return false;
        return true;
    }
	public static void Main()
	{
		// your code goes here
		int[,] arr = new int[3,3];
		
		for(int i=0; i<3; i++)
		{
		    for(int j=0; j<3; j++)
		    {
		        int n = int.Parse(Console.ReadLine());
		        arr[i , j] = n;
		    }
		}
		
		List<int> a = new List<int>();
		for(int i=0; i<3; i++) a.Add(arr[i,i]);
		for(int i=0; i<3; i++) a.Add(arr[i,3-1-i]);
		
		int ans = 0;
		foreach(var i in a)
		{
		    if(check(i) == true)
		    {
		        ans = Math.Max(ans , i);
		    }
		}
		Console.WriteLine(ans);
		

	}
}
