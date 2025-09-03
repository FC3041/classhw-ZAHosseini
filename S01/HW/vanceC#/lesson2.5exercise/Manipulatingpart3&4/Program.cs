long factorial(int n){
    long result=1;
    for(int i=1;i<=n;i++){
        result*=i;
    }
    return result;
}

void main(){
    int n=20;
    Console.WriteLine(factorial(n));
}
main();