/* Count number of spaces and characters in a string 
 * Input
 * ---------
 * Arijit is bad boy
 * 
 * Output
 * ------------------
 * Number of space : 3
   Number of character : 14
*/

using System;
using System.Linq;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {

       string s = Console.ReadLine();
       
       int spaces = 0;
       for(int i=0; i<s.Length; i++)
       {
           if(s[i] == ' ')
           {
               spaces++;
           }
       }
       
       Console.WriteLine("Number of spaces is = " + spaces);
       Console.WriteLine("Number of Characters is = " + (s.Length - spaces));
       
    }
}
