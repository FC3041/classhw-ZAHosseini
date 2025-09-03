using System;
namespace mathpart1;

public class Program
{
    public static double pi_by_area(double n){
        double h;
        double total=0;
        double x1;
        double x2;
        double y1;
        double y2;
        double PI;
        h=1/n;
        for(int i=0;i<n;i++){
            x1=i*h;
            x2=(i+1)*h;
            y1=Math.Sqrt(1-x1*x1);
            y2=Math.Sqrt(1-x2*x2);
            total+=0.5*(y1+y2)*h;


        }
        PI=total*4;
        return PI;

    }
    public static void Main()
    {
       double n=10;
       double n2=100;
       Console.WriteLine(pi_by_area(n));
       Console.WriteLine(pi_by_area(n2));


    }
}
