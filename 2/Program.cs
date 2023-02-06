using System;
class Program
{
    static void Main()
    {
        Console.Write("Input : ");
        double inputXC = double.Parse(Console.ReadLine());
        double inputYC = double.Parse(Console.ReadLine());
        double inputXP = double.Parse(Console.ReadLine());
        double inputYP = double.Parse(Console.ReadLine());
        Console.Write("input amount: ");
        double amount = double.Parse(Console.ReadLine());
        Circle(inputXC,inputYC,inputXP,inputYP,amount);
        
        
    }
    static void Circle(double XC, double YC , double XP, double YP,double amount)
    {
       double NewXC = 0;
       double NewYC = 0;
       double radian = Math.Atan((YP-YC)/(XP-XC));
       double distance = Math.Sqrt(Math.Pow(YP-YC,2)+Math.Pow(XP-XC,2));
       for(int i = 1 ;i<=amount; i++)
       {
        NewXC = XC;
        NewYC = YC;
         XC = XC+(distance/(2*i))*Math.Cos(radian+(radian*2*i));
         YC = YC+(distance/(2*i))*Math.Sin(radian+(radian*2*i));
         XP = NewXC+(distance/(Math.Pow(2,i-1)))*Math.Cos(radian+(radian*2*i));
         YP = NewYC+(distance/(Math.Pow(2,i-1)))*Math.Sin(radian+(radian*2*i));
       }
       Console.WriteLine(XC);
       Console.WriteLine(YC);
       Console.WriteLine(XP);
       Console.WriteLine(YP);
    }
    
}