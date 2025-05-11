using System;
namespace listpart1{
    public class Program
    {   
        static void calculator(){
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            int num3=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[] {num1,num2,num3};
            Console.WriteLine(string.Join(", ", arr));
            
            
    
        }
        static void Main(string[] args)
        {
            calculator();
           
        }
    }


}

