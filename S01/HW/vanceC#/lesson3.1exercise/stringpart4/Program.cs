void replace(string str,string searchStr,string replaceStr){
    for(int i=0;i<=str.Length-searchStr.Length;i++){
        for(int j=0;j<searchStr.Length;j++){
            if (str[i+j]==searchStr[j]){
                str[i+j]=replaceStr[j];
            }

        }
    
    }
    Console.WriteLine(str);
    
}
void main(){

    replace("hello world","hello","hi");
}
main();