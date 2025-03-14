void cone(int n){
    for(int m=1;m<=9;m++){
        if (m%2==1){
            for (int i = 0; i < m/ 2; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("^");
            for (int i = 1; i <= m/ 2; i++)
                {
                    for (int j = 0; j < (m / 2) - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("|");

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("\\");
                    }
                    Console.WriteLine();
            
            }
        }
    }
    

}
void main(){
    int n=9;
    cone(n);
}
main();