/* Count the words in a sentence which are start with vowel. 
 * 
 * Input: Arijit is student of MCA
 * Output: 3
 * 
 * Input: Sara plays tennis
 * Output: No such words
*/
using System;
using System.Collections.Generic;
using System.Linq;
public class Test
{
	public static void Main()
	{
	    string s = Console.ReadLine();
	    string[] arr = s.Split(' ');
	    int cnt = 0;
	    foreach(var i in arr)
	    {
	        
	        char c = char.ToLower(i[0]);
	        if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
	        {
	            cnt++;
	        }
	    }
	    Console.WriteLine(cnt);
	}
}
