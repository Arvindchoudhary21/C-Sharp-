//intput = a2b3c1
//output = aabbbc

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
            if(Char.IsDigit(s[i]) == true)
            {
                for(int j=1; j<=(s[i] - '0'); j++)
                {
                    ans += s[i-1];
                }
            }
        }
        
        Console.WriteLine("ans = " + ans);
        
    }
}
