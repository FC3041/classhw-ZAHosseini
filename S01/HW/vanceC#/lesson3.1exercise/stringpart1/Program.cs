void repeat(string str,int n){
    
    for(int i=0;i<n;i++){
        Console.WriteLine(str);
    }
}
void main(){
    string chars="hello world";
    repeat(chars,4);
}
main();