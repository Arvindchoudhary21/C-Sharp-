/*
find the sum of even digits in the given input string
*/ 


using System;
using System.Linq;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
       string n = Console.ReadLine();
       int ans = 0;
       for(int i=0; i<n.Length; i++)
       {
           if((n[i] - '0') % 2 == 0)
           {
               ans += (n[i] - '0');
           }
       }
       
       Console.WriteLine("Sum of even digits is = " + ans);
    }
}
