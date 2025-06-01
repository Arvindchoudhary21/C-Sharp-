/* Remove Vowel From A String 

 * Input : Arijit Ghosh
 * Output : rjt Ghsh
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
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == 'a' || s[i] == 'A' || s[i] == 'e' || s[i] == 'E' || s[i] == 'I' || s[i] == 'i' || s[i] == 'o' || s[i] == 'O' || s[i] == 'u' || s[i] == 'U')
            {
                continue;
            }
            ans += s[i];
        }
        
        Console.WriteLine(ans);
        
    }
}
