using System.ComponentModel;

void square_root(int x,double p){
    double lower=0;
    double upper=x;
    double count=0;
    double x_1;
    double x_2;
    double mid=(upper+lower)/2;
    double k=upper-lower;
    if(Math.Abs(k)>=p){
        if (x>=0){
            x_1=Math.Sqrt(x);
            x_2=-1*Math.Sqrt(x);
            if(lower*lower <x && x<upper*upper){
                Console.WriteLine(x_1);
                Console.WriteLine(x_2);

            }
        }
        else if(mid*mid<x){
            lower=mid;
        }
        else{
            upper=mid;
        }
        count+=1;
       
    }
    Console.WriteLine(mid);
    Console.WriteLine(count);
}
void main(){
    square_root(2,0.000001);
}
main();