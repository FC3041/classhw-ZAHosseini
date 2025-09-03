namespace HW;

class Program
{
    static void Main(string[] args)
    {
         ICar[] cars = new ICar[]{
            new Pride(3.8, 1.4,4),
            new Pars(4.3,1.8,4),
            new Samand(4.5,1.7,4)
           
        };
        for (int i=0;i<cars.Length;i++){
            System.Console.WriteLine(cars[i].Size().ToString());
            System.Console.WriteLine(cars[i].Passenger().ToString());
        }
    }
}
