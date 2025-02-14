using System.Security.Cryptography.X509Certificates;

double power(double x,double y){
    double result=1;
    for(int i=0;i<y;i++){
        result*=x;
    }
    return result;
}

void root(int x,int n,double p){
    double start=0;
    double final=x;
    double mid=(start+final)/2;
    while(Math.Abs(power(mid,n)-x)>p){
        if(power(mid,n)<x){
            start=mid;
        }
        else{
            final=mid;
        }
        mid=(start+final)/2;

    }
    Console.WriteLine(mid);
}
void main(){
    root(16,4,0.000001);
}
main();