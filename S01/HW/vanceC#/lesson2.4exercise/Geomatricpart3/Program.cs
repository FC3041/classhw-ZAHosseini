void main(){
    var c=" ";
    for(int i=0;i<21;i++){
        Console.WriteLine();
        for(int j=1;j<=20-i;j++){
            Console.Write(" ");
        }
        for(int m=1;m<=i+1;m++){
            Console.Write("*");
        }
       
    }
}
main();
