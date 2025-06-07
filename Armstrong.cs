/*Write a Java program to check if a given number is an Armstrong number or not.

Here's an example of the expected input and output:

Input number: 153
Output: "Yes, the number is an Armstrong number."

*/

using System;

public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
		
		int sz = s.Length;
		int sum = 0;
		for(int i=0; i<s.Length; i++)
		{
		    int num = s[i] - '0';
		    int temp = 1;
            for(int j=0; j<sz; j++)
            {
                temp = temp * num;
            }
            sum += temp;
		}
		
		if(sum == int.Parse(s))
		{
		    Console.WriteLine("it is armstrong number.");
		}
		else
		{
		    Console.WriteLine("not an armstrong number.");
		}
	}
}
