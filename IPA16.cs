using System;
using System.Collections.Generic;

public class NavalVessel
{
    public int vesselId;
    public string vesselName;
    public int noofPlanned;
    public int noofCompleted;
    public string purpose;
    public NavalVessel(int vesselId,string vesselName, int noofPlanned,int noofCompleted,string purpose)
    {
        this.vesselId = vesselId;
        this.vesselName = vesselName;
        this.noofPlanned = noofPlanned;
        this.noofCompleted = noofCompleted;
        this.purpose = purpose;
    }
}


public class Test
{
    
    public static double f1(List<NavalVessel>arr, double check)
    {
        int sum = 0;
        int cnt = 0;
        for(int i=0; i<arr.Count; i++)
        {
            int comp = arr[i].noofCompleted;
            int plan = arr[i].noofPlanned;
            double p = ((comp * 100) / plan);
            if(p >= check)
            {
                sum += arr[i].noofCompleted;
                cnt++;
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
        
        double dd = 0;
        return dd;
    }
    
    public static string f2(List<NavalVessel>arr, string check)
    {
        int sum = 0;
        int cnt = 0;
        for(int i=0; i<arr.Count; i++)
        {
            if(arr[i].purpose == check)
            {
                int comp = arr[i].noofCompleted;
                int plan = arr[i].noofPlanned;
                double p = ((comp * 100) / plan);
                
                if(p == 100)
                {
                    string ans = "";
                    ans += arr[i].vesselName;
                    ans += " ";
                    ans += "Star";
                    return ans;
                }
                else if(p >= 55 && p <= 79)
                {
                    string ans = "";
                    ans += arr[i].vesselName;
                    ans += "%";
                    ans += "Inspirer";
                    return ans;
                }
                
            }
            
        }
        
        string temp = "";
        return temp;
        
        
    }
    
	public static void Main()
	{
	    List<NavalVessel> arr = new List<NavalVessel>();
		for(int i=0; i<4; i++)
		{
		    int id = int.Parse(Console.ReadLine());
		    string n = Console.ReadLine();
		    int planned = int.Parse(Console.ReadLine());
		    int completed = int.Parse(Console.ReadLine());
		    string p = (Console.ReadLine());
		    arr.Add(new NavalVessel(id,n,planned,completed,p));
		}
		
		double check = double.Parse(Console.ReadLine());
		string check2 = Console.ReadLine();
		
		double ans1 = f1(arr , check);
		Console.WriteLine(ans1);
		
		string ans2 = f2(arr , check2);
		Console.WriteLine(ans2);
		
	}
}
