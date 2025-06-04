/*
arr1 = 1234
arr2 = 3456
common 34 use dictionary
*/ 

using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		int[] arr1 = new int[4];
		int[] arr2 = new int[4];
		Dictionary<int,int> d = new Dictionary<int,int>();
		for(int i=0; i<4; i++)
		{
		    int x = int.Parse(Console.ReadLine());
		    arr1[i] = x;
		    if(d.ContainsKey(x) == false)
		    {
		        d[x] = 1;
		    }
		}
		for(int i=0; i<4; i++)
		{
		    int x = int.Parse(Console.ReadLine());
		    arr2[i] = x;
		    if(d.ContainsKey(x) == true)
		    {
		        Console.WriteLine(x);
		    }
		}
		
		
		
	}
}
