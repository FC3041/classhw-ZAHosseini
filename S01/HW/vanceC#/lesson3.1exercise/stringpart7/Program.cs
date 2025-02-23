
string strsecond(string str){
    int size =str.Length;
    string news="";
    for(int i=0;i<size;i++){
        if(str[i]!=',' && str[i]!=':' && str[i]!='.' && str[i]!=' '){
            news+=str[i];
        }
    }
    return news.ToLower();
}
bool palindrom(string strs){
    string newstr="";
    int size=strs.Length;
    for(int i=size-1;i>=0;i--){
        newstr+=strs[i];

    }
    for(int i=0;i<size;i++){
        if(strs[i]!=newstr[i]){
            return false;
        }
        
    }
    return true;
}
void main(){
    string str="A man, a plan, a canal: Panama.";
    string strs =strsecond(str);
    Console.WriteLine(palindrom(strs));
}
main();