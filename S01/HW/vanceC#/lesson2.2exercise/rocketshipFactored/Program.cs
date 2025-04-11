void head(){
    Console.WriteLine("    ^    ");
    Console.WriteLine("   /|\\   ");
    Console.WriteLine("  //|\\\\  ");
    Console.WriteLine(" ///|\\\\\\ ");

}
void line(){
    Console.WriteLine("+-------+");

}
void body(){
    for(int i=0;i<4;i++){
        Console.WriteLine("+*******+");
    }
}

void main(){
    head();
    line();
    body();
    line();
    body();
    head();
}
main();
