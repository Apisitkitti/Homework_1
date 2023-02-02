using System;
class Program
{
    static void Main()
    {
      Console.Write("Input number : "); 
      double input = double.Parse(Console.ReadLine());
      Console.WriteLine(Cal(input));  
    }
    static double Cal(double input)
    {
      double ans = 0;
      if(Math.Pow(input,2) > 4)
      {
        ans = 1+Cal(input-(4*Math.Abs(input))/input);
        return ans;
      }
      else 
      {
        return ans = 2;
      }
    }
}
