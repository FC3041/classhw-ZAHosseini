using System;
namespace listpart6;

public class Program
{
    public static (int, int, int)[] remove((int, int, int)[] arr)
    {
        int size = arr.Length;
        (int, int, int)[] newarr = new (int, int, int)[size];
        int size2 = 0;

        for (int i = 0; i < size; i++)
        {
            bool check = false;
            for (int j = 0; j < size2; j++)
            {
                if (arr[i].Equals(newarr[j]))
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                newarr[size2] = arr[i];
                size2++;
            }

        }
        (int, int, int)[] finalArr = new (int, int, int)[size2];
        Array.Copy(newarr, finalArr, size2);

        return finalArr;
    }
    public static void Main()
    {
        (int, int, int)[] arr = { (3, 4, 5), (6, 8, 10), (3, 4, 5) };
        var result = remove(arr);
        foreach (var item in result)
        {
            Console.WriteLine(item); 
        }

    }
}
