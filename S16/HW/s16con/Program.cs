namespace s16con;

class Program
{
    static void Main(string[] args)
    {
        Citizen k = new Citizen("Kane", "Dave", 1, true);
        Student s = new Student(
            "Zari", "Hedayati", 2, "Math", 403521, false);
        Teacher t=new Teacher("Ahmad","Ahmadi",123,2000,10,true);
        GradStudent gs = new GradStudent(
            "Pari", "Hedayati", 2, "Math", 403521, false,
            "Calculus", "Integral");
        s.Register("Numericals");
        gs.Register("Numericals 2");
       
        System.Console.WriteLine( t.ToString());

    }
}
