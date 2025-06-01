/* Sort name by dictionary order
    Input
    -----------------
    Arijit
    Minaz
    Arnab

    Output
    -------------------
    Arijit
    Arnab
    Minaz
 */

using System;
using System.Linq;
using System.Collections.Generic;
class Test
{
    public static bool check(string s , string t)
    {
        int sz = Math.Min(s.Length , t.Length);
        int cnt = 0;
        for(int i=0; i<sz; i++)
        {
            if(s[i] == t[i])
            {
                continue;
            }
            else 
            {
                if(s[i] > t[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        return false;
    }
    public static void Main()
    {

       string[] arr = new string[3];
       for(int i=0; i<3; i++)
       {
           arr[i] = Console.ReadLine();
       }
       
    //   for(int i=0; i<3; i++)
    //   {
    //       Console.WriteLine(arr[i]);
    //   }
       
       for(int i=0; i<3; i++)
       {
           for(int j=i; j<3; j++)
           {
               if(check(arr[i],arr[j]) == true)
               {
                   //arr[i] is bigger so swap to arr[j]
                   string temp = arr[i];
                   arr[i] = arr[j];
                   arr[j] = temp;
               }
           }
       }
       
       for(int i=0; i<3; i++)
       {
           Console.WriteLine(arr[i]);
       }
       
    }
}
