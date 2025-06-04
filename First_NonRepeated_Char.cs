/*Write a Java program to find the first non-repeated character in a given string.

Here's an example of the expected input and output:

Input string: "minimum"
Output: "n"

*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
		Dictionary<char,int> d = new Dictionary<char,int>();
		
		foreach(var i in s)
		{
		    if(d.ContainsKey(i) == false)
		    {
		        d[i] = 1;
		    }
		    else
		    {
		        d[i]++;
		    }
		}
		
		foreach(var i in s)
		{
		    if(d[i] == 1)
		    {
		        Console.WriteLine(i);
		        return;
		    }
		}
        Console.WriteLine("all are repeated");
		
		
	}
}
