/* Input : 123Arijit1998Arijit10

 * Process :
 * -----------
 * Array : [123, Arijit, 1998, Arijit, 10]
 * Now you should sum up the position of that array where numbers are stored.
 * 123 + 1998 = 2121
 * 
 * Output :
 * --------------
 * 2131
 */
using System;
using System.Linq;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
       string s = Console.ReadLine();
       
       int num = 0;
       int sum = 0;
       for(int i=0; i<s.Length; i++)
       {
           if(Char.IsDigit(s[i]) == true)
           {
               num = (num * 10) + (s[i] - '0');
           }
           else
           {
               sum += num;
               num = 0;
           }
       }
       if(num > 0)
       {
           sum += num;
       }
       
       Console.WriteLine("Sum of all numbers is = " + sum);
    }
}
