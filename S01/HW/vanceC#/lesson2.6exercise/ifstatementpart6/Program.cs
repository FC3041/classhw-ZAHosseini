void ComputeChange(int n){
    if(n>=100){
        return;
    }
    int quarter=(n/25);
    n=n%25;
    int dime = (n/10);
    n=n%10;
    int nickel=(n/5);
    n=n%5;
    int penny=(n/1);
    Console.WriteLine(quarter);
    Console.WriteLine(dime);
    Console.WriteLine(nickel);
    Console.WriteLine(penny);
}
void main(){
    int n=8;
    ComputeChange(n);
}
main();