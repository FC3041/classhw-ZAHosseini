int fibonaci(int n){
    int total=0;
    if(n==0){
        return 1;
    }
    if(n==1){
        return 1;
    }
    for(int i=2;i<=n;i++){
        total=fibonaci(n-1)+fibonaci(n-2);
    }
    return total;
}
void main(){
    int n=3;
    Console.WriteLine(fibonaci(n));
}
main();