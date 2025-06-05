/* Input : Home, Sweet Home
           Home
 * Output : Number of that word present in the sentence : 2
 * 
 * Process
 * ----------
 * The word Home present in the sentence 2 times
 */

using System;
using System.Collections.Generic;
using System.Linq;
public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
		string check = Console.ReadLine();
		string[] arr = s.Split(' ');
		int ans = 0;
		foreach(var st in arr)
		{
		    string temp = "";
		    foreach(var i in st)
		    {
		        if(char.IsLetter(i) == true)
		        {
		            temp += i;
		        }
		    }
		    
		    if(temp.ToLower() == check.ToLower())
		    {
		        ans++;
		    }
		}
		Console.WriteLine(ans);
	}
}
