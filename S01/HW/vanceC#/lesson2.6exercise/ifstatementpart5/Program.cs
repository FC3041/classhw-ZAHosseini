void print_month(int n){
    string[] months={"january","february","march","april","may","june","july","agust","september","october","november","december"};
    Console.WriteLine(months[n-1]);
}

void main(){
    int n=3;
    print_month(n);

}
main();