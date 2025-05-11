void firstavg(int n){
    int sum=0;
    float a=0;
    for(int i=0;i<n+1;i++){
        sum+=i;
    }
    a=sum/n;
    Console.WriteLine(a);

}
void secondavg(int n){
    int sum=0;
    float b=0;
    for(int i=1;i<n;i++){
        sum+=i;
    }
    b=sum/n;
    Console.WriteLine(b);
}

void main(){
    int first=5;
    int second=4;
    firstavg(first);
    secondavg(second);
}
main();