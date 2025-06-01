/*
Problem Statement
Write a Java program to print the unique characters present in the given string in the same sequence as they appear(the first occurrence) in the input.

Note:
All the characters should be in lowercase only.

i/p -> 
xperience

o/p -> 
xperinc
*/

using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        string s = Console.ReadLine();
        
        Dictionary<char,int> d = new Dictionary<char,int>();
        string ans = "";
        for(int i=0; i<s.Length; i++)
        {
            if(!d.ContainsKey(s[i]))
            {
                ans += (s[i]);
                d[s[i]] = 1;
            }
        }
        
        Console.WriteLine(ans);
    }
}
