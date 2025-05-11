using System;
namespace listpart3B;

public class Program
{
    public static (int,int,int)[] pythagorean(int n){
        int count=0;
        double square;
        int c;
        for(int a=1;a<n;a++){
            for(int b=a;b<n;b++){
                square=a*a + b*b;
                c=(int)Math.Sqrt(square);
                if(c<n && square==c*c){
                    count++;
                }
            }
        }
        (int,int,int) [] arr=new (int,int,int)[count];
        int index=0;
        for(int a=1;a<n;a++){
            for(int b=a;b<n;b++){
                square=a*a + b*b;
                c=(int)Math.Sqrt(square);
                if(c<n && square==c*c){
                    arr[index]=(a,b,c);
                    index++;
                }
            }
        }
        return arr;
    }
    static void Main()
    {   int n=100;
        var arr2=pythagorean(n);
        foreach(var arr in arr2){
            Console.WriteLine(arr);

        }

        
    }
}
