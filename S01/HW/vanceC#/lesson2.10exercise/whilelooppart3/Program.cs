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

void main(){
    double x=1;
    double p=0.000001;
    Console.WriteLine(exp2(x,p));
}
main();