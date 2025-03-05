using System;
namespace listpart5;

public static class Program
{
    public static bool list(int triple, int[]tripleList){
        int len=tripleList.Length;
        for(int i=0;i<len;i++){
            if(tripleList[i]==triple){
                return true;
            }
            
        }
        return false;


    }
    static void Main()
    {
        int[] tripleList={1,2,3,4,5};
        int triple=3;
        Console.WriteLine(list(triple,tripleList));
        
    }
}
