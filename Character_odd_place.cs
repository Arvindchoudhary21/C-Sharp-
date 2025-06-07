/* Find Characters of a string at odd index
 * Arijit = rjt
 * priyanka = ryna
*/

using System;

public class Test
{
	public static void Main()
	{
		string s = (Console.ReadLine());
		
		string ans = "";
		for(int i=0; i<s.Length; i++)
		{
		    if(i%2 == 1)
		    {
		        ans += s[i];
		    }
		}
		Console.WriteLine(ans);
	}
}
