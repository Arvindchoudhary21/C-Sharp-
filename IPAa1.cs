using System;
using System.Collections.Generic;

public class Course
{
    public int CourseId;
    public string courseName;
    public string courseAdmin;
    public int quiz;
    public int handson;
    public Course(int CourseId,string courseName,string courseAdmin,int quiz,int handson)
    {
        this.CourseId = CourseId;
        this.courseName = courseName;
        this.courseAdmin = courseAdmin;
        this.quiz = quiz;
        this.handson = handson;
    }
}
public class Test
{
    public static double findAvgOfQuizByAdmin(List<Course>arr,string check)
    {
        int cnt = 0;
        int sum = 0;
        for(int i=0; i<arr.Count; i++)
        {
            if(arr[i].courseAdmin == check)
            {
                cnt++;
                sum += arr[i].quiz;
            }
        }
        
        if(cnt == 0)
        {
            double d = 0;
            return d;
        }
        else
        {
            double ans = sum / cnt;
            return ans;
        }
        
        return 0.0;
        
    }
    public static List<string> sortCourseByHandsOn(List<Course>arr,int check)
    {
        List<KeyValuePair<int,string>> temp = new List<KeyValuePair<int,string>>(); 
        
        for(int i=0; i<arr.Count; i++)
        {
            if(arr[i].handson <= check)
            {
                temp.Add(new KeyValuePair<int,string>(arr[i].handson,arr[i].courseName));
            }
        }
        
        temp.Sort((a, b) => a.Key.CompareTo(b.Key));
        
        List<string> ans = new List<string>();
        foreach(var i in temp)
        {
            ans.Add(i.Value);
        }
        return ans;
        
    }
	public static void Main()
	{
		// your code goes here
		List<Course> arr = new List<Course>();
		for(int i=0; i<4; i++)
		{
		    int id = int.Parse(Console.ReadLine());
		    string cname = Console.ReadLine();
		    string cadmin = Console.ReadLine();
		    int q = int.Parse(Console.ReadLine());
		    int h = int.Parse(Console.ReadLine());
		    arr.Add(new Course(id,cname,cadmin,q,h));
		}
		string checkName = Console.ReadLine();
		int checkhandson = int.Parse(Console.ReadLine());
		
		double ans = findAvgOfQuizByAdmin(arr , checkName);
		if(ans == 0)
		{
		    Console.WriteLine("No Course found.");
		}
		else
		{
		    Console.WriteLine(ans);
		}
		
		List<string> a = sortCourseByHandsOn(arr,checkhandson);
		if(a.Count == 0)
		{
		    Console.WriteLine("No Course found with mentioned attribute.");
		}
		else
		{
		    foreach(var i in a)
		    {
		        Console.WriteLine(i);
		    }
		}
		
	}
}
