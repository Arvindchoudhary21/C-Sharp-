/*
Test Cases
1
Nike
Sports
3000
2
Puma
Casual
2500
3
Nike
Sports
2800
4
Adidas
Formal
2700
5
Nike
Casual
3200
Sports
Nike


we need to create a class of footwear and first function will find the number of type item present like how many sport category items are present....
second function find the second highest price of a brand name like Nike brand ke jitne bhi element hai onme se second highest price find kro....

*/







using System;
using System.Collections.Generic;

public class Footwear
{
    public int id;
    public string name; 
    public string type;
    public int price;
    
    public Footwear(int id, string name, string type , int price)
    {
        this.id = id;
        this.name = name;
        this.type = type;
        this.price = price;
    }
    
    public string getName()
    {
        return name;
    }
    public string getType()
    {
        return type;
    }
    public int getPrice()
    {
        return price;
    }
}


class Test
{
    public static int getCount(Footwear[] f , string checkType)
    {
        int cnt = 0;
        for(int i=0; i<5; i++)
        {
            //not checking by case sensitive 
            if(f[i].getType().ToLower() == checkType.ToLower())
            {
                cnt++;
            }
        }
        
        return cnt;
    }
    
    
    public static int getSecondPrice(Footwear[] f , string checkName)
    {
        List<int> L = new List<int>();
        
        for(int i=0; i<5; i++)
        {
            if(f[i].getName() == checkName)
            {
                L.Add(f[i].getPrice());
            }
        }
        
        L.Sort();
        L.Reverse();
        
        
        if(L.Count >= 2)
        {
            return L[1];
        }
        else
        {
            return 0;
        }
    }
    
    
    public static void Main()
    {
        //5 size ka array jisme elements jayenge
        Footwear[] f = new Footwear[5];
        //take inputs
        for(int i=0; i<5; i++)
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string type = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            Footwear temp = new Footwear(id , name , type , price);
            f[i] = temp;
        }
        
        
        //take input of name and get count how many this name item available
        string checkType = Console.ReadLine();
        //find second highest price of this brand name 
        string checkName = Console.ReadLine();
        
        
        //to get count of checkType Category
        int count = getCount(f , checkType);
        // Console.WriteLine(count);
        if(count > 0)
        {
            Console.WriteLine("Footwear available and count is " + count);
        }
        else
        {
            Console.WriteLine("Footwear not available!!");
        }
        
        
        //to get the second highest price of name brand
        int p = getSecondPrice(f , checkName);
        
        if(p > 0)
        {
            Console.WriteLine("second highest price is = " + p);
        }
        else
        {
            Console.WriteLine("No second highest price");
        }
    }
}
