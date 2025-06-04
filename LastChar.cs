/* Last Character of each word of a sentence

 * Input: Kalyani Government Engineering College
 * Output: itge
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
		foreach(var i in arr) 
		{
		    string t = i;
		    Console.Write(t[t.Length - 1]);
		}
		
	}
}
