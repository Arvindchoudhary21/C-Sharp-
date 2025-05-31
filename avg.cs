/* Find average of a number array between two limit numbers (except the two numbers)
 * Input
 * ---------------
 *  5
    1 
    2
    3
    4
    5
 *  1
 *  4
 * 
 * Output
 * ---------------
 * 2
 */

using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        //size of the array
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for(int i=0; i<n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            arr[i] = x;
        }
        
        //take input of the limit numbers like between them take all numbers
        // and find the avg of them don't include this two range numbers
        int left = int.Parse(Console.ReadLine());
        int right = int.Parse(Console.ReadLine());
        
        int leftInd = -1;
        int rightInd = -1;
        for(int i=0; i<n; i++)
        {
            if(arr[i] == left)
            {
                leftInd = i;
                break;
            }
        }
        for(int i=0; i<n; i++)
        {
            if(arr[i] == right)
            {
                rightInd = i;
            }
        }

        if(leftInd == -1 || rightInd == -1)
        {
            Console.WriteLine("invalid input");
        }
        else
        {
            int nums = (rightInd - leftInd) - 1;
            if(nums >= 1)
            {
                int sum = 0;
                for(int i=leftInd+1; i<=rightInd-1; i++)
                {
                    sum += arr[i];
                }
 
                int avg = sum / nums;
                Console.WriteLine("Avg = " + avg);
            }
            else
            {
                Console.WriteLine("No elements are present between them.");
            }
        }
    }
}
