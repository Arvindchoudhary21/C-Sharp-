/* Input: "Hello@123World456"

Process:
Array: ["Hello", "@", "123", "World", "456"]
Now you should concatenate all the strings in the array and multiply it with the sum of the position of that array where 
numbers are stored.
Sum of positions of numbers in the array = 3 + 5 = 8
Concatenated string = "Hello@123World456"
Result = 8 * "Hello@123World456" = "Hello@123World456Hello@123World456Hello@123World456Hello@123World456Hello@123World456
Hello@123World456Hello@123World456Hello@123World456"

Output:
"Hello@123World456Hello@123World456Hello@123World456Hello@123World456Hello@123World456Hello@123World456Hello@123World456
Hello@123World456"

*/



using System;
using System.Linq;
using System.Collections.Generic;

class Test
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string num = "";
        string alpha = "";
        string special = "";
        List<string> arr = new List<string>();
        for(int i=0; i<s.Length; i++)
        {
            if((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
            {
                if(num.Length > 0)
                {
                    arr.Add(num);
                    num = "";
                }
                if(special.Length > 0)
                {
                    arr.Add(special);
                    special = "";
                }
                alpha += s[i];
            }
            else if(s[i] >= '0' && s[i] <= '9')
            {
                if(alpha.Length > 0)
                {
                    arr.Add(alpha);
                    alpha = "";
                }
                if(special.Length > 0)
                {
                    arr.Add(special);
                    special = "";
                }
                num += s[i];
            }
            else
            {
                if(alpha.Length > 0)
                {
                    arr.Add(alpha);
                    alpha = "";
                }
                if(num.Length > 0)
                {
                    arr.Add(num);
                    num = "";
                }
                special += s[i];
            }
        }
        if(num.Length > 0) arr.Add(num);
        else if(alpha.Length > 0) arr.Add(alpha);
        else arr.Add(special);
        
        //find index where there is number and sum them
        int sum = 0;
        for(int i=0; i<arr.Count; i++)
        {
            string temp = arr[i];
            if(char.IsDigit(temp[0]) == true)
            {
                sum += (i+1);
            }
        }
        Console.WriteLine(sum);
        
        string ans = "";
        for(int i=1; i<=sum; i++)
        {
            ans += s;
        }
        Console.WriteLine("ans is = " + ans);
        
        
    }
}


// 137 ans me diya h but 136 character mera aa rha pata nhi kyu maybe wo hi wrong kiya h kuch ok
