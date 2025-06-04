/* Find largest word from a given sentence
 * 
 Input: He is so funny boy
 Output: funny
 */

using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		// your code goes here
		string s = Console.ReadLine();
		string[] arr = s.Split(' ');
		int maxi = 0;
		string ans = "";
		foreach(var i in arr)
		{
		    if(i.Length > maxi)
		    {
		        maxi = i.Length;
		        ans = i;
		    }
		}
		Console.WriteLine(ans);
	}
}
