void cone(int n){
    if (n%2==1){
        for (int i = 0; i < n / 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("^");
        for (int i = 1; i <= n / 2; i++)
            {
                for (int j = 0; j < (n / 2) - i; j++)
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
void main(){
    int n=7;
    cone(n);
}
main();