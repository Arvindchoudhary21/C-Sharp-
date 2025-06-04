/* Find the palindrome words from the sentence and print them and also count
 * 
 * Input:
 * ----------------
 * My name is nitin and I can speak malayalam
 * 
 * Output:
 * ----------------
 * nitin
 * I
 * malayalam
 * 3
 */

using System;

public class Test
{
    public static bool check(string s)
    {
        int i = 0;
        int j = s.Length-1;
        while(i <= j)
        {
            if(s[i] != s[j]) return false;
            
            i++;
            j--;
        }
        return true;
    }
	public static void Main()
	{
	    string s = Console.ReadLine();
	    
	    string[] arr = s.Split(' ');
	    int cnt = 0;
	    for(int i=0; i<arr.Length; i++)
	    {
	        if(check(arr[i]) == true)
	        {
	            Console.WriteLine(arr[i]);
	            cnt++;
	        }
	    }
	    Console.WriteLine(cnt);
	}
}


