/* Count number of prime digit in a Number 
 * Input : 254786135
 * Output : 5
*/

    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Test
    {
        public static bool check(int n)
        {
            int cnt = 0;
            for(int i=1; i<=n; i++)
            {
                if(n % i == 0) cnt++;
            }
            return cnt == 2 ? true : false;
        }
    	public static void Main()
    	{
    	    string s = Console.ReadLine();
    	    int ans = 0;
    	    foreach(var i in s)
    	    {
    	        if(check(i - '0') == true)
    	        {
    	            ans++;
    	        }
    	    }
    	    Console.WriteLine(ans);
    	}
    }
