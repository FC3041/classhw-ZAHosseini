void Triple(int A,int B,int C){
    int max=A;
    int middle=B;
    int min=C;
    if(C<100 && A<100 && B<100){
        if(C>A && C>B){
            max=C;
            middle=B;
            min=A;
        }
        else if(B>A && B>C){
            max=B;
            middle=A;
            min=C;
        }
    }
    if(A*A+ B*B ==C*C){
        Console.Write(A+ ",");
        Console.Write(B +",");
        Console.Write(C);
    }
}

void main(){
    int a=3;
    int b=4;
    int c=5;
    Triple(a,b,c);
}
main();