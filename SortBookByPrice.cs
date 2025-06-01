/*
test case:
101
The Alchemist
Paulo Coelho
499.99
102
Clean Code
Robert C. Martin
899.00
103
Atomic Habits
James Clear
399.50
104
Rich Dad Poor Dad
Robert Kiyosaki
299.99


ouptut 
104 Rich Dad Poor Dad Robert Kiyosaki 299.99
103 Atomic Habits James Clear 399.5
101 The Alchemist Paulo Coelho 499.99
102 Clean Code Robert C. Martin 899
*/ 


using System;
using System.Linq;
using System.Collections.Generic;

class Book
{
    public int id;
    public string title;
    public string author;
    public double price;
    
    public Book(int id, string title, string author, double price)
    {
        this.id = id;
        this.title = title;
        this.author = author;
        this.price = price;
    }
    public int getId()
    {
        return id;
    }
    public double getPrice()
    {
        return price;
    }
    public string getName()
    {
        return title;
    }
    public string getAuthor()
    {
        return author;
    }
}

class Test
{
    public static void Main()
    {
        Book[] arr = new Book[4];
        for(int i=0; i<4; i++)
        {
            int id = int.Parse(Console.ReadLine());
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            arr[i] = new Book(id , title , author , price);
        }
        Book temp = null;
        for(int i=0; i<4; i++)
        {
            for(int j = i; j<4; j++)
            {
                if(arr[i].getPrice() > arr[j].getPrice())
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        for(int i=0; i<4; i++)
        {
            Console.Write(arr[i].getId() + " " + arr[i].getName() + " " + arr[i].getAuthor() + " " + arr[i].getPrice() + "\n");
        }
    }
}
