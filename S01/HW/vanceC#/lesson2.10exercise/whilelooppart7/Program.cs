void ln(int x,double p){
    double start=0;
    double final=x;
    double mid=0;
    if(x<=0){
        Console.WriteLine("uncorroct");
    }
    while(Math.Abs(final-start)>=p){
        mid=(start+final)/2;
        if(Math.Exp(mid)<x){
            start=mid;

        }
        else{
            final=mid;
        }
        
    }
    Console.WriteLine(mid);
}
void main(){
    ln(10,0.0001);

}
main();