/* Remove duplicate characters in a string
 * 
 * Input : Arijit Ghosh
 * Output : Arijt Ghos
 */

using System;
using System.Linq;
using System.Collections.Generic;

class Test
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string ans = "";
        Dictionary<char,int> d = new Dictionary<char,int>();
        for(int i=0; i<s.Length; i++)
        {
            if(d.ContainsKey(s[i]) == false)
            {
                d[s[i]] = 1;
                ans += s[i];
            }
        }
        Console.WriteLine(ans);
    }
}
