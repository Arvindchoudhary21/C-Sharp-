/*
find maximum number of guest on ship at all time like at any time find the maximum number of people on ship
*/

using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        Console.Write("Enter number of time = ");
        int n = int.Parse(Console.ReadLine());
        
        //arrays for entry and exit
        List<int> entry = new List<int>();
        List<int> exit = new List<int>();
        
        for(int i=0; i<n; i++)
        {
            Console.Write("Entry " + (i+1) + " = ");
            int time = int.Parse(Console.ReadLine());
            entry.Add(time);
        }
        for(int i=0; i<n; i++)
        {
            Console.Write("Exit " + (i+1) + " = ");
            int time = int.Parse(Console.ReadLine());
            exit.Add(time);
        }
        
        //List for difference in each time
        int rem = 0;
        List<int> diff = new List<int>();
        for(int i=0; i<n; i++)
        {
            rem = rem + (entry[i] - exit[i]);
            diff.Add(rem);
        }
        
        int maxi = 0;
        for(int i=0; i<n; i++)
        {
            //this prints the number of people at different time frame
            Console.Write(diff[i] + " ");
            maxi = Math.Max(maxi , (int)diff[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Maximum number of guests on cruise at an instance : " + maxi);
        
    }
}
