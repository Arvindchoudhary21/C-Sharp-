/* Group the employees by city 

 * Input:
 * ----------------
4
a
kolkata
b
kolkata
c
mumbai
d
ara

 * Output:
 * ----------------
kolkata = a b 
mumbai = c 
ara = d 
 */

using System;
using System.Linq;
using System.Collections.Generic;

class Test
{
    public static void Main()
    {
        // Console.Write("Enter number of person = ");
        int n = int.Parse(Console.ReadLine());
        Dictionary<string , List<string>> d = new Dictionary<string,List<string>>();
        for(int i=0; i<n; i++)
        {
            string name = Console.ReadLine();
            string city = Console.ReadLine();
            if(!d.ContainsKey(city))
            {
                d[city] = new List<string>();
            }
            d[city].Add(name);
        }
        
        foreach(var entry in d)
        {
            Console.Write(entry.Key + " = ");
            
            List<string> arr = entry.Value;
            foreach(var it in arr)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
        }
        
    }
}


