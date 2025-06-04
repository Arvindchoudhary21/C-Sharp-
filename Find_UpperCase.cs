/*Given a sentence, Find words that start with a capital letter.

For example, in the sentence "The quick Brown Fox jumps over the lazy dog", there are three words that start with a 
capital letter: "The", "Brown", and "Fox". */

using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
		
		string[] arr = s.Split(' ');
		
		foreach(var i in arr)
		{
		    if(i[0] >= 'A' && i[0] <= 'Z')
		    {
		        Console.WriteLine(i);
		    }
		}
		
		
	}
}
