double factorial(int n){
    double result=1;
    if(n==0){
        return 1;
    }
    for (int i=1;i<=n;i++){
        result*=i;
    }
    return result;
}
void print(int n){
    Console.WriteLine("N"+" "+" "+" "+" "+"N!" );
    for(int i=0;i<15;i++){
        Console.Write("-");

    }
    Console.WriteLine();
    for(int i=1;i<=n;i++){
        Console.WriteLine(i+" "+" "+" "+" "+factorial(i));
    }
}
void main(){
    print(6);
}
main();