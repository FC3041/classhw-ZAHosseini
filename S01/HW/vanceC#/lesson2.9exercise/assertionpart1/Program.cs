long factorial(int n){
    long result=1;
    if (n==0){
        return 1;
    }
    else if(n>0){
        for (int i=1;i<=n;i++){
            result*=i;
        }
        return result;
    }
    else{
        return -1;
    }
}
void main(){
    int n=-10;
    int a=10;
    Console.WriteLine(factorial(n));
    Console.WriteLine(factorial(a));
}
main();