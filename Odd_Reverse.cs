/* Take a number. If it odd then reverse it, otherwise print "Can not reverse"
 * 
 * Input : 123
 * Output : 321
 * 
 * Input : 234
 * Output : Can not reverse
 */

using System;
using System.Linq; 

public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
        int n = int.Parse(s);
        if(n % 2 == 0)
        {
            Console.WriteLine("cannot reverse");
        }
        else
        {
            string t = "";
            for(int i=s.Length-1; i>=0; i--) t += s[i];
            Console.WriteLine(t);
        }
	}
}
