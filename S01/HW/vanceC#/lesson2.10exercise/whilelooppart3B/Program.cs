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
    return sum+1;
}
double exp2(double x,double p){
    double first_n=1;
    double result=1;
    double n=1;
    while (Math.Abs(first_n)>p){
        first_n*=x/n;
        result+=first_n;
        n+=1;

    }
    return result;
}
bool abs_near(double x,double y,double closness){
    double max=0;
    if(x>y){
        max=x;
    }
    else if(y>x){
        max=y;
    }
    double c=closness*max;
    if(Math.Abs(x-y)<=c){
        return true;
    }
    else{
        return false;
    }

}

void main(){
    int x=1;
    double p=0.000001;
    double a=exp(x,p);
    double b=exp2(x,p);
    Console.WriteLine(abs_near(a,b,0.001));
}

main();


