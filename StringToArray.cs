// convert the input string to character array 

using System;
using System.Linq;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
       string s = Console.ReadLine();
       
       char[] arr = new char[s.Length];
       
       for(int i=0; i<s.Length; i++)
       {
           arr[i] = s[i];
       }
       
       Console.Write("the character array is = [ ");
       for(int i=0; i<s.Length; i++)
       {
           Console.Write(arr[i] + " ");
       }
       Console.Write("]");
       
    }
}
