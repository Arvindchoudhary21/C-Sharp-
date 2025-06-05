/* Write a Java program that takes a user input integer n and prints the Fibonacci series up to n.

The Fibonacci series is a series of numbers in which each number is the sum of the two preceding numbers. 
The first two numbers in the series are 0 and 1. For example, the first 10 numbers in the Fibonacci series are: 
0, 1, 1, 2, 3, 5, 8, 13, 21, 34.

The program should use a for loop to generate the series.

Sample Input:
20

Sample Output:
0 1 1 2 3 5 8 13

Explanation:
The Fibonacci series up to 20 is: 0, 1, 1, 2, 3, 5, 8, 13. Therefore, the output is "0 1 1 2 3 5 8 13". 
*/

using System;
using System.Collections.Generic;
using System.Linq;
public class Test
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int a = 0;
		int b = 1;
		if(n == 0)
		{
		    Console.WriteLine("0");
		    return;
		}
		if(n == 1)
		{
		    Console.WriteLine("0");
		    Console.WriteLine("1");
		    return;
		}
		Console.WriteLine("0");
		Console.WriteLine("1");
		while(a <= n)
		{
		    int current = a + b;
		    a = b;
		    b = current;
		    if(current <= n)
		    {
		        Console.WriteLine(current + " ");
		    }
		}
	}
}
