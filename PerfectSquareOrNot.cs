using System;
public class Test
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		
		int num = (int)Math.Sqrt(n);
		
		if(num * num == n)
		{
		    Console.WriteLine("perfect square");
		}
		else
		{
		    Console.WriteLine("not a perfect square");
		}
	}
}
