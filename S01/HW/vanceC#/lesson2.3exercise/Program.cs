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
    for(int i=0;i<6;i++){
        Console.WriteLine("+*******+");
    }
}

void main(){
    head();
    for(int i=0;i<4;i++){
        line();
        body();

    }
   
    head();
}
main();
