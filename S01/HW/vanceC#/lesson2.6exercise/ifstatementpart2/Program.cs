void main(){
    for(int i=0;i<21;i++){
        Console.WriteLine();
        if (i%2==1){
            for(int j=1;j<=i+1;j++){
            Console.Write("%");
            }

        }
        if (i%2==0){
            for(int j=1;j<=i+1;j++){
            Console.Write("*");
            }

        }
        
       
    }

}
main();