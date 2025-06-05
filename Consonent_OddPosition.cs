/* Find the characters in odd position of a string which are consonent
 * 
 * Input: Arijit Ghosh
 * Output: hs
 */
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Test
    {
        
    	public static void Main()
    	{
    	    string s = Console.ReadLine();
    	    string ans = "";
    	    for(int i=0; i<s.Length; i++)
    	    {
    	        char c = char.ToLower(s[i]);
    	        if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || i % 2 == 1 || c == ' ')
    	        {
    	            continue;
    	        }
    	        
    	        ans += s[i];
    	    }
    	    Console.WriteLine(ans);
    	}
    }
