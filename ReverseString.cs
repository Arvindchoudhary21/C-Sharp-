/* Reverse of a string
 * Arijit = tijirA
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
        for(int i=s.Length-1; i>=0; i--)
        {
            ans += s[i];
        }
        
        Console.WriteLine(ans);
        
    }
}
