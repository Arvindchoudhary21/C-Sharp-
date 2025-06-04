/* Find the occurance of each character in a string
 * Input: Hello world
 * Output:
 *  H: 1
    e: 1
    l: 3
    o: 2
    w: 1
    r: 1
    d: 1
*/

using System;
using System.Collections.Generic;
using System.Linq;
public class Test
{
	public static void Main()
	{
	    string s = Console.ReadLine();
	    SortedDictionary<char,int> d = new SortedDictionary<char,int>();
	    
	    for(int i=0; i<s.Length; i++)
	    {
	        if(s[i] == ' ') continue;
	        if(d.ContainsKey(s[i]) == false)
	        {
	            d[s[i]] = 1;
	        }
	        else
	        {
	            d[s[i]]++;
	        }
	    }
	    
	    foreach(var it in d)
	    {
	        Console.WriteLine(it.Key + " " + it.Value);
	    }
		
	}
}
