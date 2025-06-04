/* Find the index number of a character in a String
 * Input1 :
 --------------
  Carrot
  a
 
 * Output:
 ---------------
   1

 * Input2:
 ----------------
   Carrot
   z

 * Output:
  --------------
   NA
 */

using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
		
        string check = Console.ReadLine();
        
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == check[0])
            {
                Console.WriteLine(i);
                return;
            }
        }
        
        Console.WriteLine("not found");
		
		
	}
}
