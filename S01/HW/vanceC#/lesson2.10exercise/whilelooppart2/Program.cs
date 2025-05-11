long power(int a,int b){
    long result=1;
    for (int i=0;i<b;i++){
        result*=a;
    }
    return result;
}

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

double exp(int x,double p){
    double sum=0;
    int y=1;
    double e=1;
    while(e>p){
        e =power(x,y)/factorial(y);
        sum+=e;
        y+=1;
    }
    return sum;
}
void main(){
    int x=1;
    double p=0.000001;
    Console.WriteLine(exp(x,p));
}
main();