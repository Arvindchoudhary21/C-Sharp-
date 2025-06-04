/* Find the Maximum Ascii valued character in a String
 * Arijit = t
 * priyanka = y
 * Aa = a
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
	    char ans = ' ';
	    int maxi = 0;
	    for(int i=0; i<s.Length; i++)
	    {
	        if(s[i] > ans)
	        {
	           ans = s[i];
	        }
	    }
	    Console.WriteLine(ans);
	}
}
