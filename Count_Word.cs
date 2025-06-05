/* Count number of word in a string
*Note : Always ignore the spaces if more than 1 space given between two word

Sample Input : 1
------------------------
Kalyani Goverment Engineering College

Process
---------------------------
[Kalyani, Goverment, Engineering, College]

Output
---------------------------
Number of word : 4
*************************************
Sample Input : 2
------------------------
Kalyani Goverment  Engineering College

Process
---------------------------
[Kalyani, Goverment, , Engineering, College]

Output
---------------------------
Number of word : 4
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
    	    Console.WriteLine(arr.Length);
    	}
    }


