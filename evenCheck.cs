/* Count number of even digit in a number
 * If the count greater than or equal to 3, then print "True" otherwise "False"
 */

using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int even = 0;
        while(n > 0)
        {
            int last = n % 10;
            if(last % 2 == 0)
            {
                even++;
            }
            n = n / 10;
        }
        if(even >= 3)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
