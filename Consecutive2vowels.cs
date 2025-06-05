/*Count the number of words in a sentence that contain at least two consecutive vowels (a, e, i, o, u) in them.
Here's a sample input and output:

Input: I enjoy eating spaghetti and meatballs for dinner
Output: 2

Explanation: There are two words in the sentence that contain at least two consecutive vowels - "enjoy" and "meatballs".
 */

    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Test
    {
        
        public static bool check(char c)
        {
            if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    	    {
    	        return true;
    	    }
    	        
    	    return false;
        }
        
    	public static void Main()
    	{
    	    string s = Console.ReadLine();
    	    int ans = 0;
    	    string[] arr = s.Split(' ');
    	    
    	    
    	    foreach(var st in arr)
    	    {
    	        int cnt = 0;
    	        for(int i=0; i<st.Length; i++)
    	        {
    	            if(check(st[i]) == true)
    	            {
    	                cnt++;
    	            }
    	            else
    	            {
    	                cnt = 0;
    	            }
    	            
    	            if(cnt >= 2)
    	            {
    	                ans++;
    	            }
    	        }
    	    }
    	    
    	    
    	    Console.WriteLine(ans);
    	}
    }
