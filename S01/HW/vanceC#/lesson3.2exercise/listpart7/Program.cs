using System;
namespace listpart7;

public class Program
{
    public static int calculator(){
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        string str=Console.ReadLine();
        if(str=="+"){
            return num1+num2;
        }
        else if(str=="*"){
            return num1*num2;
        }
        else if(str=="-"){
            return num1-num2;
        }
        else if(str=="/"){
            return num1/num2;
        }
        else{
            return -1;
        }
    }
    public static void Main()
    {
        Console.WriteLine(calculator());
    }
}
