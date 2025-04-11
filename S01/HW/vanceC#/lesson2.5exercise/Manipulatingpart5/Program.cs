long power(int a,int b){
    long result=1;
    for(int i=0;i<b;i++){
        result*=a;
    }
    return result;
}
void main(){
    int a=2;
    int b=3;
    Console.WriteLine(power(a,b));
}
main();