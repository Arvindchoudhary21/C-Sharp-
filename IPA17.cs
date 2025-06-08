using System;
using System.Collections.Generic;

public class Student
{
    private int rollNo;
    public string name;
    public string subject;
    public char grade;
    public string date;
    
    public Student(int rollNo,string name,string subject,char grade,string date)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.subject = subject;
        this.grade = grade;
        this.date = date;
    }
    public int getRollNO()
    {
        return rollNo;
    }
}


public class Test
{
    
   public static List<Student> f1(List<Student>arr, char checkGrade,int month)
   {
       List<Student> temp = new List<Student>();
       
       for(int i=0; i<arr.Count; i++)
       {
           if(arr[i].grade == checkGrade)
           {
                string d = arr[i].date;
                string[] a = d.Split('/');
                int mm = int.Parse(a[1]);
                if(month == mm)
                {
                    temp.Add(arr[i]);
                }
           }
       }
       
       temp.Sort((a , b) => a.getRollNO().CompareTo(b.getRollNO()));
       return temp;
   }
    
	public static void Main()
	{
	    List<Student> arr = new List<Student>();
		for(int i=0; i<4; i++)
		{
		    int r = int.Parse(Console.ReadLine());
		    string n = Console.ReadLine();
		    string s = Console.ReadLine();
		    char c = char.Parse(Console.ReadLine());
		    string d = Console.ReadLine();
		    arr.Add(new Student(r , n , s , c , d));
		}
		
		char checkGrade = char.Parse(Console.ReadLine());
		int month = int.Parse(Console.ReadLine());
		
		List<Student> ans = f1(arr , checkGrade , month);
		for(int i=0; i<ans.Count; i++)
		{
		    Console.WriteLine(ans[i].name);
		    Console.WriteLine(ans[i].subject);
		}
	}
}
