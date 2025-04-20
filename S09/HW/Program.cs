namespace HW;

class Program
{
    static void Main(string[] args)
    {
        if(args[0]=="register"){
            Student sc = Student.Parse(args);
            File.AppendAllLines("List.csv", new string[]{sc.ToString()});
            

        }
        else if(args[0]=="List"){
            string[] lines = File.ReadAllLines("List.csv");
            foreach(var line in lines)
            {
                string []parts=line.Split(',');
                var ListOfStudent = Student.Parse2(parts);
                System.Console.WriteLine($"name: {ListOfStudent.name}");
                System.Console.WriteLine($"family: {ListOfStudent.family}");
                System.Console.WriteLine($"StdID: {ListOfStudent.stdid}");
                System.Console.WriteLine($"credits: {ListOfStudent.credits}");
            }
        }
        
      
    }
}
