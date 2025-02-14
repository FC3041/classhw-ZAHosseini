using System.ComponentModel.Design;

double power(double a,int b){
    
    double result=1;
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

double degreeToradian( double degree){
    return degree*(Math.PI/180);
}
double sin(double x,double p){
    double radian=degreeToradian(x);
    double result=0;
    int n=0;
    double term=0;
    while(Math.Abs(term)>p){
        term=power(-1,n)*power(radian,2*n+1) / factorial(2*n+1);
        result+=term;
        n+=1;
    }
    return result;

}
void main(){
    Console.WriteLine(sin(45,1e-10));
}
main();