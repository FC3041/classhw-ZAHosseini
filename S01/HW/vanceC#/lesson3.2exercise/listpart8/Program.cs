using System;
namespace listpart8;

public class Program
{
    public static int calculator(){
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int num3=Convert.ToInt32(Console.ReadLine());
        string str1=Console.ReadLine();
        string str2=Console.ReadLine();
        int result=0;
        if(str1=="+"){
            result=num1+num2;
        }
        else if(str1=="*"){
            result=num1*num2;
        }
        else if(str1=="-"){
            result=num1-num2;
        }
        else if(str1=="/"){
            result=num1/num2;
        }
        
        if(str2=="+"){
            return result+num3;
        }
        else if(str2=="*"){
            return result*num3;
        }
        else if(str2=="-"){
            return result-num3;
        }
        else if(str2=="/"){
            return result/num3;
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
