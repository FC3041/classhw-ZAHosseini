void leapyear(int n){

    if(n%4==0 && n%100!=0){
        Console.WriteLine("True");
    }
    else{
        Console.WriteLine("False");

    }
}
void main(){
    
    leapyear(1792);
    leapyear(1796);
    leapyear(1900);
    leapyear(1904);
    leapyear(2004);

}
main();