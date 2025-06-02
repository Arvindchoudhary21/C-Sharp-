/*
 * You are given a string S consisting of lowercase letters. Your task is to remove all the consecutive duplicates from
 * the string and output the result. For example, if the input string is "abbcddeff", the output should be "abcdef".
 * 
 * Input: abbcddeff
 * Output: abcdef
 */

using System;

public class Test
{
	public static void Main()
	{
		string s = Console.ReadLine();
		
		char temp = '#';
		
		string ans = "";
		for(int i=0; i<s.Length; i++)
		{
		    if(s[i] != temp)
		    {
		        ans += s[i];
		        temp = s[i];
		    }
		}
		Console.WriteLine(ans);
	}
}
