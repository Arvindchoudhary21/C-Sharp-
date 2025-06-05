/* Count number of vowel, consonent and digit into a string */

    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Test
    {
    	public static void Main()
    	{
    	    string s = Console.ReadLine();
    	    int v = 0;
    	    int cons = 0;
    	    int num = 0;
    	    foreach(var i in s)
    	    {
    	        char c = char.ToLower(i);
    	        if(c =='a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    	        {
    	            v++;
    	        }
    	        else if(char.IsDigit(i) == true)
    	        {
    	            num++;
    	        }
    	        else
    	        {
    	            cons++;
    	        }
    	    }
    	    Console.WriteLine(v + " " + cons + " " + num);
    	}
    }
