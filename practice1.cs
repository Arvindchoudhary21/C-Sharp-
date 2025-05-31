/*
input number of vehicle and wheels and find out how many 2 wheeler and how many 4 wheeler vehicles are there?
*/ 

using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        Console.Write("Enter total number of vehicles: ");
        int v = int.Parse(Console.ReadLine());

        Console.Write("Enter total number of wheels: ");
        int w = int.Parse(Console.ReadLine());
        
        if (v <= 0 || w <= 0 || w % 2 != 0 || w < 2 * v || w > 4 * v)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        
        /*
        Look at this derivation to find out the answer
        tw + fw = vehicles (v);
        2*tw + 4*fw = wheels (w);
        fw = v - tw;
        2*tw + 4*(v - tw) = w;
        2*tw + 4*v - 4*tw = w;
        4*v - w = 4*tw - 2*tw;
        4*v - w = 2*tw;
        tw = (4*v - w) / 2;
        fw = v - tw;
        */ 
        
        int tw = (4*v - w) / 2;
        int fw = v - tw;
        
        if (fw < 0 || tw < 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            Console.WriteLine("Number of 4-wheelers: " + fw);
            Console.WriteLine("Number of 2-wheelers: " + tw);
        }
    }
}
