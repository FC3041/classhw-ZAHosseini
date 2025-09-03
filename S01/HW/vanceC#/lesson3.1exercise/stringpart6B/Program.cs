bool palindrom(string str){
    string newstr="";
    int size=str.Length;
    for(int i=size-1;i>=0;i--){
        newstr+=str[i];

    }
    for(int i=0;i<size;i++){
        if(str[i]!=newstr[i]){
            return false;
        }
        
    }
    return true;
}
void main(){
    string str="kook";
    Console.WriteLine(palindrom(str));
}
main();