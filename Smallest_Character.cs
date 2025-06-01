/* Minimum Ascii valued character in a String 
input 
hello
ouptut
e
*/

using System;
using System.Linq;
using System.Collections.Generic;

class Test
{
    public static void Main()
    {
        string s = Console.ReadLine();
        int mini = s[0] - 'a';
        char c = s[0];
        for(int i=0; i<s.Length; i++)
        {
            if((s[i] - 'a') < mini)
            {
                mini = (s[i] - 'a');
                c = s[i];
            }
        }
        
        Console.WriteLine(c);
    }
}
