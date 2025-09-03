void pad_char(string s,int size,string padchar){
    
    string str="";
    int len=s.Length;
    int pad_len=size-len;
    if(padchar.Length!=1){
        Console.WriteLine("uncorrect");
    }
    for(int i=0;i<pad_len;i++){
        str+=padchar;

    }
    str+=s;
    Console.WriteLine(str);

}
void main(){
    string s="hello";
    int size=10;
    string padchar="*";
    pad_char(s,size,padchar);
}
main();