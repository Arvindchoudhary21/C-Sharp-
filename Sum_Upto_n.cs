/*
Write a Java program that takes a user input integer n and calculates the sum of the first n natural numbers.

The program should use a for loop to calculate the sum.

Sample Input:
---------------------
5

Sample Output:
---------------------
The sum of first 5 natural numbers is 15.

Explanation:
---------------------
The first 5 natural numbers are: 1, 2, 3, 4, 5
Their sum is: 1 + 2 + 3 + 4 + 5 = 15

*/

using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
       int n = int.Parse(Console.ReadLine());
       int sum = 0;
       for(int i=1; i<=n; i++)
       {
           sum += i;
       }
       
       Console.WriteLine("sum of first " + n + " numbers = " + sum);
    }
}
