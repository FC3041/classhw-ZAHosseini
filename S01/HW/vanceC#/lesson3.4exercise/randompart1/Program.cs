using System;
namespace randompart1;

public class Program
{
    public static double monte_carlo(double n){
        Random rand = new Random(); 
            double circle = 0; 

            for (int i = 0; i < n; i++)
            {
                
                double x = rand.NextDouble();
                double y = rand.NextDouble();
                if (x * x + y * y < 1)
                {
                    circle++;
                }
            }
            double PI = (circle / n) * 4;
            return PI;
    }
    public static void Main()
    {
        double n=1000000;
        Console.WriteLine(monte_carlo(n));
        
    }
}
