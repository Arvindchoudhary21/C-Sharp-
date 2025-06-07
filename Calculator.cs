/*
Write a Java program to implement a simple calculator. The program should prompt the user to enter two numbers and an 
operator (+, -, *, or /) and then perform the corresponding operation and display the result.

For example, if the user enters 4, 5, and +, the program should display 9 as the result. Similarly, if the user enters 10, 3, 
and *, the program should display 30 as the result.

Your program should handle invalid inputs gracefully, for example, if the user enters an operator that is not one of the four 
allowed operators or if the user enters non-numeric inputs. 
*/
using System;

public class Test
{
	public static void Main()
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		string op = Console.ReadLine();
		
		if(op[0] == '+')
		{
		    Console.WriteLine(a + b);
		}
		else if(op[0] == '-')
		{
		    Console.WriteLine(a - b);
		}
		else if(op[0] == '*')
		{
		    Console.WriteLine(a * b);
		}
		else if(op[0] == '/')
		{
		    Console.WriteLine(a / b);
		}
		else
		{
		    Console.WriteLine("invalid operator.");
		}
	}
}
