/* Remove a character from a string
 * Input
 * --------------
 * Arijit
 * i
 * Output
 * ---------------
 * Arjt
 */

using System;

public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
		string t = Console.ReadLine();
		
		string ans = "";
		for(int i=0; i<s.Length; i++)
		{
		    if(s[i] == t[0])
		    {
		        continue;
		    }
		    ans += s[i];
		}
		
		Console.WriteLine(ans);
	}
}
