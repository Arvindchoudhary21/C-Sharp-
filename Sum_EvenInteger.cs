/* Write a function that takes a list of numbers as input and returns the sum of all the even numbers in the list.

For example:

Enter size of Array: 4
Create an array:
10 15 20 25
The array is: [10, 15, 20, 25]
Sum of even numbers in the array: 30

 */

using System;
using System.Collections.Generic;
using System.Linq;
class Test
{
    public static void Main()
    {
       //size of array
       Console.Write("Enter size of array = ");
       int n = int.Parse(Console.ReadLine());
       
      int[] arr = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
        
        int sum = 0;
        for(int i=0; i<n; i++)
        {
            if(arr[i] % 2 == 0)
            {
                sum += arr[i];
            }
        }
        Console.WriteLine("sum of even elements is = " + sum);

    }
}
