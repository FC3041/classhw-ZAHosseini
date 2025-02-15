double factorial(int n){
    double result=1;
    if (n==0){
        return 1;
    }

    for (int i=1;i<=n;i++){
        result*=i;
    }
    return result;
    
}

double eulers_constant(int n){
    double sum=0;
    for(int i=0;i<+n;i++){
        sum+=1/factorial(i);
    }
    return sum;
}
void main(){
    int n=5;
    Console.WriteLine(eulers_constant(n));
}
main();