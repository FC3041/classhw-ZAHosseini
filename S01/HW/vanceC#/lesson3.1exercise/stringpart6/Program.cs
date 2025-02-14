void table(int n){
    for (int i = 0; i < n; i++)
        {
            Console.Write("-----+");
        }
        Console.WriteLine();
        Console.Write("# ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write($" {i,2} |");
        }
        Console.WriteLine();

        Console.Write("=====+");
        for (int i = 0; i < n; i++)
        {
            Console.Write("=====+");
        }
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{i,2} #");
            for (int j = 1; j <= n; j++)
            {
                Console.Write($" {i * j,3} |");
            }
            Console.WriteLine();
            Console.Write("-----+");
            for (int k = 0; k < n; k++)
            {
                Console.Write("-----+");
            }
            Console.WriteLine();
    }
}

table(10);