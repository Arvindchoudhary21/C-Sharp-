/* Find number of upper case in a string
 * AriJIt = 3
 */
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Test
    {
    	public static void Main()
    	{
    	    string s = Console.ReadLine();
    	    int cnt = 0;
    	    foreach(var i in s)
    	    {
    	        if(i >= 'A' && i <= 'Z')
    	        {
    	            cnt++;
    	        }
    	    }
    	    Console.WriteLine(cnt);
    	}
    }
