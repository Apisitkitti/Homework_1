using System;
class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        double input = double.Parse(Console.ReadLine());
        Console.WriteLine(Cal(input));
    }
    static double Cal(double input)
    {
        double sol = 0;
        double ans = 0;
        if(input >-1 && input<=0)
        {
            sol = 1-Math.Pow(input,2);
            ans = Math.Sqrt(sol);
            return ans;
        }
        if(input >0 && input<=1)
        {
            sol = 1-Math.Pow(input,2);
            ans = -1*Math.Sqrt(sol);
            return ans; 
        }
        if(input <= -1)
        {
            ans = Cal(input+2);
            return ans;
        }
        else
        {
            ans = Cal(input-2);
            return ans;
        }
    }
}
