// Find the first non repeated character substring
//Arijit = Arij

using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
		Dictionary<char,int> d = new Dictionary<char,int>();
		string ans = "";
		foreach(var i in s)
		{
		    if(d.ContainsKey(i) == false)
		    {
		        d[i] = 1;
		        ans += i;
		    }
		    else
		    {
		        d[i]++;
		        break;
		    }
		}
		
		Console.WriteLine(ans);
		
		
	}
}
