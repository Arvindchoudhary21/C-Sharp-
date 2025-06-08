using System;
using System.Collections.Generic;

public class Employee
{
    public int empId;
    public string name;
    public string branch;
    public double rating;
    public bool transport;
    public Employee(int empId,string name, string branch,double rating,bool transport)
    {
        this.empId = empId;
        this.name = name;
        this.branch = branch;
        this.rating = rating;
        this.transport = transport;
    }
}


public class Test
{
    public static int count(List<Employee> arr , string checkBranch)
    {
        int cnt = 0;
        for(int i=0; i<arr.Count; i++)
        {
            if(arr[i].branch == checkBranch)
            {
                if(arr[i].transport == true)
                {
                    cnt++;
                }
            }
        }
        return cnt;
    }
    public static Employee findsecond(List<Employee> arr)
    {
        List<double> temp = new List<double>();
        for(int i=0; i<arr.Count; i++)
        {
            if(arr[i].transport == false)
            {
                temp.Add(arr[i].rating);
            }
        }
        
        temp.Sort();
        double ss = 0;
        double highest = temp[temp.Count - 1];
        for(int i=temp.Count-1; i>=0; i--)
        {
            // Console.WriteLine(temp[i]);
            if(temp[i] != highest)
            {
                ss = temp[i];
            }
        }
        
        for(int i=0; i<arr.Count; i++)
        {
            if(arr[i].rating == ss)
            {
                return arr[i];
            }
        }
        return null;
    }
	public static void Main()
	{
	    List<Employee> arr = new List<Employee>();
		for(int i=0; i<4; i++)
		{
		    int id = int.Parse(Console.ReadLine());
		    string n = Console.ReadLine();
		    string b = Console.ReadLine();
		    double r = double.Parse(Console.ReadLine());
		    bool t = bool.Parse(Console.ReadLine());
		    arr.Add(new Employee(id , n , b , r , t));
		}
		
		string checkBranch = Console.ReadLine();
		int ans1 = count(arr , checkBranch);
		Console.WriteLine(ans1);
		
		Employee dd = findsecond(arr);
		Console.WriteLine(dd.empId);
		Console.WriteLine(dd.name);
	}
}
