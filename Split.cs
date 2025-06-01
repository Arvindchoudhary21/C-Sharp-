/*
Sample Input:
-----------------------
Enter ISBN: 978-0-13-110362-8

Sample Output:
-----------------------
GSI Prefix: 978
Group Identifier: 0
Publisher Code: 13
Item Number: 110362
Check Digit: 8

Note: The number of digits in each group may vary. You can't assume that the 
groups have the length shown in the sample output. You can test your program 
with actual ISBN values (usually found on the back cover of a book and on the 
copyright page 
*/

using System;
using System.Linq;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        Console.Write("Enter ISBN number = ");
       string s = Console.ReadLine();
       
       string[] arr = s.Split('-');
       
       if(arr.Length == 5)
       {
            int i = 0;
            Console.WriteLine("GSI Prefix: " + arr[i++]);
            Console.WriteLine("Group Identifier: " + arr[i++]);
            Console.WriteLine("Publisher Code: " + arr[i++]);
            Console.WriteLine("Item Number: " + arr[i++]);
            Console.WriteLine("Check Digit: " + arr[i++]);
       }
       else
       {
           Console.WriteLine("Invalid input");
       }
       
       
    }
}
