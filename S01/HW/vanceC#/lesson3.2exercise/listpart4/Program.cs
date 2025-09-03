using System;
namespace listpart4;

public static class Program
{
    public static bool is_multiple(int []triple1,int[] triple2){
        if(triple2[0]==2*triple1[0] && triple2[1]==2*triple1[1] && triple2[2]==2*triple1[2]){
            return true;
        }
        return false;
    }
    static void Main()
    {
        int[] triple1={3, 4, 5};
        int[] triple2={6 ,8 ,10};
        Console.WriteLine(is_multiple(triple1,triple2));
      
    }
}
