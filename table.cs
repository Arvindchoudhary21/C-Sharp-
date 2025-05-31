/*
 * Write a Java program that takes two user input integers m and n and prints the multiplication table from 1 to n for the 
 * number m. The program should use nested for loops to generate the table.
 * 
 * Sample Input:
 * --------------------
 * 3 5
 * 
 * Sample Output:
 * --------------------
 *  3 x 1 = 3
    3 x 2 = 6
    3 x 3 = 9
    3 x 4 = 12
    3 x 5 = 15

 * Explanation:
   --------------------
   The input integers are m=3 and n=5. The program generates the multiplication table for 3 from 1 to 5. 

 */

using System;

class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        
        for(int i=0; i<m; i++)
        {
            Console.WriteLine(n + " * " + (i+1) +  " = " + (n * (i+1)));
        }
    }
}
