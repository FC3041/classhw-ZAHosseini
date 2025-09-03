int triangle(char c){
    for(int i=0;i<21;i++){
        Console.WriteLine();
        for(int j=1;j<=i+1;j++){
            Console.Write(c);
        }
       
    }
    return 0;

}
void main(){
    char c='+';
    triangle(c);
}
main();