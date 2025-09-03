using System.Net.Security;
using System.Runtime.InteropServices;

namespace HW;

class Program
{

    public static void reverse2(string str){
        string newWord="";
        string finall="";
        List<string> reverse=new List<string>();
        int size=str.Length;
        for(int i=0;i<size;i++){
            newWord+=str[i];
            if(str[i]==Convert.ToChar(" ")){
                reverse.Add(" "+newWord);
                newWord="";
            }
            
        }
        reverse.Add(newWord);
        int len= Convert.ToInt32(reverse.Count / 2);
        for(int i=0;i<len;i++){
            string temp=reverse[i];
            reverse[i]=reverse[reverse.Count-i-1];
            reverse[reverse.Count-i-1]=temp;
        }
        foreach(string c in reverse){
            finall+=c;
        }
        System.Console.WriteLine(finall);
        
        

    }
    public static void reverseAll(string s,out string str){
        str="";
        for (int i = s.Length - 1; i >= 0 ; i--)
        {
            str+=s[i];
            
        }
    }

    static void Main(string[] args)
    {
        string str = "Hi Im Zahra";
        reverse2(str);
        string sentence="Hi Im Zahra";
        string str2;
        reverseAll(sentence,out str2);
        System.Console.WriteLine(str2);

      
    }
}
