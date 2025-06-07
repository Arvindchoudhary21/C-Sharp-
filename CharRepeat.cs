// aabbbcc = a2b3c2
// abbccc = a1b2c3

using System;

public class Test
{
	public static void Main()
	{
		string s = (Console.ReadLine());
		s += '#';
		char c = s[0];
		int count = 1;
// 		Console.WriteLine(c);
        int cnt = 0;
		for(int i=0; i<s.Length; i++)
		{
		  //  cnt++;
		  //  Console.WriteLine(s[i]);
		    if(s[i] != c)
		    {
		        Console.Write(c + "" + count);
		        count = 1;
		        c = s[i];
		    }
		    else
		    {
		        count++;
		    }
		}
// 		Console.WriteLine(cnt);
	}
}
