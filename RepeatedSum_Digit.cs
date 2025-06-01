/* Calculate the sum of all digits of a numbers. If the sum is greater than 9 then again sum the digits. The sum is 
continuing until the sum becomes one digit.

Input : 195
Output : 6

Explanation: 1+9+5 =15>9, so 1+5=6 */

using System;
using System.Linq;
using System.Collections.Generic;

class Test
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long ans = 0;
        while(n > 9)
        {
            long sum = 0;
            while(n > 0)
            {
                sum += (n % 10);
                n = n / 10;
            }
            if(sum > 9)
            {
                n = sum;
            }
            else
            {
                ans = sum;
                break;
            }
        }
        
        Console.WriteLine("ans = " + ans);
        
    }
}
