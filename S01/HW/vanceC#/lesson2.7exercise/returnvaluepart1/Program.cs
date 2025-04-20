int absolute(int x){
    int result=0;
    if(x>=0){
        result=x;
    }
    else{
        result=(-1)*x;
    }
    return result;
}
void main(){
    int x=-100;
    int a=-1;
    int b=1;
    int c=0;
    Console.WriteLine(absolute(x));
    Console.WriteLine(absolute(a));
    Console.WriteLine(absolute(b));
    Console.WriteLine(absolute(c));


}
main();