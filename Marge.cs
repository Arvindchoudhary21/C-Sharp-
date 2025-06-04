/* Marge two strings using comma

Input: 
Arijit,Ghosh
Pop:Mom

Output:
Arijit, Ghosh, Pop:Mom
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		// your code goes here
		string a = Console.ReadLine();
		string b = Console.ReadLine();
		string c = Console.ReadLine();
		string ans = a;
		ans += ",";
		ans += b;
		ans += ",";
		ans += c;
		Console.WriteLine(ans);
	}
}
