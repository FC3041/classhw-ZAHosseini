void quadratic(int A,int B,int C){
    double c=0;
    double v=0;
    double z=(B*B)-4*(A*C);
    if (z<0){
        return;
    }
    if(z==0){
        C=(-B)/(2*A);
        v=(-B)/(2*A);
    }
    if(z>0){
        c=((-B)+Math.Sqrt(z))/(2*A);
        v=((-B)-Math.Sqrt(z))/(2*A);
    }
    Console.WriteLine(c);
    Console.WriteLine(v);

}
void main(){
    quadratic(3,2,4);
}
main();