/* Find occurance of a character in a string
    Input
    --------------
 *  Priyanka
 *  a
 
 *  Output
    ----------------
 *  2
 */

using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string check = Console.ReadLine();
        int cnt = 0;
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == check[0])
            {
                cnt++;
            }
        }
        if(cnt > 0)
        {
            Console.WriteLine("Character appeared = " + cnt + " times");
        }
        else
        {
            Console.WriteLine("Character not appeared in string");
        }
    }
}
