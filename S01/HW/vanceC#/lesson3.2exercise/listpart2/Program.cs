using System;
namespace listpart2;

static class Program
{
    
    
    static void calculator(int [] arr){
        int size=arr.Length;
        int count=0;
        int sum=0;
        int min=arr[0];
        int max=arr[0];
        for(int i=0;i<size;i++){
            count+=1;
            sum+=arr[i];
            if(arr[i]>max){
                max=arr[i];
            }
            if (arr[i]<min){
                min=arr[i];
            }
        }
        Console.WriteLine("count is "+count);
        Console.WriteLine("sum is "+sum);
        Console.WriteLine("max is "+max);
        Console.WriteLine("min is "+min); 

    }
    static void Main()
    {   
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int num3=Convert.ToInt32(Console.ReadLine());
        int[] arr=new int[] {num1,num2,num3};
        calculator(arr);
       
    }
}

    
