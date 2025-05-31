/*
find difference of star and hash
*/

using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        string s = Console.ReadLine();
        
        int star = 0;
        int hash = 0;
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == '*') star++;
            else hash++;
        }
        Console.WriteLine(star + " " + hash);
        Console.WriteLine(star - hash);
        
    }
}
